using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExprosionGenerator : MonoBehaviour
{
    [SerializeField]
    private string hitTag;
    [SerializeField]
    private GameObject exprosion;
    private GameObject exp;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.tag == hitTag) {
            exp = Instantiate(exprosion,this.transform.position,Quaternion.identity);
            Destroy(exp, 1.0f);
        }
    }
}
