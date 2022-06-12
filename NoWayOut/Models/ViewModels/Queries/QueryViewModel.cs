using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NoWayOut.Models.ViewModels.Queries;
using NoWayOut.Models.ViewModels.Rooms;

namespace NoWayOut.Models.ViewModels.Queries
{
    public class QueryViewModel
    {
        public string Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public List<RoomViewModel> Rooms { get; set; }
        public string CreatedBy { get; set; }
        public int FinalPrice { get; set; }
        public string Status { get; set; }

    }
}