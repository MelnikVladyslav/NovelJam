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
        public Button Next;

        //Start script
        public StartScript start;

        //Glava 1
        public bool isEnd = false;
        public List<TextWithVuborsClass> ListGlava1 = new List<TextWithVuborsClass>();
        int i = 1;

        //Vubors
        public GameObject ThreePanel;
        public GameObject VuborPanel;
        public Text One;
        public Text Two;
        public Text Three;

        // Use this for initialization
        void Start()
        {
            //Insert
            ListGlava1 = new List<TextWithVuborsClass>()
            {
                //0
                new TextWithVuborsClass()
                {
                    text = "Всім привіт. Мене звати Річард, але можна просто - Рік. Мені 25, я працюю фінансовим аналітиком в Рівному."
                },
                //1
                new TextWithVuborsClass()
                {
                    text = "Чому саме ця професія?"
                },
                //2
                new TextWithVuborsClass()
                {
                    text = "Бо мені не треба спілкуватися з людьми, щоб робити свою роботу. Я навіть живу сам. Не дуже люблю увагу."
                },
                //3
                new TextWithVuborsClass()
                {
                    text = "Але таке життя мені набридло."
                },
                //4
                new TextWithVuborsClass()
                {
                    text = "Тому я переїхав в старий будинок дідуся з бабусею, який дістався мені у спадщину, він знаходиться на краю села."
                },
                //5
                new TextWithVuborsClass()
                {
                    text = "Так як село старе і далеко від міста - людей там не дуже багато, що мені до вподоби."
                },
                //6
                new TextWithVuborsClass()
                {
                    text = "Я взяв відпустку, щоб облаштуватися там і вирішити, що далі робити з роботою. Бо їхати далеко, а в селі дуже сумніваються що нормальна робота є."
                },
                //7
                new TextWithVuborsClass()
                {
                    text = "Їду я поки поїздом, так швидше і дешевше вийде. Хоча потім прийдеться далеко йти…"
                },
                //8
                new TextWithVuborsClass()
                {
                    text = "Їхати ще далеко, а їсти хочется вже, тому",
                    OneAnswer = "Я подумав про це наперед і взяв з собою перекус. ",
                    TwoAnswer = "Треба сходити у вагон-ресторан і взяти щось поїсти.",
                    ThreeAnswer = "Я подумав про це наперед і взяв з собою перекус, але забув взяти щось попити.",
                    AddBallExtr = 2,
                    AddBallIntr = 2,
                    AddZagBall = 1
                },
                //9
                new TextWithVuborsClass()
                {
                    text = "Через годину"
                },
                //10
                new TextWithVuborsClass()
                {
                    text = "Я тільки відкрив книгу, як до мене підсіла дівчина. Їдемо ми в одне місце… почитати не зможу, я так розумію."
                },
            };

            Dialog.text = ListGlava1[0].text + "\n" + "\n";

            Debug.Log(start.Person.kilkBallIntrovert);
            Debug.Log(start.Person.kilkBallExtovert);

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

            if (ListGlava1[i - 1].OneAnswer != null && ListGlava1[i - 1].OneAnswer != "")
            {
                VuborPanel.gameObject.SetActive(true);
                One.text = ListGlava1[i - 1].OneAnswer;
                Two.text = ListGlava1[i - 1].TwoAnswer;
            }
            if (ListGlava1[i - 1].ThreeAnswer != null && ListGlava1[i - 1].ThreeAnswer != "")
            {
                ThreePanel.gameObject.SetActive(true);
                Three.text = ListGlava1[i - 1].ThreeAnswer;
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
                if (ListGlava1[i].Person == null)
                {
                    NameP.text = " ";
                }
                else
                {
                    NameP.text = ListGlava1[i].GolovPerson.Name;
                    NameP.color = ListGlava1[i].GolovPerson.colorName;
                }

                Dialog.text = ListGlava1[i].text + "\n" + "\n";

                i++;
            }
        }

        public void EnterOne()
        {
            VuborPanel.gameObject.SetActive(false);
            start.Person.kilkBallIntrovert += ListGlava1[i - 1].AddBallIntr;
            Debug.Log(start.Person.kilkBallIntrovert);
            i++;
        }
        public void EnterTwo()
        {
            VuborPanel.gameObject.SetActive(false);
            start.Person.kilkBallExtovert += ListGlava1[i - 1].AddBallExtr;
            Debug.Log(start.Person.kilkBallExtovert);
            i++;
        }
        public void EnterThree()
        {
            VuborPanel.gameObject.SetActive(false);
            start.Person.kilkBallIntrovert += ListGlava1[i - 1].AddZagBall;
            start.Person.kilkBallExtovert += ListGlava1[i - 1].AddZagBall;
            Debug.Log(start.Person.kilkBallIntrovert);
            Debug.Log(start.Person.kilkBallExtovert);
            i++;
        }
    }
}