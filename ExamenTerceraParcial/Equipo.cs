using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenTerceraParcial
{

    class Equipo
    {
        private string _Nequipo;
        IList<Jugador> listajugadore;
        public Equipo(String Nequipo)
        {
            _Nequipo = Nequipo;

        }
        public string Nequipo
        {
            get { return _Nequipo; }
        }
        public void Agregar(string nombre , int numero)
        {
            listajugadore.Add(new Jugador(nombre, numero));
        }
        public void Eliminar(int posicion)
        {
            listajugadore.RemoveAt(posicion);
        }
        public override string ToString()
        {
            return "El equipo: " + Nequipo;
        }
    }
}
