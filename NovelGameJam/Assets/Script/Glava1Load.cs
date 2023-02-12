using Assets.Script.Class;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Script
{
    public class Glava1Load : MonoBehaviour
    {
        //TextPanel
        public GameObject TextPanel;
        public Text NameP;
        public Text Dialog;
        public Button Next;


        //Start
        public StartScript start;

        //Glava 1
        public bool isEnd = false;
        public List<TextWithVuborsClass> ListGlava1 = new List<TextWithVuborsClass>();
        int i;
        int ballsIntrovert;
        int ballsExtrovert;
        public List<Texture> textures = new List<Texture>();
        public RawImage background;

        //Texture persons
        public RawImage Heroy;
        public RawImage Person1;
        public List<Texture> texturesPersons = new List<Texture>();

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

        //Load
        public Load load;

        //Timing
        public GameObject TimingPanel;
        public Text TimText;

        //EndGame
        public GameObject EndGame;

        // Use this for initialization
        void Start()
        {
            i = load.loadGame.idText;
            ballsExtrovert = load.loadHeroy.kilkBallExtovert;
            ballsIntrovert = load.loadHeroy.kilkBallIntrovert;

            //Insert
            ListGlava1 = new List<TextWithVuborsClass>()
            {
                //0
                new TextWithVuborsClass()
                {
                    text = "Всім привіт. Мене звати Річард, але можна просто - Рік. Мені 20, я працюю фінансовим аналітиком в Рівному."
                },
                //1
                new TextWithVuborsClass()
                {
                    text = "Чому саме ця професія?"
                },
                //2
                new TextWithVuborsClass()
                {
                    text = "Бо мені не треба спілкуватися з людьми, щоб робити свою роботу. Да і чимось зв’язана з тим, на кого вчусь. Живу я сам. Не дуже люблю увагу. Робота допомагає скоротати час, і дає змогу спокійно жити, не залежачи від батьків."
                },
                //3
                new TextWithVuborsClass()
                {
                    text = "Але таке життя мені набридло."
                },
                //4
                new TextWithVuborsClass()
                {
                    text = "Тому я вирішив переїхати в старий будинок дідуся і бабусі, який знаходиться на краю села, що дістався нам у спадщину, а батьки вирішили віддати його мені."
                },
                //5
                new TextWithVuborsClass()
                {
                    text = "Так як село старе і далеко від міста - людей там не дуже багато, що мені до вподоби."
                },
                //6
                new TextWithVuborsClass()
                {
                    text = "Сесію я здав, маю канікули, тому я взяв відпустку, щоб облаштуватися там і вирішити, як далі вчинити з роботою. Навчання дистанційне, навіть коли обмеження спали, тому сумніваюсь, що щось зміниться ближчим часом. А питання з роботою відкрите, бо їхати з мого міста в село далеко, а в ньому сумніваюся що знайду нормальну роботу."
                },
                //7
                new TextWithVuborsClass()
                {
                    text = "Їду я поїздом, так швидше і дешевше виходить. Проте, потім прийдеться далеко йти… Але нічого, іноді потрібно."
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
                    Person = load.loadPersons.persons[0],
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
                    nextIdThree = 21,
                    nextIdOne = 62
                },
                //15
                new TextWithVuborsClass()
                {
                    GolovPerson = load.loadHeroy,
                    text = "—Здається, ми їдемо до одного й того самого місця?"
                },
                //16
                new TextWithVuborsClass()
                {
                    Person = load.loadPersons.persons[0],
                    text = "—Так! Я до рідних у гості їду."
                },
                //17
                new TextWithVuborsClass()
                {
                    Person = load.loadPersons.persons[0],
                    text = "—А тебе я раніше не бачила в цих краях, попри те що село невеличке. Повідаєш?"
                },
                //18
                new TextWithVuborsClass()
                {
                    GolovPerson = load.loadHeroy,
                    text = "—Від рідних будиночок перепав, от і їду дивитись, облаштовуватись."
                },
                //19
                new TextWithVuborsClass()
                {
                    Person = load.loadPersons.persons[0],
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
                    Person = load.loadPersons.persons[0],
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
                    Person = load.loadPersons.persons[0],
                    text = "—Багато вже прочитав?"
                },
                //25
                new TextWithVuborsClass()
                {
                    GolovPerson = load.loadHeroy,
                    text = "—Десь третину. Читала?"
                },
                //25
                new TextWithVuborsClass()
                {
                    Person = load.loadPersons.persons[0],
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
                    Person = load.loadPersons.persons[0],
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
                    GolovPerson = load.loadHeroy,
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
                    Person = load.loadPersons.persons[0],
                    text = "—18. Не звертай уваги, люблю подурачитись."
                },
                //32
                new TextWithVuborsClass()
                {
                    Person = load.loadPersons.persons[0],
                    text = "—І не люблю коли люди хмурі ходять. От і поєдную улюблене з корисним. А тобі скільки?"
                },
                //33
                new TextWithVuborsClass()
                {
                    GolovPerson = load.loadHeroy,
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
                    GolovPerson = load.loadHeroy,
                    text = "—Вже вчишся?"
                },
                //36
                new TextWithVuborsClass()
                {
                    Person = load.loadPersons.persons[0],
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
                //39
                new TextWithVuborsClass()
                {
                    GolovPerson = load.loadHeroy,
                    text = "—20 мені. Не дивись на мене так..."
                },
                //40
                new TextWithVuborsClass()
                {
                    Person = load.loadPersons.persons[0],
                    text = "—От так би й одразу!"
                },
                //41
                new TextWithVuborsClass()
                {
                    text = "Вона взяла свій сік, і перш ніж відкрити, продовжила"
                },
                //42
                new TextWithVuborsClass()
                {
                    Person = load.loadPersons.persons[0],
                    text = "—Не дивитись так... А якщо буду, то що?"
                },
                //43
                new TextWithVuborsClass()
                {
                    GolovPerson = load.loadHeroy,
                    text = "—Ой, та ну тебе"
                },
                //44
                new TextWithVuborsClass()
                {
                    text = "Не придумав я нічого краще, ніж наіграно образитись. Здається, вона подавилась соком від сміху..."
                },
                //45
                new TextWithVuborsClass()
                {
                    text = "через кілька годин"
                },
                //46
                new TextWithVuborsClass()
                {
                    Person = load.loadPersons.persons[0],
                    text = "—Ріку, прокидайся, за 5 хвилин наша зупинка!"
                },
                //47
                new TextWithVuborsClass()
                {
                    text = "Почув і не зрозумів де я і що відбувається взагалі"
                },
                //48
                new TextWithVuborsClass()
                {
                    Person = load.loadPersons.persons[0],
                    text = "—Ріку, я зараз тебе водою обіллю, щоб прокинувсь! Тобі ще речі зібрати треба. Телефон не віддам поки не зберешся!"
                },
                //49
                new TextWithVuborsClass()
                {
                    text = "Я відкрив очі і  побачивши повністю зібрану дівчину згадав події останніх годин."
                },
                //50
                new TextWithVuborsClass()
                {
                    GolovPerson = load.loadHeroy,
                    text = "—Йой, дякую, Амелі!"
                },
                //51
                new TextWithVuborsClass()
                {
                    text = "Вигляд зібраної дівчини з моїм телефоном в руках придав мені неабиякого прискорення"
                },
                //52
                new TextWithVuborsClass()
                {
                    GolovPerson = load.loadHeroy,
                    text = "—Вибач, не пам’ятаю в який момент мене в сон потягнуло…"
                },
                //53
                new TextWithVuborsClass()
                {
                    Person = load.loadPersons.persons[0],
                    text = "—Нуж-бо, нуж-бо, збирайся! А заснув ти, коли я побігла воду купувати. До речі, з телефоном в руках…"
                },
                //54
                new TextWithVuborsClass()
                {
                    Person = load.loadPersons.persons[0],
                    text = "—Ти щось писав в нотатках, здається, але я не читала. Поділишся, що ж там такого “цікавого” було?"
                },
                //55
                new TextWithVuborsClass()
                {
                    text = "Я завис, згадуючи, що писав. І як добре, що вона не читала…"
                },
                //56
                new TextWithVuborsClass()
                {
                    GolovPerson = load.loadHeroy,
                    text = "—Може, якось потім… Добре, ходімо, я зібрався"
                },
                //57
                new TextWithVuborsClass()
                {
                    text = "Я взяв рюкзак в руку і на ходу забрав свій телефон з рук дівчини, підганяючи її в бік виходу з вагону."
                },
                //58
                new TextWithVuborsClass()
                {
                    Person = load.loadPersons.persons[0],
                    text = "—Куртку хоч вдягни. Тут холодно вранці"
                },
                //59
                new TextWithVuborsClass()
                {
                    text = "Не зупиняючись, вона озирнулась на мене в одній футболці із курткою в руках"
                },
                //60
                new TextWithVuborsClass()
                {
                    Person = load.loadPersons.persons[0],
                    text = "—Захворієш ще…",
                    nextId = 72
                },
                //61
                new TextWithVuborsClass()
                {
                    text = "через деякий час"
                },
                //62
                new TextWithVuborsClass()
                {
                    text = "Я подивився на дівчину і видохнув. Щось в мені боролося і кричало про те, що я поступив неправильно."
                },
                //63
                new TextWithVuborsClass()
                {
                    text = "Дівчина побачила мої терзання і посміхнулась."
                },
                //64
                new TextWithVuborsClass()
                {
                    Person = load.loadPersons.persons[0],
                    text = "—Спробуємо ще раз? Амелія. 19 років. Їду до рідних"
                },
                //65
                new TextWithVuborsClass()
                {
                    text = "Вона протягнула руку для знайомства."
                },
                //66
                new TextWithVuborsClass()
                {
                    GolovPerson = load.loadHeroy,
                    text = "—Річард, 25"
                },
                //67
                new TextWithVuborsClass()
                {
                    text = "Я пожав руку"
                },
                //68
                new TextWithVuborsClass()
                {
                    GolovPerson = load.loadHeroy,
                    text = "—Їду облаштовуватись. Вибач за поведінку, трохи не звик до спілкування і не в настрої. Будеш?"
                },
                //69
                new TextWithVuborsClass()
                {
                    text = "В знак примирення — я протягнув шоколадку їй і вона з радістю взяла шматочок."
                },
                //70
                new TextWithVuborsClass()
                {
                    Person = load.loadPersons.persons[0],
                    text = "—Згодна",
                    nextId = 23
                },
                //71
                new TextWithVuborsClass()
                {
                    text = "Ми вийшли з вагону і вдвох пішли в сторону села. Розбалакавшись, ми не помітили купку хлопців, що стояли неподалік."
                },
                //72
                new TextWithVuborsClass()
                {
                    Person = load.loadPersons.persons[0],
                    text = "—..Так, уявляєш..!"
                },
                //73
                new TextWithVuborsClass()
                {
                    text = "Вона продовжувала розповідати про навчання, коли нас різко перервали."
                },
                //74
                new TextWithVuborsClass()
                {
                    Person = load.loadPersons.persons[1],
                    text = "—Вау, Амелія йде до батьків і не сама."
                },
                //75
                new TextWithVuborsClass()
                {
                    text = "Я не зрозумів хто то сказав з усіх тих хлопців, які вдруг почали йти в нашу сторону, але відчув як дівчина напряглась і її настрій різко зник. А я з цікавістю подивився на компанію."
                },
                //76
                new TextWithVuborsClass()
                {
                    Person = load.loadPersons.persons[0],
                    text = "—Рік, ідем. Не звертай уваги на них"
                },
                //77
                new TextWithVuborsClass()
                {
                    text = "Вона не піднімала очей і дуже хотіла піти. А я думав що робити."
                },
                //75
                new TextWithVuborsClass()
                {
                    Person = load.loadPersons.persons[1],
                    text = "—Значить, Рік? Андрій - її гарний знайомий. Приємно познайомитися"
                },
                //78
                new TextWithVuborsClass()
                {
                    text = "Я не бачив людину, яка говорила. Він стояв у тіні, а ввечері це давало свій ефект. Але я явно відчував, що він скалився."
                },
                //79
                new TextWithVuborsClass()
                {
                    Person = load.loadPersons.persons[0],
                    text = "—Андрій, відчепись. Я вже тобі все сказала"
                },
                //80
                new TextWithVuborsClass()
                {
                    text = "Чи мені здалось, чи вона готова влізти в суперечку, судячи з реакції її тіла…"
                },
                //81
                new TextWithVuborsClass()
                {
                    Person = load.loadPersons.persons[1],
                    text = "—Я не з тобою балакаю, Амелія. Поки що. Тож, Рік?"
                },
                //82
                new TextWithVuborsClass()
                {
                    GolovPerson = load.loadHeroy,
                    text = "—Рік"
                },
                //83
                new TextWithVuborsClass()
                {
                    text = "Я підійшов ближче, заводячи рукою нову знайому за спину."
                },
                //84
                new TextWithVuborsClass()
                {
                    GolovPerson = load.loadHeroy,
                    text = "—Може вийдеш з тіні і побалакаємо так?"
                },
                //85
                new TextWithVuborsClass()
                {
                    Person = load.loadPersons.persons[1],
                    text = "—Ти не знаєш куди лізеш. Іди поки не пізно"
                },
                //86
                new TextWithVuborsClass()
                {
                    text = "Він явно насміхався."
                },
                //87
                new TextWithVuborsClass()
                {
                    Person = load.loadPersons.persons[1],
                    text = "—Рік, іди. Він правий"
                },
                //88
                new TextWithVuborsClass()
                {
                    text = "Я задумався. Піти собі нікуди не влазячи, чи розібратись в ситуації, яка так не подобається моїй можливій сусідці, яка за час знайомства показала себе позитивною людиною? А зараз була дуже напряженною…"
                },
                //89
                new TextWithVuborsClass()
                {
                    text = "Як взагалі виглядає цей Андрій, що він з себе представляє, чи знають що за знайомі в Амелії її батьки? І як взагалі далі відбуватиметься моє життя в цьому місці? Хто я все-таки - інтроверт чи екстраверт?"
                },
            };

            Dialog.text = ListGlava1[i].text + "\n" + "\n";

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
            else
            {
                VuborPanel.gameObject.SetActive(false);
            }

            //Timing
            if (i == 10 || i == 62)
            {
                TimingPanel.gameObject.SetActive(true);
                TimText.text = ListGlava1[i - 1].text;
                i++;
                Dialog.text = ListGlava1[i].text;
            }

            //Background
            if ((i >= 0 && i <= 10) || i >= 72)
            {
                background.texture = textures[0];
            }
            if ((i >= 10 && i <= 60) || i >= 60)
            {
                background.texture = textures[1];
            }

            //Next
            if (ListGlava1[i].nextId != 0)
            {
                i = ListGlava1[i].nextId;
            }

            //Textures persons
            if (i == 14 || (i >= 16 && i <= 44) || i >= 47)
            {
                Person1.gameObject.SetActive(true);
                Person1.texture = texturesPersons[1];
            }
            else
            {
                Person1.gameObject.SetActive(false);
            }

            if (i >= 16 && i <= 44 || i >= 47)
            {
                Heroy.gameObject.SetActive(true);
                Heroy.texture = texturesPersons[0];
            }
            else
            {
                Heroy.gameObject.SetActive(false);
            }
        }

        public void NextGlava1()
        {
            if (i == ListGlava1.Count)
            {
                TextPanel.gameObject.SetActive(false);

                isEnd = true;

                EndGame.gameObject.SetActive(true);
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
            ballsIntrovert += ListGlava1[i - 1].AddBallIntr;
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
            ballsExtrovert += ListGlava1[i - 1].AddBallExtr;
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
            ballsIntrovert += ListGlava1[i - 1].AddZagBall;
            ballsExtrovert += ListGlava1[i - 1].AddZagBall;
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
                Name = load.loadHeroy.Name,
                Year = load.loadHeroy.Year,
                colorName = load.loadHeroy.colorName,
                kilkBallExtovert = ballsExtrovert,
                kilkBallIntrovert = ballsIntrovert
            };

            Persons persons = new Persons();

            persons.persons = load.loadPersons.persons;

            File.WriteAllText(path, JsonUtility.ToJson(saveGame));
            File.WriteAllText(path1, JsonUtility.ToJson(golovniyPerson));
            File.WriteAllText(path2, JsonUtility.ToJson(persons));
        }
    }
}