using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneGenerator : MonoBehaviour
{
    private float time;
    [SerializeField]
    private GameObject stonePrefab;
    private GameObject stone;
    private Vector2 stonePos;
    private Vector2 pos;
    private Vector3 size;

    // Start is called before the first frame update
    void Start()
    {
        time = 0;
        pos = this.transform.position;
        size = this.transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        if(time > 2.0f) {
            stonePos.x = pos.x + Random.Range(-size.x / 2.0f, size.x / 2.0f);
            stonePos.y = pos.y + Random.Range(-size.y / 2.0f, size.y / 2.0f);
            stone = Instantiate(stonePrefab);
            Destroy(stone, 2.0f);
            stone.transform.position = stonePos;
            stone.GetComponent<Rigidbody2D>().AddForce(Vector2.down * 10f, ForceMode2D.Impulse);

            time = 0;
        }
        
       
    }
}
