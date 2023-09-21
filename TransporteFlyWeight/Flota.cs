using System;
using TransporteFlyWeight.Flyweight;
using TransporteFlyWeight.Models;

namespace TransporteFlyWeight
{
	public class Flota
	{
		private List<Vehiculo> flota = new List<Vehiculo>();
		private FlyweightFactory factory = new FlyweightFactory();

		public void AgregarVehiculo(string matricula, string DNI, string marca, string modelo, string color)
		{
			flota.Add(new Vehiculo
			{
				Matricula = matricula,
				DNI = DNI,
				SharedData = factory.GetSharedData(marca, modelo, color)
			});
		}

		public void MostrarFlota()
		{
			flota.ForEach(v => Console.WriteLine(v.Serialize()));
		}

		public void MostrarFactory()
		{
			factory.ShowFlyweights();
		}
	}
}

