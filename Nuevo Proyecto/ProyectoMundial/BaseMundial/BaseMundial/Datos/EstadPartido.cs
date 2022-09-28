using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseMundial.Datos
{
    internal class EstadPartido
    {
        private string cod_Selecc;
        private int no_Ronda;
        private int no_Bombo;
        private int goles;
        private int tarj_Amari;
        private int tarj_Roja;
        private int tiro_alArco;
        private int tiro_Desv;
        private int tiro_Esquina;

        public EstadPartido()
        {
            this.cod_Selecc = "";
            this.no_Ronda = 0;
            this.no_Bombo = 0;
            this.goles = 0;
            this.tarj_Amari = 0;
            this.tarj_Roja = 0;
            this.tiro_alArco = 0;
            this.tiro_Desv = 0;
            this.tiro_Esquina = 0;
        }

        public string Cod_Selecc { get => cod_Selecc; set => cod_Selecc = value; }
        public int No_Ronda { get => no_Ronda; set => no_Ronda = value; }
        public int No_Bombo { get => no_Bombo; set => no_Bombo = value; }
        public int Goles { get => goles; set => goles = value; }
        public int Tarj_Amari { get => tarj_Amari; set => tarj_Amari = value; }
        public int Tarj_Roja { get => tarj_Roja; set => tarj_Roja = value; }
        public int Tiro_alArco { get => tiro_alArco; set => tiro_alArco = value; }
        public int Tiro_Desv { get => tiro_Desv; set => tiro_Desv = value; }
        public int Tiro_Esquina { get => tiro_Esquina; set => tiro_Esquina = value; }
    }
}
