using Assets.Script.Class;
using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Script
{
    public class Glava1 : MonoBehaviour
    {
        //TextPanel
        public GameObject TextPanel;
        public Text NameP;
        public Text Dialog;

        //Start script
        public StartScript start;

        //Glava 1
        public bool isEnd = false;
        public List<TextClass> ListGlava1 = new List<TextClass>();
        int i = 0;

        // Use this for initialization
        void Start()
        {
            //Insert

        }

        // Update is called once per frame
        void Update()
        {
            if (start.isEnd == true)
            {
                TextPanel.gameObject.SetActive(true);
            }
            if (isEnd == true)
            {
                TextPanel.gameObject.SetActive(false);
            }
        }

        public void NextGlava1()
        {
            if (i == ListGlava1.Count)
            {
                TextPanel.gameObject.SetActive(false);

                isEnd = true;
            }
            else
            {
                if (ListGlava1[i].GolovPerson == null)
                {
                    NameP.text = ListGlava1[i].Person.Name;
                    NameP.color = ListGlava1[i].Person.colorName;
                }
                else
                {
                    NameP.text = ListGlava1[i].GolovPerson.Name;
                    NameP.color = ListGlava1[i].GolovPerson.colorName;
                }

                Dialog.text += ListGlava1[i].text + "\n" + "\n";

                i++;
            }
        }
    }
}