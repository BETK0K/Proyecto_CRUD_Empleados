using Proyecto_CRUD.Modelo;
using System.DirectoryServices;

namespace Proyecto_CRUD
{
    public partial class Main : Form
    {
        private Logica _logica;

        public Main()
        {
            InitializeComponent();
            _logica = new Logica();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Consulta();
        }

        public void Consulta()
        {
            List<Empleados> lEmpleados = _logica.MostrarEmpleado();
            dtEmpleados.DataSource = lEmpleados;
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            registrar();
        }

        private void registrar()
        {
            Registro_Empleado registrarEmpleado = new Registro_Empleado();
            registrarEmpleado.ShowDialog(this);
        }

        private void dtEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewLinkCell cell = (DataGridViewLinkCell)dtEmpleados.Rows[e.RowIndex].Cells[e.ColumnIndex];
            if (cell.Value.ToString() == "Editar")
            {
                Registro_Empleado registro_Empleado = new Registro_Empleado();
                registro_Empleado.CargarEmpleados(new Empleados
                {
                    NEmpleado = int.Parse(dtEmpleados.Rows[e.RowIndex].Cells[2].Value.ToString()),
                    Nombre = dtEmpleados.Rows[e.RowIndex].Cells[3].Value.ToString(),
                    Apellidos = dtEmpleados.Rows[e.RowIndex].Cells[4].Value.ToString(),
                    Telefono = dtEmpleados.Rows[e.RowIndex].Cells[5].Value.ToString(),
                    Carrera = dtEmpleados.Rows[e.RowIndex].Cells[6].Value.ToString()
                });
                registro_Empleado.ShowDialog(this);
            }
            else if (cell.Value.ToString() == "Eliminar")
            {
                DeleteEmpleado(int.Parse(dtEmpleados.Rows[e.RowIndex].Cells[2].Value.ToString()));
                Consulta();
            }
        }

        private void DeleteEmpleado(int nempleados)
        {
            _logica.EliminarEmpleado(nempleados);
        }
    }
}