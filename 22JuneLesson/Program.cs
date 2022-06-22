using System;
using System.Collections.Generic;

namespace _22JuneLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            Appointment a1 = new Appointment()
            {
                Doctor = "kemale",
                Patient = "kemalee",
                StartDate = new DateTime(2022, 5, 5),
                EndDate = new DateTime(2022, 5, 6)
            };

            Appointment a2 = new Appointment()
            {
                Doctor = "kemale",
                Patient = "salam",
                StartDate = new DateTime(2022, 5, 2),
                EndDate = new DateTime(2022, 5, 4)
            };

            Appointment a3 = new Appointment()
            {
                Doctor = "elnur",
                Patient = "qweqwe",
                StartDate = new DateTime(2022, 5, 5),
                EndDate = new DateTime(2022, 5, 6)
            };

            Appointment a4 = new Appointment()
            {
                Doctor = "nazim",
                Patient = "hikmet",
                StartDate = new DateTime(2022, 3, 12),
                EndDate = new DateTime(2022, 3, 13)
            };

            Appointment a5 = new Appointment()
            {
                Doctor = "george",
                Patient = "washington",
                StartDate = new DateTime(2022, 5, 5)
                
            };

            Appointment a6 = new Appointment()
            {
                Doctor = "steve",
                Patient = "jobs",
                StartDate = new DateTime(2022, 5, 5),
                
            };

            Hospital saglamaile = new Hospital();
            saglamaile.AddAppointment(a1);
            saglamaile.AddAppointment(a2);
            saglamaile.AddAppointment(a3);
            saglamaile.AddAppointment(a4);
            saglamaile.AddAppointment(a5);
            saglamaile.AddAppointment(a6);


     InputAnswer:
            Console.WriteLine("1. Appointment yarat");
            Console.WriteLine("2. Appointment bitir");
            Console.WriteLine("3. Appointmentlere bax");
            Console.WriteLine("4. Bu hefteki apppointmentlere bax");
            Console.WriteLine("5. Bu gunki appointmentlere bax");
            Console.WriteLine("6. Bitmemis appointmentlere bax");
            Console.WriteLine("7. Menudan cix");

            string answerString = "";
            int answerInt = 0;
            int f = 0;
            while (f == 0)
            {
                answerString = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(answerString) && int.TryParse(answerString, out answerInt))
                {
                    answerInt = int.Parse(answerString);
                    break;
                }
            }

            if (answerInt == 1)
            {
                Appointment appointment;
                Console.WriteLine("xestenin adini daxil edin");
                string optionPatient = "";
                while (f == 0)
                {
                    optionPatient = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(optionPatient))
                    {
                        break;
                    }
                }
                Console.WriteLine("hekimin adini daxil edin");
                string optionDoctor = "";
                while (f == 0)
                {
                    optionDoctor = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(optionDoctor))
                    {
                        break;
                    }
                }
                Console.WriteLine("appointmentin baslama tarixini daxil edin yyyy/mm/dd hh:mm");
                string optionStartDateString = "";
                DateTime optionStartDate = new DateTime(1,1,1);
                while (f == 0)
                {
                    optionStartDateString = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(optionStartDateString) && DateTime.TryParse(optionStartDateString, out optionStartDate))
                    {
                        optionStartDate = DateTime.Parse(optionStartDateString);
                        break;
                    }
                }
         InputEndDate:
                Console.WriteLine("appointmentin bitme tarixini daxil edin - appointment hele de davam edirse bos buraxin");
                string optionEndDateString = null;
                DateTime optionEndDate = new DateTime();
                optionEndDateString = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(optionEndDateString))
                {
                     appointment = new Appointment()
                    {
                        Doctor = optionDoctor,
                        Patient = optionPatient,
                        StartDate = optionStartDate,
                        EndDate = null
                    };
                }
                else if (DateTime.TryParse(optionEndDateString, out optionEndDate))
                {
                    optionEndDate = DateTime.Parse(optionEndDateString);

                     appointment = new Appointment()
                    {
                        Doctor = optionDoctor,
                        Patient = optionPatient,
                        StartDate = optionStartDate,
                        EndDate = optionEndDate
                    };
                }
                else
                {
                    Console.WriteLine("bitme tarixini sehv qeyd etmisiniz..");
                    goto InputEndDate;
                }
                saglamaile.AddAppointment(appointment);
                Console.WriteLine("elave olundu!");
                goto InputAnswer;
            }
            else if (answerInt == 2)
            {
                InputNumberCheck:
                Console.WriteLine("appointmentin nomresini yaz");
                string optionNumber = Console.ReadLine();
                bool checkNumberConvertion = int.TryParse(optionNumber, out int optionNumberInt);
                Appointment foundAppointment = saglamaile.Appointments.Find(x => x.No == optionNumberInt);
                if (checkNumberConvertion && foundAppointment != null && foundAppointment.EndDate == null)
                {
                    foundAppointment.EndDate = DateTime.Now;
                    Console.WriteLine("ugurlu emeliyyat!");
                    goto InputAnswer;
                }
                else
                {
                    Console.WriteLine("xeta bas verdi yeniden yoxlayin.");
                    goto InputNumberCheck;
                }
            }
            else if (answerInt == 3)
            {
                foreach (var item in saglamaile.Appointments)
                {
                    Console.WriteLine($"{item.No} nomreli appointment: {item.Doctor} - {item.Patient}");
                }
                goto InputAnswer;
            }
            else if (answerInt == 4)
            {
                saglamaile.GetWeeklyAppointments();
                goto InputAnswer;
            }
            else if (answerInt == 5)
            {
                saglamaile.GetTodaysAppointments();
                goto InputAnswer;
            }
            else if (answerInt == 6)
            {
                saglamaile.GetAllContinuingAppointments();
                goto InputAnswer;
            }
            else if (answerInt == 7)
            {
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("prosesde xeta. yeniden yoxla.");
                goto InputAnswer;
            }





        }
    }
}

