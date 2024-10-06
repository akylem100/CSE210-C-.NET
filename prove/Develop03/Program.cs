using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture[] scriptures = GetScriptures();
        Console.WriteLine("Select a scripture to memorize:");
        for (int i = 0; i < scriptures.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {scriptures[i].GetReference()}");
        }

        int selectedScripture = 0;
        while (selectedScripture < 1 || selectedScripture > scriptures.Length)
        {
            Console.Write("Enter a number corresponding to the scripture: ");
            int.TryParse(Console.ReadLine(), out selectedScripture);
        }

        Scripture scriptureToMemorize = scriptures[selectedScripture - 1];
        MemorizeScripture(scriptureToMemorize);
    }

    static void MemorizeScripture(Scripture scripture)
    {
        while (!scripture.AreAllWordsHidden())
        {
            scripture.Display();

            Console.WriteLine("Press Enter to hide more words or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords();
        }

        Console.WriteLine("All words are hidden! Well done.");
    }

    static Scripture[] GetScriptures()
    {
        return new Scripture[]
        {
            new Scripture(new Reference("Matthew", 11, 28, 30), 
                "Come unto me, all ye that labour and are heavy laden, and I will give you rest. " +
                "Take my yoke upon you, and learn of me; for I am meek and lowly in heart: and ye shall find rest unto your souls. " +
                "For my yoke is easy, and my burden is light."),

            new Scripture(new Reference("John", 3, 16), 
                "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."),

            new Scripture(new Reference("John", 14, 6), 
                "Jesus saith unto him, I am the way, the truth, and the life: no man cometh unto the Father, but by me."),

            new Scripture(new Reference("Matthew", 22, 36, 39), 
                "Master, which is the great commandment in the law? " +
                "Jesus said unto him, Thou shalt love the Lord thy God with all thy heart, and with all thy soul, and with all thy mind. " +
                "This is the first and great commandment. " +
                "And the second is like unto it, Thou shalt love thy neighbour as thyself."),

            new Scripture(new Reference("Luke", 24, 36, 39), 
                "And as they thus spake, Jesus himself stood in the midst of them, and saith unto them, Peace be unto you. " +
                "But they were terrified and affrighted, and supposed that they had seen a spirit. " +
                "And he said unto them, Why are ye troubled? and why do thoughts arise in your hearts? " +
                "Behold my hands and my feet, that it is I myself: handle me, and see; for a spirit hath not flesh and bones, as ye see me have.")
        };
    }
}
