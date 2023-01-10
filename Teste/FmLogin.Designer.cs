namespace Teste
{
    partial class FmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmLogin));
            this.LblUser = new System.Windows.Forms.Label();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.TxtSenha = new System.Windows.Forms.TextBox();
            this.LblPass = new System.Windows.Forms.Label();
            this.BtnCadastro = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnAcesso = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblUser
            // 
            this.LblUser.AutoSize = true;
            this.LblUser.BackColor = System.Drawing.SystemColors.HighlightText;
            this.LblUser.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUser.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LblUser.Location = new System.Drawing.Point(4, 59);
            this.LblUser.Name = "LblUser";
            this.LblUser.Size = new System.Drawing.Size(64, 21);
            this.LblUser.TabIndex = 1;
            this.LblUser.Text = "Usuário";
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.Location = new System.Drawing.Point(74, 59);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(207, 20);
            this.TxtUsuario.TabIndex = 2;
            this.TxtUsuario.TextChanged += new System.EventHandler(this.TxtUsuario_TextChanged);
            // 
            // TxtSenha
            // 
            this.TxtSenha.Location = new System.Drawing.Point(74, 95);
            this.TxtSenha.Name = "TxtSenha";
            this.TxtSenha.PasswordChar = '*';
            this.TxtSenha.Size = new System.Drawing.Size(207, 20);
            this.TxtSenha.TabIndex = 4;
            // 
            // LblPass
            // 
            this.LblPass.AutoSize = true;
            this.LblPass.BackColor = System.Drawing.SystemColors.HighlightText;
            this.LblPass.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPass.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LblPass.Location = new System.Drawing.Point(20, 95);
            this.LblPass.Name = "LblPass";
            this.LblPass.Size = new System.Drawing.Size(48, 20);
            this.LblPass.TabIndex = 3;
            this.LblPass.Text = "Senha";
            // 
            // BtnCadastro
            // 
            this.BtnCadastro.Location = new System.Drawing.Point(96, 157);
            this.BtnCadastro.Name = "BtnCadastro";
            this.BtnCadastro.Size = new System.Drawing.Size(157, 21);
            this.BtnCadastro.TabIndex = 5;
            this.BtnCadastro.Text = "Cadastro";
            this.BtnCadastro.UseVisualStyleBackColor = true;
            this.BtnCadastro.Click += new System.EventHandler(this.BtnCadastro_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Sistema De Cadastro";
            // 
            // BtnAcesso
            // 
            this.BtnAcesso.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnAcesso.ForeColor = System.Drawing.SystemColors.InfoText;
            this.BtnAcesso.Location = new System.Drawing.Point(96, 121);
            this.BtnAcesso.Name = "BtnAcesso";
            this.BtnAcesso.Size = new System.Drawing.Size(157, 30);
            this.BtnAcesso.TabIndex = 0;
            this.BtnAcesso.Text = "Acesso";
            this.BtnAcesso.UseVisualStyleBackColor = false;
            this.BtnAcesso.Click += new System.EventHandler(this.button1_Click);
            // 
            // FmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(305, 189);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnCadastro);
            this.Controls.Add(this.TxtSenha);
            this.Controls.Add(this.LblPass);
            this.Controls.Add(this.TxtUsuario);
            this.Controls.Add(this.LblUser);
            this.Controls.Add(this.BtnAcesso);
            this.ForeColor = System.Drawing.SystemColors.InfoText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FmLogin";
            this.Load += new System.EventHandler(this.FmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAcesso;
        private System.Windows.Forms.Label LblUser;
        private System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.TextBox TxtSenha;
        private System.Windows.Forms.Label LblPass;
        private System.Windows.Forms.Button BtnCadastro;
        private System.Windows.Forms.Label label1;
    }
}