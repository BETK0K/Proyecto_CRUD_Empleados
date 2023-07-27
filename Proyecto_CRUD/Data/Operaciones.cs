using Microsoft.VisualBasic.ApplicationServices;
using Proyecto_CRUD.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_CRUD.Data
{
    public class Operaciones
    {
        private SqlConnection conectar = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False; User ID=sa; Initial Catalog=Empleados;Data Source = IEEN-204\\SQLEXPRESS");

        public void InsertEmpleado(Empleados empleados)
        {
            SqlCommand comando;
            SqlParameter nombre, apellidos, telefono, carrera;
            String query;

            try
            {
                conectar.Open();
                query = "INSERT INTO Empleados (Nombre, Apellidos, Telefono, Carrera) VALUES (@Nombre, @Apellidos, @Telefono, @Carrera) ";

                nombre = new SqlParameter("@Nombre", empleados.Nombre);
                apellidos = new SqlParameter("@Apellidos", empleados.Apellidos);
                telefono = new SqlParameter("@Telefono", empleados.Telefono);
                carrera = new SqlParameter("Carrera", empleados.Carrera);

                comando = new SqlCommand(query, conectar);

                comando.Parameters.Add(nombre);
                comando.Parameters.Add(apellidos);
                comando.Parameters.Add(telefono);
                comando.Parameters.Add(carrera);

                comando.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally { conectar.Close(); }
        }

        public List<Empleados> SelectEmpleado()
        {
            SqlCommand comando;
            String query;
            SqlDataReader reader;
            List<Empleados> lEmpleados = new List<Empleados>();

            try
            {
                conectar.Open();
                query = "SELECT * FROM Empleados ";
                comando = new SqlCommand(query, conectar);

                reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    lEmpleados.Add(new Empleados
                    {
                        NEmpleado = int.Parse(reader["NEmpleado"].ToString()),
                        Nombre = reader["Nombre"].ToString(),
                        Apellidos = reader["Apellidos"].ToString(),
                        Telefono = reader["Telefono"].ToString(),
                        Carrera = reader["Carrera"].ToString()
                    });
                }

            }
            catch (Exception)
            {

                throw;
            }
            finally { conectar.Close(); }

            return lEmpleados;
        }

        public void UpdateEmpleado(Empleados empleados)
        {
            SqlCommand comando;
            SqlParameter nempleado, nombre, apellidos, telefono, carrera;
            String query;
            SqlDataReader reader;

            try
            {
                conectar.Open();
                query = "UPDATE Empleados SET Nombre = @Nombre, Apellidos = @Apellidos, Telefono = @Telefono, Carrera = @Carrera WHERE NEmpleado = @NEmpleado ";

                nempleado = new SqlParameter("@NEmpleado", empleados.NEmpleado);
                nombre = new SqlParameter("@Nombre", empleados.Nombre);
                apellidos = new SqlParameter("@Apellidos", empleados.Apellidos);
                telefono = new SqlParameter("@Telefono", empleados.Telefono);
                carrera = new SqlParameter("Carrera", empleados.Carrera);

                comando = new SqlCommand(query, conectar);

                comando.Parameters.Add(nempleado);
                comando.Parameters.Add(nombre);
                comando.Parameters.Add(apellidos);
                comando.Parameters.Add(telefono);
                comando.Parameters.Add(carrera);

                comando.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally { conectar.Close(); }
        }

        public void DeleteEmpleado(int nempleado)
        {
            SqlCommand comando;
            String query;

            try
            {
                conectar.Open();
                query = "DELETE FROM Empleados WHERE NEmpleado = @NEmpleado ";

                SqlCommand command = new SqlCommand(query, conectar);
                command.Parameters.Add(new SqlParameter("@NEmpleado", nempleado));

                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally { conectar.Close(); }
        }
    }
}
