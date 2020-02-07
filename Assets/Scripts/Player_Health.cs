using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player_Health : MonoBehaviour
{
    // Start is called before the first frame update
    public int health;
    public Text uihealth;
     [SerializeField]
    private List<string> damageTags;

    void Start()
    {
        health = 10;   

    }

    // Update is called once per frame
    void Update()
    {
      
        if (health <= 0)
        {
            uihealth.text = "You died";
        }
        else
             uihealth.text = health.ToString();
    }
     private void Damage()
    {
        health -= 10;
        Debug.Log("Au");
       
        
    }

   

    public void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "Untagged")
        {
            Damage();
        }
        Debug.Log(collision.gameObject.name);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "enemy") {
            Damage();
        }
    }
}
