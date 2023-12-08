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
    public partial class Form2 : Form
    {
         PrivateFontCollection privateFontCollection = new PrivateFontCollection();
        public Form2()
        {
            InitializeComponent();
            CarregarFonte();
            StyleButton(button1);
            StyleTitle(label1);
            StyleText(label2);
        }


        private void CarregarFonte()
        {
            // Substitua "MinhaFonte" pelo nome real do arquivo da sua fonte (sem extensão)
            privateFontCollection.AddFontFile("C:/Users/Aluno/source/repos/Desafio-Final/Desafio Final/assets/CaviarDreams.ttf");
            // Passivo de mudança DEPENDENDO DO USUARIO E CAMINHO

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

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = userTextBox.Text;
            string password = passwordTextBox.Text;


            string conn = "Server=localhost;Database=7code;User=root;";
            string insertSQL = "SELECT * FROM userData WHERE nome = @Usuario and senha = @Senha";

            using (MySqlConnection connection = new MySqlConnection(conn))
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(insertSQL, connection))
                {
                    // Adiciona os parâmetros à consulta SQL
                    command.Parameters.AddWithValue("@Usuario", nome);
                    command.Parameters.AddWithValue("@Senha", password);

                    // Executa o comando SQL
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        // Verifica se há linhas retornadas
                        if (reader.Read())
                        {
                            options formCRUD = new options();
                            this.Hide();
                            formCRUD.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Usuário ou senha incorretos.");
                        }
                    }
                }
            }
        }

        private void lbl_linkForm3_Click(object sender, EventArgs e)
        {
            Form3 formStart = new Form3();
            this.Hide();
            formStart.ShowDialog();
        }
    }
}
