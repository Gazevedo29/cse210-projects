public class PromptGenerator
{
    public List<string> _prompts = new List<string>()
    {
        "Quem foi a pessoa mais interessante com quem você interagiu hoje?",
        "Qual foi a melhor parte do seu dia?",
        "O que você aprendeu hoje?",
        "Qual foi a emoção mais forte que você sentiu hoje?",
        "Se você pudesse refazer uma coisa de hoje, o que seria?",
        "Por que você é grato(a) hoje?"
    };

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}