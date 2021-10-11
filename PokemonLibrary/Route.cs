using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonLibrary
{
    public class Route
    {
        public static string GetRoute()
        {
            string[] routes =
            {
                "A small road leads forward into a clearing, as you approach the clearing you see bug pokemon flying about, it looks as if you are in a pokemon forest. Full of bug pokemon you can almost hear the forest before you see it.",
                "A small oceanside beach with a few patches of tall grass that seem to be rustling in the wind... or by wild pokemon",
                "A quaint path along a field surrounded by plentiful patches of tall grass.",
                "A snowy and icy tundra, you shiver upon entering this route and wish you would have brought a heavier jacket.",
                "A sprawling urban city with pokemon running along roofs and congregating amongst the many alleyways.",
                "A dark cave with small amounts of light thanks to glowing mushrooms. You can see just enough to continue across the path, you hear pokemon skittering just out of your view."
            };

            return routes[new Random().Next(routes.Length)];
        }
    }
}
