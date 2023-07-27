using Proyecto_CRUD.Data;
using Proyecto_CRUD.Modelo;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_CRUD
{
    public class Logica
    {
        private Operaciones _operaciones;

        public Logica()
        {
            _operaciones = new Operaciones();
        }


        public void GuardarEmpleado(Empleados empleados)
        {
            if (empleados.NEmpleado == 0)
            {
                _operaciones.InsertEmpleado(empleados);
            }
            else
            {
                _operaciones.UpdateEmpleado(empleados);
            }

        }

        public List<Empleados> MostrarEmpleado()
        {
            return _operaciones.SelectEmpleado();     
        }

        public void EliminarEmpleado(int nempleados)
        {
            _operaciones.DeleteEmpleado(nempleados);
        }
    }
}
