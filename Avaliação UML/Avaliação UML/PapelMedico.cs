using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avaliação_UML
{
    public class PapelMedico
    {
        private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Aluno\\Desktop\\Avaliação\\Avaliação UML\\Avaliação UML\\Hospital.mdf\";Integrated Security=True";

        public void InserirPapeis()
        {
            string[] papeis = { "Residente", "Docente", "Médico Comum" };

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                foreach (string papel in papeis)
                {
                    string query = "INSERT INTO PapelMedico (nome) VALUES (@Nome)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Nome", papel);

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}