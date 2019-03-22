using UnityEngine;

public class playGrammar : MonoBehaviour
{
    public AudioSource sound;
    void Update()
    {
        if (Input.GetButton("Play"))
        {
            sound.Play();
        }
    }

}
