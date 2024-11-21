public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        if (strs.Length == 0)
{
    Console.WriteLine(""); 
    return "";
}

var result = "";
var firstStr = strs[0];  

for (int i = 0; i < firstStr.Length; i++)
{

    foreach (var item in strs.Skip(1))
    {

        if (i >= item.Length || item[i] != firstStr[i])
        {
           return result;  
            
        }
    }

    result += firstStr[i];
}

return result;  
    }
}