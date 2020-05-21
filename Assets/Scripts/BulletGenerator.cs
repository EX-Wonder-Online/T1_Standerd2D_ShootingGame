using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletGenerator : MonoBehaviour
{
    private float time;
    [SerializeField]
    private GameObject bulletPrefab;
    private GameObject bullet;

    // Start is called before the first frame update
    void Start() {
        time = 0;
    }

    // Update is called once per frame
    void Update() {
        time += Time.deltaTime;

        if (time > 0.4f) {
            bullet = Instantiate(bulletPrefab);
            bullet.transform.position = this.transform.position;
            bullet.GetComponent<Rigidbody2D>().AddForce(Vector2.up * 10f, ForceMode2D.Impulse);
            Destroy(bullet, 2.0f);
            time = 0;
        }


    }
}
