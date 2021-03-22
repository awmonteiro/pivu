using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Pivu.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the PivuUser class
    public class PivuUserIdentity : IdentityUser
    {
        public string Nome { get; set; }
        public int CPF { get; set; }
        public DateTime Nascimento { get; set; }
        public int id_endereco_pricipal { get; set; }

    }
}
