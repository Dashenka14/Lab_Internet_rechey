using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Die_player : MonoBehaviour
{
    public GameObject respaun;
    public GameObject Player;
    
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == Player.tag)
        {
            Player.transform.position = respaun.transform.position;
        }
    }

}