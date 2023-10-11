using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_APIs_2910
{
    internal class MonsterMeta
    {

        public IList<Data> data { get; set; }
        public MonsterMeta() { }
        public MonsterMeta(IList<Data> d)
        {
            this.data = d;
        }

        public override string ToString()
        {
            string msg = "";

            foreach(var item in data)
            {
                msg += item;
            }

            return msg;
        }


    }
}
