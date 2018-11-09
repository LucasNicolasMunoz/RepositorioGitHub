using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SistemaFER_v02
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent(); 
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBoxMaximizar_Click(object sender, EventArgs e)
        {
            if (this.WindowState==FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
                pictureBoxMaximizar.Visible = false;
                pictureBoxRestaurar.Visible = true;
            }


        }

        private void pictureBoxRestaurar_Click(object sender, EventArgs e)
        {
            if(this.WindowState==FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                this.CenterToScreen();
                pictureBoxMaximizar.Visible = true;
                pictureBoxRestaurar.Visible = false;
            }
 
        }

        private void pictureBoxMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        public void AbrirForm<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = panelContenedorCentral.Controls.OfType<MiForm>().FirstOrDefault();
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                panelContenedorCentral.Controls.Add(formulario);
                panelContenedorCentral.Tag = formulario;
                formulario.Show();
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                formulario.BringToFront();
                formulario.FormClosed += new FormClosedEventHandler(CloseForms);

            }
            else
            {
                formulario.BringToFront();
            }
        }
        private void CloseForms(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms["Form1"] == null)
                btnAgregarPedido.BackColor = Color.FromArgb(192, 64, 0);
        }

        private void btnAgregarPedido_Click(object sender, EventArgs e)
        {
            AbrirForm<Form1>();
            btnAgregarPedido.BackColor = Color.FromArgb(255, 128, 0);
        }
    }
}
