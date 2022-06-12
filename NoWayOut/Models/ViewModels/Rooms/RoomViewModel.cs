using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NoWayOut.Models.ViewModels.Rooms
{
    public class RoomViewModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public double Rent { get; set; }
        public byte[] Photo { get; set; }

    }
}
