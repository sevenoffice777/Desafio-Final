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
using DataCurso;

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
            privateFontCollection.AddFontFile("C:/Users/Aluno/source/repos/Desafio-Final/Desafio Final/assets/CaviarDreams.ttf");
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
        private void btn_upd_Click(object sender, EventArgs e)
        {
            string nome = nme_txtbox.Text;
            string cod_curso = cod_curso_txtbox.Text;
            string duracao = drc_txtbox.Text;
            string preco = prc_curso_txtbox.Text;
            string desc_curso = dscr_curso_txtbox.Text;



            string conn = "Server=localhost;Database=7code;User=root;";
            string insertSQL = "UPDATE cursos SET nome = @nome_curso, duracao = @duracao,preco = @preco, desc_curso = @desc_curso WHERE cod_curso = @cod_curso;";

            using (MySqlConnection connection = new MySqlConnection(conn))
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(insertSQL, connection))
                {
                    // Adiciona os parâmetros à consulta SQL
                    command.Parameters.AddWithValue("@nome_curso", nome);
                    command.Parameters.AddWithValue("@cod_curso", cod_curso);
                    command.Parameters.AddWithValue("@duracao", duracao);
                    command.Parameters.AddWithValue("@preco", preco);
                    command.Parameters.AddWithValue("@desc_curso", desc_curso);
                    command.ExecuteNonQuery();

                    MessageBox.Show("CURSO ATUALIZADO COM SUCESSO!");
                }
            }

            using (MySqlConnection connection = new MySqlConnection(conn))
            {
                connection.Open();

                string query = "SELECT * FROM cursos WHERE cod_curso = @cod_curso";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Substitua "nome", "cod_curso", "duracao", "preco", "desc_curso" pelos nomes reais das colunas na sua tabela
                            string nome_ref = reader["nome"].ToString();
                            string cod_curso_ref = reader["cod_curso"].ToString();
                            string duracao_ref = reader["duracao"].ToString();
                            string preco_ref = reader["preco"].ToString();
                            string desc_curso_ref = reader["desc_curso"].ToString();

                            // Agora você pode usar as variáveis conforme necessário, por exemplo, criando uma instância de dataCurso
                            dataCurso curso = new dataCurso(nome_ref, cod_curso_ref, duracao_ref, preco_ref, desc_curso_ref);
                            // Executa o comando SQL
                            Form5 formSelect = new Form5(curso);
                            this.Hide();
                            formSelect.ShowDialog();
                            // Faça o que precisar com a instância do curso

                        }
                        else
                        {
                            Console.WriteLine("Nenhum registro encontrado.");
                        }
                    }
                }
               

            }
        }
        

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            options opt = new options();
            this.Hide();
            opt.Show();
        }
    }
}
