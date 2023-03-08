namespace NumSquence
{
    partial class frmSequence
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtStart = new System.Windows.Forms.TextBox();
            this.cmbNum = new System.Windows.Forms.ComboBox();
            this.chkList = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEnd = new System.Windows.Forms.TextBox();
            this.chkCombo = new System.Windows.Forms.CheckBox();
            this.IsNum = new System.Windows.Forms.ListBox();
            this.rbEven = new System.Windows.Forms.RadioButton();
            this.rbOdd = new System.Windows.Forms.RadioButton();
            this.rbDiv = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Start";
            // 
            // txtStart
            // 
            this.txtStart.Location = new System.Drawing.Point(171, 43);
            this.txtStart.Name = "txtStart";
            this.txtStart.Size = new System.Drawing.Size(138, 20);
            this.txtStart.TabIndex = 2;
            // 
            // cmbNum
            // 
            this.cmbNum.FormattingEnabled = true;
            this.cmbNum.Location = new System.Drawing.Point(235, 149);
            this.cmbNum.Name = "cmbNum";
            this.cmbNum.Size = new System.Drawing.Size(121, 21);
            this.cmbNum.TabIndex = 3;
            this.cmbNum.Visible = false;
            this.cmbNum.SelectedIndexChanged += new System.EventHandler(this.cmbNum_SelectedIndexChanged);
            // 
            // chkList
            // 
            this.chkList.AutoSize = true;
            this.chkList.Location = new System.Drawing.Point(429, 42);
            this.chkList.Name = "chkList";
            this.chkList.Size = new System.Drawing.Size(63, 17);
            this.chkList.TabIndex = 4;
            this.chkList.Text = "List Box";
            this.chkList.UseVisualStyleBackColor = true;
            this.chkList.CheckedChanged += new System.EventHandler(this.chkList_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "End";
            // 
            // txtEnd
            // 
            this.txtEnd.Location = new System.Drawing.Point(171, 74);
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Size = new System.Drawing.Size(138, 20);
            this.txtEnd.TabIndex = 2;
            this.txtEnd.TextChanged += new System.EventHandler(this.txtEnd_TextChanged);
            // 
            // chkCombo
            // 
            this.chkCombo.AutoSize = true;
            this.chkCombo.Location = new System.Drawing.Point(429, 73);
            this.chkCombo.Name = "chkCombo";
            this.chkCombo.Size = new System.Drawing.Size(80, 17);
            this.chkCombo.TabIndex = 4;
            this.chkCombo.Text = "Combo Box";
            this.chkCombo.UseVisualStyleBackColor = true;
            this.chkCombo.CheckedChanged += new System.EventHandler(this.chkCombo_CheckedChanged);
            // 
            // IsNum
            // 
            this.IsNum.FormattingEnabled = true;
            this.IsNum.Location = new System.Drawing.Point(75, 137);
            this.IsNum.Name = "IsNum";
            this.IsNum.Size = new System.Drawing.Size(120, 173);
            this.IsNum.TabIndex = 5;
            this.IsNum.Visible = false;
            this.IsNum.SelectedIndexChanged += new System.EventHandler(this.IsNum_SelectedIndexChanged);
            // 
            // rbEven
            // 
            this.rbEven.AutoSize = true;
            this.rbEven.Location = new System.Drawing.Point(429, 109);
            this.rbEven.Name = "rbEven";
            this.rbEven.Size = new System.Drawing.Size(50, 17);
            this.rbEven.TabIndex = 6;
            this.rbEven.TabStop = true;
            this.rbEven.Text = "Even";
            this.rbEven.UseVisualStyleBackColor = true;
            this.rbEven.CheckedChanged += new System.EventHandler(this.rbEven_CheckedChanged);
            // 
            // rbOdd
            // 
            this.rbOdd.AutoSize = true;
            this.rbOdd.Location = new System.Drawing.Point(429, 132);
            this.rbOdd.Name = "rbOdd";
            this.rbOdd.Size = new System.Drawing.Size(45, 17);
            this.rbOdd.TabIndex = 6;
            this.rbOdd.TabStop = true;
            this.rbOdd.Text = "Odd";
            this.rbOdd.UseVisualStyleBackColor = true;
            this.rbOdd.CheckedChanged += new System.EventHandler(this.rbOdd_CheckedChanged);
            // 
            // rbDiv
            // 
            this.rbDiv.AutoSize = true;
            this.rbDiv.Location = new System.Drawing.Point(429, 155);
            this.rbDiv.Name = "rbDiv";
            this.rbDiv.Size = new System.Drawing.Size(87, 17);
            this.rbDiv.TabIndex = 6;
            this.rbDiv.TabStop = true;
            this.rbDiv.Text = "Divisible by 5";
            this.rbDiv.UseVisualStyleBackColor = true;
            this.rbDiv.CheckedChanged += new System.EventHandler(this.rbDiv_CheckedChanged);
            // 
            // frmSequence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rbDiv);
            this.Controls.Add(this.rbOdd);
            this.Controls.Add(this.rbEven);
            this.Controls.Add(this.IsNum);
            this.Controls.Add(this.chkCombo);
            this.Controls.Add(this.chkList);
            this.Controls.Add(this.cmbNum);
            this.Controls.Add(this.txtEnd);
            this.Controls.Add(this.txtStart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmSequence";
            this.Text = "Number Sequence";
            this.Load += new System.EventHandler(this.frmSequence_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStart;
        private System.Windows.Forms.ComboBox cmbNum;
        private System.Windows.Forms.CheckBox chkList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEnd;
        private System.Windows.Forms.CheckBox chkCombo;
        private System.Windows.Forms.ListBox IsNum;
        private System.Windows.Forms.RadioButton rbEven;
        private System.Windows.Forms.RadioButton rbOdd;
        private System.Windows.Forms.RadioButton rbDiv;
    }
}

