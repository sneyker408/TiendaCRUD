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

        public string ObtenerFabricantePorId(int idFabricante)
        {
            _fabricanteDAL = new FabricanteDAL();
            return _fabricanteDAL.ObtenerNombreFabricanteDesdeBD(idFabricante);

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
    }
}
