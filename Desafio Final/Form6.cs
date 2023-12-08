using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Desafio_Final
{
    public partial class Form6 : Form
    {
        PrivateFontCollection privateFontCollection = new PrivateFontCollection();

        public Form6()
        {
            InitializeComponent();
            CarregarFonte();
            StyleButton(btn_upd);
            StyleTitle(titleUpdt_lbl);
            StyleText(txtUpdt_lbl);
            StyleText(cod_curso_lbl);
            StyleText(drc_lbl);
            StyleText(nme_curso_lbl);
            StyleText(prc_curso_lbl);
            StyleText(dscr_curso_lbl);
        }



        private void CarregarFonte()
        {
            // Substitua "MinhaFonte" pelo nome real do arquivo da sua fonte (sem extensão)
            privateFontCollection.AddFontFile("C:/Users/Aluno/Desktop/Desafio-Final/Desafio Final/assets/CaviarDreams.ttf");
            // Passivo de mudança DEPENDENDO DO USUARIO E CAMINHO

        }


        private void StyleText(Label labelText)
        {

            Font minhaFonte = new Font(privateFontCollection.Families[0], 12, FontStyle.Regular);
            labelText.Font = minhaFonte;
            labelText.ForeColor = Color.White;
            labelText.BackColor = Color.Transparent;
        }


        private void StyleTitle(Label labelTitle)
        {
            Font minhaFonte = new Font(privateFontCollection.Families[0], 40, FontStyle.Regular);

            labelTitle.Font = minhaFonte;
            labelTitle.ForeColor = Color.White;
            labelTitle.BackColor = Color.Transparent;
        }

        public void StyleButton(Button button)
        {
            Font minhaFonte = new Font(privateFontCollection.Families[0], 12, FontStyle.Regular);

            // Atribua a fonte ao botão
            button.Font = minhaFonte;

            // Adicione outras configurações de estilo conforme necessário
            button.BackColor = Color.Red;
            button.ForeColor = Color.White;
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 1;
            button.FlatAppearance.BorderColor = Color.FromArgb(138, 10, 10);
            button.BackColor = Color.FromArgb(138, 10, 10); // Ou a cor original que você definiu
            button.Padding = new Padding(2);
            button.MouseEnter += (sender, e) =>
            {
                // Altera a cor do fundo quando o mouse entra no botão
                button.FlatAppearance.BorderColor = Color.Red;
                button.BackColor = Color.Red;
                button.Cursor = Cursors.Hand;
            };

            button.MouseLeave += (sender, e) =>
            {
                button.FlatAppearance.BorderColor = Color.FromArgb(138, 10, 10);
                // Retorna à cor original quando o mouse deixa o botão
                button.BackColor = Color.FromArgb(138, 10, 10); // Ou a cor original que você definiu
            };
            // Use o índice 0 para acessar a fonte carregada pela PrivateFontCollection

        }
        private void btn_cad_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            options opt = new options();
            this.Hide();
            opt.Show();
        }
    }
}
