﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Requests
{
    public class AddAccountRequest
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
