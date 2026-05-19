using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace ProyectoPE
{
    public partial class FormPreguntas : Form
    {
    	string cadenaConexion = "Server=localhost; Database=proyectope; Uid=root; Pwd=;";
        string modulo;
        string respuestaCorrecta = "";
        int numeroPregunta = 1; // Contador para las preguntas dentro del mismo módulo
        const int MAX_PREGUNTAS = 10; // Cantidad de preguntas por módulo

        public FormPreguntas(string moduloSeleccionado)
        {
            InitializeComponent();
            this.modulo = moduloSeleccionado;
            CargarPregunta();
            
        }

        void CargarPregunta()
        {
        	//modulo creado por admin
        	bool idiEspañol = Objetos.idiEspañol;

    // 1. Verificar si es un módulo dinámico (creado por el admin)
    if (Objetos.PreguntasDinamicas.ContainsKey(modulo))
    {
        var datos = Objetos.PreguntasDinamicas[modulo];
        picComponente.Visible = false; // Opcional: ocultar imagen si no hay para módulos nuevos

        if (idiEspañol) {
            lblPregunta.Text = datos.PreguntaEsp;
            EstablecerOpciones(datos.Op1Esp, datos.Op2Esp, datos.Op3Esp, datos.Op4Esp);
            respuestaCorrecta = datos.RespEsp;
        } else {
            lblPregunta.Text = datos.PreguntaIng;
            EstablecerOpciones(datos.Op1Ing, datos.Op2Ing, datos.Op3Ing, datos.Op4Ing);
            respuestaCorrecta = datos.RespIng;
        }
        return ;
    }
        	//Modulos creados por código
        	
            picComponente.Visible = true;
            picComponente.SizeMode = PictureBoxSizeMode.Zoom;
            

            // ARQUITECTURA
            if (modulo == "Arquitectura y Estructura del Computador")
            {
                picComponente.Image = (Bitmap)ProyectoPE.Resource.ResourceManager.GetObject("Arquitectura");
                if (numeroPregunta == 1) {
                    lblPregunta.Text = idiEspañol ? "¿Qué sucede con la RAM al apagar la PC?" : "What happens to RAM when the PC is off?";
                    if (idiEspañol) EstablecerOpciones("Se borra", "Se guarda", "Se quema", "Se mueve al disco");
                    else EstablecerOpciones("It is erased", "It is saved", "It burns", "Moves to disk");
                    respuestaCorrecta = idiEspañol ? "Se borra" : "It is erased";
                }
                else if (numeroPregunta == 2) {
                	picComponente.Image = (Bitmap)ProyectoPE.Resource.ResourceManager.GetObject("proce");
                    lblPregunta.Text = idiEspañol ? "¿Cuál es el cerebro de la computadora?" : "What is the brain of the computer?";
                    if (idiEspañol)EstablecerOpciones("Monitor", "CPU", "RAM", "Tarjeta madre");
                    else EstablecerOpciones("Monitor", "CPU", "RAM", "Motherboard");
                    respuestaCorrecta = idiEspañol ? "CPU" : "CPU";
                }
                else if (numeroPregunta == 3) {
                	picComponente.Image = (Bitmap)ProyectoPE.Resource.ResourceManager.GetObject("proce");
                    lblPregunta.Text = idiEspañol ? "¿Cómo se llama la parte física y tangible de una computadora?" : "What is the physical and tangible part of a computer called?";
                    if (idiEspañol)EstablecerOpciones("Software", "Hardware", "Base de datos", "Algoritmo");
                    else EstablecerOpciones("Software", "Hardware", "Database", "Algorithm");
                    respuestaCorrecta = idiEspañol ? "Hardware" : "Hardware";
                }
                else if (numeroPregunta == 4) {
                	picComponente.Image = (Bitmap)ProyectoPE.Resource.ResourceManager.GetObject("proce");
                    lblPregunta.Text = idiEspañol ? "¿Qué actividad consiste en unir la tarjeta madre, procesador y memoria en el case?" : "Which activity consists of joining the motherboard, processor, and memory in the case?";
                    if (idiEspañol)EstablecerOpciones("Formateo de disco", "Diseño de interfaz", "Armado del computador", "Instalación de drivers");
                    else EstablecerOpciones("Disk formatting", "interface design", "Computer assembly", "Driver Installation");
                    respuestaCorrecta = idiEspañol ? "Armado del computador" : "Computer assembly";
                }
                else if (numeroPregunta == 5) {
                	picComponente.Image = (Bitmap)ProyectoPE.Resource.ResourceManager.GetObject("proce");
                    lblPregunta.Text = idiEspañol ? "¿Qué software principal coordina los recursos del hardware en tiempo real?" : "Which main software coordinates hardware resources in real time?";
                    if (idiEspañol)EstablecerOpciones("El Sistema Operativo", "El Navegador Web ", "El Compilador", "El Antivirus");
                    else EstablecerOpciones("The Operating System", "The Web Browser", "The Compiler", "The Antivirus ");
                    respuestaCorrecta = idiEspañol ? "El Sistema Operativo" : "The Operating System";
                }
                else if (numeroPregunta == 6) {
                	picComponente.Image = (Bitmap)ProyectoPE.Resource.ResourceManager.GetObject("proce");
                    lblPregunta.Text = idiEspañol ? "¿Cuál es un ejemplo de mantenimiento preventivo de software?" : "What is an example of software preventive maintenance?";
                    if (idiEspañol)EstablecerOpciones("Soldar un componente", "Cambiar la pantalla", "Reparar un cable roto", "Limpiar archivos temporales");
                    else EstablecerOpciones("Solder a component", "Change the screen", "Repair a broken cable", "Clean temporary files");
                    respuestaCorrecta = idiEspañol ? "Limpiar archivos temporales" : "Clean temporary files";
                }
                else if (numeroPregunta == 7) {
                	picComponente.Image = (Bitmap)ProyectoPE.Resource.ResourceManager.GetObject("proce");
                    lblPregunta.Text = idiEspañol ? "¿Cuándo se aplica el mantenimiento correctivo en el hardware?" : "When is corrective maintenance applied to hardware?";
                    if (idiEspañol)EstablecerOpciones("Antes de que el equipo falle", "Cuando un componente ya está dañado o falla", "Al momento de comprar la PC", "Durante el diseño del software");
                    else EstablecerOpciones("Before the equipment fails", "When a component is already damaged or fails", "At the time of buying the PC", "During software design");
                    respuestaCorrecta = idiEspañol ? "Cuando un componente ya está dañado o falla" : "When a component is already damaged or fails";
                }
                else if (numeroPregunta == 8) {
                	picComponente.Image = (Bitmap)ProyectoPE.Resource.ResourceManager.GetObject("proce");
                    lblPregunta.Text = idiEspañol ? "¿Qué documento se redacta para reportar el estado de una reparación técnica?" : "Which document is written to report the status of a technical repair?";
                    if (idiEspañol)EstablecerOpciones("Informe técnico de reporte", "Código fuente", "Mapa mental", "Ensayo de opinión");
                    else EstablecerOpciones("Technical status report", "Source code", "mind map", "Opinion essay");
                    respuestaCorrecta = idiEspañol ? "Informe técnico de reporte" : "Technical status report";
                }
                else if (numeroPregunta == 9) {
                	picComponente.Image = (Bitmap)ProyectoPE.Resource.ResourceManager.GetObject("proce");
                    lblPregunta.Text = idiEspañol ? "¿Qué debes revisar en el hardware antes de instalar un sistema operativo?" : "What must you check on the hardware before installing an operating system?";
                    if (idiEspañol)EstablecerOpciones("El color del case", "El precio del mouse", "Los requisitos mínimos", "La marca del teclado");
                    else EstablecerOpciones("The case color", "The mouse price", "The minimum requirements", "The keyboard brand");
                    respuestaCorrecta = idiEspañol ? "Los requisitos mínimos" : "The minimum requirements";
                }
                else {
                	picComponente.Image = (Bitmap)ProyectoPE.Resource.ResourceManager.GetObject("ssd");
                    lblPregunta.Text = idiEspañol ? "¿Qué significa SSD?" : "What does SSD stand for?";
                    if (idiEspañol)EstablecerOpciones("Disco Sólido", "Súper Disco", "Sistema Dual", "Sin Datos");
                    else EstablecerOpciones("Solid State Drive", "Super Disk", "Dual System", "No Data");
                    respuestaCorrecta = idiEspañol ? "Disco Sólido" : "Solid State Drive";
                }
            }
            // CÁLCULO 
            else if (modulo == "Cálculo")
            {
                picComponente.Image = (Bitmap)ProyectoPE.Resource.ResourceManager.GetObject("Calculo");
                if (numeroPregunta == 1) {
                    lblPregunta.Text = idiEspañol ? "¿Valor de x en: 2x - 4 = 10?" : "Value of x in: 2x - 4 = 10?";
                    EstablecerOpciones("7", "14", "5", "3");
                    respuestaCorrecta = "7";
                }
                
                else if (numeroPregunta == 2) {
                	picComponente.Image = (Bitmap)ProyectoPE.Resource.ResourceManager.GetObject("Calculo");
                    lblPregunta.Text = idiEspañol ? "Cuál es el valor del limite:" : "What is the value of the limit:";
                    if(idiEspañol)EstablecerOpciones("no existe", "0", "4", "2");
                    else EstablecerOpciones("Don't exist", "0","4","2");
                    respuestaCorrecta = "4";
                }
                else if (numeroPregunta == 3) {
                	picComponente.Image = (Bitmap)ProyectoPE.Resource.ResourceManager.GetObject("Calculo");
                    lblPregunta.Text = idiEspañol ? "¿Qué teorema se usa para hallar la distancia entre dos puntos?" : "Which theorem is used to find the distance between two points?";
                    if(idiEspañol)EstablecerOpciones("pitágoras", "tales", "regla de tres", "ley de ohm");
                    else EstablecerOpciones("pitágoras","tales","rule of three","law of ohm");
                    respuestaCorrecta = idiEspañol ? "pitágoras":"pitágoras";
                }
                else if (numeroPregunta == 4) {
                	picComponente.Image = (Bitmap)ProyectoPE.Resource.ResourceManager.GetObject("Calculo");
                    lblPregunta.Text = idiEspañol ? "¿Cómo son las pendientes de dos rectas paralelas?" : "How are the slopes of two parallel lines?";
                    if(idiEspañol)EstablecerOpciones("signo contrario", "inversas", "iguales", "diferentes");
                    else EstablecerOpciones("opposite sign","inverses","equal","different");
                    respuestaCorrecta = idiEspañol ? "iguales": "equal";
                }
                else if (numeroPregunta == 5) {
                	picComponente.Image = (Bitmap)ProyectoPE.Resource.ResourceManager.GetObject("Calculo");
                    lblPregunta.Text = idiEspañol ? "¿Qué tipo de rectas se cortan formando un ángulo de 90 grados?" : "What type of lines intersect forming a 90-degree angle?";
                    if(idiEspañol)EstablecerOpciones("perpendiculares", "oblicuas", "curvas", "paralelas");
                    else EstablecerOpciones("perpendicular","oblique","curves","parallels");
                    respuestaCorrecta = idiEspañol ? "perpendiculares":"perpendicular";
                }
                else if (numeroPregunta == 6) {
                	picComponente.Image = (Bitmap)ProyectoPE.Resource.ResourceManager.GetObject("Calculo");
                    lblPregunta.Text = idiEspañol ? "¿Qué software matemático se usa para evaluar las asíntotas y límites?" : "Which mathematical software did you use to evaluate asymptotes and limits?";
                    EstablecerOpciones("symbolab", "geogebra", "sublime text", "sharpdevelop");
                    respuestaCorrecta = "geogebra";
                }
                else if (numeroPregunta == 7) {
                	picComponente.Image = (Bitmap)ProyectoPE.Resource.ResourceManager.GetObject("Calculo");
                    lblPregunta.Text = idiEspañol ? "¿Cómo se llama una función que no tiene saltos ni interrupciones en su gráfica?" : "What is a function with no jumps or interruptions in its graph called?";
                    if(idiEspañol)EstablecerOpciones("inversa", "discontinua", "continua", "cuadrática");
                    else EstablecerOpciones("inverse","discontinuous","continuous","quadratic");
                    respuestaCorrecta = idiEspañol ? "continua": "";
                }
                else if (numeroPregunta == 8) {
                	picComponente.Image = (Bitmap)ProyectoPE.Resource.ResourceManager.GetObject("Calculo");
                    lblPregunta.Text = idiEspañol ? "¿Cuál es la derivada de x al cuadrado?" : "What is the derivative of x squared?";
                    EstablecerOpciones("2x", "25", "2(2)", "x");
                    respuestaCorrecta = "2x";
                }
                else if (numeroPregunta == 9) {
                	picComponente.Image = (Bitmap)ProyectoPE.Resource.ResourceManager.GetObject("Calculo");
                    lblPregunta.Text = idiEspañol ? "La derivada representa la pendiente de la recta..." : "The derivative represents the slope of the line...";
                    if(idiEspañol)EstablecerOpciones("Horizontal", "Vertical", "Oblicua", "Tangente");
                    else EstablecerOpciones("Horizontal","Vertical","oblique","Tangent");
                    respuestaCorrecta = idiEspañol ? "Tangente":"Tangent";
                }
                else {
                	picComponente.Image = (Bitmap)ProyectoPE.Resource.ResourceManager.GetObject("Calculo");
                    lblPregunta.Text = idiEspañol ? "Cuál es el dominio de la función:" : "What is the domain of the function:";
                    if(idiEspañol)EstablecerOpciones("x>3", "Todos los reales", "x≠3", "x≠0");
                    else EstablecerOpciones("x>3","all the real ones","x≠3","x≠0");
                    respuestaCorrecta = "x≠3";
                }
            }
            // ANTROPOLOGÍA 
            else if (modulo == "Antropología Filosófica")
            {
                picComponente.Image = (Bitmap)ProyectoPE.Resource.ResourceManager.GetObject("Antropologia");
                if (numeroPregunta == 1) {
                    lblPregunta.Text = idiEspañol ? "¿Qué estudia la antropología filosófica?" : "What does philosophical anthropology study?";
                    if (idiEspañol) EstablecerOpciones("Esencia humana", "La Tierra", "Animales", "Filosofía");
                    else EstablecerOpciones("Human essence", "The earth", "Animals", "philosophy");
                    respuestaCorrecta = idiEspañol ? "Esencia humana" : "Human essence";
                }
                else if (numeroPregunta == 2) {
                	picComponente.Image = (Bitmap)ProyectoPE.Resource.ResourceManager.GetObject("rojo");
                    lblPregunta.Text = idiEspañol ? "¿Cuáles son las dos vertientes principales que estudia la antropología?" : "What are the two main branches that anthropology studies?";
                    if(idiEspañol)EstablecerOpciones("La física y la química  ", "La biología y la cultura", "La política y la economía", "La matemática y la lógica");
                    else EstablecerOpciones(") Physics and chemistry", "Biology and culture", "Politics and economics", "Mathematics and logic");
                    respuestaCorrecta = idiEspañol ? "La biología y la cultura" : "Biology and culture";
                }
                else if (numeroPregunta == 3) {
                	picComponente.Image = (Bitmap)ProyectoPE.Resource.ResourceManager.GetObject("rojo");
                    lblPregunta.Text = idiEspañol ? "¿Cuál es una característica tradicional de la comunidad gitana?" : "What is a traditional characteristic of the Gypsy community?";
                    if(idiEspañol)EstablecerOpciones("La vida sin familia", "No tener idioma propio", "El nomadismo histórico", "El uso de computadoras");
                    else EstablecerOpciones("Life without family", "Having no language of their own", "Historical nomadism", "The use of computers");
                    respuestaCorrecta = idiEspañol ? "El nomadismo histórico" : "Historical nomadism";
                }
                else if (numeroPregunta == 4) {
                	picComponente.Image = (Bitmap)ProyectoPE.Resource.ResourceManager.GetObject("rojo");
                    lblPregunta.Text = idiEspañol ? "¿Cómo se llama el método para observar a un grupo en su vida real?" : "What is the method of observing a group in their real life called?";
                    if(idiEspañol)EstablecerOpciones("Algoritmia", "Estadística", "Etnografía", "Filosofía");
                    else EstablecerOpciones("Algorithmics", "Statistics", "Ethnography", "Philosophy");
                    respuestaCorrecta = idiEspañol ? "Etnografía" : "Ethnography";
                }
                else if (numeroPregunta == 5) {
                	picComponente.Image = (Bitmap)ProyectoPE.Resource.ResourceManager.GetObject("rojo");
                    lblPregunta.Text = idiEspañol ? "¿Qué término se refiere a la evolución física y biológica del hombre?" : "Which term refers to the physical and biological evolution of man?";
                    if(idiEspañol)EstablecerOpciones("Humanización", "Hominización", "Programación", "Globalización");
                    else EstablecerOpciones("Humanization", "Hominization", "Programming", "Globalization");
                    respuestaCorrecta = idiEspañol ? "Hominización" : "Humanization";
                }
                else if (numeroPregunta == 6) {
                	picComponente.Image = (Bitmap)ProyectoPE.Resource.ResourceManager.GetObject("rojo");
                    lblPregunta.Text = idiEspañol ? "¿Qué área estudia el impacto de la tecnología en el comportamiento humano?" : "What area studies the impact of technology on human behavior?";
                    if(idiEspañol)EstablecerOpciones("Antropología Política", "Geometría Analítica", "Ingeniería de Software", "Tecno-antropología");
                    else EstablecerOpciones("Political Anthropology", "Analytical Geometry", "Software Engineering", "Techno-anthropology");
                    respuestaCorrecta = idiEspañol ? "Tecno-antropología" : "Techno-anthropology";
                }
                else if (numeroPregunta == 7) {
                	picComponente.Image = (Bitmap)ProyectoPE.Resource.ResourceManager.GetObject("rojo");
                    lblPregunta.Text = idiEspañol ? "¿qué característica se usa para diferenciar al ser humano de otros seres vivos del planeta?" : "What characteristic is used to differentiate human beings from other living beings on the planet?";
                    if(idiEspañol)EstablecerOpciones("La capacidad de moverse de un lugar a otro", "La capacidad de razonar, pensar lógicamente y reflexionar", "La necesidad biológica de dormir y descansar", "El instinto básico de supervivencia");
                    else EstablecerOpciones("The ability to move from one place to", "The ability to reason, think logically and reflect", "The biological need to sleep and rest", "The basic instinct for survival");
                    respuestaCorrecta = idiEspañol ? "La capacidad de razonar, pensar lógicamente y reflexionar" : "The ability to reason, think logically and reflect";
                }
                else if (numeroPregunta == 8) {
                	picComponente.Image = (Bitmap)ProyectoPE.Resource.ResourceManager.GetObject("rojo");
                    lblPregunta.Text = idiEspañol ? "En la película Coco ¿Cuándo ocurre la verdadera 'muerte final' o desaparición absoluta de un ser humano?" : "In the movie Coco, when does the true 'final death' or absolute disappearance of a human being occur?";
                    if(idiEspañol)EstablecerOpciones("Cuando el corazón deja de latir en el mundo físico", "Cuando el cuerpo es enterrado en el cementerio", "Cuando la persona en el mundo de los vivos te olvida por completo", "Cuando se rompe tu guitarra favorita");
                    else EstablecerOpciones("When the heart stops beating in the physical world", "When the body is buried in the cemetery", "When the person in the world of the living forgets you completely", "When your favorite guitar breaks");
                    respuestaCorrecta = idiEspañol ? "Cuando la persona en el mundo de los vivos te olvida por completo" : "When the person in the world of the living forgets you completely";
                }
                else if (numeroPregunta == 9) {
                	picComponente.Image = (Bitmap)ProyectoPE.Resource.ResourceManager.GetObject("rojo");
                    lblPregunta.Text = idiEspañol ? "¿Qué significado tenía el color rojo en la pelicula 'La Aldea'?" : "What was the significance of the color red in the film 'The Village'?";
                    if(idiEspañol)EstablecerOpciones("Peligro", "Protección", "Libertad", "Tristeza");
                    else EstablecerOpciones("Danger", "Protection", "Freedom", "Sadness");
                    respuestaCorrecta = idiEspañol ? "Peligro" : "Danger";
                }
                else {
                	picComponente.Image = (Bitmap)ProyectoPE.Resource.ResourceManager.GetObject("social");
                    lblPregunta.Text = idiEspañol ? "¿El hombre es un ser social por naturaleza?" : "Is man a social being by nature?";
                    if(idiEspañol)EstablecerOpciones("Sí", "No", "Tal vez", "Solo en fiestas");
                    else EstablecerOpciones("Yes", "No", "Maybe", "Only at parties");
                    respuestaCorrecta = idiEspañol ? "Sí" : "Yes";
                }
            }
            // EDUCACIÓN FÍSICA 
            else if (modulo == "Educación Física")
            {
                picComponente.Image = (Bitmap)ProyectoPE.Resource.ResourceManager.GetObject("EducacionF");
                if (numeroPregunta == 1) {
                    lblPregunta.Text = idiEspañol ? "¿En qué deporte se utiliza el término 'home run'?" : "In which sport is the term 'home run' used?";
                    if (idiEspañol)EstablecerOpciones("Fútbol", "Béisbol", "Golf", "Tenis");
                    else EstablecerOpciones("Soccer", "Baseball", "Golf", "Tennis");
                    respuestaCorrecta = idiEspañol ? "Béisbol" : "Baseball";
                }
                else if (numeroPregunta == 2) {
                	picComponente.Image = (Bitmap)ProyectoPE.Resource.ResourceManager.GetObject("time");
                    lblPregunta.Text = idiEspañol ? "¿Cuántos minutos dura un tiempo de fútbol?" : "How many minutes in a soccer half?";
                    if (idiEspañol)EstablecerOpciones("30", "45", "60", "90");
                    else EstablecerOpciones("30", "45", "60", "90");
                    respuestaCorrecta = idiEspañol ? "45" : "45";
                }
                else if (numeroPregunta == 3) {
                	picComponente.Image = (Bitmap)ProyectoPE.Resource.ResourceManager.GetObject("time");
                    lblPregunta.Text = idiEspañol ? "¿Cuál es el beneficio principal de la actividad física en la universidad?" : "What is the main benefit of physical activity at the university?";
                    if (idiEspañol)EstablecerOpciones("Reducir el estrés académico", "Ganar más dinero", "Tener mas fuerza", "Aprender a Jugar");
                    else EstablecerOpciones("Reduce academic stress", "Earn more money", "Have more strength", "Learn to Play");
                    respuestaCorrecta = idiEspañol ? "Reducir el estrés académico" : "Reduce academic stress";
                }
                else if (numeroPregunta == 4) {
                	picComponente.Image = (Bitmap)ProyectoPE.Resource.ResourceManager.GetObject("time");
                    lblPregunta.Text = idiEspañol ? "¿Qué son los primeros auxilios?" : "What is first aid?";
                    if (idiEspañol)EstablecerOpciones("La atención médica avanzada", "La ayuda inmediata en una emergencia", "Un deporte de equipo", "Una rutina de gimnasio");
                    else EstablecerOpciones("Advanced medical care", "Immediate help in an emergency", "team sport", "A gym routine");
                    respuestaCorrecta = idiEspañol ? "La ayuda inmediata en una emergencia" : "Immediate help in an emergency";
                }
                else if (numeroPregunta == 5) {
                	picComponente.Image = (Bitmap)ProyectoPE.Resource.ResourceManager.GetObject("time");
                    lblPregunta.Text = idiEspañol ? "¿Cuál de los siguientes juegos es considerado oficialmente un deporte debido a su alto nivel de estrategia y torneos mundiales?" : "Which of the following games is officially considered a sport due to its high level of strategy and worldwide tournaments?";
                    if (idiEspañol)EstablecerOpciones("Cartas", "Dominoes", "Ludo", "Ajedrez");
                    else EstablecerOpciones("Cards", "Dominoes", "Ludo", "Chess");
                    respuestaCorrecta = idiEspañol ? "Ajedrez" : "Chess";
                }
                else if (numeroPregunta == 6) {
                	picComponente.Image = (Bitmap)ProyectoPE.Resource.ResourceManager.GetObject("time");
                    lblPregunta.Text = idiEspañol ? "¿Cada cuántos años se organiza la famosa Copa Mundial de la FIFA?" : "How many years is the famous FIFA World Cup organized?";
                    if (idiEspañol)EstablecerOpciones("4", "5", "2", "3");
                    else EstablecerOpciones("4", "5", "2", "3");
                    respuestaCorrecta = idiEspañol ? "4" : "4";
                }
                else if (numeroPregunta == 7) {
                	picComponente.Image = (Bitmap)ProyectoPE.Resource.ResourceManager.GetObject("time");
                    lblPregunta.Text = idiEspañol ? "¿cuál es el objeto que los nadadores obligatoriamente deben tocar al final de la piscina para registrar su tiempo de llegada?" : "What is the object that swimmers must touch at the end of the pool to record their arrival time?";
                    if (idiEspañol)EstablecerOpciones("La mano del árbitro", "Una bandera de tela", "Una cuerda de seguridad", "panel táctil electrónico");
                    else EstablecerOpciones("The referee's hand", "A cloth flag", "A safety rope", "An electronic touch plate or pad");
                    respuestaCorrecta = idiEspañol ? "panel táctil electrónico" : "An electronic touch plate";
                }
                else if (numeroPregunta == 8) {
                	picComponente.Image = (Bitmap)ProyectoPE.Resource.ResourceManager.GetObject("time");
                    lblPregunta.Text = idiEspañol ? "¿Cómo se llama la legendaria carrera de atletismo de larga distancia que mide un poco más de 42 kilómetros en total?" : "What is the name of the legendary long-distance track and field race that measures just over 42 kilometers in total?";
                    if (idiEspañol)EstablecerOpciones("Carrera de 100 metros", "Maratón", "Relevo de velocidad", "Salto alto");
                    else EstablecerOpciones("100-meter sprint", "Marathon", "Speed relay", "High jump");
                    respuestaCorrecta = idiEspañol ? "Maratón" : "Marathon";
                }
                else if (numeroPregunta == 9) {
                	picComponente.Image = (Bitmap)ProyectoPE.Resource.ResourceManager.GetObject("time");
                    lblPregunta.Text = idiEspañol ? "¿En qué liga de baloncesto profesional juega Lebron James?" : "What professional basketball league does Lebron James play in?";
                    if (idiEspañol)EstablecerOpciones("NBA", "MLB", "LVBP", "SBP");
                    else EstablecerOpciones("NBA", "MLB", "LVBP", "SBP");
                    respuestaCorrecta = idiEspañol ? "NBA" : "NBA";
                }
                else {
                	picComponente.Image = (Bitmap)ProyectoPE.Resource.ResourceManager.GetObject("tarjeta");
                    lblPregunta.Text = idiEspañol ? "¿Qué hace un jugador para ser expulsado en fútbol?" : "What does a player do to get sent off in football?";
                    if (idiEspañol)EstablecerOpciones("Entrada peligrosa", "Empujon leve", "Gritar a un compañero", "Cometer una falta táctica");
                    else EstablecerOpciones("Dangerous tackle", "Minor push", "Shouting at a teammate", "Committing a tactical foul");
                    respuestaCorrecta = idiEspañol ? "Entrada peligrosa":"Dangerous tackle";
                }
            }
        }

        void ValidarRespuesta(string opcionSeleccionada)
        {
            bool esCorrecto = (opcionSeleccionada == respuestaCorrecta);
            string mensaje;
            string titulo;

            if (esCorrecto)
            {
                Objetos.PuntuacionActual += 10;
                mensaje = Objetos.idiEspañol ? "¡Correcto! +10 puntos." : "Correct! +10 points.";
                titulo = Objetos.idiEspañol ? "Felicidades" : "Congratulations";
            }
            else
            {
                Objetos.PuntuacionActual = Math.Max(0, Objetos.PuntuacionActual - 5);
                mensaje = Objetos.idiEspañol ? "Incorrecto -5 puntos. La respuesta era: " + respuestaCorrecta : "Incorrect -5 points. The answer was: " + respuestaCorrecta;
                titulo = Objetos.idiEspañol ? "Lo siento" : "Sorry";
            }

            MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, 
                            esCorrecto ? MessageBoxIcon.Information : MessageBoxIcon.Error);
           
            if (numeroPregunta < MAX_PREGUNTAS)
            {
                
                numeroPregunta++; 
                CargarPregunta();
            }
            else
            {
            	GuardarPuntuacionEnBD();
                string finMsg = Objetos.idiEspañol ? "Módulo finalizado." : "Module finished.";
                MessageBox.Show(finMsg);
                RegresarAlMenuDirecto();
            }
        }

        void RegresarAlMenuDirecto()
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f is FormMenu) { f.Show(); break; }
            }
            this.Close();
        }

        void EstablecerOpciones(string op1, string op2, string op3, string op4)
        {
            btnOp1.Text = op1;
            btnOp2.Text = op2;
            btnOp3.Text = op3;
            btnOp4.Text = op4;
        }

        void BtnVolverClick(object sender, EventArgs e)
        {
            string pregunta = Objetos.idiEspañol ? "¿Estas seguro de volver?, no se guardará tu puntuación actual." : "Are you sure to come back? Your current score will not be saved";
            string respuesta = Objetos.idiEspañol ? "Salida" : "Leave";
            if (MessageBox.Show(pregunta, respuesta , MessageBoxButtons.YesNo) == DialogResult.Yes) RegresarAlMenuDirecto();
        }

        void BtnIdiomaClick(object sender, EventArgs e)
        {
            Objetos.idiEspañol = !Objetos.idiEspañol;
            btnIdioma.Text = Objetos.idiEspañol ? "Change to English" : "Cambiar a Español";
            CargarPregunta();
        }

        void BtnOp1Click(object sender, EventArgs e) { ValidarRespuesta(btnOp1.Text); }
        void BtnOp2Click(object sender, EventArgs e) { ValidarRespuesta(btnOp2.Text); }
        void BtnOp3Click(object sender, EventArgs e) { ValidarRespuesta(btnOp3.Text); }
        void BtnOp4Click(object sender, EventArgs e) { ValidarRespuesta(btnOp4.Text); }
        
        void GuardarPuntuacionEnBD()
        {
            // Asumo que tienes el nombre del usuario guardado de forma global (ej: Objetos.UsuarioActual)
            // Si no es así, puedes sustituirlo por una cadena fija o una variable existente.
            
			string usuario = !string.IsNullOrEmpty(Objetos.UsuarioLogeado) ? Objetos.UsuarioLogeado : "Invitado";
            if (usuario == "Invitado") {
        return; // Si es un invitado, no intentamos actualizar nada en la base de datos
    }
			string sqlpuntj = "UPDATE usuario SET puntaje = @ptj WHERE nombre = @name";
			
            using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
            {
                try
                {
                    conexion.Open();
                    using (MySqlCommand cmd = new MySqlCommand(sqlpuntj, conexion))
                    {
                        // Se usan parámetros para evitar inyecciones SQL de forma segura
                        cmd.Parameters.AddWithValue("@ptj", Objetos.PuntuacionActual);
                        cmd.Parameters.AddWithValue("@name", usuario);
                        int filasAfectadas = cmd.ExecuteNonQuery();

                        // DIAGNÓSTICO 2: Te dirá si el nombre de usuario existe tal cual en la base de datos
                        if (filasAfectadas == 0)
                        {
                            MessageBox.Show("Error de coincidencia: El usuario '"+usuario+"' no existe exactamente con ese nombre en la base de datos.", "Diagnóstico");
                        }
                        else
                        {
                            MessageBox.Show("¡Puntuación de "+Objetos.PuntuacionActual+" pts guardada con éxito para el usuario "+usuario+"", "Éxito");
                        }

                
                    }
                }
                catch (Exception ex)
                {
                    // Alerta por si falla la conexión física con el servidor de MySQL
                    string errorMsg = Objetos.idiEspañol ? "Error al guardar la puntuación: " : "Error saving score: ";
                    MessageBox.Show(errorMsg + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
    
}

