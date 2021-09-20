using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnSiteSolution.Model
{
    public class Clients
    {

        //Message id
        public int Id { get; set; }

        //Mesage text
        public string Name { get; set; }

        //Message sender
        public string Text { get; set; }

        //Message time
        public DateTime time { get; set; }
    }
}
