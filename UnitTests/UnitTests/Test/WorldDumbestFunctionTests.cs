using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests.Test
{
    public static class WorldDumbestFunctionTests
    {
        public static void WorldDumbestFunction_ReturnsPokemon_RetrunString()
        {
            try
            {
                //Arrange
                int number = 0;
                WorldDumbestFunction worldDumbestFunction = new WorldDumbestFunction();

                //Act
                string result = worldDumbestFunction.ReturnsPokemon(number);

                //Assert
                if (result == "Pikachu")
                {
                    Console.WriteLine("PASSED!");
                }
                else
                {
                    Console.WriteLine("FAILED!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
