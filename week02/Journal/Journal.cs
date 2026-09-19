using System.IO; // necessário para StreamWriter e File

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
            entry.Display();
        }
    }

    // ===== O CÓDIGO DE SALVAR VEM AQUI, DENTRO DESTE MÉTODO =====
    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}~|~{entry._promptText}~|~{entry._entryText}");
            }
        }
    }

    // ===== O CÓDIGO DE CARREGAR VEM AQUI, DENTRO DESTE MÉTODO =====
    public void LoadFromFile(string file)
    {
        _entries.Clear(); // substitui as entradas atuais

        string[] lines = File.ReadAllLines(file);
        foreach (string line in lines)
        {
            string[] parts = line.Split("~|~");
            Entry entry = new Entry(parts[0], parts[1], parts[2]);
            _entries.Add(entry);
        }
    }
}