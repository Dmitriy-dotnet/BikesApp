using Bikes.DAL.Context;
using Bikes.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Bikes.BLL.Services
{
    public class BikeService
    {
        private BikeContext _bikeContext;

        public BikeService(BikeContext bikeContext)
        {
            _bikeContext = bikeContext;
        }

        public async Task<List<Bike>> GetALLBikesAsync()
        {
            var bikes = await _bikeContext.Bikes.ToListAsync();
            return bikes;
        }

        public async Task<Bike> GetBikeAsync(int id)
        {
            var bike = await _bikeContext.Bikes.FirstAsync(x => x.Id == id);
            if (bike == null)
            {
                throw new NullReferenceException();
            }
            else
            {
                return bike;
            }
        }

        public async Task<Bike> CreateBikeAsync(Bike bike)
        {
            await _bikeContext.Bikes.AddAsync(bike);
            await _bikeContext.SaveChangesAsync();
            return bike;
        }

        public async Task DeleteBikeAsync(int id)
        {
            var bike = await _bikeContext.Bikes.FirstAsync(x => x.Id == id);
            if (bike == null)
            {
                throw new NullReferenceException();
            }
            else
            {
                _bikeContext.Bikes.Remove(bike);
                await _bikeContext.SaveChangesAsync();
            }
        } 

        //TODO: Update

        public async Task UpdateBikeAsync(Bike bike)
        {
            var oldBike = await _bikeContext.Bikes.FirstOrDefaultAsync(x => x.Id == bike.Id);
            oldBike.Name = bike.Name;
            oldBike.Price = bike.Price;
            oldBike.BikeType = bike.BikeType;
            oldBike.UpdatedAt = DateTime.Now;
            _bikeContext.Update(oldBike);
            await _bikeContext.SaveChangesAsync();
        }

    }
}
