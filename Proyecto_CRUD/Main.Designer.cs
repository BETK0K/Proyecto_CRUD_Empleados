namespace Proyecto_CRUD
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAgregar = new Button();
            dtEmpleados = new DataGridView();
            Editar = new DataGridViewLinkColumn();
            Eliminar = new DataGridViewLinkColumn();
            ((System.ComponentModel.ISupportInitialize)dtEmpleados).BeginInit();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregar.Location = new Point(12, 10);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(109, 36);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // dtEmpleados
            // 
            dtEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtEmpleados.Columns.AddRange(new DataGridViewColumn[] { Editar, Eliminar });
            dtEmpleados.Location = new Point(12, 56);
            dtEmpleados.Name = "dtEmpleados";
            dtEmpleados.RowTemplate.Height = 25;
            dtEmpleados.Size = new Size(743, 345);
            dtEmpleados.TabIndex = 1;
            dtEmpleados.CellContentClick += dtEmpleados_CellContentClick;
            // 
            // Editar
            // 
            Editar.HeaderText = "Editar";
            Editar.LinkColor = Color.FromArgb(128, 128, 255);
            Editar.Name = "Editar";
            Editar.ReadOnly = true;
            Editar.Text = "Editar";
            Editar.UseColumnTextForLinkValue = true;
            // 
            // Eliminar
            // 
            Eliminar.HeaderText = "Eliminar";
            Eliminar.LinkColor = Color.FromArgb(128, 128, 255);
            Eliminar.Name = "Eliminar";
            Eliminar.ReadOnly = true;
            Eliminar.Text = "Eliminar";
            Eliminar.UseColumnTextForLinkValue = true;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(766, 417);
            Controls.Add(dtEmpleados);
            Controls.Add(btnAgregar);
            Name = "Main";
            Text = "Empleados";
            Load += Main_Load;
            ((System.ComponentModel.ISupportInitialize)dtEmpleados).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnAgregar;
        private DataGridView dtEmpleados;
        private DataGridViewLinkColumn Editar;
        private DataGridViewLinkColumn Eliminar;
    }
}