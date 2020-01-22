using mvcConsoleCS.Models;
using mvcConsoleCS.Models.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;

namespace mvcConsoleCS.Repositories
{
	class AddressRepository
	{
		private Context context = new Context();

		public List<Address> GetAll => context.Addresses.ToList();

		public void Add(Address a)
		{
			context.Addresses.Add(a);
			context.SaveChanges();
		}

		public Address New(string ip, string port)
		{
			var address = new Address();
			address.Url = ip;
			address.Port = int.Parse(port);
			return address;
		}

		public bool Test(Address a)
		{
			var client = new TcpClient();
			try
			{
				client.Connect(a.Url, a.Port);
				a.Success = true;
			}
			catch
			{
				a.Success = false;
			}
			return a.Success;
		}
	}
}
