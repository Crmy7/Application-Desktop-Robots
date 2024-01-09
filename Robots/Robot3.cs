using System;
namespace Robots3
{
	public class Robot3
	{
		public string Name { get; set; }
		public int Year { get; set; }
		public int X { get; set; }
		public int Y { get; set; }


		public Robot3(string name, int year, int x, int y )
		{
			Name = name;
			Year = year;
			X = x;
			Y = y;
		}

		 public override string ToString()
		{
			return $"Robot Name: {Name}, Year: {Year}, Position: ({X}, {Y})";
		}

	}
}

