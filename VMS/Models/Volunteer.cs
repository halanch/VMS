using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VMS.Models;

namespace VMS.Models
{
    public class Volunteer
    {
        public Volunteer()
        {

        }
        long _VolunteerID;
        string _IqamaNo;
        string _FName;
        string _Email;
        string _MobileNo;
        string _PhoneNo;
        string _CurrentAddress;
        string _PermanentAddress;
        DateTime _DateofBirth;
        string _Gender;

        public string VolunteerID
        {
            get
            {
                return _VolunteerID;
            }

            set
            {
                _VolunteerID = value;
            }
        }

        public string IqamaNo
        {
            get
            {
                return _IqamaNo;
            }

            set
            {
                _IqamaNo = value;
            }
        }

        public string FName
        {
            get
            {
                return _FName;
            }

            set
            {
                _FName = value;
            }
        }

        public string Email
        {
            get
            {
                return _Email;
            }

            set
            {
                _Email = value;
            }
        }

        public string MobileNo
        {
            get
            {
                return _MobileNo;
            }

            set
            {
                _MobileNo = value;
            }
        }

        public string PhoneNo
        {
            get
            {
                return _PhoneNo;
            }

            set
            {
                _PhoneNo = value;
            }
        }

        public string CurrentAddress
        {
            get
            {
                return _CurrentAddress;
            }

            set
            {
                _CurrentAddress = value;
            }
        }

        public string PermanentAddress
        {
            get
            {
                return _PermanentAddress;
            }

            set
            {
                _PermanentAddress = value;
            }
        }

        public DateTime DateofBirth
        {
            get
            {
                return _DateofBirth;
            }

            set
            {
                _DateofBirth = value;
            }
        }

        public string Gender
        {
            get
            {
                return _Gender;
            }

            set
            {
                _Gender = value;
            }
        }

    }

    public class VolunteerAction
    {
        public Volunteer Login(string UserName,string Password)
        {
            Volunteer v= new Volunteer();

            return v;
        }

        public bool Register(Volunteer v)
        {
            return false;
        }
    }
}