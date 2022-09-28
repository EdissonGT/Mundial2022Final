using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseMundial.Datos
{
    internal class EstadGol
    {
        //private int id;
        private string cod_Jugad;
        private int no_Ronda;
        private int no_Bombo;
        private string cod_Selecc;
        private int min_Gol;
        private string asist_gol;
        private string tipo_gol;

        public EstadGol()
        {
            this.cod_Jugad = "";
            this.no_Ronda = 0;
            this.no_Bombo = 0;
            this.cod_Selecc = "";
            this.min_Gol = 0;
            this.asist_gol = "";
            this.tipo_gol = "";

        }

        public string Cod_Jugad { get => cod_Jugad; set => cod_Jugad = value; }
        public int No_Ronda { get => no_Ronda; set => no_Ronda = value; }
        public int No_Bombo { get => no_Bombo; set => no_Bombo = value; }
        public string Cod_Selecc { get => cod_Selecc; set => cod_Selecc = value; }
        public int Min_Gol { get => min_Gol; set => min_Gol = value; }
        public string Asist_gol { get => asist_gol; set => asist_gol = value; }
        public string Tipo_gol { get => tipo_gol; set => tipo_gol = value; }
    }
}
