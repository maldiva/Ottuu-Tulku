using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoBackScript : MonoBehaviour
{
    public void GoBackBut()
    {
        SceneManager.LoadScene("_MainMenu");
    }

}
