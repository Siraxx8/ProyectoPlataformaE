using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoPE
{
	
	public partial class FormMenu : Form
	{
		
		
		public FormMenu()
		{
		InitializeComponent();
		ConfigurarVistaPorRol();
		ActualizarTextos();
		lblNombreUsuario.Text = "Usuario: " + Objetos.UsuarioLogeado;
		}
		
		void ConfigurarVistaPorRol()
        {
            BtnPanelAdmin.Visible = (Objetos.RolSesionActiva == "Administrador");
        }
		
        void BtnCerrarSesionClick(object sender, EventArgs e)
        {
        	string pregunta = Objetos.idiEspañol ? "¿Quieres cerrar sesión?" : "Do you want to log out?";;
        	string titulo = Objetos.idiEspañol ? "Advertencia" : "Warning";
		
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
		        string mensaje = Objetos.idiEspañol ? "¡Seleccione un módulo!" : "Please select a module!";
    			MessageBox.Show(mensaje);
		    }
		            
        }
		void BtnPanelAdminClick(object sender, EventArgs e)
		{
			FormAdmin ventanaAdmin = new FormAdmin(Objetos.idiEspañol);
		    ventanaAdmin.Show();
		    this.Hide();
    	}
		void ActualizarTextos()
		{
			if (Objetos.idiEspañol){
    			
        BtnJugar.Text = "Jugar";
        btnIdioma.Text = "Change to english"; 
        BtnCerrarSesion.Text = "Cerrar Sesión";
        lblNombreUsuario.Text = "Usuario: " + Objetos.UsuarioLogeado;
        lblMenu.Text = "Menú Principal";
        lblpuntuacion.Text = "Puntuación:"+ Objetos.PuntuacionActual;
        BtnPanelAdmin.Text = "Panel de Administrador";
   
    					  }
  			else
   				 {
        BtnJugar.Text = "Play";
        btnIdioma.Text = "Cambiar a español";
        BtnCerrarSesion.Text = "Logout";
        lblNombreUsuario.Text = "User: " + Objetos.UsuarioLogeado;
        lblMenu.Text = "Main Menu";
        lblpuntuacion.Text = "Score:" + Objetos.PuntuacionActual;
        BtnPanelAdmin.Text = "Administrator panel";
    }
}
		void BtnIdiomaClick(object sender, EventArgs e)
		{
    		Objetos.idiEspañol = !Objetos.idiEspañol;
    		ActualizarTextos();
		}
		
		void FormMenuActivated(object sender, EventArgs e)
		{
			ActualizarTextos();
		}
	}
}
	
