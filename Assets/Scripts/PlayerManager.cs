using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerManager : MonoBehaviour
{
    public float health;
    public float damage;
    bool dead = false;
    public CoinController cc;
    public Slider slider;

    void Start()
    {
        slider.maxValue = health;
        slider.value = health;
    }

    void Update()
    {

    }
    public void GetDamage(float damage)
    {
        if(health - damage > 0)
        {
            health -= damage;
        }
        else 
        {
            health = 0;
        }
        slider.value = health;
        AmIDead();
    }

    void AmIDead()
    {
        if (health <= 0)
        {
            dead = true;
            SceneManager.LoadScene(3);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Coin")
        {
            cc.Coin += 1;
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.tag == "Health")
        {
            health += 10;
            slider.value = health;
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.tag == "Lock1")
        {
            
            SceneManager.LoadScene(23);
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.tag == "Lock2")
        {

            SceneManager.LoadScene(24);
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.tag == "Lock3")
        {

            SceneManager.LoadScene(25);
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.tag == "Lock4")
        {

            SceneManager.LoadScene(26);
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.tag == "Lock5")
        {

            SceneManager.LoadScene(27);
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.tag == "Lock6")
        {

            SceneManager.LoadScene(28);
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.tag == "Lock7")
        {

            SceneManager.LoadScene(29);
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.tag == "Lock8")
        {

            SceneManager.LoadScene(30);
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.tag == "Lock9")
        {

            SceneManager.LoadScene(31);
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.tag == "Lock10")
        {

            SceneManager.LoadScene(32);
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.tag == "Lock11")
        {

            SceneManager.LoadScene(33);
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.tag == "Lock12")
        {

            SceneManager.LoadScene(34);
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.tag == "Lock13")
        {

            SceneManager.LoadScene(35);
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.tag == "Lock14")
        {

            SceneManager.LoadScene(36);
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.tag == "Lock15")
        {

            SceneManager.LoadScene(37);
            Destroy(collision.gameObject);
        }

    }

}
