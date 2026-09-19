public class Solution {

    public string Encode(IList<string> strs) 
    {
        if(strs.Count == 0) return "";

        List<int> sizes = new();
        StringBuilder encoded_string = new();

        foreach(string str in strs){
            sizes.Add(str.Length);
        }
        foreach(int size in sizes){
            encoded_string.Append(size).Append(',');
        }
        encoded_string.Append('#');
        foreach(string str in strs){
            encoded_string.Append(str);
        }
        return encoded_string.ToString();
    }

    public List<string> Decode(string s) 
    {
        if(string.IsNullOrEmpty(s)) return new List<string>();
        List<string> strings = new();
        List<int> sizes = new();

        int i=0;
        while(s[i] != '#'){
            int j=i;
            while(s[j] != ','){
                j++;
            }
            sizes.Add(int.Parse(s.Substring(i, j-i)));
            i=j+1;
        }
        i++;
        foreach(int size in sizes){
            strings.Add(s.Substring(i, size));
            i += size;
        }

        return strings;
    }
}
