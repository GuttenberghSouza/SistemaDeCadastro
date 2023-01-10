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
    public partial class FmLogin : Form
    {
        public FmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-0M70IH6\\SA;Initial Catalog=SistemaDeCadastro;Integrated Security=True");
            SqlCommand verificarLoginSql = new SqlCommand("select Nome from db_SistemaDeCadastro where Senha LIKE @Senha AND Email LIKE @Email ", con);

            string senha = TxtSenha.Text;
            string email = TxtUsuario.Text;


            verificarLoginSql.Parameters.AddWithValue("@Senha", senha);
            verificarLoginSql.Parameters.AddWithValue("@Email", email);
            

            try
            {
                con.Open();
                var leitor = verificarLoginSql.ExecuteReader();

                if (leitor.HasRows)
                {
                    while (leitor.Read())
                    {
                        //int id = Int32.Parse(leitor["id"].ToString());
                        string nome = leitor["Nome"].ToString();

                        MessageBox.Show("Bem-Vindo "+nome+"\nAcesso autorizado");

                        Form1 Menu = new Form1();
                        Menu.Show();
                        this.Hide();

                    }

                }
                else
                {
                    MessageBox.Show("Email ou senha está incorreto" );
                }

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void BtnCadastro_Click(object sender, EventArgs e)
        {
            Cadastro Cadra = new Cadastro();
            Cadra.Show();
            this.Hide();
            
        }

        private void FmLogin_Load(object sender, EventArgs e)
        {

        }

        private void TxtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}
