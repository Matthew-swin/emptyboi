using System;

namespace MiscLib
{
    public class GroupOneFunctions
    {
        //---- Group 1 Functions ----------
        public int CalcRectArea(int length, int width)
        {
            if (length <= 0 || width <= 0 || length <= 0 && width <= 0)
            {
                return -1;
                throw new Exception("da fuck is this");
            }
            int a = length * width;
            int b = a;
            int c = b;
            int d = c;
            return a;

        }

        public bool IsFactiorialNum(int num)
        {
            if (num <= 0)
            {
                return false;
            }
            for (int i = 1; ; i++)
            {
                if (num % i == 0)
                {
                    num /= i;
                }
                else
                {
                    break;
                }
            }
            if (num == 1)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public int CelciusToFarenheit(int celcius)
        {
            double f =  (celcius * 9d) / 5d + 32d;
            //figuring out floor,ceiling and round #alexIsADick
                        if (f < 0)
              {
              int fah = (int)Math.Ceiling(f);
              return fah; 
              }
            int fahrenheit = (int)(Math.Ceiling(f));
            return fahrenheit;
            // int fahrenheit = (int)Math.Ceiling(f);
            // return fahrenheit;

        }

        public bool IsPalindrome(string word)
        {
            if (word.Length == 0){
                return false;
            }
            string reverse = string.Empty;
            {
                for (int i = word.Length - 1; i >= 0; i--)
                {
                    reverse += word[i].ToString();
                }
                if (reverse == word)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            
            }
        }

            public string StringReplace(string word, char replaceChar, char replacement)
            {
                string poop = word.Replace(replaceChar, replacement);
                return poop;
            
            }

            public int CharCount(string word, char countCharacter)
            {
                int count = 0;

                while(count < word.Length && word[count] == countCharacter) count++;
                return count;
            
            }
//     ░░░░░░░░░░░░░░░▄▄░░░░░░░░░░░
//     ░░░░░░░░░░░░░░█░░█░░░░░░░░░░
//     ░░░░░░░░░░░░░░█░░█░░░░░░░░░░
//     ░░░░░░░░░░░░░░█░░█░░░░░░░░░░
//     ░░░░░░░░░░░░░░█░░█░░░░░░░░░░
//     ██████▄███▄████░░███▄░░░░░░░
//     ▓▓▓▓▓▓█░░░█░░░█░░█░░░███░░░░
//     ▓▓▓▓▓▓█░░░█░░░█░░█░░░█░░█░░░
//     ▓▓▓▓▓▓█░░░░░░░░░░░░░░█░░█░░░
//     ▓▓▓▓▓▓█░░░░░░░░░░░░░░░░█░░░░
//     ▓▓▓▓▓▓█░░░░░░░░░░░░░░██░░░░░
//     ▓▓▓▓▓▓█████░░░░░░░░░██░░░░░░

// ███████▓█████▓▓╬╬╬╬╬╬╬╬▓███▓╬╬╬╬╬╬╬▓╬╬▓█ 
// ████▓▓▓▓╬╬▓█████╬╬╬╬╬╬███▓╬╬╬╬╬╬╬╬╬╬╬╬╬█ 
// ███▓▓▓▓╬╬╬╬╬╬▓██╬╬╬╬╬╬▓▓╬╬╬╬╬╬╬╬╬╬╬╬╬╬▓█ 
// ████▓▓▓╬╬╬╬╬╬╬▓█▓╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬▓█ 
// ███▓█▓███████▓▓███▓╬╬╬╬╬╬▓███████▓╬╬╬╬▓█ 
// ████████████████▓█▓╬╬╬╬╬▓▓▓▓▓▓▓▓╬╬╬╬╬╬╬█ 
// ███▓▓▓▓▓▓▓╬╬▓▓▓▓▓█▓╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬▓█ 
// ████▓▓▓╬╬╬╬▓▓▓▓▓▓█▓╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬▓█ 
// ███▓█▓▓▓▓▓▓▓▓▓▓▓▓▓▓╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬▓█ 
// █████▓▓▓▓▓▓▓▓█▓▓▓█▓╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬▓█ 
// █████▓▓▓▓▓▓▓██▓▓▓█▓╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬██ 
// █████▓▓▓▓▓████▓▓▓█▓╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬██ 
// ████▓█▓▓▓▓██▓▓▓▓██╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬██ 
// ████▓▓███▓▓▓▓▓▓▓██▓╬╬╬╬╬╬╬╬╬╬╬╬█▓╬▓╬╬▓██ 
// █████▓███▓▓▓▓▓▓▓▓████▓▓╬╬╬╬╬╬╬█▓╬╬╬╬╬▓██ 
// █████▓▓█▓███▓▓▓████╬▓█▓▓╬╬╬▓▓█▓╬╬╬╬╬╬███ 
// ██████▓██▓███████▓╬╬╬▓▓╬▓▓██▓╬╬╬╬╬╬╬▓███ 
// ███████▓██▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓╬╬╬╬╬╬╬╬╬╬╬████ 
// ███████▓▓██▓▓▓▓▓╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬▓████ 
// ████████▓▓▓█████▓▓╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬╬▓█████ 
// █████████▓▓▓█▓▓▓▓▓███▓╬╬╬╬╬╬╬╬╬╬╬▓██████ 
// ██████████▓▓▓█▓▓▓╬▓██╬╬╬╬╬╬╬╬╬╬╬▓███████ 
// ███████████▓▓█▓▓▓▓███▓╬╬╬╬╬╬╬╬╬▓████████ 
// ██████████████▓▓▓███▓▓╬╬╬╬╬╬╬╬██████████ 
// ███████████████▓▓▓██▓▓╬╬╬╬╬╬▓███████████

        }
    }
