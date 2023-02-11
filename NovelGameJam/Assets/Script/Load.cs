using Assets.Script.Class;
using System.Collections;
using System.IO;
using UnityEngine;

namespace Assets.Script
{
    public class Load : MonoBehaviour
    {
        public Game loadGame = new Game();
        public GolovniyPerson loadHeroy = new GolovniyPerson();
        public Persons loadPersons = new Persons();
        string path = Path.Combine(Application.dataPath, "Save.json");
        string path1 = Path.Combine(Application.dataPath, "SaveHeroi.json");
        string path2 = Path.Combine(Application.dataPath, "SavePersons.json");

        // Use this for initialization
        void Start()
        {
            loadGame = JsonUtility.FromJson<Game>(File.ReadAllText(path));
            loadHeroy = JsonUtility.FromJson<GolovniyPerson>(File.ReadAllText(path1));
            loadPersons = JsonUtility.FromJson<Persons>(File.ReadAllText(path2));
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}