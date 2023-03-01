using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Correios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CEP_Correios(CEPi.Text);
        }

        private void CEPi_Leave(object sender, EventArgs e)
        {

        }

        private void CEP_Correios(string CEP)
        {
            try
            {

                CorreiosRef.AtendeClienteClient correio = new CorreiosRef.AtendeClienteClient();
                CorreiosRef.enderecoERP consulta = correio.consultaCEP(CEP);

                    RUAi.Text = consulta.end;
                    BAIi.Text = consulta.bairro;
                    CIDi.Text = consulta.cidade;
                    ESTi.Text = consulta.uf;
            }
            catch
            {
                MessageBox.Show("Consulta Inválida");
            }
        }

        private void CEPi_TextChanged(object sender, EventArgs e)
        {

        }

        private void CEPi_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
