namespace CheckPathListExist
{
    partial class Form1
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
            this.rtbInput = new System.Windows.Forms.RichTextBox();
            this.rtbOutput = new System.Windows.Forms.RichTextBox();
            this.btProcess = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btCopyResult = new System.Windows.Forms.Button();
            this.tbOriginalPath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbRaw = new System.Windows.Forms.TextBox();
            this.tbFormat = new System.Windows.Forms.TextBox();
            this.tbSplit = new System.Windows.Forms.TextBox();
            this.btCopyInFormat = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btClearRaw = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtbInput
            // 
            this.rtbInput.Location = new System.Drawing.Point(7, 6);
            this.rtbInput.Name = "rtbInput";
            this.rtbInput.Size = new System.Drawing.Size(369, 437);
            this.rtbInput.TabIndex = 0;
            this.rtbInput.Text = "";
            this.rtbInput.WordWrap = false;
            // 
            // rtbOutput
            // 
            this.rtbOutput.Location = new System.Drawing.Point(382, 6);
            this.rtbOutput.Name = "rtbOutput";
            this.rtbOutput.ReadOnly = true;
            this.rtbOutput.Size = new System.Drawing.Size(390, 437);
            this.rtbOutput.TabIndex = 1;
            this.rtbOutput.Text = "";
            this.rtbOutput.WordWrap = false;
            // 
            // btProcess
            // 
            this.btProcess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btProcess.Location = new System.Drawing.Point(129, 580);
            this.btProcess.Name = "btProcess";
            this.btProcess.Size = new System.Drawing.Size(111, 34);
            this.btProcess.TabIndex = 2;
            this.btProcess.Text = "PROCESS";
            this.btProcess.UseVisualStyleBackColor = true;
            this.btProcess.Click += new System.EventHandler(this.btProcess_Click);
            // 
            // btClear
            // 
            this.btClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btClear.Location = new System.Drawing.Point(12, 580);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(111, 34);
            this.btClear.TabIndex = 3;
            this.btClear.Text = "CLEAR";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Input List";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(384, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Output List";
            // 
            // btCopyResult
            // 
            this.btCopyResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btCopyResult.Location = new System.Drawing.Point(658, 580);
            this.btCopyResult.Name = "btCopyResult";
            this.btCopyResult.Size = new System.Drawing.Size(119, 34);
            this.btCopyResult.TabIndex = 6;
            this.btCopyResult.Text = "COPY RESULT";
            this.btCopyResult.UseVisualStyleBackColor = true;
            this.btCopyResult.Click += new System.EventHandler(this.btCopyResult_Click);
            // 
            // tbOriginalPath
            // 
            this.tbOriginalPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbOriginalPath.Location = new System.Drawing.Point(88, 547);
            this.tbOriginalPath.Name = "tbOriginalPath";
            this.tbOriginalPath.Size = new System.Drawing.Size(689, 20);
            this.tbOriginalPath.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 553);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Original Path:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rtbOutput);
            this.panel1.Controls.Add(this.rtbInput);
            this.panel1.Location = new System.Drawing.Point(12, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(765, 449);
            this.panel1.TabIndex = 9;
            // 
            // tbRaw
            // 
            this.tbRaw.Location = new System.Drawing.Point(88, 477);
            this.tbRaw.Name = "tbRaw";
            this.tbRaw.Size = new System.Drawing.Size(608, 20);
            this.tbRaw.TabIndex = 10;
            // 
            // tbFormat
            // 
            this.tbFormat.Location = new System.Drawing.Point(88, 513);
            this.tbFormat.Name = "tbFormat";
            this.tbFormat.Size = new System.Drawing.Size(530, 20);
            this.tbFormat.TabIndex = 11;
            // 
            // tbSplit
            // 
            this.tbSplit.Location = new System.Drawing.Point(624, 513);
            this.tbSplit.Name = "tbSplit";
            this.tbSplit.Size = new System.Drawing.Size(72, 20);
            this.tbSplit.TabIndex = 12;
            // 
            // btCopyInFormat
            // 
            this.btCopyInFormat.Location = new System.Drawing.Point(702, 513);
            this.btCopyInFormat.Name = "btCopyInFormat";
            this.btCopyInFormat.Size = new System.Drawing.Size(75, 20);
            this.btCopyInFormat.TabIndex = 13;
            this.btCopyInFormat.Text = "COPY";
            this.btCopyInFormat.UseVisualStyleBackColor = true;
            this.btCopyInFormat.Click += new System.EventHandler(this.btCopyInFormat_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 484);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Raw input";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 517);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Format output";
            // 
            // btClearRaw
            // 
            this.btClearRaw.Location = new System.Drawing.Point(702, 477);
            this.btClearRaw.Name = "btClearRaw";
            this.btClearRaw.Size = new System.Drawing.Size(75, 20);
            this.btClearRaw.TabIndex = 16;
            this.btClearRaw.Text = "CLEAR";
            this.btClearRaw.UseVisualStyleBackColor = true;
            this.btClearRaw.Click += new System.EventHandler(this.btClearRaw_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 626);
            this.Controls.Add(this.btClearRaw);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btCopyInFormat);
            this.Controls.Add(this.tbSplit);
            this.Controls.Add(this.tbFormat);
            this.Controls.Add(this.tbRaw);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbOriginalPath);
            this.Controls.Add(this.btCopyResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.btProcess);
            this.MinimumSize = new System.Drawing.Size(805, 595);
            this.Name = "Form1";
            this.Text = "Verify Path List !";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbInput;
        private System.Windows.Forms.RichTextBox rtbOutput;
        private System.Windows.Forms.Button btProcess;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btCopyResult;
        private System.Windows.Forms.TextBox tbOriginalPath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbRaw;
        private System.Windows.Forms.TextBox tbFormat;
        private System.Windows.Forms.TextBox tbSplit;
        private System.Windows.Forms.Button btCopyInFormat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btClearRaw;
    }
}

