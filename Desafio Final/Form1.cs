using System;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;

namespace Desafio_Final
{
    public partial class Form1 : Form
    {
        PrivateFontCollection privateFontCollection = new PrivateFontCollection();

        public Form1()
        {
            InitializeComponent();
            CarregarFonte();
            StyleButton(Btn_login);
            StyleButton(Btn_signup);
            StyleTitle(label1);
        }

        private void CarregarFonte()
        {
            // Substitua "MinhaFonte" pelo nome real do arquivo da sua fonte (sem extensão)
            privateFontCollection.AddFontFile("C:/Users/Aluno/source/repos/Desafio-Final/Desafio Final/assets/CaviarDreams.ttf");
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
            button.MouseEnter += (sender, e) =>
            {
                // Altera a cor do fundo quando o mouse entra no botão
                button.BackColor = Color.FromArgb(138, 10, 10);
                button.Cursor = Cursors.Hand;
            };

            button.MouseLeave += (sender, e) =>
            {
                // Retorna à cor original quando o mouse deixa o botão
                button.BackColor = Color.Transparent; // Ou a cor original que você definiu
            };
            // Use o índice 0 para acessar a fonte carregada pela PrivateFontCollection
            Font minhaFonte = new Font(privateFontCollection.Families[0], 12, FontStyle.Regular);

            // Atribua a fonte ao botão
            button.Font = minhaFonte;

            // Adicione outras configurações de estilo conforme necessário
            button.BackColor = Color.Transparent;
            button.ForeColor = Color.White;
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 2;
            button.FlatAppearance.BorderColor = Color.White;
            button.Padding = new Padding(2);
        }

        private void Btn_login_Click(object sender, EventArgs e)
        {
            
            // Lógica para o clique no botão de login
        }

        private void Btn_signup_Click(object sender, EventArgs e)
        {
            // Lógica para o clique no botão de signup
        }

        
    }
}
