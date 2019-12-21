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
       uihealth.text = health.ToString();
    }
     private void Damage()
    {
        health -= 1;
        Debug.Log("Au");

        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.tag);
        if (damageTags.Contains(other.tag))
        {
            Damage();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (damageTags.Contains(collision.gameObject.tag))
        {
            Damage();
        }

    }
}
