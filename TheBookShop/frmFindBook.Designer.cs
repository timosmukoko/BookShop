namespace TheBookShop
{
    partial class frmFindBook
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
            this.lblEnterISBN = new System.Windows.Forms.Label();
            this.txtEnterISBN = new System.Windows.Forms.TextBox();
            this.txtBookFound = new System.Windows.Forms.TextBox();
            this.btnSearchFind = new System.Windows.Forms.Button();
            this.btnCancelFind = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEnterISBN
            // 
            this.lblEnterISBN.AutoSize = true;
            this.lblEnterISBN.Location = new System.Drawing.Point(29, 25);
            this.lblEnterISBN.Name = "lblEnterISBN";
            this.lblEnterISBN.Size = new System.Drawing.Size(60, 13);
            this.lblEnterISBN.TabIndex = 0;
            this.lblEnterISBN.Text = "Enter ISBN";
            // 
            // txtEnterISBN
            // 
            this.txtEnterISBN.Location = new System.Drawing.Point(122, 25);
            this.txtEnterISBN.Name = "txtEnterISBN";
            this.txtEnterISBN.Size = new System.Drawing.Size(152, 20);
            this.txtEnterISBN.TabIndex = 1;
            // 
            // txtBookFound
            // 
            this.txtBookFound.Location = new System.Drawing.Point(32, 61);
            this.txtBookFound.Multiline = true;
            this.txtBookFound.Name = "txtBookFound";
            this.txtBookFound.Size = new System.Drawing.Size(242, 123);
            this.txtBookFound.TabIndex = 2;
            // 
            // btnSearchFind
            // 
            this.btnSearchFind.Location = new System.Drawing.Point(32, 203);
            this.btnSearchFind.Name = "btnSearchFind";
            this.btnSearchFind.Size = new System.Drawing.Size(112, 23);
            this.btnSearchFind.TabIndex = 3;
            this.btnSearchFind.Text = "&Search";
            this.btnSearchFind.UseVisualStyleBackColor = true;
            this.btnSearchFind.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnCancelFind
            // 
            this.btnCancelFind.Location = new System.Drawing.Point(163, 203);
            this.btnCancelFind.Name = "btnCancelFind";
            this.btnCancelFind.Size = new System.Drawing.Size(111, 23);
            this.btnCancelFind.TabIndex = 4;
            this.btnCancelFind.Text = "&Cancel";
            this.btnCancelFind.UseVisualStyleBackColor = true;
            this.btnCancelFind.Click += new System.EventHandler(this.btnCancelFind_Click);
            // 
            // frmFindBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(298, 249);
            this.Controls.Add(this.btnCancelFind);
            this.Controls.Add(this.btnSearchFind);
            this.Controls.Add(this.txtBookFound);
            this.Controls.Add(this.txtEnterISBN);
            this.Controls.Add(this.lblEnterISBN);
            this.Name = "frmFindBook";
            this.Text = "Find Book";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnterISBN;
        private System.Windows.Forms.TextBox txtEnterISBN;
        private System.Windows.Forms.TextBox txtBookFound;
        private System.Windows.Forms.Button btnSearchFind;
        private System.Windows.Forms.Button btnCancelFind;
    }
}