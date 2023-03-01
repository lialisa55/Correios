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

        private void CEPi_Leave(object sender, EventArgs e)
        {
            CEP_Correios(CEPi.Text);
        }

        private void CEP_Correios(string CEP)
        {
            Correios.AtendeClienteClient correio = new Correios.AtendeClienteClient();
            Correios.enderecoERP

        }
    }
}
