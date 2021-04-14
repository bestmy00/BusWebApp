using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace SchoolBussWebApp.Models
{
    public class CardListViewModel
    {
        public List<BussCard> Cards { get; set; }
        public SelectList SelectBusLine { get; set; }
        public string BusLine { get; set; }
    }
}
