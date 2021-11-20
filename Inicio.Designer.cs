
namespace Prototipo_P
{
    partial class Inicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnMenu = new System.Windows.Forms.Panel();
            this.panelMiCuenta = new System.Windows.Forms.Panel();
            this.subMenuMiCuenta = new System.Windows.Forms.Panel();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.btnMisDatos = new System.Windows.Forms.Button();
            this.btnMiCuenta = new System.Windows.Forms.Button();
            this.panelAcceso = new System.Windows.Forms.Panel();
            this.subMenuAcceso = new System.Windows.Forms.Panel();
            this.btnCrearCuenta = new System.Windows.Forms.Button();
            this.btnIniciarSesion = new System.Windows.Forms.Button();
            this.btnAcceso = new System.Windows.Forms.Button();
            this.panelimagen = new System.Windows.Forms.Panel();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.pnMenu.SuspendLayout();
            this.panelMiCuenta.SuspendLayout();
            this.subMenuMiCuenta.SuspendLayout();
            this.panelAcceso.SuspendLayout();
            this.subMenuAcceso.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(774, 45);
            this.panel1.TabIndex = 0;
            // 
            // pnMenu
            // 
            this.pnMenu.AutoScroll = true;
            this.pnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
            this.pnMenu.Controls.Add(this.panelMiCuenta);
            this.pnMenu.Controls.Add(this.panelAcceso);
            this.pnMenu.Controls.Add(this.panelimagen);
            this.pnMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnMenu.Location = new System.Drawing.Point(0, 45);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Size = new System.Drawing.Size(192, 466);
            this.pnMenu.TabIndex = 1;
            // 
            // panelMiCuenta
            // 
            this.panelMiCuenta.Controls.Add(this.subMenuMiCuenta);
            this.panelMiCuenta.Controls.Add(this.btnMiCuenta);
            this.panelMiCuenta.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMiCuenta.Location = new System.Drawing.Point(0, 237);
            this.panelMiCuenta.Name = "panelMiCuenta";
            this.panelMiCuenta.Size = new System.Drawing.Size(192, 137);
            this.panelMiCuenta.TabIndex = 2;
            // 
            // subMenuMiCuenta
            // 
            this.subMenuMiCuenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.subMenuMiCuenta.Controls.Add(this.btnCerrarSesion);
            this.subMenuMiCuenta.Controls.Add(this.btnMisDatos);
            this.subMenuMiCuenta.Dock = System.Windows.Forms.DockStyle.Top;
            this.subMenuMiCuenta.Location = new System.Drawing.Point(0, 40);
            this.subMenuMiCuenta.Name = "subMenuMiCuenta";
            this.subMenuMiCuenta.Size = new System.Drawing.Size(192, 89);
            this.subMenuMiCuenta.TabIndex = 1;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.btnCerrarSesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCerrarSesion.Location = new System.Drawing.Point(0, 40);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(192, 40);
            this.btnCerrarSesion.TabIndex = 1;
            this.btnCerrarSesion.Text = "Cerrar Sesión";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // btnMisDatos
            // 
            this.btnMisDatos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMisDatos.FlatAppearance.BorderSize = 0;
            this.btnMisDatos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnMisDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMisDatos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMisDatos.Location = new System.Drawing.Point(0, 0);
            this.btnMisDatos.Name = "btnMisDatos";
            this.btnMisDatos.Size = new System.Drawing.Size(192, 40);
            this.btnMisDatos.TabIndex = 0;
            this.btnMisDatos.Text = "Mis Datos";
            this.btnMisDatos.UseVisualStyleBackColor = true;
            this.btnMisDatos.Click += new System.EventHandler(this.btnMisDatos_Click);
            // 
            // btnMiCuenta
            // 
            this.btnMiCuenta.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMiCuenta.FlatAppearance.BorderSize = 0;
            this.btnMiCuenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnMiCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMiCuenta.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMiCuenta.Location = new System.Drawing.Point(0, 0);
            this.btnMiCuenta.Name = "btnMiCuenta";
            this.btnMiCuenta.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnMiCuenta.Size = new System.Drawing.Size(192, 40);
            this.btnMiCuenta.TabIndex = 0;
            this.btnMiCuenta.Text = "Mi Cuenta";
            this.btnMiCuenta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMiCuenta.UseVisualStyleBackColor = true;
            this.btnMiCuenta.Click += new System.EventHandler(this.btnMiCuenta_Click);
            // 
            // panelAcceso
            // 
            this.panelAcceso.Controls.Add(this.subMenuAcceso);
            this.panelAcceso.Controls.Add(this.btnAcceso);
            this.panelAcceso.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAcceso.Location = new System.Drawing.Point(0, 100);
            this.panelAcceso.Name = "panelAcceso";
            this.panelAcceso.Size = new System.Drawing.Size(192, 137);
            this.panelAcceso.TabIndex = 1;
            // 
            // subMenuAcceso
            // 
            this.subMenuAcceso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.subMenuAcceso.Controls.Add(this.btnCrearCuenta);
            this.subMenuAcceso.Controls.Add(this.btnIniciarSesion);
            this.subMenuAcceso.Dock = System.Windows.Forms.DockStyle.Top;
            this.subMenuAcceso.Location = new System.Drawing.Point(0, 40);
            this.subMenuAcceso.Name = "subMenuAcceso";
            this.subMenuAcceso.Size = new System.Drawing.Size(192, 89);
            this.subMenuAcceso.TabIndex = 1;
            // 
            // btnCrearCuenta
            // 
            this.btnCrearCuenta.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCrearCuenta.FlatAppearance.BorderSize = 0;
            this.btnCrearCuenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnCrearCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearCuenta.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCrearCuenta.Location = new System.Drawing.Point(0, 40);
            this.btnCrearCuenta.Name = "btnCrearCuenta";
            this.btnCrearCuenta.Size = new System.Drawing.Size(192, 40);
            this.btnCrearCuenta.TabIndex = 1;
            this.btnCrearCuenta.Text = "Crear Cuenta";
            this.btnCrearCuenta.UseVisualStyleBackColor = true;
            this.btnCrearCuenta.Click += new System.EventHandler(this.btnCrearCuenta_Click);
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnIniciarSesion.FlatAppearance.BorderSize = 0;
            this.btnIniciarSesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnIniciarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciarSesion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnIniciarSesion.Location = new System.Drawing.Point(0, 0);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Size = new System.Drawing.Size(192, 40);
            this.btnIniciarSesion.TabIndex = 0;
            this.btnIniciarSesion.Text = "Iniciar Sesión";
            this.btnIniciarSesion.UseVisualStyleBackColor = true;
            this.btnIniciarSesion.Click += new System.EventHandler(this.btnIniciarSesion_Click);
            // 
            // btnAcceso
            // 
            this.btnAcceso.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAcceso.FlatAppearance.BorderSize = 0;
            this.btnAcceso.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnAcceso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcceso.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAcceso.Location = new System.Drawing.Point(0, 0);
            this.btnAcceso.Name = "btnAcceso";
            this.btnAcceso.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnAcceso.Size = new System.Drawing.Size(192, 40);
            this.btnAcceso.TabIndex = 0;
            this.btnAcceso.Text = "Acceso";
            this.btnAcceso.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAcceso.UseVisualStyleBackColor = true;
            this.btnAcceso.Click += new System.EventHandler(this.btnAcceso_Click);
            // 
            // panelimagen
            // 
            this.panelimagen.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelimagen.Location = new System.Drawing.Point(0, 0);
            this.panelimagen.Name = "panelimagen";
            this.panelimagen.Size = new System.Drawing.Size(192, 100);
            this.panelimagen.TabIndex = 0;
            // 
            // panelContenedor
            // 
            this.panelContenedor.AutoScroll = true;
            this.panelContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(192, 45);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(582, 466);
            this.panelContenedor.TabIndex = 2;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(774, 511);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.pnMenu);
            this.Controls.Add(this.panel1);
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.pnMenu.ResumeLayout(false);
            this.panelMiCuenta.ResumeLayout(false);
            this.subMenuMiCuenta.ResumeLayout(false);
            this.panelAcceso.ResumeLayout(false);
            this.subMenuAcceso.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnMenu;
        private System.Windows.Forms.Panel panelimagen;
        private System.Windows.Forms.Panel subMenuAcceso;
        private System.Windows.Forms.Button btnCrearCuenta;
        private System.Windows.Forms.Button btnIniciarSesion;
        private System.Windows.Forms.Button btnAcceso;
        private System.Windows.Forms.Panel subMenuMiCuenta;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Button btnMisDatos;
        private System.Windows.Forms.Button btnMiCuenta;
        public System.Windows.Forms.Panel panelContenedor;
        public System.Windows.Forms.Panel panelAcceso;
        public System.Windows.Forms.Panel panelMiCuenta;
    }
}

