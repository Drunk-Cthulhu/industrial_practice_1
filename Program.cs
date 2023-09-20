using System.Text.RegularExpressions;

int[] first(int[] sequence)
    {
    int firstPositive = 0;
    int lastNegative = 0;

    foreach (int num in sequence)
    {
        if (num > 0 && firstPositive == 0)
        {
            firstPositive = num;
        }
        else if (num < 0)
        {
            lastNegative = num;
        }
    }

    if (firstPositive != 0 && lastNegative != 0)
    {
        int[] result = { firstPositive, lastNegative };
        return (result);
    }
    else
    {
        int[] result = { firstPositive, lastNegative };
        return result;    
}
}
int[] sequence = { -5, -2, 3, 0, 7, -9, 10, 4 };
Console.WriteLine($"1) {first(sequence)[0]} {first(sequence)[1]}");


int second(int D, int[] sequence)
{
    bool found = false;

    foreach (int num in sequence)
    {
        if (num > 0 && num % 10 == D)
        {
            return(num);
            break;
        }
    }

    return 0;
}
Console.WriteLine($"2) {second(3, sequence)}");

void third(int L, string input)
{
    using (StringReader reader = new StringReader(input))
    {
        string line;
        string lastSuitableLine = null;

        while ((line = reader.ReadLine()) != null)
        {
            if (line.Length == L && Char.IsDigit(line[0]))
            {
                lastSuitableLine = line;
            }
        }

        if (lastSuitableLine != null)
        {
            Console.WriteLine($"3) {lastSuitableLine}");
        }
        else
        {
            Console.WriteLine("Not found");
        }
    }
}
 third(5, "This is line 1\n" +
     "Line 2 starts with a digit 2\n" +
     "Line 3 is too short\n" +
     "Line 4 is the last suitable line\n" +
     "1isme");
void fourth(string A, char C)
{
    string result = "";

    foreach (string str in A.Split('\n'))
    {
        if (str.EndsWith(C.ToString()))
        {
            if (result != "")
            {
                result = "Error";
                break;
            }
            result = str;
        }
    }

    Console.WriteLine($"4) {result}");
}
fourth("This is line 1\n" +
     "Line 2 starts with a digit 2\n" +
     "Line 3 is too short\n" +
     "Line 4 is the last suitable line\n" +
     "1isme", '1');

void fifth(string A, char C)
    {
    int count = 0;
    foreach (string element in A.Split('\n'))
    {
        if (element.Length > 1 && element[0] == C && element[element.Length - 1] == C)
        {
            count++;
        }
    }
    Console.WriteLine("5) Number of elements that meet the criteria: " + count);
}
fifth("abc\na\nab\nbcd\naca\nababa",'a');

void sixth(int[] sequence)
{
    int count = 0;
    int sum = 0;

    foreach (int number in sequence)
    {
        if (number >= 10 && number <= 99)
        {
            count++;
            sum += number;
        }
    }

    if (count > 0)
    {
        double mean = (double)sum / count;
        Console.WriteLine($"6) {count},{mean}");
    }
    else
    {
        Console.WriteLine("6) 0, 0.0");
    }
}
int[] arr = { 10, 5, -25, 15, -30, 101, 40, 50, -60, 70, 80, 90, -100};
sixth(arr);

void seventh(string A, int L)
{
    string[] strings = A.Split('\n');
    var filteredStrings = strings.Where(s => s.Length == L);
    string largestString = filteredStrings.DefaultIfEmpty("").Max();
    Console.Write("7) ");
    Console.WriteLine(largestString != "" ? largestString : "");
}
seventh("abc\na\nab\nbcd\naca\nababa", 3);



void eighth(string strings)
{
    int sum = 0;
    foreach(string sub in strings.Split('\n'))
    {
        sum += sub.Length;
    }
    Console.WriteLine("8) " + sum);
}
eighth("abc\na\nab\nbcd\naca\nababa");

void ninth(int D, int[] A)
{
    bool start = false;
    List<int> result = new List<int>();

    for (int i = 0; i < A.Length; i++)
    {
        
        if (A[i] > D)
        {
            start = true;
        }
        else
        {
            if(!start)
                result.Add(A[i]);
        }

        if (start && A[i] > 0 && A[i] % 2 != 0)
        {
            result.Add(A[i]);
        }
    }

    result.Reverse();
    Console.Write("9) ");
    foreach (var num in result)
    {
        Console.Write(num+" ");
    };
    Console.Write('\n');
}
ninth(10, arr);


void tenth(string A, int D)
    {
    List<string> lines = A.Split('\n').ToList(); // convert A into a list of lines
    List<string> extractedLines = new List<string>();

    for (int i = 0; i < D; i++)
    {
        string line = lines[i];
        if (line.Length % 2 != 0 && char.IsUpper(line[0]))
        {
            extractedLines.Add(line);
        }
    }

    extractedLines.Reverse(); // reverse the order of the extracted lines

    string result = string.Join(", ", extractedLines); // convert the reversed lines into a string
    Console.WriteLine("10) "+result);
}
tenth("abc\nCaB\nAB\nBcd\naca\nAbaba", 4);

void eleventh(int[] A, int D, int K)
{
    var firstFragment = A.TakeWhile(x => x <= D);
    var secondFragment = A.Skip(K - 1);
    var union = firstFragment.Union(secondFragment);

    var sortedUnion = union.OrderByDescending(x => x);
    Console.Write("11) ");
    foreach (var item in sortedUnion)
    {
        Console.Write(item + " ");
    }
    Console.Write("\n");
}
eleventh(arr, -5, 7);

void twelwth(int K, int[] A)
{
    List<int> evenNumbers = A.Where(x => x % 2 == 0).ToList();
    List<int> numbersGreaterThanK = A.Where((x, i) => i > K).ToList();

    List<int> difference = evenNumbers.Except(numbersGreaterThanK).ToList();

    List<int> distinctElements = difference.Distinct().ToList();

    List<int> reversedSequence = distinctElements.OrderByDescending(x => x).ToList();
    Console.Write("12) ");
    foreach (var item in reversedSequence)
    {
        Console.Write(item+" ");
    }
    Console.Write("\n");
}
twelwth(5, arr);

void thirteenth(int K, string A)
{
    string[] fragment1 = A.Split('\n').Take(3 * K).ToArray();
    int lastNumberIndex = Array.FindLastIndex(A.Split('\n'), s => Regex.IsMatch(s, @"\d$"));
    string[] fragment2 = A.Split('\n').Skip(lastNumberIndex + 1).ToArray();

    IEnumerable<string> intersection = fragment1.Intersect(fragment2).Distinct();

    var result = intersection.OrderBy(s => s.Length).ThenBy(s => s);

    Console.Write("13) ");
    foreach (var item in result)
    {
        Console.Write(item+" ");
    }
    Console.Write("\n");

}
thirteenth(5, "This is line 1\n" +
     "Line 2 starts with a digit 2\n" +
     "Line 3 is too short\n" +
     "Line 4 is the last suitable line\n" +
     "1isme");


void fourteenth(string A)
{
    string[] sequenceA = A.Split('\n');
    List<string> modifiedSequence = new List<string>();

    for (int i = 0; i < sequenceA.Count(); i++)
    {
        string str = sequenceA[i];

        if (!string.IsNullOrEmpty(str))
        {
            string modifiedStr = str + (i + 1);
            modifiedSequence.Add(modifiedStr);
        }
    }

    modifiedSequence.Sort();
    Console.Write("14) ");

    foreach (string str in modifiedSequence)
    {
        Console.Write(str+", ");
    }
    Console.Write("\n");

}
fourteenth("ABC\n \nDEF\nGHI");