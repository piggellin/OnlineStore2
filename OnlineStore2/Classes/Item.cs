﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore2.Classes
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }

        public Item(int id, string name, int price)
        {
            Id = id;

            Name = name;

            Price = price;
        }
    }


}
