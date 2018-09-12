namespace WindowsFormsApp
{
    partial class SplitForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CVTypeTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.KFoldRadioButton = new System.Windows.Forms.RadioButton();
            this.ShuffleSplitRadioButton = new System.Windows.Forms.RadioButton();
            this.LeaveOneOutRadioButton = new System.Windows.Forms.RadioButton();
            this.LeavePOutRadioButton = new System.Windows.Forms.RadioButton();
            this.StratifiedKFoldRadioButton = new System.Windows.Forms.RadioButton();
            this.StratifiedShuffleSplitRadioButton = new System.Windows.Forms.RadioButton();
            this.GroupKFoldRadioButton = new System.Windows.Forms.RadioButton();
            this.GroupShuffleSplitRadioButton = new System.Windows.Forms.RadioButton();
            this.LeaveOneGroupOutRadioButton = new System.Windows.Forms.RadioButton();
            this.LeavePGroupsOutRadioButton = new System.Windows.Forms.RadioButton();
            this.ParamsGroupBox = new System.Windows.Forms.GroupBox();
            this.PTB = new System.Windows.Forms.TextBox();
            this.PLabel = new System.Windows.Forms.Label();
            this.n_groupsTB = new System.Windows.Forms.TextBox();
            this.n_groupsLabel = new System.Windows.Forms.Label();
            this.NotificationLabel = new System.Windows.Forms.Label();
            this.TestTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TrainTB = new System.Windows.Forms.TextBox();
            this.TrainLabel = new System.Windows.Forms.Label();
            this.shuffle_splitCB = new System.Windows.Forms.CheckBox();
            this.n_splitsTB = new System.Windows.Forms.TextBox();
            this.ShuffleLable = new System.Windows.Forms.Label();
            this.n_splitsLabel = new System.Windows.Forms.Label();
            this.OKButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.CVTypeTableLayoutPanel.SuspendLayout();
            this.ParamsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // CVTypeTableLayoutPanel
            // 
            this.CVTypeTableLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.CVTypeTableLayoutPanel.ColumnCount = 4;
            this.CVTypeTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.CVTypeTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.CVTypeTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.CVTypeTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.CVTypeTableLayoutPanel.Controls.Add(this.KFoldRadioButton, 0, 0);
            this.CVTypeTableLayoutPanel.Controls.Add(this.ShuffleSplitRadioButton, 1, 0);
            this.CVTypeTableLayoutPanel.Controls.Add(this.LeaveOneOutRadioButton, 2, 0);
            this.CVTypeTableLayoutPanel.Controls.Add(this.LeavePOutRadioButton, 3, 0);
            this.CVTypeTableLayoutPanel.Controls.Add(this.StratifiedKFoldRadioButton, 0, 1);
            this.CVTypeTableLayoutPanel.Controls.Add(this.StratifiedShuffleSplitRadioButton, 1, 1);
            this.CVTypeTableLayoutPanel.Controls.Add(this.GroupKFoldRadioButton, 0, 2);
            this.CVTypeTableLayoutPanel.Controls.Add(this.GroupShuffleSplitRadioButton, 1, 2);
            this.CVTypeTableLayoutPanel.Controls.Add(this.LeaveOneGroupOutRadioButton, 2, 2);
            this.CVTypeTableLayoutPanel.Controls.Add(this.LeavePGroupsOutRadioButton, 3, 2);
            this.CVTypeTableLayoutPanel.Location = new System.Drawing.Point(48, 61);
            this.CVTypeTableLayoutPanel.Name = "CVTypeTableLayoutPanel";
            this.CVTypeTableLayoutPanel.RowCount = 3;
            this.CVTypeTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.CVTypeTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.CVTypeTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.CVTypeTableLayoutPanel.Size = new System.Drawing.Size(555, 221);
            this.CVTypeTableLayoutPanel.TabIndex = 0;
            // 
            // KFoldRadioButton
            // 
            this.KFoldRadioButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.KFoldRadioButton.AutoSize = true;
            this.KFoldRadioButton.Location = new System.Drawing.Point(42, 28);
            this.KFoldRadioButton.Name = "KFoldRadioButton";
            this.KFoldRadioButton.Size = new System.Drawing.Size(55, 17);
            this.KFoldRadioButton.TabIndex = 0;
            this.KFoldRadioButton.TabStop = true;
            this.KFoldRadioButton.Text = "K-Fold";
            this.KFoldRadioButton.UseVisualStyleBackColor = true;
            this.KFoldRadioButton.CheckedChanged += new System.EventHandler(this.KFoldRadioButton_CheckedChanged);
            // 
            // ShuffleSplitRadioButton
            // 
            this.ShuffleSplitRadioButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ShuffleSplitRadioButton.AutoSize = true;
            this.ShuffleSplitRadioButton.Location = new System.Drawing.Point(167, 28);
            this.ShuffleSplitRadioButton.Name = "ShuffleSplitRadioButton";
            this.ShuffleSplitRadioButton.Size = new System.Drawing.Size(81, 17);
            this.ShuffleSplitRadioButton.TabIndex = 1;
            this.ShuffleSplitRadioButton.TabStop = true;
            this.ShuffleSplitRadioButton.Text = "Shuffle Split";
            this.ShuffleSplitRadioButton.UseVisualStyleBackColor = true;
            this.ShuffleSplitRadioButton.CheckedChanged += new System.EventHandler(this.ShuffleSplitRadioButton_CheckedChanged);
            // 
            // LeaveOneOutRadioButton
            // 
            this.LeaveOneOutRadioButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LeaveOneOutRadioButton.AutoSize = true;
            this.LeaveOneOutRadioButton.Location = new System.Drawing.Point(296, 28);
            this.LeaveOneOutRadioButton.Name = "LeaveOneOutRadioButton";
            this.LeaveOneOutRadioButton.Size = new System.Drawing.Size(98, 17);
            this.LeaveOneOutRadioButton.TabIndex = 2;
            this.LeaveOneOutRadioButton.TabStop = true;
            this.LeaveOneOutRadioButton.Text = "Leave One Out";
            this.LeaveOneOutRadioButton.UseVisualStyleBackColor = true;
            this.LeaveOneOutRadioButton.CheckedChanged += new System.EventHandler(this.LeaveOneOutRadioButton_CheckedChanged);
            // 
            // LeavePOutRadioButton
            // 
            this.LeavePOutRadioButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LeavePOutRadioButton.AutoSize = true;
            this.LeavePOutRadioButton.Location = new System.Drawing.Point(442, 28);
            this.LeavePOutRadioButton.Name = "LeavePOutRadioButton";
            this.LeavePOutRadioButton.Size = new System.Drawing.Size(85, 17);
            this.LeavePOutRadioButton.TabIndex = 3;
            this.LeavePOutRadioButton.TabStop = true;
            this.LeavePOutRadioButton.Text = "Leave P Out";
            this.LeavePOutRadioButton.UseVisualStyleBackColor = true;
            this.LeavePOutRadioButton.CheckedChanged += new System.EventHandler(this.LeavePOutRadioButton_CheckedChanged);
            // 
            // StratifiedKFoldRadioButton
            // 
            this.StratifiedKFoldRadioButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.StratifiedKFoldRadioButton.AutoSize = true;
            this.StratifiedKFoldRadioButton.Location = new System.Drawing.Point(20, 101);
            this.StratifiedKFoldRadioButton.Name = "StratifiedKFoldRadioButton";
            this.StratifiedKFoldRadioButton.Size = new System.Drawing.Size(99, 17);
            this.StratifiedKFoldRadioButton.TabIndex = 4;
            this.StratifiedKFoldRadioButton.TabStop = true;
            this.StratifiedKFoldRadioButton.Text = "Stratified K-Fold";
            this.StratifiedKFoldRadioButton.UseVisualStyleBackColor = true;
            this.StratifiedKFoldRadioButton.CheckedChanged += new System.EventHandler(this.StratifiedKFoldRadioButton_CheckedChanged);
            // 
            // StratifiedShuffleSplitRadioButton
            // 
            this.StratifiedShuffleSplitRadioButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.StratifiedShuffleSplitRadioButton.AutoSize = true;
            this.StratifiedShuffleSplitRadioButton.Location = new System.Drawing.Point(145, 101);
            this.StratifiedShuffleSplitRadioButton.Name = "StratifiedShuffleSplitRadioButton";
            this.StratifiedShuffleSplitRadioButton.Size = new System.Drawing.Size(125, 17);
            this.StratifiedShuffleSplitRadioButton.TabIndex = 5;
            this.StratifiedShuffleSplitRadioButton.TabStop = true;
            this.StratifiedShuffleSplitRadioButton.Text = "Stratified Shuffle Split";
            this.StratifiedShuffleSplitRadioButton.UseVisualStyleBackColor = true;
            this.StratifiedShuffleSplitRadioButton.CheckedChanged += new System.EventHandler(this.StratifiedShuffleSplitRadioButton_CheckedChanged);
            // 
            // GroupKFoldRadioButton
            // 
            this.GroupKFoldRadioButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GroupKFoldRadioButton.AutoSize = true;
            this.GroupKFoldRadioButton.Location = new System.Drawing.Point(26, 175);
            this.GroupKFoldRadioButton.Name = "GroupKFoldRadioButton";
            this.GroupKFoldRadioButton.Size = new System.Drawing.Size(87, 17);
            this.GroupKFoldRadioButton.TabIndex = 8;
            this.GroupKFoldRadioButton.TabStop = true;
            this.GroupKFoldRadioButton.Text = "Group K-Fold";
            this.GroupKFoldRadioButton.UseVisualStyleBackColor = true;
            this.GroupKFoldRadioButton.CheckedChanged += new System.EventHandler(this.GroupKFoldRadioButton_CheckedChanged);
            // 
            // GroupShuffleSplitRadioButton
            // 
            this.GroupShuffleSplitRadioButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GroupShuffleSplitRadioButton.AutoSize = true;
            this.GroupShuffleSplitRadioButton.Location = new System.Drawing.Point(151, 175);
            this.GroupShuffleSplitRadioButton.Name = "GroupShuffleSplitRadioButton";
            this.GroupShuffleSplitRadioButton.Size = new System.Drawing.Size(113, 17);
            this.GroupShuffleSplitRadioButton.TabIndex = 9;
            this.GroupShuffleSplitRadioButton.TabStop = true;
            this.GroupShuffleSplitRadioButton.Text = "Group Shuffle Split";
            this.GroupShuffleSplitRadioButton.UseVisualStyleBackColor = true;
            this.GroupShuffleSplitRadioButton.CheckedChanged += new System.EventHandler(this.GroupShuffleSplitRadioButton_CheckedChanged);
            // 
            // LeaveOneGroupOutRadioButton
            // 
            this.LeaveOneGroupOutRadioButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LeaveOneGroupOutRadioButton.AutoSize = true;
            this.LeaveOneGroupOutRadioButton.Location = new System.Drawing.Point(280, 175);
            this.LeaveOneGroupOutRadioButton.Name = "LeaveOneGroupOutRadioButton";
            this.LeaveOneGroupOutRadioButton.Size = new System.Drawing.Size(130, 17);
            this.LeaveOneGroupOutRadioButton.TabIndex = 10;
            this.LeaveOneGroupOutRadioButton.TabStop = true;
            this.LeaveOneGroupOutRadioButton.Text = "Leave One Group Out";
            this.LeaveOneGroupOutRadioButton.UseVisualStyleBackColor = true;
            this.LeaveOneGroupOutRadioButton.CheckedChanged += new System.EventHandler(this.LeaveOneGroupOutRadioButton_CheckedChanged);
            // 
            // LeavePGroupsOutRadioButton
            // 
            this.LeavePGroupsOutRadioButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LeavePGroupsOutRadioButton.AutoSize = true;
            this.LeavePGroupsOutRadioButton.Location = new System.Drawing.Point(423, 175);
            this.LeavePGroupsOutRadioButton.Name = "LeavePGroupsOutRadioButton";
            this.LeavePGroupsOutRadioButton.Size = new System.Drawing.Size(122, 17);
            this.LeavePGroupsOutRadioButton.TabIndex = 11;
            this.LeavePGroupsOutRadioButton.TabStop = true;
            this.LeavePGroupsOutRadioButton.Text = "Leave P Groups Out";
            this.LeavePGroupsOutRadioButton.UseVisualStyleBackColor = true;
            this.LeavePGroupsOutRadioButton.CheckedChanged += new System.EventHandler(this.LeavePGroupsOutRadioButton_CheckedChanged);
            // 
            // ParamsGroupBox
            // 
            this.ParamsGroupBox.Controls.Add(this.PTB);
            this.ParamsGroupBox.Controls.Add(this.PLabel);
            this.ParamsGroupBox.Controls.Add(this.n_groupsTB);
            this.ParamsGroupBox.Controls.Add(this.n_groupsLabel);
            this.ParamsGroupBox.Controls.Add(this.NotificationLabel);
            this.ParamsGroupBox.Controls.Add(this.TestTB);
            this.ParamsGroupBox.Controls.Add(this.label2);
            this.ParamsGroupBox.Controls.Add(this.TrainTB);
            this.ParamsGroupBox.Controls.Add(this.TrainLabel);
            this.ParamsGroupBox.Controls.Add(this.shuffle_splitCB);
            this.ParamsGroupBox.Controls.Add(this.n_splitsTB);
            this.ParamsGroupBox.Controls.Add(this.ShuffleLable);
            this.ParamsGroupBox.Controls.Add(this.n_splitsLabel);
            this.ParamsGroupBox.Location = new System.Drawing.Point(48, 323);
            this.ParamsGroupBox.Name = "ParamsGroupBox";
            this.ParamsGroupBox.Size = new System.Drawing.Size(555, 164);
            this.ParamsGroupBox.TabIndex = 1;
            this.ParamsGroupBox.TabStop = false;
            this.ParamsGroupBox.Text = "Параметры";
            // 
            // PTB
            // 
            this.PTB.Enabled = false;
            this.PTB.Location = new System.Drawing.Point(499, 35);
            this.PTB.Name = "PTB";
            this.PTB.Size = new System.Drawing.Size(36, 20);
            this.PTB.TabIndex = 12;
            // 
            // PLabel
            // 
            this.PLabel.AutoSize = true;
            this.PLabel.Location = new System.Drawing.Point(476, 38);
            this.PLabel.Name = "PLabel";
            this.PLabel.Size = new System.Drawing.Size(17, 13);
            this.PLabel.TabIndex = 11;
            this.PLabel.Text = "P:";
            // 
            // n_groupsTB
            // 
            this.n_groupsTB.Enabled = false;
            this.n_groupsTB.Location = new System.Drawing.Point(419, 35);
            this.n_groupsTB.Name = "n_groupsTB";
            this.n_groupsTB.Size = new System.Drawing.Size(36, 20);
            this.n_groupsTB.TabIndex = 10;
            // 
            // n_groupsLabel
            // 
            this.n_groupsLabel.AutoSize = true;
            this.n_groupsLabel.Location = new System.Drawing.Point(199, 38);
            this.n_groupsLabel.Name = "n_groupsLabel";
            this.n_groupsLabel.Size = new System.Drawing.Size(217, 13);
            this.n_groupsLabel.TabIndex = 9;
            this.n_groupsLabel.Text = "Количество групп для тестовой выборки:";
            // 
            // NotificationLabel
            // 
            this.NotificationLabel.AutoSize = true;
            this.NotificationLabel.Location = new System.Drawing.Point(16, 130);
            this.NotificationLabel.Name = "NotificationLabel";
            this.NotificationLabel.Size = new System.Drawing.Size(491, 13);
            this.NotificationLabel.TabIndex = 8;
            this.NotificationLabel.Text = "Значение от 0 до 1 - доля от общего числа примеров. Значение более 1 - количество" +
    " примеров";
            // 
            // TestTB
            // 
            this.TestTB.Enabled = false;
            this.TestTB.Location = new System.Drawing.Point(400, 101);
            this.TestTB.Name = "TestTB";
            this.TestTB.Size = new System.Drawing.Size(36, 20);
            this.TestTB.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(249, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Размер тестовой выборки:";
            // 
            // TrainTB
            // 
            this.TrainTB.Enabled = false;
            this.TrainTB.Location = new System.Drawing.Point(180, 101);
            this.TrainTB.Name = "TrainTB";
            this.TrainTB.Size = new System.Drawing.Size(36, 20);
            this.TrainTB.TabIndex = 5;
            // 
            // TrainLabel
            // 
            this.TrainLabel.AutoSize = true;
            this.TrainLabel.Location = new System.Drawing.Point(16, 104);
            this.TrainLabel.Name = "TrainLabel";
            this.TrainLabel.Size = new System.Drawing.Size(156, 13);
            this.TrainLabel.TabIndex = 4;
            this.TrainLabel.Text = "Размер обучающей выборки:";
            // 
            // shuffle_splitCB
            // 
            this.shuffle_splitCB.AutoSize = true;
            this.shuffle_splitCB.Enabled = false;
            this.shuffle_splitCB.Location = new System.Drawing.Point(142, 70);
            this.shuffle_splitCB.Name = "shuffle_splitCB";
            this.shuffle_splitCB.Size = new System.Drawing.Size(15, 14);
            this.shuffle_splitCB.TabIndex = 3;
            this.shuffle_splitCB.UseVisualStyleBackColor = true;
            // 
            // n_splitsTB
            // 
            this.n_splitsTB.Enabled = false;
            this.n_splitsTB.Location = new System.Drawing.Point(144, 35);
            this.n_splitsTB.Name = "n_splitsTB";
            this.n_splitsTB.Size = new System.Drawing.Size(36, 20);
            this.n_splitsTB.TabIndex = 2;
            // 
            // ShuffleLable
            // 
            this.ShuffleLable.AutoSize = true;
            this.ShuffleLable.Location = new System.Drawing.Point(16, 70);
            this.ShuffleLable.Name = "ShuffleLable";
            this.ShuffleLable.Size = new System.Drawing.Size(121, 13);
            this.ShuffleLable.TabIndex = 1;
            this.ShuffleLable.Text = "Перемешать выборку:";
            // 
            // n_splitsLabel
            // 
            this.n_splitsLabel.AutoSize = true;
            this.n_splitsLabel.Location = new System.Drawing.Point(16, 38);
            this.n_splitsLabel.Name = "n_splitsLabel";
            this.n_splitsLabel.Size = new System.Drawing.Size(126, 13);
            this.n_splitsLabel.TabIndex = 0;
            this.n_splitsLabel.Text = "Количество разбиений:";
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(490, 514);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 2;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(604, 514);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 3;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // CrossValidationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 549);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.ParamsGroupBox);
            this.Controls.Add(this.CVTypeTableLayoutPanel);
            this.Name = "CrossValidationForm";
            this.Text = "Стратегия разбиения данных";
            this.CVTypeTableLayoutPanel.ResumeLayout(false);
            this.CVTypeTableLayoutPanel.PerformLayout();
            this.ParamsGroupBox.ResumeLayout(false);
            this.ParamsGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel CVTypeTableLayoutPanel;
        private System.Windows.Forms.RadioButton KFoldRadioButton;
        private System.Windows.Forms.RadioButton ShuffleSplitRadioButton;
        private System.Windows.Forms.RadioButton LeaveOneOutRadioButton;
        private System.Windows.Forms.RadioButton LeavePOutRadioButton;
        private System.Windows.Forms.RadioButton StratifiedKFoldRadioButton;
        private System.Windows.Forms.RadioButton StratifiedShuffleSplitRadioButton;
        private System.Windows.Forms.RadioButton GroupKFoldRadioButton;
        private System.Windows.Forms.RadioButton GroupShuffleSplitRadioButton;
        private System.Windows.Forms.RadioButton LeaveOneGroupOutRadioButton;
        private System.Windows.Forms.RadioButton LeavePGroupsOutRadioButton;
        private System.Windows.Forms.GroupBox ParamsGroupBox;
        private System.Windows.Forms.Label NotificationLabel;
        private System.Windows.Forms.TextBox TestTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TrainTB;
        private System.Windows.Forms.Label TrainLabel;
        private System.Windows.Forms.CheckBox shuffle_splitCB;
        private System.Windows.Forms.TextBox n_splitsTB;
        private System.Windows.Forms.Label ShuffleLable;
        private System.Windows.Forms.Label n_splitsLabel;
        private System.Windows.Forms.TextBox n_groupsTB;
        private System.Windows.Forms.Label n_groupsLabel;
        private System.Windows.Forms.TextBox PTB;
        private System.Windows.Forms.Label PLabel;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button CancelButton;
    }
}