using Python.Runtime;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp.CrossValidation;
using WindowsFormsApp.Data;

namespace WindowsFormsApp
{
    public partial class MainForm : Form
    {
        Dictionary <string, AttributeDataSets> AttributeDataSets;
        CVObject cvObject;
        int initheightDataSetDataGridView, initwidthDataSetDataGridView;
        string olddatasetkey = "";
        PyObject PyModule;
        public MainForm()
        {
            InitializeComponent();
            AttributeDataSets = new Dictionary<string, AttributeDataSets>();
            initheightDataSetDataGridView = DataSetDataGridView.Height;
            initwidthDataSetDataGridView = DataSetDataGridView.Width;
            cvObject = new CVObject("KFold");
            using (Py.GIL())
            {
                PyModule = Py.Import("Main");
            }
        }

        private void LoadCSVAttributesFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Stream stream = null;
                OpenFileDialog OFD = new OpenFileDialog
                {
                    InitialDirectory = Directory.GetCurrentDirectory(),
                    Filter = "Данные, разделённые запятыми (*.csv)|*.csv|Все файлы (*.*)|*.*",
                    FilterIndex = 2,
                    RestoreDirectory = true,
                    Title = "Загрузить атрибуты"
                };
                if (OFD.ShowDialog() == DialogResult.OK)
                {
                    if ((stream = OFD.OpenFile()) != null)
                    {
                        if (Path.GetExtension(OFD.FileName) != ".csv")
                            throw new FileLoadException("Неверное расширение файла", OFD.FileName);
                        PyObject attributesPyObject;
                        using (Py.GIL())
                        {
                            attributesPyObject = PyModule.InvokeMethod("GetAttributes", new PyObject[] { OFD.FileName.ToPython() });
                        }
                        AttributeDataSets[Path.GetFileNameWithoutExtension(OFD.FileName)] = new AttributeDataSets(attributesPyObject);
                        AttributesListBox.Items.Add(Path.GetFileNameWithoutExtension(OFD.FileName));
                        MessageBox.Show("Файл атрибутов загружен!", "Загрузка файла", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка загрузки данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void LoadCSVDataFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (AttributesListBox.SelectedItem == null)
                    throw new NullReferenceException("Набор атрибутов не задан!\nДля загрузки данных выберите набор атрибутов из списка.");
                Stream stream = null;
                OpenFileDialog OFD = new OpenFileDialog
                {
                    InitialDirectory = Directory.GetCurrentDirectory(),
                    Filter = "Данные, разделённые запятыми (*.csv)|*.csv|Все файлы (*.*)|*.*",
                    FilterIndex = 2,
                    RestoreDirectory = true,
                    Title = "Загрузить данные"
                };
                if (OFD.ShowDialog() == DialogResult.OK)
                {
                    if ((stream = OFD.OpenFile()) != null)
                    {
                        if (Path.GetExtension(OFD.FileName) != ".csv")
                            throw new FileLoadException("Неверное расширение файла", OFD.FileName);
                        PyObject dataPyObject;
                        using (Py.GIL())
                        {
                            dataPyObject = PyModule.InvokeMethod("GetData", new PyObject[] { OFD.FileName.ToPython(), AttributeDataSets[AttributesListBox.SelectedItem.ToString()].Attributes });
                        }
                        int inputlength = dataPyObject["inputdata"].Length();
                        int outputlength = dataPyObject["outputdata"].Length();
                        if (inputlength != outputlength)
                            throw new InvalidOperationException("Объём входных данных не соответствует объёму выходных!");
                        Data.DataSet dataset = new Data.DataSet(dataPyObject, 0, inputlength - 1);
                        DataGridViewRow dataGridViewRow = new DataGridViewRow();
                        dataGridViewRow.CreateCells(DataSetDataGridView);
                        dataGridViewRow.Cells[0].Value = Path.GetFileNameWithoutExtension(OFD.FileName);
                        dataGridViewRow.Cells[1].Value = dataset.Start;
                        dataGridViewRow.Cells[2].Value = dataset.Finish;
                        int before = DataSetDataGridView.RowCount;
                        DataSetDataGridView.Rows.Add(dataGridViewRow);
                        ResizeDataGridView(DataSetDataGridView, before);
                        AttributeDataSets[AttributesListBox.SelectedItem.ToString()].DataSets[Path.GetFileNameWithoutExtension(OFD.FileName)] = dataset;
                        MessageBox.Show("Файл данных загружен!", "Загрузка файла", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка загрузки данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void PreprocessingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (AttributesListBox.SelectedItem == null)
                    throw new NullReferenceException("Набор атрибутов не выбран!\nДля загрузки информации об атрибутах выберите набор атрибутов из списка.");
                PreprocessingForm preprocessingForm = new PreprocessingForm(AttributeDataSets[AttributesListBox.SelectedItem.ToString()].Attributes);
                if (preprocessingForm.ShowDialog(this) == DialogResult.OK)
                    AttributeDataSets[AttributesListBox.SelectedItem.ToString()].Attributes = new PyDict(preprocessingForm.GetAttributes());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка загрузки информации об атрибутах", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
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

        private void DataSetDataGridView_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (DataSetDataGridView.IsCurrentCellDirty)
            {
                DataSetDataGridView.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void DataSetDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            if (e.ColumnIndex == 3)
                AttributeDataSets[AttributesListBox.SelectedItem.ToString()].DataSets[DataSetDataGridView["DataSetNameTB", e.RowIndex].Value.ToString()].ToCrossValidate = (bool)DataSetDataGridView[e.ColumnIndex, e.RowIndex].Value;
        }

        private void DataSetDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int old_value_start = -1, old_value_finish = -1;
            try
            {
                if (e.ColumnIndex == 0)
                {
                    Data.DataSet new_value = AttributeDataSets[AttributesListBox.SelectedItem.ToString()].DataSets[olddatasetkey];
                    AttributeDataSets[AttributesListBox.SelectedItem.ToString()].DataSets.Remove(olddatasetkey);
                    AttributeDataSets[AttributesListBox.SelectedItem.ToString()].DataSets[DataSetDataGridView["DataSetNameTB", e.RowIndex].Value.ToString()] = new_value;
                }
                else if (e.ColumnIndex == 1)
                {
                    old_value_start = AttributeDataSets[AttributesListBox.SelectedItem.ToString()].DataSets[DataSetDataGridView["DataSetNameTB", e.RowIndex].Value.ToString()].Start;
                    old_value_finish = AttributeDataSets[AttributesListBox.SelectedItem.ToString()].DataSets[DataSetDataGridView["DataSetNameTB", e.RowIndex].Value.ToString()].Finish;
                    int new_value_start = Int32.Parse(DataSetDataGridView[e.ColumnIndex, e.RowIndex].Value.ToString());
                    if (new_value_start >= old_value_finish)
                        throw new IndexOutOfRangeException("Номер начальной строки должен быть меньше номера конечной строки!");
                    if (new_value_start < 0)
                        throw new IndexOutOfRangeException("Номер начальной строки должен быть больше 0!");
                    if (new_value_start > AttributeDataSets[AttributesListBox.SelectedItem.ToString()].DataSets[DataSetDataGridView["DataSetNameTB", e.RowIndex].Value.ToString()].Max)
                        throw new IndexOutOfRangeException("Номер начальной строки не может превышать количество строк в наборе данных!");
                    AttributeDataSets[AttributesListBox.SelectedItem.ToString()].DataSets[DataSetDataGridView["DataSetNameTB", e.RowIndex].Value.ToString()].Start = new_value_start;
                }
                else if (e.ColumnIndex == 2)
                {
                    old_value_start = AttributeDataSets[AttributesListBox.SelectedItem.ToString()].DataSets[DataSetDataGridView["DataSetNameTB", e.RowIndex].Value.ToString()].Start;
                    old_value_finish = AttributeDataSets[AttributesListBox.SelectedItem.ToString()].DataSets[DataSetDataGridView["DataSetNameTB", e.RowIndex].Value.ToString()].Finish;
                    int new_value_finish = Int32.Parse(DataSetDataGridView[e.ColumnIndex, e.RowIndex].Value.ToString());
                    if (new_value_finish < 0)
                        throw new IndexOutOfRangeException("Номер конечной строки должен быть больше 0!");
                    if (new_value_finish <= old_value_start)
                        throw new IndexOutOfRangeException("Номер конечной строки должен быть больше номера начальной строки!");
                    if (new_value_finish > AttributeDataSets[AttributesListBox.SelectedItem.ToString()].DataSets[DataSetDataGridView["DataSetNameTB", e.RowIndex].Value.ToString()].Max)
                        throw new IndexOutOfRangeException("Номер конечной строки не может превышать количество строк в наборе данных!");
                    AttributeDataSets[AttributesListBox.SelectedItem.ToString()].DataSets[DataSetDataGridView["DataSetNameTB", e.RowIndex].Value.ToString()].Finish = new_value_finish;
                }
            }
            catch (Exception ex)
            {
                if (e.ColumnIndex == 1 || e.ColumnIndex == 2)
                {
                    DataSetDataGridView["RowsFromTB", e.RowIndex].Value = old_value_start;
                    DataSetDataGridView["RowsTillTB", e.RowIndex].Value = old_value_finish;
                }
                MessageBox.Show(ex.Message, "Ошибка при изменении даннных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void DataSetDataGridView_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (e.ColumnIndex == 0)
                olddatasetkey = DataSetDataGridView[e.ColumnIndex, e.RowIndex].Value.ToString();
        }

        private void CrossValidationBtn_Click(object sender, EventArgs e)
        {
            try
            {
                bool estimatorselected = false, datasetselected = false;
                Dictionary<(string Estimator, string Dataset), double> precision = new Dictionary<(string, string), double>();
                Dictionary<(string Estimator, string Dataset), double> recall = new Dictionary<(string, string), double>();
                Dictionary<(string Estimator, string Dataset), double> f1score = new Dictionary<(string, string), double>();
                foreach (CheckBox checkbox in EstimatorsGroupBox.Controls)
                {
                    if (checkbox.Checked)
                    {
                        estimatorselected = true;
                        foreach (KeyValuePair<string, AttributeDataSets> attributedataset in AttributeDataSets)
                        {
                            foreach (KeyValuePair<string, Data.DataSet> dataset in attributedataset.Value.DataSets)
                            {
                                if (dataset.Value.ToCrossValidate)
                                {
                                    datasetselected = true;
                                    CrossValidationSet cvs = new CrossValidationSet(checkbox.Name, checkbox.Text, dataset.Key, dataset.Value.Dataset, dataset.Value.Start, dataset.Value.Finish, attributedataset.Value.Attributes, cvObject, PyModule);
                                    (double Precision, double Recall, double F1score) = cvs.CrossValidate();
                                    precision[(cvs.EstimatorName, cvs.DatasetName)] = Precision;
                                    recall[(cvs.EstimatorName, cvs.DatasetName)] = Recall;
                                    f1score[(cvs.EstimatorName, cvs.DatasetName)] = F1score;
                                }
                            }
                        }
                    }
                }
                if (!estimatorselected)
                    throw new ArgumentException("Алгоритм(ы) обучения для кросс-валидации не выбран(ы)!");
                if (!datasetselected)
                    throw new ArgumentException("Набор(ы) данных для кросс-валидации не выбран(ы)!");
                ScoresForm scoresForm = new ScoresForm(precision, recall, f1score);
                scoresForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка кросс-валидации", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void SplitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SplitForm crossValidationForm = new SplitForm(cvObject);
            if (crossValidationForm.ShowDialog(this) == DialogResult.OK)
                cvObject = crossValidationForm.GetCVObject();
        }

        private void AttributesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (AttributesListBox.SelectedItem == null)
                return;
            DataSetDataGridView.Rows.Clear();
            DataSetDataGridView.Height = initheightDataSetDataGridView;
            DataSetDataGridView.Width = initwidthDataSetDataGridView;
            foreach (KeyValuePair<string, Data.DataSet> dataset in AttributeDataSets[AttributesListBox.SelectedItem.ToString()].DataSets)
            {
                DataGridViewRow dataGridViewRow = new DataGridViewRow();
                dataGridViewRow.CreateCells(DataSetDataGridView);
                dataGridViewRow.Cells[0].Value = dataset.Key;
                dataGridViewRow.Cells[1].Value = dataset.Value.Start;
                dataGridViewRow.Cells[2].Value = dataset.Value.Finish;
                dataGridViewRow.Cells[3].Value = dataset.Value.ToCrossValidate;
                int before = DataSetDataGridView.RowCount;
                DataSetDataGridView.Rows.Add(dataGridViewRow);
                ResizeDataGridView(DataSetDataGridView, before);
            }
        }
    }
}
