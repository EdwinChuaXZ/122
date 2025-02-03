using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Defense_of_Consolas
{
    public class Count
    {
        private int xpoint = -1;
        private int ypoint = -1;

        //get and set
        public int Xpoint { get { return xpoint; } set { xpoint = value; } }
        public int Ypoint { get { return ypoint; } set { ypoint = value; } }

        // Equations of up, down, left and right
        public int Leftpoint(){

            int leftpoint = -1;

            leftpoint = xpoint - 1;

            if (leftpoint < 0) { leftpoint = -1; }

            return leftpoint;
        }

        public int Rightpoint()
        {

            int rightpoint = -1;

            rightpoint = xpoint + 1;

            if (rightpoint < 0) { rightpoint = -1; }

            return rightpoint;
        }

        public int Uppoint()
        {

            int uppoint = -1;

            uppoint = ypoint + 1;

            if (uppoint < 0) { uppoint = -1; }

            return uppoint;
        }

        public int Downpoint()
        {

            int downpoint = -1;

            downpoint = ypoint - 1;

            if (downpoint < 0) { downpoint = -1; }

            return downpoint;
        }

        public override string ToString()//override
        {
            String message = "";

            message += "Deploy to : "+ "\n";
            message += "("+ this.Xpoint+","+this.Downpoint() + ")" + "\n" + "(" + this.Leftpoint() + "," + this.Ypoint + ")" + "\n";
            message += "(" + this.Xpoint + "," + this.Uppoint() + ")" + "\n" + "(" + this.Rightpoint() + "," + this.Ypoint + ")" + "\n";

            return message;
        }
    }
}
