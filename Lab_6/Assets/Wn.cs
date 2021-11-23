using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Wn : MonoBehaviour
{
    public GameObject respaun;
    public GameObject Player;
    public GameObject UI_game_winn;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (Player.tag == collision.tag)
        {
            UI_game_winn.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}
