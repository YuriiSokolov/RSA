using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            ProtIn protIn = new ProtIn();
            protIn.Show();
        }

        private void btnPOut_Click(object sender, EventArgs e)
        {
            ProtOut protOut = new ProtOut();
            protOut.Show();
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            Encrypt encrypt = new Encrypt();
            encrypt.Show();
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            Sign sign = new Sign();
            sign.Show();
        }

        private void btnGKey_Click(object sender, EventArgs e)
        {
            GenerateKey genKey = new GenerateKey();
            genKey.Show();
        }
    }
}
