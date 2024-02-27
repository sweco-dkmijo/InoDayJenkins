using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InoDayJenkins
{
	public class TemperatureConverter
	{
		public static float ConvertToFerenhite(float tempInC)
		{
			float tempInF = (tempInC*(float)9/(float)5) + 32;
			return tempInF;
		}
	}
}
