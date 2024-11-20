public class Solution {
    public bool IsPalindrome(int x) {
        var strx = x.ToString().ToCharArray();

        for (int i = 0, j = strx.Count() - 1; i <= strx.Count() - 1 && j >= 0; i++, j--)
        {
                if(strx[i]!=strx[j]){
                    return false;
                }
        }
        return true;

    }
}