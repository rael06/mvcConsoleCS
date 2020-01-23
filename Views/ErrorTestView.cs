using FrameworkMVC.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvcConsoleCS.Views
{
	public class ErrorTestView : View
	{
		public ErrorTestView(Dictionary<string, object> data) : base(data)
		{
			this.data = data;
		}
		public override void Show()
		{
			Console.WriteLine("erreur de paramètre, veuillez entrer l'URL puis le PORT");
		}
	}
}
