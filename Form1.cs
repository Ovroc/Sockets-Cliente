using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Socket_Cliente
{
    public partial class Frm_Cliente : Form
    {
        Cliente cliente;

        public Frm_Cliente()
        {
            InitializeComponent();
        }

        private void Btn_Cliente_Click(object sender, EventArgs e)
        {
            try
            {
                cliente.EnviarMensagem(Txt_Cliente.Text);
                Txt_Cliente.Text = "";
                Lbl_Resposta.Visible = false;

                if (cliente.respostaServidor == "Verdadeiro")
                {

                    Lbl_Resposta.Text = cliente.respostaServidor;
                    Lbl_Resposta.Visible = true;
                }
                else
                {
                    Lbl_Resposta.Text = cliente.respostaServidor;
                    Lbl_Resposta.Visible = true;
                }
                
            }
            catch (Exception)
            {
                Lbl_Resposta.Visible = false;
                MessageBox.Show("Não foi possível enviar solicitação para o servidor, verifique se o mesmo foi iniciado.","Falha de Comunicação",MessageBoxButtons.OK,MessageBoxIcon.Asterisk); 
            }

        }

        private void Frm_Cliente_Load(object sender, EventArgs e)
        {
            cliente = new Cliente();
        }
    }
}
