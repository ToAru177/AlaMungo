﻿namespace AlaMungo.Customer.Controls
{
    partial class InvoiceSearchControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chbToDate = new System.Windows.Forms.CheckBox();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txbTitle = new System.Windows.Forms.TextBox();
            this.chbFromDate = new System.Windows.Forms.CheckBox();
            this.chbTitle = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chbToDate);
            this.groupBox1.Controls.Add(this.dtpToDate);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtpFromDate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.txbTitle);
            this.groupBox1.Controls.Add(this.chbFromDate);
            this.groupBox1.Controls.Add(this.chbTitle);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(633, 48);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // chbToDate
            // 
            this.chbToDate.AutoSize = true;
            this.chbToDate.Checked = true;
            this.chbToDate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbToDate.Location = new System.Drawing.Point(410, 20);
            this.chbToDate.Name = "chbToDate";
            this.chbToDate.Size = new System.Drawing.Size(15, 14);
            this.chbToDate.TabIndex = 16;
            this.chbToDate.UseVisualStyleBackColor = true;
            this.chbToDate.CheckedChanged += new System.EventHandler(this.ChbToDate_CheckedChanged);
            // 
            // dtpToDate
            // 
            this.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpToDate.Location = new System.Drawing.Point(431, 17);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(101, 21);
            this.dtpToDate.TabIndex = 15;
            this.dtpToDate.Value = new System.DateTime(2019, 6, 21, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(390, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 12);
            this.label3.TabIndex = 14;
            this.label3.Text = "~";
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFromDate.Location = new System.Drawing.Point(283, 17);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(101, 21);
            this.dtpFromDate.TabIndex = 13;
            this.dtpFromDate.Value = new System.DateTime(2019, 6, 21, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 12);
            this.label2.TabIndex = 12;
            this.label2.Text = "구매일시 :";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(552, 17);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "검색";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // txbTitle
            // 
            this.txbTitle.Location = new System.Drawing.Point(86, 17);
            this.txbTitle.Name = "txbTitle";
            this.txbTitle.Size = new System.Drawing.Size(100, 21);
            this.txbTitle.TabIndex = 6;
            // 
            // chbFromDate
            // 
            this.chbFromDate.AutoSize = true;
            this.chbFromDate.Checked = true;
            this.chbFromDate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbFromDate.Location = new System.Drawing.Point(195, 20);
            this.chbFromDate.Name = "chbFromDate";
            this.chbFromDate.Size = new System.Drawing.Size(15, 14);
            this.chbFromDate.TabIndex = 5;
            this.chbFromDate.UseVisualStyleBackColor = true;
            this.chbFromDate.CheckedChanged += new System.EventHandler(this.ChbFromDate_CheckedChanged);
            // 
            // chbTitle
            // 
            this.chbTitle.AutoSize = true;
            this.chbTitle.Checked = true;
            this.chbTitle.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbTitle.Location = new System.Drawing.Point(6, 20);
            this.chbTitle.Name = "chbTitle";
            this.chbTitle.Size = new System.Drawing.Size(15, 14);
            this.chbTitle.TabIndex = 3;
            this.chbTitle.UseVisualStyleBackColor = true;
            this.chbTitle.CheckedChanged += new System.EventHandler(this.ChbTitle_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "책 제목 :";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(86, 60);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 20);
            this.comboBox1.TabIndex = 10;
            // 
            // InvoiceSearchControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "InvoiceSearchControl";
            this.Size = new System.Drawing.Size(633, 83);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txbTitle;
        private System.Windows.Forms.CheckBox chbFromDate;
        private System.Windows.Forms.CheckBox chbTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chbToDate;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}
