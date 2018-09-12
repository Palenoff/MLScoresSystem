using Python.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp.CrossValidation;

namespace WindowsFormsApp
{
    public class CrossValidationSet
    {
        PyString _estimator;
        string _estimatorname;
        string _datasetname;
        PyObject _dataset;
        PyInt _rowstart;
        PyInt _rowfinish;
        PyObject _attributes;
        PyString _cv;
        PyDict _cvparams;
        PyObject _pymodule;

        public CrossValidationSet(string estimator, string estimatorname, string datasetname, PyObject dataset, int rowstart, int rowfinish, PyObject attributes, CVObject cvObject, PyObject PyModule)
        {
            Estimator = new PyString(estimator);
            EstimatorName = estimatorname;
            DatasetName = datasetname;
            Dataset = dataset;
            Rowstart = new PyInt(rowstart);
            Rowfinish = new PyInt(rowfinish);
            Attributes = attributes;
            CV = new PyString(cvObject.Type);
            CVparams = new PyDict();
            if (cvObject.N_groups != 0)
                CVparams["n_groups"] = new PyInt(cvObject.N_groups);
            if (cvObject.N_splits != 0)
                CVparams["n_splits"] = new PyInt(cvObject.N_splits);
            if (cvObject.P != 0)
                CVparams["p"] = new PyInt(cvObject.P);
            if (cvObject.Shuffle)
                CVparams["shuffle"] = true.ToPython();
            if (cvObject.Train_size != null)
            {
                if (cvObject.Train_size.GetType().Name == "Int32")
                    CVparams["train_size"] = new PyInt((int)cvObject.Train_size);
                if (cvObject.Train_size.GetType().Name == "Double")
                    CVparams["train_size"] = new PyFloat((double)cvObject.Train_size);
            }
            if (cvObject.Test_size != null)
            {
                if (cvObject.Test_size.GetType().Name == "Int32")
                    CVparams["test_size"] = new PyInt((int)cvObject.Test_size);
                if (cvObject.Test_size.GetType().Name == "Double")
                    CVparams["test_size"] = new PyFloat((double)cvObject.Test_size);
            }
            _pymodule = PyModule;
        }

        public PyString Estimator { get => _estimator; set => _estimator = value; }
        public string EstimatorName { get => _estimatorname; set => _estimatorname = value; }
        public string DatasetName { get => _datasetname; set => _datasetname = value; }
        public PyObject Dataset { get => _dataset; set => _dataset = value; }
        public PyInt Rowstart { get => _rowstart; set => _rowstart = value; }
        public PyInt Rowfinish { get => _rowfinish; set => _rowfinish = value; }
        public PyObject Attributes { get => _attributes; set => _attributes = value; }
        public PyString CV { get => _cv; set => _cv = value; }
        public PyDict CVparams { get => _cvparams; set => _cvparams = value; }

        public (double Precision, double Recall, double F1score) CrossValidate()
        {
            PyObject results;
            using (Py.GIL())
            {
                results = _pymodule.InvokeMethod("CrossValidation", new PyObject[] { Estimator, Dataset, Rowstart, Rowfinish, Attributes, CV, CVparams });
            }
            double Precision = Double.Parse(results["Precision"].Repr().Replace(".", ","));
            double Recall = Double.Parse(results["Recall"].Repr().Replace(".", ","));
            double F1score = Double.Parse(results["F1Score"].Repr().Replace(".", ","));
            return (Precision: Precision, Recall: Recall, F1score: F1score);
        }
    }
}
