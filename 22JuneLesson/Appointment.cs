using System;
namespace _22JuneLesson
{
	public class Appointment
	{
		public Appointment()
		{
			_no = _count;
			_count++;
		}
		private int _no;
		public int No { get => _no; }
		private static int _count = 1000;
		public string Patient;
		public string Doctor;
		public DateTime StartDate;
		public DateTime? EndDate;

	}
}

