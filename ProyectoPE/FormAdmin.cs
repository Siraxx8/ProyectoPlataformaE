using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoPE
{
	
	public partial class FormAdmin : Form
	{
		public FormAdmin(bool idiomaActual)
		{	
			InitializeComponent();
			this.esEspanol = idiomaActual;
			ActualizarTabla();
		}
		void ActualizarTabla()
			{
    	dgvUsuarios.Rows.Clear();
    	if (dgvUsuarios.Columns.Count == 0) {
        dgvUsuarios.Columns.Add("user", "Usuario");
        dgvUsuarios.Columns.Add("rol", "Rol");
        dgvUsuarios.Columns.Add("score", "Puntuación");
    		}

    	for (int i = 0; i < Objetos.Usuarios.Count; i++) {
        string nombre = Objetos.Usuarios[i];
        string rol = Objetos.Roles[i];
        int puntos = Objetos.PuntuacionesJugadores.ContainsKey(nombre) ? Objetos.PuntuacionesJugadores[nombre] : 0;
        
        dgvUsuarios.Rows.Add(nombre, rol, puntos);
    		}
		}
		void BtnEliminarUsuarioClick(object sender, EventArgs e)
			{
    	if (dgvUsuarios.CurrentRow != null) {
        int index = dgvUsuarios.CurrentRow.Index;
        string nombre = Objetos.Usuarios[index];

        // Eliminar de todas las listas
        Objetos.Usuarios.RemoveAt(index);
        Objetos.Claves.RemoveAt(index);
        Objetos.Roles.RemoveAt(index);
        Objetos.PuntuacionesJugadores.Remove(nombre);

        ActualizarTabla();
        MessageBox.Show("Usuario eliminado.");
    		}
		}
		void BtnGuardarClick(object sender, EventArgs e)
{
    string u = txtUsuario.Text.Trim();
    string p = txtPass.Text.Trim();

    if (u != "" && p != "") {
        Objetos.Usuarios.Add(u);
        Objetos.Claves.Add(p);
        Objetos.Roles.Add("Jugador"); // Por defecto
        Objetos.PuntuacionesJugadores.Add(u, 0);

        ActualizarTabla();
        txtUsuario.Clear();
        txtPass.Clear();
    }
}
		// Al cambiar el módulo en el ComboBox
void CmbModulosSelectedIndexChanged(object sender, EventArgs e)
{
    // Aquí podrías cargar los textos actuales en los TextBox 
    // para que el admin sepa qué está modificando.
}

void BtnGuardarPreguntaClick(object sender, EventArgs e)
{
    // Nota: Para que esto sea permanente, deberías crear una lista de 
    // objetos "Pregunta" en la clase Objetos. 
    // Por ahora, podrías enviar un mensaje de confirmación:
    MessageBox.Show("Pregunta actualizada para el módulo: " + cmbModulos.Text);
}
		
		bool esEspanol;

		void BtnVolverClick(object sender, EventArgs e)
		{
			FormMenu f = new FormMenu();
				f.Show();
        		this.Close();
    		}			
		}
	}


