using ProjectMono.Service.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectMono.Service.Data
{
    public interface IVehicleService
    {
        void Add<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        void Update<T>(T entity) where T : class;

        IEnumerable<VehicleMake> GetMakes();
        VehicleMake GetMake(int id);

        IEnumerable<VehicleModel> GetModels();
        VehicleModel GetModel(int id);


    }
}
