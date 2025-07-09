using System;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Qeydiyyat qeydiyyat = new Qeydiyyat();
            qeydiyyat.ShowDialog();


        }

        private void btngiris_Click(object sender, EventArgs e)
        {
            Frmbacar a = new Frmbacar();
            a.ShowDialog();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            F_parol parol = new F_parol();
            parol.ShowDialog();
        }
    }
}
