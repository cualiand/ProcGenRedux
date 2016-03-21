using UnityEngine;
using System.Collections;

public class pathmaker : MonoBehaviour {

    private int counter = 0;
    public Transform floorPrefab;
    public Transform pathmakerPrefab;
    public Transform blockPrefab;
    public Transform monster1;
    public Transform monster2;
    public Transform monster3;

    public int counterNumber = 50;
    public float rePathMakerStart = .98f;
    public float rePathMakerEnd = .99f;
    public float createMonsterStart = .90f;
    public float createMonsterEnd = .95f;


	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
        
	    if (counter < counterNumber)
        {
            float randNum = Random.Range(0f, 1f);
            if (randNum < .25f)
            {
                transform.Rotate(0f, 90f, 0f);
            }
            else if (randNum > .25f && randNum < .5f)
            {
                transform.Rotate(0f, -90f, 0f);
            }
            else if (randNum > createMonsterStart && randNum < createMonsterEnd)
            {
                float monsterRandNum = Random.Range(0f, 1f);
             
                if (monsterRandNum > .33f)
                {
                    Instantiate(monster1, transform.position, Quaternion.identity);
                }
                else if (monsterRandNum < .66f && monsterRandNum > .33f)
                {
                    Instantiate(monster2, transform.position, Quaternion.identity);
                }
                else if (monsterRandNum < 1f && monsterRandNum > .66f)
                {
                    Instantiate(monster3, transform.position, Quaternion.identity);
                }
            }

            else if (randNum > rePathMakerStart && randNum < rePathMakerEnd)
            {
                Instantiate(pathmakerPrefab, transform.position, Quaternion.identity);
            }
            else if (randNum > .99f)
            {
                Instantiate(floorPrefab, transform.position, Quaternion.identity);
                Instantiate(blockPrefab, transform.position + Vector3.up * 5, Quaternion.identity);
                transform.Translate(0f, 10f, 0f);
            }
            Instantiate(floorPrefab, transform.position, Quaternion.identity);
            transform.Translate(5f, 0f, 0f);
            counter++;
        }
        else
        {
            Destroy(gameObject);
        }
	}
}
