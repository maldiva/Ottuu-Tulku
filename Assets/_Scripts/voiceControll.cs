// using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.Windows.Speech;
//using UnityEngine.SceneManagement;
//using System;
//using System.Linq;

//public class voiceControll : MonoBehaviour
//{
//    private KeywordRecognizer keywordRecognizer;
//    private Dictionary<string, Action> actions = new Dictionary<string, Action>();

//    private void Start() 
//    {
//        actions.Add("open", fairyTale);

//        keywordRecognizer = new KeywordRecognizer(actions.Keys.ToArray());
//        keywordRecognizer.OnPhraseRecognized += ifRecognized;
//        keywordRecognizer.Start();
//    }

//    private void ifRecognized(PhraseRecognizedEventArgs speech)
//    {
//        Debug.Log(speech.text);
//        actions[speech.text].Invoke();
//    }

//    private void fairyTale() 
//    {
//        SceneManager.LoadScene("ARFairyTale");
//    }



//}

