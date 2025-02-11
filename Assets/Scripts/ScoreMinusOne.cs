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
 
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("OnCollisionEnter2D");

        if (collision.gameObject.CompareTag("Player"))
        {
            ScoreManager.Instance.IncScore(-1);
        }
        else if (collision.gameObject.CompareTag("Boundary"))
        {
            ScoreManager.Instance.IncScore(1);
        }

        Destroy(gameObject);
    }
}
