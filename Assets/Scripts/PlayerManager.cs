﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerManager : MonoBehaviour
{
    public GameObject player;

    public Slider slider;

    public GameObject startingRoom;

    public GameObject frontOfHouse;

    public Animator anim;

    private BoxCollider2D startingRoomCollider;
    private BoxCollider2D playerCollider;
    private BoxCollider2D frontHouseCollider;

    public int maxHealth;
    public int currentHealth;
    public int healthIncreaseAmount;
    public bool fullyHealOnMaxHealthIncrease;

    public bool isPlayerInSafeRoom;

    public int framesUntilHurt;

    private int frames;

    private bool gameBeaten;
    
    // Start is called before the first frame update
    void Start()
    {
        maxHealth = 100;
        currentHealth = maxHealth;
        gameBeaten = false;

        slider.maxValue = maxHealth;
        slider.value = currentHealth;

        startingRoomCollider = startingRoom.GetComponent<BoxCollider2D>();
        playerCollider = player.GetComponent<BoxCollider2D>();
        frontHouseCollider = frontOfHouse.GetComponent<BoxCollider2D>();

        anim.SetBool("explosion", false);
    }

    // Update is called once per frame
    void Update()
    {
        if (gameBeaten || startingRoomCollider.Distance(playerCollider).isOverlapped)
        {
            isPlayerInSafeRoom = true;
        } else
        {
            isPlayerInSafeRoom = false;
        }

        if (frontHouseCollider.Distance(playerCollider).isOverlapped)
        {
            currentHealth = maxHealth;
        }

        if (currentHealth <= 0)
        {
            anim.SetBool("explosion", true);
            if (anim.GetCurrentAnimatorStateInfo(0).IsName("Game Over"))
            {
                Destroy(player);
            }
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
        slider.gameObject.transform.localScale += new Vector3(0.25f, 0.0f, 0.0f);
    }

    public void beatGame()
    {
        gameBeaten = true;
    }
}
