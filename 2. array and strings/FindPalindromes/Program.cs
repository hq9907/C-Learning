var words = Console.ReadLine().Split(".,:;=()&[]\"'\\/!? ".ToCharArray()).ToArray();

var ans = words.Where(word => IsPalindrome(word)).Distinct().ToArray();
Array.Sort(ans);

Console.WriteLine(String.Join(", ", ans));

static bool IsPalindrome(string word)
{
    return !String.IsNullOrEmpty(word) && word.Equals(new string(word.Reverse().ToArray()));
}
