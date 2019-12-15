using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    private List<string> damageTags;

    [SerializeField]
    private int maxHp = 10;
    private int currentHp;
    float speed1 = 2f;
     public float number;

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
    void Update(){
            Collider[] hitColliders = Physics.OverlapSphere(transform.position,20);
        foreach(Collider hitCollider in hitColliders){
            if(hitCollider.name == "Player"){
              
                float step = speed1 * Time.deltaTime;
             transform.position = Vector3.MoveTowards(transform.position,GameObject.Find("Player").GetComponent<Transform>().position,step);

    }
}
    }
}
