using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // このメソッドを呼び出すとゲームシーンが呼び出される
    public void GameStart() {
        SceneManager.LoadScene("GameScene");
    }
}
