using System;
namespace _22JunePracticw
{
	public class Car
	{
		public Car()
		{
			_no = _countno;
			_countno++;

		}
		public string Brand;
		private int _countno = 100;
		private int _no;
		public int No
        {
			get => _no;
        }
		public TimeSpan RaceDurationMinutes;

	}
}

