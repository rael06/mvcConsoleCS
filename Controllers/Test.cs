using FrameworkMVC.Core;
using mvcConsoleCS.Models;
using mvcConsoleCS.Models.Entities;
using mvcConsoleCS.Repositories;
using System.Collections.Generic;

namespace mvcConsoleCS.Controllers
{
	public class Test : Controller
	{
		private Context context = new Context();
		private AddressRepository addressRepository = new AddressRepository();
		public Address address { get; set; }
		public override string Start()
		{
			if (data.ContainsKey("ip") && data.ContainsKey("port"))
			{
				address = addressRepository.New(data["ip"] as string, data["port"] as string);
				address.Success = addressRepository.Test(address);
				addressRepository.Add(address);
				context.SaveChanges();
				return "test";
			}
			else
			{
				return "errorTest";
			}
		}

		protected override Dictionary<string, object> GenerateViewData()
		{
			var data = new Dictionary<string, object>();
			if (address != null)
			{
				data.Add("address", address);
				data.Add("success", address.Success);
			}
			return data;
		}
	}
}
