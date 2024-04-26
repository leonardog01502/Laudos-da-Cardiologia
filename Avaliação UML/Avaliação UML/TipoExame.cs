using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avaliação_UML
{
    internal class TipoExame
    {
        private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Aluno\\Desktop\\Avaliação\\Avaliação UML\\Avaliação UML\\Hospital.mdf\";Integrated Security=True";

        public void InserirTiposExame()
        {
            string[] tiposExame = { "Ecocardiograma", "Eletrocardiograma", "MAPA", "Holter" };
            string cid10 = "I21.9"; 

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                foreach (string tipo in tiposExame)
                {
                    string query = "INSERT INTO TipoExame (nome, cid10) VALUES (@Nome, @CID10)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Nome", tipo);
                    command.Parameters.AddWithValue("@CID10", cid10);

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}