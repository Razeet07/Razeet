  
using System.Collections.Generic;
public class Collections
{
    public void LearnAboutList()
    {
        List<string> names = new List<string> { "Shyam", "Hari" };

        names.Add("Bishal");
        names.Add("Bikash");
        names.Add("amit");
        names.Add("Raman");

        names.Sort();
    }
    public void LearnAboutDictionary()
    {
        //Holds key-value pairs
        Dictionary<string, string> countryCapitals = new Dictionary<string, string>
        {
            ["Bhutan"] = "Thimpu",
            ["China"] = "Beijing"
        };

        countryCapitals.Add("Nepal", "Kathmandu");
        countryCapitals.Add("India", "Delhi");
        countryCapitals.Add("USA", "DC");
        countryCapitals.Add("Russia", "Mosco");



    }
}
