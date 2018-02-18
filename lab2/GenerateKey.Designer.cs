namespace lab2
{
    partial class GenerateKey
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GenerateKey));
            this.btnGenE = new System.Windows.Forms.Button();
            this.txtE = new System.Windows.Forms.TextBox();
            this.txtD = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFi = new System.Windows.Forms.TextBox();
            this.txtN = new System.Windows.Forms.TextBox();
            this.txtQ = new System.Windows.Forms.TextBox();
            this.txtP = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSet65537 = new System.Windows.Forms.Button();
            this.btnGenN = new System.Windows.Forms.Button();
            this.btnCheckQ = new System.Windows.Forms.Button();
            this.btnGenQ = new System.Windows.Forms.Button();
            this.btnCheckP = new System.Windows.Forms.Button();
            this.btnGenP = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnGenAll = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCopyToEncrypt = new System.Windows.Forms.Button();
            this.btnCopyToB = new System.Windows.Forms.Button();
            this.btnCopyToA = new System.Windows.Forms.Button();
            this.btnCopyToSign = new System.Windows.Forms.Button();
            this.btnGenD = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGenE
            // 
            this.btnGenE.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnGenE.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnGenE.FlatAppearance.BorderSize = 2;
            this.btnGenE.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGenE.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGenE.Location = new System.Drawing.Point(494, 196);
            this.btnGenE.Name = "btnGenE";
            this.btnGenE.Size = new System.Drawing.Size(80, 20);
            this.btnGenE.TabIndex = 75;
            this.btnGenE.Text = "Start";
            this.btnGenE.UseVisualStyleBackColor = true;
            this.btnGenE.Click += new System.EventHandler(this.btnGenE_Click);
            // 
            // txtE
            // 
            this.txtE.Location = new System.Drawing.Point(56, 196);
            this.txtE.Name = "txtE";
            this.txtE.Size = new System.Drawing.Size(432, 20);
            this.txtE.TabIndex = 74;
            // 
            // txtD
            // 
            this.txtD.Location = new System.Drawing.Point(56, 233);
            this.txtD.Name = "txtD";
            this.txtD.Size = new System.Drawing.Size(432, 20);
            this.txtD.TabIndex = 73;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 20);
            this.label3.TabIndex = 72;
            this.label3.Text = "e =";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(12, 230);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 20);
            this.label8.TabIndex = 71;
            this.label8.Text = "d =";
            // 
            // txtFi
            // 
            this.txtFi.Location = new System.Drawing.Point(56, 150);
            this.txtFi.Name = "txtFi";
            this.txtFi.Size = new System.Drawing.Size(432, 20);
            this.txtFi.TabIndex = 70;
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(56, 116);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(432, 20);
            this.txtN.TabIndex = 69;
            // 
            // txtQ
            // 
            this.txtQ.Location = new System.Drawing.Point(56, 76);
            this.txtQ.Name = "txtQ";
            this.txtQ.Size = new System.Drawing.Size(432, 20);
            this.txtQ.TabIndex = 68;
            // 
            // txtP
            // 
            this.txtP.Location = new System.Drawing.Point(56, 44);
            this.txtP.Name = "txtP";
            this.txtP.Size = new System.Drawing.Size(432, 20);
            this.txtP.TabIndex = 67;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(11, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 20);
            this.label6.TabIndex = 66;
            this.label6.Text = "fi =";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(12, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 20);
            this.label7.TabIndex = 65;
            this.label7.Text = "n =";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 20);
            this.label5.TabIndex = 64;
            this.label5.Text = "q =";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 20);
            this.label4.TabIndex = 63;
            this.label4.Text = "p =";
            // 
            // btnSet65537
            // 
            this.btnSet65537.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSet65537.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSet65537.FlatAppearance.BorderSize = 2;
            this.btnSet65537.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSet65537.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSet65537.Location = new System.Drawing.Point(580, 196);
            this.btnSet65537.Name = "btnSet65537";
            this.btnSet65537.Size = new System.Drawing.Size(80, 20);
            this.btnSet65537.TabIndex = 76;
            this.btnSet65537.Text = "65537";
            this.btnSet65537.UseVisualStyleBackColor = true;
            this.btnSet65537.Click += new System.EventHandler(this.btnSet65537_Click);
            // 
            // btnGenN
            // 
            this.btnGenN.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnGenN.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnGenN.FlatAppearance.BorderSize = 2;
            this.btnGenN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGenN.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGenN.Location = new System.Drawing.Point(494, 116);
            this.btnGenN.Name = "btnGenN";
            this.btnGenN.Size = new System.Drawing.Size(166, 20);
            this.btnGenN.TabIndex = 79;
            this.btnGenN.Text = "Start";
            this.btnGenN.UseVisualStyleBackColor = true;
            this.btnGenN.Click += new System.EventHandler(this.btnGenN_Click);
            // 
            // btnCheckQ
            // 
            this.btnCheckQ.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCheckQ.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCheckQ.FlatAppearance.BorderSize = 2;
            this.btnCheckQ.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCheckQ.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCheckQ.Location = new System.Drawing.Point(580, 76);
            this.btnCheckQ.Name = "btnCheckQ";
            this.btnCheckQ.Size = new System.Drawing.Size(80, 20);
            this.btnCheckQ.TabIndex = 82;
            this.btnCheckQ.Text = "Check Q";
            this.btnCheckQ.UseVisualStyleBackColor = true;
            this.btnCheckQ.Click += new System.EventHandler(this.btnCheckQ_Click);
            // 
            // btnGenQ
            // 
            this.btnGenQ.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnGenQ.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnGenQ.FlatAppearance.BorderSize = 2;
            this.btnGenQ.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGenQ.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGenQ.Location = new System.Drawing.Point(494, 76);
            this.btnGenQ.Name = "btnGenQ";
            this.btnGenQ.Size = new System.Drawing.Size(80, 20);
            this.btnGenQ.TabIndex = 81;
            this.btnGenQ.Text = "Start";
            this.btnGenQ.UseVisualStyleBackColor = true;
            this.btnGenQ.Click += new System.EventHandler(this.btnGenQ_Click);
            // 
            // btnCheckP
            // 
            this.btnCheckP.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCheckP.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCheckP.FlatAppearance.BorderSize = 2;
            this.btnCheckP.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCheckP.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCheckP.Location = new System.Drawing.Point(580, 44);
            this.btnCheckP.Name = "btnCheckP";
            this.btnCheckP.Size = new System.Drawing.Size(80, 20);
            this.btnCheckP.TabIndex = 84;
            this.btnCheckP.Text = "Check P";
            this.btnCheckP.UseVisualStyleBackColor = true;
            this.btnCheckP.Click += new System.EventHandler(this.btnCheckP_Click);
            // 
            // btnGenP
            // 
            this.btnGenP.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnGenP.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnGenP.FlatAppearance.BorderSize = 2;
            this.btnGenP.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGenP.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGenP.Location = new System.Drawing.Point(494, 44);
            this.btnGenP.Name = "btnGenP";
            this.btnGenP.Size = new System.Drawing.Size(80, 20);
            this.btnGenP.TabIndex = 83;
            this.btnGenP.Text = "Start";
            this.btnGenP.UseVisualStyleBackColor = true;
            this.btnGenP.Click += new System.EventHandler(this.btnGenP_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(494, 150);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 20);
            this.button1.TabIndex = 85;
            this.button1.Text = "Check Euler";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnGenAll
            // 
            this.btnGenAll.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnGenAll.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnGenAll.FlatAppearance.BorderSize = 2;
            this.btnGenAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGenAll.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGenAll.Location = new System.Drawing.Point(99, 12);
            this.btnGenAll.Name = "btnGenAll";
            this.btnGenAll.Size = new System.Drawing.Size(166, 20);
            this.btnGenAll.TabIndex = 86;
            this.btnGenAll.Text = "Generate All";
            this.btnGenAll.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnClear.FlatAppearance.BorderSize = 2;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClear.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClear.Location = new System.Drawing.Point(271, 12);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(166, 20);
            this.btnClear.TabIndex = 87;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCopyToEncrypt
            // 
            this.btnCopyToEncrypt.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCopyToEncrypt.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCopyToEncrypt.FlatAppearance.BorderSize = 2;
            this.btnCopyToEncrypt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCopyToEncrypt.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCopyToEncrypt.Location = new System.Drawing.Point(99, 259);
            this.btnCopyToEncrypt.Name = "btnCopyToEncrypt";
            this.btnCopyToEncrypt.Size = new System.Drawing.Size(166, 20);
            this.btnCopyToEncrypt.TabIndex = 88;
            this.btnCopyToEncrypt.Text = "Copy to encryption";
            this.btnCopyToEncrypt.UseVisualStyleBackColor = true;
            this.btnCopyToEncrypt.Click += new System.EventHandler(this.btnCopyToEncrypt_Click);
            // 
            // btnCopyToB
            // 
            this.btnCopyToB.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCopyToB.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCopyToB.FlatAppearance.BorderSize = 2;
            this.btnCopyToB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCopyToB.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCopyToB.Location = new System.Drawing.Point(272, 285);
            this.btnCopyToB.Name = "btnCopyToB";
            this.btnCopyToB.Size = new System.Drawing.Size(166, 20);
            this.btnCopyToB.TabIndex = 91;
            this.btnCopyToB.Text = "Copy to B";
            this.btnCopyToB.UseVisualStyleBackColor = true;
            this.btnCopyToB.Click += new System.EventHandler(this.btnCopyToB_Click);
            // 
            // btnCopyToA
            // 
            this.btnCopyToA.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCopyToA.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCopyToA.FlatAppearance.BorderSize = 2;
            this.btnCopyToA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCopyToA.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCopyToA.Location = new System.Drawing.Point(272, 259);
            this.btnCopyToA.Name = "btnCopyToA";
            this.btnCopyToA.Size = new System.Drawing.Size(166, 20);
            this.btnCopyToA.TabIndex = 90;
            this.btnCopyToA.Text = "Copy to A";
            this.btnCopyToA.UseVisualStyleBackColor = true;
            this.btnCopyToA.Click += new System.EventHandler(this.btnCopyToA_Click);
            // 
            // btnCopyToSign
            // 
            this.btnCopyToSign.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCopyToSign.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCopyToSign.FlatAppearance.BorderSize = 2;
            this.btnCopyToSign.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCopyToSign.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCopyToSign.Location = new System.Drawing.Point(100, 285);
            this.btnCopyToSign.Name = "btnCopyToSign";
            this.btnCopyToSign.Size = new System.Drawing.Size(166, 20);
            this.btnCopyToSign.TabIndex = 89;
            this.btnCopyToSign.Text = "Copy to Sign";
            this.btnCopyToSign.UseVisualStyleBackColor = true;
            this.btnCopyToSign.Click += new System.EventHandler(this.btnCopyToSign_Click);
            // 
            // btnGenD
            // 
            this.btnGenD.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnGenD.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnGenD.FlatAppearance.BorderSize = 2;
            this.btnGenD.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGenD.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGenD.Location = new System.Drawing.Point(494, 233);
            this.btnGenD.Name = "btnGenD";
            this.btnGenD.Size = new System.Drawing.Size(166, 20);
            this.btnGenD.TabIndex = 92;
            this.btnGenD.Text = "Start";
            this.btnGenD.UseVisualStyleBackColor = true;
            this.btnGenD.Click += new System.EventHandler(this.btnGenD_Click);
            // 
            // GenerateKey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(672, 314);
            this.Controls.Add(this.btnGenD);
            this.Controls.Add(this.btnCopyToB);
            this.Controls.Add(this.btnCopyToA);
            this.Controls.Add(this.btnCopyToSign);
            this.Controls.Add(this.btnCopyToEncrypt);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnGenAll);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCheckP);
            this.Controls.Add(this.btnGenP);
            this.Controls.Add(this.btnCheckQ);
            this.Controls.Add(this.btnGenQ);
            this.Controls.Add(this.btnGenN);
            this.Controls.Add(this.btnSet65537);
            this.Controls.Add(this.btnGenE);
            this.Controls.Add(this.txtE);
            this.Controls.Add(this.txtD);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtFi);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.txtQ);
            this.Controls.Add(this.txtP);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "GenerateKey";
            this.Text = "GenerateKey";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenE;
        public System.Windows.Forms.TextBox txtE;
        public System.Windows.Forms.TextBox txtD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox txtFi;
        public System.Windows.Forms.TextBox txtN;
        public System.Windows.Forms.TextBox txtQ;
        public System.Windows.Forms.TextBox txtP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSet65537;
        private System.Windows.Forms.Button btnGenN;
        private System.Windows.Forms.Button btnCheckQ;
        private System.Windows.Forms.Button btnGenQ;
        private System.Windows.Forms.Button btnCheckP;
        private System.Windows.Forms.Button btnGenP;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnGenAll;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCopyToEncrypt;
        private System.Windows.Forms.Button btnCopyToB;
        private System.Windows.Forms.Button btnCopyToA;
        private System.Windows.Forms.Button btnCopyToSign;
        private System.Windows.Forms.Button btnGenD;
    }
}