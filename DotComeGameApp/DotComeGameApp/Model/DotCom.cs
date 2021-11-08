using System;
using System.Collections.Generic;
using System.Linq;
namespace DotComeGameApp.Model
{
    class DotCom
    {
        public string name="abc";
        public string[] locationCells= { "0","0","0"};
        public string CheckGuessForEachDotCom(string guess,string result)
        {
            for (int i = 0;i < locationCells.Length;i++)
            {
                if (guess==locationCells[i]) {
                    result = "hit";
                    List<string> locationList = locationCells.ToList();
                    locationList.Remove(guess);
                    locationCells = locationList.ToArray();
                    break;
                }
                else
                {
                    result = "miss";
                }
            }
            if (locationCells.Length == 0)
            {
                result = "kill";
            }
            return result;
        }
        public void SetLocationCells() {
            string[] dimensions = { "v", "h" };
            Random randomValueGenerator = new Random();
            string dimensionChoice = dimensions[randomValueGenerator.Next(dimensions.Length)];
            string characters = "abcde";
            char randomCharacter = characters[randomValueGenerator.Next(characters.Length)];
            int randomNumber = randomValueGenerator.Next(0, 4);
            
            if (dimensionChoice=="v")
            {
                for(int i = 0; i < this.locationCells.Length; i++)
                {
                    this.locationCells[i] = Convert.ToString(randomCharacter) + Convert.ToString(randomNumber);
                    randomCharacter++;
                }
            }
            else
            {
                for (int i = 0; i < this.locationCells.Length; i++)
                {
                    this.locationCells[i] = Convert.ToString(randomCharacter) + Convert.ToString(randomNumber);
                    randomNumber++;
                }
            }
            foreach (string s in this.locationCells)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("--------");
        }
    }
}
