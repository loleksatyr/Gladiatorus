using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    private List<string> damageTags;

    [SerializeField]
    private int maxHp = 10;
    private int currentHp;

    [SerializeField]
    private Color hitColor = Color.red;

    private void Start()
    {
        currentHp = maxHp;
    }

    private void Damage()
    {
        currentHp -= 5;

        if (currentHp <= 0)
        {
            Destroy(this.gameObject);
        }
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
