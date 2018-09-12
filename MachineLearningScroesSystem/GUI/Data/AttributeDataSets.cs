using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Python.Runtime;

namespace WindowsFormsApp.Data
{
    class AttributeDataSets
    {
        PyObject _attributes;
        Dictionary<string, DataSet> _datasets;

        public AttributeDataSets(PyObject attributes)
        {
            Attributes = attributes;
            DataSets = new Dictionary<string, DataSet>();
        }

        public PyObject Attributes { get => _attributes; set => _attributes = value; }
        public Dictionary<string, DataSet> DataSets { get => _datasets; set => _datasets = value; }
    }
}
