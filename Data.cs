using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_APIs_2910
{
    public class Data
    {
        public string category { get; set; }
        public List<string> common_locations { get; set; }
        public string description { get; set; }
        public bool dlc { get; set; }
        public List<string> drops { get; set; } //this only is in monsters and creatures
        public int id { get; set; }
        public string image { get; set; } //not using
        public string name { get; set; }

        //this is the extra stuff for equipment
        public Equipment properties { get; set; }
        //this actually might need to be it's own class with stats

        //extra stuff for material
        public float hearts_recovered { get; set; }
        public string cooking_effect { get; set; }

        //extra for creature
        public bool edible { get; set; }

        public Data()
        {

        }

        public Data(string category, List<string> common_locations, string description, bool dlc, List<string> drops, int id, string image, string name, Equipment properties, float hearts_recovered, string cooking_effect, bool edible)
        {
            this.category = category;
            this.common_locations = common_locations;
            this.description = description;
            this.dlc = dlc;
            this.drops = drops;
            this.id = id;
            this.image = image;
            this.name = name;
            this.properties = properties;
            this.hearts_recovered = hearts_recovered;
            this.cooking_effect = cooking_effect;
            this.edible = edible;
        }               


        public override string ToString()
        {
            string msg = "";

            msg += $"--------------------------------------\n";

            msg += $"Name: {name}\n";
            msg += $"ID: {id}\n";
            msg += $"Category: {category} \n";

            if (common_locations != null)
            {
                msg += $"Location: {String.Join(", ", common_locations)} \n";
            }

            if (drops != null) //drops only happen sometimes
            {
                msg += $"Drops: {String.Join(", ", drops)} \n";
            }

            if (properties != null)
            {
                msg += $"Properties: {properties}\n";
            }

            if (edible != false)
            {
                msg += $"Edible: {edible}\n";
            }

            if (hearts_recovered != 0)
            {
                msg += $"Hearts Recovered: {hearts_recovered} \n";
            }

            if (cooking_effect != null)
            {
                msg += $"Cooking Effect: {cooking_effect} \n";
            }
            msg += $"DLC: {dlc} \n";

            msg += "\n****** Description ******\n";
            msg += $"{description}\n";

            msg += $"--------------------------------------\n";
            return msg;

        }
    }
}
