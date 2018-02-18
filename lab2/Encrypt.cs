/*Лабораторна робота №1
 Соколов Ю. М.
 Хренов О. Г. 
 ФБ-41*/
using System;
using System.Windows.Forms;
using System.Numerics;
using myfunc;

namespace lab2
{
    public partial class Encrypt : Form
    {
        public Encrypt()
        {
            InitializeComponent();
        }

        private void btnCopyDown_Click(object sender, EventArgs e)
        {
            txtCe.Text = txtC.Text;
        }

        private void btnStartE_Click(object sender, EventArgs e)
        {
            BigInteger n = Func.ConvertInTen(txtN.Text, 16);
            BigInteger ee = Func.ConvertInTen(txtE.Text, 16);
            BigInteger m = Func.ConvertInTen(txtM.Text, 16);
            if(m == 0)
            {
                do
                {
                    m = Func.ConvertInTen(Func.BBSBit(256), 2);
                } while(m > n);
            }
            txtM.Text = m.ToString("X");
            BigInteger c = BigInteger.ModPow(m, ee, n);
            txtC.Text = c.ToString("X");
        }

        private void btnStartD_Click(object sender, EventArgs e)
        {
            BigInteger n = Func.ConvertInTen(txtNe.Text, 16);
            BigInteger d = Func.ConvertInTen(txtD.Text, 16);
            BigInteger c = Func.ConvertInTen(txtCe.Text, 16);

            BigInteger m = BigInteger.ModPow(c, d, n);
            txtMe.Text = m.ToString("X");
        }
    }
}
