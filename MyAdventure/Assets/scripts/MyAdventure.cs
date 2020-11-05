
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyAdventure : MonoBehaviour
{
    private enum States  //Staging list
    {
        start,
        intro1,
        intro2,
        delen,
        deelnee,
        deelja,
        leukgsprek,
        deeltadres,
        nacht,
        checksloten,
        checkramen,
        slaapkamer
    }

    private States currentState = States.start;  //set state to start for begin

    // Start is called before the first frame update

    void Start()  //starting void
    {
        ShowMainMenu();
    }


    // Update is called once per frame
    void Update()
    {

    }

    void ShowMainMenu() //main menu void
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Welkom bij Nacht");
        Terminal.WriteLine("");
        Terminal.WriteLine("Type start om de Beginnen.");
    }

    void OnUserInput(string input)  //On input change state section
    {
        if (currentState == States.start)
        {
            if (input == "start")
            {
                currentState = States.intro1;
                StartIntro();
            }
        }
        else if (currentState == States.intro1)
        {
            if (input == "verder")
            {
                currentState = States.intro2;
                StartIntro2();
            }
        }
        else if (currentState == States.deelja)
        {
            if (input == "verder")
            {
                currentState = States.nacht;
                nacht();
            }
        }
        else if (currentState == States.deelnee)
        {
            if (input == "verder")
            {
                currentState = States.nacht;
                nacht();
            }
        }
        else if (currentState == States.intro2)
        {
            if (input == "ja")
            {
                currentState = States.deelja;
                deelja();
            } else if (input == "nee")
            {
                currentState = States.deelnee;
                deelnee();
            }
        } else if (currentState == States.nacht) 
        {
        	if (input == "ja") 
        	{
        		currentState = States.checksloten;
        		checksloten();
        	} else 
        	{
        		currentState = States.checkramen;
        		checkramen();
        	}
        } else if (currentState == States.checkramen) 
        {
        	if (input == "woonkamer") 
        	{
        		EndGame();
        	} else if (input == "slaapkamer") 
        	{
        		SlaapKamer();
        		currentState = States.slaapkamer;
        	}
        } else if (currentState == States.slaapkamer) 
        {
        	if (input == "seinen") 
        	{
        		Seinen();
        	}else if (input == "verstoppen") 
        	{
        		Verstoppen();
        	}
        } else if (currentState == States.checksloten) 
        {
        	if (input == "badkamer") 
        	{
        		EndGame();
        	}else if (input == "slaapkamer") 
        	{
        		Verstoppen();
        	} else if (input == "woonkamer") 
        	{
        		Verstoppen();
        	}
        }
    }

    void StartIntro()  // all story lines
        {
            Terminal.ClearScreen();
            Terminal.WriteLine("Het was niet een normale winterse nacht.");
            Terminal.WriteLine("Alles was koud terwijl de verwarming overtoeren draaiden.");
            Terminal.WriteLine("Type verder om verder te gaan.");
        }

        void StartIntro2()
        {
            Terminal.ClearScreen();
            Terminal.WriteLine("Je zit een online game te spelen en krijgt een melding van Jostiband123.");
            Terminal.WriteLine("Hij vraagt om jou discord tag.");
            Terminal.WriteLine("Type ja om het te delen en nee voor het houden ervan.");
        }

        void deelja()
        {
            Terminal.ClearScreen();
            Terminal.WriteLine("Je Hebt jou discord tag Tosti_ijzer012#1337 gedeelt.");
            Terminal.WriteLine("Jullie gaan in call en spelen het spelletje uren lang.");
            Terminal.WriteLine("Het is nacht geworden en hij vraagt om je adres.");
            Terminal.WriteLine("Je Besluit om je adres te delen.");
            Terminal.WriteLine("type verder om verder te gaan.");

        }

        void deelnee()
        {
            Terminal.ClearScreen();
            Terminal.WriteLine("Je hebt je discord tag geheim gehouden.");
            Terminal.WriteLine("Maar je besluit wel om met hem online in de game te blijven praten.");
            Terminal.WriteLine("Het is nacht geworden en hij vraagt om je adres.");
            Terminal.WriteLine("Je geeft hem jou adres.");
            Terminal.WriteLine("type verder om verder te gaan.");
        }

        void nacht()
        {
            Terminal.ClearScreen();
            Terminal.WriteLine("Het is nacht geworden en je hoord raren geluiden.");
            Terminal.WriteLine("Ga je de sloten checken ja of nee de ramen.");
        }

        void checksloten() 
        {
        	Terminal.ClearScreen();
            Terminal.WriteLine("Je kijkt bij de sloten maar hoor iemand binnen stappen via het raam.");
            Terminal.WriteLine("Je besluit rond te rennen door het huis");
            Terminal.WriteLine("Waar verstop je? badkamer, slaapkamer, woonkamer");
        }

        void checkramen()
        {
        	Terminal.ClearScreen();
        	Terminal.WriteLine("Je gaat je ramen checken of ze dicht zitten.");
        	Terminal.WriteLine("Opeens valt het licht uit en je word bang");
        	Terminal.WriteLine("Je gaat opzoek naar een zaklamp, maar waar ligt die? woonkamer of slaapkamer");

        }

        void EndGame() 
        {
        	Terminal.ClearScreen();
        	Terminal.WriteLine("Je hebt de juiste keuzes gemaakt. Je hebt het gehaald");

        }

        void SlaapKamer() 
        {
        	Terminal.ClearScreen();
        	Terminal.WriteLine("Je hoord een raam door geslagen worden en wat ga je nu doen?");
        	Terminal.WriteLine("Seinen naar de buren zodat zij de politebelen of verstoppen onder het bed");
        }

        void Seinen() 
        {
        	Terminal.ClearScreen();
        	Terminal.WriteLine("Je seint naar de buren en zei bellen de politie je hebt de juiste keuze gemaakt en gewonnen.");

        }

        void Verstoppen() 
        {
        	Terminal.ClearScreen();
        	Terminal.WriteLine("Je hebt niet de goeie keuze gemaakt de boef komt je kamer in en maakt je dood.");
        }

}


