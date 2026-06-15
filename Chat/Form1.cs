using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Chat
{
    public partial class Form1 : Form
    {
        List<FrmConversa> usuarios;

        public Form1()
        {
            InitializeComponent();
        }

        private void btIniciar_Click(object sender, EventArgs e)
        {
            usuarios = new List<FrmConversa>();
            for (int i = 0; i < numQtd.Value; i++)
            {
                usuarios.Add(new FrmConversa(this));
                usuarios[i].Show();
            }
            btIniciar.Enabled = false;
        }

        public void Fechar(FrmConversa usuario)
        {
            usuarios.Remove(usuario);
            btIniciar.Enabled = usuarios.Count == 0;
            Focus();
        }

        public void Disparar(string usuario, string mensagem)
        {
            // percorrer a lista de usuarios disparando suas funções ReceberMensagem
            foreach (FrmConversa u in usuarios)
            {
                u.ReceberMensagem(usuario, mensagem);
            }
        }
    }
}