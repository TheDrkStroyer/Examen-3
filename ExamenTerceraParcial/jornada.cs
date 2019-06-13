using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenTerceraParcial
{
    class jornada
    {
        IList<Equipo> listaequipo;
        private int _ronda;
        Random random = new Random();
        public jornada()
        {
            _ronda = ronda;
        }
        public int ronda
        {
            get { return _ronda; }
        }
        public void Agregar(string nombre)
        {
            listaequipo.Add(new Equipo(nombre));
        }
        public void enfrentamiento(int equipo1, int equipo2)
        {
            int dale = random.Next(1, 3);
            if(dale == 1)
            {
                return equipo1;
            }
            else
            {
                return equipo2;
            }
        }
        }

    }
}
