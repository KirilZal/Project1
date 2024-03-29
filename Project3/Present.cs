using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    class Present<T> where T : ICreat
    {
        private static Dictionary<string,DateTime>GiftNow=new Dictionary<string,DateTime>();

        private string Gift { get; }
           

        public Present(string gift)
        {
            Gift = gift;
        }
        public void OpenBAG(T creature)
        {
            if (!GiftNow.ContainsKey(creature.Name) || (DateTime.Now - GiftNow[creature.Name]).TotalDays >= 1) 
            {
                Console.WriteLine($"{creature.Name}відкрив мішок та знайшов {Gift}");
                GiftNow[creature.Name] = DateTime.Now;
            }
            else
            {
                Console.WriteLine($"{creature.Name} - вже отримав подарунок ");
            }
            
        }
    }
}
