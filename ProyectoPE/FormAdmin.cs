using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;


namespace ProyectoPE
{
	
	public partial class FormAdmin : Form
	{
		string cadenaConexion = "Server=localhost; Database=proyectope; Uid=root; Pwd=;";
		public FormAdmin(bool idiomaActual)
		{
			InitializeComponent();
			this.esEspanol = idiomaActual;
			
			ActualizarComboModulos();
			Cargarusuarios();
		}
		
		void Cargarusuarios(){
			using (MySqlConnection conexion = new MySqlConnection(cadenaConexion)) {
			conexion.Open();
					//tabla de nombres que no se pueden usar
					string sqlnames = "SELECT id, nombre, contraseña, puntaje, rol FROM usuario";
					MySqlDataAdapter adapter = new MySqlDataAdapter(sqlnames, conexion);
					DataTable table = new DataTable();
					adapter.Fill(table);
					dgvUsuarios.DataSource = table;
			}
		}
		
		void BtnEliminarUsuarioClick(object sender, EventArgs e)
		{
			if (dgvUsuarios.CurrentRow != null) {
        // 1. Obtenemos el nombre del usuario directamente desde la celda seleccionada en el DataGridView
        string nombreUsuario = dgvUsuarios.CurrentRow.Cells["nombre"].Value.ToString();
        
        // Evitar que el Administrador se elimine a sí mismo por accidente si está logeado
        if (nombreUsuario == Objetos.UsuarioLogeado) {
            MessageBox.Show("No puedes eliminar al usuario con la sesión activa actual.", "Operación denegada"
        	                , MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        DialogResult confirmar = MessageBox.Show(
            "¿Seguro que deseas eliminar al usuario '" + nombreUsuario + "' permanentemente de la Base de Datos?", 
            "Confirmar eliminación", 
            MessageBoxButtons.YesNo, 
            MessageBoxIcon.Warning
        );

        if (confirmar == DialogResult.Yes) {
            using (MySqlConnection conexion = new MySqlConnection(cadenaConexion)) {
                try {
                    conexion.Open();
                    
                    // 2. Borramos en MySQL usando el parámetro del nombre obtenido
                    string sqlDelete = "DELETE FROM usuario WHERE nombre = @name";
                    MySqlCommand cmd = new MySqlCommand(sqlDelete, conexion);
                    cmd.Parameters.AddWithValue("@name", nombreUsuario);
                    cmd.ExecuteNonQuery();

                    // 3. Limpiamos en las listas en memoria por si acaso siguen en uso
                    if (Objetos.Usuarios.Contains(nombreUsuario)) {
                        int indexMemoria = Objetos.Usuarios.IndexOf(nombreUsuario);
                        Objetos.Usuarios.RemoveAt(indexMemoria);
                        Objetos.Claves.RemoveAt(indexMemoria);
                        Objetos.Roles.RemoveAt(indexMemoria);
                    }
                    Objetos.PuntuacionesJugadores.Remove(nombreUsuario);

                    // 4. Refrescamos la tabla
                    Cargarusuarios();
                    MessageBox.Show("Usuario '" + nombreUsuario + "' eliminado con éxito de la base de datos.","Eliminado"
                                    ,MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex) {
                    MessageBox.Show("Error al eliminar en la base de datos: " + ex.Message, "Error");
                }
            }
        }
    } 	
			else {
        MessageBox.Show("Por favor, selecciona una fila en la tabla de usuarios.", "Atención");
    }
		}
		
		void BtnGuardarClick(object sender, EventArgs e)
		{
			string u = txtUsuario.Text.Trim();
			string p = txtPass.Text.Trim();
			if (u== "" || p == "") {
					DialogResult dialogresult = MessageBox.Show("Ingresa usuario y contraseña", "Error", 
						                                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			return;	
			}
			
					
			
			
				string sqlCheck = "SELECT COUNT(*) FROM usuario WHERE nombre = @name";
				string sqlguardar = "INSERT INTO usuario (nombre, contraseña, rol, puntaje) VALUES (@user, @pass, @rol, @punt)";
				using (MySqlConnection conexion = new MySqlConnection(cadenaConexion)) {

					conexion.Open();
					MySqlCommand cmdCheck = new MySqlCommand(sqlCheck, conexion);
            		cmdCheck.Parameters.AddWithValue("@name", u);
            		
          			  if (Convert.ToInt32(cmdCheck.ExecuteScalar()) > 0) {
               			MessageBox.Show("El nombre de usuario '" + u + "' ya se encuentra registrado.", "error" , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                		return;
            		}
            		
					MySqlCommand cmd = new MySqlCommand(sqlguardar, conexion);
					cmd.Parameters.AddWithValue("@user", u);
					cmd.Parameters.AddWithValue("@pass", p);
					cmd.Parameters.AddWithValue("@rol", "Jugador");
					cmd.Parameters.AddWithValue("@punt", 0);
				
					cmd.ExecuteNonQuery();
					MessageBox.Show("Usuario registrado con exito","Guardar", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);	
					
           			 }
            Cargarusuarios();
            txtUsuario.Clear();
            txtPass.Clear();
            
            		}

		
		void ActualizarComboModulos()
		{
			// Limpiamos los items actuales
			cmbModulos.Items.Clear();
			
			// Recorremos la lista global y los añadimos al ComboBox
			foreach (string m in Objetos.ListaModulos)
			{
				cmbModulos.Items.Add(m);
			}
			
			// Opcional: Seleccionar el primer elemento si la lista no está vacía
			if (cmbModulos.Items.Count > 0)
			{
				cmbModulos.SelectedIndex = 0;
			}
		}


		void BtnGuardarPreguntaClick(object sender, EventArgs e)
		{
			string moduloSel = cmbModulos.Text;
			if (string.IsNullOrEmpty(moduloSel)) return;

			Objetos.DatosPregunta nuevaP = new Objetos.DatosPregunta();
			
			// Capturamos textos en español
			nuevaP.PreguntaEsp = txtPreguntaEsp.Text;
			nuevaP.Op1Esp = txtOp1Esp.Text; // Asegúrate que estos nombres sean tus TextBox
			nuevaP.Op2Esp = txtOp2Esp.Text;
			nuevaP.Op3Esp = txtOp3Esp.Text;
			nuevaP.Op4Esp = txtOp4Esp.Text;
			nuevaP.RespEsp = txtRespEsp.Text;

			// Capturamos textos en inglés
			nuevaP.PreguntaIng = txtPreguntaIng.Text;
			nuevaP.Op1Ing = txtOp1Ing.Text;
			nuevaP.Op2Ing = txtOp2Ing.Text;
			nuevaP.Op3Ing = txtOp3Ing.Text;
			nuevaP.Op4Ing = txtOp4Ing.Text;
			nuevaP.RespIng = txtRespIng.Text;

			// Guardamos o actualizamos en el diccionario global
			if (Objetos.PreguntasDinamicas.ContainsKey(moduloSel))
				Objetos.PreguntasDinamicas[moduloSel] = nuevaP;
			else
				Objetos.PreguntasDinamicas.Add(moduloSel, nuevaP);

			MessageBox.Show("Datos del módulo " + moduloSel + " guardados correctamente.");
		}
		
		bool esEspanol;

		void BtnVolverClick(object sender, EventArgs e)
		{
			FormMenu f = new FormMenu();
			f.Show();
			this.Close();
		}
		
		void BtnCrearMClick(object sender, EventArgs e)
		{
			// Microsoft.VisualBasic permite usar Interaction.InputBox
			
			string nuevoModulo = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el nombre del nuevo módulo:", "Crear Módulo");

			if (!string.IsNullOrWhiteSpace(nuevoModulo))
			{
				if (!Objetos.ListaModulos.Contains(nuevoModulo))
				{
					Objetos.ListaModulos.Add(nuevoModulo);
					MessageBox.Show("Módulo '" + nuevoModulo + "' creado exitosamente.");
				}
				else
				{
					MessageBox.Show("Ese módulo ya existe.");
				}
			}
			ActualizarComboModulos();
		}
		
		void BtnModificarMClick(object sender, EventArgs e)
		{
			string viejoNombre = Microsoft.VisualBasic.Interaction.InputBox("Nombre del módulo que desea cambiar:", "Modificar Módulo");

			if (Objetos.ListaModulos.Contains(viejoNombre))
			{
				string nuevoNombre = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el nuevo nombre para '" + viejoNombre + "':", "Nuevo Nombre");
				
				if (!string.IsNullOrWhiteSpace(nuevoNombre))
				{
					int indice = Objetos.ListaModulos.IndexOf(viejoNombre);
					Objetos.ListaModulos[indice] = nuevoNombre;
					MessageBox.Show("Módulo actualizado.");
				}
			}
			else if (!string.IsNullOrWhiteSpace(viejoNombre))
			{
				MessageBox.Show("El módulo no existe.");
			}
			ActualizarComboModulos();
		}
		
		void BtnVisualizarMClick(object sender, EventArgs e)
		{
			string lista = "Módulos actuales:\n\n";
			foreach (string m in Objetos.ListaModulos)
			{
				lista += "- " + m + "\n";
			}
			MessageBox.Show(lista, "Lista de Módulos");
			ActualizarComboModulos();
		}
		
		void BtnEliminarMClick(object sender, EventArgs e)
		{
			string moduloAEliminar = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el nombre exacto del módulo a eliminar:", "Eliminar Módulo");

			if (Objetos.ListaModulos.Contains(moduloAEliminar))
			{
				Objetos.ListaModulos.Remove(moduloAEliminar);
				MessageBox.Show("Módulo eliminado correctamente.");
			}
			else if (!string.IsNullOrWhiteSpace(moduloAEliminar))
			{
				MessageBox.Show("No se encontró ningún módulo con ese nombre.");
			}
			ActualizarComboModulos();
		}
		
		
	}
}