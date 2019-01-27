using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerManager : MonoBehaviour
{
    public GameObject player;

    public Slider slider;

    public GameObject startingRoom;

    private BoxCollider2D startingRoomCollider;
    private BoxCollider2D playerCollider;

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

        slider.maxValue = maxHealth;
        slider.value = currentHealth;

        startingRoomCollider = startingRoom.GetComponent<BoxCollider2D>();
        playerCollider = player.GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (startingRoomCollider.Distance(playerCollider).isOverlapped)
        {
            isPlayerInSafeRoom = true;
        } else
        {
            isPlayerInSafeRoom = false;
        }
        if (currentHealth <= 0)
        {
            Destroy(player);
        }
        if (!isPlayerInSafeRoom)
        {
            frames++;
            if (framesUntilHurt < frames)
            {
                frames = 0;
                currentHealth--;
            }
        }
        slider.maxValue = maxHealth;
        slider.value = currentHealth;
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
        slider.gameObject.transform.localScale += new Vector3(0.1f, 0.0f, 0.0f);
    }
}
