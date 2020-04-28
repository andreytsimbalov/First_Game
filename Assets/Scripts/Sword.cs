using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : MonoBehaviour
{

    public float offset;
    public float startShotTime;
    private float timeShot = 0;
    public float damage = 7f;
    public GameObject oblast;
    HashSet<Collider2D> _objInCollider = new HashSet<Collider2D>();

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (!collider.isTrigger && collider.tag== "Enemy"){
            _objInCollider.Add(collider);
            Debug.Log(_objInCollider.Count);
        }
    }

    void OnTriggerExit2D(Collider2D collider)
    {
        _objInCollider.Remove(collider);
    }


    void Update()
    {
        Vector3 diff = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float rotateZ = Mathf.Atan2(diff.y, diff.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rotateZ + offset);

        if (timeShot <= 0)
        {
            if (Input.GetMouseButtonDown(1))
            {
                HitSword();
                SwordAnim sw = oblast.GetComponent<SwordAnim>();
                sw.playAnim();
                timeShot = startShotTime;
            }
        }
        else
        {
            timeShot -= Time.deltaTime;
        }
    }

    //private void OnTriggerStay2D(Collider2D collision)
    //{

    //}

    private void HitSword()
    {

        int n = _objInCollider.Count;
        int i = 0;
        int j = 0;
        while (j < n) {
            try
            {
                foreach (Collider2D coll in _objInCollider)
                {
                    if (j >= i) {
                        EnemyBrain1 enemy = coll.GetComponent<EnemyBrain1>();
                        if (enemy != null)
                        {
                            enemy.TakeDamage(damage);
                            Debug.Log(_objInCollider.Count);
                        }
                    }
                    
                    j++;
                    

                }
            }
            catch
            {
                n -= 1;
                i = j-1;
                j = 0;
                Debug.Log(_objInCollider.Count);
            }
        }
        Debug.Log("Success damage");

    }
    
}
