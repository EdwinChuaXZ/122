//written by Edwin
//2/10/2025
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace how_many_D_s
{
    internal class FindDClass
    {
        public int FindD(string sentence)
        {

            //change sentence = Capitaleter
            sentence = sentence.ToUpper();

            int count = 0;
            //check all letter
            foreach (char i in sentence) {
            
                if(i == 'D')
                {

                    count++;
                }
            }
            return count;

        }
    }
}
