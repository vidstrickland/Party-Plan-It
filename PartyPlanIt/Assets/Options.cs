using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Options : MonoBehaviour {

    public enum Food { Cake, Bar, Lobster, Horsdoeuvres };

    public enum Entertainer { Clown, Singer, Lecturer, Priest};

    public enum Attire { Toga, Casual, Business, BlackTie};

    public enum Music { Polka, Pop, Elevator, Chamber};

    public enum Type { Birthday, Wedding, Office, Funeral};

    public static bool SameType(Food first, Food second)
    {
        if((int)first <= 1 && (int)second <= 1) { return true; }
        else if((int)first >= 2 && (int)second >=2) { return true; }
        else { return false; }
    }

    public static bool SameType(Type first, Type second)
    {
        if ((int)first <= 1 && (int)second <= 1) { return true; }
        else if ((int)first >= 2 && (int)second >= 2) { return true; }
        else { return false; }
    }

    public static bool SameType(Attire first, Attire second)
    {
        if ((int)first <= 1 && (int)second <= 1) { return true; }
        else if ((int)first >= 2 && (int)second >= 2) { return true; }
        else { return false; }
    }

    public static bool SameType(Music first, Music second)
    {
        if ((int)first <= 1 && (int)second <= 1) { return true; }
        else if ((int)first >= 2 && (int)second >= 2) { return true; }
        else { return false; }
    }

    public static bool SameType(Entertainer first, Entertainer second)
    {
        if ((int)first <= 1 && (int)second <= 1) { return true; }
        else if ((int)first >= 2 && (int)second >= 2) { return true; }
        else { return false; }
    }

    public static string ToText(Attire selection)
    {
        switch (selection)
        {
            case Attire.BlackTie:
                return "black tie";

            case Attire.Business:
                return "business clothes";

            case Attire.Casual:
                return "casual wear";

            case Attire.Toga:
                return "togas";

            default:
                return "wat?";
        }

    }

    public static string ToText(Type selection)
    {
        switch (selection)
        {
            case Type.Birthday:
                return "birthday party";

            case Type.Funeral:
                return "funeral";

            case Type.Office:
                return "office party";

            case Type.Wedding:
                return "wedding reception";

            default:
                return "wat?";
        }

    }

    public static string ToText(Music selection)
    {
        switch (selection)
        {
            case Music.Chamber:
                return "chamber music";

            case Music.Elevator:
                return "elevator music";

            case Music.Polka:
                return "polka";

            case Music.Pop:
                return "pop music";

            default:
                return "wat?";
        }

    }

    public static string ToText(Food selection)
    {
        switch (selection)
        {
            case Food.Lobster:
                return "lobster dinner";

            case Food.Bar:
                return "open bar";

            case Food.Horsdoeuvres:
                return "hors d\'oeuvres";

            case Food.Cake:
                return "cake and icecream";

            default:
                return "wat?";
        }

    }

    public static string ToText(Entertainer selection)
    {
        switch (selection)
        {
            case Entertainer.Clown:
                return "clown";

            case Entertainer.Lecturer:
                return "lecturer";

            case Entertainer.Priest:
                return "priest";

            case Entertainer.Singer:
                return "singer";

            default:
                return "wat?";
        }

    }
}
