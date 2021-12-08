using System;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    [SerializeField] private float shootRate = 3f;
    [SerializeField] private GameObject projectile;
    
    private float timer = 10f;
    private bool start = false;

    private void Update()
    {
        if (start)
        {
            if (timer < shootRate)
                timer += Time.deltaTime;
            else
            {
                timer = shootRate;
                start = false;
            }
        }
    }

    private void OnShoot()
    {
        if (timer >= shootRate)
        {
            GameObject newProjectile = Instantiate(projectile, transform.position + transform.forward, transform.rotation);
            newProjectile.transform.parent = gameObject.transform.parent;
            newProjectile.GetComponent<Rigidbody>().AddForce(transform.forward*70, ForceMode.VelocityChange);
            start = true;
            timer = 0f;
        }
    }
}
