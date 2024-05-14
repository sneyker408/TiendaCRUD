using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class FabricanteLOG
    {
        FabricanteDAL _fabricanteDAL;

        public int GuardarFabricante(Fabricante fabricante, int id = 0, bool Actualizacion = false)
        {
            _fabricanteDAL = new FabricanteDAL();

            return _fabricanteDAL.Guardar(fabricante, id, Actualizacion);
        }

        public FabricanteLOG()
        {
            _fabricanteDAL = new FabricanteDAL();
        }

        public Fabricante ObtenerFabricantePorId(int codigo)
        {
            _fabricanteDAL = new FabricanteDAL();
            return _fabricanteDAL.LeerPorId(codigo);

        }

        public int ActualizarFabricante(Fabricante fabricante, int id)
        {
            _fabricanteDAL = new FabricanteDAL();

            return _fabricanteDAL.Guardar(fabricante, id, true);
        }

        public List<Fabricante> ObtenerFabricantes(bool inactivo = false)
        {
            _fabricanteDAL = new FabricanteDAL();
            return _fabricanteDAL.Fabricantes(inactivo);

        }

        public string EstraerNombreFabricante(int idFabricante)
        {
            _fabricanteDAL = new FabricanteDAL();
            return _fabricanteDAL.ObtenerNombreFabricanteDesdeBD(idFabricante);

        }

        public int EliminarFabricante(int id)
        {
            _fabricanteDAL = new FabricanteDAL();
            return _fabricanteDAL.EliminarFabricante(id);
        }

        public Fabricante ObtenerFabricantePorNombre(string nombreFabricante)
        {
            return _fabricanteDAL.ObtenerFabricantePorNombre(nombreFabricante);
        }

        public List<Fabricante> ObtenerFabricantesPorEstado(bool estadoActivo)
        {
            return _fabricanteDAL.ObtenerFabricantesPorEstado(estadoActivo);
        }

        public object ObtenerTodosFabricantes()
        {
            _fabricanteDAL = new FabricanteDAL();
            return _fabricanteDAL.TodosFabricantes();
        }
    }
}
