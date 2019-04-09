using System;
using System.Collections.Generic;

namespace ProjectMono.Service.Models
{
    public partial class VehicleModel
    {
        public int Id { get; set; }
        public int MakeId { get; set; }
        public string Name { get; set; }
        public string Abrv { get; set; }

        public virtual VehicleMake VehicleMake { get; set; }
    }
}
