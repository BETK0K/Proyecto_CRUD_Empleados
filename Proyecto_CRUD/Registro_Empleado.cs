using Proyecto_CRUD.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_CRUD
{
    public partial class Registro_Empleado : Form
    {
        private Logica _Logica;
        private Empleados _empleados;

        public Registro_Empleado()
        {
            InitializeComponent();
            _Logica = new Logica();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
            this.Close();
            ((Main)this.Owner).Consulta();
        }

        public void Guardar()
        {
            Empleados empleados = new Empleados();
            empleados.Nombre = txtNombre.Text;
            empleados.Apellidos = txtApellidos.Text;
            empleados.Telefono = txtTelefono.Text;
            empleados.Carrera = txtCarrera.Text;

            empleados.NEmpleado = _empleados != null ? _empleados.NEmpleado : 0;

            _Logica.GuardarEmpleado(empleados);
        }

        public void CargarEmpleados(Empleados empleados)
        {
            _empleados = empleados;

            if (empleados != null)
            {
                BorrarFormularios();
                txtNombre.Text = empleados.Nombre;
                txtApellidos.Text = empleados.Apellidos;
                txtTelefono.Text = empleados.Telefono;
                txtCarrera.Text = empleados.Carrera;
            }

        }

        public void BorrarFormularios()
        {
            txtNombre.Text = string.Empty;
            txtApellidos.Text = string.Empty;
            txtTelefono.Text += string.Empty;
            txtCarrera.Text += string.Empty;
        }
    }
}