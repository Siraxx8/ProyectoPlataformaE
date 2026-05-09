using System;
using System.Collections.Generic;

namespace ProyectoPE
{
	
	public class Objetos
	{
		public static List<string> Usuarios = new List<string>();
        public static List<string> Claves = new List<string>();
        public static List<string> Roles = new List<string>();
        public static string RolSesionActiva = "";
        public static List<string> ListaModulos = new List<string> { "Arquitectura", "Antropología", "Cálculo", "Deporte" };
		public static string UsuarioLogeado;
		public static bool idiEspañol = true;
		// Diccionario para guardar puntuaciones individuales
    	public static Dictionary<string, int> PuntuacionesJugadores = new Dictionary<string, int>();
    	// Propiedad para obtener la puntuación del que está jugando en el momento
    	public static int PuntuacionActual
    		{
        get 
        	{ 
        if (string.IsNullOrEmpty(UsuarioLogeado)) return 0;
        if (!PuntuacionesJugadores.ContainsKey(UsuarioLogeado)) return 0;
        return PuntuacionesJugadores[UsuarioLogeado];
        	}
        set 
        	{
        if (!string.IsNullOrEmpty(UsuarioLogeado))
            {
                PuntuacionesJugadores[UsuarioLogeado] = value;
            }
        }
    }
} 
}

