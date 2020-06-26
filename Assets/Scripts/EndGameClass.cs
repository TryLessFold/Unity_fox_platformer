using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndGameClass : MonoBehaviour
{
    public static bool stop;
    public static Text label;

    private void Start()
    {
        label = GetComponent<Text>();
        label.text = "";
        stop = false;
    }

    public void endGame()
    {
        if (stop == false)
        {
            SoundPlayer.PlaySound("end");
            label.text = "You have a " + CrystallCollect.crystalCount +
                " crystals for " + Mathf.RoundToInt(CrystallCollect.totalTime) + " seconds. Press r to reset game, or 'Esc' for exit";
            stop = true;
        }
    }
}
