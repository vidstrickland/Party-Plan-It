using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionMenu : MonoBehaviour {

    Options.Attire selectedAttire;
    Options.Entertainer selectedEntertainer;
    Options.Food selectedFood;
    Options.Music selectedMusic;
    Options.Type selectedType;
    bool indoors;

    public List<GameObject> menus;

    ReviewGenerator review;

    public void Cake() { selectedFood = Options.Food.Cake; }
    public void Bar() { selectedFood = Options.Food.Bar; }
    public void Horsdoeuvres() { selectedFood = Options.Food.Horsdoeuvres; }
    public void Lobster() { selectedFood = Options.Food.Lobster; }

    public void Casual() { selectedAttire = Options.Attire.Casual; }
    public void Business() { selectedAttire = Options.Attire.Business; }
    public void Toga() { selectedAttire = Options.Attire.Toga; }
    public void BlackTie() { selectedAttire = Options.Attire.BlackTie; }

    public void Singer() { selectedEntertainer = Options.Entertainer.Singer; }
	public void Clown() { selectedEntertainer = Options.Entertainer.Clown; }
    public void Lecturer() { selectedEntertainer = Options.Entertainer.Lecturer; }
    public void Priest() { selectedEntertainer = Options.Entertainer.Priest; }

    public void Pop() { selectedMusic = Options.Music.Pop; }
    public void Polka() { selectedMusic = Options.Music.Polka; }
    public void Chamber() { selectedMusic = Options.Music.Chamber; }
    public void Elevator() { selectedMusic = Options.Music.Elevator; }

    public void Birthday() { selectedType = Options.Type.Birthday; }
    public void Funeral() { selectedType = Options.Type.Funeral; }
    public void Office() { selectedType = Options.Type.Office; }
    public void Wedding() { selectedType = Options.Type.Wedding; }

    public void Indoors() { indoors = true; }
    public void Outdoors() { indoors = false; }

    public void Begin()
    {
        review = GameObject.FindObjectOfType<ReviewGenerator>();
        review.SetGot(selectedAttire);
        review.SetGot(selectedEntertainer);
        review.SetGot(selectedFood);
        review.SetGot(selectedMusic);
        review.SetGot(selectedType);
        foreach (GameObject x in menus) { x.SetActive(true); }
        review.Begin();
    }

}
