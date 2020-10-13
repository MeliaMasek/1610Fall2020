using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewMoveLeft : MonoBehaviour
{
    private float leftBound = -15;
    private float speed = 30;
    private NewPlayerController newPlayerControllerScript;
    // Start is called before the first frame update
    void Start()
    {
        newPlayerControllerScript = GameObject.Find("Player").GetComponent<NewPlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (newPlayerControllerScript.gameOver == false)
        {
            transform.Translate(Vector3.left * (Time.deltaTime * speed));
        }

        if (transform.position.x < leftBound && gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        }
    }
}
