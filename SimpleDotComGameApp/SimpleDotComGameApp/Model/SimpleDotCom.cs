using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDotComGameApp.Model
{
    class SimpleDotCom
    {
        public int[] locationCells = new int[3];
        public int numberOfHits;
        public String CheckGuess(string result,int guess)
        {
            for (int i =0;i<locationCells.Length;i++ )
            {
                if (guess == locationCells[i])
                {
                    List<int> locationCellsList = locationCells.ToList();
                    locationCellsList.Remove(guess);
                    locationCells = locationCellsList.ToArray();
                    result = "hit";
                    break;
                }
                else
                {
                    result = "miss";
                }
            }
            if (locationCells.Length==0) {
                result = "kill";
            }
            return result;
        }
        public void SetLocationCells()
        {
            Random randomNumberGenerator = new Random();
            int DotComStartIndex = randomNumberGenerator.Next(0, 4);
            for (int i=0;i<locationCells.Length;i++)
            {
                locationCells[i] = DotComStartIndex;
                DotComStartIndex += 1;
            }
        }
    }
}
