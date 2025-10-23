using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapsManagerViewModels.ViewModels
{
    public class MapViewModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string DepartmentName { get; set; }
        public string RingBinderName { get; set; }
        public int ShelfNumber { get; set; }
        public int RowNumber { get; set; }

    }
}
