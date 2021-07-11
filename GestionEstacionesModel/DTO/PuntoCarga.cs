using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEstacionesModel.DTO
{
    public enum TipoPunto
    {
        Eléctrico, Dual
    }

    public class PuntoCarga
    {
        private int idPunto;
        private int capacidadMax;
        private DateTime vencimiento;
        private TipoPunto tipo;

        public int IdPunto { get => idPunto; set => idPunto = value; }
        public int CapacidadMax { get => capacidadMax; set => capacidadMax = value; }
        public DateTime Vencimiento { get => vencimiento; set => vencimiento = value; }
        public TipoPunto Tipo { get => tipo; set => tipo = value; }
    }
}
