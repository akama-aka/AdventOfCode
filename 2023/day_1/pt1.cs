// See https://aka.ms/new-console-template for more information
/*
--- Day 1: Trebuchet?! ---
   
   Something is wrong with global snow production, and you've been selected to take a look. The Elves have even given you a map; on it, they've used stars to mark the top fifty locations that are likely to be having problems.
   
   You've been doing this long enough to know that to restore snow operations, you need to check all fifty stars by December 25th.
   
   Collect stars by solving puzzles. Two puzzles will be made available on each day in the Advent calendar; the second puzzle is unlocked when you complete the first. Each puzzle grants one star. Good luck!
   
   You try to ask why they can't just use a weather machine ("not powerful enough") and where they're even sending you ("the sky") and why your map looks mostly blank ("you sure ask a lot of questions") and hang on did you just say the sky ("of course, where do you think snow comes from") when you realize that the Elves are already loading you into a trebuchet ("please hold still, we need to strap you in").
   
   As they're making the final adjustments, they discover that their calibration document (your puzzle input) has been amended by a very young Elf who was apparently just excited to show off her art skills. Consequently, the Elves are having trouble reading the values on the document.
   
   The newly-improved calibration document consists of lines of text; each line originally contained a specific calibration value that the Elves now need to recover. On each line, the calibration value can be found by combining the first digit and the last digit (in that order) to form a single two-digit number.
   For example:
   1abc2
   pqr3stu8vwx
   a1b2c3d4e5f
   treb7uchet
   
   In this example, the calibration values of these four lines are 12, 38, 15, and 77. Adding these together produces 142.
   
   Consider your entire calibration document. What is the sum of all of the calibration values?
   
   
   My Puzzle:
   https://adventofcode.com/2023/day/1/input
*/

using System.Data;

namespace aoc_DayOne
{
   class pt1
   {
      public static void Main(string[] args)
      {
         var puzzle = File.ReadAllLines("/home/slush/Dokumente/ArbeitsAufträge/Private/AdventOfCode/2023/day_1/puzzle.txt");
         List<int> resultCache = new List<int>();
         foreach (var line in puzzle)
         {
            int numerale = int.Parse(String.Join("", line.ToCharArray().Where(Char.IsDigit)));
            if (numerale.ToString().Length == 2)
            {
               resultCache.Add(numerale);
            } else if (numerale.ToString().Length == 1)
            {
               // Convert it to String for better transformation
               string cache = Convert.ToString(numerale);
               cache += cache;
               resultCache.Add(Convert.ToInt32(cache));
            }
            else
            {
               string puzzleStr = numerale.ToString();
               char[] puzzleSplit = puzzleStr.ToCharArray();
               char first = puzzleSplit[0];
               char last = puzzleSplit[puzzleSplit.Length - 1];
               string resultPzzl = puzzleSplit[0].ToString() + puzzleSplit[puzzleSplit.Length - 1].ToString();
               resultCache.Add(Convert.ToInt32(resultPzzl));
            }
         }

         int result = 0;
         foreach (int value in resultCache)
         {
            if (result == 0)
            {
               result = value;
            }
            else
            {
               result += value;
            }
         }
         Console.WriteLine(result);
      }
   }
}




/*
           ,ggg,                                                                       ,ggg,                         
             dP""8I   ,dPYb,                                                             dP""8I   ,dPYb,                
            dP   88   IP'`Yb                                                            dP   88   IP'`Yb                
           dP    88   I8  8I                                                           dP    88   I8  8I                
          ,8'    88   I8  8bgg,                                                       ,8'    88   I8  8bgg,             
          d88888888   I8 dP" "8    ,gggg,gg   ,ggg,,ggg,,ggg,     ,gggg,gg            d88888888   I8 dP" "8    ,gggg,gg 
    __   ,8"     88   I8d8bggP"   dP"  "Y8I  ,8" "8P" "8P" "8,   dP"  "Y8I      __   ,8"     88   I8d8bggP"   dP"  "Y8I 
   dP"  ,8P      Y8   I8P' "Yb,  i8'    ,8I  I8   8I   8I   8I  i8'    ,8I     dP"  ,8P      Y8   I8P' "Yb,  i8'    ,8I 
   Yb,_,dP       `8b,,d8    `Yb,,d8,   ,d8b,,dP   8I   8I   Yb,,d8,   ,d8b,    Yb,_,dP       `8b,,d8    `Yb,,d8,   ,d8b,
    "Y8P"         `Y888P      Y8P"Y8888P"`Y88P'   8I   8I   `Y8P"Y8888P"`Y8     "Y8P"         `Y888P      Y8P"Y8888P"`Y8
                                                                                                                        
*/