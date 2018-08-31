using System.IO;
using System.Collections.Generic;


public class DataAdaptor {
    
    // TODO: This needs to be more generic, should be able to return a list of any kind of data (int, float, double, string, etc.)
    // For now, we're returning the raw strings, and letting the developer parse if needed
    public static List<string> ReadCSVFile(string filename)
    {
        List<string> all_data = new List<string>();
        StreamReader file = new StreamReader(filename);
        string line;
        while ((line = file.ReadLine()) != null)
        {
            string[] line_data = line.Split(',');
            foreach (string data in line_data)
            {
                all_data.Add(data);
            }
        }
        return all_data;
    }
}