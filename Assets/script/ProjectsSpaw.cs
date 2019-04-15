using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectsSpaw : MonoBehaviour
{
    // Start is called before the first frame update
    
    GameObject parent;

    public GameObject predab;

    public GameObject spawnPoint;
    public float waitTime = 3f;

    public float projectileSpeed = 3f;

    public Vector3[] directions;

        void Start()
    {

     parent = GameObject.Find("Tape");
     StartCoroutine(Spawn());
    }
IEnumerator Spawn(){

    while (true) {
        yield return new WaitForSeconds(waitTime);
        for(int i=0; i<directions.Length; i++) {

            GameObject projectile = Instantiate(predab,spawnPoint.transform.position, Quaternion.identity);
        projectile.transform.SetParent(parent.transform);
        projectile.GetComponent<Rigidbody2D>().velocity = projectileSpeed * directions[i];
        }
    }
}
}
