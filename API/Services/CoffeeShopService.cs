using API.Models;
using DataAccess.Data;
using Microsoft.EntityFrameworkCore;

namespace API.Services
{
    public class CoffeeShopService : ICoffeShopService
    {
        public ApplicationDbContext DbContext { get; }

        public CoffeeShopService(ApplicationDbContext dbContext)
        {
            DbContext = dbContext;
        }

        public async Task<List<CoffeeShopModel>> List()
        {
            return await (from shop in DbContext.CoffeeShops
                          select new CoffeeShopModel()
                          {
                              Id = shop.Id,
                              Name = shop.Name,
                              OpeningHours = shop.OpeningHours,
                              Address = shop.Address
                          }).ToListAsync();
        }
    }
}