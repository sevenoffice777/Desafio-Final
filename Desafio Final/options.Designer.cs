
namespace Desafio_Final
{
    partial class options
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(options));
            this.Cad_btn = new System.Windows.Forms.Button();
            this.upd_btn = new System.Windows.Forms.Button();
            this.slct_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Cad_btn
            // 
            this.Cad_btn.Location = new System.Drawing.Point(26, 113);
            this.Cad_btn.Name = "Cad_btn";
            this.Cad_btn.Size = new System.Drawing.Size(312, 36);
            this.Cad_btn.TabIndex = 0;
            this.Cad_btn.Text = "CADASTRAR";
            this.Cad_btn.UseVisualStyleBackColor = true;
            this.Cad_btn.Click += new System.EventHandler(this.cad_btn_Click);
            // 
            // upd_btn
            // 
            this.upd_btn.Location = new System.Drawing.Point(24, 189);
            this.upd_btn.Name = "upd_btn";
            this.upd_btn.Size = new System.Drawing.Size(314, 39);
            this.upd_btn.TabIndex = 1;
            this.upd_btn.Text = "ATUALIZAR";
            this.upd_btn.UseVisualStyleBackColor = true;
            this.upd_btn.Click += new System.EventHandler(this.upd_btn_Click);
            // 
            // slct_btn
            // 
            this.slct_btn.Location = new System.Drawing.Point(26, 276);
            this.slct_btn.Name = "slct_btn";
            this.slct_btn.Size = new System.Drawing.Size(312, 36);
            this.slct_btn.TabIndex = 2;
            this.slct_btn.Text = "BUSCAR";
            this.slct_btn.UseVisualStyleBackColor = true;
            this.slct_btn.Click += new System.EventHandler(this.slct_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(150, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "OPÇÕES";
            // 
            // options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Desafio_Final.Properties.Resources.background_container1;
            this.ClientSize = new System.Drawing.Size(362, 357);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.slct_btn);
            this.Controls.Add(this.upd_btn);
            this.Controls.Add(this.Cad_btn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "options";
            this.Text = "7CODE -OPÇÕES";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cad_btn;
        private System.Windows.Forms.Button upd_btn;
        private System.Windows.Forms.Button slct_btn;
        private System.Windows.Forms.Label label1;
    }
}