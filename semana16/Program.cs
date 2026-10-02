class Program
{
static Grafo grafoCiudades = new Grafo();
static Grafo grafoEstudiantes = new Grafo();

static void Main()
{
    CargarDatos();

    int opcion;

    do
    {
        Console.WriteLine("\n===== GRAFICA DE GRAFOS =====");
        Console.WriteLine("1. Mostrar grafo de ciudades");
        Console.WriteLine("2. Mostrar grafo de estudiantes");
        Console.WriteLine("3. Consultar ciudad");
        Console.WriteLine("4. Consultar estudiante");
        Console.WriteLine("5. Mostrar reporte");
        Console.WriteLine("6. Salir");
        Console.Write("Seleccione una opcion: ");

        opcion = int.Parse(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                Console.WriteLine("\n--- GRAFO DE CIUDADES ---");
                grafoCiudades.MostrarGrafo();
                break;

            case 2:
                Console.WriteLine("\n--- GRAFO DE ESTUDIANTES ---");
                grafoEstudiantes.MostrarGrafo();
                break;

            case 3:
                Console.Write("\nIngrese una ciudad: ");
                string ciudad = Console.ReadLine();
                grafoCiudades.ConsultarVertice(ciudad);
                break;

            case 4:
                Console.Write("\nIngrese un estudiante: ");
                string estudiante = Console.ReadLine();
                grafoEstudiantes.ConsultarVertice(estudiante);
                break;

            case 5:
                MostrarReporte();
                break;

            case 6:
                Console.WriteLine("\nPrograma finalizado.");
                break;

            default:
                Console.WriteLine("\nOpcion no valida.");
                break;
        }

    } while (opcion != 6);
}

static void CargarDatos()
{
    string archivo = "datos_grafos.txt";

    if (!File.Exists(archivo))
    {
        Console.WriteLine("No se encontro el archivo de datos.");
        return;
    }

    string grafoActual = "";

    foreach (string linea in File.ReadAllLines(archivo))
    {
        if (string.IsNullOrWhiteSpace(linea))
            continue;

        if (linea == "GRAFO1")
        {
            grafoActual = "GRAFO1";
            continue;
        }

        if (linea == "GRAFO2")
        {
            grafoActual = "GRAFO2";
            continue;
        }

        string[] datos = linea.Split(';');

        if (datos.Length == 2)
        {
            if (grafoActual == "GRAFO1")
                grafoCiudades.AgregarConexion(datos[0], datos[1]);

            if (grafoActual == "GRAFO2")
                grafoEstudiantes.AgregarConexion(datos[0], datos[1]);
        }
    }
}

static void MostrarReporte()
{
    Console.WriteLine("\n===== REPORTE =====");

    Console.WriteLine("\nGrafo de ciudades:");
    Console.WriteLine("Vertices: " + grafoCiudades.CantidadVertices());
    Console.WriteLine("Conexiones: " + grafoCiudades.CantidadConexiones());

    Console.WriteLine("\nGrafo de estudiantes:");
    Console.WriteLine("Vertices: " + grafoEstudiantes.CantidadVertices());
    Console.WriteLine("Conexiones: " + grafoEstudiantes.CantidadConexiones());
}

}