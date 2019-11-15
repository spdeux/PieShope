using PieShop.Models;
using System.Collections.Generic;

namespace PieShop.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Pie> PiesOfTheWeek { get; set; }
    }
}
