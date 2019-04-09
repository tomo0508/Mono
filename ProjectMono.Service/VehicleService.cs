using Microsoft.EntityFrameworkCore;
using ProjectMono.Service.Data;
using ProjectMono.Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectMono.Service
{
    public class VehicleService : IVehicleService
    {
        private readonly VehicleContext _context;

        public VehicleService( VehicleContext context)
        {
           _context = context;
        }

        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
            _context.SaveChanges();
        }

        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
            _context.SaveChanges();
           
        }

        public VehicleMake GetMake(int id)
        {
            var make = _context.VehicleMake
                 .Include(m => m.VehicleModels)
                 .FirstOrDefault(m => m.Id == id);
            return make;
        }

        public IEnumerable<VehicleMake> GetMakes()
        {
          return _context.VehicleMake;
            
        }

        public VehicleModel GetModel(int id)
        {
            var model = _context.VehicleModel
                 .FirstOrDefault(m => m.Id == id);
            return model;
        }

        public IEnumerable<VehicleModel> GetModels()
        {
            return  _context.VehicleModel;
            
        }

        public void Update<T>(T entity) where T : class
        {
            _context.Update(entity);
            _context.SaveChanges();
        }
    }
}
