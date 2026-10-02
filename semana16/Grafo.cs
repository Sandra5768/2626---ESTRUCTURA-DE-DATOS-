public class Grafo
{
private Dictionary<string, List<string>> conexiones =
new Dictionary<string, List<string>>();

public void AgregarVertice(string vertice)
{
    if (!conexiones.ContainsKey(vertice))
    {
        conexiones[vertice] = new List<string>();
    }
}

public void AgregarConexion(string origen, string destino)
{
    AgregarVertice(origen);
    AgregarVertice(destino);

    if (!conexiones[origen].Contains(destino))
    {
        conexiones[origen].Add(destino);
    }

    if (!conexiones[destino].Contains(origen))
    {
        conexiones[destino].Add(origen);
    }
}

public void MostrarGrafo()
{
    foreach (var vertice in conexiones)
    {
        Console.WriteLine(
            $"{vertice.Key} -> {string.Join(", ", vertice.Value)}"
        );
    }
}

public void ConsultarVertice(string vertice)
{
    if (conexiones.ContainsKey(vertice))
    {
        Console.WriteLine(
            $"Vertice: {vertice} | Conexiones: {string.Join(", ", conexiones[vertice])}"
        );
    }
    else
    {
        Console.WriteLine("No se encontró el vertice.");
    }
}

public int CantidadVertices()
{
    return conexiones.Count;
}

public int CantidadConexiones()
{
    int total = 0;

    foreach (var vertice in conexiones)
    {
        total += vertice.Value.Count;
    }

    return total / 2;
}

}