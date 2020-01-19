using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public float damage = 10f;
    public float range = 100f;
    public float power = 40f;
    public GameObject bullet;
    public Transform spawnTransform;
    public GameObject bulletClone;
    

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            //Shoot();
            ShootBullet();
        }
        
    }

    void ShootBullet()
    {
      bulletClone = Instantiate(bullet, spawnTransform.position, spawnTransform.rotation) as GameObject;
        bulletClone.transform.Rotate(90, 0, 0);
        var bulletRB = bulletClone.GetComponent<Rigidbody>();
        bulletRB.velocity = power * spawnTransform.forward;


    }

    void Shoot()
    {
        /*RaycastHit hit;
        if(Physics.Raycast(transform.position, transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);
        }*/
        
        
    }
}
