namespace StackEd
{
    partial class StackEd
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
            this.btnCorrect = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.stsLogs = new System.Windows.Forms.StatusStrip();
            this.stsLogLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnAutoCorrect = new System.Windows.Forms.Button();
            this.stsLogs.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCorrect
            // 
            this.btnCorrect.Location = new System.Drawing.Point(122, 11);
            this.btnCorrect.Name = "btnCorrect";
            this.btnCorrect.Size = new System.Drawing.Size(90, 26);
            this.btnCorrect.TabIndex = 5;
            this.btnCorrect.Text = "Change C&ase";
            this.btnCorrect.UseVisualStyleBackColor = true;
            this.btnCorrect.Click += new System.EventHandler(this.btnCorrect_Click);
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(602, 49);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // txtContent
            // 
            this.txtContent.AcceptsReturn = true;
            this.txtContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtContent.HideSelection = false;
            this.txtContent.Location = new System.Drawing.Point(0, 49);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtContent.Size = new System.Drawing.Size(602, 397);
            this.txtContent.TabIndex = 1;
            this.txtContent.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtContent_KeyUp);
            // 
            // stsLogs
            // 
            this.stsLogs.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stsLogLabel});
            this.stsLogs.Location = new System.Drawing.Point(0, 424);
            this.stsLogs.Name = "stsLogs";
            this.stsLogs.Size = new System.Drawing.Size(602, 22);
            this.stsLogs.TabIndex = 4;
            this.stsLogs.Text = "statusStrip1";
            this.stsLogs.Visible = false;
            // 
            // stsLogLabel
            // 
            this.stsLogLabel.Name = "stsLogLabel";
            this.stsLogLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // btnAutoCorrect
            // 
            this.btnAutoCorrect.Location = new System.Drawing.Point(29, 12);
            this.btnAutoCorrect.Name = "btnAutoCorrect";
            this.btnAutoCorrect.Size = new System.Drawing.Size(77, 25);
            this.btnAutoCorrect.TabIndex = 3;
            this.btnAutoCorrect.Text = "&Correct";
            this.btnAutoCorrect.UseVisualStyleBackColor = true;
            this.btnAutoCorrect.Click += new System.EventHandler(this.btnAutoCorrect_Click);
            // 
            // StackEd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 446);
            this.Controls.Add(this.btnAutoCorrect);
            this.Controls.Add(this.stsLogs);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.btnCorrect);
            this.Controls.Add(this.splitter1);
            this.Name = "StackEd";
            this.Text = "StackEd";
            this.Load += new System.EventHandler(this.StackEd_Load);
            this.stsLogs.ResumeLayout(false);
            this.stsLogs.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCorrect;
        private System.Windows.Forms.Splitter splitter1;
        public System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.StatusStrip stsLogs;
        private System.Windows.Forms.ToolStripStatusLabel stsLogLabel;
        private System.Windows.Forms.Button btnAutoCorrect;
    }
}

