namespace QRBarkodOlusturma
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
            this.qrTextTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.olusturBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.qrText2Txt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // qrTextTxt
            // 
            this.qrTextTxt.Location = new System.Drawing.Point(113, 42);
            this.qrTextTxt.Name = "qrTextTxt";
            this.qrTextTxt.Size = new System.Drawing.Size(264, 20);
            this.qrTextTxt.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Barkod Text 1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(114, 104);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(207, 164);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // olusturBtn
            // 
            this.olusturBtn.Location = new System.Drawing.Point(120, 289);
            this.olusturBtn.Name = "olusturBtn";
            this.olusturBtn.Size = new System.Drawing.Size(190, 39);
            this.olusturBtn.TabIndex = 3;
            this.olusturBtn.Text = "Barkod Oluştur";
            this.olusturBtn.UseVisualStyleBackColor = true;
            this.olusturBtn.Click += new System.EventHandler(this.olusturBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Barkod Text 2";
            // 
            // qrText2Txt
            // 
            this.qrText2Txt.Location = new System.Drawing.Point(113, 68);
            this.qrText2Txt.Name = "qrText2Txt";
            this.qrText2Txt.Size = new System.Drawing.Size(264, 20);
            this.qrText2Txt.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 349);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.qrText2Txt);
            this.Controls.Add(this.olusturBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.qrTextTxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Barkod Oluşturma Ekranı";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox qrTextTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button olusturBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox qrText2Txt;
    }
}

