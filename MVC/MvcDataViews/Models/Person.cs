﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcDataViews.Models;

namespace MvcDataViews.Models
{
    public class Person
    {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }
            public string Phone { get; set; }
            public string Email { get; set; }

    }
}