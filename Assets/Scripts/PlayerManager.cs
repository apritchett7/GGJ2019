using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public GameObject player;
    public int maxHealth;
    public int currentHealth;
    public int healthIncreaseAmount;
    public bool fullyHealOnMaxHealthIncrease;
    
    // Start is called before the first frame update
    void Start()
    {
        maxHealth = 100;
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if (currentHealth <= 0)
        {
            Destroy(player);
        }
    }

    public void increaseMaximumHealth()
    {
        maxHealth += healthIncreaseAmount;
        if (fullyHealOnMaxHealthIncrease)
        {
            currentHealth = maxHealth;
        }
        else
        {
            currentHealth += healthIncreaseAmount;
        }
    }
}
