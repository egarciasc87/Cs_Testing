using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests
{
    public class WorldDumbestFunction
    {
        public string ReturnsPokemon(int id)
        {
            if (id == 0)
            {
                return "Pikachu";
            }
            else
            {
                return "Squirtle";
            }
        }
    }
}
