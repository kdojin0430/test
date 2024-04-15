using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScripts : MonoBehaviour
{
    Rigidbody2D myrigidbody;
    [SerializeField]
    private float power;
    [SerializeField]
    Transform pos;
    [SerializeField]
    float checkRadius;
    [SerializeField]
    LayerMask islayer;

    public int jumpCount;
    
    int jumpCut;

    bool Ground;
    
    void Start()
    {
        myrigidbody = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        Ground = Physics2D.OverlapCircle(pos.position,checkRadius,islayer);

        if(Ground == true && Input.GetKeyDown(KeyCode.Space )&& jumpCut > 0)
        {
            myrigidbody.velocity = Vector2.up * power; 
        } 
        if(Ground == false && Input.GetKeyDown(KeyCode.Space )&& jumpCut > 0)
        {
            myrigidbody.velocity = Vector2.up * power; 
        }
        if (Input.GetKey(KeyCode.Space) ) 
        {
            jumpCut--;
        }
        if (Ground)
        {
            jumpCut =
        }
    }

    private void FixedUpdate()
    {
        float hor = Input.GetAxis("Horizontal");
        myrigidbody.velocity = new Vector2 (hor*3, myrigidbody.velocity.y);
    }
}
