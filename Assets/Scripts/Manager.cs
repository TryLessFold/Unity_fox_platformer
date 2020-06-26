using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
    public Transform spawnTrans;
    public Transform playerTrans;

    private void Update()
    {
        if (Input.GetKeyDown("r"))
        {
            SceneManager.LoadScene("SampleScene");
        }
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
        if (playerTrans.position.y < -15)
        {
            SoundPlayer.PlaySound("die");
            CrystallCollect.totalTime += 6;
            playerTrans.position = spawnTrans.position;
        }
    }
}
