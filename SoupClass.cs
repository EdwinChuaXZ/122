//Edwin Chua
//2/15/2025
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simula_s_Soup
{
    public class SoupClass
    {
        private string choose1 = "n/a";
        private string choose2 = "n/a";
        private string choose3 = "n/a";

        // use enum set data
        public enum Foodtype { soup, stew, bumbo }
        public enum Ingredient { mushrooms, chicken, carrots, potatoes }
        public enum FoodSeasoning { spicy, salty, sweet }

        //original data

        Foodtype afoodtype = Foodtype.soup;
        Ingredient aingredient = Ingredient.mushrooms;
        FoodSeasoning afoodSeasoning = FoodSeasoning.spicy;

        //get and set
        public string Choose1 { get{ return this.choose1; } set { this.choose1 = value; } }
        public string Choose2 { get { return this.choose2; } set { this.choose2 = value; } }

        public string Choose3 { get { return this.choose3; } set { this.choose3 = value; } }

        public Foodtype AFoodtype { get { return this.afoodtype; } set { this.afoodtype = value; } }
        public Ingredient AIngredient { get { return this.aingredient; } set { this.aingredient = value; } }
        public FoodSeasoning AFoodSeasoning { get { return this.afoodSeasoning; } set { this.afoodSeasoning = value; } }


        //Determine the Foodtype input
        public Foodtype aChoose1() {
            
            if (Choose1 == "soup") { AFoodtype = Foodtype.soup; }
            else if (Choose1 == "stew") { AFoodtype = Foodtype.stew; }
            else if (Choose1 == "bumbo") { AFoodtype = Foodtype.bumbo; }
            return AFoodtype;
        
        }
        //Determine the Ingredient input
        public Ingredient aChoose2()
        {
            
            if (Choose2 == "mushrooms") { AIngredient = Ingredient.mushrooms; }
            else if (Choose2 == "chicken") { AIngredient = Ingredient.chicken; }
            else if (Choose2 == "carrots") { AIngredient = Ingredient.carrots; }
            else if (Choose2 == "potatoes") { AIngredient = Ingredient.potatoes; }
            return AIngredient;

        }
        //Determine the FoodSeasoning input
        public FoodSeasoning aChoose3()
        {
            
            if (Choose3 == "spicy") { AFoodSeasoning = FoodSeasoning.spicy; }
            else if (Choose3 == "salty") { AFoodSeasoning = FoodSeasoning.salty; }
            else if (Choose3 == "sweet") { AFoodSeasoning = FoodSeasoning.sweet; }
            return AFoodSeasoning;

        }
        //Override
        //user Tuple save data
        public override string ToString()
        {
            string message = "";

            var Soup = Tuple.Create(aChoose1(), aChoose2(), aChoose3());

            message += Soup.Item1 +" "+ Soup.Item2 +" "+ Soup.Item3;

            return message;
        }
    }
}
