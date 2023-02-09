using System;
using System.Collections;
using UnityEngine;

namespace Assets.Script.Class
{
    [Serializable]
    public class TextClass : MonoBehaviour
    {
        public string text;
        public PersonClass Person = new PersonClass();
        public GolovniyPerson GolovPerson = new GolovniyPerson();
    }
}