/// <summary>
/// Author: Tomas Perers
/// Created Date:   2017-10-20
/// Last Updated: 2017-11-03
/// </summary>

namespace Assignment4
{
    /// <summary>
    /// A recepie manger class that holds all the recpies in an Array
    /// </summary>
    class RecepieManager
    {
        // List of recepies
        private Recepie[] recepieList;
        /// <summary>
        /// Constructur rakes a parameter for the number of elements in the array.
        /// </summary>
        /// <param name="maxNumberOfElements"></param>
        public RecepieManager(int maxNumberOfElements)
        {
            recepieList = new Recepie[maxNumberOfElements];
        }

        /// <summary>
        /// Finds a vacant position (null) in the array returns -1 if no place is found.
        /// </summary>
        /// <returns>int index</returns>
        private int FindVacantPosition()
        {
            for (int i = 0; i <recepieList.Length; i++)
            {
                if (recepieList[i] == null)
                    return i;
            }
            return -1;
        }

        /// <summary>
        /// Returns the recepie at index but with an offset as we don't count the empty places.
        /// </summary>
        /// <param name="index"></param>
        /// <returns>Recepie</returns>
        public Recepie GetRecepie(int index)
        {
            Recepie returnValue = null;
            int fakeIndex = 0;
            if (CheckIndex(index))
            {
                for (int i = 0; i < recepieList.Length; i++)
                {
                    if (recepieList[i] != null)
                    {
                        if (fakeIndex == index)
                        {
                            returnValue = recepieList[i];
                            break;
                        }
                        fakeIndex++;
                    }
                }
            }
            return returnValue;
        }

        /// <summary>
        /// Verify that the index is inside the array return true or false
        /// </summary>
        /// <param name="index">int index</param>
        /// <returns>bool true or false</returns>
        private bool CheckIndex(int index)
        {
            bool ok = false;
            if (index >= 0 && index < recepieList.Length)
                ok = true;
            return ok;
        }

        /// <summary>
        /// Adds a recepie to the array.
        /// </summary>
        /// <param name="recepieToAdd">Recepie</param>
        /// <returns>bool true or false</returns>
        public bool Add(Recepie recepieToAdd)
        {
    
            bool returnValue = false;
            int index = FindVacantPosition();
            if (index >= 0)
            {
                recepieList[index] = recepieToAdd;
                returnValue = true;
            }
        return returnValue;
        }

        /// <summary>
        /// Adds a recepie to the array, by creating a recepie.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="category"></param>
        /// <param name="ingredients"></param>
        /// <returns>bool true or false</returns>
        public bool Add(string name, FoodCategory category, string[] ingredients)
        {
            bool returnValue = false;
            int index = FindVacantPosition();
            if (index >= 0 )
            {
                Recepie recepie = new Recepie(ingredients.Length);
                recepie.Name = name;
                recepie.IngredientsArray = ingredients;
                recepie.Category = category;
                recepieList[index] = recepie;
                returnValue = true;
            }
            return returnValue;
        }

        /// <summary>
        /// Returns a string array of all the recepies 
        /// </summary>
        /// <returns></returns>
        public string[] RecepieListToString()
        {
            int maxIndex = CurrentNumOfItems();
            if (maxIndex == 0)
                return null;
            string[] output = new string[maxIndex];
            int index = 0;
            for (int i = 0; i < recepieList.Length; i ++)
            {
                if (recepieList[i] != null)
                {
                    output[index] = recepieList[i].ToString();
                    index++;
                }
            }
            return output;
        }

        /// <summary>
        /// Check if a recepie is present in the array with the same name and category.
        /// </summary>
        /// <param name="recepie">Recepie</param>
        /// <returns>bool true or false</returns>
        public bool IsRecepieAdded(Recepie recepie)
        {
            bool returnValue = false;
            for (int i = 0; i < recepieList.Length; i ++)
            {
                if (recepieList[i] != null)
                {
                    if (recepieList[i].Name == recepie.Name && recepieList[i].Category == recepie.Category)
                    {
                        returnValue = true;
                    }
                }
                
            }
            return returnValue;
        }

        /// <summary>
        /// Change the recepie on specefied index to given recepie.
        /// </summary>
        /// <param name="index">int</param>
        /// <param name="recepie">Recepie</param>
        /// <returns>true or false</returns>
        public bool ChangeElement(int index, Recepie recepie)
        {
            int fakeIndex = 0; // This will be increased only for positions in the array that are not null.
            if (CheckIndex(index))
            {   
                for (int i = 0; i < recepieList.Length; i ++)
                {
                    if (recepieList[i] != null)
                    {
                        if (fakeIndex == index)
                        {
                            recepieList[i] = recepie;
                            return true;
                        }
                        fakeIndex++;
                    }
                }
                
            }
            return false;
        }

        /// <summary>
        /// Set the value of the index in the array to null.
        /// </summary>
        /// <param name="index">int index</param>
        /// <returns>true or false</returns>
        public bool DeleteElement(int index)
        {
            int fakeIndex = 0; // This will be increased only for positions in the array that are not null.
            if (CheckIndex(index))
            {
                for (int i = 0; i < recepieList.Length; i++)
                {
                    if (recepieList[i] != null)
                    {
                        if (fakeIndex == index)
                        {
                            recepieList[i] = null;
                            return true;
                        }
                        fakeIndex++;
                    }
                }

            }
            return false;
        }

        /// <summary>
        /// Return the count of non null entried in the array.
        /// </summary>
        /// <returns></returns>
        public int CurrentNumOfItems()
        {
            int count = 0;
            for (int i = 0; i < recepieList.Length; i++)
            {
                if (recepieList[i] != null)
                    count++;
            }
            return count;
        }
    }
}
