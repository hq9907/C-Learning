using System.Text;

var seperators = ".,:;=()&[]\"'\\/!? ".ToCharArray();

var s = Console.ReadLine();

var words = new List<string>();
var seps = new List<string>();

for (int i = 0, j = 0; i < s.Length; i = j)
{
    bool isSep = seperators.Contains(s[i]);
    for (j = i; j < s.Length && seperators.Contains(s[j]) == isSep; ++j) ;

    (isSep ? seps : words).Add(s.Substring(i, j - i));
}
words.Reverse();

//Console.WriteLine(words.Count);
//Console.WriteLine(seps.Count);

var ans = new StringBuilder();

for (int i = 0; i < words.Count; ++i)
{
    ans.Append(words[i]);
    ans.Append(seps[i]);
}

Console.WriteLine(ans.ToString());

