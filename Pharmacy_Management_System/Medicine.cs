using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Management_System
{
    internal class Medicine
    {
        string name;
        string mfg_company;
        string mfg_date;
        string exp_date;
        int quantity;
        int price;

        public string get_name() { return this.name; }
        public int get_count() { return this.quantity; }
        public int get_price() { return this.price; }
        public int get_total_price() { return this.price * this.quantity; }
        public string get_company() { return this.mfg_company; }
        public string get_mfg_date() { return this.mfg_date; }
        public string get_exp_date() { return this.exp_date; }
        public void set_count(int quantity) { this.quantity = quantity; }

        public Medicine(string name, string mfg_company, string mfg_date, string exp_date, string price, string quantity)
        {
            this.name = name;
            this.mfg_company = mfg_company;
            this.mfg_date = mfg_date;
            this.exp_date = exp_date;
            this.price = int.Parse(price);
            this.quantity = int.Parse(quantity);
        }
    }
}
