using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace introPOO.clases
{
   public class Persona
    {
        public string cedula;

        public string nombre;

        public string apellido;

        private short edad;

        public short altura;

        public Persona(string _cedula, string _nombre, string _apellido, short _edad, short _altura)
        {
            this.cedula = _cedula;
            this.nombre = _nombre;
            this.apellido = _apellido;
            this.edad = _edad;
            this.altura = _altura;
        }

        public void SetEdad(short valorEdad)
        {
            if(valorEdad >= 0)
            this.edad = valorEdad;
        }

        public short GetEdad()
        {
            return this.edad; 
        }
    }
}
