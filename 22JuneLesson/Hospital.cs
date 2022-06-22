using System;
using System.Collections.Generic;

namespace _22JuneLesson
{
	public class Hospital
	{
		public Hospital()
		{
		}
		public List<Appointment> Appointments = new List<Appointment>();


		public void AddAppointment(Appointment app)
        {
            if (app!=null)
            {
                Appointments.Add(app);
            }
            else
            {
                throw new NullReferenceException();
            }
            
        }
		public void EndAppointment(int no)
        {

            Appointment appointmentFinded = GetAppointment(no);

            if (appointmentFinded.EndDate == null && appointmentFinded != null)
            {
                appointmentFinded.EndDate = DateTime.Now;
            }
        }
		public Appointment GetAppointment(int no)
        {
            Appointment appointmentFinded = Appointments.Find(x => x.No == no);
            return appointmentFinded;
        }
		public void GetAllAppointments()
        {
            foreach (var item in Appointments)
            {
                Console.WriteLine($"{item.No}. {item.Patient} - {item.Doctor} start: {item.StartDate}, end: {item.EndDate}");
            }
        }
		public void GetWeeklyAppointments()
        {
            foreach (var item in Appointments)
            {
                if (item.StartDate > DateTime.Now && item.StartDate < DateTime.Now.AddDays(7))
                {
                    Console.WriteLine($"{item.No}. {item.Patient} - {item.Doctor} start: {item.StartDate}, end: {item.EndDate}");
                }
            }
        }
		public void GetTodaysAppointments()
        {
            foreach (var item in Appointments)
            {
                if (item.StartDate.Day == DateTime.Now.Day)
                {
                    Console.WriteLine($"{item.No}. {item.Patient} - {item.Doctor} start: {item.StartDate}, end: {item.EndDate}");
                }
            }
        }
		public void GetAllContinuingAppointments()
        {
            foreach (var item in Appointments)
            {
                if (item.EndDate == null)
                {
                    Console.WriteLine($"{item.No}. {item.Patient} - {item.Doctor} start: {item.StartDate}, end: {item.EndDate}");
                }
            }

        }
	}
}

