using FoodDeliveryMvcApp.BusinessLayer.Interface;
using FoodDeliveryMvcApp.BusinessLayer.Services.Repository;
using FoodDeliveryMvcApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FoodDeliveryMvcApp.BusinessLayer.Services
{
    public class RestorentService: IRestorentService
    {
        private readonly IRestorentRepository _repository;

        public RestorentService(IRestorentRepository repository)
        {
            _repository = repository;
        }
        public async Task<Restorents> RestorentCreateAsync(Restorents restorent)
        {
            var userdetails = await _repository.RestorentCreateAsync(restorent);
            return restorent;

        }
        public async Task<FoodIteam> FooditemCreateAsync(FoodIteam fooditem)
        {
            var userdetails = await _repository.FooditemCreateAsync(fooditem);
            return fooditem;

        }
    }
}
