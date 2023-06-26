using metodos_crud.Models;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Agregar Clientes:");
        agregarCliente("Kevin",
                        "Taffur",
                        "Ecuador",
                        1234567890,
                        new DateTime(1998, 01, 01, 0, 0, 0),
                        "Soltero");
        agregarCliente("Maria",
                        "Velez",
                        "Ecuador",
                        1234567890,
                        new DateTime(1998, 01, 01, 0, 0, 0),
                        "Soltera");
        agregarCliente("Julia",
                        "Perez",
                        "Ecuador",
                        1234567890,
                        new DateTime(1998, 01, 01, 0, 0, 0),
                        "Soltera");

        Console.WriteLine("Consultar Clientes:");
        consultarClientes();

        Console.WriteLine("Actualizar Cliente:");
        actualizarCliente(1, "Pepe", "Mejía", "Perú", 1234509867, "Casado");

        Console.WriteLine("Eliminar Cliente:");
        eliminarCliente(3);

        Console.WriteLine("Clientes luego de todos los procesos:");
        consultarClientes();
    }

    public static void agregarCliente(string nombre,
                                        string apellido,
                                        string direccion,
                                        int telefono,
                                        DateTime fechaNacimiento,
                                        string estado)
    {
        ClientContext context = new ClientContext();
        Cliente cliente = new Cliente();
        cliente.nombre = nombre;
        cliente.apellido = apellido;
        cliente.direccion = direccion;
        cliente.telefono = telefono;
        cliente.fechaNacimiento = fechaNacimiento;
        cliente.estado = estado;
        context.Clientes.Add(cliente);
        context.SaveChanges();

        Console.WriteLine("Cliente: " + cliente.nombre + " " + cliente.apellido +
            ", Dirección: " + cliente.direccion + ", Teléfono: " + cliente.telefono + ", Estado: " + cliente.estado);

    }

    public static void consultarClientes()
    {
        ClientContext context = new ClientContext();
        List<Cliente> clientes = context.Clientes.ToList();

        foreach (var cliente in clientes)
        {
            Console.WriteLine("Cliente: " + cliente.nombre + " " + cliente.apellido +
            ", Dirección: " + cliente.direccion + ", Teléfono: " + cliente.telefono + ", Estado: " + cliente.estado);
        }

    }
    public static void actualizarCliente(int id,
                                            string nombre,
                                            string apellido,
                                            string direccion,
                                            int telefono,
                                            string estado)
    {
        ClientContext context = new ClientContext();
        Cliente cliente = new Cliente();
        cliente = context.Clientes.Find(id);

        cliente.nombre = nombre;
        cliente.apellido = apellido;
        cliente.direccion = direccion;
        cliente.telefono = telefono;
        cliente.estado = estado;
        context.SaveChanges();
        Console.WriteLine("Cliente: " + cliente.nombre + " " + cliente.apellido +
            ", Dirección: " + cliente.direccion + ", Teléfono: " + cliente.telefono + ", Estado: " + cliente.estado);

    }

    public static void eliminarCliente(int id)
    {
        ClientContext context = new ClientContext();
        Cliente cliente = new Cliente();
        cliente = context.Clientes.Find(id);
        context.Remove(cliente);
        context.SaveChanges();
    }
}