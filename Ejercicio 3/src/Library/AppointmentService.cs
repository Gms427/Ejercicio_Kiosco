using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Library
{
    public class AppointmentService
    {
        private List<Appointment> _appointments;

        public List<Appointment> Appointments
        {
            get 
            {
                return this._appointments;
            }

            set
            {
                this._appointments = value;
            }
        }

        public AppointmentService()
        {
            this._appointments = new List<Appointment>();
        }

        public AppointmentService(List<Appointment> appointments)
        {
            this.Appointments = appointments;
        }

        public void AddAppointment(Appointment appointment)
        {
            this._appointments.Add(appointment);
        }

        public int GetUnicAppointmentId()
        {
            return this._appointments.Select(ap => ap.Id).Max();
        }

        public string CreateAppointment(Patient patient, DateTime date, string appoinmentPlace, Doctor doctor)
        {
            StringBuilder stringBuilder = new StringBuilder("Scheduling appointment...\n");

            int appointmentId = GetUnicAppointmentId();

            Appointment appointment = new Appointment(patient, date, appoinmentPlace, doctor, appointmentId);
            this.AddAppointment(appointment);

            stringBuilder.Append("Appoinment Scheduled");

            return stringBuilder.ToString();
        }
    }
}
