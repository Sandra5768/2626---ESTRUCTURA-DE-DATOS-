public class Conjuntos
{
    private HashSet<string> equipos = new HashSet<string>();
 
    public void RegistrarEquipo(string nombre)
    {
        if (equipos.Add(nombre))
        {
            Console.WriteLine("Equipo registrado correctamente.");
        }
        else
        {
            Console.WriteLine("El equipo ya se encuentra registrado.");
        }
    }
 
    public HashSet<string> ObtenerEquipos()
    {
        return equipos;
    }
}