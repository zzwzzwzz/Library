﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    public class LibrarianUser : User
    {
        public override string GetUserType() => "Librarian";
    }
}
