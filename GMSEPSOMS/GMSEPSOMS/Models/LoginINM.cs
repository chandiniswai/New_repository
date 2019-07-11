﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GMSEPSOMS.Models
{
    public class LoginINM
    {
       
            [Required(AllowEmptyStrings = false, ErrorMessage = "Please Enter UserName")]
            [StringLength(50, ErrorMessage = "message length exceeded", MinimumLength = 1)]
            public string UserName { get; set; }
            [Required(AllowEmptyStrings = false, ErrorMessage = "Please Enter UserName")]
            public string Pwd { get; set; }
        
    }
}