using FrameworkMVC.Core;
using System;
using System.Collections.Generic;

namespace mvcConsoleCS.Views
{
	class HelpView : View
	{
		public HelpView(Dictionary<string, object> data) : base(data)
		{
		}

		public override void Show()
		{
			Console.WriteLine("test : teste une adresse ip et son port, indiquez les paramètres -ip puis -port");
			Console.WriteLine("history : énumère tous les tests effectués");
			Console.WriteLine("help : affiche l'aide");
			Console.WriteLine("Appuyer sur entrée  pour continuer..");
			Console.ReadLine();
		}
	}
}
