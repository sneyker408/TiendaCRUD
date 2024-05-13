using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class EmpleadoLOG
    {
        EmpleadoDAL _empleadoDAL;

        public int GuardarEmpleado(Empleado empleado)
        {
            _empleadoDAL = new EmpleadoDAL();

            return _empleadoDAL.Guardar(empleado);
        }

        public Empleado ObtenerEmpleadoPorId(int codigo)
        {
            _empleadoDAL = new EmpleadoDAL();

            return _empleadoDAL.LeerPorId(codigo);
        }

        public int ActualizarEmpleado(Empleado empleado, int id)
        {
            _empleadoDAL = new EmpleadoDAL();

            return _empleadoDAL.Guardar(empleado, id, true);
        }

        public List<Empleado> ObtenerEmpleados()
        {
            _empleadoDAL = new EmpleadoDAL();

            return _empleadoDAL.Leer();
        }

        public bool CorreoElectronicoExiste(string correoElectronico)
        {
            using (var contexto = new ContextoBD())
            {
                return contexto.Empleados.Any(c => c.CorreoElectronico == correoElectronico);
            }
        }
    }
}
