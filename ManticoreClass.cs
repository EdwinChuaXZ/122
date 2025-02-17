//Written by Edwin
//2/14/2025
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boss_Battle_Hunting_the_Manticore
{
    public class ManticoreClass
    {
        private int pilotManticore = -1;
        private int cityDefenses = -1;
        
        private int round = 1;
        private int manticore = 10;
        public int expected = 1;

        public int city = 15;
        //get and set
        public int PilotManticore {  get { return this.pilotManticore; } set { this.pilotManticore = value; } }
        public int CityDefenses { get { return this.cityDefenses; } set { this.cityDefenses = value; } }
        public int Round { get { return this.round; } set { this.round = value; } }

        public int Manticore { get { return this.manticore; } set { this.manticore = value; } }
        public int Expected { get { return this.expected; } set { this.expected = value; } }

        public int City { get { return this.city; } set { this.city = value; } }

        //Determine whether the entered value is correct
        public string DamageResult()
        {
            string damageResult = "n/a";
           
                if (PilotManticore < CityDefenses) { damageResult = "That round OVERSHOT the target.";  }
                if (PilotManticore == CityDefenses) { damageResult = "That round was a DIRECT HIT!";  }
                if (PilotManticore > CityDefenses) { damageResult = "That round FELL SHORT the target.";  }

                return damageResult;
          

        }


        //Round is updated every round, and Manticore HP reduction should be before Round ++, and predicted damage should be after Round ++.
        //ManticoreHP() is the current HP
        //Predicted damage is the prediction of damage in the next round
        public int turn()
        {
            
            if (Round <= 15) {  ManticoreHP(); CityHp(); Round = Round + 1; ExpectedNum(); }
           
            return Round;
        }

        //Only when the inputs are equal will the blood deduction be executed.
        public int ManticoreHP()
        {


            if (PilotManticore == cityDefenses)
            {

                if (Round % 3 == 0 && Round % 5 == 0) { Manticore = Manticore - 10; }
                else if (Round % 3 == 0) { Manticore = Manticore - 3; }
                else if (Round % 5 == 0) { Manticore = Manticore - 5; }
                else { Manticore = Manticore - 1; }
            }
            


            return Manticore;
        }

        //Updated damage estimate per round
        public int ExpectedNum()
        {


          
                if (Round % 3 == 0 && Round % 5 == 0) { Expected = 10; }
                else if (Round % 3 == 0) { Expected = 3;  }
                else if (Round % 5 == 0) { Expected = 3; }
                else { Expected = 1; }

            


            return Expected;
        }
        //Update the city's HP. If enter error, 1 HP will be deducted each round.
        public int CityHp()
        {
            if (Manticore > 0 && PilotManticore != cityDefenses) { 
            City = City - 1;

        }
            return City;
        }
        //Output the results and run city damage based on the results
        public override string ToString()
        {
            string message = "";
 
            message += DamageResult()+"\n";
            
            return message;
        }
    }
}
