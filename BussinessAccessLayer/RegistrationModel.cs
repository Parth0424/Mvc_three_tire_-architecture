﻿using System;

namespace BussinessAccessLayer
{
    public class RegistrationModel
    {
        public int id { get; set; }
        public string Firstname { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
