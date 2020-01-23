using FrameworkMVC.Core;
using mvcConsoleCS.Models.Entities;
using System;
using System.Collections.Generic;

namespace mvcConsoleCS.Views
{
	public class HistoryView : View
	{
		public HistoryView(Dictionary<string, object> data) : base(data)
		{
		}

		public override void Show()
		{
			Console.WriteLine("history : ");
			var addresses = (List<Address>)data["addresses"];
			addresses.ForEach(a => DisplayAddress(a));
		}

		private void DisplayAddress(Address address)
		{
			Console.WriteLine($"{address.Url} : {address.Port} est " + (address.Success ? "valide" : "invalide"));
		}
	}
}
