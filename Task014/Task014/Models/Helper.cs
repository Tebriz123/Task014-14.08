using System;
using System.Collections.Generic;
using System.Text;

namespace Task014.Models
{
    internal static class Helper
    {
        public static bool IsOdd(this int num)
        {
            if(num %2 == 0)
            {
                return false;
            }
            return true;
        }
        public static bool IsEven(this int num)
        {
            if (num % 2 != 0)
            {
                return false;
            }
            return true;
        }
        public static bool HasDigit(this string name)
        {
            for(int i = 0; i < name.Length; i++)
            {
                if(Char.IsDigit(name[i]))
                {
                    return true;
                }
               
            }
            return false;
        }
        public static bool CheckPassword(this string password)
        {
            
            for(int i = 0; i < password.Length; i++)
            {
                char upperChar = Char.ToUpper(password[i]);
                char lowerChar = Char.ToLower(password[i]);
                if(password.Length <= 8) 
                {

                    if (upperChar != password[i])
                    {
                        if (lowerChar != password[i])
                        {
                            if (!Char.IsDigit(password[i]))
                            {
                                
                            }

                        }
                    }
                    return false;

                }
                }
            return true;
        
        }
        public static string Capitalize(this string name)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Char.ToUpper(name[0]));
            for(int i = 1; i < name.Length; i++)
            {
                sb.Append(Char.ToLower(name[i]));
            }
            return sb.ToString();
            
        }
    }
}
