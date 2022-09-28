using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseMundial.Datos
{
    internal class Seleccion
    {
        private string cod_Selecc;
        private string nom_Selecc;
        private string entrenador;
        private int no_Bombo;

        public Seleccion()
        {
            this.cod_Selecc = "";
            this.nom_Selecc = "";
            this.entrenador = "";
            this.no_Bombo = 0;
        }

        public string Cod_Selecc { get => cod_Selecc; set => cod_Selecc = value; }
        public string Nom_Selecc { get => nom_Selecc; set => nom_Selecc = value; }
        public string Entrenador { get => entrenador; set => entrenador = value; }
        public int No_Bombo { get => no_Bombo; set => no_Bombo = value; }
    }
}
