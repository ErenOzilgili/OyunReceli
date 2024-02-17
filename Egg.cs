using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Egg : MonoBehaviour
{
    private Enemy enemy;
    private Sprite sprite;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<SpriteRenderer>().sprite = this.sprite;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setEnemy(Enemy enemy){
        this.enemy = enemy;

    }




}
