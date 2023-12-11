using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;



namespace DataCurso
{
    public class dataCurso
    {
        public string nome;
        public string cod_curso;
        public string duracao;
        public string preco;
        public string desc_curso;

        public dataCurso(string nme_txtBox_p, string cod_curso_txtbox_p, string drc_txtbox_p, string prc_curso_txtbox_p, string dscr_curso_txtbox_p)
        {
            nome = nme_txtBox_p;
            cod_curso = cod_curso_txtbox_p;
            duracao = drc_txtbox_p;
            preco = prc_curso_txtbox_p;
            desc_curso = dscr_curso_txtbox_p;

        }

    }
}
