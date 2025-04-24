//Written by Edwin
//4/15
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baseball_Game
{
    internal class BaseballClass1
    {

        public int CalPoints(string[] operations) { 
        
            //create a new stack
            Stack<int> Scores = new Stack<int>();

            // check all string from the operations list(input value)
            foreach (string operation in operations) {
                //if =c, use Pop to remove it from the record.
                if (operation == "C") { Scores.Pop(); }
                //if = d, use Push to save the value(use peek *2 to double the value)
                else if (operation == "D") { Scores.Push(Scores.Peek() * 2); }

                //if =+
                else if (operation == "+")
                {
                    // Take out and remove the top of the stack 
                    int scores1 = Scores.Pop();
                    //Remove the top value from the stack, but do not remove it.
                    int scores2 = Scores.Peek();

                    //sum of the previous two scores.
                    int newScores = scores1 + scores2;

                    //save the scores1 and the newScores(sum of the previous two scores)
                    Scores.Push(scores1);
                    Scores.Push(newScores);
                }

                //if it is value, just change to int and save
                else { Scores.Push(int.Parse(operation)); }
            
            
            }

            // total of the score
            int total = 0;
            foreach (int score in Scores)
            {
                total += score;
            }
            return total;
        
        
        
        
        }
    }
}
