using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoPE
{
	
	public partial class FormPreguntas : Form
	{
		string modulo;
        string respuestaCorrecta = "";

        public FormPreguntas(string moduloSeleccionado)
        {
            InitializeComponent();
            this.modulo = moduloSeleccionado;
          	CargarPregunta();
        }
       
        void CargarPregunta()
        {
        	picComponente.Visible = true;
    		picComponente.SizeMode = PictureBoxSizeMode.Zoom;
            if (modulo == "Arquitectura y Estructura del Computador")
            {
                picComponente.Image = (Bitmap)ProyectoPE.Resource.ResourceManager.GetObject("Arquitectura");
                lblPregunta.Text = "¿Qué sucede con la información almacenada en la memoria RAM cuando se apaga la computadora?";
                EstablecerOpciones("Se comprime para ahorrar espacio", "Se borra", "Se mueve automáticamente al disco duro", "Se guarda permanentemente en el chip");
                respuestaCorrecta = "CPU";
            }
            else if (modulo == "Cálculo")
            {
            	picComponente.Image = (Bitmap)ProyectoPE.Resource.ResourceManager.GetObject("Calculo");
                lblPregunta.Text = "¿Cuál es el valor de x en la ecuación: 2x - 4 = 10?";
                EstablecerOpciones("7", "14", "5", "3");
                respuestaCorrecta = "7";
            }
            else if (modulo == "Antropología Filosófica")
            {
				picComponente.Image = (Bitmap)ProyectoPE.Resource.ResourceManager.GetObject("Antropologia");
		        lblPregunta.Text = "¿Cuál es el objetivo central del estudio de la antropología filosófica?";
		            EstablecerOpciones("La esencia y el sentido del ser humano", "Las estructuras sociales de las tribus antiguas", "La evolución biológica de los homínidos", "El funcionamiento físico del cerebro");
		            respuestaCorrecta = "La esencia y el sentido del ser humano";
            }
            else if (modulo == "Educación Física")
            {
            	picComponente.Image = (Bitmap)ProyectoPE.Resource.ResourceManager.GetObject("EducacionF");
                lblPregunta.Text ="¿En qué deporte se utiliza el término 'Home Run'?";
                EstablecerOpciones("Fútbol", "Baloncesto", "Béisbol", "Golf");
                respuestaCorrecta = "Béisbol";
            }
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
            DialogResult dialogResult = MessageBox.Show(
			"¿Seguro que deseas volver?", 
			"Advertencia", 
			MessageBoxButtons.YesNo, 
			MessageBoxIcon.Question
			);
			if (dialogResult == DialogResult.Yes)
			{
				foreach (Form f in Application.OpenForms)
				{
					if (f is FormMenu)
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

