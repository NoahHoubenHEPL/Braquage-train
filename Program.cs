namespace Braquage_train;

class Program
{
    static void Main(string[] args)
    {
        /*
         * Consignes :
           - Utiliser une première boucle pour parcourir les quatre wagons.
           - Utiliser une deuxième boucle à l'intérieur pour parcourir les trois coffres de chaque wagon.
           - Afficher chaque coffre inspecté avec son numéro de wagon.
           - Compter le nombre total de coffres inspectés.
        */

        /* int totalChests = 0;
        for (int wagon = 1; wagon <= 4; wagon++)
        {
            for (int chest = 1; chest <= 3; chest++)
            {
                totalChests = (totalChests + 1);
                Console.WriteLine("Wagon " + wagon + " - Coffre " + chest + " inspecté");
                Console.WriteLine(totalChests + "/12 coffres inspectés.");
                Console.WriteLine(" ");
                Console.ReadLine();
            }
        }
        */

        /* Exemple :
               Inspection des 4 wagons du train
               Wagon 1 - Coffre 1 inspecté
               Wagon 1 - Coffre 2 inspecté
               Wagon 1 - Coffre 3 inspecté
               Wagon 2 - Coffre 1 inspecté
               ...
               Total : 12 coffres inspectés.
            
            BONUS 1 : permettre à l'utilisateur de choisir le nombre de wagons
        */

        int totalChests = 0;
        Console.WriteLine("Combien de wagons?");
        int totalWagons = Convert.ToInt32(Console.ReadLine());
        for (int wagon = 1; wagon <= totalWagons; wagon++)
        {
            for (int chest = 1; chest <= 3; chest++)
            {
                totalChests = (totalChests + 1);
                Console.WriteLine("Wagon " + wagon + " - Coffre " + chest + " inspecté");
                Console.WriteLine(totalChests + "/" + (totalWagons * 3) + " coffres inspectés.");
                Console.WriteLine(" ");
                Console.ReadLine();
            }
        }

        /* BONUS 2 : enregistrer l'ensemble du butin trouvé et l'afficher à la fin
        */

        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine(" ");
        }
        Console.WriteLine("End!");
        Console.WriteLine(totalChests + " coffres collectés.");
        Console.WriteLine(totalWagons + " wagons explorés.");
    }
}