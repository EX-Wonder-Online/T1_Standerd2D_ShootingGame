using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Vector2 pos; // プレイヤーの現在の位置
    private Vector2 mousePos; // マウスの位置
    private float posX; // プレイヤーの次の状態のX座標
    [SerializeField]
    private float moveSpeed; // プレイヤーの移動速度[0 ~ 1]
    [SerializeField]
    private GameDirector gameDirector;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        pos = this.transform.position; // フレームごとに位置を取得

        if (Input.GetMouseButton(0)) { // もし画面をタッチしたら
            mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition); // マウスの位置を取得
        }
        posX = Mathf.Lerp(pos.x, mousePos.x, moveSpeed); // 現在のX座標とマウスのX座標にだんだん変化させる
        this.transform.position = new Vector2(posX, pos.y); // プレイヤーの位置を更新

    }

    private void OnCollisionEnter2D(Collision2D collision) {
        if(collision.gameObject.tag == "Stone") {
             gameDirector.GameOver();
        }
       
    }
}
