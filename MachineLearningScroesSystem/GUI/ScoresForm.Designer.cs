namespace WindowsFormsApp
{
    partial class ScoresForm
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
            this.ScoresTabControl = new System.Windows.Forms.TabControl();
            this.PrecisionTabPage = new System.Windows.Forms.TabPage();
            this.RecallTabPage = new System.Windows.Forms.TabPage();
            this.F1ScoreTabPage = new System.Windows.Forms.TabPage();
            this.OKBtn = new System.Windows.Forms.Button();
            this.ScoresTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // ScoresTabControl
            // 
            this.ScoresTabControl.Controls.Add(this.PrecisionTabPage);
            this.ScoresTabControl.Controls.Add(this.RecallTabPage);
            this.ScoresTabControl.Controls.Add(this.F1ScoreTabPage);
            this.ScoresTabControl.Location = new System.Drawing.Point(0, 0);
            this.ScoresTabControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ScoresTabControl.Name = "ScoresTabControl";
            this.ScoresTabControl.SelectedIndex = 0;
            this.ScoresTabControl.Size = new System.Drawing.Size(1358, 325);
            this.ScoresTabControl.TabIndex = 0;
            // 
            // PrecisionTabPage
            // 
            this.PrecisionTabPage.Location = new System.Drawing.Point(4, 25);
            this.PrecisionTabPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PrecisionTabPage.Name = "PrecisionTabPage";
            this.PrecisionTabPage.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PrecisionTabPage.Size = new System.Drawing.Size(1350, 296);
            this.PrecisionTabPage.TabIndex = 0;
            this.PrecisionTabPage.Text = "Точность";
            this.PrecisionTabPage.UseVisualStyleBackColor = true;
            // 
            // RecallTabPage
            // 
            this.RecallTabPage.Location = new System.Drawing.Point(4, 25);
            this.RecallTabPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RecallTabPage.Name = "RecallTabPage";
            this.RecallTabPage.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RecallTabPage.Size = new System.Drawing.Size(1350, 296);
            this.RecallTabPage.TabIndex = 1;
            this.RecallTabPage.Text = "Полнота";
            this.RecallTabPage.UseVisualStyleBackColor = true;
            // 
            // F1ScoreTabPage
            // 
            this.F1ScoreTabPage.Location = new System.Drawing.Point(4, 25);
            this.F1ScoreTabPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.F1ScoreTabPage.Name = "F1ScoreTabPage";
            this.F1ScoreTabPage.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.F1ScoreTabPage.Size = new System.Drawing.Size(773, 296);
            this.F1ScoreTabPage.TabIndex = 2;
            this.F1ScoreTabPage.Text = "F-мера";
            this.F1ScoreTabPage.UseVisualStyleBackColor = true;
            // 
            // OKBtn
            // 
            this.OKBtn.Location = new System.Drawing.Point(627, 334);
            this.OKBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OKBtn.Name = "OKBtn";
            this.OKBtn.Size = new System.Drawing.Size(100, 28);
            this.OKBtn.TabIndex = 1;
            this.OKBtn.Text = "OK";
            this.OKBtn.UseVisualStyleBackColor = true;
            this.OKBtn.Click += new System.EventHandler(this.OKBtn_Click);
            // 
            // ScoresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 377);
            this.Controls.Add(this.OKBtn);
            this.Controls.Add(this.ScoresTabControl);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ScoresForm";
            this.Text = "Оценки алгоритмов";
            this.ScoresTabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl ScoresTabControl;
        private System.Windows.Forms.TabPage PrecisionTabPage;
        private System.Windows.Forms.TabPage RecallTabPage;
        private System.Windows.Forms.TabPage F1ScoreTabPage;
        private System.Windows.Forms.Button OKBtn;
    }
}