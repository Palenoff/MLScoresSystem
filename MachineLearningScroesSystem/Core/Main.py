import BitSetConvertor.BitSetConvertor as bsc
import CrossValidation as cv

def GetAttributes(filename):
    return bsc.GetAttributes(filename)

def GetData(filename, attributes):
    return bsc.GetData(filename,attributes)

def CrossValidation(estimator, data, rowstart, rowfinish, attributes, CV, CVparams):
    CVObject = cv.GetCVObject(CV, **CVparams)
    X = data["inputdata"][rowstart:rowfinish]
    y = data["outputdata"][rowstart:rowfinish]
    groups = data["groupdata"][rowstart:rowfinish] if "groupdata" in data.keys() else None
    return cv.cross_validation(estimator, X, y, groups, attributes, CVObject)