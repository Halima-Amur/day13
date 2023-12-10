using System;
namespace day13
{
	public static class IntegerMiror
	{
		public static int Miror(this int Number)
		{
			int result = 0, reminder;
			while(Number != 0)
			{
                reminder = Number % 10;

				result = result * 10 + reminder;
				Number = Number / 10;

            }
			return result;
        }
	}
}

