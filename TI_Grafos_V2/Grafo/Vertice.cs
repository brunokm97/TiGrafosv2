using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI_Grafos_V2
{
    
    
    public class Vertice
    {

        string nomeCidade;
        ListaRotas rotasAdjacentes;
        List<ArestaVoo> voosAdjacentes;


        public Vertice()
        {
            rotasAdjacentes = new ListaRotas();
            voosAdjacentes = new List<ArestaVoo>();
        }

        public string NomeCidade
        {
            get
            {
                return nomeCidade;
            }

            set
            {
                nomeCidade = value;
            }
        }

        public ListaRotas RotasAdjacentes
        {
            get
            {
                return rotasAdjacentes;
            }

            set
            {
                rotasAdjacentes = value;
            }
        }

        internal List<ArestaVoo> VoosAdjacentes
        {
            get
            {
                return voosAdjacentes;
            }

            set
            {
                voosAdjacentes = value;
            }
        }
    }
}
