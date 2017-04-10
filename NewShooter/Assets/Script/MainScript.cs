using UnityEngine;
using System.Collections;

public class MainScript : MonoBehaviour {
    public Transform Enemy;
    public float SpawnTime = 30;
    public float SpawnEnemyBorder;
    private float time;

    // Use this for initialization
    void Start () {
        time = SpawnTime;
    }
	
	// Update is called once per frame
	void Update () {
        if (time > 0)
        {
            time -= Time.deltaTime;
        }
        else
        {
            time = SpawnTime;
            Instantiate(Enemy, new Vector3(Random.Range(-SpawnEnemyBorder, SpawnEnemyBorder), 0, 4), Quaternion.identity);
        }
        
    }
}
