using System;
using System.Text;

namespace Library
{
    public class Appointment
    {
        private DateTime _date;
        private string _appoinmentPlace;
        private int _id;
        private Patient _patient;
        private Doctor _doctor;

        public DateTime Date 
        {
            get 
            {
                return this._date;
            }

            set 
            {
                this._date = value;
            }
        }

        public string AppoinmentPlace
        {
            get 
            {
                return this._appoinmentPlace;
            }

            set 
            {
                if(!String.IsNullOrEmpty(value)){
                    this._appoinmentPlace = value;
                }
            }
        }

        public int Id 
        {
            get 
            {
                return this._id;
            }

            set 
            {
                this._id = value;
            }
        }

        public Patient Patient
        {
            get 
            {
                return this._patient;
            }

            set 
            {
                this._patient = value;
            }
        }

        public Doctor Doctor
        {
            get 
            {
                return this._doctor;
            }

            set 
            {
                this._doctor = value;
            }
        }
        
        public Appointment(Patient patient, DateTime date, string appoinmentPlace, Doctor doctor, int id){
            this.Patient = patient;
            this.Date = date;
            this.AppoinmentPlace = appoinmentPlace;
            this.Doctor = doctor;
            this.Id = id;
        }
    }
}
