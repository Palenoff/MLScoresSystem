#Copyright (c) 2018 Oleg Anshakov, Kirill Palenov

from JSM import Norris
import BitSetConvertor.BitSetConvertor as bsc
import pandas as pd
from sklearn.base import BaseEstimator


class JSMClassifier(BaseEstimator):

    def __init__(self, attributes=None, extensional_threshold=2, intentional_threshold=1, createsimilarities_method=Norris.Norris):
        self.__attributes = attributes
        self.__extensional_threshold = extensional_threshold
        self.__intentional_threshold = intentional_threshold
        self.__createsimilarities_method = createsimilarities_method

    def __induction(self,OPlus,OMinus,BOC=False):
        # Порождение сходств
        CPCPlus=self.__createsimilarities(list(OPlus.values()))
        CPCMinus=self.__createsimilarities(list(OMinus.values()))
        # Фильтрация по мощности экстенсионала и интенсионала
        FCPCPlus=self.__fltration(CPCPlus)
        FCPCMinus=self.__fltration(CPCMinus)
        # Фальсификация
        # Возвращаем возможные причины
        self.__CPlus=self.__falsification(FCPCPlus,FCPCMinus,OMinus.values(),BOC)
        self.__CMinus=self.__falsification(FCPCMinus,FCPCPlus,OPlus.values(),BOC)


    def __createsimilarities(self, O):
        return self.__createsimilarities_method(O)

    def __fltration(self, CPC):
        Ext=0;Int=1
        L=[]
        for i in range(len(CPC)):
            if len(CPC[i][Ext])>=self.__extensional_threshold and len(CPC[i][Int])>=self.__intentional_threshold:
                L.append(CPC[i][Int])
        return L

    def __falsification(self,C1,C2,O,BOC=False):
        L=[]
        for a in C1:
            if BOC:
                if [o for o in O if a<=o]==[]:
                    L.append(a)
            else:
                if a not in C2:
                    L.append(a)
        return L

    def __analogy(self,OTau):
        OPlusPredicted = {}
        OMinusPredicted = {}
        OContraPredicted = {}
        for index in OTau:
            PlusCondition=([c for c in self.__CPlus if c<=OTau[index]]!=[])
            MinusCondition=([c for c in self.__CMinus if c<=OTau[index]]!=[])
            if PlusCondition and not MinusCondition:
                OPlusPredicted[index] = OTau[index];
            elif MinusCondition and not PlusCondition:
                OMinusPredicted[index] = OTau[index];
            elif PlusCondition and MinusCondition: 
                OContraPredicted[index] = OTau[index];
        return OPlusPredicted


    def get_params(self, deep=True):
        return {"attributes":self.__attributes, "extensional_threshold":self.__extensional_threshold, "intentional_threshold":self.__intentional_threshold,"createsimilarities_method":self.__createsimilarities_method}

    def set_params(self, **parameters):
        for parameter, value in parameters.items():
            setattr(self, parameter, value)
        return self
    
    def fit(self, X, y):
        OPlus={}
        OMinus={}
        OContra={}    
        try:
            if type(self.__attributes) is None:
                raise TypeError("Набор атрибутов не задан!")
            if len(X) != len(y):
                raise IndexError("Объём входной и выходной выборок не совпадают!")
            for i in range(len(y.index)):
                if y.iloc[i] == 1 or y.iloc[i] == "yes" or y.iloc[i] == True or y.iloc[i] == "True":
                    OPlus[X.index[i]] = bsc.toBitset_X(X.iloc[i],self.__attributes)
                else:
                    OMinus[X.index[i]] = bsc.toBitset_X(X.iloc[i],self.__attributes)
            if OPlus == {}:
                raise Exception("Множество положительных примеров пусто. ДСМ-метод не может продолжить работу!\nОбучающая выборка должна содержать как положительные, так и отрицательные примеры.")
            if OMinus == {}:
                raise Exception("Множество отрицательных примеров пусто. ДСМ-метод не может продолжить работу!\nОбучающая выборка должна содержать как положительные, так и отрицательные примеры.")
        except TypeError as err:
            return err.args
        except IndexError as err:
            return err.args
        except AssertionError as err:
            return err.args
        except Exception as err:
            return err.args
        self.__induction(OPlus, OMinus)
    
    def predict(self, X):
        OTau = {}
        for i in range(len(X.index)):
            OTau[X.index[i]] = bsc.toBitset_X(X.iloc[i],self.__attributes) 
        OPlusPredicted = self.__analogy(OTau)
        return bsc.toBinary_y(OPlusPredicted,X)