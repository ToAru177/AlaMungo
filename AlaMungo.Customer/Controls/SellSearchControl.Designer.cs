namespace AlaMungo.Customer.Controls
{
    partial class SellSearchControl
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txbPublisher = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.chbPublisher = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbWriter = new System.Windows.Forms.TextBox();
            this.txbTitle = new System.Windows.Forms.TextBox();
            this.chbWriter = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chbTitle = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txbPublisher);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.chbPublisher);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txbWriter);
            this.groupBox1.Controls.Add(this.txbTitle);
            this.groupBox1.Controls.Add(this.chbWriter);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.chbTitle);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(803, 48);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // txbPublisher
            // 
            this.txbPublisher.Location = new System.Drawing.Point(453, 17);
            this.txbPublisher.Name = "txbPublisher";
            this.txbPublisher.Size = new System.Drawing.Size(100, 21);
            this.txbPublisher.TabIndex = 12;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(722, 17);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "검색";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // chbPublisher
            // 
            this.chbPublisher.AutoSize = true;
            this.chbPublisher.Checked = true;
            this.chbPublisher.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbPublisher.Location = new System.Drawing.Point(377, 20);
            this.chbPublisher.Name = "chbPublisher";
            this.chbPublisher.Size = new System.Drawing.Size(15, 14);
            this.chbPublisher.TabIndex = 9;
            this.chbPublisher.UseVisualStyleBackColor = true;
            this.chbPublisher.CheckedChanged += new System.EventHandler(this.ChbPublisher_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(398, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "출판사 :";
            // 
            // txbWriter
            // 
            this.txbWriter.Location = new System.Drawing.Point(267, 17);
            this.txbWriter.Name = "txbWriter";
            this.txbWriter.Size = new System.Drawing.Size(100, 21);
            this.txbWriter.TabIndex = 7;
            // 
            // txbTitle
            // 
            this.txbTitle.Location = new System.Drawing.Point(94, 17);
            this.txbTitle.Name = "txbTitle";
            this.txbTitle.Size = new System.Drawing.Size(100, 21);
            this.txbTitle.TabIndex = 6;
            // 
            // chbWriter
            // 
            this.chbWriter.AutoSize = true;
            this.chbWriter.Checked = true;
            this.chbWriter.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbWriter.Location = new System.Drawing.Point(203, 20);
            this.chbWriter.Name = "chbWriter";
            this.chbWriter.Size = new System.Drawing.Size(15, 14);
            this.chbWriter.TabIndex = 5;
            this.chbWriter.UseVisualStyleBackColor = true;
            this.chbWriter.CheckedChanged += new System.EventHandler(this.ChbWriter_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(224, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "저자 :";
            // 
            // chbTitle
            // 
            this.chbTitle.AutoSize = true;
            this.chbTitle.Checked = true;
            this.chbTitle.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbTitle.Location = new System.Drawing.Point(14, 20);
            this.chbTitle.Name = "chbTitle";
            this.chbTitle.Size = new System.Drawing.Size(15, 14);
            this.chbTitle.TabIndex = 3;
            this.chbTitle.UseVisualStyleBackColor = true;
            this.chbTitle.CheckedChanged += new System.EventHandler(this.ChbTitle_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "책 제목 :";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // SellSearchControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "SellSearchControl";
            this.Size = new System.Drawing.Size(803, 67);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.CheckBox chbPublisher;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbWriter;
        private System.Windows.Forms.TextBox txbTitle;
        private System.Windows.Forms.CheckBox chbWriter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chbTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbPublisher;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}
