using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectHealth : MonoBehaviour
{

    public GameObject playerManager;
    private PlayerManager playerManagerScript;

    // Start is called before the first frame update
    void Start()
    {
        playerManagerScript = playerManager.GetComponent<PlayerManager>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            playerManagerScript.increaseMaximumHealth();
            Destroy(gameObject);
        }
    }
}
