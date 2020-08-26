using FoodDeliveryMvcApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FoodDeliveryMvcApp.BusinessLayer.Interface
{
   public interface IRestorentService
    {
        Task<Restorents> RestorentCreateAsync(Restorents restorent);
        Task<FoodIteam> FooditemCreateAsync(FoodIteam fooditem);

    }
}
