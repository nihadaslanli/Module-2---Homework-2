

namespace Module_2___Homework_2
{
    internal class Program
    {
        #region task1
        static void Main(string[] args, string salam)
        {
            string input = Console.ReadLine();
            string output = Result(input);
            Console.WriteLine(output);



        }

        static string Result(string input)
        {

            var divide = input.Split('.');
            return divide[1] + '.' + divide[0];


        }
        #endregion
        #region task2
        //static void Main(string[] args)
        //{
        //    string word = Console.ReadLine();
        //    string capitalizedWord = Capitalize(word);
        //    Console.WriteLine(capitalizedWord);
        //}

        //static string Capitalize(string word)
        //{
        //    if (string.IsNullOrEmpty(word))
        //        return word;
        //    return char.ToUpper(word[0]) + word.Substring(1);
        //}
        #endregion
    }
}
