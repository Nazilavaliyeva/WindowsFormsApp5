namespace WindowsFormsApp5
{
    partial class F_parol
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_parol));
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtyenisifre = new System.Windows.Forms.TextBox();
            this.txtsifretekrar = new System.Windows.Forms.TextBox();
            this.lblemail = new System.Windows.Forms.Label();
            this.lblyenisifre = new System.Windows.Forms.Label();
            this.lblsifretekrari = new System.Windows.Forms.Label();
            this.btntesdiqs = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtemail
            // 
            this.txtemail.ForeColor = System.Drawing.Color.Navy;
            this.txtemail.Location = new System.Drawing.Point(175, 41);
            this.txtemail.Multiline = true;
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(300, 34);
            this.txtemail.TabIndex = 0;
            // 
            // txtyenisifre
            // 
            this.txtyenisifre.ForeColor = System.Drawing.Color.Navy;
            this.txtyenisifre.Location = new System.Drawing.Point(175, 97);
            this.txtyenisifre.Multiline = true;
            this.txtyenisifre.Name = "txtyenisifre";
            this.txtyenisifre.Size = new System.Drawing.Size(300, 34);
            this.txtyenisifre.TabIndex = 1;
            // 
            // txtsifretekrar
            // 
            this.txtsifretekrar.ForeColor = System.Drawing.Color.Navy;
            this.txtsifretekrar.Location = new System.Drawing.Point(175, 149);
            this.txtsifretekrar.Multiline = true;
            this.txtsifretekrar.Name = "txtsifretekrar";
            this.txtsifretekrar.Size = new System.Drawing.Size(300, 34);
            this.txtsifretekrar.TabIndex = 2;
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemail.ForeColor = System.Drawing.Color.Navy;
            this.lblemail.Location = new System.Drawing.Point(24, 37);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(65, 25);
            this.lblemail.TabIndex = 3;
            this.lblemail.Text = "E-mail";
            // 
            // lblyenisifre
            // 
            this.lblyenisifre.AutoSize = true;
            this.lblyenisifre.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblyenisifre.ForeColor = System.Drawing.Color.Navy;
            this.lblyenisifre.Location = new System.Drawing.Point(24, 93);
            this.lblyenisifre.Name = "lblyenisifre";
            this.lblyenisifre.Size = new System.Drawing.Size(89, 25);
            this.lblyenisifre.TabIndex = 4;
            this.lblyenisifre.Text = "Yeni şifrə";
            this.lblyenisifre.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblsifretekrari
            // 
            this.lblsifretekrari.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsifretekrari.ForeColor = System.Drawing.Color.Navy;
            this.lblsifretekrari.Location = new System.Drawing.Point(24, 149);
            this.lblsifretekrari.Name = "lblsifretekrari";
            this.lblsifretekrari.Size = new System.Drawing.Size(156, 29);
            this.lblsifretekrari.TabIndex = 0;
            this.lblsifretekrari.Text = "Şifrənin təkrarı";
            // 
            // btntesdiqs
            // 
            this.btntesdiqs.BackColor = System.Drawing.Color.White;
            this.btntesdiqs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntesdiqs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntesdiqs.ForeColor = System.Drawing.Color.Navy;
            this.btntesdiqs.Location = new System.Drawing.Point(233, 202);
            this.btntesdiqs.Name = "btntesdiqs";
            this.btntesdiqs.Size = new System.Drawing.Size(187, 52);
            this.btntesdiqs.TabIndex = 6;
            this.btntesdiqs.Text = "Təsdiqlə";
            this.btntesdiqs.UseVisualStyleBackColor = false;
            // 
            // F_parol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(494, 268);
            this.Controls.Add(this.lblsifretekrari);
            this.Controls.Add(this.lblyenisifre);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.btntesdiqs);
            this.Controls.Add(this.txtsifretekrar);
            this.Controls.Add(this.txtyenisifre);
            this.Controls.Add(this.txtemail);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "F_parol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Şifrəni dəyişdir";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtyenisifre;
        private System.Windows.Forms.TextBox txtsifretekrar;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label lblyenisifre;
        private System.Windows.Forms.Label lblsifretekrari;
        private System.Windows.Forms.Button btntesdiqs;
    }
}