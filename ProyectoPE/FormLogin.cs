
using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace ProyectoPE
{
	
	public partial class FormLogin : Form
	{
		string cadenaConexion = "Server=localhost; Database=proyectope; Uid=root; Pwd=;";
		public FormLogin()
		{
			InitializeComponent();
			Actualizartextos();
		}
		
		void BtnIniciarClick(object sender, EventArgs e)
		{
			string user = textUserLogin.Text.Trim();
    		string pass = textPassLogin.Text.Trim();
			string mensaje;
			string titulo;				

    if (user == "" || pass == "") {
    			mensaje = Objetos.idiEspañol ? "Por favor, ingrese usuario y contraseña." : "Please enter username and password.";
    			titulo = Objetos.idiEspañol ? "Campos vacíos" : "Empty fields";
    			MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        		return;
   				 }
			
    using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
    {
        
            conexion.Open();
            
            // Buscamos el usuario que coincida con el nombre y la contraseña
            string sqlLogin = "SELECT rol, nombre, puntaje FROM usuario WHERE nombre = @name AND contraseña = @con";
            
            MySqlCommand cmd = new MySqlCommand(sqlLogin, conexion);
            cmd.Parameters.AddWithValue("@name", user);
            cmd.Parameters.AddWithValue("@con", pass); // Nota: Asegúrate de que coincida con "contraseña" en tu BD
            
            // Ejecutamos el lector para obtener los datos del usuario si existe
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read()) // Si encuentra una coincidencia
                {
                    // Asignamos las variables globales que usa tu sistema
                    Objetos.RolSesionActiva = reader["rol"].ToString();
                    Objetos.UsuarioLogeado = reader["nombre"].ToString();
					int puntajeBD = Convert.ToInt32(reader["puntaje"]);
                    // Sincronizamos con el diccionario de puntuaciones por si se necesita en memoria
                    if (!Objetos.PuntuacionesJugadores.ContainsKey(Objetos.UsuarioLogeado))
                    {
                        Objetos.PuntuacionesJugadores.Add(Objetos.UsuarioLogeado, puntajeBD); 
                    }
                    else
                    {
                        // Si por algún motivo ya existía en memoria, actualizamos el valor con el de la BD
                        Objetos.PuntuacionesJugadores[Objetos.UsuarioLogeado] = puntajeBD;
                    }
					string m;
					string t;
					m = Objetos.idiEspañol ? "¡Hola " + Objetos.RolSesionActiva + ", bienvenido al sistema! " : "¡Hello " + Objetos.RolSesionActiva + ", welcome to the system!";
					t = Objetos.idiEspañol ? "Iniciaste sesión" : "You logged in";
                    MessageBox.Show(m,t, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    
                    FormMenu menu = new FormMenu();
                    menu.Show();
                    this.Hide(); 
                }
                else
                {
                	string c = Objetos.idiEspañol ? "Usuario o clave incorrectos." : "Incorrect username or password.";
                	string u = Objetos.idiEspañol ? "Inicio de sesión fallido" : "Failed Login";
                    MessageBox.Show(c, u, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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
				string v = Objetos.idiEspañol ? "¿Seguro que deseas volver?" : "Are you sure you want to come back?";
				string	b = Objetos.idiEspañol ? "Advertencia" : "Warning";
			DialogResult dialogResult = MessageBox.Show(v, b, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
		void Actualizartextos(){
		if (Objetos.idiEspañol) {
		lblsesion.Text = "Inicio de Sesión";
		lblusu.Text = "Ingresar Usuario:";
		lblcontra.Text = "Ingresar Contraseña";
		ChkVerContra.Text = "Mostrar contraseña";
		BtnIniciar.Text = "Iniciar Sesión";
		BtnVolver.Text = "Volver";
		}
			else{
		lblsesion.Text = "Login";
		lblusu.Text = "Enter User:";
		lblcontra.Text = "Enter Password";
		ChkVerContra.Text = "Show password";
		BtnIniciar.Text = "Login";
		BtnVolver.Text = "Return";
			
			}
		}
	}
}


		
		
	
