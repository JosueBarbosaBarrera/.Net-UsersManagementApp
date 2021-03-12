namespace gestorDeUsuariosApp
{
    partial class frmPrincipal
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuRegistrarUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCerrarSession = new System.Windows.Forms.ToolStripMenuItem();
            this.etiquetaLogeadorComo = new System.Windows.Forms.Label();
            this.CajaDeDatosUsuarios = new System.Windows.Forms.GroupBox();
            this.txtIdTipo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtConfirPass = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtTipoUsuario = new System.Windows.Forms.TextBox();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.CajaDeDatosUsuarios.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(200, 52);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(343, 30);
            this.txtNombre.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuUsuarios,
            this.menuCerrarSession});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(555, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuUsuarios
            // 
            this.menuUsuarios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMenuRegistrarUsuario});
            this.menuUsuarios.Name = "menuUsuarios";
            this.menuUsuarios.Size = new System.Drawing.Size(204, 24);
            this.menuUsuarios.Text = "Administracion de Usuarios";
            // 
            // subMenuRegistrarUsuario
            // 
            this.subMenuRegistrarUsuario.Name = "subMenuRegistrarUsuario";
            this.subMenuRegistrarUsuario.Size = new System.Drawing.Size(151, 26);
            this.subMenuRegistrarUsuario.Text = "Registrar";
            this.subMenuRegistrarUsuario.Click += new System.EventHandler(this.subMenuRegistrarUsuario_Click);
            // 
            // menuCerrarSession
            // 
            this.menuCerrarSession.Name = "menuCerrarSession";
            this.menuCerrarSession.Size = new System.Drawing.Size(116, 24);
            this.menuCerrarSession.Text = "Cerrar Session";
            this.menuCerrarSession.Click += new System.EventHandler(this.menuCerrarSession_Click);
            // 
            // etiquetaLogeadorComo
            // 
            this.etiquetaLogeadorComo.AutoSize = true;
            this.etiquetaLogeadorComo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etiquetaLogeadorComo.Location = new System.Drawing.Point(12, 55);
            this.etiquetaLogeadorComo.Name = "etiquetaLogeadorComo";
            this.etiquetaLogeadorComo.Size = new System.Drawing.Size(161, 25);
            this.etiquetaLogeadorComo.TabIndex = 2;
            this.etiquetaLogeadorComo.Text = "Logeado como:";
            // 
            // CajaDeDatosUsuarios
            // 
            this.CajaDeDatosUsuarios.Controls.Add(this.txtIdTipo);
            this.CajaDeDatosUsuarios.Controls.Add(this.label5);
            this.CajaDeDatosUsuarios.Controls.Add(this.txtId);
            this.CajaDeDatosUsuarios.Controls.Add(this.txtConfirPass);
            this.CajaDeDatosUsuarios.Controls.Add(this.txtPass);
            this.CajaDeDatosUsuarios.Controls.Add(this.label4);
            this.CajaDeDatosUsuarios.Controls.Add(this.label3);
            this.CajaDeDatosUsuarios.Controls.Add(this.btnLimpiar);
            this.CajaDeDatosUsuarios.Controls.Add(this.btnEliminar);
            this.CajaDeDatosUsuarios.Controls.Add(this.btnActualizar);
            this.CajaDeDatosUsuarios.Controls.Add(this.btnBuscar);
            this.CajaDeDatosUsuarios.Controls.Add(this.txtTipoUsuario);
            this.CajaDeDatosUsuarios.Controls.Add(this.txtNombreUsuario);
            this.CajaDeDatosUsuarios.Controls.Add(this.label2);
            this.CajaDeDatosUsuarios.Controls.Add(this.label1);
            this.CajaDeDatosUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CajaDeDatosUsuarios.Location = new System.Drawing.Point(17, 124);
            this.CajaDeDatosUsuarios.Name = "CajaDeDatosUsuarios";
            this.CajaDeDatosUsuarios.Size = new System.Drawing.Size(526, 419);
            this.CajaDeDatosUsuarios.TabIndex = 3;
            this.CajaDeDatosUsuarios.TabStop = false;
            this.CajaDeDatosUsuarios.Text = "Datos de Usuario";
            // 
            // txtIdTipo
            // 
            this.txtIdTipo.Location = new System.Drawing.Point(216, 114);
            this.txtIdTipo.Name = "txtIdTipo";
            this.txtIdTipo.Size = new System.Drawing.Size(87, 30);
            this.txtIdTipo.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "ID Tipo:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(216, 30);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(87, 30);
            this.txtId.TabIndex = 12;
            this.txtId.Visible = false;
            // 
            // txtConfirPass
            // 
            this.txtConfirPass.Location = new System.Drawing.Point(216, 258);
            this.txtConfirPass.Name = "txtConfirPass";
            this.txtConfirPass.PasswordChar = '*';
            this.txtConfirPass.Size = new System.Drawing.Size(219, 30);
            this.txtConfirPass.TabIndex = 11;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(216, 200);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(219, 30);
            this.txtPass.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Confirmar Contrasena:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Contrasena:";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(374, 330);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(131, 53);
            this.btnLimpiar.TabIndex = 7;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(192, 330);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(131, 53);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(12, 330);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(131, 53);
            this.btnActualizar.TabIndex = 5;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(407, 59);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(113, 44);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtTipoUsuario
            // 
            this.txtTipoUsuario.Location = new System.Drawing.Point(216, 154);
            this.txtTipoUsuario.Name = "txtTipoUsuario";
            this.txtTipoUsuario.Size = new System.Drawing.Size(219, 30);
            this.txtTipoUsuario.TabIndex = 3;
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Location = new System.Drawing.Point(216, 66);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(185, 30);
            this.txtNombreUsuario.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre de Usuario:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre (persona):";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 555);
            this.Controls.Add(this.CajaDeDatosUsuarios);
            this.Controls.Add(this.etiquetaLogeadorComo);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestor de usuarios";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPrincipal_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.CajaDeDatosUsuarios.ResumeLayout(false);
            this.CajaDeDatosUsuarios.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuUsuarios;
        private System.Windows.Forms.ToolStripMenuItem subMenuRegistrarUsuario;
        private System.Windows.Forms.ToolStripMenuItem menuCerrarSession;
        private System.Windows.Forms.Label etiquetaLogeadorComo;
        private System.Windows.Forms.GroupBox CajaDeDatosUsuarios;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtConfirPass;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtTipoUsuario;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtIdTipo;
        private System.Windows.Forms.Label label5;
    }
}