using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordAnim : MonoBehaviour
{
    private Animator anim;
    private float startShotTime=0.1f;
    private float timeShot = 0;



    void Start()
    {
        anim = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timeShot <= 0 && anim.GetBool("IsHits"))
        {
            anim.SetBool("IsHits", false);
        }
        else
        {
            timeShot -= Time.deltaTime;
        }
    }

    public void playAnim()
    {
        anim.SetBool("IsHits", true);
        timeShot = startShotTime;
    }
}
