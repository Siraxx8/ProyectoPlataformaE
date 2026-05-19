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
        public static List<string> ListaModulos = new List<string> { "Arquitectura y Estructura del Computador", "Antropología Filosófica", "Cálculo", "Educación Física" };
		public static string UsuarioLogeado;
		public static bool idiEspañol = true;
		//preguntas para nuevo modulo
		public static Dictionary<string, DatosPregunta> PreguntasDinamicas = new Dictionary<string, DatosPregunta>();
   		
		public class DatosPregunta {
        public string PreguntaEsp, PreguntaIng;
        public string Op1Esp, Op2Esp, Op3Esp, Op4Esp;
        public string Op1Ing, Op2Ing, Op3Ing, Op4Ing;
        public string RespEsp, RespIng;
		}
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
        if (!string.IsNullOrEmpty(UsuarioLogeado)){
           PuntuacionesJugadores[UsuarioLogeado] = value;
            }
        }
    }
} 
}