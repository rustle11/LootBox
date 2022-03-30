using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit69 : MonoBehaviour
{
    static int score = 0;
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
        score = score + 1000;
        print("Заработок " + score + "$");
        Destroy(gameObject);
    }
}
