using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float l_horizontal = Input.GetAxisRaw("LHorizontal");
        float l_vertical = Input.GetAxisRaw("LVertical");

        float r_horizontal = Input.GetAxisRaw("LHorizontal");
        float r_vertical = Input.GetAxisRaw("LVertical");

        Vector3 rotation = new Vector3(0, 0, 0);
        Vector3 direction = new Vector3(l_horizontal, 0, l_vertical);

        gameObject.transform.Translate(direction.normalized * Time.deltaTime * speed);

        
    }
}
