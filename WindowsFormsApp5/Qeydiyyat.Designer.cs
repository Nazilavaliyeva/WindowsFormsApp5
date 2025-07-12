namespace WindowsFormsApp5
{
    partial class Qeydiyyat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Qeydiyyat));
            this.lbladq = new System.Windows.Forms.Label();
            this.lblsoyadq = new System.Windows.Forms.Label();
            this.lbldogumq = new System.Windows.Forms.Label();
            this.lblregionq = new System.Windows.Forms.Label();
            this.lblmailq = new System.Windows.Forms.Label();
            this.txtadq = new System.Windows.Forms.TextBox();
            this.txtsoyadq = new System.Windows.Forms.TextBox();
            this.txtdogumq = new System.Windows.Forms.TextBox();
            this.txtregionq = new System.Windows.Forms.TextBox();
            this.txtmailq = new System.Windows.Forms.TextBox();
            this.btntesdiqq = new System.Windows.Forms.Button();
            this.txtyenisifreq = new System.Windows.Forms.TextBox();
            this.txtsifreq = new System.Windows.Forms.TextBox();
            this.lblsifreq = new System.Windows.Forms.Label();
            this.lbltekrarq = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbladq
            // 
            this.lbladq.AutoSize = true;
            this.lbladq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbladq.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladq.ForeColor = System.Drawing.Color.Black;
            this.lbladq.Location = new System.Drawing.Point(2, 36);
            this.lbladq.Name = "lbladq";
            this.lbladq.Size = new System.Drawing.Size(33, 23);
            this.lbladq.TabIndex = 0;
            this.lbladq.Text = "Ad";
            // 
            // lblsoyadq
            // 
            this.lblsoyadq.AutoSize = true;
            this.lblsoyadq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblsoyadq.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsoyadq.ForeColor = System.Drawing.Color.Black;
            this.lblsoyadq.Location = new System.Drawing.Point(2, 94);
            this.lblsoyadq.Name = "lblsoyadq";
            this.lblsoyadq.Size = new System.Drawing.Size(59, 23);
            this.lblsoyadq.TabIndex = 1;
            this.lblsoyadq.Text = "Soyad";
            // 
            // lbldogumq
            // 
            this.lbldogumq.AutoSize = true;
            this.lbldogumq.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbldogumq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbldogumq.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldogumq.ForeColor = System.Drawing.Color.Black;
            this.lbldogumq.Location = new System.Drawing.Point(2, 152);
            this.lbldogumq.Name = "lbldogumq";
            this.lbldogumq.Size = new System.Drawing.Size(117, 23);
            this.lbldogumq.TabIndex = 2;
            this.lbldogumq.Text = "Doğum tarixi";
            // 
            // lblregionq
            // 
            this.lblregionq.AutoSize = true;
            this.lblregionq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblregionq.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblregionq.ForeColor = System.Drawing.Color.Black;
            this.lblregionq.Location = new System.Drawing.Point(2, 210);
            this.lblregionq.Name = "lblregionq";
            this.lblregionq.Size = new System.Drawing.Size(66, 23);
            this.lblregionq.TabIndex = 3;
            this.lblregionq.Text = "Region";
            this.lblregionq.Click += new System.EventHandler(this.lblregion_Click);
            // 
            // lblmailq
            // 
            this.lblmailq.AutoSize = true;
            this.lblmailq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblmailq.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmailq.ForeColor = System.Drawing.Color.Black;
            this.lblmailq.Location = new System.Drawing.Point(2, 268);
            this.lblmailq.Name = "lblmailq";
            this.lblmailq.Size = new System.Drawing.Size(61, 23);
            this.lblmailq.TabIndex = 4;
            this.lblmailq.Text = "E-mail";
            this.lblmailq.Click += new System.EventHandler(this.lblmail_Click);
            // 
            // txtadq
            // 
            this.txtadq.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtadq.ForeColor = System.Drawing.Color.Black;
            this.txtadq.Location = new System.Drawing.Point(158, 21);
            this.txtadq.Multiline = true;
            this.txtadq.Name = "txtadq";
            this.txtadq.Size = new System.Drawing.Size(236, 38);
            this.txtadq.TabIndex = 5;
            // 
            // txtsoyadq
            // 
            this.txtsoyadq.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsoyadq.ForeColor = System.Drawing.Color.Black;
            this.txtsoyadq.Location = new System.Drawing.Point(158, 79);
            this.txtsoyadq.Multiline = true;
            this.txtsoyadq.Name = "txtsoyadq";
            this.txtsoyadq.Size = new System.Drawing.Size(236, 38);
            this.txtsoyadq.TabIndex = 6;
            // 
            // txtdogumq
            // 
            this.txtdogumq.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdogumq.ForeColor = System.Drawing.Color.Black;
            this.txtdogumq.Location = new System.Drawing.Point(158, 137);
            this.txtdogumq.Multiline = true;
            this.txtdogumq.Name = "txtdogumq";
            this.txtdogumq.Size = new System.Drawing.Size(236, 38);
            this.txtdogumq.TabIndex = 7;
            // 
            // txtregionq
            // 
            this.txtregionq.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtregionq.ForeColor = System.Drawing.Color.Black;
            this.txtregionq.Location = new System.Drawing.Point(158, 195);
            this.txtregionq.Multiline = true;
            this.txtregionq.Name = "txtregionq";
            this.txtregionq.Size = new System.Drawing.Size(236, 38);
            this.txtregionq.TabIndex = 8;
            this.txtregionq.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtmailq
            // 
            this.txtmailq.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmailq.ForeColor = System.Drawing.Color.Black;
            this.txtmailq.Location = new System.Drawing.Point(158, 253);
            this.txtmailq.Multiline = true;
            this.txtmailq.Name = "txtmailq";
            this.txtmailq.Size = new System.Drawing.Size(236, 38);
            this.txtmailq.TabIndex = 9;
            this.txtmailq.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // btntesdiqq
            // 
            this.btntesdiqq.BackColor = System.Drawing.Color.White;
            this.btntesdiqq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntesdiqq.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntesdiqq.ForeColor = System.Drawing.Color.Black;
            this.btntesdiqq.Location = new System.Drawing.Point(181, 433);
            this.btntesdiqq.Name = "btntesdiqq";
            this.btntesdiqq.Size = new System.Drawing.Size(160, 41);
            this.btntesdiqq.TabIndex = 10;
            this.btntesdiqq.Text = "Təsdiqlə";
            this.btntesdiqq.UseVisualStyleBackColor = false;
            this.btntesdiqq.Click += new System.EventHandler(this.btntesdiqq_Click);
            // 
            // txtyenisifreq
            // 
            this.txtyenisifreq.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtyenisifreq.ForeColor = System.Drawing.Color.Black;
            this.txtyenisifreq.Location = new System.Drawing.Point(158, 311);
            this.txtyenisifreq.Multiline = true;
            this.txtyenisifreq.Name = "txtyenisifreq";
            this.txtyenisifreq.Size = new System.Drawing.Size(236, 38);
            this.txtyenisifreq.TabIndex = 12;
            // 
            // txtsifreq
            // 
            this.txtsifreq.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsifreq.ForeColor = System.Drawing.Color.Black;
            this.txtsifreq.Location = new System.Drawing.Point(158, 369);
            this.txtsifreq.Multiline = true;
            this.txtsifreq.Name = "txtsifreq";
            this.txtsifreq.Size = new System.Drawing.Size(236, 38);
            this.txtsifreq.TabIndex = 11;
            // 
            // lblsifreq
            // 
            this.lblsifreq.AutoSize = true;
            this.lblsifreq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblsifreq.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsifreq.ForeColor = System.Drawing.Color.Black;
            this.lblsifreq.Location = new System.Drawing.Point(2, 326);
            this.lblsifreq.Name = "lblsifreq";
            this.lblsifreq.Size = new System.Drawing.Size(82, 23);
            this.lblsifreq.TabIndex = 13;
            this.lblsifreq.Text = "Yeni şifrə";
            // 
            // lbltekrarq
            // 
            this.lbltekrarq.AutoSize = true;
            this.lbltekrarq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbltekrarq.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltekrarq.ForeColor = System.Drawing.Color.Black;
            this.lbltekrarq.Location = new System.Drawing.Point(2, 384);
            this.lbltekrarq.Name = "lbltekrarq";
            this.lbltekrarq.Size = new System.Drawing.Size(132, 23);
            this.lbltekrarq.TabIndex = 14;
            this.lbltekrarq.Text = "Şifrənin təkrarı";
            // 
            // Qeydiyyat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(134)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(415, 486);
            this.Controls.Add(this.lbltekrarq);
            this.Controls.Add(this.lblsifreq);
            this.Controls.Add(this.txtyenisifreq);
            this.Controls.Add(this.txtsifreq);
            this.Controls.Add(this.btntesdiqq);
            this.Controls.Add(this.txtmailq);
            this.Controls.Add(this.txtregionq);
            this.Controls.Add(this.txtdogumq);
            this.Controls.Add(this.txtsoyadq);
            this.Controls.Add(this.txtadq);
            this.Controls.Add(this.lblmailq);
            this.Controls.Add(this.lblregionq);
            this.Controls.Add(this.lbldogumq);
            this.Controls.Add(this.lblsoyadq);
            this.Controls.Add(this.lbladq);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Qeydiyyat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Qeydiyyat";
            this.Load += new System.EventHandler(this.Qeydiyyat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbladq;
        private System.Windows.Forms.Label lblsoyadq;
        private System.Windows.Forms.Label lbldogumq;
        private System.Windows.Forms.Label lblregionq;
        private System.Windows.Forms.Label lblmailq;
        private System.Windows.Forms.TextBox txtadq;
        private System.Windows.Forms.TextBox txtsoyadq;
        private System.Windows.Forms.TextBox txtdogumq;
        private System.Windows.Forms.TextBox txtregionq;
        private System.Windows.Forms.TextBox txtmailq;
        private System.Windows.Forms.Button btntesdiqq;
        private System.Windows.Forms.TextBox txtyenisifreq;
        private System.Windows.Forms.TextBox txtsifreq;
        private System.Windows.Forms.Label lblsifreq;
        private System.Windows.Forms.Label lbltekrarq;
    }
}