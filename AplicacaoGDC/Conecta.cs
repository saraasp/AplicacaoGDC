using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comunidade
{
    internal class Conecta
    {
        public DataTable BuscaDados(string str_conection, string str_sql)
        {
            //recebe a string de conexão à base de dados e a string com o comando SQL
            //devolve uma tabela (datatable) com os registos provenientes da base de dados
            SqlConnection C = new SqlConnection(str_conection); C.Open();
            //criar comando SQL para extrair os dados pretendidos:
            SqlCommand command = C.CreateCommand(); command.CommandText = str_sql;
            //o comando SQL vem na string


            //trazer os dados da tabela especificada para uma "tabela" em memória:
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable t = new DataTable();
            da.Fill(t);
            C.Close();
            return t; //t leva os registos
        } //----------------------------------------------------------------------------- CONECT

        public string GetStringConnection()
        {
            string sc = "Data Source=xxxx\\xxxx; Initial Catalog = bdGdc; User ID = xxxx; Password=xxxx;";
            string casa = "Data Source=LAPTOP-F2JAL7KG\\SQLEXPRESS; Initial Catalog = bdGdc; User ID = sa; Password=123;";
            return casa;
        }
    }



    
}
