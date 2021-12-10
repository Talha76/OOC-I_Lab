using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class SingleRoom: Room
    {
        private bool gaming;
        public int calculate_cost()
        {
            return 2000 + (this.ac ? 500 : 0) + (this.gaming ? 1000 : 0);
        }

        public SingleRoom(string name, string tv, string fridge, string qty, string ac, string gaming)
        {
            this.name = name;
            this.tv = (tv == "" ? 1 : Convert.ToInt32(tv));
            this.fridge = (fridge == "" ? 1 : Convert.ToInt32(fridge));
            this.bed = 1;
            this.ac = (ac == "Yes" ? true : false);
            this.quantity = Convert.ToInt32(qty);
            this.gaming = (gaming == "Yes" ? true : false);
        }
    }
}
