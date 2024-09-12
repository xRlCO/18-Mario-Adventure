namespace _18__Mario_Adventure
{
    namespace _18__Mario_Adventure
    {
        using System;

        namespace MarioAdventure
        {
            class Program
            {
                static void Main(string[] args)
                {
                    MainMenu(); 
                }

                static void MainMenu()
                {
                    Console.WriteLine("Welcome to the 18+ Mario Adventure Game!");
                    Console.WriteLine("1: Start Game\n2: Instructions\n3: Exit");

                    string choice = Console.ReadLine();

                    if (choice == "1")
                    {
                        Console.WriteLine("Bowser's Koopalings kidnapped Princess Peach. Time to rescue her!");
                        World1_1(); 
                    }
                    else if (choice == "2")
                    {
                        Console.WriteLine("Instructions: This is a text-based adventure game. You will be given choices at every step that will impact your adventure. You can also type 'hint' if you're stuck. Good luck.\n");
                        MainMenu(); 
                    }
                    else if (choice == "3")
                    {
                        Console.WriteLine("Exiting game. Goodbye!");
                        Environment.Exit(0); 
                    }
                    else if (choice == "hint")
                    {
                        Console.WriteLine("Hint: You only have 2 fucking choices you braindead fucking idiot. flip a fucking coin or something, retard.");
                    }

                    else
                    {
                        Console.WriteLine("Invalid option. Try again.");
                        MainMenu(); 
                    }
                }

                static void World1_1()
                {
                    Console.WriteLine("\nYou start your adventure in World 1-1.");
                    Console.WriteLine("You encounter a Goomba. What do you do?");
                    Console.WriteLine("1: Stomp\n2: Pass");

                    string choice = Console.ReadLine();
                    if (choice == "1")
                    {
                        Console.WriteLine("You stomp on the Goomba, killing it instantly. You see its brain splat on the pavement, and this gives you severe PTSD.");
                    }
                    else if (choice == "2")
                    {
                        Console.WriteLine("You jump over the Goomba and move on.");
                    }
                    else if (choice == "hint")
                    {
                        Console.WriteLine("Hint: You only have 2 fucking choices you braindead fucking idiot. flip a fucking coin or something, retard.");
                    }
                    else
                    {
                        Console.WriteLine("Invalid option. Try again.");
                        World1_1(); 
                        return;
                    }

                    EncounterBlock();
                }

                static void EncounterBlock()
                {
                    Console.WriteLine("\nYou encounter a ?-block. Will you hit it?");
                    Console.WriteLine("1: Yes\n2: No");

                    string choice = Console.ReadLine();
                    if (choice == "1")
                    {
                        Console.WriteLine("You hit the ?-block. A mushroom comes out. You take it and get an insane shroom trip. You feel bigger and stronger.");
                    }
                    else if (choice == "2")
                    {
                        Console.WriteLine("You pass the ?-block because you're a whiny little loser.");
                    }
                    else if (choice == "hint")
                    {
                        Console.WriteLine("Hint: You only have 2 fucking choices you braindead fucking idiot. flip a fucking coin or something, retard.");
                    }
                    else
                    {
                        Console.WriteLine("Invalid option. Try again.");
                        EncounterBlock(); 
                        return;
                    }

                    EncounterPipe();
                }

                static void EncounterPipe()
                {
                    Console.WriteLine("\nYou encounter a pipe. Will you go in?");
                    Console.WriteLine("1: Yes\n2: No");

                    string choice = Console.ReadLine();
                    if (choice == "1")
                    {
                        Console.WriteLine("You go in and find a shiny star coin. Congratulations! You find a drug dealer and spend that star coin on some fentanyl.");
                    }
                    else if (choice == "2")
                    {
                        Console.WriteLine("You pass the pipe, why? Because you're a whiny, little, fucking, loser.");
                    }
                    else if (choice == "hint")
                    {
                        Console.WriteLine("Hint: You only have 2 fucking choices you braindead fucking idiot. flip a fucking coin or something, retard.");
                    }
                    else
                    {
                        Console.WriteLine("Invalid option. Try again.");
                        EncounterPipe(); 
                        return;
                    }

                    World1_3();
                }

                static void World1_3()
                {
                    Console.WriteLine("\nYou finish the level and head to World 1-3.");
                    Console.WriteLine("You find Yoshi smoking a joint all by himself. He offers you a hit. Do you accept?");
                    Console.WriteLine("1: Yes\n2: No");

                    string choice = Console.ReadLine();
                    if (choice == "1")
                    {
                        Console.WriteLine("You take a hit. That's some strong shit! You pass out and Yoshi takes you to the nearest building: 1-Tower.");
                        Tower1();
                    }
                    else if (choice == "2")
                    {
                        Console.WriteLine("Yoshi tells you to go fuck yourself. This hurt your feelings. You inject some fentanyl and find yourself in front of a tower.");
                        Tower1();
                    }
                    else if (choice == "hint")
                    {
                        Console.WriteLine("Hint: You only have 2 fucking choices you braindead fucking idiot. flip a fucking coin or something, retard.");
                    }
                    else
                    {
                        Console.WriteLine("Invalid option. Try again.");
                        World1_3(); 
                        return;
                    }
                }

                static void Tower1()
                {
                    Console.WriteLine("\nYou enter the tower and hear a terrifying laugh echoing down. Do you proceed?");
                    Console.WriteLine("1: Yes\n2: No");

                    string choice = Console.ReadLine();
                    if (choice == "1")
                    {
                        Console.WriteLine("You move up, encountering a swinging platform. Do you jump left or right?");
                        Console.WriteLine("1: Left\n2: Right");

                        string platformChoice = Console.ReadLine();
                        if (platformChoice == "1")
                        {
                            Console.WriteLine("You found some coins and a star coin! You bribe Larry with the coins and he lets you pass.");
                        }
                        else if (platformChoice == "2")
                        {
                            Console.WriteLine("You encounter Dry Bones, but he's weak as fuck. You reach the top where Larry awaits.");
                            Console.WriteLine("You try to bribe him but he shoots you through the skull. Luckily, you respawn.");
                        }
                        else if (choice == "hint")
                        {
                            Console.WriteLine("Hint: You only have 2 fucking choices you braindead fucking idiot. flip a fucking coin or something, retard.");
                        }
                        else
                        {
                            Console.WriteLine("Invalid option. Try again.");
                            Tower1(); 
                            return;
                        }

                        World5_1();
                    }
                    else
                    {
                        Console.WriteLine("Invalid option. Try again.");
                        Tower1(); 
                        return;
                    }
                }

                static void World5_1()
                {
                    Console.WriteLine("\nYou enter World 5-1. Walking Piranha Plants are in your way. What will you do?");
                    Console.WriteLine("1: Jump\n2: Fight");

                    string choice = Console.ReadLine();
                    if (choice == "1")
                    {
                        Console.WriteLine("The Piranha Plant bites your legs, but you rip its eyes out and move on.");
                    }
                    else if (choice == "2")
                    {
                        Console.WriteLine("You pull out your Glock and shoot the Piranha in the head.");
                    }
                    else if (choice == "hint")
                    {
                        Console.WriteLine("Hint: You only have 2 fucking choices you braindead fucking idiot. flip a fucking coin or something, retard.");
                    }
                    else
                    {
                        Console.WriteLine("Invalid option. Try again.");
                        World5_1(); 
                        return;
                    }

                    VinesAndPlatforms();
                }

                static void VinesAndPlatforms()
                {
                    Console.WriteLine("\nYou encounter vines and platforms. Choose your path:");
                    Console.WriteLine("1: Vines\n2: Platforms");

                    string pathChoice = Console.ReadLine();
                    if (pathChoice == "1")
                    {
                        Console.WriteLine("You swing across the vines, kicking Piranha Plants into pits.");
                    }
                    else if (pathChoice == "2")
                    {
                        Console.WriteLine("You jump across platforms, shooting unarmed Piranhas in the head.");
                    }
                    else if (pathChoice == "hint")
                    {
                        Console.WriteLine("Hint: You only have 2 fucking choices you braindead fucking idiot. flip a fucking coin or something, retard.");
                    }
                    else
                    {
                        Console.WriteLine("Invalid option. Try again.");
                        VinesAndPlatforms(); 
                        return;
                    }

                    Tower5();
                }

                static void Tower5()
                {
                    Console.WriteLine("\nYou arrive at World 5-Tower. Roy Koopa is waiting at the top. You encounter a series of traps.");
                    Console.WriteLine("Midway through, you find a ?-block. Will you hit it?");
                    Console.WriteLine("1: Yes\n2: No");

                    string choice = Console.ReadLine();
                    if (choice == "1")
                    {
                        Console.WriteLine("You get a Fire Flower! You’re armed with fireballs now.");
                    }
                    else if (choice == "2")
                    {
                        Console.WriteLine("You ignore the block and press on.");
                    }
                    else if (choice == "hint")
                    {
                        Console.WriteLine("Hint: You only have 2 fucking choices you braindead fucking idiot. flip a fucking coin or something, retard.");
                    }
                    else
                    {
                        Console.WriteLine("Invalid option. Try again.");
                        Tower5(); 
                        return;
                    }

                    Console.WriteLine("Roy appears, holding dual Desert Eagles.");
                    Console.WriteLine("1: Charge\n2: Keep Distance");

                    string fightChoice = Console.ReadLine();
                    if (fightChoice == "1")
                    {
                        Console.WriteLine("You charge at Roy, dodging his bullets and landing a fiery punch to his face.");
                    }
                    else if (fightChoice == "2")
                    {
                        Console.WriteLine("You keep your distance, firing fireballs. After a few hits, Roy goes down.");
                    }
                    else if (choice == "hint")
                    {
                        Console.WriteLine("Hint: You only have 2 fucking choices you braindead fucking idiot. flip a fucking coin or something, retard.");
                    }
                    else
                    {
                        Console.WriteLine("Invalid option. Try again.");
                        Tower5(); 
                        return;
                    }

                    World8();
                }

                static void World8()
                {
                    Console.WriteLine("\nWelcome to World 8. Lava flows and enemies swarm as you approach Bowser’s Castle.");
                    Console.WriteLine("After braving countless hazards, you arrive at Bowser’s throne room.");
                    Console.WriteLine("He’s got a rocket launcher and machine guns. How will you fight him?");
                    Console.WriteLine("1: Guns Blazing\n2: Strategic");

                    string choice = Console.ReadLine();
                    if (choice == "1")
                    {
                        Console.WriteLine("You charge in, guns blazing. Bowser shoots you, but you respawn and eventually defeat him.");
                    }
                    else if (choice == "2")
                    {
                        Console.WriteLine("You take cover, planning your attacks. You outsmart Bowser and take him down with precision.");
                    }
                    else if (choice == "hint")
                    {
                        Console.WriteLine("Hint: You only have 2 fucking choices you braindead fucking idiot. flip a fucking coin or something, retard.");
                    }
                    else
                    {
                        Console.WriteLine("Invalid option. Try again.");
                        World8(); 
                        return;
                    }

                    Console.WriteLine("Congratulations! You saved Princess Peach and completed the adventure!");
                    MainMenu(); 
                }
            }
        }
    }


}
