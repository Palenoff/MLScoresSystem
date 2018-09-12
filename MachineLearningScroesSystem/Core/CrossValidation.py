#Загрузка данных
import BitSetConvertor.BitSetConvertor as bsc


#Работа метода машинного обучения

from sklearn.linear_model import LogisticRegression
from sklearn.naive_bayes import GaussianNB
from sklearn.neighbors import KNeighborsClassifier
from sklearn.tree import DecisionTreeClassifier
from sklearn.svm import SVC
from sklearn.ensemble import RandomForestClassifier
from sklearn.neural_network import MLPClassifier
from JSM.JSM import JSMClassifier
from sklearn.model_selection import cross_validate, GroupKFold, GroupShuffleSplit, KFold, LeaveOneGroupOut, LeaveOneOut, LeavePGroupsOut, LeavePOut, ShuffleSplit, StratifiedKFold, StratifiedShuffleSplit

def GetCVObject(type, **kwargs):
    if (type == 'KFold'):
        return KFold(**kwargs)
    elif (type == 'StratifiedKFold'):
        return StratifiedKFold(**kwargs)
    elif (type == 'GroupKFold'):
        return GroupKFold(**kwargs)
    elif (type == 'ShuffleSplit'):
        return ShuffleSplit(**kwargs)
    elif (type == 'StratifiedShuffleSplit'):
        return StratifiedShuffleSplit(**kwargs)
    elif (type == 'GroupShuffleSplit'):
        return GroupShuffleSplit(**kwargs)
    elif (type == 'LeaveOneOut'):
        return LeaveOneOut()
    elif (type == 'LeavePOut'):
        return LeavePOut(**kwargs)
    elif (type == 'LeaveOneGroupOut'):
        return LeaveOneGroupOut()
    elif (type == 'LeavePGroupsOut'):
        return LeavePGroupsOut(**kwargs)

def GetEstimator(estimator, **kwargs):
        if (estimator=='LogisticRegression'):
            return LogisticRegression(**kwargs)
        elif (estimator=='GaussianNB'):
            return GaussianNB(**kwargs)
        elif (estimator=='KNeighbors'):
            return KNeighborsClassifier(**kwargs)
        elif (estimator=='DecisionTree'):
            return DecisionTreeClassifier(**kwargs)
        elif (estimator=='RandomForest'):
            return RandomForestClassifier(**kwargs)
        elif (estimator=='SVC'):
            return SVC(**kwargs)
        elif (estimator=='MLP'):
            return MLPClassifier(**kwargs)
        elif (estimator=='JSM'):
            return JSMClassifier(**kwargs)


def cross_validation(model, X, y, groups, attributes, CVObject):
    #Возможные параметры:
    #['accuracy', 'adjusted_mutual_info_score', 'adjusted_rand_score', 'average_precision', 
    #'completeness_score', 'explained_variance', 
    #'f1', 'f1_macro', 'f1_micro', 'f1_samples', 'f1_weighted', 'fowlkes_mallows_score', 
    #'homogeneity_score', 'mutual_info_score', 
    #'neg_log_loss', 'neg_mean_absolute_error', 'neg_mean_squared_error', 'neg_mean_squared_log_error',
    #'neg_median_absolute_error', 'normalized_mutual_info_score',
    #'precision', 'precision_macro', 'precision_micro', 'precision_samples', 'precision_weighted', 
    #'r2', 'recall', 'recall_macro', 'recall_micro', 'recall_samples', 'recall_weighted', 
    #'roc_auc', 'v_measure_score'] 
    attributes_copy = {}
    if model == "JSM":
        attributes_copy, y = bsc.toBistet_y(y,attributes)
    else:
        attributes_copy = attributes
    PrecisionAvgAttributes = []
    RecallAvgAttributes = []
    F1ScoreAvgAttributes = []
    Precision = 0
    Recall = 0
    F1Score = 0
    X = bsc.factorize_X(attributes_copy, X) if model != "JSM" else X
    for outputattribute in attributes_copy["outputattributes"]:
        y_attribute = bsc.factorize_y(attributes_copy, y[outputattribute])
        scores = cross_validate(GetEstimator(model,**{"attributes":attributes_copy} if model == "JSM" else {}), X, y_attribute, groups, ('precision_weighted', 'recall_weighted', 'f1_weighted'), CVObject, return_train_score = False)
        PrecisionSumFold = 0
        RecallSumFold = 0
        F1scoreSumFold = 0
        for i in range(len(scores['score_time'])):
            PrecisionSumFold = PrecisionSumFold + scores['test_precision_weighted'][i] #+ scores['train_precision_weighted'][i] #сумма точностей по фолдам
            RecallSumFold = RecallSumFold + scores['test_recall_weighted'][i] #+ scores['train_recall_weighted'][i] #сумма полнот по фолдам
            F1scoreSumFold = F1scoreSumFold + scores['test_f1_weighted'][i] #+ scores['train_f1_weighted'][i] #сумма F-мер по фолдам
        PrecisionAvgAttributes.append(PrecisionSumFold / len(scores['score_time'])) #вычисление средней точности атрибута (=сумма точностей фолдов / количество разбиений)
        RecallAvgAttributes.append(RecallSumFold / len(scores['score_time'])) #вычисление средней полноты атрибута (=сумма полнот фолдов / количество разбиений)
        F1ScoreAvgAttributes.append(F1scoreSumFold / len(scores['score_time'])) #вычисление средней F-меры атрибута (=сумма F-мер фолдов / количество разбиений)

    for PrecisionAvgAttribute in PrecisionAvgAttributes:
        Precision = Precision + PrecisionAvgAttribute
    Precision = Precision / len(attributes_copy["outputattributes"]) #вычисление средней точности (=сумма средних точностей атрибутов / количество выходных атрибутов)
    for RecallAvgAttribute in RecallAvgAttributes:
        Recall = Recall + RecallAvgAttribute
    Recall = Recall / len(attributes_copy["outputattributes"]) #вычисление средней полноты (=сумма средних полнот атрибутов / количество выходных атрибутов)
    for F1ScoreAvgAttribute in F1ScoreAvgAttributes: 
        F1Score = F1Score + F1ScoreAvgAttribute
    F1Score = F1Score / len(attributes_copy["outputattributes"]) #вычисление средней F-меры (=сумма средних F-мер атрибутов / количество выходных атрибутов)
    return {"Precision":Precision, "Recall":Recall, "F1Score":F1Score}