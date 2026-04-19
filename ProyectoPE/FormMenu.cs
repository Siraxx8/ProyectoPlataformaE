using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoPE
{
	
	public partial class FormMenu : Form
	{
		bool esEspanol = true;
		
		public FormMenu()
		{
		InitializeComponent();
		ConfigurarVistaPorRol();
		lblNombreUsuario.Text = "Usuario: " + Objetos.UsuarioLogeado;
		}
		
		void ConfigurarVistaPorRol()
        {
            BtnPanelAdmin.Visible = (Objetos.RolSesionActiva == "Administrador");
        }
		
        void BtnCerrarSesionClick(object sender, EventArgs e)
        {
        	string pregunta = "¿Quieres cerrar sesión?";
		    string titulo = "Advertencia";
		
		    DialogResult result = MessageBox.Show(pregunta, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

		    if (result == DialogResult.Yes)
		    {
		        foreach (Form f in Application.OpenForms)
		        {
		            if (f is MainForm)
		            {
		                f.Show();
		                break;
		            }
		        }
		        this.Close();
		    }
        }

        void BtnJugarClick(object sender, EventArgs e)
        {
            if (cmbModulos.SelectedIndex != -1) 
    		{
		        FormPreguntas ventanaJuego = new FormPreguntas(cmbModulos.Text);
		        ventanaJuego.Show();
		        this.Hide(); 
		    }
		    else 
		    {
		        MessageBox.Show("¡Seleccione un módulo!");
		    }
		            
        }
		void BtnPanelAdminClick(object sender, EventArgs e)
		{
			FormAdmin ventanaAdmin = new FormAdmin(esEspanol);
		    ventanaAdmin.Show();
		    this.Hide();
    	}
		
	}
}
	
