﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandType
{
	class Program
	{
		static void Main(string[] args)
		{
			var randPart = RandType.Generate<Part>();
		}
	}

	public class Part
	{
		public int Id { get; set; }

		public string Name { get; set; }

		public DateTime CreatedDate { get; set; }

		public double Value { get; set; }

		private int PrivateProp { get; set; }

		public List<PriceList> PriceLists { get; set; }
	}

	public class PriceList
	{
		public int id { get; set; }

		public string Description { get; set; }

		public decimal Latitude { get; set; }

		public decimal Longitude { get; set; }
	}
}
