using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OrderGenerator : MonoBehaviour
{

    // MUSIC DIALOGUE
    string[] firstChoiceFirstDialogue = {
        "The attendees",
        "There’s no instrument I love more than",
        "My neighbor performs"
    };
    string[] firstChoiceSecondDialogue = {
        "and we’re looking forward to",
        "For that reason, I want our party to have a",
        "In order for the attendees to enjoy their music, we need to have"
    };
    // MUSIC GROUP 1
    string[] firstChoiceGroup1Item = {
        "are of Bohemian ancestry",       // POLKA
		"love Top 40",                    // POP
		"enjoy smooth jazz",              // ELEVATOR
		"only listen to Classical music"  // CHAMBER
	};

    string[] firstChoiceGroup1Style = {
        "busting a move all night.",  // POLKA-POP
		"a stellar performance."      // ELEVATOR-CHAMBER
	};
    // MUSIC GROUP 2
    string[] firstChoiceGroup2Item = {
        "the accordion",                  // POLKA
		"the synthesizer",                // POP
		"the soprano sax",                // ELEVATOR
		"the cello"                       // CHAMBER
	};
    string[] firstChoiceGroup2Style = {
        "dance.",                     // POLKA-POP
		"concert performance."        // ELEVATOR-CHAMBER
	};
    // MUSIC GROUP 3
    string[] firstChoiceGroup3Item = {
        "in the local polka hall’s group",          // POLKA
		"at dance clubs across the solar system",   // POP
		"with a production music outfit",           // ELEVATOR
		"for the interplanetary string quartet"     // CHAMBER
	};
    string[] firstChoiceGroup3Style = {
        "a dancefloor.",                  // POLKA-POP
		"auditorium seating."             // ELEVATOR-CHAMBER
	};
    // CATERING DIALOGUE
    string[] secondChoiceFirstDialogue = {
        "Our guests really can’t wait to",
        "Everyone absolutely loves",
        "I’ve made absolutely sure that"
    };
    string[] secondChoiceSecondDialogue = {
        "This will hopefully",
        "Just make sure that the guests don’t",
        "This could only be ruined if"
    };
    // CATERING GROUP 1
    string[] secondChoiceGroup1Item = {
        "eat cake until they become the Moon’s new satellite",               // CAKE + ICE CREAM
		"forget about their troubles and the rest of the night",             // OPEN BAR
		"figure out the correct order of forks and spoons to use to eat",    // LOBSTER DINNER
		"berate the waiter for not having enough tiny hot dogs on sticks"    // HORS DOEUVRES
	};

    string[] secondChoiceGroup1Style = {
        "increase activity from the guests.",                      // CAKE + ICE CREAM & OPEN BAR
		"highlight the importance and gravity of this event."      // LOBSTER DINNER & HORS DOEUVRES
	};
    // CATERING GROUP 2
    string[] secondChoiceGroup2Item = {
        "more sugar than the human body can handle",                                // CAKE + ICE CREAM
		"crippling reliance on drinking to make it through social situations",      // OPEN BAR
		"sticking their pinky out during dinner, it's a great wrist workout",       // LOBSTER DINNER
		"microscopic food portions"                                                 // HORS DOEUVRES
	};
    string[] secondChoiceGroup2Style = {
        "get anything on the control panels.",                               // CAKE + ICE CREAM & OPEN BAR
		"play with their food, we are dignified people, not animals."        // LOBSTER DINNER & HORS DOEUVRES
	};
    // CATERING GROUP 3
    string[] secondChoiceGroup3Item = {
        "no dancers have stowed away, before or after the cake has been baked",      // CAKE + ICE CREAM
		"we have stocked only the biggest and cheapest bottles we could find",       // OPEN BAR
		"everyone is not allergic to shellfish nor are they selfish",                // LOBSTER DINNER
		"the cheese platter has been harvested from the moon"                        // HORS DOEUVRES
	};
    string[] secondChoiceGroup3Style = {
        "people have so much they get sick.",                 // POLKA-POP
		"the waiters rebel against those they serve."         // LOBSTER DINNER & HORS DOEUVRES
	};
    // PARTY TYPE DIALOGUE
    string[] thirdChoiceFirstDialogue = {
        "We are looking to",
        "We are really looking forward to",
        "Make sure to bring"
    };
    string[] thirdChoiceSecondDialogue = {
        "I hope you",
        "just make sure",
        "as long as we don't have a repeat of last year when"
    };
    // PARTY TYPE GROUP 1
    string[] thirdChoiceGroup1Item = {
        "celebrate the uteral liberation of Joey",        //Birthday
		"join together ___ and ___ in space matrimony",   //Wedding
		"improve workplace synergy",                      //Office
		"shoot ____ into space"                           //Funeral
	};

    string[] thirdChoiceGroup1Style = {
        "take this seriously.",      //Birthday-Wedding
		"have fun with it."          //Office-Funeral
	};
    // PARTY TYPE GROUP 2
    string[] thirdChoiceGroup2Item = {
        "playing pin the harpoon on the moon whale",                  //Birthday
		"the overly long vows",                                       //Wedding
		"trust falls",                                                //Office
		"returning Uncle Roger to the void from whence he came"       //Funeral
	};
    string[] thirdChoiceGroup2Style = {
        "there is a table for presents.",             //Birthday-Wedding
		"there is hand sanitizer and tissues."        //Office-Funeral
	};
    // PARTY TYPE GROUP 3
    string[] thirdChoiceGroup3Item = {
        "only the funniest party hats",     //Birthday
		"the galactic bonding bands",       //Wedding
		"the safe for work board games",    //Office
		"the body rocket"                   //Funeral
	};
    string[] thirdChoiceGroup3Style = {
        "the -female relative- made it about herself.",  //Birthday-Wedding
		"Joey had a mental breakdown."                   //Office-Funeral
	};
    // ATTIRE DIALOGUE
    string[] fourthChoiceFirstDialogue = {
        "Make sure the invitations specify",
        "The theme of this party is",
        "Please include instructions"
    };
    string[] fourthChoiceSecondDialogue = {
        "We want to avoid people coming to the party",
        "Everyone is expected to dress appropriately and",
        "The last party’s theme was a disaster, so we want it to be"
    };
    // ATTIRE GROUP 1
    string[] fourthChoiceGroup1Item = {
        "they should come in Greek/Roman attire",   // Toga
		"this is a jeans & T-shirt party",          // Casual
		"to come dressed in business attire",       // Business
		"this is a “Black Tie only” event"          // Black Tie
	};

    string[] fourthChoiceGroup1Style = {
        "overdressed.",     // Toga/Casual
		"underdressed."     // Business/Black Tie
	};
    // ATTIRE GROUP 2
    string[] fourthChoiceGroup2Item = {
        "“Civilizations of the Past”",  // Toga
		"“20th Century Casual”",        // Casual
		"“Corporate Appearance”",       // Office
		"“Upper Crust”"                 // Black Tie
	};
    string[] fourthChoiceGroup2Style = {
        "have fun.",    // Toga/Casual
		"respectfully." // Office/Black Tie
	};
    // ATTIRE GROUP 3
    string[] fourthChoiceGroup3Item = {
        "for how to make a toga from bedsheets",    // Toga
		"to come wearing whatever you please",      // Casual
		"to follow company dress code",             // Business
		"to come dressed to the nines"              // Black Tie
	};
    string[] fourthChoiceGroup3Style = {
        "more spontaneous.",    // Toga/Casual
		"more reserved."        // Business/Black Tie
	};
    // ENTERTAINER DIALOGUE
    string[] fifthChoiceFirstDialogue = {
        "Our special guest is going to be",
        "I’ve heard that all the best parties hire",
        "Do you know"
    };
    string[] fifthChoiceSecondDialogue = {
        "Please make sure to provide a microphone and",
        "As you know, you can’t have a party without",
        "that’s available? The special guest we had scheduled cancelled on us, so we need a new"
    };
    // ENTERTAINER GROUP 1
    string[] fifthChoiceGroup1Item = {
        "Cozmo the Space Clown",                        // Clown
		"Beyoncéres",                                   // Singer
		"John T. Michelson and Michael Q. Johnson",     // Presenter
		"Father O’Rion"                                 // Priest
	};

    string[] fifthChoiceGroup1Style = {
        "stage lights.",  // Clown-Singer
		"a lectern."      // Presenter-Priest
	};
    // ENTERTAINER GROUP 2
    string[] fifthChoiceGroup2Item = {
        "The Crashlanded Clown",     // Clown
		"Pluto Mars",                // Singer
		"TON-33 Robitron 3000",      // Presenter
		"Rev. Eurin Gin"             // Priest
	};
    string[] fifthChoiceGroup2Style = {
        "some entertainment.",      // Clown-Singer
		"a special guest speaker."  // Presenter-Priest
	};
    // ENTERTAINER GROUP 3
    string[] fifthChoiceGroup3Item = {
        "a circus performer",          // Clown
		"a vocalist",     // Singer
		"a business guru",             // Presenter
		"a vicar"   // Priest
	};
    string[] fifthChoiceGroup3Style = {
        "performer.",                  // Clown-Singer
		"keynote speaker."                 // Presenter-Priest
	};


	public Text call;

    string[] firstDialogueArray = {
        "first",
        "second",
        "third",
        "fourth",
        "fifth"};

    string[] itemArray = {
        "first",
        "second",
        "third",
        "fourth",
        "fifth" };

    string[] secondDialogueArray = {
        "first",
        "second",
        "third",
        "fourth",
        "fifth"};

    string[] styleArray = {
        "first",
        "second",
        "third",
        "fourth",
        "fifth"};

    int[] difficultyArray = {
        0,
        0,
        0,
        0,
        0
    };

    int dialogueRandomizer;
    int itemRandomizer;

    int choiceCount;
    int removalLength;
    int choiceDifficulty;
    public int difficultyLimit;

    string choiceItem;

    public int numChoices;

    public int firstDifficultyDebug;

    public int secondDifficultyDebug;

    public int thirdDifficultyDebug;

    public int fourthDifficultyDebug;

    public int fifthDifficultyDebug;

    public int globalDifficulty;

	public int displayCount;

	public GameObject padLockScreen;

	public GameObject waveform;

	public GameObject launchPartyButton;

	public GameObject bigPhoto;

	public GameObject smallPhoto;

	public GameObject largePhoto;

    private ReviewGenerator review;

    //string[] firstChoiceOptions = {"Complete Message " + firstChoiceSelection, 
    //								"Incomplete Message " + firstChoiceSelection, 
    //								"Broken Message " + firstChoiceSelection};

    string[] completeMessage = { "First", "Second", "Third", "Fourth", "Fifth" };

    // Use this for initialization
    void Start()
    {
        globalDifficulty = 10;
        review = GameObject.FindObjectOfType<ReviewGenerator>();
        GenerateOrder();
    }

    void DifficultyCheck()
    {
        if (globalDifficulty > 6)
        {
            difficultyLimit = 2;
        }
        else if (globalDifficulty > 4)
        {
            difficultyLimit = 1;
        }
        else if (globalDifficulty <= 3)
        {
            difficultyLimit = 0;
        }
    }

    //Generate the party order
    public void GenerateOrder()
    {
        for (int i = 0; i < numChoices; i++)
        {
            GenerateChoice();
            DifficultyCheck();
            SignalScrambler();
			StringBuilder ();
            choiceCount++;
        }
    }

    void GenerateChoice()
    {
        //Generate three random numbers for use in this choice
        dialogueRandomizer = Random.Range(0, 3);
        itemRandomizer = Random.Range(0, 4);

        //Select a random difficulty between 0 and 2
        difficultyArray[choiceCount] = Random.Range(0, difficultyLimit + 1);


        //Difficulty Debugger (Set to 0, 1, or 2)
        //choiceDifficulty = 5;

        //Generate First Choice
        if (choiceCount == 0)
        {
            firstDifficultyDebug = difficultyArray[choiceCount];
            firstDialogueArray[choiceCount] = firstChoiceFirstDialogue[dialogueRandomizer];
            secondDialogueArray[choiceCount] = firstChoiceSecondDialogue[dialogueRandomizer];
            if (itemRandomizer == 0)
            {
                review.SetWanted(Options.Music.Polka);
            }
            else if (itemRandomizer == 1)
            {
                review.SetWanted(Options.Music.Pop);
            }
            else if (itemRandomizer == 2)
            {
                review.SetWanted(Options.Music.Elevator);
            }
            else
            {
                review.SetWanted(Options.Music.Chamber);
            }
            if (dialogueRandomizer == 0)
            {
                itemArray[choiceCount] = firstChoiceGroup1Item[itemRandomizer];
                if (itemRandomizer < 2)
                {
                    styleArray[choiceCount] = firstChoiceGroup1Style[0];
                }
                else
                {
                    styleArray[choiceCount] = firstChoiceGroup1Style[1];
                }
            }
            else if (dialogueRandomizer == 1)
            {
                itemArray[choiceCount] = firstChoiceGroup2Item[itemRandomizer];
                if (itemRandomizer < 2)
                {
                    styleArray[choiceCount] = firstChoiceGroup2Style[0];
                }
                else
                {
                    styleArray[choiceCount] = firstChoiceGroup2Style[1];
                }
            }
            else if (dialogueRandomizer == 2)
            {
                itemArray[choiceCount] = firstChoiceGroup3Item[itemRandomizer];
                if (itemRandomizer < 2)
                {
                    styleArray[choiceCount] = firstChoiceGroup3Style[0];
                }
                else
                {
                    styleArray[choiceCount] = firstChoiceGroup3Style[1];
                }
            }
            //Generate Second Choice
        }
        else if (choiceCount == 1)
        {
            secondDifficultyDebug = difficultyArray[choiceCount];
            firstDialogueArray[choiceCount] = secondChoiceFirstDialogue[dialogueRandomizer];
            secondDialogueArray[choiceCount] = secondChoiceSecondDialogue[dialogueRandomizer];
            if (itemRandomizer == 0)
            {
                review.SetWanted(Options.Food.Cake);
            }
            else if (itemRandomizer == 1)
            {
                review.SetWanted(Options.Food.Bar);
            }
            else if (itemRandomizer == 2)
            {
                review.SetWanted(Options.Food.Lobster);
            }
            else
            {
                review.SetWanted(Options.Food.Horsdoeuvres);
            }
            if (dialogueRandomizer == 0)
            {
                itemArray[choiceCount] = secondChoiceGroup1Item[itemRandomizer];
                if (itemRandomizer < 2)
                {
                    styleArray[choiceCount] = secondChoiceGroup1Style[0];
                }
                else
                {
                    styleArray[choiceCount] = secondChoiceGroup1Style[1];
                }
            }
            else if (dialogueRandomizer == 1)
            {
                itemArray[choiceCount] = secondChoiceGroup2Item[itemRandomizer];
                if (itemRandomizer < 2)
                {
                    styleArray[choiceCount] = secondChoiceGroup2Style[0];
                }
                else
                {
                    styleArray[choiceCount] = secondChoiceGroup2Style[1];
                }
            }
            else if (dialogueRandomizer == 2)
            {
                itemArray[choiceCount] = secondChoiceGroup3Item[itemRandomizer];
                if (itemRandomizer < 2)
                {
                    styleArray[choiceCount] = secondChoiceGroup3Style[0];
                }
                else
                {
                    styleArray[choiceCount] = secondChoiceGroup3Style[1];
                }
            }
            //Generate Third Choice
        }
        else if (choiceCount == 2)
        {
            thirdDifficultyDebug = difficultyArray[choiceCount];
            firstDialogueArray[choiceCount] = thirdChoiceFirstDialogue[dialogueRandomizer];
            secondDialogueArray[choiceCount] = thirdChoiceSecondDialogue[dialogueRandomizer];
            if (itemRandomizer == 0)
            {
                review.SetWanted(Options.Type.Birthday);
            }
            else if (itemRandomizer == 1)
            {
                review.SetWanted(Options.Type.Wedding);
            }
            else if (itemRandomizer == 2)
            {
                review.SetWanted(Options.Type.Office);
            }
            else
            {
                review.SetWanted(Options.Type.Funeral);
            }
            if (dialogueRandomizer == 0)
            {
                itemArray[choiceCount] = thirdChoiceGroup1Item[itemRandomizer];
                if (itemRandomizer < 2)
                {
                    styleArray[choiceCount] = thirdChoiceGroup1Style[0];
                }
                else
                {
                    styleArray[choiceCount] = thirdChoiceGroup1Style[1];
                }
            }
            else if (dialogueRandomizer == 1)
            {
                itemArray[choiceCount] = thirdChoiceGroup2Item[itemRandomizer];
                if (itemRandomizer < 2)
                {
                    styleArray[choiceCount] = thirdChoiceGroup2Style[0];
                }
                else
                {
                    styleArray[choiceCount] = thirdChoiceGroup2Style[1];
                }
            }
            else if (dialogueRandomizer == 2)
            {
                itemArray[choiceCount] = thirdChoiceGroup3Item[itemRandomizer];
                if (itemRandomizer < 2)
                {
                    styleArray[choiceCount] = thirdChoiceGroup3Style[0];
                }
                else
                {
                    styleArray[choiceCount] = thirdChoiceGroup3Style[1];
                }
            }
        }
        //Generate Fourth Choice
        else if (choiceCount == 3)
        {
            fourthDifficultyDebug = difficultyArray[choiceCount];
            firstDialogueArray[choiceCount] = fourthChoiceFirstDialogue[dialogueRandomizer];
            secondDialogueArray[choiceCount] = fourthChoiceSecondDialogue[dialogueRandomizer];
            if (itemRandomizer == 0)
            {
                review.SetWanted(Options.Attire.Toga);
            }
            else if (itemRandomizer == 1)
            {
                review.SetWanted(Options.Attire.Casual);
            }
            else if (itemRandomizer == 2)
            {
                review.SetWanted(Options.Attire.Business);
            }
            else
            {
                review.SetWanted(Options.Attire.BlackTie);
            }
            if (dialogueRandomizer == 0)
            {
                itemArray[choiceCount] = fourthChoiceGroup1Item[itemRandomizer];
                if (itemRandomizer < 2)
                {
                    styleArray[choiceCount] = fourthChoiceGroup1Style[0];
                }
                else
                {
                    styleArray[choiceCount] = fourthChoiceGroup1Style[1];
                }
            }
            else if (dialogueRandomizer == 1)
            {
                itemArray[choiceCount] = fourthChoiceGroup2Item[itemRandomizer];
                if (itemRandomizer < 2)
                {
                    styleArray[choiceCount] = fourthChoiceGroup2Style[0];
                }
                else
                {
                    styleArray[choiceCount] = fourthChoiceGroup2Style[1];
                }
            }
            else if (dialogueRandomizer == 2)
            {
                itemArray[choiceCount] = fourthChoiceGroup3Item[itemRandomizer];
                if (itemRandomizer < 2)
                {
                    styleArray[choiceCount] = fourthChoiceGroup3Style[0];
                }
                else
                {
                    styleArray[choiceCount] = fourthChoiceGroup3Style[1];
                }
            }
        }
        //Generate Fifth Choice
        else if (choiceCount == 4)
        {
            fifthDifficultyDebug = difficultyArray[choiceCount];
            firstDialogueArray[choiceCount] = fifthChoiceFirstDialogue[dialogueRandomizer];
            secondDialogueArray[choiceCount] = fifthChoiceSecondDialogue[dialogueRandomizer];
            if (itemRandomizer == 0)
            {
                review.SetWanted(Options.Entertainer.Clown);
            }
            else if (itemRandomizer == 1)
            {
                review.SetWanted(Options.Entertainer.Singer);
            }
            else if (itemRandomizer == 2)
            {
                review.SetWanted(Options.Entertainer.Lecturer);
            }
            else
            {
                review.SetWanted(Options.Entertainer.Priest);
            }
            if (dialogueRandomizer == 0)
            {
                itemArray[choiceCount] = fifthChoiceGroup1Item[itemRandomizer];
                if (itemRandomizer < 2)
                {
                    styleArray[choiceCount] = fifthChoiceGroup1Style[0];
                }
                else
                {
                    styleArray[choiceCount] = fifthChoiceGroup1Style[1];
                }
            }
            else if (dialogueRandomizer == 1)
            {
                itemArray[choiceCount] = fifthChoiceGroup2Item[itemRandomizer];
                if (itemRandomizer < 2)
                {
                    styleArray[choiceCount] = fifthChoiceGroup2Style[0];
                }
                else
                {
                    styleArray[choiceCount] = fifthChoiceGroup2Style[1];
                }
            }
            else if (dialogueRandomizer == 2)
            {
                itemArray[choiceCount] = fifthChoiceGroup3Item[itemRandomizer];
                if (itemRandomizer < 2)
                {
                    styleArray[choiceCount] = fifthChoiceGroup3Style[0];
                }
                else
                {
                    styleArray[choiceCount] = fifthChoiceGroup3Style[1];
                }
            }
        }
    }

    void SignalScrambler()
    {
        if (difficultyArray[choiceCount] == 0)
        {
            //Do Nothing, this is dummy space for the next time a new feature appears
        }
        else if (difficultyArray[choiceCount] == 1)
        {
            itemArray[choiceCount] = itemArray[choiceCount].Substring(2, itemArray[choiceCount].Length - 2);
            styleArray[choiceCount] = styleArray[choiceCount].Substring(2, styleArray[choiceCount].Length - 2);
            globalDifficulty -= 2;
        }
        else if (difficultyArray[choiceCount] == 2)
        {
            itemArray[choiceCount] = itemArray[choiceCount].Substring(4, itemArray[choiceCount].Length - 4);
            styleArray[choiceCount] = styleArray[choiceCount].Substring(4, styleArray[choiceCount].Length - 4);
            globalDifficulty -= 4;
        }
    }

	void StringBuilder()
    {
        if (difficultyArray[choiceCount] == 0)
        {
            completeMessage[choiceCount] = firstDialogueArray[choiceCount] + " " + itemArray[choiceCount] + " " + secondDialogueArray[choiceCount] + " " + styleArray[choiceCount];
            Debug.Log(completeMessage[choiceCount]);
        }
        else if (difficultyArray[choiceCount] == 1)
        {
            completeMessage[choiceCount] = firstDialogueArray[choiceCount] + " *skrssssssh*-" + itemArray[choiceCount] + "-*whiiiii* " + secondDialogueArray[choiceCount] + " *zzzzzt*-" + styleArray[choiceCount] + "-*kzt*";
            Debug.Log(completeMessage[choiceCount]);
        }
        else if (difficultyArray[choiceCount] == 2)
        {
            completeMessage[choiceCount] = firstDialogueArray[choiceCount] + " *SKKKKKKKK*-" + itemArray[choiceCount] + "-*SKRRRRRR* " + secondDialogueArray[choiceCount] + " *FSSSSSSSSSS*-" + styleArray[choiceCount] + "-*SHK*";
            Debug.Log(completeMessage[choiceCount]);
        }
	}

	public void Reset(){
		choiceCount = 0;
		displayCount = 0;
		globalDifficulty = 10;
	}

	public void DisplayCall(){
		if (displayCount < 5) {
			call.text = completeMessage [displayCount];
			waveform.transform.localScale = new Vector3 (315, 150, 1);
			launchPartyButton.transform.localScale = new Vector3 (0, 0, 0);
			displayCount++;
		}else if (displayCount == 5) {
			call.text = "";
			padLockScreen.transform.position = new Vector3 (2000, 2000, 0);
			waveform.transform.localScale = new Vector3 (0, 0, 0);
			launchPartyButton.transform.localScale = new Vector3 (1, 1, 1);
		}
	}

	public void DisplaySmallPhoto(){
		smallPhoto.transform.localScale = new Vector3 (0.4f, 0.4f, 4.6f);
	}

	public void DisplayLargePhoto(){
		largePhoto.transform.localScale = new Vector3 (1f, 1f, 1f);
		Debug.Log ("Firing");
	}
}