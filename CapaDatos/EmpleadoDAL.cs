using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class EmpleadoDAL
    {
        ContextoBD _db;

        public int EliminarEmpleado(int id)
        {
            _db = new ContextoBD();
            int resultado = 0;

            var empleado = _db.Empleados.Find(id);

            if (empleado != null)
            {
                _db.SaveChanges();

                resultado = empleado.EmpleadoId;
            }

            return resultado;
        }

        public int Guardar(Empleado empleado, int id = 0, bool esActualizacion = false)
        {
            _db = new ContextoBD();

            int resultado;

            if (esActualizacion)
            {
                empleado.EmpleadoId = id;

                _db.Entry(empleado).State = System.Data.Entity.EntityState.Modified;
                _db.SaveChanges();

                resultado = empleado.EmpleadoId;
            }
            else
            {
                _db.Empleados.Add(empleado);
                _db.SaveChanges();

                resultado = empleado.EmpleadoId;
            }

            return resultado;
        }

        public List<Empleado> Leer()
        {
            _db = new ContextoBD();

            return _db.Empleados.ToList();
        }

        public Empleado LeerPorId(int id)
        {
            _db = new ContextoBD();

            return _db.Empleados.Find(id);
        }
    }
}
