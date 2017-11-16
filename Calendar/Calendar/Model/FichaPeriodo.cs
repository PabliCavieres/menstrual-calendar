using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Calendar.Model {
    public class FichaPeriodo {
        public int id;
        public DateTime fechaPeriodo;
        public int duracionCiclo;
        public int duracionPeriodo;




        public FichaPeriodo() {
        }

        public int Id { get => id; set => id = value; }
        public DateTime FechaPeriodo { get => fechaPeriodo; set => fechaPeriodo = value; }
        public int DuracionCiclo { get => duracionCiclo; set => duracionCiclo = value; }
        public int DuracionPeriodo { get => duracionPeriodo; set => duracionPeriodo = value; }

    }
}