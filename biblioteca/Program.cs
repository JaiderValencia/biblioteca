// See https://aka.ms/new-console-template for more information

public class Estanterias
{
    public int id { get; set; }
    public string? nombre { get; set; }
    public Boolean activo { get; set; }

    public List<Estanterias>? _Estaterias { get; set; }
}

public class Niveles
{
    public int id { get; set; }
    public string? nombre { get; set; }
    public int Estanteria { get; set; }

    public Estanterias? _Estanteria { get; set; }
    public List<Libros>? _Libros { get; set; }
}

public class Categorias
{
    public int id { get; set; }
    public string? nombre { get; set; }
    public string? descripcion { get; set; }

    public List<Libros>? _Libros { get; set; }
}

public class Autores
{
    public int id { get; set; }
    public string? nombre { get; set; }
    public string? apellido { get; set; }

    public List<Libros>? _Libros { get; set; }
}

public class Libros
{
    public int id { get; set; }
    public string? nombre { get; set; }
    public DateTime fecha { get; set; }
    public int Categoria { get; set; }
    public int Autor { get; set; }

    public Categorias? _Categoria { get; set; }
    public Autores? _Autor { get; set; }

    public List<NumerosDeSeries>? _NumerosDeSeries { get; set; }
    public List<Niveles>? _Niveles { get; set; }
}

public class NumerosDeSeries
{
    public int id { get; set; }
    public string? numeroSeries { get; set; }
    public int Libro { get; set; }

    public Libros? _Libro { get; set; }
}

public class Niveles_tiene_Libros
{
    public int id { get; set; }
    public int Nivel { get; set; }
    public int Libro { get; set; }

    public Niveles? _Nivel { get; set; }
    public Libros? _Libro { get; set; }
}

public class TiposDocumentos
{
    public int id { get; set; }
    public string? nombre { get; set; }
    public string? nombreCorto { get; set; }

    public List<Clientes>? _Clientes { get; set; }
}

public class Clientes
{
    public int id { get; set; }
    public string? nombre { get; set; }
    public string? apellido { get; set; }
    public string? direccion { get; set; }
    public string? telefono { get; set; }
    public string? correo { get; set; }
    public int TipoDocumento { get; set; }

    public TiposDocumentos? _TipoDocumento { get; set; }
}

public class Prestamos
{
    public int id { get; set; }
    public DateTime fechaInicio { get; set; }
    public DateTime fechaFinal { get; set; }
    public DateTime fechaDevolucion { get; set; }
    public int Cliente { get; set; }
    public int Libro { get; set; }

    public Clientes? _Cliente { get; set; }
    public Libros? _Libro { get; set; }
}