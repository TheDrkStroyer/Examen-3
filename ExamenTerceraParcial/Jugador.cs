using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenTerceraParcial
{
    public class Jugador
    {
        private string _Nombre;
        private int _Numero;
        public Jugador(string Nombre, int Numero)
        {
            _Nombre = Nombre;
            _Numero = Numero;
        }

        public string Nombre
        {
            get { return _Nombre; }
        }

        public int Numero
        {
            get { return _Numero; }
        }
        public override string ToString()
        {
            return "El jugador " + Nombre + " y su numero es " + Numero;
        }
    }
}
