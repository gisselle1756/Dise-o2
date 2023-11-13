namespace Diseño
{
    partial class Form2
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
            this.grpDatospersona = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEjecutar = new System.Windows.Forms.Button();
            this.dtgDatospersona = new System.Windows.Forms.DataGridView();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtIdentificacio = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblIdentificacion = new System.Windows.Forms.Label();
            this.grpDatospersona.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDatospersona)).BeginInit();
            this.SuspendLayout();
            // 
            // grpDatospersona
            // 
            this.grpDatospersona.Controls.Add(this.btnSalir);
            this.grpDatospersona.Controls.Add(this.btnEjecutar);
            this.grpDatospersona.Controls.Add(this.dtgDatospersona);
            this.grpDatospersona.Controls.Add(this.txtEmail);
            this.grpDatospersona.Controls.Add(this.txtNombre);
            this.grpDatospersona.Controls.Add(this.txtTelefono);
            this.grpDatospersona.Controls.Add(this.txtIdentificacio);
            this.grpDatospersona.Controls.Add(this.lblEmail);
            this.grpDatospersona.Controls.Add(this.lblTelefono);
            this.grpDatospersona.Controls.Add(this.lblNombre);
            this.grpDatospersona.Controls.Add(this.lblIdentificacion);
            this.grpDatospersona.Location = new System.Drawing.Point(37, 107);
            this.grpDatospersona.Name = "grpDatospersona";
            this.grpDatospersona.Size = new System.Drawing.Size(585, 301);
            this.grpDatospersona.TabIndex = 1;
            this.grpDatospersona.TabStop = false;
            this.grpDatospersona.Text = "Datos de persona";
            this.grpDatospersona.Enter += new System.EventHandler(this.grpDatospersona_Enter);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(441, 252);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(101, 43);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnEjecutar
            // 
            this.btnEjecutar.Location = new System.Drawing.Point(24, 252);
            this.btnEjecutar.Name = "btnEjecutar";
            this.btnEjecutar.Size = new System.Drawing.Size(114, 43);
            this.btnEjecutar.TabIndex = 9;
            this.btnEjecutar.Text = "Ejecutar";
            this.btnEjecutar.UseVisualStyleBackColor = true;
            // 
            // dtgDatospersona
            // 
            this.dtgDatospersona.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDatospersona.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtgDatospersona.Location = new System.Drawing.Point(302, 20);
            this.dtgDatospersona.Name = "dtgDatospersona";
            this.dtgDatospersona.Size = new System.Drawing.Size(240, 150);
            this.dtgDatospersona.TabIndex = 2;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(97, 106);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(149, 20);
            this.txtEmail.TabIndex = 8;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(97, 80);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(149, 20);
            this.txtNombre.TabIndex = 7;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(97, 50);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(149, 20);
            this.txtTelefono.TabIndex = 6;
            // 
            // txtIdentificacio
            // 
            this.txtIdentificacio.Location = new System.Drawing.Point(97, 20);
            this.txtIdentificacio.Name = "txtIdentificacio";
            this.txtIdentificacio.Size = new System.Drawing.Size(149, 20);
            this.txtIdentificacio.TabIndex = 1;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(30, 103);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Email";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(25, 50);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(49, 13);
            this.lblTelefono.TabIndex = 2;
            this.lblTelefono.Text = "Telefono";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(30, 80);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // lblIdentificacion
            // 
            this.lblIdentificacion.AutoSize = true;
            this.lblIdentificacion.Location = new System.Drawing.Point(21, 20);
            this.lblIdentificacion.Name = "lblIdentificacion";
            this.lblIdentificacion.Size = new System.Drawing.Size(70, 13);
            this.lblIdentificacion.TabIndex = 0;
            this.lblIdentificacion.Text = "Identificacion";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpDatospersona);
            this.Name = "Form2";
            this.Text = "Formulario Parqueadero";
            this.grpDatospersona.ResumeLayout(false);
            this.grpDatospersona.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDatospersona)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDatospersona;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEjecutar;
        private System.Windows.Forms.DataGridView dtgDatospersona;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtIdentificacio;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblIdentificacion;
    }
}