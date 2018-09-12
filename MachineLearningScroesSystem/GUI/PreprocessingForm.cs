using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Python.Runtime;
using System.Text.RegularExpressions;

namespace WindowsFormsApp
{
    public partial class PreprocessingForm : Form
    {
        PyObject PyAttributes;
        public PreprocessingForm()
        {
            InitializeComponent();
        }

        public PreprocessingForm(PyObject pyAttributes)
        {
            PyAttributes = pyAttributes;
            InitializeComponent();
            if (PyAttributes == null)
                return;
            foreach (PyObject key in PyAttributes["inputattributes"])
            {
                DataGridViewRow dataGridViewRow = new DataGridViewRow();
                dataGridViewRow.CreateCells(KeysDataGridView);
                dataGridViewRow.Cells[0].Value = key.ToString();
                dataGridViewRow.Cells[1].Value = PyAttributes["inputattributes"][key]["type"].ToString() == "binary" ? "Бинарный" : PyAttributes["inputattributes"][key]["type"].ToString() == "numeric" ? "Числовой" : PyAttributes["inputattributes"][key]["type"].ToString() == "categorical" ? "Номинальный" : "";
                dataGridViewRow.Cells[2].Value = PyAttributes["inputattributes"][key]["values"].ToString();
                int before = KeysDataGridView.RowCount;
                KeysDataGridView.Rows.Add(dataGridViewRow);
                ResizeDataGridView(KeysDataGridView, before);
            }
            foreach (PyObject key in PyAttributes["outputattributes"])
            {
                DataGridViewRow dataGridViewRow = new DataGridViewRow();
                dataGridViewRow.CreateCells(KeysDataGridView);
                dataGridViewRow.Cells[0].Value = key.ToString();
                dataGridViewRow.Cells[1].Value = PyAttributes["outputattributes"][key]["type"].ToString() == "binary" ? "Бинарный" : PyAttributes["outputattributes"][key]["type"].ToString() == "numeric" ? "Числовой" : PyAttributes["outputattributes"][key]["type"].ToString() == "categorical" ? "Номинальный" : "";
                dataGridViewRow.Cells[2].Value = PyAttributes["outputattributes"][key]["values"].ToString();
                dataGridViewRow.Cells[3].Value = "True";
                int before = KeysDataGridView.RowCount;
                KeysDataGridView.Rows.Add(dataGridViewRow);
                ResizeDataGridView(KeysDataGridView, before);
            }
        }

        private void AddKeyButton_Click(object sender, EventArgs e)
        {
            //KeysDataGridView.Size.Height = 100; //=+ 20;
            int before = KeysDataGridView.RowCount;
            KeysDataGridView.Rows.Add();
            ResizeDataGridView(KeysDataGridView, before);
            ClearSelection();
        }

        private void RemoveKeyButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow DataGridViewRow in KeysDataGridView.SelectedRows)
            {
                int before = KeysDataGridView.RowCount;
                KeysDataGridView.Rows.Remove(DataGridViewRow);
                ResizeDataGridView(KeysDataGridView, before);
            }
        }

        public void ClearSelection()
        {
            KeysDataGridView.ClearSelection();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        public PyDict GetAttributes()
        {
            PyDict newInputDict = new PyDict();
            PyDict newOutputDict = new PyDict();
            for (int i = 0; i < KeysDataGridView.Rows.Count; i++)
            {
                string name = KeysDataGridView.Rows[i].Cells["NameTB"].Value.ToString();
                string type = KeysDataGridView.Rows[i].Cells["TypeCB"].Value.ToString() == "Бинарный" ? "binary" : KeysDataGridView.Rows[i].Cells["TypeCB"].Value.ToString() == "Числовой" ? "numeric" : KeysDataGridView.Rows[i].Cells["TypeCB"].Value.ToString() == "Номинальный" ? "categorical" : "";
                string values = KeysDataGridView.Rows[i].Cells["ValuesTB"].Value.ToString();
                string isOutput = KeysDataGridView.Rows[i].Cells["isOutputCB"].Value == null ? "False" : KeysDataGridView.Rows[i].Cells["isOutputCB"].Value.ToString();
                PyDict pyAttrLine = new PyDict();
                pyAttrLine["type"] = type.ToPython();
                PyList pyValues;
                using (Py.GIL())
                {
                    dynamic astmodule = Py.Import("ast");
                    dynamic eval = astmodule.literal_eval;
                    pyValues = new PyList(eval(values));
                }
                pyAttrLine["values"] = pyValues;
                if (isOutput == "False")
                    newInputDict[name] = pyAttrLine;
                else
                    newOutputDict[name] = pyAttrLine;
            }
            PyDict pyAttrs = new PyDict();
            pyAttrs["inputattributes"] = newInputDict;
            pyAttrs["outputattributes"] = newOutputDict;
            if (new PyDict(PyAttributes).HasKey("groupattributes"))
                pyAttrs["groupattributes"] = PyAttributes["groupattributes"];

            return pyAttrs;
        }

        protected void ResizeDataGridView(DataGridView dataGridView, int before)
        {
            if (dataGridView.Rows.Count < 11 && dataGridView.Rows.Count > before)
            {
                dataGridView.Height += 22;
            }
            if (dataGridView.Rows.Count < 11 && dataGridView.Rows.Count < before)
            {
                dataGridView.Height -= 22;
            }
            if (dataGridView.Rows.Count == 11 && dataGridView.Rows.Count > before)
            {
                dataGridView.Width += 17;
                dataGridView.ScrollBars = ScrollBars.Vertical;
            }
            if (dataGridView.Rows.Count == 11 && dataGridView.Rows.Count < before)
            {
                dataGridView.Width -= 17;
                dataGridView.ScrollBars = ScrollBars.None;
            }
        }
    }
}
