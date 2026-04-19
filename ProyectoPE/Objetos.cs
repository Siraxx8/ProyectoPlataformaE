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
	}
}
