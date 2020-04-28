using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiNavigation : MonoBehaviour
{

    public Vector2 vectMove;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(vectMove.normalized * speed * Time.deltaTime);
    }
}
