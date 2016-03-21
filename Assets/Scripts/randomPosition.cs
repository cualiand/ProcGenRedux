using UnityEngine;
using System.Collections;

public class randomPosition : MonoBehaviour {

    public Transform cube;

	// Use this for initialization
	void Start () {
        float randomNumber = Random.Range(0f, 1f);
        Debug.Log(randomNumber.ToString());
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log(Random.Range(0, 1)); //exclusive random
        Vector3 randomPosition = new Vector3(Random.Range(-5f, 5f), Random.Range(-5f, 5f), Random.Range(-5f, 5f));

        transform.position = cube.position + randomPosition;
	}
}
