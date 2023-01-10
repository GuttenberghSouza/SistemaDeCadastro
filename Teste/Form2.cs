using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teste
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
          


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnTeste_Click(object sender, EventArgs e)
        {
            
           SqlConnection conn = new SqlConnection("Data Source=DESKTOP-0M70IH6\\SA;Initial Catalog=Cadastro;Integrated Security=True");
           
           string sql = "INSERT INTO db_cadastro(id,nome) VALUES (@id,@nome)";
            Random numeroID = new Random();
            numeroID.Next();
           
           try
            {
                SqlCommand c = new SqlCommand(sql, conn);

                c.Parameters.Add(new SqlParameter("@id", numeroID.Next()));
                c.Parameters.Add(new SqlParameter("@nome", this.TxtNome.Text));

                conn.Open();

                c.ExecuteNonQuery();

                conn.Close();

                MessageBox.Show("Enviado com sucesso!");

            }catch(SqlException ex)
            {
                MessageBox.Show("Erro ao se conectar " + ex);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
