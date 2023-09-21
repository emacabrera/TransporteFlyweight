using System;
using TransporteFlyWeight.Models;

namespace TransporteFlyWeight.Flyweight
{
	public class FlyweightFactory
	{
		private Dictionary<string, VehiculoFlyweight> flyweights
			= new Dictionary<string, VehiculoFlyweight>();


		public VehiculoFlyweight GetSharedData(string marca, string modelo, string color)
		{
			string key = GetKey(marca, modelo, color);

			if (!flyweights.ContainsKey(key))
			{
				Console.WriteLine($"There is no existing sharedData with the key: {key}. Adding new one.");
				flyweights.Add(key, new VehiculoFlyweight
				{
					Marca = marca,
					Modelo = modelo,
					Color = color
				});
			} else
			{
				Console.WriteLine($"sharedData founded for key: {key}. Returning existing one.");
			}

			return flyweights[key];
		}

		public void ShowFlyweights()
		{
			int count = flyweights.Count;
			Console.WriteLine($"List of flyweights: {count}");

			foreach (var fw in flyweights)
			{
				Console.WriteLine($"- {fw.Key}");
			}
		}

		private static string GetKey(string marca, string modelo, string color)
		{
			//return string.Join("_",
			//	sharedData.GetType()
			//	.GetProperties()
			//	.Select(p => p.GetValue(sharedData, null))
			//	.ToList()
			//).ToString();

			return string.Join("_", marca, modelo, color);
		}
	}
}

