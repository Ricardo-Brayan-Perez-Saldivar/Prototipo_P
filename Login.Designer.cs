
namespace Prototipo_P
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRestaConrasena = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btnAccesarLogin = new System.Windows.Forms.Button();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtNickname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TimAcceso = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(432, 146);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 28);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(432, 93);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // btnRestaConrasena
            // 
            this.btnRestaConrasena.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRestaConrasena.FlatAppearance.BorderSize = 0;
            this.btnRestaConrasena.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestaConrasena.ForeColor = System.Drawing.Color.Turquoise;
            this.btnRestaConrasena.Location = new System.Drawing.Point(86, 270);
            this.btnRestaConrasena.Margin = new System.Windows.Forms.Padding(4);
            this.btnRestaConrasena.Name = "btnRestaConrasena";
            this.btnRestaConrasena.Size = new System.Drawing.Size(208, 31);
            this.btnRestaConrasena.TabIndex = 20;
            this.btnRestaConrasena.Text = "Restaurar Contraseña";
            this.btnRestaConrasena.UseVisualStyleBackColor = true;
            this.btnRestaConrasena.Click += new System.EventHandler(this.btnRestaConrasena_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Cancelar.BackColor = System.Drawing.Color.Red;
            this.btn_Cancelar.FlatAppearance.BorderSize = 0;
            this.btn_Cancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancelar.Location = new System.Drawing.Point(175, 205);
            this.btn_Cancelar.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(133, 34);
            this.btn_Cancelar.TabIndex = 18;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = false;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btnAccesarLogin
            // 
            this.btnAccesarLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAccesarLogin.BackColor = System.Drawing.Color.YellowGreen;
            this.btnAccesarLogin.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAccesarLogin.FlatAppearance.BorderSize = 0;
            this.btnAccesarLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OliveDrab;
            this.btnAccesarLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccesarLogin.Location = new System.Drawing.Point(331, 205);
            this.btnAccesarLogin.Margin = new System.Windows.Forms.Padding(5);
            this.btnAccesarLogin.Name = "btnAccesarLogin";
            this.btnAccesarLogin.Size = new System.Drawing.Size(133, 34);
            this.btnAccesarLogin.TabIndex = 17;
            this.btnAccesarLogin.Text = "Acceder";
            this.btnAccesarLogin.UseVisualStyleBackColor = false;
            this.btnAccesarLogin.Click += new System.EventHandler(this.btnAccesarLogin_Click);
            // 
            // txtPass
            // 
            this.txtPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPass.Location = new System.Drawing.Point(247, 146);
            this.txtPass.Margin = new System.Windows.Forms.Padding(5);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(175, 23);
            this.txtPass.TabIndex = 16;
            // 
            // txtNickname
            // 
            this.txtNickname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNickname.Location = new System.Drawing.Point(247, 94);
            this.txtNickname.Margin = new System.Windows.Forms.Padding(5);
            this.txtNickname.Name = "txtNickname";
            this.txtNickname.Size = new System.Drawing.Size(175, 23);
            this.txtNickname.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(96, 146);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Constraseña";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(136, 94);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Usuario";
            // 
            // TimAcceso
            // 
            this.TimAcceso.Tick += new System.EventHandler(this.TimAcceso_Tick);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(636, 427);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnRestaConrasena);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btnAccesarLogin);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtNickname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnRestaConrasena;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtNickname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer TimAcceso;
        public System.Windows.Forms.Button btnAccesarLogin;
    }
}