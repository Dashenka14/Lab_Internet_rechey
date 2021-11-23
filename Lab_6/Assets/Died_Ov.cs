using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Died_Ov : MonoBehaviour
{
    public GameObject Player;
    public GameObject respaun;
    public GameObject UI_game_over;
    public void Resume()
    {
        Player.transform.position = respaun.transform.position;
        UI_game_over.SetActive(false);
        Time.timeScale = 1f;
    }
}
