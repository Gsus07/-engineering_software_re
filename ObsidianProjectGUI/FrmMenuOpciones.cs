using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ObsidianProjectGUI
{
    public partial class FrmMenuOpciones : Form
    {
        public FrmMenuOpciones()
        {
            InitializeComponent();
        }

        private void MostrarFormSecundaria(object formHija)
        {
            if (this.Envoltura.Controls.Count > 0)
            {
                this.Envoltura.Controls.RemoveAt(0);
                Form form = formHija as Form;
                form.TopLevel = false;
                form.Dock = DockStyle.Fill;
                this.Envoltura.Controls.Add(form);
                this.Envoltura.Tag = form;
                form.Show();
            }
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wMsg, int wParam, int lParam);

        private void Envoltura_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnRestaurar.Visible = true;
            btnMaximizar.Visible = false;
        }

        private void RegistrarProducto_Click(object sender, EventArgs e)
        {
            MostrarFormSecundaria(new FrmProducto());
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            var respuesta = MessageBox.Show("¿DESEA CERRAR SESION?", "CERRAR SESION", MessageBoxButtons.YesNo);
            if (respuesta == DialogResult.Yes)
            {
                this.Close();
                FrmLogin frmLogin = new FrmLogin();
                frmLogin.Show();
            }
            
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void BtnCerrarSesion_Click(object sender, EventArgs e)
        {
            var respuesta = MessageBox.Show("¿DESEA CERRAR SESION?", "CERRAR SESION", MessageBoxButtons.YesNo);
            if (respuesta == DialogResult.Yes)
            {
                this.Close();
                FrmLogin frmLogin = new FrmLogin();
                frmLogin.Show();
            }
        }

        private void FechaHoraMenuOpciones_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MostrarFormSecundaria(new FrmGestionarPersona());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MostrarFormSecundaria(new FrmFacturaProducto());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MostrarFormSecundaria(new FrmFacturaEquipoAlquiler());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MostrarFormSecundaria(new FrmGestionarPersona());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MostrarFormSecundaria(new FrmInforme());
        }

        private void ContenedorMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblHora_Click(object sender, EventArgs e)
        {

        }

        private void lblFecha_Click(object sender, EventArgs e)
        {

        }
    }
}
