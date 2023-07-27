namespace Proyecto_CRUD
{
    partial class Registro_Empleado
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
            btnGuardar = new Button();
            txtNombre = new TextBox();
            label2 = new Label();
            txtApellidos = new TextBox();
            label3 = new Label();
            txtTelefono = new TextBox();
            label4 = new Label();
            txtCarrera = new TextBox();
            label5 = new Label();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnGuardar.Location = new Point(170, 225);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(96, 33);
            btnGuardar.TabIndex = 0;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.Location = new Point(148, 30);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(292, 26);
            txtNombre.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(10, 30);
            label2.Name = "label2";
            label2.Size = new Size(84, 23);
            label2.TabIndex = 3;
            label2.Text = "Nombre:";
            // 
            // txtApellidos
            // 
            txtApellidos.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtApellidos.Location = new Point(148, 77);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(292, 26);
            txtApellidos.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(10, 77);
            label3.Name = "label3";
            label3.Size = new Size(96, 23);
            label3.TabIndex = 5;
            label3.Text = "Apellidos:";
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTelefono.Location = new Point(148, 125);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(292, 26);
            txtTelefono.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(10, 125);
            label4.Name = "label4";
            label4.Size = new Size(92, 23);
            label4.TabIndex = 7;
            label4.Text = "Telefono:";
            // 
            // txtCarrera
            // 
            txtCarrera.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCarrera.Location = new Point(148, 173);
            txtCarrera.Name = "txtCarrera";
            txtCarrera.Size = new Size(292, 26);
            txtCarrera.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(10, 173);
            label5.Name = "label5";
            label5.Size = new Size(82, 23);
            label5.TabIndex = 9;
            label5.Text = "Carrera:";
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.Location = new Point(323, 225);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(96, 33);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // Registro_Empleado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(461, 281);
            Controls.Add(btnCancelar);
            Controls.Add(txtCarrera);
            Controls.Add(label5);
            Controls.Add(txtTelefono);
            Controls.Add(label4);
            Controls.Add(txtApellidos);
            Controls.Add(label3);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(btnGuardar);
            Name = "Registro_Empleado";
            Text = "Empleado";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGuardar;
        private TextBox txtNombre;
        private Label label2;
        private TextBox txtApellidos;
        private Label label3;
        private TextBox txtTelefono;
        private Label label4;
        private TextBox txtCarrera;
        private Label label5;
        private Button btnCancelar;
    }
}