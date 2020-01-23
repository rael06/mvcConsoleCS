using FrameworkMVC.Core;
using System.Collections.Generic;

namespace mvcConsoleCS.Controllers
{
	public class Help : Controller
	{
		public override string Start()
		{
			return "help";
		}

		protected override Dictionary<string, object> GenerateViewData()
		{
			return null;
		}
	}
}
