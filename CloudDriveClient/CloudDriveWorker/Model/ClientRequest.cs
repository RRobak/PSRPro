﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudDriveWorker.Model
{
    internal class ClientRequest
    {
        public string Request { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
