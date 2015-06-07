using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;


namespace PlayMovieQuotes
{
    class Program
    {
        //static class RandomStringArrayTool
        //{
        //    static Random _random = new Random();

        //    public static string[] RandomizeStrings(string[] arr)
        //    {
        //        List<KeyValuePair<int, string>> list = new List<KeyValuePair<int, string>>();
        //        // Add all strings from array
        //        // Add new random int each time
        //        foreach (string s in arr)
        //        {
        //            list.Add(new KeyValuePair<int, string>(_random.Next(), s));
        //        }
        //        // Sort the list by the random number
        //        var sorted = from item in list
        //                     orderby item.Key
        //                     select item;
        //        // Allocate new string array
        //        string[] result = new string[arr.Length];
        //        // Copy values to array
        //        int index = 0;
        //        foreach (KeyValuePair<int, string> pair in sorted)
        //        {
        //            result[index] = pair.Value;
        //            index++;
        //        }
        //        // Return copied array
        //        return result;
        //    }
        //}

        static void Main()
        {

           var myArray = new string[]{
               "http://www.wavsource.com/snds_2015-05-24_3842437052126496/movies/caddyshack/dad.wav",
               "http://www.wavsource.com/snds_2015-05-24_3842437052126496/movies/caddyshack/hey_everybody.wav",
               "http://www.wavsource.com/snds_2015-05-24_3842437052126496/movies/caddyshack/this_place_sucks.wav"
           };


           //string[] deezNuts = RandomStringArrayTool.RandomizeStrings(myArray);
           Random rnd = new Random();

           Console.WriteLine(myArray[rnd.Next(0, myArray.Length)]);
          

           // SoundPlayer.myA
           using (SoundPlayer x = new SoundPlayer(myArray[0]))
           {
               x.Play();
               Console.ReadLine();
           }
           Main();
            


        }
    }
}
