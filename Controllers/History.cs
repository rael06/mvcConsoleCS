﻿using FrameworkMVC.Core;
using mvcConsoleCS.Models.Entities;
using mvcConsoleCS.Repositories;
using System.Collections.Generic;

namespace mvcConsoleCS.Controllers
{
	public class History : Controller
	{
		private AddressRepository addressRepository = new AddressRepository();
		private List<Address> addresses;

		public override string Start()
		{
			addresses = addressRepository.GetAll;
			return "history";
		}

		protected override Dictionary<string, object> GenerateViewData()
		{
			var data = new Dictionary<string, object>();
			data.Add("addresses", addresses);
			return data;
		}
	}
}
