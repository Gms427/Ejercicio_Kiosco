using System;
using System.Text;

namespace Library
{
    public class Patient
    {
        private string _name;
        private string _id;
        private string _phoneNumber;

        public string Name 
        {
            get {
                return this._name;
            }

            set {
                if(!String.IsNullOrEmpty(value))
                {
                    this._name = value;
                }
            }
        }

        public string Id 
        {
            get 
            {
                return this._id;
            }

            set 
            {
                if(!String.IsNullOrEmpty(value)) 
                {
                    this._id = value;
                }
            }
        }

        public string PhoneNumber 
        {
            get 
            {
                return this._phoneNumber;
            }

            set 
            {
                if(!String.IsNullOrEmpty(value)) 
                {
                    this._phoneNumber = value;
                }
            }
        }

        public Patient(string name, string id, string phoneNumber)
        {
            this.Name = name;
            this.Id = id;
            this.PhoneNumber = phoneNumber;
        }
    }
}
