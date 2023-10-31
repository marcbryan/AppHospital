using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Paciente : Persona
    {
        private Medico medico;

        public Medico Medico { get { return medico; } set { medico = value; } }

        public Paciente(string nombre, string apellidos, int edad, Medico medico) : base(nombre, apellidos, edad)
        {
            this.medico = medico;
        }

        public string GetNombreCompleto()
        {
            return Nombre + " " + Apellidos;
        }

        public override string ToString()
        {
            return GetNombreCompleto() + ", edad: " + Edad;
        }
    }
}
