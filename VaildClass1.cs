//Written by Edwin
//4/15

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valid_Parentheses
{
    internal class VaildClass1
    {
        public bool isValue(string s) {

            //create a new stack
            Stack<char> brackets = new Stack<char>();

            //check all char in the s(what we get from input)
            foreach(char c in s)
            {

                //use push to save the left brackets
                if(c == '(' || c == '{' || c == '[')
                {

                    brackets.Push(c);
                }

                else if(c==')'|| c == '}' || c == ']') { 

                    //if the left brackets are =0, it is mean we don;t have any left brackets
                    ///so return false
                    if(brackets.Count==0) {return false;}
                
                    //use the left brackets just now we save
                char top = brackets.Pop();

                    //if we have the right bracket but we don't have left brackets
                    //return false
                    if(c == ')' && top != '('|| c == '}' && top != '{' || c == ']'&& top != '[') {

                        return false;
                    
                    }

                }


            }
            //if we already check every bracket from the s and the brackets already clear
            //return true
            return brackets.Count == 0;





            
        } 
    }
}
