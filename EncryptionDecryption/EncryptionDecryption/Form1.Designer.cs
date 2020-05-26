namespace EncryptionDecryption
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
            this.text1 = new System.Windows.Forms.TextBox();
            this.lblt1 = new System.Windows.Forms.Label();
            this.lblt2 = new System.Windows.Forms.Label();
            this.text2 = new System.Windows.Forms.TextBox();
            this.gbET = new System.Windows.Forms.GroupBox();
            this.btnET = new System.Windows.Forms.Button();
            this.txtbET = new System.Windows.Forms.RichTextBox();
            this.lblET = new System.Windows.Forms.Label();
            this.gbDT = new System.Windows.Forms.GroupBox();
            this.btnDT = new System.Windows.Forms.Button();
            this.txtbDT = new System.Windows.Forms.RichTextBox();
            this.lblDT = new System.Windows.Forms.Label();
            this.gbET.SuspendLayout();
            this.gbDT.SuspendLayout();
            this.SuspendLayout();
            // 
            // text1
            // 
            this.text1.Location = new System.Drawing.Point(153, 19);
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(464, 20);
            this.text1.TabIndex = 0;
            // 
            // lblt1
            // 
            this.lblt1.AutoSize = true;
            this.lblt1.Location = new System.Drawing.Point(27, 26);
            this.lblt1.Name = "lblt1";
            this.lblt1.Size = new System.Drawing.Size(35, 13);
            this.lblt1.TabIndex = 1;
            this.lblt1.Text = "TEXT";
            // 
            // lblt2
            // 
            this.lblt2.AutoSize = true;
            this.lblt2.Location = new System.Drawing.Point(27, 26);
            this.lblt2.Name = "lblt2";
            this.lblt2.Size = new System.Drawing.Size(35, 13);
            this.lblt2.TabIndex = 2;
            this.lblt2.Text = "TEXT";
            // 
            // text2
            // 
            this.text2.Location = new System.Drawing.Point(153, 19);
            this.text2.Name = "text2";
            this.text2.Size = new System.Drawing.Size(464, 20);
            this.text2.TabIndex = 3;
            // 
            // gbET
            // 
            this.gbET.Controls.Add(this.btnET);
            this.gbET.Controls.Add(this.txtbET);
            this.gbET.Controls.Add(this.lblET);
            this.gbET.Controls.Add(this.text1);
            this.gbET.Controls.Add(this.lblt1);
            this.gbET.Location = new System.Drawing.Point(53, 67);
            this.gbET.Name = "gbET";
            this.gbET.Size = new System.Drawing.Size(776, 181);
            this.gbET.TabIndex = 4;
            this.gbET.TabStop = false;
            this.gbET.Text = "ENCRYPT";
            // 
            // btnET
            // 
            this.btnET.Location = new System.Drawing.Point(636, 112);
            this.btnET.Name = "btnET";
            this.btnET.Size = new System.Drawing.Size(122, 44);
            this.btnET.TabIndex = 4;
            this.btnET.Text = "ENCRYPT";
            this.btnET.UseVisualStyleBackColor = true;
            this.btnET.Click += new System.EventHandler(this.btnET_Click);
            // 
            // txtbET
            // 
            this.txtbET.Location = new System.Drawing.Point(153, 60);
            this.txtbET.Name = "txtbET";
            this.txtbET.Size = new System.Drawing.Size(464, 96);
            this.txtbET.TabIndex = 3;
            this.txtbET.Text = "";
            // 
            // lblET
            // 
            this.lblET.AutoSize = true;
            this.lblET.Location = new System.Drawing.Point(27, 63);
            this.lblET.Name = "lblET";
            this.lblET.Size = new System.Drawing.Size(104, 13);
            this.lblET.TabIndex = 2;
            this.lblET.Text = "ENCRYPTED TEXT";
            // 
            // gbDT
            // 
            this.gbDT.Controls.Add(this.btnDT);
            this.gbDT.Controls.Add(this.txtbDT);
            this.gbDT.Controls.Add(this.lblDT);
            this.gbDT.Controls.Add(this.text2);
            this.gbDT.Controls.Add(this.lblt2);
            this.gbDT.Location = new System.Drawing.Point(53, 283);
            this.gbDT.Name = "gbDT";
            this.gbDT.Size = new System.Drawing.Size(776, 181);
            this.gbDT.TabIndex = 5;
            this.gbDT.TabStop = false;
            this.gbDT.Text = "DECRYPT";
            // 
            // btnDT
            // 
            this.btnDT.Location = new System.Drawing.Point(636, 118);
            this.btnDT.Name = "btnDT";
            this.btnDT.Size = new System.Drawing.Size(122, 44);
            this.btnDT.TabIndex = 6;
            this.btnDT.Text = "DECRYPT";
            this.btnDT.UseVisualStyleBackColor = true;
            this.btnDT.Click += new System.EventHandler(this.btnDT_Click);
            // 
            // txtbDT
            // 
            this.txtbDT.Location = new System.Drawing.Point(153, 66);
            this.txtbDT.Name = "txtbDT";
            this.txtbDT.Size = new System.Drawing.Size(464, 96);
            this.txtbDT.TabIndex = 5;
            this.txtbDT.Text = "";
            // 
            // lblDT
            // 
            this.lblDT.AutoSize = true;
            this.lblDT.Location = new System.Drawing.Point(27, 69);
            this.lblDT.Name = "lblDT";
            this.lblDT.Size = new System.Drawing.Size(104, 13);
            this.lblDT.TabIndex = 4;
            this.lblDT.Text = "DECRYPTED TEXT";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 488);
            this.Controls.Add(this.gbDT);
            this.Controls.Add(this.gbET);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbET.ResumeLayout(false);
            this.gbET.PerformLayout();
            this.gbDT.ResumeLayout(false);
            this.gbDT.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox text1;
        private System.Windows.Forms.Label lblt1;
        private System.Windows.Forms.Label lblt2;
        private System.Windows.Forms.TextBox text2;
        private System.Windows.Forms.GroupBox gbET;
        private System.Windows.Forms.Button btnET;
        private System.Windows.Forms.RichTextBox txtbET;
        private System.Windows.Forms.Label lblET;
        private System.Windows.Forms.GroupBox gbDT;
        private System.Windows.Forms.Button btnDT;
        private System.Windows.Forms.RichTextBox txtbDT;
        private System.Windows.Forms.Label lblDT;
    }
}

