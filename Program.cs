using Fundamentos_de_C__para_Principiantes.Modelos;
using Fundamentos_de_C__para_Principiantes.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos_de_C__para_Principiantes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creando una instancia de Persona desde el namespace Modelos
            Persona persona = new Persona();
            persona.Nombre = "Stiven";
            persona.Edad = 25;

            // Usando el servicio para mostrar la información de la persona
            PersonaService personaService = new PersonaService();
            personaService.MostrarInformacion(persona);
        }
    }
}

// Namespace para el modelo Persona
namespace Fundamentos_de_C__para_Principiantes.Modelos
{
    public class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
    }
}

// Namespace para el servicio que maneja lógica relacionada con Persona
namespace Fundamentos_de_C__para_Principiantes.Servicios
{
    public class PersonaService
    {
        public void MostrarInformacion(Persona persona)
        {
            Console.WriteLine($"Nombre: {persona.Nombre}, Edad: {persona.Edad}");
        }
    }
}
