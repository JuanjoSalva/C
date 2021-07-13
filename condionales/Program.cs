using System;

namespace seis
{
    class Program
    {
        static void Main(string[] args)
        {
            //juegoDados();
            //subscripcion();
            desafio();
            //desafio2();
        }

        /*juego de dados. Tres tiradas cuyos números se suman. Si hay dobles se suman 2 puntos extras, si hay triple
        se suman 6. Y a la suma de las tiradas se le suma los extras. Si hay puntos extras se muestra mensaje.
        Si los puntos son mayor que 15 se muestra mensaje e que ganas. En caso contrario se miuestra mensaje
        de que pierdes */
        static void juegoDados()
        {
            Random dice = new Random();

            int roll1 = dice.Next(1, 7);
            int roll2 = dice.Next(1, 7);
            int roll3 = dice.Next(1, 7);

            int total = roll1 + roll2 + roll3;

            Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

            if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
            {
                if ((roll1 == roll2) && (roll2 == roll3))
                {
                    Console.WriteLine("You rolled triples!  +6 bonus to total!");
                    total += 6;
                }
                else
                {
                    Console.WriteLine("You rolled doubles!  +2 bonus to total!");
                    total += 2;
                }
            }

            if (total >= 16)
            {
                Console.WriteLine("You win a new car!");
            }
            else if (total >= 10)
            {
                Console.WriteLine("You win a new laptop!");
            }
            else if (total == 7)
            {
                Console.WriteLine("You win a trip for two!");
            }
            else
            {
                Console.WriteLine("You win a kitten!");
            }
        }

        /*El desafio es crear un método que dado un número aleatorio, que será el númro de días que queda para que
        nuestra subsripción termine, muestra un mensaje u otro indicando el tiempo que nos queda a nuestra
        subscripción y una oferta*/
        static void desafio()
        {
            Random random = new Random();
            int daysUntilExpiration = random.Next(12);
            int discountPercentage = 0;

            if (daysUntilExpiration == 0)
            {
                Console.WriteLine("Your subscription has expired.");
            }
            else if (daysUntilExpiration == 1)
            {
                Console.WriteLine("Your subscription expires within a day!");
                discountPercentage = 20;
            }
            else if (daysUntilExpiration <= 5)
            {
                Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
                discountPercentage = 10;
            }
            else if (daysUntilExpiration <= 10)
            {
                Console.WriteLine("Your subscription will expire soon.  Renew now!");
            }

            if (discountPercentage > 0)
            {
                Console.WriteLine($"Renew now and save {discountPercentage}%.");
            }
        }

    static void desafio2()
    {
        Random random = new Random();
        int daysUntilExpiration = random.Next(12);
        int discountPercentage = 0;

        //Esto es solo para testear:
        //Console.WriteLine($"daysUntilExpiration={​​​​​​​​daysUntilExpiration}​​​​​​​​");

        // Your code goes here
        if (daysUntilExpiration == 0)
            Console.WriteLine("Your subscription has expired.");
        else if (daysUntilExpiration == 1)
            Console.WriteLine($"Your subscription expires within a day! \n Renew now and save {discountPercentage=20}%!");
        else if (daysUntilExpiration <= 5)
            Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days. \n Renew now and save {discountPercentage=10}%!");
        else if (daysUntilExpiration <= 10)
            Console.WriteLine("Your subscription will expire soon. Renew now!");

        Console.WriteLine($"discountPercentage={discountPercentage}%");
    }

    }
}

