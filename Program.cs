using System;

namespace Planner
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create several buildings in the Main() method of Program.cs
            Building FiveOneTwoEigth = new Building("512 8th Avenue");
            Building SixSevenNineSecond = new Building("679 2th Avenue");
            Building FiveOneThreeSixth = new Building("513 6th Avenue");
            
            // Give each building a width, height, and number of stories. 
            FiveOneTwoEigth._Depth = 20;
            FiveOneTwoEigth._Width = 13;
            FiveOneTwoEigth._Stories = 11;

            FiveOneThreeSixth._Depth = 50;
            FiveOneThreeSixth._Width = 90;
            FiveOneThreeSixth._Stories = 14;

            SixSevenNineSecond._Depth = 327;
            SixSevenNineSecond._Width = 243;
            SixSevenNineSecond._Stories = 16;

            // Construct each building.
            FiveOneTwoEigth.Construct();
            FiveOneThreeSixth.Construct();
            SixSevenNineSecond.Construct();

            // Have business people in your city purchase each of your buildings.
            FiveOneTwoEigth.Purchased("Brant Pippin");
            FiveOneThreeSixth.Purchased("Corri Golden");
            SixSevenNineSecond.Purchased("Christian Pippin");

            // display building information
            FiveOneThreeSixth.BuildingInfo();
            FiveOneTwoEigth.BuildingInfo();
            SixSevenNineSecond.BuildingInfo();
        }
    }
}
