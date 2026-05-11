using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoPE
{
    public partial class FormPreguntas : Form
    {
        string modulo;
        string respuestaCorrecta = "";
        int numeroPregunta = 1; // Contador para las preguntas dentro del mismo módulo
        const int MAX_PREGUNTAS = 3; // Cantidad de preguntas por módulo

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
                    if (idiEspañol)EstablecerOpciones("Monitor", "CPU", "Mouse", "Teclado");
                    else EstablecerOpciones("Monitor", "CPU", "Mouse", "Keyboard");
                    respuestaCorrecta = idiEspañol ? "CPU" : "CPU";
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
                    lblPregunta.Text = idiEspañol ? "¿Cuánto es 5 * 5?" : "How much is 5 * 5?";
                    EstablecerOpciones("10", "20", "25", "30");
                    respuestaCorrecta = "25";
                }
                else {
                	picComponente.Image = (Bitmap)ProyectoPE.Resource.ResourceManager.GetObject("Calculo");
                    lblPregunta.Text = idiEspañol ? "¿Raíz cuadrada de 81?" : "Square root of 81?";
                    EstablecerOpciones("7", "8", "9", "10");
                    respuestaCorrecta = "9";
                }
            }
            // ANTROPOLOGÍA 
            else if (modulo == "Antropología Filosófica")
            {
                picComponente.Image = (Bitmap)ProyectoPE.Resource.ResourceManager.GetObject("Antropologia");
                if (numeroPregunta == 1) {
                    lblPregunta.Text = idiEspañol ? "¿Qué estudia la antropología filosófica?" : "What does philosophical anthropology study?";
                    if (idiEspañol) EstablecerOpciones("Esencia humana", "Piedras", "Animales", "Estrellas");
                    else EstablecerOpciones("Human essence", "Rocks", "Animals", "Stars");
                    respuestaCorrecta = idiEspañol ? "Esencia humana" : "Human essence";
                }
                else if (numeroPregunta == 2) {
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
                    EstablecerOpciones("30", "45", "60", "90");
                    respuestaCorrecta = "45";
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
            string pregunta = Objetos.idiEspañol ? "¿Deseas volver al menú?" : "Do you want to go back to menu?";
            if (MessageBox.Show(pregunta, "Salida", MessageBoxButtons.YesNo) == DialogResult.Yes) RegresarAlMenuDirecto();
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
    }
    
}

