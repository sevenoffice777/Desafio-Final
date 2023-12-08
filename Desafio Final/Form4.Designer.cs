
namespace Desafio_Final
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dscr_curso_txtbox = new System.Windows.Forms.TextBox();
            this.btn_cad = new System.Windows.Forms.Button();
            this.prc_curso_txtbox = new System.Windows.Forms.TextBox();
            this.drc_txtbox = new System.Windows.Forms.TextBox();
            this.cod_curso_txtbox = new System.Windows.Forms.TextBox();
            this.nme_txtbox = new System.Windows.Forms.TextBox();
            this.dscr_curso_lbl = new System.Windows.Forms.Label();
            this.prc_curso_lbl = new System.Windows.Forms.Label();
            this.drc_lbl = new System.Windows.Forms.Label();
            this.cod_curso_lbl = new System.Windows.Forms.Label();
            this.nme_curso_lbl = new System.Windows.Forms.Label();
            this.title_cad_lbl = new System.Windows.Forms.Label();
            this.txtCad_lbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.dscr_curso_txtbox);
            this.groupBox1.Controls.Add(this.btn_cad);
            this.groupBox1.Controls.Add(this.prc_curso_txtbox);
            this.groupBox1.Controls.Add(this.drc_txtbox);
            this.groupBox1.Controls.Add(this.cod_curso_txtbox);
            this.groupBox1.Controls.Add(this.nme_txtbox);
            this.groupBox1.Controls.Add(this.dscr_curso_lbl);
            this.groupBox1.Controls.Add(this.prc_curso_lbl);
            this.groupBox1.Controls.Add(this.drc_lbl);
            this.groupBox1.Controls.Add(this.cod_curso_lbl);
            this.groupBox1.Controls.Add(this.nme_curso_lbl);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(701, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(446, 418);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CADASTRO";
            // 
            // dscr_curso_txtbox
            // 
            this.dscr_curso_txtbox.Location = new System.Drawing.Point(21, 312);
            this.dscr_curso_txtbox.Name = "dscr_curso_txtbox";
            this.dscr_curso_txtbox.Size = new System.Drawing.Size(412, 20);
            this.dscr_curso_txtbox.TabIndex = 11;
            // 
            // btn_cad
            // 
            this.btn_cad.Location = new System.Drawing.Point(22, 356);
            this.btn_cad.Name = "btn_cad";
            this.btn_cad.Size = new System.Drawing.Size(412, 43);
            this.btn_cad.TabIndex = 10;
            this.btn_cad.Text = "CADASTRAR";
            this.btn_cad.UseVisualStyleBackColor = true;
            this.btn_cad.Click += new System.EventHandler(this.btn_cad_Click);
            // 
            // prc_curso_txtbox
            // 
            this.prc_curso_txtbox.Location = new System.Drawing.Point(21, 246);
            this.prc_curso_txtbox.Name = "prc_curso_txtbox";
            this.prc_curso_txtbox.Size = new System.Drawing.Size(412, 20);
            this.prc_curso_txtbox.TabIndex = 8;
            this.prc_curso_txtbox.TextChanged += new System.EventHandler(this.prc_curso_txtbox_TextChanged);
            // 
            // drc_txtbox
            // 
            this.drc_txtbox.Location = new System.Drawing.Point(21, 172);
            this.drc_txtbox.Name = "drc_txtbox";
            this.drc_txtbox.Size = new System.Drawing.Size(412, 20);
            this.drc_txtbox.TabIndex = 7;
            // 
            // cod_curso_txtbox
            // 
            this.cod_curso_txtbox.Location = new System.Drawing.Point(22, 109);
            this.cod_curso_txtbox.Name = "cod_curso_txtbox";
            this.cod_curso_txtbox.Size = new System.Drawing.Size(411, 20);
            this.cod_curso_txtbox.TabIndex = 6;
            // 
            // nme_txtbox
            // 
            this.nme_txtbox.Location = new System.Drawing.Point(21, 52);
            this.nme_txtbox.Name = "nme_txtbox";
            this.nme_txtbox.Size = new System.Drawing.Size(412, 20);
            this.nme_txtbox.TabIndex = 5;
            // 
            // dscr_curso_lbl
            // 
            this.dscr_curso_lbl.AutoSize = true;
            this.dscr_curso_lbl.Location = new System.Drawing.Point(19, 282);
            this.dscr_curso_lbl.Name = "dscr_curso_lbl";
            this.dscr_curso_lbl.Size = new System.Drawing.Size(132, 13);
            this.dscr_curso_lbl.TabIndex = 4;
            this.dscr_curso_lbl.Text = "DESCRIÇÃO DO CURSO ";
            // 
            // prc_curso_lbl
            // 
            this.prc_curso_lbl.AutoSize = true;
            this.prc_curso_lbl.Location = new System.Drawing.Point(19, 216);
            this.prc_curso_lbl.Name = "prc_curso_lbl";
            this.prc_curso_lbl.Size = new System.Drawing.Size(110, 13);
            this.prc_curso_lbl.TabIndex = 3;
            this.prc_curso_lbl.Text = "PREÇO DO  CURSO ";
            // 
            // drc_lbl
            // 
            this.drc_lbl.AutoSize = true;
            this.drc_lbl.Location = new System.Drawing.Point(18, 143);
            this.drc_lbl.Name = "drc_lbl";
            this.drc_lbl.Size = new System.Drawing.Size(60, 13);
            this.drc_lbl.TabIndex = 2;
            this.drc_lbl.Text = "DURAÇÃO";
            // 
            // cod_curso_lbl
            // 
            this.cod_curso_lbl.AutoSize = true;
            this.cod_curso_lbl.Location = new System.Drawing.Point(19, 84);
            this.cod_curso_lbl.Name = "cod_curso_lbl";
            this.cod_curso_lbl.Size = new System.Drawing.Size(90, 13);
            this.cod_curso_lbl.TabIndex = 1;
            this.cod_curso_lbl.Text = "CÓDIGO CURSO";
            // 
            // nme_curso_lbl
            // 
            this.nme_curso_lbl.AutoSize = true;
            this.nme_curso_lbl.Location = new System.Drawing.Point(19, 27);
            this.nme_curso_lbl.Name = "nme_curso_lbl";
            this.nme_curso_lbl.Size = new System.Drawing.Size(102, 13);
            this.nme_curso_lbl.TabIndex = 0;
            this.nme_curso_lbl.Text = "NOME DO CURSO ";
            // 
            // title_cad_lbl
            // 
            this.title_cad_lbl.AutoSize = true;
            this.title_cad_lbl.Location = new System.Drawing.Point(54, 181);
            this.title_cad_lbl.Name = "title_cad_lbl";
            this.title_cad_lbl.Size = new System.Drawing.Size(132, 13);
            this.title_cad_lbl.TabIndex = 1;
            this.title_cad_lbl.Text = "CADASTRO DE CURSOS";
            // 
            // txtCad_lbl
            // 
            this.txtCad_lbl.AutoSize = true;
            this.txtCad_lbl.Location = new System.Drawing.Point(54, 252);
            this.txtCad_lbl.Name = "txtCad_lbl";
            this.txtCad_lbl.Size = new System.Drawing.Size(182, 13);
            this.txtCad_lbl.TabIndex = 2;
            this.txtCad_lbl.Text = "Cadastre seus cursos aqui na 7code!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 34);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Desafio_Final.Properties.Resources.background_container2;
            this.ClientSize = new System.Drawing.Size(1159, 455);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtCad_lbl);
            this.Controls.Add(this.title_cad_lbl);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "7CODE - CADASTRO DE CURSOS";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_cad;
        private System.Windows.Forms.TextBox prc_curso_txtbox;
        private System.Windows.Forms.TextBox drc_txtbox;
        private System.Windows.Forms.TextBox cod_curso_txtbox;
        private System.Windows.Forms.TextBox nme_txtbox;
        private System.Windows.Forms.Label dscr_curso_lbl;
        private System.Windows.Forms.Label prc_curso_lbl;
        private System.Windows.Forms.Label drc_lbl;
        private System.Windows.Forms.Label cod_curso_lbl;
        private System.Windows.Forms.Label nme_curso_lbl;
        private System.Windows.Forms.TextBox dscr_curso_txtbox;
        private System.Windows.Forms.Label title_cad_lbl;
        private System.Windows.Forms.Label txtCad_lbl;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}