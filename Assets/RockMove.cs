using UnityEngine;
using System.Collections;

public class RockMove : MonoBehaviour
{
    public GameObject rocks;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
  
    }
   

    // Update is called once per frame
    void Update()
    {
        float speed = 0.017f;
        transform.position = new Vector2(transform.position.x - speed, transform.position.y);
    }
}
