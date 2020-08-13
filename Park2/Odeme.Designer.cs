namespace Park2
{
    partial class Odeme
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
            this.text_marka = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.text_model = new System.Windows.Forms.RichTextBox();
            this.text_renk = new System.Windows.Forms.RichTextBox();
            this.text_plaka = new System.Windows.Forms.RichTextBox();
            this.text_giris = new System.Windows.Forms.RichTextBox();
            this.text_ucret = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button_update = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // text_marka
            // 
            this.text_marka.Location = new System.Drawing.Point(55, 76);
            this.text_marka.Name = "text_marka";
            this.text_marka.Size = new System.Drawing.Size(193, 39);
            this.text_marka.TabIndex = 0;
            this.text_marka.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Marka";
            // 
            // text_model
            // 
            this.text_model.Location = new System.Drawing.Point(312, 76);
            this.text_model.Name = "text_model";
            this.text_model.Size = new System.Drawing.Size(193, 39);
            this.text_model.TabIndex = 2;
            this.text_model.Text = "";
            // 
            // text_renk
            // 
            this.text_renk.Location = new System.Drawing.Point(547, 76);
            this.text_renk.Name = "text_renk";
            this.text_renk.Size = new System.Drawing.Size(193, 39);
            this.text_renk.TabIndex = 3;
            this.text_renk.Text = "";
            // 
            // text_plaka
            // 
            this.text_plaka.Location = new System.Drawing.Point(55, 160);
            this.text_plaka.Name = "text_plaka";
            this.text_plaka.Size = new System.Drawing.Size(193, 39);
            this.text_plaka.TabIndex = 4;
            this.text_plaka.Text = "";
            // 
            // text_giris
            // 
            this.text_giris.Location = new System.Drawing.Point(312, 160);
            this.text_giris.Name = "text_giris";
            this.text_giris.Size = new System.Drawing.Size(193, 39);
            this.text_giris.TabIndex = 5;
            this.text_giris.Text = "";
            // 
            // text_ucret
            // 
            this.text_ucret.Location = new System.Drawing.Point(547, 160);
            this.text_ucret.Name = "text_ucret";
            this.text_ucret.Size = new System.Drawing.Size(193, 39);
            this.text_ucret.TabIndex = 6;
            this.text_ucret.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(309, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Model";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(544, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Renk";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Plaka";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(309, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Giriş Zamani";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(544, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Ucret";
            // 
            // button_update
            // 
            this.button_update.Location = new System.Drawing.Point(184, 253);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(161, 71);
            this.button_update.TabIndex = 12;
            this.button_update.Text = "Araç Bilgilerini Güncelle";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // button_exit
            // 
            this.button_exit.Location = new System.Drawing.Point(416, 253);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(161, 71);
            this.button_exit.TabIndex = 13;
            this.button_exit.Text = "Araç Çıkışı";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // Odeme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.text_ucret);
            this.Controls.Add(this.text_giris);
            this.Controls.Add(this.text_plaka);
            this.Controls.Add(this.text_renk);
            this.Controls.Add(this.text_model);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_marka);
            this.Name = "Odeme";
            this.Text = "Odeme";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox text_marka;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox text_model;
        private System.Windows.Forms.RichTextBox text_renk;
        private System.Windows.Forms.RichTextBox text_plaka;
        private System.Windows.Forms.RichTextBox text_giris;
        private System.Windows.Forms.RichTextBox text_ucret;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button_exit;
    }
}