import pandas as pd

def toBinary_y(OpredictedPlus, X):
    i = 0
    y = []
    default = 0 #костыль - значение, которое записывается в выходной вектор, если пример противоречивый
    for i in range(len(X.index)):
        if X.index[i] in OpredictedPlus.keys():
            y.append(1)
        else:
            y.append(0)
    return pd.Series(y)

def GetAttributes(filename):
    dfattributes = pd.read_csv(filename,sep=None);
    inputdict = {}
    outputdict = {}
    groupdict = {}
    #binarykeys = []
    for i in range(len(dfattributes)):
        valuesstrings = dfattributes["values"][i].split("|") if not pd.isnull(dfattributes["values"][i]) else [];
        values=[]
        if dfattributes["type"][i] == "numeric":
            for val in valuesstrings:
                if val.find("->") != -1: #если новый бинарный атрибут представляет собой принадлежность к интервалу
                   tmplist = val.split("->")
                   intervalmin = tmplist[0].replace('"', "").replace("'", '').strip() #получение минимального числа из отрезка
                   intervalmax = tmplist[1].replace('"', "").replace("'", '').strip()
                   values.append([intervalmin,intervalmax])
                else:
                    values.append(val);
        else:
            values = valuesstrings
        if dfattributes["attribute_type"][i] == "input":
            inputdict[dfattributes["name"][i]] = {'type':dfattributes["type"][i], 'values':values}
        elif dfattributes["attribute_type"][i] == "output":
            outputdict[dfattributes["name"][i]] = {'type':dfattributes["type"][i], 'values':values}
        elif dfattributes["attribute_type"][i] == "group":
            groupdict[dfattributes["name"][i]] = {'type':dfattributes["type"][i], 'values':values}
        #if dfattributes["type"][i] != 'binary':
        #    for value in values:
        #        binarykeys.append(dfattributes["name"][i] + "=" + str(value))
        #else:
        #    binarykeys.append(dfattributes["name"][i]) 
    attrdict = {}
    attrdict["inputattributes"] = inputdict
    attrdict["outputattributes"] = outputdict
    if groupdict != {}:
        attrdict["groupattributes"] = groupdict
    return attrdict#{"binarykeys": binarykeys, "binaryattributes": {"inputattributes": inputdict, "outputattributes": outputdict}

def GetData(filename, attributes):
    df = pd.read_csv(filename, sep=None, header=0)
    datadict = {}
    datadict["inputdata"] = df[list(attributes["inputattributes"].keys())]
    datadict["outputdata"] = df[list(attributes["outputattributes"].keys())]
    if "groupattributes" in attributes.keys():
        datadict["groupdata"] = df[list(attributes["groupattributes"].keys())]
    return datadict    

def toBitset_X(dfrow,binaryattributes):
    positivekeys = []
    try:
        if type(binaryattributes["inputattributes"].keys()) is None:
                raise TypeError()
        for key in dfrow.index:
            if key not in binaryattributes["inputattributes"].keys():
                raise KeyError("Аттрибут не является входным")
            factval = dfrow.loc[key]
            if binaryattributes["inputattributes"][key]["type"] == "categorical":
                for value in binaryattributes["inputattributes"][key]["values"]:
                    if value == factval:
                        positivekeys.append(key + "=" + str(value))
                    else:
                        positivekeys.append("not_" + key + "=" + str(value))
            elif binaryattributes["inputattributes"][key]["type"] == "numeric":
                factval = float(factval)
                for value in binaryattributes["inputattributes"][key]["values"]:
                    if isinstance(value, list): #если новый бинарный атрибут представляет собой принадлежность к интервалу
                        if value[0] == "-inf": #от минус бесконечности до value[1]
                            if factval <= float(value[1]):
                               positivekeys.append(key + "=" + str(value))
                            else:
                                positivekeys.append("not_" + key + "=" + str(value))
                        elif value[1] == "inf": #от value[0] до плюс бесконечности
                            if factval >= float(value[0]):
                                positivekeys.append(key + "=" + str(value))
                            else:
                                positivekeys.append("not_" + key + "=" + str(value))
                        else: #от value[0] до value[1]
                            if factval >= float(value[0]) and factval <= float(value[1]):
                                positivekeys.append(key + "=" + str(value))
                            else:
                                positivekeys.append("not_" + key + "=" + str(value))
                    else: #если новый бинарный атрибут представляет собой равенство числу
                        if float(value) == factval:
                            positivekeys.append(key + "=" + str(value))
                        else:
                            positivekeys.append("not_" + key + "=" + str(value))
            elif binaryattributes["inputattributes"][key]["type"] == "binary":
                if factval == "yes" or factval == 1 or factval == True:
                    positivekeys.append(key)
                else:
                    positivekeys.append("not_" + key)

    except TypeError as err:
            return err.args
    except KeyError as err:
        return err.args
    return set(positivekeys)

def toBistet_y(y,binaryattributes):
    binaryattributes_copy = {}
    y_copy = pd.DataFrame()
    binaryattributes_copy["inputattributes"] = binaryattributes["inputattributes"].copy()
    binaryattributes_copy["outputattributes"] = {}
    if "groupattributes" in binaryattributes.keys():
        binaryattributes_copy["groupattributes"] = binaryattributes["groupattributes"].copy()
    for key in binaryattributes["outputattributes"]:
        if binaryattributes["outputattributes"][key]["type"] == "binary":
            binaryattributes_copy["outputattributes"][key] = binaryattributes["outputattributes"][key]
            binaryattributes_copy["outputattributes"][key]["values"] = [0, 1]
            y_copy[key] = y[key]
        elif binaryattributes["outputattributes"][key]["type"] == "categorical":
            for value in binaryattributes["outputattributes"][key]["values"]:
                binaryattributes_copy["outputattributes"][key + "=" + value] = {}   
                binaryattributes_copy["outputattributes"][key + "=" + value]["type"] = "binary"
                binaryattributes_copy["outputattributes"][key + "=" + value]["values"] = [0, 1]
                valueslist = []
                for factval in y[key]:
                    valueslist.append(1 if factval == value else 0)
                y_copy[key + "=" + value] = pd.Series(valueslist)
        elif binaryattributes["outputattributes"][key]["type"] == "numeric":
            binaryattributes_copy["outputattributes"][key + "=" + value] = {}
            for value in binaryattributes["outputattributes"][key]["values"]:
                binaryattributes_copy["outputattributes"][key + "=" + value] = {}
                binaryattributes_copy["outputattributes"][key + "=" + value]["type"] = "binary"
                binaryattributes_copy["outputattributes"][key + "=" + value]["values"] = [0, 1]
                valueslist = []
                for factval in y[key]:
                    factval = float(factval)
                    if isinstance(value, list): #если новый бинарный атрибут представляет собой принадлежность к интервалу
                        if value[0] == "-inf": #от минус бесконечности до value[1]
                            valueslist.append(1 if factval <= float(value[1]) else 0)
                        elif value[1] == "inf": #от value[0] до плюс бесконечности
                            valueslist.append(1 if factval >= float(value[0]) else 0)
                        else: #от value[0] до value[1]
                            valueslist.append(1 if factval >= float(value[0]) and factval <= float(value[1]) else 0)
                    else: #если новый бинарный атрибут представляет собой равенство числу
                        valueslist.append(1 if float(value) == factval else 0)
                    y_copy[key + "=" + value] = pd.Series(valueslist)
    return binaryattributes_copy, y_copy

def factorize_X(attributes, X):
    multidimensioninput = len(attributes["inputattributes"]) > 1
    for key in attributes["inputattributes"]:
        if attributes["inputattributes"][key]["type"] == "categorical":
            X[key] = pd.factorize(X[key])[0]
        elif attributes["inputattributes"][key]["type"] == "binary":
            if attributes["inputattributes"][key]["values"] != ["0", "1"] and attributes["inputattributes"][key]["values"] != ["1", "0"]:
                X = X.replace({key:{"no":0,"No":0,"NO":0,"N":0,"n":0,"False":0,"false":0,"FALSE":0,"F":0,"f":0,"yes":1,"Yes":1,"YES":1,"Y":1,"y":1,"True":1,"true":1,"TRUE":1,"T":1,"t":1}})
    return X

def factorize_y(attributes, y):
    if attributes["outputattributes"][y.name]["type"] == "categorical":
        return pd.Series(pd.factorize(y)[0],name=y.name)
    elif attributes["outputattributes"][y.name]["type"] == "binary":
        if y.dtype.kind == "O":
            return y.replace({"no":0, "No":0, "NO":0,"N":0,"n":0,"False":0,"false":0,"FALSE":0,"F":0,"f":0,"yes":1,"Yes":1,"YES":1,"Y":1,"y":1,"True":1,"true":1,"TRUE":1,"T":1,"t":1})
        else:
            return y