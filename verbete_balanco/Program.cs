using Newtonsoft.Json;
using verbete_balanco;

var client = new HttpClient();
string word = "";

while(true)
{
    Console.Write("Digite uma palavra para saber seu significado ou 'sair' para encerrar: ");

    word = Console.ReadLine().ToLower().Trim();
    if (word == "sair")
    {
        Console.WriteLine("Encerrando...");
        break;
    }

    try
    {
        var response = await client.GetAsync($"https://api.dictionaryapi.dev/api/v2/entries/en/{word}");
        var content = await response.Content.ReadAsStringAsync();

        var result = JsonConvert.DeserializeObject<List<Word>>(content);

        foreach (Meaning mean in result[0].Meanings)
        {
            Console.WriteLine($"Definition: {mean.Definitions[0].definition}");
            Console.WriteLine($"Example: {mean.Definitions[0].Example ?? "No example for this definition"}\n");
        }
    }
    catch (Exception)
    {
        Console.WriteLine("Palavra não encontrada.");
    }

} 



