namespace WordCards
{
    partial class frmEditWord
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
            this.grpWord = new System.Windows.Forms.GroupBox();
            this.grpPhonogram = new System.Windows.Forms.GroupBox();
            this.grpSoundPath = new System.Windows.Forms.GroupBox();
            this.grpExplain = new System.Windows.Forms.GroupBox();
            this.txtWord = new System.Windows.Forms.TextBox();
            this.txtPhonogram = new System.Windows.Forms.TextBox();
            this.txtSoundPath = new System.Windows.Forms.TextBox();
            this.txtExplain = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.grpWord.SuspendLayout();
            this.grpPhonogram.SuspendLayout();
            this.grpSoundPath.SuspendLayout();
            this.grpExplain.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpWord
            // 
            this.grpWord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(245)))), ((int)(((byte)(253)))));
            this.grpWord.Controls.Add(this.txtWord);
            this.grpWord.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.grpWord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(95)))), ((int)(((byte)(165)))));
            this.grpWord.Location = new System.Drawing.Point(71, 34);
            this.grpWord.Name = "grpWord";
            this.grpWord.Size = new System.Drawing.Size(491, 109);
            this.grpWord.TabIndex = 0;
            this.grpWord.TabStop = false;
            this.grpWord.Text = "單字";
            // 
            // grpPhonogram
            // 
            this.grpPhonogram.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(248)))), ((int)(((byte)(244)))));
            this.grpPhonogram.Controls.Add(this.txtPhonogram);
            this.grpPhonogram.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.grpPhonogram.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(110)))), ((int)(((byte)(86)))));
            this.grpPhonogram.Location = new System.Drawing.Point(71, 155);
            this.grpPhonogram.Name = "grpPhonogram";
            this.grpPhonogram.Size = new System.Drawing.Size(491, 109);
            this.grpPhonogram.TabIndex = 1;
            this.grpPhonogram.TabStop = false;
            this.grpPhonogram.Text = "音標";
            // 
            // grpSoundPath
            // 
            this.grpSoundPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(239)))), ((int)(((byte)(254)))));
            this.grpSoundPath.Controls.Add(this.txtSoundPath);
            this.grpSoundPath.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.grpSoundPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(74)))), ((int)(((byte)(183)))));
            this.grpSoundPath.Location = new System.Drawing.Point(71, 284);
            this.grpSoundPath.Name = "grpSoundPath";
            this.grpSoundPath.Size = new System.Drawing.Size(491, 109);
            this.grpSoundPath.TabIndex = 1;
            this.grpSoundPath.TabStop = false;
            this.grpSoundPath.Text = "音檔路徑";
            // 
            // grpExplain
            // 
            this.grpExplain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(245)))), ((int)(((byte)(238)))));
            this.grpExplain.Controls.Add(this.txtExplain);
            this.grpExplain.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.grpExplain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(79)))), ((int)(((byte)(11)))));
            this.grpExplain.Location = new System.Drawing.Point(71, 408);
            this.grpExplain.Name = "grpExplain";
            this.grpExplain.Size = new System.Drawing.Size(491, 322);
            this.grpExplain.TabIndex = 1;
            this.grpExplain.TabStop = false;
            this.grpExplain.Text = "解釋";
            // 
            // txtWord
            // 
            this.txtWord.BackColor = System.Drawing.Color.White;
            this.txtWord.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtWord.Enabled = false;
            this.txtWord.Location = new System.Drawing.Point(16, 43);
            this.txtWord.Name = "txtWord";
            this.txtWord.Size = new System.Drawing.Size(461, 43);
            this.txtWord.TabIndex = 0;
            // 
            // txtPhonogram
            // 
            this.txtPhonogram.BackColor = System.Drawing.Color.White;
            this.txtPhonogram.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPhonogram.Location = new System.Drawing.Point(16, 46);
            this.txtPhonogram.Name = "txtPhonogram";
            this.txtPhonogram.Size = new System.Drawing.Size(461, 43);
            this.txtPhonogram.TabIndex = 1;
            // 
            // txtSoundPath
            // 
            this.txtSoundPath.BackColor = System.Drawing.Color.White;
            this.txtSoundPath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSoundPath.Location = new System.Drawing.Point(16, 47);
            this.txtSoundPath.Name = "txtSoundPath";
            this.txtSoundPath.Size = new System.Drawing.Size(461, 43);
            this.txtSoundPath.TabIndex = 2;
            // 
            // txtExplain
            // 
            this.txtExplain.BackColor = System.Drawing.Color.White;
            this.txtExplain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtExplain.Location = new System.Drawing.Point(16, 49);
            this.txtExplain.Multiline = true;
            this.txtExplain.Name = "txtExplain";
            this.txtExplain.Size = new System.Drawing.Size(461, 247);
            this.txtExplain.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(95)))), ((int)(((byte)(165)))));
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnSave.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(420, 749);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(142, 63);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "儲存";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmEditWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(640, 849);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grpExplain);
            this.Controls.Add(this.grpSoundPath);
            this.Controls.Add(this.grpPhonogram);
            this.Controls.Add(this.grpWord);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmEditWord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "編輯單字";
            this.grpWord.ResumeLayout(false);
            this.grpWord.PerformLayout();
            this.grpPhonogram.ResumeLayout(false);
            this.grpPhonogram.PerformLayout();
            this.grpSoundPath.ResumeLayout(false);
            this.grpSoundPath.PerformLayout();
            this.grpExplain.ResumeLayout(false);
            this.grpExplain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpWord;
        private System.Windows.Forms.GroupBox grpPhonogram;
        private System.Windows.Forms.GroupBox grpSoundPath;
        private System.Windows.Forms.GroupBox grpExplain;
        private System.Windows.Forms.TextBox txtWord;
        private System.Windows.Forms.TextBox txtPhonogram;
        private System.Windows.Forms.TextBox txtSoundPath;
        private System.Windows.Forms.TextBox txtExplain;
        private System.Windows.Forms.Button btnSave;
    }
}