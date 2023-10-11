using System.Diagnostics.Metrics;
using System.Reflection.Metadata;
using System.Text.Json;
using System.Threading;
using System.Net.Http;
using System.Threading.Tasks;


namespace Lab5_APIs_2910
{
    internal class Program
    {
        public static async Task Main(string[] args)
        {

            //gonna have one that will return only a single entry, then one that will filter by category, then MAYBE one that will filter monsters by their drops


            Console.WriteLine("What function would you like to do?\n1.) Find a single entry\n2.) Show all monsters (WIP)\n3.) Exit\n");
            int userInput = Convert.ToInt32(Console.ReadLine());

            while (userInput != 3)
            {
                switch (userInput)
                {
                    case 1:
                        await SingleEntryCall();
                        //this will correctly change the ToString to only show the items that are not null bc
                        //a monster will not have an attribute for if its edible or not, and so it wont show that
                        //:D
                        break;

                    case 2:
                        await FilterCategoryCall();
                        //IT WORRKSSSSSSSSS
                        break;

                    default:
                        break;

                }

                Console.WriteLine("\nWhat function would you like to do?\n1.) Find a single entry\n2.) Show all monsters\n3.) Exit\n");
                userInput = Convert.ToInt32(Console.ReadLine());

            }


        }//end of main

        //I know that this is lame because you also used monster for the DND example BUT I SWEAR ITS DIFFERENT KINDS OF MONSTERS T-T
        public static async Task SingleEntryCall()
        {
            var client = new HttpClient();

            Console.Write("\nFind entry: ");
            string monster = Console.ReadLine();

            HttpResponseMessage response = await client.GetAsync($"https://botw-compendium.herokuapp.com/api/v3/compendium/entry/{monster}");

            // I think this would work? I don’t see why not if its only for one specific monster

            string json = await response.Content.ReadAsStringAsync();
            var options = new JsonSerializerOptions() { PropertyNameCaseInsensitive = true };

            Monster m = JsonSerializer.Deserialize<Monster>(json, options);
            
            Console.WriteLine($"{m.data.ToString()}");
        }

        public static async Task FilterCategoryCall()
        {
            var client = new HttpClient();
            Console.Write("\nFilter by category: ");
            string category = Console.ReadLine();


            HttpResponseMessage response = await client.GetAsync($"https://botw-compendium.herokuapp.com/api/v3/compendium/category/{category}");
            

            string json = await response.Content.ReadAsStringAsync();

            MonsterMeta monsters = JsonSerializer.Deserialize<MonsterMeta>(json);

            List<Data> monstersList = new List<Data>();
            monstersList = monsters.data.ToList();

            foreach(var item in monstersList)
            {
                Console.WriteLine(item.ToString());
            }

           

        }

       
        
        


    }
}