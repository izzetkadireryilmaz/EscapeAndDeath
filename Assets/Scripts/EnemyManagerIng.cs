using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManagerIng : MonoBehaviour
{
    public float health;
    public float damage;

    bool colliderBusy = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player" && !colliderBusy)
        {
            colliderBusy = true;
            other.GetComponent<PlayerManagerIng>().GetDamage(damage);
            GetDamage(other.GetComponent<PlayerManagerIng>().damage);
        }
        else if (other.tag == "Arrow")
        {
            GetDamage(other.GetComponent<ArrowManager>().arrowDamage);
        }
        
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            colliderBusy = false;
        }
    }
    public void GetDamage(float damage)
    {
        if (health - damage > 0)
        {
            health -= damage;
        }
        else
        {
            health = 0;
        }
        AmIDead();
    }

    void AmIDead()
    {
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }

}
