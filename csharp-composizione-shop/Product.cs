﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_composizione_shop
{
	public class Product
	{	
		//ATTRIBUTES + PROPERTIES
		private string code;
		public string Code
		{
			get
			{
				return this.code;
			}
		}

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

		private string description;
		public string Description
		{
			get
			{
				return this.description;
			}
			set
			{
				this.description = value;
			}
		}

		private float price;
		public float Price
		{
			get
			{
				return this.price;
			}
			set
			{
				this.price = value;
			}
		}

		private int tax;
		public int Tax
		{
			get
			{
				return this.tax;
			}
			set
			{
				this.tax = value;
			}
		}

		//CONSTRUCTOR
		public Product(string name, string description, float price, int tax = 22)
		{
			this.name = name;
			this.description = description;
			this.code = getCodePadLeft8();
			this.price = price;
			this.tax = tax;
		}

		//METHODS
		private string getCodePadLeft8()
		{
			Random rnd = new Random();
			int numeroCifre = rnd.Next(1, 9);

			int codeInt = 0;

			switch (numeroCifre)
			{
				case 1:
					codeInt = rnd.Next(1, 10);
					break;
				case 2:
					codeInt = rnd.Next(10, 100);
					break;
				case 3:
					codeInt = rnd.Next(100, 1000);
					break;
				case 4:
					codeInt = rnd.Next(1000, 10000);
					break;
				case 5:
					codeInt = rnd.Next(10000, 1000000);
					break;
				case 6:
					codeInt = rnd.Next(100000, 1000000);
					break;
				case 7:
					codeInt = rnd.Next(1000000, 10000000);
					break;
				case 8:
					codeInt = rnd.Next(10000000, 100000000);
					break;

			}

			string codeString = codeInt.ToString();
			string codeStringPadded = codeString.PadLeft(8, '0');
			return codeStringPadded;

		}





	}
}
