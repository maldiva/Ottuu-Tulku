using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class getInput : MonoBehaviour
{
    //   public void parseInput (string newText) {

    //        string tempText = newText;
    //        Debug.Log(newText);

    //public AudioSource audioData1;

    public Text userInput;

        public void setget(string text)
        {
            string main = "Көлдүн суусу кышында тоңбойт.";

            //audioData1.Play(0);

            string temptText = text;
            Debug.Log("Input = " + temptText);


            string[] mainAr = main.Split(' ');
            Debug.Log("Input = " + main);
            string newText = text;
            string[] newTextAr = newText.Split(' ');
            int mainL = mainAr.Length;
            int newL = newTextAr.Length;

            if (mainL > newL)
            {
                Debug.Log("Your text doesn't have some words. Please double check");
                userInput.text = "Your text doesn't have some words. Please double check";
            }
            else if (mainL < newL)
            {
                Debug.Log("you text have more words. Please double check!");
                userInput.text = "you text have more words. Please double check!";

            }
            else
            {
                string check = "";
                for (int i = 0; i < mainL; i++)
                {
                    if (mainAr[i] == newTextAr[i])
                    {
                        check += mainAr[i] + " ";
                    }
                    else
                    {
                        check += "<" + newTextAr[i] + "> ";
                    }
                }
                Debug.Log(check);
                
                userInput.text = check;
            }
        }

    }



