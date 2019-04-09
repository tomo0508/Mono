using System;
using System.Collections.Generic;

namespace ProjectMono.Service.Models
{
    public partial class VehicleMake
    {
        public VehicleMake()
        {
            VehicleModels = new HashSet<VehicleModel>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Abrv { get; set; }

        public virtual ICollection<VehicleModel> VehicleModels { get; set; }
    }
}
