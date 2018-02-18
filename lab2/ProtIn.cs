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
    public partial class ProtIn : Form
    {
        public ProtIn()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            BigInteger nA = Func.ConvertInTen(txtNa.Text.Trim(), 16);
            BigInteger eA = Func.ConvertInTen(txtEa.Text.Trim(), 16);
            BigInteger nB = Func.ConvertInTen(txtNb.Text.Trim(), 16);
            BigInteger dB = Func.ConvertInTen(txtDb.Text.Trim(), 16);

            BigInteger k1 = Func.ConvertInTen(txtKs.Text.Trim(), 16);
            BigInteger s1 = Func.ConvertInTen(txtSs.Text.Trim(), 16);
            BigInteger k = BigInteger.ModPow(k1, dB, nB);
            BigInteger s = BigInteger.ModPow(s1, dB, nB);

            txtS.Text = s.ToString("X");
            txtK.Text = k.ToString("X");

            BigInteger tmpK = BigInteger.ModPow(s, eA, nA);

            if(k == tmpK)
            {
                txtS.ForeColor = Color.Green;
            }
            else
            {
                txtS.ForeColor = Color.Red;
            }
        }
    }
}
