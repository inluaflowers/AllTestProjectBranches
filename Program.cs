string pangram = "The quick brown fox jumps over the lazy dog";
string[] pangramWords = pangram.Split(" ");
string[] reversedWords = new string[pangram.Length];
string reversedWordsPangram = "";

foreach (string word in pangramWords)
{
    char[] chars = word.ToCharArray();
    Console.WriteLine(chars);
}
