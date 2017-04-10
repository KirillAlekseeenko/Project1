using UnityEngine;
using System.Collections;

public class GunScript : MonoBehaviour {

    public int speed = 60;
    public float bulletSpeed;
    public GameObject bullet;
    public GameObject bulletSpawn;
    public float fireRate;
    public string inputName;
    private float nextFire;
    
	// Use this for initialization
	void Start () {
        nextFire = 0;


	}
	
	// Update is called once per frame
	void FixedUpdate () {
        nextFire += Time.deltaTime;
        transform.Rotate(Vector3.up * Time.deltaTime * speed);
        if(Input.GetKey(inputName) && nextFire > fireRate)
        {
            
            nextFire = 0;
            GameObject newBullet = Instantiate(bullet, bulletSpawn.transform.position,Quaternion.identity) as GameObject;
            newBullet.GetComponent<Rigidbody>().velocity = (bulletSpawn.transform.position - transform.position) * bulletSpeed;
        }
    }
}
