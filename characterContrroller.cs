using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterContrroller : MonoBehaviour
{

    Rigidbody2D rigid;
    public float force = 0;
    Vector2 yon;
    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        yon = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        yon.Normalize();
        rigid.velocity = yon * force;
    }

}
