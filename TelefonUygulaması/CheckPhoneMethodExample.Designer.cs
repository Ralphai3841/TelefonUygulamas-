
namespace TelefonUygulaması
{
    partial class CheckPhoneMethodExample
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
            this.btnCheckPhone = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCheckPhone
            // 
            this.btnCheckPhone.BackColor = System.Drawing.Color.DimGray;
            this.btnCheckPhone.Location = new System.Drawing.Point(316, 135);
            this.btnCheckPhone.Name = "btnCheckPhone";
            this.btnCheckPhone.Size = new System.Drawing.Size(180, 97);
            this.btnCheckPhone.TabIndex = 0;
            this.btnCheckPhone.Text = "Kontrol Et";
            this.btnCheckPhone.UseVisualStyleBackColor = false;
            this.btnCheckPhone.Click += new System.EventHandler(this.btnCheckPhone_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Phone :";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(181, 164);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(100, 22);
            this.txtPhoneNumber.TabIndex = 2;
            // 
            // CheckPhoneMethodExample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCheckPhone);
            this.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Name = "CheckPhoneMethodExample";
            this.Text = "CheckPhoneMethodExample";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCheckPhone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPhoneNumber;
    }
}