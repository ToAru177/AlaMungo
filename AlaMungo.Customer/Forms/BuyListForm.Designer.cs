namespace AlaMungo.Customer
{
    partial class BuyListForm
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
            this.buySearchControl1 = new AlaMungo.Customer.Controls.BuySearchControl();
            this.buyListControl1 = new AlaMungo.Customer.Controls.BuyListControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buySearchControl1
            // 
            this.buySearchControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.buySearchControl1.Location = new System.Drawing.Point(0, 0);
            this.buySearchControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buySearchControl1.Name = "buySearchControl1";
            this.buySearchControl1.Size = new System.Drawing.Size(925, 69);
            this.buySearchControl1.TabIndex = 0;
            // 
            // buyListControl1
            // 
            this.buyListControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buyListControl1.Location = new System.Drawing.Point(0, 69);
            this.buyListControl1.Name = "buyListControl1";
            this.buyListControl1.Size = new System.Drawing.Size(925, 426);
            this.buyListControl1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 435);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(925, 60);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(838, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "종료(&X)";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // BuyListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 495);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buyListControl1);
            this.Controls.Add(this.buySearchControl1);
            this.Name = "BuyListForm";
            this.Text = "BuyListForm";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.BuySearchControl buySearchControl1;
        private Controls.BuyListControl buyListControl1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
    }
}