using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Room
    {
        protected string name;
        protected int tv, fridge, bed, quantity;
        protected bool ac;
        public string get_name() { return this.name; }
        public int get_count() { return this.quantity; }
        public void set_count(int quantity) { this.quantity = quantity; }
        protected Room() { }
    }
}