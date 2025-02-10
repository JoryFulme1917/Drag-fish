using UnityEngine;

public class ScoreMinusOne : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     private void OnCollisionEnter2D(Collision2D collison){
        Debug.Log("OnCollisionEnter2D");
        Destroy(gameObject);

        ScoreManager.Instance.IncScore(-1);
    }
}
