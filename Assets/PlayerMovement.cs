using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if (pos.y >= 4) {
            pos.y = 4;
        }
        if (pos.y <= -4){
            pos.y = -4;
        }
        transform.position = new Vector2(transform.position.x, pos.y);
    
    }
}
