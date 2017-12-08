using System;

/// <summary>
/// Author: Tomas Perers
/// Date:   2017-10-20
/// Updated 2017-11-06
/// </summary>

namespace Assignment4
{

    /// <summary>
    /// REcepie class. Represents a Recepie with a name, food category, description and list of ingredients.
    /// </summary>
    public class Recepie
    {
        private string[] ingredientsArray;
        private string name;
        private FoodCategory category;
        private string description;

        public string Description { get => description; set => description = value; }
        public FoodCategory Category { get => category; set => category = value; }
        public string Name { get => name; set => name = value; }
        public string[] IngredientsArray { get => ingredientsArray; set => ingredientsArray = value; }
        public int MaxNumOfIngredients { get { return IngredientsArray.Length; } }

        /// <summary>
        /// Constructor that takes in an int for Maximum number of Ingredients used to create an array of strings of said value.
        /// </summary>
        /// <param name="maxNumOfIngredients">int maximum number of ingredients</param>
        public Recepie(int maxNumOfIngredients)
        {
            IngredientsArray = new string[maxNumOfIngredients];
            DefaultValue();
        }

        /// <summary>
        /// Set default values for everything.
        /// </summary>
        public void DefaultValue()
        {
            for (int i = 0; i < ingredientsArray.Length; i++)
                ingredientsArray[i] = String.Empty;
            
            name = string.Empty;
            category = FoodCategory.Vegetarian;
            description = string.Empty;
        }

        /// <summary>
        /// Remove all ingredients
        /// </summary>
        public void RemoveAllIngredients()
        {
            for (int i = 0; i < ingredientsArray.Length; i++)
                ingredientsArray[i] = String.Empty;
        }

        /// <summary>
        /// Add an ingredient return true or false if the ingredient could be added.
        /// </summary>
        /// <param name="ingredient">string ingredient</param>
        /// <returns>bool true or false</returns>
        public bool AddIngredients(string ingredient)
        {
            bool ok = true;
            int index = FindVacantPosition();
            if (index >= 0)
            {
                IngredientsArray[index] = ingredient;
                ok = true;
            }
            else
                ok = false;

            return ok;
        }

        /// <summary>
        /// Checkes that the index specefied is inside the array of strings.
        /// </summary>
        /// <param name="index">int index</param>
        /// <returns>bool true or false</returns>
        private bool CheckIndex(int index)
        {
            if (index >= 0 && index < IngredientsArray.Length)
                return true;
            else
                return false;
        }

        // Decided to handle this in another way.
        ///// <summary>
        ///// Change an ingredient on said position. Return true if changed.
        ///// </summary>
        ///// <param name="index">int index in array</param>
        ///// <param name="ingredient">string ingredient to add</param>
        ///// <returns>bool true or flase</returns>
        //public bool ChangeIngredient(int index, string ingredient)
        //{
        //    bool ok = false;
        //    if (! CheckIndex(index))
        //    {
        //        ok = false;
        //    }
        //    else
        //    {

        //    }
        //    return ok;
        //}

        /// <summary>
        /// Return number of ingredients in recepie. (array)
        /// </summary>
        /// <returns>int number of ingredients</returns>
        public int GetCurrentNumOfIngredients()
        {
            int count = 0;
            for (int i=0; i < ingredientsArray.Length; i++)
            {
                if (!String.IsNullOrEmpty(ingredientsArray[i]))
                    count++;
            }
            return count;
        }

        /// <summary>
        /// Returns the index of a free position in the array, where the value is String.Empty or null. otherwise return -1
        /// </summary>
        /// <returns>int vacantPosition</returns>
        public int FindVacantPosition()
        {
            for (int i = 0; i < ingredientsArray.Length; i++)
            {
                if (ingredientsArray[i].Equals(String.Empty) || ingredientsArray[i] == null)
                {
                    return i;
                }
            }
            return -1;
        }

        /// <summary>
        /// Overrides the ToString and returns name, number of ingredients, food category and description of recepie.
        /// </summary>
        /// <returns>string name, number of ingredients, food category and description of recepie</returns>
        public override string ToString()
        {
            int chars = Math.Min(description.Length, 15);
            string descriptionText = description.Substring(0, chars);

            if (String.IsNullOrEmpty(descriptionText))
                descriptionText = "No description!";

            string textOut = String.Format("{0, -20} {1,4} {2,-12} {3,15}", name, GetCurrentNumOfIngredients(), category.ToString(), descriptionText);
            return textOut;
        }
        
        // Decided to handle this in another way.
        ///// <summary>
        ///// Removes an ingredient at specefied index.
        ///// </summary>
        ///// <param name="index"></param>
        ///// <returns></returns>
        //public bool RemoveIngredient(int index)
        //{
        //    bool ok = false;
        //    if (CheckIndex(index))
        //    {
        //        ingredientsArray[index] = String.Empty;
        //        ok = true;
        //    }
        //    return ok;
        //}
    }
}
