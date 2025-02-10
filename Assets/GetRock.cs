using System.Collections;
using UnityEngine;

public class GetRock : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject rock;

    void Start()
    {
        StartCoroutine("GoRock");
    }

    IEnumerator GoRock() {
        for (;;) {
            yield return new WaitForSeconds(Random.Range(2f,5f));
            Instantiate(rock);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
