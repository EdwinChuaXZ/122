//Edwin Chua
//2/15/2025
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simula_s_Test
{
    public class SimulaClass
    {
        // user input
        private string choose = "n/a";

        // enum choose
        public enum BoxState { Open, Closed, Locked,Unlocked }
        
        //original state
        private BoxState box = BoxState.Closed; 

        //get and set the box state
        public BoxState Box { get { return this.box; } set { this.box = value; } }

        //get and set user input
        public string Choose { get { return this.choose; } set { this.choose = value; } }

        //judge input
        public string Chest() {
            string chest = "n/a";

            switch (choose)
            {

                case "LOCK" :

                    if(Box == BoxState.Open) { chest = "Please close the box first."; } 
                    
                    else { Box = BoxState.Locked; chest = "The chest is locked"; }
                    break;

                case "CLOSE":
                    Box = BoxState.Closed;
                    chest = "The chest is closed";
                    break;

                case "OPEN":

                    if (Box == BoxState.Locked) { chest = "Please unlock the box first."; }
                    else { Box = BoxState.Open; chest = "The chest is open."; }
                    break;

            }
        
            return chest;
        }
        //override
        public override string ToString()
        {
            string message = "";
            message +=  Chest() + "\n";
            return message;
        }
    }
}
