using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundPlayer : MonoBehaviour
{
    public static  AudioClip playerJump;
    public static AudioClip playerMoney;
    public static AudioClip playerEndGame;
    public static AudioClip playerDie;

    static AudioSource audioSrc;

    public string Jump;
    public string Money;
    public string EndGame;
    public string Die;
    // Start is called before the first frame update
    void Start()
    {
        playerJump = Resources.Load<AudioClip> (Jump);
        playerMoney = Resources.Load<AudioClip> (Money);
        playerEndGame = Resources.Load<AudioClip> (EndGame);
        playerDie = Resources.Load<AudioClip> (Die);

        audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void PlaySound(string clip)
    {
        switch (clip) {
            case "jump":
                audioSrc.PlayOneShot(playerJump);
                break;
            case "end":
                audioSrc.PlayOneShot(playerEndGame);
                break;
            case "die":
                audioSrc.PlayOneShot(playerDie);
                break;
            case "money":
                audioSrc.PlayOneShot(playerMoney);
                break;
        }
    }
}
