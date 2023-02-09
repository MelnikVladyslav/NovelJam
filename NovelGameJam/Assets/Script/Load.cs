using Assets.Script.Class;
using System.Collections;
using System.IO;
using UnityEngine;

namespace Assets.Script
{
    public class Load : MonoBehaviour
    {
        public Game loadGame = new Game();
        string path = Path.Combine(Application.dataPath, "Save.json");

        // Use this for initialization
        void Start()
        {
            loadGame = JsonUtility.FromJson<Game>(File.ReadAllText(path));
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}