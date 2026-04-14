public class Solution {
    public int NumUniqueEmails(string[] emails) {
        HashSet<string> unique = new HashSet<string>();

        foreach(var email in emails)
        {
            string[] parts = email.Split('@');
            string alias = parts[0];
            string domain = parts[1];

            alias = parts[0].Split('+')[0];
            alias = alias.Replace(".","");
            unique.Add(alias+@domain);
        }

        return unique.Count;
    }
}