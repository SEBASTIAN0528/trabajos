using mvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace mvc.service
{
    public class promedioservice
    {

        public List<Promedio> Obtenerpromedios()
        {
            var prom11 = new Promedio()
            {

                Nombre = "juan",
                Apellido = "gomez",
                Nota = 2.0,
                materia = "Matematicas"

            };
            var prom12 = new Promedio()
            {

                Nombre = "dario",
                Apellido = "torres",
                Nota = 3.4,
                materia = "Matematicas"

            };
            var prom13 = new Promedio()
            {

                Nombre = "david",
                Apellido = "monroy",
                Nota = 4.1,
                materia = "Matematicas"

            };
            var prom14 = new Promedio()
            {

                Nombre = "kevin",
                Apellido = "gomez",
                Nota = 3.8,
                materia = "Matematicas"

            };
            var prom15 = new Promedio()
            {

                Nombre = "ronald",
                Apellido = "albarracin",
                Nota = 4.4,
                materia = "Matematicas"

            };

            return new List<Promedio> { prom11, prom12, prom13, prom14, prom15 };
        }
    }
}