using PersonasEmpresaApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonasEmpresaApp.Models
{
    internal class Employee : Person, IEmployee
    {
        public override int IdNumber {  get; set; }
        public override string Name { get; set; }
        public override string LastName { get; set; }
        public override string Gender { get; set; }

        public string occupation { get; set; }
        public string IdEmployee { 
            get 
            {
                return IdCode();
            }
            set 
            {
            } 
        }
        public string FullNameEmployee { 
            get 
            {   
                return FullName();
            }
            set 
            {
            } 
        }
        public string Area { get; set; }
        public string OccupationEmployee { 
            get { 
                return occupation.ToString(); 
            } 
            set 
            {
            } 
        }

        public Employee(int idNumber, string name, string lastName, string gender)
        {
            IdNumber = idNumber;
            Name = name;
            LastName = lastName;
            Gender = gender;
            occupation = Occupation.Other.ToString();
        }

        public Employee(int idNumber, string name, string lastName, string gender, string occupation, string area) : this(idNumber, name, lastName, gender)
        {
            this.occupation = occupation;
            Area = area;
        }

        public override string FullName()
        {
            return base.FullName();
        }

        public override string IdCode()
        {
            return $"{LastName}_{IdNumber}_{Name}";
        }

        public override string PersonalInformation()
        {
            return base.PersonalInformation();
        }
    }
}
