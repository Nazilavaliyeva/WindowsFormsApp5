namespace WindowsFormsApp5
{
    partial class Frmbacar
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmbacar));
            this.btn_c = new System.Windows.Forms.Button();
            this.btn_b = new System.Windows.Forms.Button();
            this.btn_d = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_geri = new System.Windows.Forms.Button();
            this.pb_yes = new System.Windows.Forms.PictureBox();
            this.pb_no = new System.Windows.Forms.PictureBox();
            this.btn_ireli = new System.Windows.Forms.Button();
            this.richtxtsual = new System.Windows.Forms.RichTextBox();
            this.pb_sekil = new System.Windows.Forms.PictureBox();
            this.lbluser = new System.Windows.Forms.Label();
            this.lblduzgun = new System.Windows.Forms.Label();
            this.lblsualatla = new System.Windows.Forms.Label();
            this.lbl_vaxt = new System.Windows.Forms.Label();
            this.lbl_xal = new System.Windows.Forms.Label();
            this.lbl_bal = new System.Windows.Forms.Label();
            this.lblsual = new System.Windows.Forms.Label();
            this.btn_a = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_yes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_no)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_sekil)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_c
            // 
            this.btn_c.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_c.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_c.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_c.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_c.Location = new System.Drawing.Point(19, 532);
            this.btn_c.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_c.Name = "btn_c";
            this.btn_c.Size = new System.Drawing.Size(285, 69);
            this.btn_c.TabIndex = 1;
            this.btn_c.Text = "C";
            this.btn_c.UseVisualStyleBackColor = false;
            // 
            // btn_b
            // 
            this.btn_b.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_b.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_b.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_b.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_b.Location = new System.Drawing.Point(341, 430);
            this.btn_b.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_b.Name = "btn_b";
            this.btn_b.Size = new System.Drawing.Size(285, 69);
            this.btn_b.TabIndex = 2;
            this.btn_b.Text = "B";
            this.btn_b.UseVisualStyleBackColor = false;
            this.btn_b.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_d
            // 
            this.btn_d.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_d.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_d.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_d.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_d.Location = new System.Drawing.Point(341, 532);
            this.btn_d.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_d.Name = "btn_d";
            this.btn_d.Size = new System.Drawing.Size(285, 69);
            this.btn_d.TabIndex = 3;
            this.btn_d.Text = "D";
            this.btn_d.UseVisualStyleBackColor = false;
            // 
            // btn_geri
            // 
            this.btn_geri.BackColor = System.Drawing.Color.SlateGray;
            this.btn_geri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_geri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_geri.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_geri.Location = new System.Drawing.Point(939, 532);
            this.btn_geri.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_geri.Name = "btn_geri";
            this.btn_geri.Size = new System.Drawing.Size(285, 69);
            this.btn_geri.TabIndex = 5;
            this.btn_geri.Text = "Geri";
            this.btn_geri.UseVisualStyleBackColor = false;
            // 
            // pb_yes
            // 
            this.pb_yes.BackColor = System.Drawing.Color.Lime;
            this.pb_yes.Location = new System.Drawing.Point(657, 430);
            this.pb_yes.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pb_yes.Name = "pb_yes";
            this.pb_yes.Size = new System.Drawing.Size(163, 69);
            this.pb_yes.TabIndex = 6;
            this.pb_yes.TabStop = false;
            // 
            // pb_no
            // 
            this.pb_no.BackColor = System.Drawing.Color.Firebrick;
            this.pb_no.Location = new System.Drawing.Point(657, 532);
            this.pb_no.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pb_no.Name = "pb_no";
            this.pb_no.Size = new System.Drawing.Size(163, 69);
            this.pb_no.TabIndex = 7;
            this.pb_no.TabStop = false;
            // 
            // btn_ireli
            // 
            this.btn_ireli.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_ireli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ireli.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ireli.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_ireli.Location = new System.Drawing.Point(939, 430);
            this.btn_ireli.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_ireli.Name = "btn_ireli";
            this.btn_ireli.Size = new System.Drawing.Size(285, 69);
            this.btn_ireli.TabIndex = 8;
            this.btn_ireli.Text = "İrəli";
            this.btn_ireli.UseVisualStyleBackColor = false;
            this.btn_ireli.Click += new System.EventHandler(this.btn_ireli_Click);
            // 
            // richtxtsual
            // 
            this.richtxtsual.BackColor = System.Drawing.Color.RoyalBlue;
            this.richtxtsual.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.richtxtsual.Location = new System.Drawing.Point(15, 14);
            this.richtxtsual.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.richtxtsual.Name = "richtxtsual";
            this.richtxtsual.Size = new System.Drawing.Size(611, 393);
            this.richtxtsual.TabIndex = 9;
            this.richtxtsual.Text = "";
            // 
            // pb_sekil
            // 
            this.pb_sekil.Location = new System.Drawing.Point(643, 14);
            this.pb_sekil.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pb_sekil.Name = "pb_sekil";
            this.pb_sekil.Size = new System.Drawing.Size(581, 396);
            this.pb_sekil.TabIndex = 10;
            this.pb_sekil.TabStop = false;
            // 
            // lbluser
            // 
            this.lbluser.AutoSize = true;
            this.lbluser.BackColor = System.Drawing.Color.Gainsboro;
            this.lbluser.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbluser.Location = new System.Drawing.Point(1234, 30);
            this.lbluser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbluser.Name = "lbluser";
            this.lbluser.Size = new System.Drawing.Size(110, 25);
            this.lbluser.TabIndex = 11;
            this.lbluser.Text = "Username";
            // 
            // lblduzgun
            // 
            this.lblduzgun.AutoSize = true;
            this.lblduzgun.BackColor = System.Drawing.Color.Gainsboro;
            this.lblduzgun.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblduzgun.Location = new System.Drawing.Point(1234, 88);
            this.lblduzgun.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblduzgun.Name = "lblduzgun";
            this.lblduzgun.Size = new System.Drawing.Size(195, 25);
            this.lblduzgun.TabIndex = 12;
            this.lblduzgun.Text = "Düzgün cavab sayı";
            // 
            // lblsualatla
            // 
            this.lblsualatla.AutoSize = true;
            this.lblsualatla.BackColor = System.Drawing.Color.Gainsboro;
            this.lblsualatla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblsualatla.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblsualatla.Location = new System.Drawing.Point(1234, 146);
            this.lblsualatla.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblsualatla.Name = "lblsualatla";
            this.lblsualatla.Size = new System.Drawing.Size(180, 25);
            this.lblsualatla.TabIndex = 13;
            this.lblsualatla.Text = "Yanlış cavab sayı";
            // 
            // lbl_vaxt
            // 
            this.lbl_vaxt.AutoSize = true;
            this.lbl_vaxt.BackColor = System.Drawing.Color.Gainsboro;
            this.lbl_vaxt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_vaxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_vaxt.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_vaxt.Location = new System.Drawing.Point(1234, 262);
            this.lbl_vaxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_vaxt.Name = "lbl_vaxt";
            this.lbl_vaxt.Size = new System.Drawing.Size(116, 25);
            this.lbl_vaxt.TabIndex = 14;
            this.lbl_vaxt.Text = "Qalan vaxt";
            // 
            // lbl_xal
            // 
            this.lbl_xal.AutoSize = true;
            this.lbl_xal.BackColor = System.Drawing.Color.Gainsboro;
            this.lbl_xal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_xal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_xal.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_xal.Location = new System.Drawing.Point(1234, 320);
            this.lbl_xal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_xal.Name = "lbl_xal";
            this.lbl_xal.Size = new System.Drawing.Size(144, 25);
            this.lbl_xal.TabIndex = 15;
            this.lbl_xal.Text = "Qazanılan xal";
            // 
            // lbl_bal
            // 
            this.lbl_bal.AutoSize = true;
            this.lbl_bal.BackColor = System.Drawing.Color.LightGray;
            this.lbl_bal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_bal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bal.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_bal.Location = new System.Drawing.Point(1234, 378);
            this.lbl_bal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_bal.Name = "lbl_bal";
            this.lbl_bal.Size = new System.Drawing.Size(115, 25);
            this.lbl_bal.TabIndex = 16;
            this.lbl_bal.Text = "Ümumi Bal";
            // 
            // lblsual
            // 
            this.lblsual.AutoSize = true;
            this.lblsual.BackColor = System.Drawing.Color.Gainsboro;
            this.lblsual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblsual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsual.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblsual.Location = new System.Drawing.Point(1234, 204);
            this.lblsual.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblsual.Name = "lblsual";
            this.lblsual.Size = new System.Drawing.Size(155, 25);
            this.lblsual.TabIndex = 17;
            this.lblsual.Text = "Sualın nömrəsi";
            // 
            // btn_a
            // 
            this.btn_a.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_a.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_a.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_a.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_a.Location = new System.Drawing.Point(19, 429);
            this.btn_a.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_a.Name = "btn_a";
            this.btn_a.Size = new System.Drawing.Size(285, 69);
            this.btn_a.TabIndex = 0;
            this.btn_a.Text = "A";
            this.btn_a.UseVisualStyleBackColor = false;
            this.btn_a.Click += new System.EventHandler(this.btn_a_Click);
            // 
            // Frmbacar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1480, 614);
            this.Controls.Add(this.lblsual);
            this.Controls.Add(this.lbl_bal);
            this.Controls.Add(this.lbl_xal);
            this.Controls.Add(this.lbl_vaxt);
            this.Controls.Add(this.lblsualatla);
            this.Controls.Add(this.lblduzgun);
            this.Controls.Add(this.lbluser);
            this.Controls.Add(this.pb_sekil);
            this.Controls.Add(this.richtxtsual);
            this.Controls.Add(this.btn_ireli);
            this.Controls.Add(this.pb_no);
            this.Controls.Add(this.pb_yes);
            this.Controls.Add(this.btn_geri);
            this.Controls.Add(this.btn_d);
            this.Controls.Add(this.btn_b);
            this.Controls.Add(this.btn_c);
            this.Controls.Add(this.btn_a);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Frmbacar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bacar_IQ";
            ((System.ComponentModel.ISupportInitialize)(this.pb_yes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_no)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_sekil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_c;
        private System.Windows.Forms.Button btn_b;
        private System.Windows.Forms.Button btn_d;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_geri;
        private System.Windows.Forms.PictureBox pb_yes;
        private System.Windows.Forms.PictureBox pb_no;
        private System.Windows.Forms.Button btn_ireli;
        private System.Windows.Forms.RichTextBox richtxtsual;
        private System.Windows.Forms.PictureBox pb_sekil;
        private System.Windows.Forms.Label lbluser;
        private System.Windows.Forms.Label lblduzgun;
        private System.Windows.Forms.Label lblsualatla;
        private System.Windows.Forms.Label lbl_vaxt;
        private System.Windows.Forms.Label lbl_xal;
        private System.Windows.Forms.Label lbl_bal;
        private System.Windows.Forms.Label lblsual;
        private System.Windows.Forms.Button btn_a;
    }
}

