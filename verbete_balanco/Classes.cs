
namespace verbete_balanco
{
    public class Phonetic
    {
        public string Text { get; set; }
        public string Audio { get; set; }
    }

    public class Definition
    {
        public string definition { get; set; }
        public string Example { get; set; }
        public List<string> Synonyms { get; set; }
        public List<string> Antonyms { get; set; }
    }

    public class Meaning
    {
        public string PartOfSpeech { get; set; }
        public List<Definition> Definitions { get; set; }
    }

    public class Word
    {
        public string word { get; set; }
        public string Phonetic { get; set; }
        public List<Phonetic> Phonetics { get; set; }
        public string Origin { get; set; }
        public List<Meaning> Meanings { get; set; }
    }

}
