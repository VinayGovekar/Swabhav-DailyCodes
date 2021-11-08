using System;
using System.Collections.Generic;
namespace DotComeGameApp.Model
{
    class DotComGameManager
    {
        DotCom FirstSite = new DotCom();
        DotCom SecondSite = new DotCom();
        DotCom ThirdSite = new DotCom();
        List<DotCom> DotComsList = new List<DotCom>();
        public void SetDotComNameAndLoc(string[] dotComNames) {
            DotComsList.Add(FirstSite);
            DotComsList.Add(SecondSite);
            DotComsList.Add(ThirdSite);
            for (int i=0;i<dotComNames.Length;i++)
            {
                DotComsList[i].name = dotComNames[i];
                DotComsList[i].SetLocationCells();
            }
        }
        public void DisplayDotComLocations()
        {
            for(int i = 0; i < DotComsList.Count; i++)
            {
                for (int j = 0;j<DotComsList[i].locationCells.Length;j++)
                {
                    Console.WriteLine(DotComsList[i].locationCells[j]);
                }
                Console.WriteLine("---------");
            }
        }
        public string UserGuess(string guess) {
            string result = "miss";
            for(int i = 0; i < DotComsList.Count; i++)
            {
                result = DotComsList[i].CheckGuessForEachDotCom(guess, result);
                if (result == "hit" || result=="kill")
                {
                    if (result=="kill")
                    {
                        Console.WriteLine("You just sinked {0}", DotComsList[i].name);
                        DotComsList.Remove(DotComsList[i]);
                    }
                    break;
                }
            }
            if (DotComsList.Count == 0)
            {
                result = "All Ded";
            }
            return result;
        }
    }
}
