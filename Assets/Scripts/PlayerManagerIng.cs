using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerManagerIng : MonoBehaviour
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
        if (health - damage > 0)
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
            SceneManager.LoadScene(6);
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
        else if (collision.gameObject.tag == "Lock16")
        {

            SceneManager.LoadScene(54);
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.tag == "Lock17")
        {

            SceneManager.LoadScene(55);
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.tag == "Lock18")
        {

            SceneManager.LoadScene(56);
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.tag == "Lock19")
        {

            SceneManager.LoadScene(57);
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.tag == "Lock20")
        {

            SceneManager.LoadScene(58);
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.tag == "Lock21")
        {

            SceneManager.LoadScene(59);
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.tag == "Lock22")
        {

            SceneManager.LoadScene(60);
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.tag == "Lock23")
        {

            SceneManager.LoadScene(61);
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.tag == "Lock24")
        {

            SceneManager.LoadScene(62);
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.tag == "Lock25")
        {

            SceneManager.LoadScene(63);
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.tag == "Lock26")
        {

            SceneManager.LoadScene(64);
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.tag == "Lock27")
        {

            SceneManager.LoadScene(65);
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.tag == "Lock28")
        {

            SceneManager.LoadScene(66);
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.tag == "Lock29")
        {

            SceneManager.LoadScene(67);
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.tag == "Lock30")
        {

            SceneManager.LoadScene(68);
            Destroy(collision.gameObject);
        }

    }
}
