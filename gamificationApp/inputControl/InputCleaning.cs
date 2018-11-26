using System;

namespace gamificationApp
{
    public class InputCleaning
    {

        public static string[] specialCharacterRemoval(String question, String solution1, String solution2)
        {
            string[] cleanedArray = new string[3];

            //Question Clean
            cleanedArray[0] = stringCleaning(question);

            //Solution1 Clean
            cleanedArray[1] = stringCleaning(solution1);

            //Solution2 Clean
            cleanedArray[2] = stringCleaning(solution2);

            return cleanedArray;
        }

        public static string stringCleaning(String checkString)
        {
            String cleanedString = "";
            char[] tempArray;
            tempArray = new char[checkString.Length];
            tempArray = checkString.ToCharArray();
            char[] restrictedCharacters = { '<', '>', '/', '"', '@', '#', '|', '=', '+', '(', ')', '{', '}', '[', ']' };

            for (int i = 0; i < tempArray.Length; i++)
            {
                int count = 0;
                bool valid = true;

                foreach (char c in restrictedCharacters)
                {
                    if (tempArray[i].Equals(c))
                    {
                        valid = false;
                        count++;
                    }
                    else if (!tempArray[i].Equals(c))
                    {
                        if (count.Equals(restrictedCharacters.Length - 1) && valid)
                        {
                            cleanedString += tempArray[i];

                        }
                        else
                        {
                            count++;
                        }

                    }
                }
            }

            return cleanedString;
        }

    }
}
