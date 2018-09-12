namespace WindowsFormsApp
{
    partial class PreprocessingForm
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
            this.AddKeyButton = new System.Windows.Forms.Button();
            this.RemoveKeyButton = new System.Windows.Forms.Button();
            this.PreprocessingGroupBox = new System.Windows.Forms.GroupBox();
            this.KeysDataGridView = new System.Windows.Forms.DataGridView();
            this.NameTB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeCB = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ValuesTB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isOutputCB = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.OKButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.PreprocessingGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KeysDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // AddKeyButton
            // 
            this.AddKeyButton.Location = new System.Drawing.Point(554, 57);
            this.AddKeyButton.Name = "AddKeyButton";
            this.AddKeyButton.Size = new System.Drawing.Size(26, 23);
            this.AddKeyButton.TabIndex = 2;
            this.AddKeyButton.Text = "+";
            this.AddKeyButton.UseVisualStyleBackColor = true;
            this.AddKeyButton.Click += new System.EventHandler(this.AddKeyButton_Click);
            // 
            // RemoveKeyButton
            // 
            this.RemoveKeyButton.Location = new System.Drawing.Point(554, 104);
            this.RemoveKeyButton.Name = "RemoveKeyButton";
            this.RemoveKeyButton.Size = new System.Drawing.Size(26, 23);
            this.RemoveKeyButton.TabIndex = 3;
            this.RemoveKeyButton.Text = "-";
            this.RemoveKeyButton.UseVisualStyleBackColor = true;
            this.RemoveKeyButton.Click += new System.EventHandler(this.RemoveKeyButton_Click);
            // 
            // PreprocessingGroupBox
            // 
            this.PreprocessingGroupBox.Controls.Add(this.KeysDataGridView);
            this.PreprocessingGroupBox.Controls.Add(this.RemoveKeyButton);
            this.PreprocessingGroupBox.Controls.Add(this.AddKeyButton);
            this.PreprocessingGroupBox.Location = new System.Drawing.Point(12, 12);
            this.PreprocessingGroupBox.Name = "PreprocessingGroupBox";
            this.PreprocessingGroupBox.Size = new System.Drawing.Size(615, 338);
            this.PreprocessingGroupBox.TabIndex = 0;
            this.PreprocessingGroupBox.TabStop = false;
            this.PreprocessingGroupBox.Text = "Атрибуты";
            // 
            // KeysDataGridView
            // 
            this.KeysDataGridView.AllowUserToAddRows = false;
            this.KeysDataGridView.AllowUserToDeleteRows = false;
            this.KeysDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.KeysDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameTB,
            this.TypeCB,
            this.ValuesTB,
            this.isOutputCB});
            this.KeysDataGridView.Location = new System.Drawing.Point(29, 57);
            this.KeysDataGridView.Name = "KeysDataGridView";
            this.KeysDataGridView.RowHeadersVisible = false;
            this.KeysDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.KeysDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.KeysDataGridView.Size = new System.Drawing.Size(481, 23);
            this.KeysDataGridView.TabIndex = 1;
            // 
            // NameTB
            // 
            this.NameTB.HeaderText = "Имя";
            this.NameTB.Name = "NameTB";
            // 
            // TypeCB
            // 
            this.TypeCB.HeaderText = "Тип";
            this.TypeCB.Items.AddRange(new object[] {
            "Бинарный",
            "Номинальный",
            "Числовой"});
            this.TypeCB.Name = "TypeCB";
            // 
            // ValuesTB
            // 
            this.ValuesTB.HeaderText = "Значения";
            this.ValuesTB.Name = "ValuesTB";
            this.ValuesTB.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ValuesTB.Width = 233;
            // 
            // isOutputCB
            // 
            this.isOutputCB.HeaderText = "Выход";
            this.isOutputCB.Name = "isOutputCB";
            this.isOutputCB.Width = 45;
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(449, 395);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 1;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(552, 395);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 2;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // PreprocessingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 440);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.PreprocessingGroupBox);
            this.Name = "PreprocessingForm";
            this.Text = "Препроцессинг";
            this.PreprocessingGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.KeysDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button AddKeyButton;
        private System.Windows.Forms.Button RemoveKeyButton;
        private System.Windows.Forms.GroupBox PreprocessingGroupBox;
        private System.Windows.Forms.DataGridView KeysDataGridView;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameTB;
        private System.Windows.Forms.DataGridViewComboBoxColumn TypeCB;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValuesTB;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isOutputCB;
    }
}