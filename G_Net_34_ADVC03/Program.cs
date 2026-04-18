using System.ComponentModel;

namespace G_Net_34_ADVC03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Exercise 1: Student Grade Manager
            #region Q1
            //List<int> grades = new List<int>() { 85, 92, 78, 95, 88, 70, 100, 65 };
            #endregion
            #region Q2 

            //Console.WriteLine($"Count is : {grades.Count}");
            //Console.WriteLine($"Frist Grade is : {grades[0]}");
            //Console.WriteLine($"Last Grade is : {grades[^1]}"); 
            #endregion
            #region Q3
            //ConsoleHelper.PrintList("Grades Before Sorting", grades);
            //grades.Sort();
            //ConsoleHelper.PrintList("Grades After Sorting", grades); 
            #endregion
            #region Q4
            //Console.WriteLine(grades.Find(p=>p>90));
            #endregion
            #region Q5
            //List<int> falingGrades = grades.FindAll(p => p < 75);
            //ConsoleHelper.PrintList("Failing Gardes", falingGrades);
            #endregion
            #region Q6
            //grades.RemoveAll(p => p<75);
            //ConsoleHelper.PrintList("Grades with no Failing ", grades);

            #endregion
            #region Q7 
            //Console.WriteLine(grades.Contains(100));
            #endregion
            #region Q8
            //List<string> strings = grades.Select(g => $"Grade X: {g}").ToList();
            //ConsoleHelper.PrintList("strings", strings);
            #endregion
            #endregion

            #region Exercise 2: Leaderboard 
            #region Q1

            SortedList<int, string> leaderBoard = new SortedList<int, string>()
            {
                [500] = "Ahmed",
                [200] = "Sara",
                [800] = "Ali",
                [350] = "Mona",

            };
            #endregion
            #region Q2
            //foreach (var item in leaderBoard)
            //{
            //    Console.WriteLine(item);
            //}
            ////or
            //ConsoleHelper.PrintCollection("LeaderBoard", leaderBoard); 
            #endregion

            #region Q3
            //Console.WriteLine(leaderBoard.Keys[0]); 
            #endregion
            #region Q4
            //Console.WriteLine(leaderBoard.Values[0]);
            #endregion
            #region Q5
            // Console.WriteLine(leaderBoard.ContainsKey(500));
            #endregion
            #region Q6
            //if (leaderBoard.TryGetValue(999, out string? palyer))
            //{
            //    Console.WriteLine(palyer);
            //}
            //else { Console.WriteLine("Not Found"); } 
            #endregion
            #region Q7
            //leaderBoard.Remove(200);
            //ConsoleHelper.PrintCollection("LeaderBoard After Update", leaderBoard);
            #endregion

            #endregion

            #region Exercise 3: Phone Book
            #region Q1
            //Dictionary<string, string> phoneBook = new Dictionary<string, string>();

            #endregion
            #region Q2
            //phoneBook.Add("mariam", "01099523475");
            //phoneBook.Add("fatma", "01149523455");
            //phoneBook.Add("mohammed", "0154942344");
            //phoneBook.Add("sara", "0124942354");
            #endregion
            #region Q3
            //try
            //{
            //    phoneBook.Add("sara", "0124942354");
            //}
            //catch (Exception ex)
            //{

            //    Console.WriteLine($"this is Exception  :  [{ex}]");
            //}

            #endregion
            #region Q4
            //if (phoneBook.TryAdd("sara", "011234675"))
            //{
            //    Console.WriteLine("Succedd Adding");
            //}
            //else
            //{
            //    Console.WriteLine("Faild  to Add");
            //}

            #endregion

            #region Q5
            //string searchKey = "mayada";
            //if (phoneBook.ContainsKey(searchKey))
            //{
            //    Console.WriteLine(phoneBook[searchKey]);
            //}
            //else
            //{
            //    Console.WriteLine($"{searchKey} is not found in the collection");
            //}

            #endregion

            #region Q6
            //Console.WriteLine(phoneBook.GetValueOrDefault("Amira","Not Found ")); 

            #endregion
            #region Q7

            //Console.WriteLine("Keys : "+string.Join(", ",phoneBook.Keys));
            //Console.WriteLine("Values : "+string.Join(", ",phoneBook.Values));
            #endregion
            #endregion

            #region Exercise 4: Unique Email Validator
            #region Q1
            HashSet<string> emailValidator = new HashSet<string>(StringComparer.OrdinalIgnoreCase);


            #endregion
            #region Q2
            //emailValidator.Add("ahmed@test.com");
            //emailValidator.Add("AHMED@test.com");
            //emailValidator.Add("sara@test.com");
            //emailValidator.Add("Sara@Test.Com");
            #endregion
            #region Q3
            //Console.WriteLine(emailValidator.Count);// count is 2 becuase there is
            //dublication Because of StringComparer.OrdinalIgnoreCase that ignore caseSesnsitive  and HashSet prevent Duplication
            #endregion
            #region Q4,Q5
            //var setA = new HashSet<int> { 1, 2, 3, 4, 5 };
            //var setB = new HashSet<int> { 4, 5, 6, 7, 8 };
            //var union = new HashSet<int>(setA);
            //union.UnionWith(setB);
            //Console.WriteLine($"UnionWith A union B = {{ {string.Join(", ", union)} }}");
            //var intersect = new HashSet<int>(setA);
            //union.Intersect(setB);
            //Console.WriteLine($"Intersect A intersect B ={{{string.Join(", ",intersect)}}}");
            //var except = new HashSet<int>(setA);
            //except.ExceptWith(setB);
            //Console.WriteLine($"Intersect A Except B ={{{string.Join(", ",except)}}}");

            #endregion
            #region Q6
            //var small = new HashSet<int> { 1, 2 };
            //bool isSubset = small.IsSubsetOf(setA);
            //Console.WriteLine($"  {{1, 2}}.IsSubsetOf(Set A) = {isSubset}");
            #endregion

            #endregion
        }
    }
}
