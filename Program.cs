// the ourAnimals array will store the following: 
using System;
//using Internal;

string animalSpecies = "";
string animalID = "";
string animalAge = "";
string animalPhysicalDescription = "";
string animalPersonalityDescription = "";
string animalNickname = "";

// variables that support data entry
int maxPets = 8;
string? readResult;
string menuSelection = "";

// array used to store runtime data, there is no persisted data
string[,] ourAnimals = new string[maxPets, 6];

// create some initial ourAnimals array entries
for (int i = 0; i < maxPets; i++)
{
    switch (i)
    {
        case 0:
            animalSpecies = "dog";
            animalID = "d1";
            animalAge = "2";
            animalPhysicalDescription = "medium sized cream colored female golden retriever weighing about 65 pounds. housebroken.";
            animalPersonalityDescription = "loves to have her belly rubbed and likes to chase her tail. gives lots of kisses.";
            animalNickname = "lola";
            break;

        case 1:
            animalSpecies = "dog";
            animalID = "d2";
            animalAge = "9";
            animalPhysicalDescription = "large reddish-brown male golden retriever weighing about 85 pounds. housebroken.";
            animalPersonalityDescription = "loves to have his ears rubbed when he greets you at the door, or at any time! loves to lean-in and give doggy hugs.";
            animalNickname = "loki";
            break;

        case 2:
            animalSpecies = "cat";
            animalID = "c3";
            animalAge = "1";
            animalPhysicalDescription = "small white female weighing about 8 pounds. litter box trained.";
            animalPersonalityDescription = "friendly";
            animalNickname = "Puss";
            break;

        case 3:
            animalSpecies = "cat";
            animalID = "c4";
            animalAge = "?";
            animalPhysicalDescription = "";
            animalPersonalityDescription = "";
            animalNickname = "";
            break;

        default:
            animalSpecies = "";
            animalID = "";
            animalAge = "";
            animalPhysicalDescription = "";
            animalPersonalityDescription = "";
            animalNickname = "";
            break;
    }

    ourAnimals[i, 0] = "ID #: " + animalID;
    ourAnimals[i, 1] = "Species: " + animalSpecies;
    ourAnimals[i, 2] = "Age: " + animalAge;
    ourAnimals[i, 3] = "Nickname: " + animalNickname;
    ourAnimals[i, 4] = "Physical description: " + animalPhysicalDescription;
    ourAnimals[i, 5] = "Personality: " + animalPersonalityDescription;
}

// display the top-level menu options

do
{
    Console.Clear();

    Console.WriteLine("Welcome to the Contoso PetFriends app. Your main menu options are:");
    Console.WriteLine(" 1. List all of our current pet information");
    Console.WriteLine(" 2. Add a new animal friend to the ourAnimals array");
    Console.WriteLine(" 3. Ensure animal ages and physical descriptions are complete");
    Console.WriteLine(" 4. Ensure animal nicknames and personality descriptions are complete");
    Console.WriteLine(" 5. Edit an animal’s age");
    Console.WriteLine(" 6. Edit an animal’s personality description");
    Console.WriteLine(" 7. Display all cats with a specified characteristic");
    Console.WriteLine(" 8. Display all dogs with a specified characteristic");
    Console.WriteLine();
    Console.WriteLine("Enter your selection number (or type Exit to exit the program)");

    readResult = Console.ReadLine();
    if (readResult != null)
    {
        menuSelection = readResult.ToLower();
    }

    Console.WriteLine($"You selected menu option {menuSelection}.");
    Console.WriteLine("Press the Enter key to continue");

    switch (menuSelection)
    {
        case "1":
            // List all of our current pet information
            //Cannot use foreach loop here because it is multidimensional array
            //Need to use the for loop
            //Also cannot use the ourAnimals.Length property on the array either, because it is multidimensional
            //C# will think there is 48 entries 8 max animals * 6 columnns of characteristics
            //Need to use the maxPets variable here
            for (int i = 0; i < maxPets; i++)
            {
                if (ourAnimals[i,0] != "ID #: ")
                {
                    //Interesting syntax here, as opposed to PHP where this would be
                    //ourAnimals[i][0], we use a comma to get the other dimension in the array!
                    Console.WriteLine();
                    //Why are we hardcoding 6 here?
                    //Hardcoding to six because the array only has six columns! 
                    for (int j = 0; j < 6; j++)
                    {
                        Console.WriteLine(ourAnimals[i, j]);
                    }
                }
            }
            readResult = Console.ReadLine();
            break;
        case "2":
            // Add a new animal friend to the ourAnimals array
            string anotherPet = "y";
            int petCount = 0;
            
            for (int i = 0; i < maxPets; i++)
            {
                if (ourAnimals[i, 0] != "ID #: ")
                {
                    petCount++;
                }
            }

            if(petCount < maxPets)
            {
                Console.WriteLine($"We currently have {petCount} pets that need homes. We can manage {(maxPets - petCount)} more.");
            }

            while(anotherPet == "y" && petCount < maxPets)
            {
                while (anotherPet == "y" && petCount < maxPets)
                {
                    bool validEntry = false;

                    do
                    {
                        Console.WriteLine("\n\rEnter 'dog' or 'cat' to begin a new entry");
                        readResult = Console.ReadLine();
                        if(readResult != null)
                        {
                            animalSpecies = readResult.ToLower();
                            if (animalSpecies != "dog" && animalSpecies != "cat")
                            {
                                Console.WriteLine($"You entered: {animalSpecies}.");
                                validEntry = false;
                            }
                            else
                            {
                                validEntry = true;


                            }
                        }
                    } while (validEntry == false);

                    // build the animal the ID number - for example C1, C2, D3 (for Cat 1, Cat 2, Dog 3)
                    animalID = animalSpecies.Substring(0, 1) + (petCount + 1).ToString();

                    // get the pet's age. can be ? at initial entry.
                    do
                    {
                        int petAge;
                        Console.WriteLine("Enter the pet's age or enter ? if unknown");
                        readResult = Console.ReadLine();
                        if (readResult != null)
                        {
                            animalAge = readResult;
                            if (animalAge != "?")
                            {
                                validEntry = int.TryParse(animalAge, out petAge);
                                
                            }
                            else
                            {
                                validEntry = true;
                            }
                        }
                    } while (validEntry == false);

                    // get a description of the pet's physical appearance/condition - animalPhysicalDescription can be blank.
                    do
                    {
                        Console.WriteLine("Enter a physical description of the pet (size, color, gender, weight, housebroken)");
                        readResult = Console.ReadLine();
                        if (readResult != null)
                        {
                            animalPhysicalDescription = readResult.ToLower();
                            if (animalPhysicalDescription == "")
                            {
                                animalPhysicalDescription = "tbd";
                            }
                        }
                    } while (animalPhysicalDescription == "");

                    // get a description of the pet's personality - animalPersonalityDescription can be blank.
                    do
                    {
                        Console.WriteLine("Enter a description of the pet's personality (likes or dislikes, tricks, energy level)");
                        readResult = Console.ReadLine();
                        if (readResult != null)
                        {
                            animalPersonalityDescription = readResult.ToLower();
                            if (animalPersonalityDescription == "")
                            {
                                animalPersonalityDescription = "tbd";
                            }
                        }
                    } while (animalPersonalityDescription == "");

                    // get the pet's nickname. animalNickname can be blank.
                    do
                    {
                        Console.WriteLine("Enter a nickname for the pet");
                        readResult = Console.ReadLine();
                        if (readResult != null)
                        {
                            animalNickname = readResult.ToLower();
                            if (animalNickname == "")
                            {
                                animalNickname = "tbd";
                            }
                        }
                    } while (animalNickname == "");

                    // store the pet information in the ourAnimals array (zero based)
                    ourAnimals[petCount, 0] = "ID #: " + animalID;
                    ourAnimals[petCount, 1] = "Species: " + animalSpecies;
                    ourAnimals[petCount, 2] = "Age: " + animalAge;
                    ourAnimals[petCount, 3] = "Nickname: " + animalNickname;
                    ourAnimals[petCount, 4] = "Physical description: " + animalPhysicalDescription;
                    ourAnimals[petCount, 5] = "Personality: " + animalPersonalityDescription;

                    // increment petCount (the array is zero-based, so we increment the counter after adding to the array)
                    petCount = petCount + 1;

                    // check maxPet limit
                    if (petCount < maxPets)
                    {
                        // another pet?
                        Console.WriteLine("Do you want to enter info for another pet (y/n)");
                        do
                        {
                            readResult = Console.ReadLine();
                            if (readResult != null)
                            {
                                anotherPet = readResult.ToLower();
                            }

                        } while (anotherPet != "y" && anotherPet != "n");
                    }
                }

                if (petCount >= maxPets)
                {
                    Console.WriteLine("We have reached our limit on the number of pets that we can manage.");
                    Console.WriteLine("Press the Enter key to continue.");
                    readResult = Console.ReadLine();
                }
            }

            readResult = Console.ReadLine();
            break;
        case "3":
            for(int i = 0; i < maxPets; i++)
            {
                //Prompt the user for the age of the animal
                if (ourAnimals[i,0] != "ID :# " && ourAnimals[i,2] == "Age: ?")
                {
                    bool ageMissing = false;
                    int updatedAge = 0;

                    do
                    {
                        Console.WriteLine($"Enter an age for ID#: {ourAnimals[i, 0]}");
                        readResult = Console.ReadLine();
                        if(readResult != null)
                        {
                            ageMissing = int.TryParse(readResult, out updatedAge);
                        }else
                        {
                            ageMissing = false;
                        }
                        

                    } while (!ageMissing);


                    Console.WriteLine($"You entered {updatedAge} for ID#{ourAnimals[i, 0]}");
                    //ourAnimals[i, 2] = "Age: " + updatedAge;
                }

                //Now prompt the user for physical properties
                if (!ourAnimals[i, 0].Equals("ID #: ") && !string.IsNullOrWhiteSpace(ourAnimals[i, 0]) && ourAnimals[i, 4] == "Physical description: ")
                {
                    bool physicalDescriptionMissing = false;
                    string physicalDescriptionUpdate = string.Empty;

                    do
                    {
                        Console.WriteLine($"Enter a physical description for {ourAnimals[i, 0]} (size, color, breed, gender, weight, housebroken)");

                        readResult = Console.ReadLine();
                        if (!string.IsNullOrWhiteSpace(readResult))
                        {
                            physicalDescriptionUpdate = readResult;
                            physicalDescriptionMissing = true;
                        }
                        else
                        {
                            physicalDescriptionMissing = false;
                        }
                    } while (!physicalDescriptionMissing);

                    Console.WriteLine($"You entered {physicalDescriptionUpdate} for {ourAnimals[i, 0]}");
                    ourAnimals[i, 4] = "Physical description: " + physicalDescriptionUpdate;


                }

            }

            Console.WriteLine("Age and physical description fields are complete for all of our friends. \n");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;
        case "4":
            for (int i = 0; i < maxPets; i++)
            {
                //Check if the animal does not have a nickname! 
                if (ourAnimals[i, 0] != "ID #: " && ourAnimals[i, 3] == "Nickname: " && ourAnimals[i,1] != "Species: ")
                {
                    bool leaveNickNameLoop = false;
                    string updatedNickName = string.Empty;

                    do
                    {
                        Console.WriteLine($"Enter a nickname for {ourAnimals[i, 0]}");

                        readResult = Console.ReadLine();
                        if (!string.IsNullOrWhiteSpace(readResult))
                        {
                            updatedNickName = readResult;
                            leaveNickNameLoop = true;
                        }
                        else
                        {
                            leaveNickNameLoop = false;
                        }


                    } while (!leaveNickNameLoop);

                    Console.WriteLine($"You entered {updatedNickName} for {ourAnimals[i, 0]}");
                    ourAnimals[i, 3] = "Nickname: " + updatedNickName;
                }

                //Check if the animal does not have a personality type set
                if (ourAnimals[i, 0] != "ID #: " && ourAnimals[i, 5] == "Personality: " && ourAnimals[i, 1] != "Species: ")
                {
                    bool leavePersonalityLoop = false;
                    string updatePersonality = string.Empty;

                    do
                    {
                        Console.WriteLine($"Enter a personality description for {ourAnimals[i, 0]} (likes or dislikes, tricks, energy level)" );

                        readResult = Console.ReadLine();
                        if (!string.IsNullOrWhiteSpace(readResult))
                        {
                            updatePersonality = readResult;
                            leavePersonalityLoop = true;
                        }
                        else
                        {
                            leavePersonalityLoop = false;
                        }


                    } while (!leavePersonalityLoop);

                    Console.WriteLine($"You entered {updatePersonality} for {ourAnimals[i, 0]}");
                    ourAnimals[i, 5] = "Nickname: " + updatePersonality;
                }


            }
            Console.WriteLine("Nickname and personality description fields are complete for all of our friends. \n");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();

            break;
        case "5":
            break;
        case "6":
            break;
        case "7":
            break;
        case "8":
            break;
        default:
            Console.WriteLine("Menu selection not supported.");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;


    }


    // pause code execution
    readResult = Console.ReadLine();
} while (menuSelection != "exit");
