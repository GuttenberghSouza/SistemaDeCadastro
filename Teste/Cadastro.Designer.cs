namespace Teste
{
    partial class Cadastro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastro));
            this.BtnCadastrar = new System.Windows.Forms.Button();
            this.BtnVoltar = new System.Windows.Forms.Button();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.LblNome = new System.Windows.Forms.Label();
            this.TxtSobrenome = new System.Windows.Forms.TextBox();
            this.LblSobrenome = new System.Windows.Forms.Label();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.LblContato = new System.Windows.Forms.Label();
            this.LblEmail = new System.Windows.Forms.Label();
            this.LblCpf = new System.Windows.Forms.Label();
            this.LblDataNasc = new System.Windows.Forms.Label();
            this.LblGenero = new System.Windows.Forms.Label();
            this.LbmCadastro = new System.Windows.Forms.Label();
            this.MkdContato = new System.Windows.Forms.MaskedTextBox();
            this.MkdCep = new System.Windows.Forms.MaskedTextBox();
            this.LblCep = new System.Windows.Forms.Label();
            this.MkdCpf2 = new System.Windows.Forms.MaskedTextBox();
            this.CboGenero = new System.Windows.Forms.ComboBox();
            this.MkdNascimento = new System.Windows.Forms.MaskedTextBox();
            this.TxtSenha = new System.Windows.Forms.TextBox();
            this.TxtConfSenha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnCadastrar
            // 
            this.BtnCadastrar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.BtnCadastrar.Location = new System.Drawing.Point(92, 334);
            this.BtnCadastrar.Name = "BtnCadastrar";
            this.BtnCadastrar.Size = new System.Drawing.Size(121, 41);
            this.BtnCadastrar.TabIndex = 0;
            this.BtnCadastrar.Text = "Cadastar";
            this.BtnCadastrar.UseVisualStyleBackColor = true;
            this.BtnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click);
            // 
            // BtnVoltar
            // 
            this.BtnVoltar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.BtnVoltar.Location = new System.Drawing.Point(215, 9);
            this.BtnVoltar.Name = "BtnVoltar";
            this.BtnVoltar.Size = new System.Drawing.Size(53, 20);
            this.BtnVoltar.TabIndex = 14;
            this.BtnVoltar.Text = "Voltar";
            this.BtnVoltar.UseVisualStyleBackColor = true;
            this.BtnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click);
            // 
            // TxtNome
            // 
            this.TxtNome.Location = new System.Drawing.Point(74, 39);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(194, 20);
            this.TxtNome.TabIndex = 1;
            this.TxtNome.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // LblNome
            // 
            this.LblNome.AutoSize = true;
            this.LblNome.Location = new System.Drawing.Point(6, 39);
            this.LblNome.Name = "LblNome";
            this.LblNome.Size = new System.Drawing.Size(35, 13);
            this.LblNome.TabIndex = 2;
            this.LblNome.Text = "Nome";
            this.LblNome.Click += new System.EventHandler(this.label1_Click);
            // 
            // TxtSobrenome
            // 
            this.TxtSobrenome.Location = new System.Drawing.Point(74, 65);
            this.TxtSobrenome.Name = "TxtSobrenome";
            this.TxtSobrenome.Size = new System.Drawing.Size(194, 20);
            this.TxtSobrenome.TabIndex = 3;
            // 
            // LblSobrenome
            // 
            this.LblSobrenome.AutoSize = true;
            this.LblSobrenome.Location = new System.Drawing.Point(6, 65);
            this.LblSobrenome.Name = "LblSobrenome";
            this.LblSobrenome.Size = new System.Drawing.Size(61, 13);
            this.LblSobrenome.TabIndex = 4;
            this.LblSobrenome.Text = "Sobrenome";
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(74, 91);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(194, 20);
            this.TxtEmail.TabIndex = 5;
            // 
            // LblContato
            // 
            this.LblContato.AutoSize = true;
            this.LblContato.Location = new System.Drawing.Point(6, 117);
            this.LblContato.Name = "LblContato";
            this.LblContato.Size = new System.Drawing.Size(44, 13);
            this.LblContato.TabIndex = 6;
            this.LblContato.Text = "Contato";
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.Location = new System.Drawing.Point(6, 91);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(35, 13);
            this.LblEmail.TabIndex = 6;
            this.LblEmail.Text = "E-mail";
            // 
            // LblCpf
            // 
            this.LblCpf.AutoSize = true;
            this.LblCpf.Location = new System.Drawing.Point(6, 143);
            this.LblCpf.Name = "LblCpf";
            this.LblCpf.Size = new System.Drawing.Size(27, 13);
            this.LblCpf.TabIndex = 8;
            this.LblCpf.Text = "CPF";
            // 
            // LblDataNasc
            // 
            this.LblDataNasc.AutoSize = true;
            this.LblDataNasc.Location = new System.Drawing.Point(6, 206);
            this.LblDataNasc.Name = "LblDataNasc";
            this.LblDataNasc.Size = new System.Drawing.Size(104, 13);
            this.LblDataNasc.TabIndex = 10;
            this.LblDataNasc.Text = "Data de Nascimento";
            // 
            // LblGenero
            // 
            this.LblGenero.AutoSize = true;
            this.LblGenero.Location = new System.Drawing.Point(6, 170);
            this.LblGenero.Name = "LblGenero";
            this.LblGenero.Size = new System.Drawing.Size(42, 13);
            this.LblGenero.TabIndex = 12;
            this.LblGenero.Text = "Gênero";
            // 
            // LbmCadastro
            // 
            this.LbmCadastro.AutoSize = true;
            this.LbmCadastro.Location = new System.Drawing.Point(102, 9);
            this.LbmCadastro.Name = "LbmCadastro";
            this.LbmCadastro.Size = new System.Drawing.Size(49, 13);
            this.LbmCadastro.TabIndex = 15;
            this.LbmCadastro.Text = "Cadastro";
            // 
            // MkdContato
            // 
            this.MkdContato.Location = new System.Drawing.Point(74, 117);
            this.MkdContato.Mask = "(00)00000-0000";
            this.MkdContato.Name = "MkdContato";
            this.MkdContato.Size = new System.Drawing.Size(101, 20);
            this.MkdContato.TabIndex = 20;
            // 
            // MkdCep
            // 
            this.MkdCep.Location = new System.Drawing.Point(74, 236);
            this.MkdCep.Mask = "00000-000";
            this.MkdCep.Name = "MkdCep";
            this.MkdCep.Size = new System.Drawing.Size(77, 20);
            this.MkdCep.TabIndex = 21;
            // 
            // LblCep
            // 
            this.LblCep.AutoSize = true;
            this.LblCep.Location = new System.Drawing.Point(6, 239);
            this.LblCep.Name = "LblCep";
            this.LblCep.Size = new System.Drawing.Size(28, 13);
            this.LblCep.TabIndex = 22;
            this.LblCep.Text = "CEP";
            // 
            // MkdCpf2
            // 
            this.MkdCpf2.Location = new System.Drawing.Point(74, 144);
            this.MkdCpf2.Mask = "000,000,000-00";
            this.MkdCpf2.Name = "MkdCpf2";
            this.MkdCpf2.Size = new System.Drawing.Size(101, 20);
            this.MkdCpf2.TabIndex = 24;
            // 
            // CboGenero
            // 
            this.CboGenero.FormattingEnabled = true;
            this.CboGenero.Items.AddRange(new object[] {
            "Masculino",
            "Feminino",
            "Não identificar",
            "Outro"});
            this.CboGenero.Location = new System.Drawing.Point(74, 170);
            this.CboGenero.Name = "CboGenero";
            this.CboGenero.Size = new System.Drawing.Size(121, 21);
            this.CboGenero.TabIndex = 25;
            this.CboGenero.TabStop = false;
            // 
            // MkdNascimento
            // 
            this.MkdNascimento.Location = new System.Drawing.Point(116, 203);
            this.MkdNascimento.Mask = "00/00/0000";
            this.MkdNascimento.Name = "MkdNascimento";
            this.MkdNascimento.Size = new System.Drawing.Size(79, 20);
            this.MkdNascimento.TabIndex = 24;
            this.MkdNascimento.ValidatingType = typeof(System.DateTime);
            // 
            // TxtSenha
            // 
            this.TxtSenha.Location = new System.Drawing.Point(92, 271);
            this.TxtSenha.Name = "TxtSenha";
            this.TxtSenha.Size = new System.Drawing.Size(176, 20);
            this.TxtSenha.TabIndex = 5;
            this.TxtSenha.TextChanged += new System.EventHandler(this.TxtSenha_TextChanged);
            // 
            // TxtConfSenha
            // 
            this.TxtConfSenha.Location = new System.Drawing.Point(92, 297);
            this.TxtConfSenha.Name = "TxtConfSenha";
            this.TxtConfSenha.Size = new System.Drawing.Size(176, 20);
            this.TxtConfSenha.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 297);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Confirma senha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 271);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Senha";
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(291, 388);
            this.Controls.Add(this.CboGenero);
            this.Controls.Add(this.MkdNascimento);
            this.Controls.Add(this.MkdCpf2);
            this.Controls.Add(this.LblCep);
            this.Controls.Add(this.MkdCep);
            this.Controls.Add(this.MkdContato);
            this.Controls.Add(this.LbmCadastro);
            this.Controls.Add(this.BtnVoltar);
            this.Controls.Add(this.LblGenero);
            this.Controls.Add(this.LblDataNasc);
            this.Controls.Add(this.LblCpf);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LblEmail);
            this.Controls.Add(this.LblContato);
            this.Controls.Add(this.TxtConfSenha);
            this.Controls.Add(this.TxtSenha);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.LblSobrenome);
            this.Controls.Add(this.TxtSobrenome);
            this.Controls.Add(this.LblNome);
            this.Controls.Add(this.TxtNome);
            this.Controls.Add(this.BtnCadastrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Cadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.Cadastro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCadastrar;
        private System.Windows.Forms.Button BtnVoltar;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.Label LblNome;
        private System.Windows.Forms.TextBox TxtSobrenome;
        private System.Windows.Forms.Label LblSobrenome;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Label LblContato;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.Label LblCpf;
        private System.Windows.Forms.Label LblDataNasc;
        private System.Windows.Forms.Label LblGenero;
        private System.Windows.Forms.Label LbmCadastro;
        private System.Windows.Forms.MaskedTextBox MkdContato;
        private System.Windows.Forms.MaskedTextBox MkdCep;
        private System.Windows.Forms.Label LblCep;
        private System.Windows.Forms.MaskedTextBox MkdCpf2;
        private System.Windows.Forms.ComboBox CboGenero;
        private System.Windows.Forms.MaskedTextBox MkdNascimento;
        private System.Windows.Forms.TextBox TxtSenha;
        private System.Windows.Forms.TextBox TxtConfSenha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}