using System;
using System.Linq;
using System.Text;

class Peliculas
{

    private string titulo, director, genero;
    private float duracion;

    public Peliculas(string titulo, string director, string genero, float duracion)
    {
        setTitulo(titulo);
        setDirector(director);
        setGenero(genero);
        setDuracion(duracion);

    }
    /*Metdos Modificadores*/
    public void setTitulo(string n) { titulo = n; }
    public void setDirector(string a) { director = a; }
    public void setGenero(string c) { genero = c; }
    public void setDuracion(float e) { duracion = e; }

    /*Metodos Accesores*/
    public String getTitulo() { return titulo; }
    public String getDirector() { return director; }
    public String getGenero() { return genero; }
    public float getDuracion() { return duracion; }

    public void mostrarPelicula()
    {
        Console.Write("\nTitulo:" + getTitulo() + "\nDirector:" + getDirector() + "\nGenero:" + getGenero() + "\nDuracion:" + getDuracion());

    }
}
public class Principal
{
    public static void Main()
    {
        string titulo, director, genero;
        float duracion;
        Console.WriteLine("Favor de ingresar titulo de la pelicula:");
        titulo = Console.ReadLine();
        Console.WriteLine("Favor de ingresar director:");
        director = Console.ReadLine();
        Console.WriteLine("Favor de ingresar genero:");
        genero = Console.ReadLine();
        Console.WriteLine("Favor de ingresar duracion:");
        duracion = float.Parse(Console.ReadLine());
        Peliculas e;
        e = new Peliculas(titulo, director, genero, duracion);
        e.mostrarPelicula();
    }
}