using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_APIs_2910
{
    public class Monster
    {

        public Data data { get; set; }

        public Monster() { }       

        public Monster(Data data)
        {
            this.data = data; 
        }

        public override string ToString()
        {
            string monsterString = "";

            return monsterString;
        }

    }
}
