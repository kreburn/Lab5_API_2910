using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_APIs_2910
{
    public class Equipment
    {
        public int Attack { get; set; }

        public int Defense { get; set; }

        public Equipment() { }

        public Equipment(int Attack, int Defense)
        {
            this.Attack = Attack;
            this.Defense = Defense;
        }

        public override string ToString()
        {
            string msg = "";

            msg += $"\n     Attack: {Attack}\n";
            msg += $"    Defense: {Defense}";

            return msg;
        }


    }
}
