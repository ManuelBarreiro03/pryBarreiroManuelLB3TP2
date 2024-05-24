namespace pryBarreiroManuelLB3TP2
{
    partial class frmInicioSEsion
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
            lblUsuario = new Label();
            lblContraseña = new Label();
            cmdIniciar = new Button();
            txtUsuario = new TextBox();
            txtContraseña = new TextBox();
            cmdCancelar = new Button();
            statusStrip1 = new StatusStrip();
            tssEstadoConexion = new ToolStripStatusLabel();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 11F);
            lblUsuario.Location = new Point(12, 9);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(59, 20);
            lblUsuario.TabIndex = 2;
            lblUsuario.Text = "Usuario";
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Font = new Font("Segoe UI", 11F);
            lblContraseña.Location = new Point(12, 50);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(83, 20);
            lblContraseña.TabIndex = 3;
            lblContraseña.Text = "Contraseña";
            // 
            // cmdIniciar
            // 
            cmdIniciar.Font = new Font("Segoe UI", 10F);
            cmdIniciar.Location = new Point(12, 88);
            cmdIniciar.Name = "cmdIniciar";
            cmdIniciar.Size = new Size(99, 34);
            cmdIniciar.TabIndex = 2;
            cmdIniciar.Text = "Iniciar Sesion";
            cmdIniciar.UseVisualStyleBackColor = true;
            cmdIniciar.Click += cmdIniciar_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Segoe UI", 11F);
            txtUsuario.Location = new Point(101, 2);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(166, 27);
            txtUsuario.TabIndex = 0;
            // 
            // txtContraseña
            // 
            txtContraseña.Font = new Font("Segoe UI", 11F);
            txtContraseña.Location = new Point(101, 43);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = '*';
            txtContraseña.Size = new Size(166, 27);
            txtContraseña.TabIndex = 1;
            // 
            // cmdCancelar
            // 
            cmdCancelar.Font = new Font("Segoe UI", 10F);
            cmdCancelar.Location = new Point(168, 88);
            cmdCancelar.Name = "cmdCancelar";
            cmdCancelar.Size = new Size(99, 34);
            cmdCancelar.TabIndex = 3;
            cmdCancelar.Text = "Cancelar";
            cmdCancelar.UseVisualStyleBackColor = true;
            cmdCancelar.Click += cmdCancelar_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { tssEstadoConexion });
            statusStrip1.Location = new Point(0, 126);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(279, 22);
            statusStrip1.TabIndex = 5;
            statusStrip1.Text = "statusStrip1";
            // 
            // tssEstadoConexion
            // 
            tssEstadoConexion.Name = "tssEstadoConexion";
            tssEstadoConexion.Size = new Size(57, 17);
            tssEstadoConexion.Text = "EstadoBD";
            // 
            // frmInicioSEsion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(279, 148);
            Controls.Add(statusStrip1);
            Controls.Add(cmdCancelar);
            Controls.Add(cmdIniciar);
            Controls.Add(lblContraseña);
            Controls.Add(lblUsuario);
            Controls.Add(txtContraseña);
            Controls.Add(txtUsuario);
            Name = "frmInicioSEsion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio Sesion";
            Load += frmInicioSEsion_Load;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsuario;
        private Label lblContraseña;
        private Button cmdIniciar;
        private TextBox txtUsuario;
        private TextBox txtContraseña;
        private Button cmdCancelar;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel tssEstadoConexion;
    }
}