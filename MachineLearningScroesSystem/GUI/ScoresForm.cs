using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class ScoresForm : Form
    {
        public ScoresForm(Dictionary<(string Estimator, string Dataset), double> precision, Dictionary<(string Estimator, string Dataset), double> recall, Dictionary<(string Estimator, string Dataset), double> f1score)
        {
            InitializeComponent();
            InitializeDataGridView("PrecisionDataGridView", PrecisionTabPage, precision);
            InitializeDataGridView("RecallDataGridView", RecallTabPage, recall);
            InitializeDataGridView("F1ScoreDataGridView", F1ScoreTabPage, f1score);
        }

        void InitializeDataGridView(string dataGridViewName, TabPage tabPage, Dictionary<(string Estimator, string Dataset), double> metric)
        {
            int datasetindex;
            List<string> datasets = new List<string>();
            DataGridView dataGridView = new DataGridView()
            {
                AllowUserToAddRows = false,
                AllowUserToDeleteRows = false,
                Anchor = (AnchorStyles)(AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right),
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells,
                ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize,
                Name = dataGridViewName,
                RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders,
                SelectionMode = DataGridViewSelectionMode.CellSelect
            };
            dataGridView.RowTemplate.ReadOnly = true;        
            foreach (KeyValuePair<(string Estimator, string Dataset), double> score in metric)
            {
                if (!dataGridView.Columns.Contains(score.Key.Estimator))
                {
                    DataGridViewTextBoxColumn dataGridViewTextBoxColumn = new DataGridViewTextBoxColumn
                    {
                        HeaderText = score.Key.Estimator,
                        Name = score.Key.Estimator,
                    };
                    dataGridView.Columns.Add(dataGridViewTextBoxColumn);
                }
                if ((datasetindex = datasets.IndexOf(score.Key.Dataset)) == -1)
                {
                    DataGridViewRow dataGridViewRow = new DataGridViewRow();
                    dataGridViewRow.HeaderCell.Value = score.Key.Dataset;
                    dataGridView.Rows.Add(dataGridViewRow);
                    datasets.Add(score.Key.Dataset);
                    dataGridView[score.Key.Estimator, datasets.Count - 1].Value = score.Value;
                    dataGridView[score.Key.Estimator, datasets.Count - 1].ReadOnly = true;
                }
                else
                {
                    dataGridView[score.Key.Estimator, datasetindex].Value = score.Value;
                    dataGridView[score.Key.Estimator, datasets.Count - 1].ReadOnly = true;
                }
            }
            bool horizontal = (dataGridView.ColumnCount > 3), vertical = (dataGridView.RowCount > 9);
            dataGridView.Height = (vertical) ? tabPage.Height : dataGridView.Rows.GetRowsHeight(DataGridViewElementStates.None) + dataGridView.ColumnHeadersHeight + 14 + (horizontal ? 17 : 0);
            dataGridView.Width = tabPage.Width;
            tabPage.Controls.Add(dataGridView);
        }

        private void OKBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
