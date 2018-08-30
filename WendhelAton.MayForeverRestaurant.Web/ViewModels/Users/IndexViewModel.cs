using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WendhelAton.MayForeverRestaurant.Web.Infrastructure.Data.Helpers;
using WendhelAton.MayForeverRestaurant.Web.Infrastructure.Data.Models;

namespace WendhelAton.MayForeverRestaurant.Web.ViewModels.Users
{
    public class IndexViewModel
    {
        public Page<User> Users { get; set; }
    }
}
