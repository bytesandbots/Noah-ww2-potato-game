using System.Collections;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public bool isEnemy;
    public float bulletSpeed;
    public float firingRate;
    public GameObject projectile;


    void Start()
    {
        StartCoroutine(FiringRate());
    }


    IEnumerator FiringRate()
    {
        while (true)
        {
            yield return new WaitForSeconds(firingRate);
            GameObject newBullet = Instantiate(projectile, transform.position, Quaternion.identity);
            
        }
    }



}



