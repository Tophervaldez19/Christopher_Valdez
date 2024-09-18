// See https://aka.ms/new-console-template for more information

while (true)
{
    Console.Write("Input a Word:");

    var input = Console.ReadLine();

    bool isPalindrome = true;

    for (var i = 0; i <= input!.Length / 2; i++)
    {
        if (!(input[i] == input[input.Length - (i + 1)]))
        {
            isPalindrome = false;
            break;
        }
    }

    Console.WriteLine(isPalindrome ? "Palindrome" : "Not Palindrome");
    Console.WriteLine("~~~~~~~~~~~~~~~");
}
