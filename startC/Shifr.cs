Console.Write("Введите слово: ");
string?  WordFirst = Console.ReadLine();

char[] alphabet = ['А','Б','В','Г','Д','Е','Ё','Ж','З','И','Й','К','Л','М','Н','О','П','Р','С','Т','У','Ф','Х','Ц','Ч','Ш','Щ','Ъ','Ы','Ь','Э','Ю','Я'];
char[] tebahpla = ['Я','Ю','Э','Ь','Ы','Ъ','Щ','Ш','Ч','Ц','Х','Ф','У','Т','С','Р','П','О','Н','М','Л','К','Й','И','З','Ж','Ё','Е','Д','Г','В','Б','А'];

for (int iW = 0; iW < WordFirst.Length; iW++)
{
    //Console.WriteLine(WordFirst[iW]);
    for (int iA = 0; iA < alphabet.Length; iA++)
    {
        if (alphabet[iA] == WordFirst[iW])
        {
            Console.Write(tebahpla[iA]);
        }
    }
}
