string pangram = "The quick brown fox jumps over the lazy dog";
string[] pangramWords = pangram.Split(" ");
string[] reversedWords = new string[pangram.Length];
string reversedWordsPangram = "";

for (int i = 0; i < pangramWords.Length; i++)
{
    char[] chars = pangramWords[i].ToCharArray();
    Array.Reverse(chars);
    string newWord = String.Join("", chars);
    Console.WriteLine(newWord);



}
