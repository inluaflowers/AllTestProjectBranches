string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
string[] orderArray = orderStream.Split(',');
Array.Sort(orderArray);

for (int i = 0; i < orderArray.Length; i++)
{
    if (orderArray[i].Length != 3)
    {
        orderArray[i] = orderArray[i] + "\t - Error";
    }
    Console.WriteLine(orderArray[i]);
}