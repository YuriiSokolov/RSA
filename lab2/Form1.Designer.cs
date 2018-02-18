namespace lab2
{
    partial class Menu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.btnGKey = new System.Windows.Forms.Button();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnSign = new System.Windows.Forms.Button();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnPOut = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGKey
            // 
            this.btnGKey.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnGKey.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnGKey.FlatAppearance.BorderSize = 2;
            this.btnGKey.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGKey.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGKey.Location = new System.Drawing.Point(12, 12);
            this.btnGKey.Name = "btnGKey";
            this.btnGKey.Size = new System.Drawing.Size(116, 30);
            this.btnGKey.TabIndex = 0;
            this.btnGKey.Text = "Generate Key";
            this.btnGKey.UseVisualStyleBackColor = true;
            this.btnGKey.Click += new System.EventHandler(this.btnGKey_Click);
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnEncrypt.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEncrypt.FlatAppearance.BorderSize = 2;
            this.btnEncrypt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEncrypt.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEncrypt.Location = new System.Drawing.Point(134, 12);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(111, 30);
            this.btnEncrypt.TabIndex = 1;
            this.btnEncrypt.Text = "Encryption";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnSign
            // 
            this.btnSign.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSign.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSign.FlatAppearance.BorderSize = 2;
            this.btnSign.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSign.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSign.Location = new System.Drawing.Point(82, 59);
            this.btnSign.Name = "btnSign";
            this.btnSign.Size = new System.Drawing.Size(101, 30);
            this.btnSign.TabIndex = 2;
            this.btnSign.Text = "Sign";
            this.btnSign.UseVisualStyleBackColor = true;
            this.btnSign.Click += new System.EventHandler(this.btnSign_Click);
            // 
            // btnIn
            // 
            this.btnIn.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnIn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnIn.FlatAppearance.BorderSize = 2;
            this.btnIn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIn.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnIn.Location = new System.Drawing.Point(12, 109);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(116, 30);
            this.btnIn.TabIndex = 3;
            this.btnIn.Text = "Protocol INPUT";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnPOut
            // 
            this.btnPOut.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnPOut.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPOut.FlatAppearance.BorderSize = 2;
            this.btnPOut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPOut.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPOut.Location = new System.Drawing.Point(134, 109);
            this.btnPOut.Name = "btnPOut";
            this.btnPOut.Size = new System.Drawing.Size(111, 30);
            this.btnPOut.TabIndex = 4;
            this.btnPOut.Text = "Protocol OUTPUT";
            this.btnPOut.UseVisualStyleBackColor = true;
            this.btnPOut.Click += new System.EventHandler(this.btnPOut_Click);
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnExit.FlatAppearance.BorderSize = 2;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExit.Location = new System.Drawing.Point(82, 157);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(101, 30);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(257, 189);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPOut);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.btnSign);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.btnGKey);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGKey;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnSign;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnPOut;
        private System.Windows.Forms.Button btnExit;
    }
}

