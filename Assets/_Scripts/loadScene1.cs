using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadScene1 : MonoBehaviour
{
    public void changeScene()
    {
        SceneManager.LoadScene("GrammarScene");
    }
}
