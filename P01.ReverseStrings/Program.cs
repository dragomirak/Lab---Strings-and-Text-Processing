namespace P01.ReverseStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word;
            while ((word = Console.ReadLine()) != "end")
            {
                // string reversedWord = "";
                //for (int i = word.Length - 1; i >= 0; i--)
                //{
                //    reversedWord += word[i];
                //}

                string reversedWord = string.Join("", word.ToCharArray().Reverse());

                Console.WriteLine($"{word} = {reversedWord}");
            }
        }
    }
}