﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TaskPerson
{
    class Phone
    {
        private string _phoneNumber;
        private string _phoneType;

        public Phone()
        {
            _phoneNumber = "000";
        }
        public Phone(string phoneNumber)
        {
            _phoneNumber = phoneNumber;
            PhoneType = Utils.GetPhotoType();
        }

        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set
            {
                if (value.Length == 0)
                    _phoneNumber = "001";
                else
                    _phoneNumber = value;
            }
        }

        public string PhoneType
        {
            get { return _phoneType; }
            set { _phoneType = value; }
        }


        //Methods

        
        


    }
}
