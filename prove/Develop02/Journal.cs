using System.IO;
public class Journal

{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)  
    {
     _entries.Add(newEntry);
    }

    public void DisplayAll()
    {

      foreach (Entry entry in _entries)
      {         
        entry.DisplayEntry();     }
    }

    public void SaveToFile(string filename)
    {
     
  using (StreamWriter outputFile = new StreamWriter(filename))
  {
    foreach (Entry entry in _entries)
      {         
        outputFile.WriteLine($"{entry._date}~ {entry._promptText}~ {entry._entryText}" );
      }
  }
     
    }
    
    public void LoadFromFile(string file)
    {
     string[] lines = System.IO.File.ReadAllLines(file);

    foreach (string line in lines)
      {
        string[] parts = line.Split("~");
        // parts[date,prompt, entry] 
       string date = parts [0];  
       string prompt = parts [1];  
       string entry = parts [2];
       Entry anEntry = new Entry(date, prompt, entry);
       _entries.Add(anEntry);


       }   
    }
}