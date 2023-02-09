using System.Collections;
using System.IO;
using UnityEngine;
using UnityEngine.Experimental.UIElements;
using UnityEngine.SceneManagement;

namespace Assets.Script
{
    public class MenuScript : MonoBehaviour
    {
        string path = Path.Combine(Application.dataPath, "Save.json");

        public void NewGame(int id)
        {
            SceneManager.LoadSceneAsync(id);
        }

        public void Continue(int id)
        {
            if (File.Exists(path))
            {
                SceneManager.LoadSceneAsync(id);
            }
        }

        public void Exit()
        {
            Application.Quit();
        }
    }
}