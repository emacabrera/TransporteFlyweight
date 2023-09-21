using System;
using Newtonsoft.Json;

namespace TransporteFlyWeight.Models
{
	public class Vehiculo
	{
		// extrinseco (no se comparte)
		public string Matricula { get; set; }
		public string DNI { get; set; }

		// intrinseco (se comparte)
		public VehiculoFlyweight SharedData { get; set; }

		public string Serialize()
		{
			return JsonConvert.SerializeObject(this);
		}
	}
}

