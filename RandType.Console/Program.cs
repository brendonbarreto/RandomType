﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace RandType.Console
{
	class Program
	{
		static void Main(string[] args)
		{
			var rand = RandType.Generate<Part>();
		}

		public class Part
		{
			public long Long { get; set; }

			public List<TimeSpan> TimeSpanList { get; set; }

			public byte[] ByteArray { get; set; }

			public byte Byte { get; set; }

			public List<byte> ByteList { get; set; }

			public List<Batata> BatataList { get; set; }

			public Batata[] BatataArray { get; set; }

			public int[] IntArray { get; set; }

			public char Char { get; set; }

			public List<float> Float { get; set; }

			public List<double> DoubleList { get; set; }

			public List<bool> BoolList { get; set; }

			public List<long> LongList { get; set; }

			public List<DateTime> DateList { get; set; }
		}

		public class Batata
		{
			public int Hue { get; set; }
		}
	}
}
