public class Solution {
    public int RomanToInt(string s) {
        
        Dictionary<char, int> Roman = new Dictionary<char, int>
        {
                { 'I', 1},
                { 'V', 5},
                { 'X', 10},
                { 'L', 50},
                { 'C', 100},
                { 'D', 500},
                { 'M', 1000}
        };

        int resultNumber = 0;

        for(int i = 0; i < s.Length; i++)
        {
             int currentValue = Roman[s[i]]; 

           if(i == s.Length - 1 || Roman[s[i]] >= Roman[s[i + 1]])
                resultNumber += currentValue;
            else
                resultNumber -= currentValue;
            
        }
        return resultNumber;
    }
}

