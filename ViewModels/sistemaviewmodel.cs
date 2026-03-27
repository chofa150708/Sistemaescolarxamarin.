using System.Collections.Generic;
using System.Linq;
public class SistemaViewModel
{

Aquí empieza el código para registrar

las calificaciones

Aquí empieza el código para el
modelo escolar

public List<Alumno> alumnos = new List<Alumno>();
public List<Calificacion> calificaciones = new List<Calificacion>();
public void AgregarAlumno(string nombre)
{
alumnos.Add(new Alumno { Nombre = nombre });
}
public void AgregarCalificacion(string alumno, string materia, double nota)
{
calificaciones.Add(new Calificacion
{
Alumno = alumno,
Materia = materia,
Nota = nota
});
}
public double CalcularPromedio(string alumno)
{
var notas = calificaciones
.Where(c => c.Alumno == alumno)
.Select(c => c.Nota);
return notas.Average();
}
}
