using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 10.0f;
    private Rigidbody bulletRB;
    public float lifeTime = 10f;
    public Transform barrelTransform;

    // Start is called before the first frame update
    void Start()
    {
        bulletRB = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(lifeTime > 0)
        {
            lifeTime -= Time.deltaTime;
            if(lifeTime <= 0)
            {
                Destruction();
            }
        }
    }

    void Go()
    {
        bulletRB.velocity = speed * barrelTransform.forward;
    }

    void Destruction()
    {
        Destroy(this.gameObject);
    }
}
