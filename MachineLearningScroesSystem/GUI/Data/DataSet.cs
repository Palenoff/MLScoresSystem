using Python.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp.Data
{
    public class DataSet
    {
        PyObject _dataset;
        int _start;
        int _finish;
        int _max;
        bool _tocrossvalidate;

        public DataSet(PyObject dataset, int start, int finish)
        {
            Dataset = dataset;
            Start = start;
            Finish = finish;
            _max = finish;
            ToCrossValidate = false;
        }

        public PyObject Dataset { get => _dataset; set => _dataset = value; }
        public int Start { get => _start; set => _start = value; }
        public int Finish { get => _finish; set => _finish = value; }
        public bool ToCrossValidate { get => _tocrossvalidate; set => _tocrossvalidate = value; }
        public int Max { get => _max; }
    }
}
