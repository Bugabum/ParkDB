namespace Park2
{
    partial class AracUpdate
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
            this.update_button = new System.Windows.Forms.Button();
            this.update_label = new System.Windows.Forms.Label();
            this.update_text = new System.Windows.Forms.RichTextBox();
            this.id_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // update_button
            // 
            this.update_button.Location = new System.Drawing.Point(63, 112);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(123, 55);
            this.update_button.TabIndex = 0;
            this.update_button.Text = "Güncelleştir";
            this.update_button.UseVisualStyleBackColor = true;
            this.update_button.Click += new System.EventHandler(this.update_button_Click);
            // 
            // update_label
            // 
            this.update_label.AutoSize = true;
            this.update_label.Location = new System.Drawing.Point(100, 20);
            this.update_label.Name = "update_label";
            this.update_label.Size = new System.Drawing.Size(45, 13);
            this.update_label.TabIndex = 1;
            this.update_label.Text = "attribute";
            // 
            // update_text
            // 
            this.update_text.Location = new System.Drawing.Point(12, 46);
            this.update_text.Name = "update_text";
            this.update_text.Size = new System.Drawing.Size(244, 60);
            this.update_text.TabIndex = 2;
            this.update_text.Text = "";
            // 
            // id_label
            // 
            this.id_label.AutoSize = true;
            this.id_label.Location = new System.Drawing.Point(29, 20);
            this.id_label.Name = "id_label";
            this.id_label.Size = new System.Drawing.Size(15, 13);
            this.id_label.TabIndex = 3;
            this.id_label.Text = "id";
            // 
            // AracUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 182);
            this.Controls.Add(this.id_label);
            this.Controls.Add(this.update_text);
            this.Controls.Add(this.update_label);
            this.Controls.Add(this.update_button);
            this.Name = "AracUpdate";
            this.Text = "AracUpdate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button update_button;
        private System.Windows.Forms.Label update_label;
        private System.Windows.Forms.RichTextBox update_text;
        private System.Windows.Forms.Label id_label;
    }
}