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
    public partial class GenerateKey : Form
    {
        public GenerateKey()
        {
            InitializeComponent();
        }

        ProtOut protOut = new ProtOut();

        private void btnClear_Click(object sender, EventArgs e)
        {
            //bool kek = Func.MillerRab(Func.ConvertInTen("99999999999999999999999999999999", 16), 50);
            txtP.Text = string.Empty;
            txtQ.Text = string.Empty;
            txtN.Text = string.Empty;
            txtFi.Text = string.Empty;
            txtE.Text = string.Empty;
            txtD.Text = string.Empty;
        }

        private void btnCopyToEncrypt_Click(object sender, EventArgs e)
        {
            Encrypt encrypt = new Encrypt();
            encrypt.Show();

            encrypt.txtN.Text = txtN.Text;
            encrypt.txtNe.Text = txtN.Text;
            encrypt.txtD.Text = txtD.Text;
            encrypt.txtE.Text = txtE.Text;
        }

        private void btnCopyToSign_Click(object sender, EventArgs e)
        {
            Sign sign = new Sign();
            sign.Show();

            sign.txtN.Text = txtN.Text;
            sign.txtNe.Text = txtN.Text;
            sign.txtD.Text = txtD.Text;
            sign.txtE.Text = txtE.Text;
        }

        private void btnCopyToA_Click(object sender, EventArgs e)
        {
            //ProtOut protOut = new ProtOut();
            if (!protOut.IsDisposed)
            {
                protOut.Show();
            }

            protOut.txtNa.Text = txtN.Text;
            protOut.txtDa.Text = txtD.Text;
        }

        private void btnCopyToB_Click(object sender, EventArgs e)
        {
            //ProtOut protOut = new ProtOut();
            if (!protOut.IsDisposed)
            {
                protOut.Show();
            }

            protOut.txtNb.Text = txtN.Text;
            protOut.txtEb.Text = txtE.Text;
        }

        private void btnSet65537_Click(object sender, EventArgs e)
        {
            txtE.Text = Convert.ToString(65537, 16);
        }

        private void btnCheckP_Click(object sender, EventArgs e)
        {
            txtP.ForeColor = Color.Black;

            if (Func.MillerRab(Func.ConvertInTen(txtP.Text, 16), 50))
            {
                txtP.ForeColor = Color.Green;
            }
            else
            {
                txtP.ForeColor = Color.Red;
            }
        }

        private void btnCheckQ_Click(object sender, EventArgs e)
        {
            txtQ.ForeColor = Color.Black;

            if (Func.MillerRab(Func.ConvertInTen(txtQ.Text, 16), 50))
            {
                txtQ.ForeColor = Color.Green;
            }
            else
            {
                txtQ.ForeColor = Color.Red;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtFi.ForeColor = Color.Black;

            if (BigInteger.ModPow((BigInteger)2, Func.ConvertInTen(txtFi.Text, 16), Func.ConvertInTen(txtN.Text, 16)) == 1)
            {
                txtFi.ForeColor = Color.Green;
            }
            else
            {
                txtFi.ForeColor = Color.Red;
            }
        }

        private void btnGenE_Click(object sender, EventArgs e)
        {
            BigInteger ee = new BigInteger();
            BigInteger fi = Func.ConvertInTen(txtFi.Text, 16);
            bool gdcCheck;

            do
            {
                ee = Func.ConvertInTen(Func.BBSBit(256), 2);
                gdcCheck = (Func.Euclid(ee, fi) != 1);
            } while (ee > fi || gdcCheck);

            txtE.Text = ee.ToString("X");
            BigInteger kek = Func.Euclid(ee, fi);
            BigInteger keks = Func.Euclid(ee, fi);
        }

        private void btnGenN_Click(object sender, EventArgs e)
        {
            BigInteger p = Func.ConvertInTen(txtP.Text, 16);
            BigInteger q = Func.ConvertInTen(txtQ.Text, 16);
            BigInteger n = BigInteger.Multiply(p, q);
            BigInteger fi = BigInteger.Multiply(p - 1, q - 1);          
            txtN.Text = n.ToString("X");
            txtFi.Text = fi.ToString("X");
        }

        private void btnGenD_Click(object sender, EventArgs e)
        {
            BigInteger ee = Func.ConvertInTen(txtE.Text, 16);
            BigInteger fi = Func.ConvertInTen(txtFi.Text, 16);
            BigInteger d = Func.InverseElement(ee, fi);

            txtD.Text = d.ToString("X");
        }

        private void btnGenP_Click(object sender, EventArgs e)
        {
            BigInteger p = Func.GenPrime();

            txtP.Text = p.ToString("X");
        }

        private void btnGenQ_Click(object sender, EventArgs e)
        {
            BigInteger q = Func.GenPrime();

            txtQ.Text = q.ToString("X");
        }
    }
}
