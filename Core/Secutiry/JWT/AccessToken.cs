﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Secutiry.JWT
{
    public class AccessToken
    {
        public string Token { get; set; }
        public DateTime Expiration { get; set; }

    }
}
