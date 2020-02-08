using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour
{

    // Start is called before the first frame update

    public GameObject theEnemy;
    public int xPos;
    public int zPos;
    public int EnemyCounter;
    void Start()
    {
        StartCoroutine(EnemyDrop());
    }
    IEnumerator EnemyDrop() {
        while (EnemyCounter < 10) {
            xPos = Random.Range(20,26);
            zPos = Random.Range(-4, -16);
            Instantiate(theEnemy, new Vector3(xPos,0.1f,zPos),Quaternion.identity);
            yield return new WaitForSeconds(5f);
            EnemyCounter += 1;
        }
    }
}
