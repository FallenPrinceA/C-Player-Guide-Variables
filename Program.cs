using System;

namespace C_PlayerGuideVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            string username; //Declaring a variable
            Console.WriteLine("Hello Player, tell me what is your name?");
            username = Console.ReadLine(); //Assigning a value to a variable
            Console.WriteLine("Hi " + username); //Retrieving its current value

            string favoritecolor; //Declaring a variable
            Console.WriteLine("Hi " + username + " now please tell me what is your favorite color?");
            favoritecolor = Console.ReadLine();
            Console.WriteLine("Ok Great! It appears you have chosen the color " + favoritecolor);

            string weapon; //Declaring a variable 
            Console.WriteLine("Ok " + username + " now please tell me which weapon you prefer?");
            weapon = Console.ReadLine();
             Console.WriteLine("Excellent. Your character has been created:");
            Console.WriteLine("Name: " + username + " Favorite Color: " + favoritecolor + " Weapon: " + weapon);

            Console.WriteLine("================The Variable Shop===============");
            string Player = "Casper Mordred";
            string Class = "Witch";
            char Gender = 'M';
            bool Status = true;
            int magic_attack = 30000;
            uint health = 99;
            short defense = 45;
            ushort magic_defense = 200;
            long spell_count = 64;
            ulong stealth = 5;
            byte range = 66;
            sbyte speed = 20;
            float technique = 490.5f;
            double intelligence = 120;
            decimal strength = 4.5m;

            //Display
            Console.WriteLine("By using the fourteen variables I created a fantasy character named " + Player);
            Console.WriteLine("He is a " + Class + " thus means he specializes in magic");
            Console.WriteLine("I use the char variable to set " + Player + " gender to " + Gender);
            Console.WriteLine("By using the bool status and setting it to " + Status + " this indicates the character is still alive");
            Console.WriteLine("Being a witch he has a very high magic attack at Magic Attack: " + magic_attack);
            Console.WriteLine("Since uint can't be negative I used this variable to set the health which can only be 0 or postitive. His health is " + health);
            Console.WriteLine("He has a very low defense at Defense:" + defense);
            Console.WriteLine("However his magic defense is quite high at " + magic_defense);
            Console.WriteLine("He has a good arsenel of spells though! Spell Count: " + spell_count);
            Console.WriteLine("He's not very sneaky though... stealth: " + stealth);
            Console.WriteLine("His range could also use some work... Range: " + range);
            Console.WriteLine("In terms of athletic he could use some work. Even his speed is poor. Speed: " + speed);
            Console.WriteLine("His technique however is rather high. Technique: " + technique);
            Console.WriteLine("He is also very intelligent. Intelligence: " + intelligence);
            Console.WriteLine("However strength wise he has almost nothing... Strength: " + strength);

            Console.WriteLine("================The Variable Shop Returns ===============");
            Player = "Emilia Lucifer";
            Class = "Fighter";
            Gender = 'F';
            Status = true;
            magic_attack = 5;
            health = 300;
            defense = 150;
            magic_defense = 12;
            spell_count = 3;
            stealth = 100;
            range = 12;
            speed = 64;
            technique = 103.1f;
            intelligence = 99;
            strength = 780.9m;

            //Display
            Console.WriteLine("By modifying the variables I created a new fantasy character named " + Player);
            Console.WriteLine("Unlike our first class she is a " + Class + " which means she specializes in hand to hand combat");
            Console.WriteLine("I reuse the char variable to set " + Player + " gender to " + Gender);
            Console.WriteLine("By using the bool status and setting it to " + Status + " this indicates that she is still alive"); 
            Console.WriteLine("She has a very low level of magic attack at. Magic Attack: " + magic_attack);
            Console.WriteLine("She has a very high health. Health:" + health);
            Console.WriteLine("Her defense is really high though. Defense: " + defense);
            Console.WriteLine("Her magic defense however... not so much. Magic Defense: " + magic_defense);
            Console.WriteLine("Her spell count is also something to not ride home about. Spell Count: " + spell_count);
            Console.WriteLine("Good thing she isn't the loud type of fighter with a high stealth. Stealth: " + stealth);
            Console.WriteLine("Her range is very low too. Range: " + range);
            Console.WriteLine("Her speed is very high unlike the witch! Speed: " + speed);
            Console.WriteLine("Her technique however is very average. Technique: " + technique);
            Console.WriteLine("Same with her intelligent. Intelligence: " + intelligence);
            Console.WriteLine("However her strength is off the chart! Strength: " + strength);

            //The Convert Class
            Console.Write("What is your Health Point Level at? ");
            string healthpointText = Console.ReadLine();
            int healthpoint = Convert.ToInt32(healthpointText);
            Console.WriteLine("Your current health point level is at: " + healthpoint + " looking good!");

            //Math in C#
            int a = 10 + 6; //addition 
            int b = 9 - 3; //subtraction 
            int c; // initializing a variable 
            c = 9 - 2; // one value to c
            c = 3 + 3; // another value to c

            int d= 3 + 1; //declaring and assigning
            d = 1 + 2; //assagning a second value to d

            //Multiplication and Float Assignment 
            float power = 4;
            float dexterity = 9;
            float SpecialPower = power * dexterity;

            Console.WriteLine("This witch has a high special power at " + SpecialPower);

            //Division and Double Assignment
            double moneyMadeFromGame = 100000;
            double totalProgrammers = 4;
            double moneyPerPerson = moneyMadeFromGame / totalProgrammers;
            Console.WriteLine("Wow each programmer made " + moneyPerPerson + " from our latest project!");

            Console.WriteLine("================The Triangle Farmer ===============");
            Console.WriteLine("What is the triangle's width?");
            string widthText = Console.ReadLine();
            float width = Convert.ToSingle(widthText);

            Console.WriteLine("What is the triangle's height?");
            string heightText = Console.ReadLine();
            float height = Convert.ToSingle(heightText);

            float area = (width * height) / 2;
            Console.WriteLine("The area of our triangle is " + area);

            Console.WriteLine("================The Four Sisters and the DuckBear ===============");
            Console.WriteLine("How many chocolate eggs are there? ");
            string eggText = Console.ReadLine();
            int egg = Convert.ToInt32(eggText);

            Console.WriteLine("Wow that's alot of chocolate eggs " + egg + " now let's see how many the sisters and duckbear get");

           int sisters = egg / 4;
           int duckbear = egg % 4;
            Console.WriteLine("The sisters get " + sisters + " each");
            Console.WriteLine("The duckbear gets what's left at " + duckbear);

            Console.WriteLine("================The Dominion of Kings ===============");
            int estate = 1;
            int duchy = 3;
            int province = 6;

            Console.WriteLine("What is the name of the King?");
            string King = Console.ReadLine();

            Console.WriteLine("How many estates does King " + King + " have?");
            string kestateText = Console.ReadLine();
            int kestate = Convert.ToInt32(kestateText);

            Console.WriteLine("How many duches does King " + King + " have?");
            string kduchyText = Console.ReadLine();
            int kduchy = Convert.ToInt32(kduchyText);

            Console.WriteLine("How many provinces does King " + King + " have?");
            string kprovinceText = Console.ReadLine();
            int kprovince = Convert.ToInt32(kprovinceText);

            int score = (estate * kestate) + (duchy * kduchy) + (province * kprovince);
            Console.WriteLine("King " + King + " has a total score of " + score);







        }
    }
}
