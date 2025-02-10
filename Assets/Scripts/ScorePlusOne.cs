using UnityEngine;

public class ScorePlusOne : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D col){
        Debug.Log("OnCollisionEnter2D");
        Destroy(col.gameObject);

        ScoreManager.Instance.IncScore(1);
    }
}
