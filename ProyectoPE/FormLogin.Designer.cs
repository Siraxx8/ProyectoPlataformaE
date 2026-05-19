/*
 * Creado por SharpDevelop.
 * Usuario: Sira
 * Fecha: 18/4/2026
 * Hora: 10:29 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace ProyectoPE
{
	partial class FormLogin
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
			this.lblsesion = new System.Windows.Forms.Label();
			this.textUserLogin = new System.Windows.Forms.TextBox();
			this.textPassLogin = new System.Windows.Forms.TextBox();
			this.lblusu = new System.Windows.Forms.Label();
			this.lblcontra = new System.Windows.Forms.Label();
			this.BtnIniciar = new System.Windows.Forms.Button();
			this.BtnVolver = new System.Windows.Forms.Button();
			this.ChkVerContra = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// lblsesion
			// 
			this.lblsesion.BackColor = System.Drawing.Color.Transparent;
			this.lblsesion.Font = new System.Drawing.Font("Haettenschweiler", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblsesion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lblsesion.Location = new System.Drawing.Point(35, 18);
			this.lblsesion.Name = "lblsesion";
			this.lblsesion.Size = new System.Drawing.Size(317, 61);
			this.lblsesion.TabIndex = 0;
			this.lblsesion.Text = "Inicio de Sesión";
			// 
			// textUserLogin
			// 
			this.textUserLogin.Location = new System.Drawing.Point(35, 147);
			this.textUserLogin.MaxLength = 50;
			this.textUserLogin.Name = "textUserLogin";
			this.textUserLogin.Size = new System.Drawing.Size(149, 20);
			this.textUserLogin.TabIndex = 1;
			// 
			// textPassLogin
			// 
			this.textPassLogin.Location = new System.Drawing.Point(35, 223);
			this.textPassLogin.MaxLength = 50;
			this.textPassLogin.Name = "textPassLogin";
			this.textPassLogin.PasswordChar = '*';
			this.textPassLogin.Size = new System.Drawing.Size(149, 20);
			this.textPassLogin.TabIndex = 2;
			// 
			// lblusu
			// 
			this.lblusu.BackColor = System.Drawing.Color.Transparent;
			this.lblusu.Font = new System.Drawing.Font("Haettenschweiler", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblusu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lblusu.Location = new System.Drawing.Point(35, 111);
			this.lblusu.Name = "lblusu";
			this.lblusu.Size = new System.Drawing.Size(168, 33);
			this.lblusu.TabIndex = 3;
			this.lblusu.Text = "Ingresar usuario:";
			// 
			// lblcontra
			// 
			this.lblcontra.BackColor = System.Drawing.Color.Transparent;
			this.lblcontra.Font = new System.Drawing.Font("Haettenschweiler", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblcontra.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lblcontra.Location = new System.Drawing.Point(35, 191);
			this.lblcontra.Name = "lblcontra";
			this.lblcontra.Size = new System.Drawing.Size(185, 29);
			this.lblcontra.TabIndex = 4;
			this.lblcontra.Text = "Ingresar contraseña:";
			// 
			// BtnIniciar
			// 
			this.BtnIniciar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.BtnIniciar.Font = new System.Drawing.Font("Haettenschweiler", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnIniciar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.BtnIniciar.Location = new System.Drawing.Point(34, 334);
			this.BtnIniciar.Name = "BtnIniciar";
			this.BtnIniciar.Size = new System.Drawing.Size(110, 39);
			this.BtnIniciar.TabIndex = 5;
			this.BtnIniciar.Text = "Iniciar sesión";
			this.BtnIniciar.UseVisualStyleBackColor = false;
			this.BtnIniciar.Click += new System.EventHandler(this.BtnIniciarClick);
			// 
			// BtnVolver
			// 
			this.BtnVolver.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.BtnVolver.Font = new System.Drawing.Font("Haettenschweiler", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnVolver.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.BtnVolver.Location = new System.Drawing.Point(519, 334);
			this.BtnVolver.Name = "BtnVolver";
			this.BtnVolver.Size = new System.Drawing.Size(109, 39);
			this.BtnVolver.TabIndex = 6;
			this.BtnVolver.Text = "Volver";
			this.BtnVolver.UseVisualStyleBackColor = false;
			this.BtnVolver.Click += new System.EventHandler(this.BtnVolverClick);
			// 
			// ChkVerContra
			// 
			this.ChkVerContra.BackColor = System.Drawing.Color.Transparent;
			this.ChkVerContra.Font = new System.Drawing.Font("Heebo", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ChkVerContra.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.ChkVerContra.Location = new System.Drawing.Point(35, 264);
			this.ChkVerContra.Name = "ChkVerContra";
			this.ChkVerContra.Size = new System.Drawing.Size(185, 24);
			this.ChkVerContra.TabIndex = 7;
			this.ChkVerContra.Text = "Mostrar contraseña";
			this.ChkVerContra.UseVisualStyleBackColor = false;
			this.ChkVerContra.CheckedChanged += new System.EventHandler(this.ChkVerContraCheckedChanged);
			// 
			// FormLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(661, 423);
			this.Controls.Add(this.ChkVerContra);
			this.Controls.Add(this.BtnVolver);
			this.Controls.Add(this.BtnIniciar);
			this.Controls.Add(this.lblcontra);
			this.Controls.Add(this.lblusu);
			this.Controls.Add(this.textPassLogin);
			this.Controls.Add(this.textUserLogin);
			this.Controls.Add(this.lblsesion);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FormLogin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Login";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.CheckBox ChkVerContra;
		private System.Windows.Forms.Button BtnVolver;
		private System.Windows.Forms.Button BtnIniciar;
		private System.Windows.Forms.Label lblcontra;
		private System.Windows.Forms.Label lblusu;
		private System.Windows.Forms.TextBox textPassLogin;
		private System.Windows.Forms.TextBox textUserLogin;
		private System.Windows.Forms.Label lblsesion;
	}
}
