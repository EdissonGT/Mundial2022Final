using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseMundial.Datos
{
    internal class Plantilla
    {
        private string cod_Jugad;
        private string cod_Selecc;
        private string nom_Jugad;
        private string apell_Jugad;
        private string date_Naci;
        private string club_Jugad;
        private int min_play;
        private int goles_Jugad;
        private int asist_Jugad;

        public Plantilla()
        {
            this.cod_Jugad = "";
            this.cod_Selecc = "";
            this.nom_Jugad = "";
            this.apell_Jugad = "";
            this.date_Naci = "";
            this.club_Jugad = "";
            this.min_play = 0;
            this.goles_Jugad = 0;
            this.Asist_Jugad = 0;

        }

        public string Cod_Jugad { get => cod_Jugad; set => cod_Jugad = value; }
        public string Cod_Selecc { get => cod_Selecc; set => cod_Selecc = value; }
        public string Nom_Jugad { get => nom_Jugad; set => nom_Jugad = value; }
        public string Apell_Jugad { get => apell_Jugad; set => apell_Jugad = value; }
        public string Date_Naci { get => date_Naci; set => date_Naci = value; }
        public string Club_Jugad { get => club_Jugad; set => club_Jugad = value; }
        public int Min_play { get => min_play; set => min_play = value; }
        public int Goles_Jugad { get => goles_Jugad; set => goles_Jugad = value; }
        public int Asist_Jugad { get => asist_Jugad; set => asist_Jugad = value; }
    }
}
