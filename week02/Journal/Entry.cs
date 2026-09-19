public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public Entry(string date, string promptText, string entryText)
    {
        _date = date;
        _promptText = promptText;
        _entryText = entryText;
    }

    public void Display()
    {
        Console.WriteLine($"Data: {_date}");
        Console.WriteLine($"Pergunta: {_promptText}");
        Console.WriteLine($"Resposta: {_entryText}");
        Console.WriteLine(); // linha em branco entre entradas
    }
}