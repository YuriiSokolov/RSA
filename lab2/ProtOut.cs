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
    public partial class ProtOut : Form
    {
        public ProtOut()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            txtNa.ForeColor = Color.Black;     

            BigInteger nA = Func.ConvertInTen(txtNa.Text.Trim(), 16);
            BigInteger dA = Func.ConvertInTen(txtDa.Text.Trim(), 16);
            BigInteger nB = Func.ConvertInTen(txtNb.Text.Trim(), 16);
            BigInteger eB = Func.ConvertInTen(txtEb.Text.Trim(), 16);

            if (nB >= nA)
            {
                BigInteger k = Func.ConvertInTen(Func.BBSBit(256), 2);
                BigInteger k1 = BigInteger.ModPow(k, eB, nB);
                BigInteger s = BigInteger.ModPow(k, dA, nA);
                BigInteger s1 = BigInteger.ModPow(s, eB, nB);

                txtK.Text = k.ToString("X");
                txtKs.Text = k1.ToString("X");
                txtS.Text = s.ToString("X");
                txtSs.Text = s1.ToString("X");
            }
            else
            {
                txtNa.ForeColor = Color.Red;
            }
        }

        private void btnOutPut_Click(object sender, EventArgs e)
        {
            ProtIn protIn = new ProtIn();
            protIn.Show();

            protIn.txtDb.Text = txtDa.Text;
            protIn.txtNb.Text = txtNb.Text;
            protIn.txtNa.Text = txtNa.Text;
            protIn.txtEa.Text = txtEb.Text;
            protIn.txtSs.Text = txtSs.Text;
            protIn.txtKs.Text = txtKs.Text;
        }
    }
}
