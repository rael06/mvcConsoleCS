using FrameworkMVC.Core;

namespace mvcConsoleCS
{
	class Program
	{
		static void Main(string[] args)
		{
			var paramsNames = new string[] { "controller", "ip", "port" };
			//var app = new AppCore(paramsNames, args);
			var app = new App(paramsNames, args);

			app.Route();
		}
	}
}
