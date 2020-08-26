using FoodDeliveryMvcApp.DataLayer;
using FoodDeliveryMvcApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FoodDeliveryMvcApp.BusinessLayer.Services.Repository
{
    public class RestorentRepository : IRestorentRepository
    {
        private InMemoryDb _DbContext;
        public RestorentRepository(InMemoryDb DbContext)
        {
            _DbContext = DbContext;
        }
        public async Task<Restorents> RestorentCreateAsync(Restorents restorent)
        {
            _DbContext.restorent.Add(restorent);
            _DbContext.SaveChanges();

            return restorent;
        }
        public async Task<FoodIteam> FooditemCreateAsync(FoodIteam fooditem)
        {
            _DbContext.fooditem.Add(fooditem);
            _DbContext.SaveChanges();

            return fooditem;
        }
        
    }
}
