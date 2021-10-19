using System;

namespace BackupFiles.exe
{
    class Program
    {
        static void Main(string[] args)
        {
            //Le programme attends 3 arguments [repertoire source, repertoire destination, type de fichiers]
            static void Main(string[] args)
            {
                // si les 3 fichiers ne sont pas present on affiche un message et on quitte l'application
                if (args.Length < 3)
                {
                    Console.WriteLine("Les paramètres attendus sont: [repertoire source, repertoire destination, type de fichiers]");
                    return;
                }
                string repertoireSource = args[0];
                string repertoireDestination = args[1];
                string typeDeFichiers = args[2];
                //Juste poru l exemple on affiche tous les arguments.
                for (int index = 0; index < args.Length; index++)
                {
                    Console.WriteLine("Argument {0}: value: {1}", index, args[index]);
                }
                Console.ReadLine();
            }
        }
    }
}
