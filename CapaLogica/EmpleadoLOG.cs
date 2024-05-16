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

        public List<int> ObtenerTodosLosEmpleadoIds()
        {
            _empleadoDAL = new EmpleadoDAL();

            return _empleadoDAL.ObtenerTodosLosEmpleadoIds();
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

        public int EliminarEmpleado(int id)
        {
            _empleadoDAL = new EmpleadoDAL();
            return _empleadoDAL.EliminarEmpleado(id);
        }

        public List<Empleado> NumeroTelefonoExiste(bool inactivo = false)
        {
            _empleadoDAL = new EmpleadoDAL();
            return _empleadoDAL.NumeroTelefonoExiste(inactivo);
        }

        public object ObtenerTodosTelefonos()
        {
            _empleadoDAL = new EmpleadoDAL();
            return _empleadoDAL.TodosTelefonos();
        }

        public object ObtenerTodosCorreos()
        {
            _empleadoDAL = new EmpleadoDAL();
            return _empleadoDAL.TodosCorreos();
        }

        public Empleado ObtenerCorreoPorNombre(string nombrecorreo)
        {
            _empleadoDAL = new EmpleadoDAL();

            return _empleadoDAL.ObtenerCorreoPorNombre(nombrecorreo);
        }

        public Empleado ObtenerClientePorTelefono(int numeroTelefono)
        {
            _empleadoDAL = new EmpleadoDAL();

            return _empleadoDAL.ObtenerClientePorTelefono(numeroTelefono);
        }

        public string ExtraercorreoEmpleado(int codigo)
        {
            _empleadoDAL = new EmpleadoDAL();
            return _empleadoDAL.ObtenercorreoEmpleadoDesdeBD(codigo);
        }

        public string ExtrarnumeroEmpleado(int codigo)
        {
            _empleadoDAL = new EmpleadoDAL();
            return _empleadoDAL.ObtenernumeroEmpleadoDesdeBD(codigo);
        }

        public List<string> ObtenerCorreos()
        {
            List<string> correos = new List<string>();

            using (var _db = new ContextoBD())
            {
                correos = _db.Empleados.Select(c => c.CorreoElectronico).ToList();
            }

            return correos;
        }
    }
}
