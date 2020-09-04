using System;
using System.Text;

namespace Library
{
    public class Doctor
    {
        private string _name;

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
        public Doctor(string name) 
        {
            this.Name = name;
        }

    }
}
