using FrameworkMVC.Core;
using mvcConsoleCS.Models.Entities;
using System;
using System.Collections.Generic;

namespace mvcConsoleCS.Views
{
	class TestView : View
	{
		public TestView(Dictionary<string, object> data) : base(data)
		{
			this.data = data;
		}

		public override void Show()
		{
			var address = (Address)data["address"];
			bool success = (bool)data["success"];
			Console.WriteLine($"l'adresse : {address.Url} - port : {address.Port} est " + (success ? "valide" : "invalide"));
			Console.WriteLine("Appuyer sur entrée  pour continuer..");
			Console.ReadLine();
		}
	}
}
