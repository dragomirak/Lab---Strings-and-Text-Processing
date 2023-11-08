namespace P02.RepeatStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(" ");

            string output = "";
            for (int i = 0; i < words.Length; i++)
            {
                string currentWord = words[i];

                for (int j = 0; j < currentWord.Length; j++) 
                {
                    output += currentWord;
                }
            }

            Console.WriteLine(output);
        }
    }
}