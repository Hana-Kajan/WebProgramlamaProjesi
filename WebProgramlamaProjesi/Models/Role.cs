using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebProgramlamaProjesi.Models
{
    public class Role : IdentityRole
    {
        public Role() :base() { }
        public Role(string name) : base(name) { }
    }
}
