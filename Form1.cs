using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace progetto_conti
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            
            string[] Numero = { "11264", "99780", "00342", "03419", "34562", "09887", "02341" };
            string[] Saldo = { "11534", "-2345", "3451", "127", "45673", "-13", "3452" };
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] Nome = { "Rossi Mario", "Bianchi Luigi", "Belli Giulia", "Dotti Fabio", "Merli Gianna", "Zeri Giulio", "Botti Maria" };
        }
    }
}
