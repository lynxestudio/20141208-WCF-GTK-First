using System;
using System.Text;

namespace Samples.MyFirstWCF.DisplayBitsService
{
	public class DisplayBitsServiceImplementation : IDisplayBitsServiceContract
	{
		public string DisplayToBits (int i)
		{
		int mask = 1 << 31;
		StringBuilder buf = new StringBuilder (35);
		for (int bit = 1; bit <= 32; bit++) 
		{
		buf.Append((i & mask) == 0 ? '0' : '1');
		i <<= 1;
		if(bit % 8 == 0)
		buf.Append(' ');
		}
		return buf.ToString();
		}
	}
}

