using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CameraController : MonoBehaviour
{

    public float dumping = 1.5f;
    public Vector2 offset = new Vector2(2f, 1f);
    private Transform player;
    private int lastX;

    // Start is called before the first frame update
    void Start()
    {
        offset = new Vector2(Mathf.Abs(offset.x), offset.y);
        FindPlayer();
    }

    public void FindPlayer() 
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        if (player)
        {
            transform.position = new Vector3(player.position.x, player.position.y, transform.position.z);
        }
    }

    void FixedUpdate()
    {
        if (player)
        {
            transform.position = new Vector3(player.position.x, player.position.y, transform.position.z);
        }
        
    }
}
