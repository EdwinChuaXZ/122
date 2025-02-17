//Written by Edwin
//2/16

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Vin_Fletcher_s_Arrows
{
    public class VinFletcherClass1
    {//enum select material
        public enum Arrowhead { steel, wood, obsidian }
        public enum Fletch { plastic, turkey, goose }

        //original
        Arrowhead arrowhead = Arrowhead.steel;
        Fletch fletch = Fletch.plastic;

        private string Iarrowhead = "n/a";
        private string Ifletch = "n/a";
        private double length = -1.00;
        //get and set
        public string IArrowhead { get { return this.Iarrowhead; } set { this.Iarrowhead = value; } }
        public string IFletch { get { return this.Ifletch; } set { this.Ifletch = value; } }
        public double Length { get { return this.length; } set { this.length = value; } }
        public Arrowhead aArrowhead { get { return this.arrowhead; } set { this.arrowhead = value; }}
        public Fletch aFletch { get { return this.fletch; } set { this.fletch = value; } }

        
        // full consturt
        public VinFletcherClass1(Arrowhead aarrowhead, Fletch afletch, double alength) {
           
            this.aArrowhead = aarrowhead;
            this.aFletch = afletch;
            this.Length = alength;


        }
        // empty consturt
        public VinFletcherClass1() : this (Arrowhead.steel, Fletch.plastic, -1.0)
        {


        }

        //calculator the cost
        public double GetCost() {

            double cost = 0.00;

            switch (IArrowhead) {
                case "steel": aArrowhead =Arrowhead.steel; cost = cost + 10; break;
                case "wood": aArrowhead = Arrowhead.wood; cost = cost + 3; break;
                case "obsidian": aArrowhead = Arrowhead.obsidian; cost = cost + 5; break;

            }
            switch (IFletch)
            {
                case "plastic": aFletch = Fletch.plastic; cost = cost + 10; break;
                case "turkey": aFletch = Fletch.turkey; cost = cost + 3; break;
                case "goose":  aFletch = Fletch.goose; cost = cost + 5; break;

            }
            cost = cost + length * 0.05;

            return cost;
        
        }
        //override
        public override string ToString() {
            string message = "";

            message += "Total cost:" + GetCost();

            return message;

        }
    }
}
