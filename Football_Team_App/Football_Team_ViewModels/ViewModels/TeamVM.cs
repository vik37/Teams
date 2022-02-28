using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football_Team_ViewModels.ViewModels
{
    public class TeamVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Stadium { get; set; }
        public int FoundedYear { get; set; }
        public string History { get; set; }
    }
}
