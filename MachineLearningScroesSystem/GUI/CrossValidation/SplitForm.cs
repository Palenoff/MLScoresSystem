using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp.CrossValidation;

namespace WindowsFormsApp
{
    public partial class SplitForm : Form
    {
        string _typecrossvalidation;
        Control[] _allcontrols;
        public SplitForm()
        {
            InitializeComponent();
            _allcontrols = new Control[] { n_groupsTB, n_splitsTB, TrainTB, TestTB, PTB, shuffle_splitCB };
        }

        public SplitForm(CVObject cvObject)
        {
            InitializeComponent();
            _allcontrols = new Control[] { n_groupsTB, n_splitsTB, TrainTB, TestTB, PTB, shuffle_splitCB };
            if (cvObject != null)
            {
                n_groupsTB.Text = cvObject.N_groups.ToString();
                n_splitsTB.Text = cvObject.N_splits.ToString();
                TrainTB.Text = (cvObject.Train_size != null) ? cvObject.Train_size.ToString() : "";
                TestTB.Text = (cvObject.Test_size != null) ? cvObject.Test_size.ToString() : "";
                PTB.Text = cvObject.P.ToString();
                shuffle_splitCB.Checked = cvObject.Shuffle;
                ((RadioButton)CVTypeTableLayoutPanel.Controls[cvObject.Type + "RadioButton"]).Checked = true;             
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void KFoldRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            _typecrossvalidation = "KFold";
            ControlsSetActive(n_splitsTB, shuffle_splitCB);
        }

        private void ShuffleSplitRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            _typecrossvalidation = "ShuffleSplit";
            ControlsSetActive(n_splitsTB, TrainTB, TestTB);
        }

        private void LeaveOneOutRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            _typecrossvalidation = "LeaveOneOut";
            ControlsSetActive();
        }

        private void LeavePOutRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            _typecrossvalidation = "LeavePOut";
            ControlsSetActive(PTB);
        }

        private void StratifiedKFoldRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            _typecrossvalidation = "StratifiedKFold";
            ControlsSetActive(n_splitsTB,shuffle_splitCB);
        }

        private void StratifiedShuffleSplitRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            _typecrossvalidation = "StratifiedShuffleSplit";
            ControlsSetActive(n_splitsTB, TrainTB, TestTB);
        }

        private void GroupKFoldRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            _typecrossvalidation = "GroupKFold";
            ControlsSetActive(n_splitsTB);
        }

        private void GroupShuffleSplitRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            _typecrossvalidation = "GroupShuffleSplit";
            ControlsSetActive(n_splitsTB, TrainTB, TestTB);
        }

        private void LeaveOneGroupOutRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            _typecrossvalidation = "LeaveOneGroupOut";
            ControlsSetActive();
        }

        private void LeavePGroupsOutRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            _typecrossvalidation = "LeavePGroupsOut";
            ControlsSetActive(n_groupsTB);
        }

        private void ControlsSetActive(params Control[] controls)
        {
            foreach (Control control in _allcontrols)
            {
                if (controls.Contains(control))
                    control.Enabled = true;
                else
                    control.Enabled = false;
            }
        }

        public CVObject GetCVObject()
        {
            CVObject cv = null;
            try
            {
                cv = new CVObject(_typecrossvalidation, n_splitsTB.Text, n_groupsTB.Text, PTB.Text, shuffle_splitCB.Checked, TrainTB.Text, TestTB.Text, n_splitsTB.Enabled, n_groupsTB.Enabled, TrainTB.Enabled, TestTB.Enabled, PTB.Enabled);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Ошибка формирования данных кросс-валидации", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            return cv;
        }
    }
}
