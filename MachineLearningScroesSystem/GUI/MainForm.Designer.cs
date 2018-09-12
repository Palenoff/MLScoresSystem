namespace WindowsFormsApp
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LoadCSVAttributesFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LoadCSVDataFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ParametrsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PreprocessingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SplitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AttributesListBox = new System.Windows.Forms.ListBox();
            this.AttributesLlabel = new System.Windows.Forms.Label();
            this.DataSetDataGridView = new System.Windows.Forms.DataGridView();
            this.DataSetNameTB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RowsFromTB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RowsTillTB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toCrossValidationTB = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DataLabel = new System.Windows.Forms.Label();
            this.EstimatorsGroupBox = new System.Windows.Forms.GroupBox();
            this.JSM = new System.Windows.Forms.CheckBox();
            this.SVC = new System.Windows.Forms.CheckBox();
            this.MLP = new System.Windows.Forms.CheckBox();
            this.KNeighbors = new System.Windows.Forms.CheckBox();
            this.GaussianNB = new System.Windows.Forms.CheckBox();
            this.RandomForest = new System.Windows.Forms.CheckBox();
            this.LogisticRegression = new System.Windows.Forms.CheckBox();
            this.DecisionTree = new System.Windows.Forms.CheckBox();
            this.CrossValidationBtn = new System.Windows.Forms.Button();
            this.MenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetDataGridView)).BeginInit();
            this.EstimatorsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.ParametrsToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(700, 24);
            this.MenuStrip.TabIndex = 0;
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LoadCSVAttributesFileToolStripMenuItem,
            this.LoadCSVDataFileToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.FileToolStripMenuItem.Text = "Файл";
            // 
            // LoadCSVAttributesFileToolStripMenuItem
            // 
            this.LoadCSVAttributesFileToolStripMenuItem.Name = "LoadCSVAttributesFileToolStripMenuItem";
            this.LoadCSVAttributesFileToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
            this.LoadCSVAttributesFileToolStripMenuItem.Text = "Загрузить CSV-файл с атрибутами";
            this.LoadCSVAttributesFileToolStripMenuItem.Click += new System.EventHandler(this.LoadCSVAttributesFileToolStripMenuItem_Click);
            // 
            // LoadCSVDataFileToolStripMenuItem
            // 
            this.LoadCSVDataFileToolStripMenuItem.Name = "LoadCSVDataFileToolStripMenuItem";
            this.LoadCSVDataFileToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
            this.LoadCSVDataFileToolStripMenuItem.Text = "Загрузить CSV-файл с данными";
            this.LoadCSVDataFileToolStripMenuItem.Click += new System.EventHandler(this.LoadCSVDataFileToolStripMenuItem_Click);
            // 
            // ParametrsToolStripMenuItem
            // 
            this.ParametrsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PreprocessingToolStripMenuItem,
            this.SplitToolStripMenuItem});
            this.ParametrsToolStripMenuItem.Name = "ParametrsToolStripMenuItem";
            this.ParametrsToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.ParametrsToolStripMenuItem.Text = "Параметры";
            // 
            // PreprocessingToolStripMenuItem
            // 
            this.PreprocessingToolStripMenuItem.Name = "PreprocessingToolStripMenuItem";
            this.PreprocessingToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.PreprocessingToolStripMenuItem.Text = "Препроцессинг";
            this.PreprocessingToolStripMenuItem.Click += new System.EventHandler(this.PreprocessingToolStripMenuItem_Click);
            // 
            // SplitToolStripMenuItem
            // 
            this.SplitToolStripMenuItem.Name = "SplitToolStripMenuItem";
            this.SplitToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.SplitToolStripMenuItem.Text = "Стратегия разбиения данных";
            this.SplitToolStripMenuItem.Click += new System.EventHandler(this.SplitToolStripMenuItem_Click);
            // 
            // AttributesListBox
            // 
            this.AttributesListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AttributesListBox.FormattingEnabled = true;
            this.AttributesListBox.ItemHeight = 16;
            this.AttributesListBox.Location = new System.Drawing.Point(29, 83);
            this.AttributesListBox.Name = "AttributesListBox";
            this.AttributesListBox.Size = new System.Drawing.Size(120, 244);
            this.AttributesListBox.TabIndex = 1;
            this.AttributesListBox.SelectedIndexChanged += new System.EventHandler(this.AttributesListBox_SelectedIndexChanged);
            // 
            // AttributesLlabel
            // 
            this.AttributesLlabel.AutoSize = true;
            this.AttributesLlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AttributesLlabel.Location = new System.Drawing.Point(36, 40);
            this.AttributesLlabel.Name = "AttributesLlabel";
            this.AttributesLlabel.Size = new System.Drawing.Size(98, 24);
            this.AttributesLlabel.TabIndex = 2;
            this.AttributesLlabel.Text = "Атрибуты";
            // 
            // DataSetDataGridView
            // 
            this.DataSetDataGridView.AllowUserToAddRows = false;
            this.DataSetDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataSetDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataSetDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataSetDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataSetNameTB,
            this.RowsFromTB,
            this.RowsTillTB,
            this.toCrossValidationTB});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataSetDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.DataSetDataGridView.Location = new System.Drawing.Point(193, 83);
            this.DataSetDataGridView.Name = "DataSetDataGridView";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataSetDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DataSetDataGridView.RowHeadersVisible = false;
            this.DataSetDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DataSetDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataSetDataGridView.Size = new System.Drawing.Size(477, 23);
            this.DataSetDataGridView.TabIndex = 4;
            this.DataSetDataGridView.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.DataSetDataGridView_CellBeginEdit);
            this.DataSetDataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataSetDataGridView_CellEndEdit);
            this.DataSetDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataSetDataGridView_CellValueChanged);
            this.DataSetDataGridView.CurrentCellDirtyStateChanged += new System.EventHandler(this.DataSetDataGridView_CurrentCellDirtyStateChanged);
            // 
            // DataSetNameTB
            // 
            this.DataSetNameTB.HeaderText = "Имя набора данных";
            this.DataSetNameTB.Name = "DataSetNameTB";
            this.DataSetNameTB.Width = 208;
            // 
            // RowsFromTB
            // 
            this.RowsFromTB.HeaderText = "Строки с";
            this.RowsFromTB.Name = "RowsFromTB";
            this.RowsFromTB.Width = 75;
            // 
            // RowsTillTB
            // 
            this.RowsTillTB.HeaderText = "Строки по";
            this.RowsTillTB.Name = "RowsTillTB";
            this.RowsTillTB.Width = 90;
            // 
            // toCrossValidationTB
            // 
            this.toCrossValidationTB.HeaderText = "Кросс-валидация";
            this.toCrossValidationTB.Name = "toCrossValidationTB";
            // 
            // DataLabel
            // 
            this.DataLabel.AutoSize = true;
            this.DataLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DataLabel.Location = new System.Drawing.Point(189, 40);
            this.DataLabel.Name = "DataLabel";
            this.DataLabel.Size = new System.Drawing.Size(80, 24);
            this.DataLabel.TabIndex = 5;
            this.DataLabel.Text = "Данные";
            // 
            // EstimatorsGroupBox
            // 
            this.EstimatorsGroupBox.Controls.Add(this.JSM);
            this.EstimatorsGroupBox.Controls.Add(this.SVC);
            this.EstimatorsGroupBox.Controls.Add(this.MLP);
            this.EstimatorsGroupBox.Controls.Add(this.KNeighbors);
            this.EstimatorsGroupBox.Controls.Add(this.GaussianNB);
            this.EstimatorsGroupBox.Controls.Add(this.RandomForest);
            this.EstimatorsGroupBox.Controls.Add(this.LogisticRegression);
            this.EstimatorsGroupBox.Controls.Add(this.DecisionTree);
            this.EstimatorsGroupBox.Location = new System.Drawing.Point(29, 348);
            this.EstimatorsGroupBox.Name = "EstimatorsGroupBox";
            this.EstimatorsGroupBox.Size = new System.Drawing.Size(641, 94);
            this.EstimatorsGroupBox.TabIndex = 6;
            this.EstimatorsGroupBox.TabStop = false;
            this.EstimatorsGroupBox.Text = "Алгоритмы машинного обучения";
            // 
            // JSM
            // 
            this.JSM.AutoSize = true;
            this.JSM.Location = new System.Drawing.Point(466, 64);
            this.JSM.Name = "JSM";
            this.JSM.Size = new System.Drawing.Size(51, 17);
            this.JSM.TabIndex = 7;
            this.JSM.Text = "ДСМ";
            this.JSM.UseVisualStyleBackColor = true;
            // 
            // SVC
            // 
            this.SVC.AutoSize = true;
            this.SVC.Location = new System.Drawing.Point(176, 64);
            this.SVC.Name = "SVC";
            this.SVC.Size = new System.Drawing.Size(163, 17);
            this.SVC.TabIndex = 3;
            this.SVC.Text = "Машина опорных векторов";
            this.SVC.UseVisualStyleBackColor = true;
            // 
            // MLP
            // 
            this.MLP.AutoSize = true;
            this.MLP.Location = new System.Drawing.Point(466, 36);
            this.MLP.Name = "MLP";
            this.MLP.Size = new System.Drawing.Size(164, 17);
            this.MLP.TabIndex = 6;
            this.MLP.Text = "Многослойный персептрон";
            this.MLP.UseVisualStyleBackColor = true;
            // 
            // KNeighbors
            // 
            this.KNeighbors.AutoSize = true;
            this.KNeighbors.Location = new System.Drawing.Point(176, 36);
            this.KNeighbors.Name = "KNeighbors";
            this.KNeighbors.Size = new System.Drawing.Size(163, 17);
            this.KNeighbors.TabIndex = 2;
            this.KNeighbors.Text = "Метод ближайших соседей";
            this.KNeighbors.UseVisualStyleBackColor = true;
            // 
            // GaussianNB
            // 
            this.GaussianNB.AutoSize = true;
            this.GaussianNB.Location = new System.Drawing.Point(6, 64);
            this.GaussianNB.Name = "GaussianNB";
            this.GaussianNB.Size = new System.Drawing.Size(173, 17);
            this.GaussianNB.TabIndex = 1;
            this.GaussianNB.Text = "Нормальный наивный Байес";
            this.GaussianNB.UseVisualStyleBackColor = true;
            // 
            // RandomForest
            // 
            this.RandomForest.AutoSize = true;
            this.RandomForest.Location = new System.Drawing.Point(345, 64);
            this.RandomForest.Name = "RandomForest";
            this.RandomForest.Size = new System.Drawing.Size(102, 17);
            this.RandomForest.TabIndex = 5;
            this.RandomForest.Text = "Случайный лес";
            this.RandomForest.UseVisualStyleBackColor = true;
            // 
            // LogisticRegression
            // 
            this.LogisticRegression.AutoSize = true;
            this.LogisticRegression.Location = new System.Drawing.Point(6, 36);
            this.LogisticRegression.Name = "LogisticRegression";
            this.LogisticRegression.Size = new System.Drawing.Size(159, 17);
            this.LogisticRegression.TabIndex = 0;
            this.LogisticRegression.Text = "Логистическая регрессия";
            this.LogisticRegression.UseVisualStyleBackColor = true;
            // 
            // DecisionTree
            // 
            this.DecisionTree.AutoSize = true;
            this.DecisionTree.Location = new System.Drawing.Point(345, 36);
            this.DecisionTree.Name = "DecisionTree";
            this.DecisionTree.Size = new System.Drawing.Size(118, 17);
            this.DecisionTree.TabIndex = 4;
            this.DecisionTree.Text = "Деревья решений";
            this.DecisionTree.UseVisualStyleBackColor = true;
            // 
            // CrossValidationBtn
            // 
            this.CrossValidationBtn.Location = new System.Drawing.Point(495, 459);
            this.CrossValidationBtn.Name = "CrossValidationBtn";
            this.CrossValidationBtn.Size = new System.Drawing.Size(137, 23);
            this.CrossValidationBtn.TabIndex = 7;
            this.CrossValidationBtn.Text = "Кросс-валидация";
            this.CrossValidationBtn.UseVisualStyleBackColor = true;
            this.CrossValidationBtn.Click += new System.EventHandler(this.CrossValidationBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 494);
            this.Controls.Add(this.CrossValidationBtn);
            this.Controls.Add(this.EstimatorsGroupBox);
            this.Controls.Add(this.DataLabel);
            this.Controls.Add(this.DataSetDataGridView);
            this.Controls.Add(this.AttributesLlabel);
            this.Controls.Add(this.AttributesListBox);
            this.Controls.Add(this.MenuStrip);
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "MainForm";
            this.Text = "Система оценки качества работы алгоритмов машинного обучения";
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetDataGridView)).EndInit();
            this.EstimatorsGroupBox.ResumeLayout(false);
            this.EstimatorsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LoadCSVAttributesFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ParametrsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PreprocessingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LoadCSVDataFileToolStripMenuItem;
        private System.Windows.Forms.ListBox AttributesListBox;
        private System.Windows.Forms.Label AttributesLlabel;
        private System.Windows.Forms.DataGridView DataSetDataGridView;
        private System.Windows.Forms.Label DataLabel;
        private System.Windows.Forms.ToolStripMenuItem SplitToolStripMenuItem;
        private System.Windows.Forms.GroupBox EstimatorsGroupBox;
        private System.Windows.Forms.CheckBox LogisticRegression;
        private System.Windows.Forms.CheckBox GaussianNB;
        private System.Windows.Forms.CheckBox SVC;
        private System.Windows.Forms.CheckBox KNeighbors;
        private System.Windows.Forms.CheckBox JSM;
        private System.Windows.Forms.CheckBox MLP;
        private System.Windows.Forms.CheckBox RandomForest;
        private System.Windows.Forms.CheckBox DecisionTree;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataSetNameTB;
        private System.Windows.Forms.DataGridViewTextBoxColumn RowsFromTB;
        private System.Windows.Forms.DataGridViewTextBoxColumn RowsTillTB;
        private System.Windows.Forms.DataGridViewCheckBoxColumn toCrossValidationTB;
        private System.Windows.Forms.Button CrossValidationBtn;
    }
}

