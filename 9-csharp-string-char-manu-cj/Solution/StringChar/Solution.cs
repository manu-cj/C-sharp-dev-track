namespace StringChar
{
    public class Solution
    {
        public static string ReversedString(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                throw new ArgumentException("Input string must not be empty");
            }

            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public static string CountVowels(string line)
        {
            if (string.IsNullOrEmpty(line))
            {
            throw new ArgumentException("Input string must not be empty");
            }

            HashSet<char> vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'y', 'u', 'A', 'E', 'I', 'O', 'U', 'Y' };
            HashSet<char> foundVowels = new HashSet<char>();

            foreach (char c in line)
            {
            if (vowels.Contains(c))
            {
                foundVowels.Add(char.ToLower(c));
            }
            }

            return $"Number of vowels:{foundVowels.Count}";
        }



        public static bool isPalindrome(string line) 
        {
            string lineLower = line.ToLower().Replace(" ", "");
            

            char[] charArray = line.ToCharArray();
            Array.Reverse(charArray);

            if (lineLower == new string(charArray).ToLower().Replace(" ", ""))
            {
                return true;   
            }
            else
            {
                return false;
            }
        }

        public static char firstNonRepeatingCharacter(string line)
        {
            Dictionary<char, int> charCount = new Dictionary<char, int>();

            foreach (char c in line.ToLower())
            {
                if (charCount.ContainsKey(c))
                {
                    charCount[c]++;
                }
                else
                {
                    charCount[c] = 1;
                }
            }

            foreach (char c in line.ToLower())
            {
                if (charCount[c] == 1)
                {
                    return c;
                }
            }

            return '\0'; // Return null character if all characters are repeating
        }
       
    }
}
