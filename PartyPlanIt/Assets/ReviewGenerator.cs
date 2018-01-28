using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReviewGenerator : MonoBehaviour {

    public Text display;

    public float score;

    //Texts
    public List<string> badStart;
    public List<string> midStart;
    public List<string> goodStart;

    public List<string> compliments;
    public List<string> critiques;

    public List<string> badEnd;
    public List<string> midEnd;
    public List<string> goodEnd;

    //Options
    Options.Food foodWanted;
    Options.Food foodGot;
    Options.Entertainer entertainerWanted;
    Options.Entertainer entertainerGot;
    Options.Music musicWanted;
	public Options.Music musicGot;
    Options.Attire attireWanted;
    Options.Attire attireGot;
    Options.Type typeGot;
    Options.Type typeWanted;

    
    public void SetGot(Options.Food set) { foodGot = set; }
    public void SetGot(Options.Entertainer set) { entertainerGot = set; }
    public void SetGot(Options.Music set) { musicGot = set; }
    public void SetGot(Options.Attire set) { attireGot = set; }
    public void SetGot(Options.Type set) { typeGot = set; }
    public void SetWanted(Options.Food set) { foodWanted = set; }
    public void SetWanted(Options.Entertainer set) { entertainerWanted = set; }
    public void SetWanted(Options.Music set) { musicWanted = set; }
    public void SetWanted(Options.Attire set) { attireWanted = set; }
    public void SetWanted(Options.Type set) { typeWanted = set; }

    string Generate()
    {
        //Opening sentance
        string review = "";
        if (score < -2)
        {
            review += badStart[Random.Range(0, badStart.Count)];
            if (typeGot != typeWanted) { review += "I asked for a " + Options.ToText(typeWanted) + ", but got a " + Options.ToText(typeGot) + ". "; }
        } else if(score <= 2)
        {
            review += midStart[Random.Range(0, midStart.Count)];
        } else
        {
            review += goodStart[Random.Range(0, goodStart.Count)];
        }

        //Specific complement

        if (foodGot == foodWanted)
        {
            review += compliments[Random.Range(0, compliments.Count)];
            review += Options.ToText(foodGot);
            review += ". ";
        }
        else if (entertainerGot == entertainerWanted)
        {
            review += compliments[Random.Range(0, compliments.Count)];
            review += Options.ToText(entertainerGot);
            review += ". ";
        }
        else if (musicGot == musicWanted)
        {
            review += compliments[Random.Range(0, compliments.Count)];
            review += Options.ToText(musicGot);
            review += ". ";
        }
        else if (attireGot == attireWanted)
        {
            review += compliments[Random.Range(0, compliments.Count)];
            review += Options.ToText(attireGot);
            review += ". ";
        }


        //specific critique

        if (musicGot != musicWanted)
        {
            review += critiques[Random.Range(0, critiques.Count)];
            review += Options.ToText(musicGot);
            review += ". ";
        }
        else if (foodGot != foodWanted)
        {
            review += critiques[Random.Range(0, critiques.Count)];
            review += Options.ToText(foodGot);
            review += ". ";
        }
        else if (entertainerGot != entertainerWanted)
        {
            review += critiques[Random.Range(0, critiques.Count)];
            review += Options.ToText(entertainerGot);
            review += ". ";
        }
        else if (attireGot != attireWanted)
        {
            review += critiques[Random.Range(0, critiques.Count)];
            review += Options.ToText(attireGot);
            review += ". ";
        }


        //Ending sentance
        if (score < -2)
        {
            review += badEnd[Random.Range(0, badEnd.Count)];
        }
        else if (score <= 2)
        {
            review += midEnd[Random.Range(0, midEnd.Count)];
        }
        else
        {
            review += goodEnd[Random.Range(0, goodEnd.Count)];
            if (typeGot == typeWanted) { review += "It was a great " + Options.ToText(typeGot) + ". "; }
        }

        return review;
    }
	
    int GetScore()
    {
        int newScore = 0;
        if (foodGot == foodWanted) { newScore++; }
        else if (Options.SameType(foodGot, foodWanted) == false) { newScore--; }
        if (musicGot == musicWanted) { newScore++; }
        else if (Options.SameType(musicGot, musicWanted) == false) { newScore--; }
        if (typeGot == typeWanted) { newScore++; }
        else if (Options.SameType(typeGot, typeWanted) == false) { newScore--; }
        if (attireGot == attireWanted) { newScore++; }
        else if (Options.SameType(attireGot, attireWanted) == false) { newScore--; }
        if (entertainerWanted == entertainerGot) { newScore++; }
        else if (Options.SameType(entertainerGot, entertainerWanted) == false) { newScore--; }

        return newScore;
    }

    // Update is called once per frame
    public void Begin()
    {
        score = GetScore();

        display.text = Generate();
    }

}
