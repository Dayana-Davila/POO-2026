//diseñe una nombre de clase producto con los siguientes atributos privados:
//-codigo (tipo de dato string)
//-descripción
//-precio (tipo doble), y con los metodos publicos get y set.

class Tienda() 
{
    static void Main()
    {
        Producto nuevo = new Producto();
        nuevo.SetPrecio(2.5);
        Console.WriteLine(nuevo.GetPrecio());


        nuevo.SetDescripcion("Computadora");
        Console.WriteLine(nuevo.GetDescripcion());
    }
}//
class Producto //Es el nombre de la clase. La primera letra siempre va en mayúscula
{
    // Atributos (características) privados
    private string codigo; //private es que solo la clase puede usar esos datos, desde otra clase no se puede
    private string descripcion; // a esto se le llama encapsulamiento
    private double precio;

    // Método get y set para codigo
    public string GetCodigo() //Lee el valor del atributo Codigo
    {
        return codigo;
    }

    public void SetCodigo(string codigo) //Se asigna un valor al atributo Codigo. Void no retorna valor 
    {
        this.codigo = codigo;
    }

    // Método get y set para descripcion
    public string GetDescripcion() //Lee el valor del atributo Descripcion
    {
        return descripcion;
    }

    public void SetDescripcion(string descripcion) //Se asigna un valor al atributo Descripcion
    {
        this.descripcion = descripcion;
    }

    // Método get y set para precio
    public double GetPrecio() //Lee el valor del atributo Precio
    {
        return precio;
    }

    public void SetPrecio(double precio) //Se asigna un valor al atributo Precio
    {
        this.precio = precio;
    }

}
