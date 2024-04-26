using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Avaliação_UML
{
    public class ProfissionalSaude
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string TipoProfissional { get; set; }
        public string CRM { get; set; }
        public string TitulacaoUniversitaria { get; set; }
        public DateTime AnoResidencia { get; set; }
    }

    public class Hospital
    {
        private string conn = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\Avaliação\\Avaliação UML\\Avaliação UML\\Hospital.mdf\";Integrated Security=True";

        public void AdicionarProfissional(ProfissionalSaude profissional)
        {
            using (SqlConnection connection = new SqlConnection(conn))
            {
                string query = "INSERT INTO CadastroMedicos (nome, tipo_profissional, crm, titulacao_universitaria, ano_residencia) " +
                               "VALUES (@Nome, @TipoProfissional, @CRM, @TitulacaoUniversitaria, @AnoResidencia)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Nome", profissional.Nome);
                command.Parameters.AddWithValue("@TipoProfissional", profissional.TipoProfissional);
                command.Parameters.AddWithValue("@CRM", profissional.CRM ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@TitulacaoUniversitaria", profissional.TitulacaoUniversitaria ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@AnoResidencia", profissional.AnoResidencia); 

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void AtualizarProfissional(ProfissionalSaude profissional)
        {
            using (SqlConnection connection = new SqlConnection(conn))
            {
                string query = "UPDATE CadastroMedicos SET nome = @Nome, tipo_profissional = @TipoProfissional, crm = @CRM, " +
                               "titulacao_universitaria = @TitulacaoUniversitaria, ano_residencia = @AnoResidencia WHERE id = @Id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Nome", profissional.Nome);
                command.Parameters.AddWithValue("@TipoProfissional", profissional.TipoProfissional);
                command.Parameters.AddWithValue("@CRM", profissional.CRM ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@TitulacaoUniversitaria", profissional.TitulacaoUniversitaria ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@AnoResidencia", profissional.AnoResidencia);
                command.Parameters.AddWithValue("@Id", profissional.Id);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void ExcluirProfissional(int id)
        {
            using (SqlConnection connection = new SqlConnection(conn))
            {
                string query = "DELETE FROM CadastroMedicos WHERE id = @Id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", id);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public ProfissionalSaude ObterProfissionalPorId(int id)
        {
            using (SqlConnection connection = new SqlConnection(conn))
            {
                string query = "SELECT * FROM CadastroMedicos WHERE id = @Id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", id);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    return new ProfissionalSaude
                    {
                        Id = (int)reader["id"],
                        Nome = reader["nome"].ToString(),
                        TipoProfissional = reader["tipo_profissional"].ToString(),
                        CRM = reader["crm"] != DBNull.Value ? reader["crm"].ToString() : null,
                        TitulacaoUniversitaria = reader["titulacao_universitaria"] != DBNull.Value ? reader["titulacao_universitaria"].ToString() : null,
                        AnoResidencia = (DateTime)reader["ano_residencia"] 
                    };
                }
                else
                {
                    return null;
                }
            }
        }

        public List<ProfissionalSaude> ObterTodosProfissionais()
        {
            List<ProfissionalSaude> listaProfissionais = new List<ProfissionalSaude>();
            string sql = "SELECT * FROM CadastroMedicos";
            using (SqlConnection connection = new SqlConnection(conn))
            {
                SqlCommand command = new SqlCommand(sql, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ProfissionalSaude profissional = new ProfissionalSaude();
                    profissional.Id = (int)reader["id"];
                    profissional.Nome = reader["nome"].ToString();
                    profissional.TipoProfissional = reader["tipo_profissional"].ToString();
                    profissional.CRM = reader["crm"].ToString();
                    profissional.TitulacaoUniversitaria = reader["titulacao_universitaria"].ToString();
                    profissional.AnoResidencia = Convert.ToDateTime( reader["ano_residencia"]);
                    listaProfissionais.Add(profissional);
                }
            }
            return listaProfissionais;
        }

        public bool VerificarExistenciaMedico(string crm)
        {
            string sql = "SELECT COUNT(*) FROM CadastroMedicos WHERE crm = @CRM";
            using (SqlConnection connection = new SqlConnection(conn))
            {
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@CRM", crm);
                connection.Open();
                int count = (int)command.ExecuteScalar();
                return count > 0;
            }
        }
    }
}
