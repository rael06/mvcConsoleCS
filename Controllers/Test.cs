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
		public override void Start()
		{
			address = addressRepository.New(data["ip"] as string, data["port"] as string);
			address.Success = addressRepository.Test(address);
			addressRepository.Add(address);
			context.SaveChanges();
		}

		protected override Dictionary<string, object> GenerateViewData()
		{
			var data = new Dictionary<string, object>();
			data.Add("address", address);
			data.Add("success", address.Success);
			return data;
		}
	}
}
