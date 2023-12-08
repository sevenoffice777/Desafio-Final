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
    public partial class Form3 : Form
    {
        PrivateFontCollection privateFontCollection = new PrivateFontCollection();

        public Form3()
        {
            InitializeComponent();
            CarregarFonte();
            StyleButton(btn_signup);
            StyleTitle(titleLbl);
            StyleText(textLbl);
            
        }

        private void CarregarFonte()
        {
            // Substitua "MinhaFonte" pelo nome real do arquivo da sua fonte (sem extensão)
            privateFontCollection.AddFontFile("C:/Users/Aluno/Desktop/Desafio-Final/Desafio Final/assets/CaviarDreams.ttf");
        }

        private void StyleText(Label labelText)
        {
            Font minhaFonte = new Font(privateFontCollection.Families[0], 12, FontStyle.Regular);
            labelText.Location = new System.Drawing.Point(50, 256);
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
            Font minhaFonte = new Font(privateFontCollection.Families[0], 12, FontStyle.Regular);

            // Atribua a fonte ao botão
            button.Font = minhaFonte;

            // Adicione outras configurações de estilo conforme necessário
            button.BackColor = Color.Red;
            button.ForeColor = Color.White;
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 1;
            button.FlatAppearance.BorderColor = Color.Red;
            button.Padding = new Padding(2);
        }



        private void lbl_linkForm2_Click(object sender, EventArgs e)
        {
            Form2 formLogin = new Form2();
            this.Hide();
            formLogin.ShowDialog();
        }

        private void btn_signup_Click(object sender, EventArgs e)
        {
            string nome = textBox1.Text;
            string password = textBox2.Text;

            string conn = "Server=localhost;Database=7code;User=root;";
            string insertSQL = "INSERT INTO userData(nome, senha) VALUES (@Usuario, @Senha)";

            using (MySqlConnection connection = new MySqlConnection(conn))
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(insertSQL, connection))
                {
                    // Adiciona os parâmetros à consulta SQL
                    command.Parameters.AddWithValue("@Usuario", nome);
                    command.Parameters.AddWithValue("@Senha", password);

                    // Executa o comando SQL
                    command.ExecuteNonQuery();
                    Form2 formLogin = new Form2();
                    this.Hide();
                    formLogin.ShowDialog();
                }
            }
        }
    }
}
