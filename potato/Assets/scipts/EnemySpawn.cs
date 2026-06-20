using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public List <GameObject> Enemies=new List<GameObject>();

    void Start()
    {
        StartCoroutine(smiles());
    }

    IEnumerator smiles()
    { 
        while(true)
        {       
             yield return new WaitForSeconds(7f);
            Instantiate(Enemies[Random.Range(0,Enemies.Count)], transform.position+new Vector3(0,-0.81f,0), Quaternion.identity);
         }
    }
}
