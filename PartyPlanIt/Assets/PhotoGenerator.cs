// Example that loads sprites from a texture in the Resources folder
// and allows them to be chosen by the selection button.

using UnityEngine;

public class PhotoGenerator : MonoBehaviour
{
	public int spritePos = 0;
	private SpriteRenderer spriteR;
	public Sprite[] sprites;

	void Start()
	{
		spriteR = gameObject.GetComponent<SpriteRenderer>();
	}

	//Entertainers
	public void GenerateClown()
	{
			spriteR.sprite = sprites [0];
	}
	public void GenerateLecturer()
	{
		spriteR.sprite = sprites [1];
	}
	public void GeneratePriest()
	{
		spriteR.sprite = sprites [2];
	}
	public void GenerateSinger()
	{
		spriteR.sprite = sprites [3];
	}

	//Attire
	public void GenerateBusiness()
	{
		spriteR.sprite = sprites [0];
	}
	public void GenerateCasual()
	{
		spriteR.sprite = sprites [1];
	}
	public void GenerateBlackTie()
	{
		spriteR.sprite = sprites [2];
	}
	public void GenerateTogas()
	{
		spriteR.sprite = sprites [3];
	}

	//Food
	public void GenerateLobster()
	{
		spriteR.sprite = sprites [0];
	}
	public void GenerateOpenBar()
	{
		spriteR.sprite = sprites [1];
	}
	public void GenerateHorsDoeuvres()
	{
		spriteR.sprite = sprites [2];
	}
	public void GenerateCake()
	{
		spriteR.sprite = sprites [3];
	}

	//Type
	public void GenerateWedding()
	{
		spriteR.sprite = sprites [0];
	}
	public void GenerateOfficeParty()
	{
		spriteR.sprite = sprites [1];
	}
	public void GenerateFuneral()
	{
		spriteR.sprite = sprites [2];
	}
	public void GenerateBirthday()
	{
		spriteR.sprite = sprites [3];
	}
	

	//Location
	public void GenerateInside()
	{
		spriteR.sprite = sprites [0];
	}
	public void GenerateOutside()
	{
		spriteR.sprite = sprites [1];
	}
}