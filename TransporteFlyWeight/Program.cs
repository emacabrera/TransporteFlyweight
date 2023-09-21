// See https://aka.ms/new-console-template for more information
using TransporteFlyWeight;
using TransporteFlyWeight.Flyweight;
using TransporteFlyWeight.Models;

Flota flota = new Flota();

flota.AgregarVehiculo("ABC123", "123456789", "Fiat", "Cronos", "Negro");
flota.AgregarVehiculo("ABC123", "123456789", "Fiat", "Cronos", "Azul");
flota.AgregarVehiculo("ABC123", "123456789", "Fiat", "Argo", "Negro");
flota.AgregarVehiculo("ABC123", "123456789", "Fiat", "Argo", "Azul");

flota.AgregarVehiculo("ABC123", "123456789", "Fiat", "Cronos", "Negro");
flota.AgregarVehiculo("ABC123", "123456789", "Fiat", "Cronos", "Azul");
flota.AgregarVehiculo("ABC123", "123456789", "Fiat", "Argo", "Negro");
flota.AgregarVehiculo("ABC123", "123456789", "Fiat", "Argo", "Azul");

// Print Information
flota.MostrarFactory();

Console.WriteLine();

flota.MostrarFlota();

Console.ReadKey();