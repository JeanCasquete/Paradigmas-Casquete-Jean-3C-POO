using System;
using System.Collections.Generic;
using System.Linq;

namespace ParadigmaFuncional
{
    class Program
    { //Nombre: Jean Pier Casquete Rodriguez
        //Curso: 3er Nivel C
        //Materia: POO
        public class People
        {
            //creamos la variable name, ciudad y una booleana de si esta persona toma alcohol
            public string Name { get; set; }
            public string ciudad { get; set; }

            public bool TomaAlcohol { get; set; }
        }
        static void Main(string[] args)

        {
            var peoples = new List<People>()
            //Lista de personas
            {
                new People() {Name= "Juan", ciudad= "Manta", TomaAlcohol=true},
                new People() {Name= "Diego", ciudad= "Zapata", TomaAlcohol=true},
                new People() {Name= "Raow", ciudad= "Manta", TomaAlcohol =false},
            };

            //Imperativa
            var namePeopleTomaAlcohol = new List<string>();
            foreach (var people in peoples) 
            {
                //Verificamos si la persona toma alcohol y pedimos que nos diga su nombre en mayusculas
                if (people.TomaAlcohol)
                    namePeopleTomaAlcohol.Add(people.Name.ToUpper());

            }
            //Fucional 
            //este es de una forma declarativa
            //creamos un var de la segunda persona y con la extencion where pedimos que nos diga
            //si este toma alcohol y nos muestre su nombre en mayusculas
            var namePeopleTomaAlcohol2 = peoples.Where(d => d.TomaAlcohol)
                .Select(d => d.Name.ToUpper());
             
            //esa es la difererencia entre imperativa y declarativa
        }   

        
     }
}
