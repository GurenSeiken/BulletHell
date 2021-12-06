using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerr : MonoBehaviour
{
    public int maxHealth = 100;
	public int currentHealth;
    // Start is called before the first frame update
    private void Start()
    {
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    private void Update()
    {
        
    }
    void TakeDamage(int damage)
    {
        currentHealth -= damage;
    }
}
