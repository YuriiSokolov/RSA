/*Лабораторна робота №1
 Соколов Ю. М.
 Хренов О. Г. 
 ФБ-41*/
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Numerics;
using myfunc;

namespace lab2
{
    public partial class Sign : Form
    {
        public Sign()
        {
            InitializeComponent();
        }

        private void btnCopyDown_Click(object sender, EventArgs e)
        {
            txtMs.Text = txtM.Text;
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            BigInteger n = Func.ConvertInTen(txtN.Text, 16);
            BigInteger d = Func.ConvertInTen(txtD.Text, 16);
            BigInteger m = Func.ConvertInTen(txtM.Text, 16);
            if(m == 0)
            {
                do
                {
                    m = Func.ConvertInTen(Func.BBSBit(256), 2);
                } while(m > n);
            }
            txtM.Text = m.ToString("X");
            BigInteger s = BigInteger.ModPow(m, d, n);
            txtS.Text = s.ToString("X");
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            txtSs.ForeColor = Color.Black;

            BigInteger n = Func.ConvertInTen(txtN.Text, 16);
            BigInteger ee = Func.ConvertInTen(txtE.Text, 16);
            BigInteger m = Func.ConvertInTen(txtM.Text, 16);
            BigInteger sc = Func.ConvertInTen(txtS.Text, 16);

            BigInteger s = BigInteger.ModPow(sc, ee, n);
            txtSs.Text = sc.ToString("X");

            if(m == s)
            {
                txtSs.ForeColor = Color.Green;
            }
            else
            {
                txtSs.ForeColor = Color.Red;
            }
        }
    }
}
