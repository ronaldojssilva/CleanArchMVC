using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchMvc.Domain.Account
{
    internal interface ISeedUserRoleInitial
    {
        void SeedUsers();
        void SeedRoles();
    }
}
