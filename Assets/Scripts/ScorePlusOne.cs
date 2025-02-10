using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class ScorePlusOne : MonoBehaviour
{    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D col){
        if (col.CompareTag("Boundary")){
            Debug.Log("OnCollisionEnter2D");
            Destroy(col.gameObject);

            ScoreManager.Instance.IncScore(1);

        }
        
    }
}
