using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Calendar.Model {
    public class Registro {

        private int id;
        private String inicioOtermino;
        private String observacion;
        private String metodoAnticonceptivo;
        private int actoSexual;

        /*Estado de ánimo*/
        private int agotada;
        private int ansiosa;
        private int coqueta;
        private int deprimida;
        private int enojada;
        private int nauseas;
        private int libidinosa;
        private int estres;
        private int irritable;
        private int insomnio;
        private int rara;
        private int sensible;

        /*Síntomas*/
        private int dolorCabeza;
        private int migraña;
        private int dolorPechos;
        private int sensibilidadPechos;
        private int dolorEspalda;
        private int dolorLumbar;
        private int calambre;
        private int escalosfrios;
        private int sarpullido;
        private int sofoco;
        private int dolorPelvis;
        private int hinchazon;
        private int estreñimiento;
        private int diarrea;
        private int antojos;
        private int dolorPorOvulacion;
        private int sangrado;
        private int manchado;

        /*Fluidos*/
        private int seco;
        private int pegajoso;
        private int cremoso;
        private int verde;
        private int conSangre;
        private int conMalOlor;

        public Registro() {
        }

        public int Id { get => id; set => id = value; }
        public String InicioOtermino { get => inicioOtermino; set => inicioOtermino = value; }
        public String Observacion { get => observacion; set => observacion = value; }
        public String MetodoAnticonceptivo { get => metodoAnticonceptivo; set => metodoAnticonceptivo = value; }
        public int ActoSexual { get => actoSexual; set => actoSexual = value; }
        public int Agotada { get => agotada; set => agotada = value; }
        public int Ansiosa { get => ansiosa; set => ansiosa = value; }
        public int Coqueta { get => coqueta; set => coqueta = value; }
        public int Deprimida { get => deprimida; set => deprimida = value; }
        public int Enojada { get => enojada; set => enojada = value; }
        public int Nauseas { get => nauseas; set => nauseas = value; }
        public int Libidinosa { get => libidinosa; set => libidinosa = value; }
        public int Estres { get => estres; set => estres = value; }
        public int Irritable { get => irritable; set => irritable = value; }
        public int Insomnio { get => insomnio; set => insomnio = value; }
        public int Rara { get => rara; set => rara = value; }
        public int Sensible { get => sensible; set => sensible = value; }
        public int DolorCabeza { get => dolorCabeza; set => dolorCabeza = value; }
        public int Migraña { get => migraña; set => migraña = value; }
        public int DolorPechos { get => dolorPechos; set => dolorPechos = value; }
        public int SensibilidadPechos { get => sensibilidadPechos; set => sensibilidadPechos = value; }
        public int DolorEspalda { get => dolorEspalda; set => dolorEspalda = value; }
        public int DolorLumbar { get => dolorLumbar; set => dolorLumbar = value; }
        public int Calambre { get => calambre; set => calambre = value; }
        public int Escalosfrios { get => escalosfrios; set => escalosfrios = value; }
        public int Sarpullido { get => sarpullido; set => sarpullido = value; }
        public int Sofoco { get => sofoco; set => sofoco = value; }
        public int DolorPelvis { get => dolorPelvis; set => dolorPelvis = value; }
        public int Hinchazon { get => hinchazon; set => hinchazon = value; }
        public int Estreñimiento { get => estreñimiento; set => estreñimiento = value; }
        public int Diarrea { get => diarrea; set => diarrea = value; }
        public int Antojos { get => antojos; set => antojos = value; }
        public int DolorPorOvulacion { get => dolorPorOvulacion; set => dolorPorOvulacion = value; }
        public int Sangrado { get => sangrado; set => sangrado = value; }
        public int Manchado { get => manchado; set => manchado = value; }
        public int Seco { get => seco; set => seco = value; }
        public int Pegajoso { get => pegajoso; set => pegajoso = value; }
        public int Cremoso { get => cremoso; set => cremoso = value; }
        public int Verde { get => verde; set => verde = value; }
        public int ConSangre { get => conSangre; set => conSangre = value; }
        public int ConMalOlor { get => conMalOlor; set => conMalOlor = value; }
    }
}