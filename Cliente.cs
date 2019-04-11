using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Socket_Cliente
{
    public class Cliente
    {

        const int PORTA = 9009;
        const int TAMANHO_BUFFER = 1000000;

        public string mensagem;
        public string respostaServidor;

        private TcpClient cliente;

        public Cliente()
        {
            this.cliente = new TcpClient();
            this.cliente.Connect("127.0.0.1", PORTA);
        }

        public void EnviarMensagem(string mensagem)
        {
            NetworkStream servidorStream = this.cliente.GetStream();

            /* adiciona um caractere especial para melhorar a 
             * impressão da mensagem no servidor console
             * e converte a mensagem em um array de bytes
             */
            byte[] saida = Encoding.ASCII.GetBytes(mensagem + "$");

            //envia a mensagem ao servidor
            servidorStream.Write(saida, 0, saida.Length);
            servidorStream.Flush();

            byte[] entrada = new byte[TAMANHO_BUFFER];

            //recebe uma mensagem do servidor
            servidorStream.Read(entrada, 0, (int)this.cliente.ReceiveBufferSize);

            //converte a mensagem do servidor em uma string
            this.respostaServidor = Encoding.ASCII.GetString(entrada);
        }
    }
}
