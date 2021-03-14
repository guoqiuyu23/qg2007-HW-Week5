using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eat : MonoBehaviour
{
    private float personWidth ;
    // Start is called before the first frame update
    private void Awake()
    {
        personWidth = (float) 0.5;
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale = new Vector2(personWidth, (float)0.7);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        Destroy(other.gameObject);
        personWidth += (float)0.1;
        Debug.Log("eat");
    }

 
}
