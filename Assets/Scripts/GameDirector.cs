using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameDirector : MonoBehaviour
{
    [SerializeField]
    private GameObject ui;
    [SerializeField]
    private PlayerController playerController;
    [SerializeField]
    private StoneGenerator stoneGenerator;
    [SerializeField]
    private BulletGenerator bulletGenerator;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GameOver() {
        playerController.enabled = false;
        stoneGenerator.enabled = false;
        bulletGenerator.enabled = false;
        ui.SetActive(true);
    }
}
