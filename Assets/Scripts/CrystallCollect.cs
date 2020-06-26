using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CrystallCollect : MonoBehaviour
{
    public static float totalTime;
    public static int crystalCount;
    private Text crystalCounter;
    // Start is called before the first frame update
    void Start()
    {
        crystalCounter = GetComponent<Text>();
        crystalCount = 0;
        totalTime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        totalTime += Time.deltaTime;
    }
    void FixedUpdate()
    {
        crystalCounter.text = "x" + crystalCount + " Time: " + Mathf.RoundToInt(totalTime);
    }
}
