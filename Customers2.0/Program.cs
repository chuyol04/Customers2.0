using Customers2._0;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;

class Program
{
    static void Main(string[] args)
    {
        var serviceProvider = new ServiceCollection()
            .AddDbContext<CustomerDbContext>(options =>
            {
                options.UseSqlServer("Server=DESKTOP-40GHGG8\\CHUYOL04;Database=CustomerInnova1;TrustServerCertificate=True;Trusted_Connection=True;");
            })
            .BuildServiceProvider();

        using var context = serviceProvider.GetRequiredService<CustomerDbContext>();


        // Crear un nuevo cliente y agregarlo a la base de datos
        var nuevosClientes = new List<Customer>
        {
            new Customer
            {
                Id = 10, // Asigna un valor válido para CustomerId
                Name = "Juan",
                Age = 35,
                Email = "test1.com"
            },
            new Customer
            {
                Id = 11,
                Name = "María",
                Age = 28,
                Email = "test1.com"
            },
            new Customer
            {
                Id = 12,
                Name = "Doe",
                Age = 40,
                Email = "test1.com"
            }
        };

        context.Customers.AddRange(nuevosClientes);
        context.SaveChanges();


        var clientesMayoresDe30 = context.Customers
            .Where(c => c.Age > 30)
            .ToList();

        Console.WriteLine("Clientes mayores de 30 años:");
        foreach (var cliente in clientesMayoresDe30)
        {
            Console.WriteLine($"Nombre: {cliente.Name}, Edad: {cliente.Age}");
        }

        var clientesConDoe = context.Customers
            .Where(c => c.Name.Contains("Doe"))
            .ToList();

        Console.WriteLine("Clientes cuyo nombre contiene 'Doe':");
        foreach (var cliente in clientesConDoe)
        {
            Console.WriteLine($"Nombre: {cliente.Name}, Edad: {cliente.Age}");
        }


    }
}
