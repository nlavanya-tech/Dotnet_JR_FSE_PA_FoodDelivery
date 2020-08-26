using FoodDeliveryMvcApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FoodDeliveryMvcApp.BusinessLayer.Services.Repository
{
    public interface IRestorentRepository
    {
        Task<Restorents> RestorentCreateAsync(Restorents restorent);
        Task<FoodIteam> FooditemCreateAsync(FoodIteam fooditem);
    }
}
