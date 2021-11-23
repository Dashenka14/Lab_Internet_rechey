using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Winn_g : MonoBehaviour
{
    public GameObject Player;
    public GameObject respaun;
    public GameObject UI_game_winn;
    public void Resume()
    {
        Player.transform.position = respaun.transform.position;
        UI_game_winn.SetActive(false);
        Time.timeScale = 1f;
    }
}
