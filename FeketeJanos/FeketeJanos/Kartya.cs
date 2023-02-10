using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeketeJanos
{
    class Kartya
    {

		public int Value
		{
			get {
				string[] s = src.Split('.');
				int num = int.Parse(s[0]) % 13;
				if (num == 0 || num >= 10)
				{
					return 10;
				}
				else
				{
					return num;
				}
            }
		}

		public string src { get; set; }

		


		public Kartya(int num)
		{
			src = $"{num}.png";
		}
    }
}
