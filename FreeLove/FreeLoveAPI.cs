﻿using StardewValley;
using StardewValley.Locations;
using System.Collections.Generic;

namespace FreeLove
{
    public class FreeLoveAPI
    {
        public void PlaceSpousesInFarmhouse(FarmHouse farmHouse)
        {
            Misc.PlaceSpousesInFarmhouse(farmHouse);
        }
        public static Dictionary<string, NPC> GetSpouses(Farmer farmer, bool all = true)
        {
            return Misc.GetSpouses(farmer, all);
        }
    }
}