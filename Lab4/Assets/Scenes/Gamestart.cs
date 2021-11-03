using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gamestart : MonoBehaviour
{
    public void OnMouseDown()
    {
        transform.localScale = new Vector3(0.55f, 0.55f, 0.55f);
        SceneManager.LoadScene("GameScene");
    }
    
    public void OnMouseUp()
    {
        transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
    }
}
