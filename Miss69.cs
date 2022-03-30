using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Miss69 : MonoBehaviour
{
    Transform case_transform;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        print("Мимо");
        Destroy(gameObject);
        case_transform.Translate(0.1f, 0, 0);
    }
}
