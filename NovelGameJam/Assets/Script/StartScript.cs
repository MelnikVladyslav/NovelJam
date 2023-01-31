using Assets.Script.Class;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartScript : MonoBehaviour {

    //Nvl
    public GameObject PanelNvl;
    public Text WordAutor;

	//Persons
	public GolovniyPerson Person = new GolovniyPerson() 
	{
		Name = "Річард", 
		colorName = new Color(232, 181, 39), 
		Year = 25
	};
	public List<PersonClass> ListPersons = new List<PersonClass>();

	//Prolog
	public List<TextClass> PrologTexts = new List<TextClass>();
    int i = 0;
	public bool isEnd = false;

    // Use this for initialization
    void Start () 
	{
		//Insert
		PrologTexts = new List<TextClass>() 
		{
			//0
			new TextClass()
			{
				text = "Кожному в житті постійно приходиться робити той чи інший вибір."
            },
			//1
			new TextClass()
            {
                text = "Часто це впливає на вашу особистість - ви людина інтроверт, чи екстраверт?"
            },
			//2
			new TextClass()
            {
                text = "Особисто я ще не виришив, тому прошу допомогти мені. Тож…"
            }
        };

		//Prolog
		PanelNvl.gameObject.SetActive(true);
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	public void NextProlog()
	{
		if (i == PrologTexts.Count)
		{
			PanelNvl.gameObject.SetActive(false);
			isEnd = true;
		}
		else
		{
			WordAutor.text += PrologTexts[i].text + "\n" + "\n";

			i++;
		}
	}
}
