using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Teste
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void Cadastro_Load(object sender, EventArgs e)
        {
        

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }        
        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            FmLogin FrmMain = new FmLogin();
            FrmMain.Show();
            this.Hide();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void VerificadorNome()
        {
            string Nome = TxtNome.Text;

            if (Nome != "")
            {
            }
            else
            {
                MessageBox.Show("Campo nome esta vazio");
            }

        }
        public void VerificadorSobrenome()
        {
            string Sobrenome = TxtSobrenome.Text;

            if (Sobrenome != "")
            {
            }
            else
            {
                MessageBox.Show("Campo Sobrenome esta vazio");
            }

        }   
        public void VerificadorEmail()
        {
            string Email = TxtEmail.Text;

            bool validacaoEmail = Email.Contains("@" + "gmail" + "hotmail") || Email.Contains(".com");

            if (validacaoEmail == true)
            {   
            }
            else
            {
                MessageBox.Show("Email invalido");
            }
        }
        public void VerificadorContato()
        {
            string Contato = MkdContato.Text;
            bool validacaoContato = Contato.Contains("");

            if (validacaoContato == true)
            {
                MessageBox.Show("Contato valido");
            }
            else
            {
                MessageBox.Show("Contato invalido");
            }
        }      
        public void VerificarCPF()
        {
            //CPF
            string validar = MkdCpf2.Text;

            if (CPF.ValidaCpf(validar))
            { }
            else
            {
                MessageBox.Show("CPF inválido");
            }
        }
        public void VerificarGenero()
        {
            string Genero = CboGenero.Text;

            bool validacaoEmail = Genero.Contains("Masculino") || Genero.Contains("Feminino")
                || Genero.Contains("Não identificar") || Genero.Contains("Outro");

            if (validacaoEmail == true)
            {
            }
            else
            {
                MessageBox.Show("Gênero invalido");
            }
        }
        public void VerificarCEP()
        {
            var cepValido = Cep.Validar(MkdCep.Text);

            if (cepValido)
            {

            }
            else
            {
                MessageBox.Show("Cep inválido");
            }

        }
        public void VerificarSenha()
        {
            string senha = TxtSenha.Text;
            string senhaConfirmacao = TxtConfSenha.Text;

            if(senha == senhaConfirmacao && senhaConfirmacao !="")
            {
            }
            else
            {
                MessageBox.Show("senha diferente");
            }         
            
        }
        public void BancoDeDados()
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-0M70IH6\\SA;Initial Catalog=SistemaDeCadastro;Integrated Security=True");

            string sql = "INSERT INTO db_SistemaDeCadastro(id,nome,sobrenome,email,contato,cpf,genero,nascimento,cep,senha)" +
                            " VALUES (@id,@nome,@sobrenome,@email,@contato,@cpf,@genero,@nascimento,@cep,@senha)";
            Random numeroID = new Random();
            numeroID.Next();

            try
            {
                SqlCommand c = new SqlCommand(sql, conn);

                c.Parameters.Add(new SqlParameter("@id", numeroID.Next()));
                c.Parameters.Add(new SqlParameter("@nome", this.TxtNome.Text));
                c.Parameters.Add(new SqlParameter("@sobrenome", this.TxtSobrenome.Text));
                c.Parameters.Add(new SqlParameter("@email", this.TxtEmail.Text));
                c.Parameters.Add(new SqlParameter("@contato", this.MkdContato.Text));
                c.Parameters.Add(new SqlParameter("@cpf", this.MkdCpf2.Text));
                c.Parameters.Add(new SqlParameter("@genero", this.CboGenero.Text));
                c.Parameters.Add(new SqlParameter("@nascimento", this.MkdNascimento.Text));
                c.Parameters.Add(new SqlParameter("@cep", this.MkdCep.Text));
                c.Parameters.Add(new SqlParameter("@senha", this.TxtSenha.Text));

                conn.Open();

                c.ExecuteNonQuery();

                conn.Close();

                MessageBox.Show("Enviado com sucesso!");

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro ao se conectar " + ex);
            }
            finally
            {
                conn.Close();
            }

        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            
            VerificadorNome();
            VerificadorSobrenome();
            VerificadorEmail();
            VerificarCPF();
            VerificarGenero();
            VerificarCEP();
            VerificarSenha();
            BancoDeDados();

        }     
        private void RdoTermos_CheckedChanged(object sender, EventArgs e)
        {      

        }

        private void Date_ValueChanged(object sender, EventArgs e)
        {

        }

        private void TxtSenha_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
