using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class DoubleRoom: Room
    {
        private bool xtra_tv, breakfast;
        public int calculate_cost() {
            return 3500 + (this.ac ? 500 : 0) + (this.xtra_tv ? 1000 : 0) + (this.breakfast ? 1000 : 0);
        }
        public DoubleRoom(string name, string tv, string fridge, string qty, string ac, string xtra_tv, string breakfast)
        {
            this.name = name;
            this.tv = (tv == "" ? 1 : Convert.ToInt32(tv));
            this.fridge = (fridge == "" ? 1 : Convert.ToInt32(fridge));
            this.quantity = Convert.ToInt32(qty);
            this.ac = (ac == "Yes" ? true : false);
            this.xtra_tv = (xtra_tv == "Yes" ? true : false);
            this.breakfast = (breakfast == "Yes" ? true : false);
        }
    }
}
