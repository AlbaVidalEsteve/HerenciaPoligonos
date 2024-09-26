using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionHospital
{
    
    internal class Hospital
    {
        List<Persona> ListaPersonas { get; set; }
        public List<Cita> ListaCitas { get; set; }
        public Hospital()
        {
            ListaPersonas = new List<Persona>();
            ListaCitas = new List<Cita>();
        }

        public void AñadirMedico(string nombre)
        {
            Console.WriteLine("---Escoge especialidad---" +
                "\n [1] Cardiología" +
                "\n [2] General" +
                "\n [3] Neumología" +
                "\n [4] Neurología" +
                "\n [5] Dermatología" +
                "\n [6] Pediatría");
            int opcion = Convert.ToInt32(Console.ReadLine());
            eEspecialidades especialidad = (eEspecialidades)opcion;
            Medico medico = new Medico(nombre, especialidad);
            ListaPersonas.Add(medico);
        }
        public void AñadirPaciente(string nombre,Medico medico)
        {
            Paciente paciente = new Paciente(nombre, medico);
            ListaPersonas.Add(paciente);
        }
        public void AñadirAdministrativo(string nombre)
        {
            Administrativo administrativo = new Administrativo(nombre);
            ListaPersonas.Add(administrativo);
        }
        public void CambiarMedico(Paciente paciente, Medico medicoNuevo)
        {
            if(paciente.MedicoAsignado != medicoNuevo)
            {
                paciente.MedicoAsignado.ListaPacientes.Remove(paciente);
                medicoNuevo.ListaPacientes.Add(paciente);
                paciente.MedicoAsignado = medicoNuevo;
            } else
            {
                Console.WriteLine("El paciente ya tiene asignado este médico.");
            }
        }
        public void MostrarPersonal() 
        {
         Console.WriteLine($"En el hospital hay:{ListaPersonas.Count}");
            foreach(Persona persona in ListaPersonas)
            {
                Console.WriteLine(persona);
            }
        }
        public T BuscarPersona<T>(string nombre) where T : Persona
        {
            return ListaPersonas.OfType<T>().FirstOrDefault(p => p.Nombre == nombre);
        }
        public void DarDeAlta(Paciente paciente, Medico medico)
        {
            if (medico.ListaPacientes.Contains(paciente))
            {
                medico.ListaPacientes.Remove(paciente);
                ListaPersonas.Remove(paciente);

                Console.WriteLine($"Paciente {paciente.Nombre} dado de alta.");
            }
            else
            {
                Console.WriteLine($"El paciente {paciente.Nombre} no está en la lista de este médico.");
            }
        }

        public void DarCita( Medico medico, Paciente paciente)
        {
            Cita cita = new Cita(EscogerFecha(), medico, paciente);
            ListaCitas.Add(cita);

            //medico.ListaCitas.Add(cita);
            //paciente.ListaCitas.Add(cita);
        }

        public void ModificarCita(List<Cita> citas)
        {

        }
        

        public List<Cita> ConsultarCitas(Persona persona)
        {
            switch (persona)
            {
                case Medico m:
                    var citasMedico = ListaCitas.Where(c => c.Medico == m).ToList();
                    if (citasMedico.Count > 0)
                    {
                        Console.WriteLine($"Citas del médico {m.Nombre}:");
                        foreach (var (cita, index) in citasMedico.Select((cita, index) => (cita, index)))
                        {
                            Console.WriteLine($"[{index + 1}] Paciente: {cita.Paciente.Nombre}, Fecha: {cita.Fecha}");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"El médico {m.Nombre} no tiene citas.");
                    }
                    return citasMedico;

                case Paciente p:
                    var citasPaciente = ListaCitas.Where(c => c.Paciente == p).ToList();
                    if (citasPaciente.Count > 0)
                    {
                        Console.WriteLine($"Citas del paciente {p.Nombre}:");
                        foreach (var (cita, index) in citasPaciente.Select((cita, index) => (cita, index)))
                        {
                            Console.WriteLine($"[{index + 1}] Médico: {cita.Medico.Nombre}, Fecha: {cita.Fecha}");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"El paciente {p.Nombre} no tiene citas.");
                    }
                    return citasPaciente;

                default:
                    Console.WriteLine("La persona no es un médico ni un paciente.");
                    return new List<Cita>();
            }
        }

        public void CancelarCita(List<Cita> citas)
        {
            if (citas.Count > 1)
            {
                Console.WriteLine("Escoge la cita que quieres cancelar: ");
                int seleccion = Convert.ToInt32(Console.ReadLine());


            }

        }
        public DateTime EscogerFecha()
        {
            int diaMes, mes, año, hora, minutos;

            Console.WriteLine("Escoge el día del mes: (Número)");
            while (!int.TryParse(Console.ReadLine(), out diaMes) || diaMes < 1 || diaMes > 31)
            {
                Console.WriteLine("Por favor, introduce un día válido (1-31).");
            }

            Console.WriteLine("Escoge el mes: (Número)");
            while (!int.TryParse(Console.ReadLine(), out mes) || mes < 1 || mes > 12)
            {
                Console.WriteLine("Por favor, introduce un mes válido (1-12).");
            }

            Console.WriteLine("Escoge el año: (Número)");
            while (!int.TryParse(Console.ReadLine(), out año) || año < 1)
            {
                Console.WriteLine("Por favor, introduce un año válido (mayor que 0).");
            }

            Console.WriteLine("Escoge la hora: (Número)");
            while (!int.TryParse(Console.ReadLine(), out hora) || hora < 0 || hora > 23)
            {
                Console.WriteLine("Por favor, introduce una hora válida (0-23).");
            }

            Console.WriteLine("Escoge los minutos: (Número)");
            while (!int.TryParse(Console.ReadLine(), out minutos) || minutos < 0 || minutos > 59)
            {
                Console.WriteLine("Por favor, introduce minutos válidos (0-59).");
            }

            
            if (diaMes > DateTime.DaysInMonth(año, mes))
            {
                Console.WriteLine($"El mes {mes} del año {año} solo tiene {DateTime.DaysInMonth(año, mes)} días. Por favor, introduce un día válido.");
                return EscogerFecha();
            }
            DateTime fecha = new DateTime(año, mes, diaMes, hora, minutos, 0);
            return fecha;
        }
    }
}
