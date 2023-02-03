using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeketeJanos
{
    class Kartya
    {

		public int MyProperty
		{
			get {
				string[] s = src.Split('.');
				return int.Parse(s[0])%13 == 0? 13 : int.Parse(s[0]) % 13;
			}
		}

		public string src { get; set; }

		


		public Kartya(int num)
		{
			src = $"{num}.png";
		}
    }
}
