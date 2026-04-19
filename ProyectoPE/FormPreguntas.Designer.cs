/*
 * Creado por SharpDevelop.
 * Usuario: Sira
 * Fecha: 18/4/2026
 * Hora: 10:30 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace ProyectoPE
{
	partial class FormPreguntas
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPreguntas));
			this.btnOp1 = new System.Windows.Forms.Button();
			this.btnOp3 = new System.Windows.Forms.Button();
			this.btnOp2 = new System.Windows.Forms.Button();
			this.btnOp4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.BtnVolver = new System.Windows.Forms.Button();
			this.lblPregunta = new System.Windows.Forms.Label();
			this.picComponente = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.picComponente)).BeginInit();
			this.SuspendLayout();
			// 
			// btnOp1
			// 
			this.btnOp1.Font = new System.Drawing.Font("Haettenschweiler", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnOp1.Location = new System.Drawing.Point(12, 84);
			this.btnOp1.Name = "btnOp1";
			this.btnOp1.Size = new System.Drawing.Size(180, 57);
			this.btnOp1.TabIndex = 0;
			this.btnOp1.Text = "Opción 1";
			this.btnOp1.UseVisualStyleBackColor = false;
			// 
			// btnOp3
			// 
			this.btnOp3.Font = new System.Drawing.Font("Haettenschweiler", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnOp3.Location = new System.Drawing.Point(12, 231);
			this.btnOp3.Name = "btnOp3";
			this.btnOp3.Size = new System.Drawing.Size(180, 57);
			this.btnOp3.TabIndex = 1;
			this.btnOp3.Text = "Opción 3";
			this.btnOp3.UseVisualStyleBackColor = true;
			// 
			// btnOp2
			// 
			this.btnOp2.Font = new System.Drawing.Font("Haettenschweiler", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnOp2.Location = new System.Drawing.Point(12, 157);
			this.btnOp2.Name = "btnOp2";
			this.btnOp2.Size = new System.Drawing.Size(180, 57);
			this.btnOp2.TabIndex = 2;
			this.btnOp2.Text = "Opción 2";
			this.btnOp2.UseVisualStyleBackColor = true;
			// 
			// btnOp4
			// 
			this.btnOp4.Font = new System.Drawing.Font("Haettenschweiler", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnOp4.Location = new System.Drawing.Point(12, 303);
			this.btnOp4.Name = "btnOp4";
			this.btnOp4.Size = new System.Drawing.Size(180, 57);
			this.btnOp4.TabIndex = 3;
			this.btnOp4.Text = "Opción 4";
			this.btnOp4.UseVisualStyleBackColor = true;
			// 
			// button5
			// 
			this.button5.Font = new System.Drawing.Font("Haettenschweiler", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button5.Location = new System.Drawing.Point(12, 406);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(109, 45);
			this.button5.TabIndex = 4;
			this.button5.Text = "Cambiar a inglés";
			this.button5.UseVisualStyleBackColor = true;
			// 
			// BtnVolver
			// 
			this.BtnVolver.Font = new System.Drawing.Font("Haettenschweiler", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnVolver.Location = new System.Drawing.Point(570, 406);
			this.BtnVolver.Name = "BtnVolver";
			this.BtnVolver.Size = new System.Drawing.Size(109, 45);
			this.BtnVolver.TabIndex = 5;
			this.BtnVolver.Text = "Volver";
			this.BtnVolver.UseVisualStyleBackColor = true;
			this.BtnVolver.Click += new System.EventHandler(this.BtnVolverClick);
			// 
			// lblPregunta
			// 
			this.lblPregunta.BackColor = System.Drawing.Color.Transparent;
			this.lblPregunta.Font = new System.Drawing.Font("Haettenschweiler", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPregunta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lblPregunta.Location = new System.Drawing.Point(12, 0);
			this.lblPregunta.Name = "lblPregunta";
			this.lblPregunta.Size = new System.Drawing.Size(678, 81);
			this.lblPregunta.TabIndex = 6;
			this.lblPregunta.Text = "Pregunta";
			this.lblPregunta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// picComponente
			// 
			this.picComponente.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.picComponente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.picComponente.Location = new System.Drawing.Point(228, 84);
			this.picComponente.Name = "picComponente";
			this.picComponente.Size = new System.Drawing.Size(442, 276);
			this.picComponente.TabIndex = 7;
			this.picComponente.TabStop = false;
			// 
			// FormPreguntas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(702, 463);
			this.Controls.Add(this.picComponente);
			this.Controls.Add(this.lblPregunta);
			this.Controls.Add(this.BtnVolver);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.btnOp4);
			this.Controls.Add(this.btnOp2);
			this.Controls.Add(this.btnOp3);
			this.Controls.Add(this.btnOp1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormPreguntas";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Preguntas";
			((System.ComponentModel.ISupportInitialize)(this.picComponente)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.PictureBox picComponente;
		private System.Windows.Forms.Label lblPregunta;
		private System.Windows.Forms.Button BtnVolver;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button btnOp4;
		private System.Windows.Forms.Button btnOp2;
		private System.Windows.Forms.Button btnOp3;
		private System.Windows.Forms.Button btnOp1;
	}
}
