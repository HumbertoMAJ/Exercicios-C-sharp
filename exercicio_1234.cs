using System;
using System.Text;
using System.Globalization;

namespace exercicio_1234
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
            while (true) { 


                string sentence = Console.ReadLine();
              
                bool lowerCase = true;
                string string01 = "";
                for (int i = 0; i < sentence.Length; i++)
                {
                    if (lowerCase && sentence[i] != ' ')
                    {
                        lowerCase = false;
                        string01 += char.ToUpper(sentence[i]);
                    }
                    else if (!lowerCase && sentence[i] != ' ')
                    {
                        lowerCase = true;
                        string01 += char.ToLower(sentence[i]);
                    }
                    else
                    {
                        string01 += " ";
                    }
                }
                Console.WriteLine(string01);
                
            }
            }
     

        }
            
      

    }




    

