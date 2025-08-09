// EJEMPLO DE COMO CREAR UNA CLASE EN POO
using System;
using Microsoft.VisualBasic;
//Clase que representa un vehiculo
public class Libro
{
    //Atributos de la clase Vehiculo
    public string Nombre { get; set; }
    public string Autor { get; set; }
    public int Anio_Edicion { get; set; }

    //Constructor de la clase Vehiculo
    public Libro(string nombre, string autor, int anio_edicion)
    {
        this.Nombre = nombre;
        this.Autor = autor;
        this.Anio_Edicion = anio_edicion;
    }
    // Metodo para acceder a los atributos
    public string nombre
    {
        get => nombre;
        set => nombre = value;
    }
    public string autor
    {
        get => autor;
        set => autor = value;
    }
    public int anio_edicion
    {
        get => anio_edicion;
        set
        {
            if (value > 1900 && value < DateTime.Now.Year)
            {
                anio_edicion = value;
            }
            else
            {
                throw new ArgumentException("El año debe ser mayor que 1990.");
            }
        }
    }
    //Metodo para mostrar informacion de la clase
    public void MostrarInformacion()
    {
        Console.WriteLine($"Nombre: {Nombre}, Autor: {Autor}, Año de Edición: {Anio_Edicion}");
    }

}
    //CODIGO PARA EVALUAR MI VEHICULO SEGUN EL AÑO
    public class Program
    {
        public static void Main(string[] args)
        {
            var miLibro = new Libro("El Principito", "Antoine de Saint-Exupéry", 1943);
            miLibro.MostrarInformacion();
            miLibro.Anio_Edicion = 1943; // Año válido
            miLibro.MostrarInformacion();
        }
    }