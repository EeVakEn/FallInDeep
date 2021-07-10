using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Relationship : MonoBehaviour
{
    public int coinValue = 1;
    public Animator anim1, anim2;
    private Animator anim;
    public GameObject effect;
    private void Start()
    {
        if (Public.charOn == 1)
        {
            anim = anim1;
        }
        else if (Public.charOn == 2)
        {
            anim = anim2;
        }

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag.Equals("platform"))
        {
            GameObject.FindWithTag("Player").GetComponent<healthbar>().fill -= 1f;
            GameObject.FindWithTag("Player").GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePositionX;
            GameObject.FindWithTag("Player").GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeRotation;
            anim.SetTrigger("isDieOnPlatform");
        }
        if (other.gameObject.tag.Equals("health"))
        {
            GameObject.FindWithTag("Player").GetComponent<healthbar>().fill += 0.1f;
            Destroy(other.gameObject);
            anim.SetTrigger("isHeal");

        }
        if (other.gameObject.tag.Equals("enemy"))
        {

            GameObject.FindWithTag("Player").GetComponent<healthbar>().fill -= 0.4f;

            Destroy(other.gameObject);
            anim.SetTrigger("isHit");

        }
        if (other.gameObject.tag.Equals("coin"))
        {
            //+баланс
            CoinManager.instance.ChangeScore(coinValue);
            Instantiate(effect, transform.position, Quaternion.identity);
            Destroy(other.gameObject);

        }
    }

}
