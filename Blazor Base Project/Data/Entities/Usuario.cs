using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor_Base_Project.Data.Entities
{
    public class Usuario :BaseDal
    {
        public string Login { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
    }
}
