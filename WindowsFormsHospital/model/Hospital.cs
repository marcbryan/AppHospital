using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Hospital
    {
        private List<Persona> personas = null;

        //public List<Persona> Personas { get { return personas; } set { personas = value; } }

        private enum eTipoPersona
        {
            medico,
            paciente
        }

        public Hospital() 
        {
            personas = new List<Persona>();
        }

        public void AddMedico(Medico medico)
        {
            personas.Add(medico);
        }

        private int PreguntarPorValorNumerico(string texto)
        {
            bool esNumerico = false;
            int valor = -1;

            while (!esNumerico)
            {
                Console.WriteLine(texto);
                string strValor = Console.ReadLine();

                esNumerico = int.TryParse(strValor, out valor);
            }

            return valor;
        }

        public void AddPaciente(Paciente paciente)
        {
            personas.Add(paciente);
            paciente.Medico.AddPaciente(paciente);
        }

        private List<Persona> ObtenerListaDe(eTipoPersona tipo)
        {
            List<Persona> listaPers = new List<Persona>();
            int contador = 0;

            if (tipo == eTipoPersona.medico)
            {
                foreach (Medico medico in personas.OfType<Medico>())
                {
                    listaPers.Add(medico);
                    contador++;
                }
            }
            else if (tipo == eTipoPersona.paciente)
            {
                foreach (Paciente paciente in personas.OfType<Paciente>())
                {
                    listaPers.Add(paciente);
                    contador++;
                }
            }

            return listaPers;
        }

        public List<Medico> GetMedicos()
        {
            return personas.OfType<Medico>().ToList();
        }

        public List<Paciente> GetPacientes()
        {
            return personas.OfType<Paciente>().ToList();
        }

        public List<Paciente> ObtenerPacientesMedico(int index)
        {
            List<Persona> medicos = ObtenerListaDe(eTipoPersona.medico);
            Medico medico = (Medico) medicos[index];
            return medico.PacientesMedico;
        }

        public void EliminarPaciente(int index)
        {
            List<Persona> listaPacientes = ObtenerListaDe(eTipoPersona.paciente);

            Paciente paciente = (Paciente) listaPacientes[index];

            // Lo eliminamos de la lista de pacientes del médico
            Medico suMedico = paciente.Medico;
            if (suMedico != null)
                suMedico.DesasignarPaciente(paciente);

            // Y lo eliminamos de la lista de personas que están en el hospital
            personas.Remove(paciente);
        }

        public void EliminarMedico(int index)
        {
            List<Persona> listaMedicos = ObtenerListaDe(eTipoPersona.medico);

            Medico medico = (Medico) listaMedicos[index];

            // Eliminamos el médico de cada paciente (de los pacientes del médico que vamos a eliminar)
            foreach (Paciente paciente in medico.PacientesMedico)
                paciente.Medico = null;

            personas.Remove(medico);
        }

        public void MostrarPersonasHospital()
        {
            foreach (var persona in personas)
                Console.WriteLine(persona.ToString());
        }

        public int ContarMedicos()
        {
            return personas.OfType<Medico>().Count();
        }

        public int ContarPacientes()
        {          
            return personas.OfType<Paciente>().Count();
        }
    }
}
