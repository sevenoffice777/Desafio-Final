
namespace Desafio_Final
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.codCurso_Slct_lbl = new System.Windows.Forms.Label();
            this.cod_curso_txtBox = new System.Windows.Forms.TextBox();
            this.title_slct_lbl = new System.Windows.Forms.Label();
            this.btn_slct = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.title_groupBox_lbl = new System.Windows.Forms.Label();
            this.desc_lbl = new System.Windows.Forms.Label();
            this.desc_ref_lbl = new System.Windows.Forms.Label();
            this.duracao_lbl = new System.Windows.Forms.Label();
            this.duracao_ref_lbl = new System.Windows.Forms.Label();
            this.preco_lbl = new System.Windows.Forms.Label();
            this.preco_ref_lbl = new System.Windows.Forms.Label();
            this.name_lbl = new System.Windows.Forms.Label();
            this.name_ref_lbl = new System.Windows.Forms.Label();
            this.cod_curso_lbl = new System.Windows.Forms.Label();
            this.cod_curso_ref_lbl = new System.Windows.Forms.Label();
            this.btn_updt = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // codCurso_Slct_lbl
            // 
            this.codCurso_Slct_lbl.AutoSize = true;
            this.codCurso_Slct_lbl.Location = new System.Drawing.Point(31, 246);
            this.codCurso_Slct_lbl.Name = "codCurso_Slct_lbl";
            this.codCurso_Slct_lbl.Size = new System.Drawing.Size(112, 13);
            this.codCurso_Slct_lbl.TabIndex = 0;
            this.codCurso_Slct_lbl.Text = "CODIGO DO CURSO ";
            // 
            // cod_curso_txtBox
            // 
            this.cod_curso_txtBox.Location = new System.Drawing.Point(31, 284);
            this.cod_curso_txtBox.Name = "cod_curso_txtBox";
            this.cod_curso_txtBox.Size = new System.Drawing.Size(174, 20);
            this.cod_curso_txtBox.TabIndex = 1;
            // 
            // title_slct_lbl
            // 
            this.title_slct_lbl.AutoSize = true;
            this.title_slct_lbl.Location = new System.Drawing.Point(12, 142);
            this.title_slct_lbl.Name = "title_slct_lbl";
            this.title_slct_lbl.Size = new System.Drawing.Size(65, 13);
            this.title_slct_lbl.TabIndex = 2;
            this.title_slct_lbl.Text = "CONSULTA";
            // 
            // btn_slct
            // 
            this.btn_slct.Location = new System.Drawing.Point(31, 336);
            this.btn_slct.Name = "btn_slct";
            this.btn_slct.Size = new System.Drawing.Size(171, 41);
            this.btn_slct.TabIndex = 3;
            this.btn_slct.Text = "CONSULTAR";
            this.btn_slct.UseVisualStyleBackColor = true;
            this.btn_slct.Click += new System.EventHandler(this.btn_slct_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.title_groupBox_lbl);
            this.groupBox1.Controls.Add(this.desc_lbl);
            this.groupBox1.Controls.Add(this.desc_ref_lbl);
            this.groupBox1.Controls.Add(this.duracao_lbl);
            this.groupBox1.Controls.Add(this.duracao_ref_lbl);
            this.groupBox1.Controls.Add(this.preco_lbl);
            this.groupBox1.Controls.Add(this.preco_ref_lbl);
            this.groupBox1.Controls.Add(this.name_lbl);
            this.groupBox1.Controls.Add(this.name_ref_lbl);
            this.groupBox1.Controls.Add(this.cod_curso_lbl);
            this.groupBox1.Controls.Add(this.cod_curso_ref_lbl);
            this.groupBox1.Location = new System.Drawing.Point(450, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(410, 380);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // title_groupBox_lbl
            // 
            this.title_groupBox_lbl.AutoSize = true;
            this.title_groupBox_lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.title_groupBox_lbl.Location = new System.Drawing.Point(88, 16);
            this.title_groupBox_lbl.Name = "title_groupBox_lbl";
            this.title_groupBox_lbl.Size = new System.Drawing.Size(52, 13);
            this.title_groupBox_lbl.TabIndex = 15;
            this.title_groupBox_lbl.Text = "CURSOS";
            // 
            // desc_lbl
            // 
            this.desc_lbl.AutoSize = true;
            this.desc_lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.desc_lbl.Location = new System.Drawing.Point(16, 335);
            this.desc_lbl.Name = "desc_lbl";
            this.desc_lbl.Size = new System.Drawing.Size(55, 13);
            this.desc_lbl.TabIndex = 13;
            this.desc_lbl.Text = "Descrição";
            // 
            // desc_ref_lbl
            // 
            this.desc_ref_lbl.AutoSize = true;
            this.desc_ref_lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.desc_ref_lbl.Location = new System.Drawing.Point(295, 334);
            this.desc_ref_lbl.Name = "desc_ref_lbl";
            this.desc_ref_lbl.Size = new System.Drawing.Size(103, 13);
            this.desc_ref_lbl.TabIndex = 14;
            this.desc_ref_lbl.Text = "________________";
            // 
            // duracao_lbl
            // 
            this.duracao_lbl.AutoSize = true;
            this.duracao_lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.duracao_lbl.Location = new System.Drawing.Point(16, 271);
            this.duracao_lbl.Name = "duracao_lbl";
            this.duracao_lbl.Size = new System.Drawing.Size(48, 13);
            this.duracao_lbl.TabIndex = 11;
            this.duracao_lbl.Text = "Duração";
            // 
            // duracao_ref_lbl
            // 
            this.duracao_ref_lbl.AutoSize = true;
            this.duracao_ref_lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.duracao_ref_lbl.Location = new System.Drawing.Point(295, 271);
            this.duracao_ref_lbl.Name = "duracao_ref_lbl";
            this.duracao_ref_lbl.Size = new System.Drawing.Size(103, 13);
            this.duracao_ref_lbl.TabIndex = 12;
            this.duracao_ref_lbl.Text = "________________";
            // 
            // preco_lbl
            // 
            this.preco_lbl.AutoSize = true;
            this.preco_lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.preco_lbl.Location = new System.Drawing.Point(16, 214);
            this.preco_lbl.Name = "preco_lbl";
            this.preco_lbl.Size = new System.Drawing.Size(35, 13);
            this.preco_lbl.TabIndex = 9;
            this.preco_lbl.Text = "Preço";
            // 
            // preco_ref_lbl
            // 
            this.preco_ref_lbl.AutoSize = true;
            this.preco_ref_lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.preco_ref_lbl.Location = new System.Drawing.Point(295, 216);
            this.preco_ref_lbl.Name = "preco_ref_lbl";
            this.preco_ref_lbl.Size = new System.Drawing.Size(103, 13);
            this.preco_ref_lbl.TabIndex = 10;
            this.preco_ref_lbl.Text = "________________";
            // 
            // name_lbl
            // 
            this.name_lbl.AutoSize = true;
            this.name_lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.name_lbl.Location = new System.Drawing.Point(16, 152);
            this.name_lbl.Name = "name_lbl";
            this.name_lbl.Size = new System.Drawing.Size(35, 13);
            this.name_lbl.TabIndex = 7;
            this.name_lbl.Text = "Nome";
            // 
            // name_ref_lbl
            // 
            this.name_ref_lbl.AutoSize = true;
            this.name_ref_lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.name_ref_lbl.Location = new System.Drawing.Point(295, 152);
            this.name_ref_lbl.Name = "name_ref_lbl";
            this.name_ref_lbl.Size = new System.Drawing.Size(103, 13);
            this.name_ref_lbl.TabIndex = 8;
            this.name_ref_lbl.Text = "________________";
            this.name_ref_lbl.Click += new System.EventHandler(this.name_ref_lbl_Click);
            // 
            // cod_curso_lbl
            // 
            this.cod_curso_lbl.AutoSize = true;
            this.cod_curso_lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cod_curso_lbl.Location = new System.Drawing.Point(16, 99);
            this.cod_curso_lbl.Name = "cod_curso_lbl";
            this.cod_curso_lbl.Size = new System.Drawing.Size(40, 13);
            this.cod_curso_lbl.TabIndex = 5;
            this.cod_curso_lbl.Text = "Código";
            // 
            // cod_curso_ref_lbl
            // 
            this.cod_curso_ref_lbl.AutoSize = true;
            this.cod_curso_ref_lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cod_curso_ref_lbl.Location = new System.Drawing.Point(295, 99);
            this.cod_curso_ref_lbl.Name = "cod_curso_ref_lbl";
            this.cod_curso_ref_lbl.Size = new System.Drawing.Size(103, 13);
            this.cod_curso_ref_lbl.TabIndex = 6;
            this.cod_curso_ref_lbl.Text = "________________";
            this.cod_curso_ref_lbl.Click += new System.EventHandler(this.label2_Click);
            // 
            // btn_updt
            // 
            this.btn_updt.Location = new System.Drawing.Point(208, 336);
            this.btn_updt.Name = "btn_updt";
            this.btn_updt.Size = new System.Drawing.Size(171, 41);
            this.btn_updt.TabIndex = 5;
            this.btn_updt.Text = "ATUALIZAR CURSO";
            this.btn_updt.UseVisualStyleBackColor = true;
            this.btn_updt.Click += new System.EventHandler(this.btn_updt_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Desafio_Final.Properties.Resources.back;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 34);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Desafio_Final.Properties.Resources.background_container1;
            this.ClientSize = new System.Drawing.Size(899, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_updt);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_slct);
            this.Controls.Add(this.title_slct_lbl);
            this.Controls.Add(this.cod_curso_txtBox);
            this.Controls.Add(this.codCurso_Slct_lbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "7CODE - CONSULTA DE CURSOS";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label codCurso_Slct_lbl;
        private System.Windows.Forms.TextBox cod_curso_txtBox;
        private System.Windows.Forms.Label title_slct_lbl;
        private System.Windows.Forms.Button btn_slct;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label cod_curso_lbl;
        private System.Windows.Forms.Label cod_curso_ref_lbl;
        private System.Windows.Forms.Label title_groupBox_lbl;
        private System.Windows.Forms.Label desc_lbl;
        private System.Windows.Forms.Label desc_ref_lbl;
        private System.Windows.Forms.Label duracao_lbl;
        private System.Windows.Forms.Label duracao_ref_lbl;
        private System.Windows.Forms.Label preco_lbl;
        private System.Windows.Forms.Label preco_ref_lbl;
        private System.Windows.Forms.Label name_lbl;
        private System.Windows.Forms.Label name_ref_lbl;
        private System.Windows.Forms.Button btn_updt;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}