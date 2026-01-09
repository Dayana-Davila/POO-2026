 /*definir las propiedades para poder acceder a dichos atributos). 
 * Definir como responsabilidad un método para imprimir.
Plantear una segunda clase Empleado que herede de la clase Persona. 
Añadir un atributo sueldo ( y su propiedad) y el método para imprimir su sueldo.
Definir un objeto de la clase Persona y llamar a sus métodos y propiedades.
También crear un objeto de la clase Empleado y llamar a sus métodos y propiedades.*/

class Persona
{
    // Atributos privados 
    private string nombre;
    private int edad;

    // Propiedades para el Nombre
    public string Nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }

    // Propiedades para la edad
    public int Edad
    {
        get { return edad; }
        set { edad = value; }
    }


    public Persona(string nombre, int edad)
    {
        this.nombre = nombre;
        this.edad = edad;
    }

    public virtual void Imprimir()
    {
        Console.WriteLine($"Nombre: {nombre}, Edad: {edad}");
    }
}

class Empleado : Persona
{
    private double sueldo;

    public double Sueldo
    {
        get { return sueldo; }
        set { sueldo = value; }
    }

    public Empleado(string nombre, int edad, double sueldo) : base(nombre, edad)
    {
        this.sueldo = sueldo;
    }

    public void ImprimirSueldo()
    {
        Console.WriteLine($"Sueldo: {sueldo}");
    }
}    