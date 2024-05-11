using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class FabricanteDAL
    {
        ContextoBD _db;

        public int Guardar(Fabricante fabricante, int id = 0, bool esActualizacion = false)
        {
            _db = new ContextoBD();

            int resultado;

            if (esActualizacion)
            {
                fabricante.FabricanteId = id;

                _db.Entry(fabricante).State = System.Data.Entity.EntityState.Modified;
                _db.SaveChanges();

                resultado = fabricante.FabricanteId;
            }
            else
            {
                _db.Fabricantes.Add(fabricante);
                _db.SaveChanges();

                resultado = fabricante.FabricanteId;
            }

            return resultado;
        }

        public List<Fabricante> Leer()
        {
            _db = new ContextoBD();

            return _db.Fabricantes.ToList();
        }

        public Fabricante LeerPorId(int id)
        {
            _db = new ContextoBD();

            return _db.Fabricantes.Find(id);
        }

        public string ObtenerNombreFabricanteDesdeBD(int idFabricante)
        {
            string nombreFabricante = string.Empty;
            _db = new ContextoBD();
            Fabricante fabricante = _db.Fabricantes.FirstOrDefault(m => m.FabricanteId == idFabricante);
            if (fabricante != null)
            {
                nombreFabricante = fabricante.NombreFabricante;
            }
            return nombreFabricante;
        }

        public List<Fabricante> Fabricantes(bool inactivo = false)
        {
            _db = new ContextoBD();

            if (inactivo)
            {
                return _db.Fabricantes.Where(c => c.Estado == false).ToList();
            }
            else
            {
                return _db.Fabricantes.Where(c => c.Estado == true).ToList();
            }
        }
    }
}
