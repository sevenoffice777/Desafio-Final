
namespace Desafio_Final
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
            this.Btn_login = new System.Windows.Forms.Button();
            this.Btn_signup = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btn_login
            // 
            this.Btn_login.Location = new System.Drawing.Point(242, 225);
            this.Btn_login.Name = "Btn_login";
            this.Btn_login.Size = new System.Drawing.Size(116, 37);
            this.Btn_login.TabIndex = 0;
            this.Btn_login.Text = "Login";
            this.Btn_login.UseVisualStyleBackColor = false;
            this.Btn_login.Click += new System.EventHandler(this.Btn_login_Click);
            // 
            // Btn_signup
            // 
            this.Btn_signup.Location = new System.Drawing.Point(380, 225);
            this.Btn_signup.Name = "Btn_signup";
            this.Btn_signup.Size = new System.Drawing.Size(146, 37);
            this.Btn_signup.TabIndex = 1;
            this.Btn_signup.Text = "Cadastrar";
            this.Btn_signup.UseVisualStyleBackColor = false;
            this.Btn_signup.Click += new System.EventHandler(this.Btn_signup_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(339, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "7 CODE HUB";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Desafio_Final.Properties.Resources.background_container1;
            this.ClientSize = new System.Drawing.Size(750, 420);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_signup);
            this.Controls.Add(this.Btn_login);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_login;
        private System.Windows.Forms.Button Btn_signup;
        private System.Windows.Forms.Label label1;
    }
}

