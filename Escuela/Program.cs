public class Persona
{
    public String Nombre { get; set; }
    public String Cedula { get; set; }  
    public DateTime FechaNacimiento { get; set; }
}

public class Estudiante : Persona
{
    public int NumeroEnClase { get; set; }
    public String ClaseId { get; set; }

}

public class Profesor : Persona
{
    public List<Curso> Cursos { get; set; } = new List<Curso>();
}
public class Clase
{
    public string Identificador { get; set; }
    public List<Profesor> Profesores { get; set; } = new List<Profesor>();
    public List<Estudiante> Estudiantes { get; set; } = new List<Estudiante>();
}

public class Curso
{
    public string Nombre { get; set; }
    public int RecuentoClases { get; set; }
    public int RecuentoEjercicios { get; set; }
}
