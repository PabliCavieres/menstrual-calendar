using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Calendar.Model {
    public class Registro {

        private int id;
        private bool inicio;
        private bool termino;
        private String observacion;
        private bool metodoAnticonceptivo;
        private bool actoSexual;

        /*Estado de ánimo*/
        private bool agotada;
        private bool ansiosa;
        private bool coqueta;
        private bool deprimida;
        private bool enojada;
        private bool nauseas;
        private bool libidinosa;
        private bool estres;
        private bool irritable;
        private bool insomnio;
        private bool rara;
        private bool sensible;

        /*Síntomas*/
        private bool dolorCabeza;
        private bool migraña;
        private bool dolorPechos;
        private bool sensibilidadPechos;
        private bool dolorEspalda;
        private bool dolorLumbar;
        private bool calambre;
        private bool escalosfrios;
        private bool sarpullido;
        private bool sofoco;
        private bool dolorPelvis;
        private bool hinchazon;
        private bool estreñimiento;
        private bool diarrea;
        private bool antojos;
        private bool dolorPorOvulacion;
        private bool sangrado;
        private bool manchado;

        /*Fluidos*/
        private bool seco;
        private bool pegajoso;
        private bool cremoso;
        private bool verde;
        private bool conSangre;
        private bool conMalOlor;

        public Registro() {
        }

        public int Id { get => id; set => id = value; }
        public bool Inicio { get => inicio; set => inicio = value; }
        public bool Termino { get => termino; set => termino = value; }
        public String Observacion { get => observacion; set => observacion = value; }
        public bool MetodoAnticonceptivo { get => metodoAnticonceptivo; set => metodoAnticonceptivo = value; }
        public bool ActoSexual { get => actoSexual; set => actoSexual = value; }
        public bool Agotada { get => agotada; set => agotada = value; }
        public bool Ansiosa { get => ansiosa; set => ansiosa = value; }
        public bool Coqueta { get => coqueta; set => coqueta = value; }
        public bool Deprimida { get => deprimida; set => deprimida = value; }
        public bool Enojada { get => enojada; set => enojada = value; }
        public bool Nauseas { get => nauseas; set => nauseas = value; }
        public bool Libidinosa { get => libidinosa; set => libidinosa = value; }
        public bool Estres { get => estres; set => estres = value; }
        public bool Irritable { get => irritable; set => irritable = value; }
        public bool Insomnio { get => insomnio; set => insomnio = value; }
        public bool Rara { get => rara; set => rara = value; }
        public bool Sensible { get => sensible; set => sensible = value; }
        public bool DolorCabeza { get => dolorCabeza; set => dolorCabeza = value; }
        public bool Migraña { get => migraña; set => migraña = value; }
        public bool DolorPechos { get => dolorPechos; set => dolorPechos = value; }
        public bool SensibilidadPechos { get => sensibilidadPechos; set => sensibilidadPechos = value; }
        public bool DolorEspalda { get => dolorEspalda; set => dolorEspalda = value; }
        public bool DolorLumbar { get => dolorLumbar; set => dolorLumbar = value; }
        public bool Calambre { get => calambre; set => calambre = value; }
        public bool Escalosfrios { get => escalosfrios; set => escalosfrios = value; }
        public bool Sarpullido { get => sarpullido; set => sarpullido = value; }
        public bool Sofoco { get => sofoco; set => sofoco = value; }
        public bool DolorPelvis { get => dolorPelvis; set => dolorPelvis = value; }
        public bool Hinchazon { get => hinchazon; set => hinchazon = value; }
        public bool Estreñimiento { get => estreñimiento; set => estreñimiento = value; }
        public bool Diarrea { get => diarrea; set => diarrea = value; }
        public bool Antojos { get => antojos; set => antojos = value; }
        public bool DolorPorOvulacion { get => dolorPorOvulacion; set => dolorPorOvulacion = value; }
        public bool Sangrado { get => sangrado; set => sangrado = value; }
        public bool Manchado { get => manchado; set => manchado = value; }
        public bool Seco { get => seco; set => seco = value; }
        public bool Pegajoso { get => pegajoso; set => pegajoso = value; }
        public bool Cremoso { get => cremoso; set => cremoso = value; }
        public bool Verde { get => verde; set => verde = value; }
        public bool ConSangre { get => conSangre; set => conSangre = value; }
        public bool ConMalOlor { get => conMalOlor; set => conMalOlor = value; }
    }
}