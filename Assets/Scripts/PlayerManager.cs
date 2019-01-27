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

    public bool isPlayerInSafeRoom;

    public int framesUntilHurt;

    private int frames;
    
    // Start is called before the first frame update
    void Start()
    {
        maxHealth = 100;
        currentHealth = maxHealth;
        isPlayerInSafeRoom = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (currentHealth <= 0)
        {
            Destroy(player);
        }

        if (framesUntilHurt < frames)
        {
            frames = 0;
            currentHealth--;
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
