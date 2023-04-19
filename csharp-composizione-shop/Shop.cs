using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_composizione_shop
{
	public class Shop
	{
		private string name;
		public string Name
		{
			get
			{
				return this.name;
			}
			set 
			{ 
				this.name = value; 
			}

		}

		private string city;
		public string City
		{
			get
			{
				return this.city;
			}
		}

		private string address;
		public string Address
		{
			get
			{
				return this.address;
			}
		}

		private string houseNumber;
		public string HouseNumber
		{
			get
			{
				return this.houseNumber;
			}
		}

		private List<Product> shopProducts;

		//CONSTRUCTOR
		public Shop(string name, string city, string address, string houseNumber)
		{
			this.name = name;
			this.city = city;
			this.address = address;
			this.houseNumber = houseNumber;
			this.shopProducts = new List<Product>();
		}

	}
}
