using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Chat
{
    public partial class FrmConversa : Form
    {
        Form1 mestre;
        string nome;

        public FrmConversa(Form1 m)
        {
            InitializeComponent();
            mestre = m;
            Random r = new Random();
            int id = r.Next(1, 10000);
            AtribuirNome($"Usuário {id}");
            txtNome.Text = $"Usuário {id}";
        }

        void AtribuirNome(string n)
        {
            nome = n;
            Text = nome;
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            AtribuirNome(txtNome.Text);
        }

        private void FrmConversa_FormClosing(object sender, FormClosingEventArgs e)
        {
            // chame a função Fechar do mestre para desalocar a posição desse form no list de usuarios
            mestre.Fechar(this);
        }

        public void ReceberMensagem(string usuario, string texto)
        {
            // concatenar no texto do txtHistorico "{usuario} :: {texto}" se o usuario for outro
            // se for mensagem própria, ou seja, usuario igual ao nome, concatenar "Você :: {texto}"
            string prefixo = usuario == nome ? "Você" : usuario;
            txtHistorico.AppendText($"{prefixo} :: {texto}{Environment.NewLine}");
        }

        // no TextChange do txtMensagem, verificar se está vazio, se estiver, travar botão <enviar>
        private void txtMensagem_TextChanged(object sender, EventArgs e)
        {
            btEnviar.Enabled = !string.IsNullOrWhiteSpace(txtMensagem.Text);
        }

        // programe o evento click do btEnviar para funcionar conforme previsto
        private void btEnviar_Click(object sender, EventArgs e)
        {
            string mensagem = txtMensagem.Text.Trim();

            if (string.IsNullOrWhiteSpace(mensagem))
                return;

            mestre.Disparar(nome, txtMensagem.Text);
            txtMensagem.Clear();
        }
    }
}