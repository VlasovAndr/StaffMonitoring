﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployersLibrary
{
    public class Company
    {
        public List<Person> stuff;
        public List<Person> stuffOfficeEmployers
        {
            get
            {
                var stuffOfficeEmployers = new List<Person>();
                var count = stuff.Count;
                for (int i = count - 1; i >= 0; i--)
                {
                    if (stuff[i].IsEntered == true)
                    {
                        stuffOfficeEmployers.Add(stuff[i]);
                    }
                }
                return stuffOfficeEmployers;
            }
        }
        public List<Person> stuffOfficeAbsentEmployers
        {
            get
            {
                List<Person> stuffOfficeAbsentEmployers = new List<Person>();
                stuffOfficeAbsentEmployers = stuff.FindAll(item => item.IsEntered == false);
                return stuffOfficeAbsentEmployers;
            }
        }

        public Company()
        {
            this.stuff = new List<Person>();
        }
        public void AddPerson(Person p)
        {
            stuff.Add(p);
        }

        public void RemovePerson(Person p)
        {
            stuff.Remove(p);
        }

        public void PersonComeIn(Person p)
        {
            p.IsEntered = true;
        }

        public void PersonComeOut(Person p)
        {
            p.IsEntered = false;
        }

    }

    public class Person
    {
        public string FirstName;
        public string LastName;
        public bool IsEntered;
    }

    public class Employer : Person
    {

    }

    public class Director : Person
    {
        public Company firstLineSoftware;
        public ICollection<Person> GetListOfAllOfficeEmployers() => firstLineSoftware.stuffOfficeEmployers;
        public ICollection<Person> GetListOfAllOfficeAbsentEmployers() => firstLineSoftware.stuffOfficeAbsentEmployers;
        public ICollection<Person> GetListOfAllEmployers() => firstLineSoftware.stuff;
    }
}