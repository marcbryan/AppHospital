using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Medico : Persona
    {
        private List<Paciente> pacientesMedico = null;

        public List<Paciente> PacientesMedico
        {
            get { return pacientesMedico; } set { pacientesMedico = value; }
        }
        
        public Medico() { }

        public Medico(string nombre, string apellidos, int edad) : base(nombre, apellidos, edad)
        {
            pacientesMedico = new List<Paciente>();
        }

        public void MostrarPacientes()
        {
            foreach (var paciente in pacientesMedico)
                Console.WriteLine(paciente.ToString());
        }

        public void AddPaciente(Paciente paciente)
        {
            pacientesMedico.Add(paciente);
        }

        public void DesasignarPaciente(Paciente paciente)
        {
            pacientesMedico.Remove(paciente);
        }

        public string GetNombreCompleto()
        {
            return Nombre + " " + Apellidos;
        }

        public override string ToString()
        {
            return "{ nombre: " + Nombre + ", apellidos: " + Apellidos + ", edad: " + Edad + ", numPacientes: " + pacientesMedico.Count + " }";
        }
    }
}
