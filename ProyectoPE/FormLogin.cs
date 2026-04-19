
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoPE
{
	
	public partial class FormLogin : Form
	{
		public FormLogin()
		{
			InitializeComponent();
		}
		
		void BtnIniciarClick(object sender, EventArgs e)
		{
			int pos = Objetos.Usuarios.IndexOf(textUserLogin.Text);
            if (pos != -1 && Objetos.Claves[pos] == textPassLogin.Text)
            {
                Objetos.RolSesionActiva = Objetos.Roles[pos];
                Objetos.UsuarioLogeado = textUserLogin.Text;
    
                MessageBox.Show("¡Hola " + Objetos.RolSesionActiva + ", bienvenido al sistema!" , "Iniciaste sesión");
                FormMenu menu = new FormMenu();
                menu.Show();
                this.Hide(); 
            }
            else 
            { 
            	MessageBox.Show("Usuario o clave incorrectos." , "Inicio de sesión fallido"); 
            }
        }
		
		void ChkVerContraCheckedChanged(object sender, EventArgs e)
		{
			if (ChkVerContra.Checked)
			{
        		textPassLogin.PasswordChar = '\0';
   			} 
   			else 
   			{
        		textPassLogin.PasswordChar = '*';
			}
		}
		void BtnVolverClick(object sender, EventArgs e)
		{
			DialogResult dialogResult = MessageBox.Show("¿Seguro que deseas volver?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (dialogResult == DialogResult.Yes)
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
	}
}

		
		
	
