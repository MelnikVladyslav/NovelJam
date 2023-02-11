using Assets.Script.Class;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;
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

        //Save
        string path = Path.Combine(Application.dataPath, "Save.json");
        string path1 = Path.Combine(Application.dataPath, "SaveHeroi.json");
        string path2 = Path.Combine(Application.dataPath, "SavePersons.json");

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
                    OneAnswer = "Я подумав про це наперед і взяв з собою перекус.",
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
                //11
                new TextWithVuborsClass()
                {
                    text = "Через її погляд прийшлось відкласти книгу."
                },
                //12
                new TextWithVuborsClass()
                {
                    text = "Тепер з моїх речей на столі лежали квиток, \"Цифрова фортеця\" і шоколадка."
                },
                //13
                new TextWithVuborsClass()
                {
                    Person = start.ListPersons[0],
                    text = "-Привіт! Мене звати Амелія."
                },
                //14
                new TextWithVuborsClass()
                {
                    text = "Вона підсіла до мене і протягнула руку посміхнувшись, як тільки прочитала назву книги і побачила мій квиток.",
                    OneAnswer = "Проігнорувати звернення і проникнення у особистий простір і просто дивитись у вікно.",
                    ThreeAnswer = "—Річард. Даруйте, але можете пересісти на своє місце? Хочу побільше особистого простору.",
                    TwoAnswer = "—Річард. Я потиснув руку в знак знайомства, проігнорувавши те, що дівчина лізе в мій особистий простір.",
                    AddBallExtr = 2,
                    AddBallIntr = 2,
                    AddZagBall = 1,
                    nextIdThree = 21
                    //nextIdOne = 
                },
                //15
                new TextWithVuborsClass()
                {
                    GolovPerson = start.Person,
                    text = "—Здається, ми їдемо до одного й того самого місця?"
                },
                //16
                new TextWithVuborsClass()
                {
                    Person = start.ListPersons[0],
                    text = "—Так! Я до рідних у гості їду."
                },
                //17
                new TextWithVuborsClass()
                {
                    Person = start.ListPersons[0],
                    text = "—А тебе я раніше не бачила в цих краях, попри те що село невеличке. Повідаєш?"
                },
                //18
                new TextWithVuborsClass()
                {
                    GolovPerson = start.Person,
                    text = "—Від рідних будиночок перепав, от і їду дивитись, облаштовуватись."
                },
                //19
                new TextWithVuborsClass()
                {
                    Person = start.ListPersons[0],
                    text = "—Ось як, тоді якщо треба буде якась допомога, можеш кликати мене! Приїдемо, покажу де мене можна знайти."
                },
                //20
                new TextWithVuborsClass()
                {
                    text = "Я посміхнувся і погодився."
                },
                //21
                new TextWithVuborsClass()
                {
                    text = "Амелія все-таки пересіла, побачивши що мені трохи незручно, коли вона порушує мій особистий простір, і тепер ми сиділи навпроти одне одного."
                },
                //22
                new TextWithVuborsClass()
                {
                    Person = start.ListPersons[0],
                    text = "—Вибач, дурна звичка."
                },
                //23
                new TextWithVuborsClass()
                {
                    text = "Вона усміхнулася і перевела погляд на книгу"
                },
                //24
                new TextWithVuborsClass()
                {
                    Person = start.ListPersons[0],
                    text = "—Багато вже прочитав?"
                },
                //25
                new TextWithVuborsClass()
                {
                    GolovPerson = start.Person,
                    text = "—Десь третину. Читала?"
                },
                //25
                new TextWithVuborsClass()
                {
                    Person = start.ListPersons[0],
                    text = "—Так! Але спойлерити не буду"
                },
                //26
                new TextWithVuborsClass()
                {
                    text = "Вона показала мені язика, нібито ми друзі дитинства. Цікава поїздка буде все-таки. Я не стримав посмішки, що вона швидко помітила."
                },
                //27
                new TextWithVuborsClass()
                {
                    Person = start.ListPersons[0],
                    text = "—Що смішного?"
                },
                //28
                new TextWithVuborsClass()
                {
                    text = "Зробила вигляд, що нічого не було."
                },
                //29
                new TextWithVuborsClass()
                {
                    GolovPerson = start.Person,
                    text = "—Тобі скільки років-то?"
                },
                //30
                new TextWithVuborsClass()
                {
                    text = "Спитав я з цією ж посмішкою. І ось вже я продовжую розмову, люблячи самотність"
                },
                //31
                new TextWithVuborsClass()
                {
                    Person = start.ListPersons[0],
                    text = "—19. Не звертай уваги, люблю подурачитись."
                },
                //32
                new TextWithVuborsClass()
                {
                    Person = start.ListPersons[0],
                    text = "—І не люблю коли люди хмурі ходять. От і поєдную улюблене з корисним. А тобі скільки?"
                },
                //33
                new TextWithVuborsClass()
                {
                    GolovPerson = start.Person,
                    text = "—Зрозуміло. Поки секрет"
                },
                //34
                new TextWithVuborsClass()
                {
                    text = "Я і сам не втримавсь. Хай погадає трохи."
                },
                //35
                new TextWithVuborsClass()
                {
                    GolovPerson = start.Person,
                    text = "—Вже вчишся?"
                },
                //36
                new TextWithVuborsClass()
                {
                    Person = start.ListPersons[0],
                    text = "—Так. І не скажу де і на кого, поки не скажеш свій вік! Заінтригував же"
                },
                //37
                new TextWithVuborsClass()
                {
                    text = "Я на момент подивився у вікно, а коли перевів погляд назад на Амелію, чомусь згадав той старий, але любий усіма мультфільм про Шрека."
                },
                //38
                new TextWithVuborsClass()
                {
                    text = "Той самий момент із Котом в черевиках, який використовує свій спеціальний погляд, щоб відволікти увагу."
                },
            };

            Dialog.text = ListGlava1[0].text + "\n" + "\n";


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
                if (ListGlava1[i] != null)
                {
                    if (ListGlava1[i].Person != null)
                    {
                        NameP.text = ListGlava1[i].Person.Name;
                        NameP.color = ListGlava1[i].Person.colorName;
                    }
                    else if (ListGlava1[i].GolovPerson != null)
                    {
                        NameP.text = ListGlava1[i].GolovPerson.Name;
                        NameP.color = ListGlava1[i].GolovPerson.colorName;
                        Debug.Log("Hello");
                    }
                }
                else
                {
                    NameP.text = " ";
                }

                Dialog.text = ListGlava1[i].text + "\n" + "\n";

                i++;
            }
        }

        public void EnterOne()
        {
            VuborPanel.gameObject.SetActive(false);
            start.Person.kilkBallIntrovert += ListGlava1[i - 1].AddBallIntr;
            if (ListGlava1[i - 1].nextIdOne != 0)
            {
                i = ListGlava1[i - 1].nextIdOne;
            }
            Dialog.text = ListGlava1[i].text + "\n" + "\n";
            i++;
        }
        public void EnterTwo()
        {
            VuborPanel.gameObject.SetActive(false);
            start.Person.kilkBallExtovert += ListGlava1[i - 1].AddBallExtr;
            if (ListGlava1[i - 1].nextIdTwo != 0)
            {
                i = ListGlava1[i - 1].nextIdTwo;
            }
            Dialog.text = ListGlava1[i].text + "\n" + "\n";
            i++;
        }
        public void EnterThree()
        {
            VuborPanel.gameObject.SetActive(false);
            start.Person.kilkBallIntrovert += ListGlava1[i - 1].AddZagBall;
            start.Person.kilkBallExtovert += ListGlava1[i - 1].AddZagBall;
            if (ListGlava1[i - 1].nextIdThree != 0)
            {
                i = ListGlava1[i - 1].nextIdThree;
            }
            Dialog.text = ListGlava1[i].text + "\n" + "\n";
            i++;
        }

        public void Save()
        {
            Game saveGame = new Game()
            {
                idGlav = 1,
                idText = i - 1
            };

            GolovniyPerson golovniyPerson = new GolovniyPerson()
            {
                Name = start.Person.Name,
                Year = start.Person.Year,
                colorName = start.Person.colorName,
                kilkBallExtovert = start.Person.kilkBallExtovert,
                kilkBallIntrovert = start.Person.kilkBallIntrovert
            };

            Persons persons = new Persons();

            persons.persons = start.ListPersons.ToArray();

            File.WriteAllText(path, JsonUtility.ToJson(saveGame));
            File.WriteAllText(path1, JsonUtility.ToJson(golovniyPerson));
            File.WriteAllText(path2, JsonUtility.ToJson(persons));
            
        }
    }
}