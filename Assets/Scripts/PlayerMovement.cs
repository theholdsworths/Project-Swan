using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    // Force that is added to the player on the Y axis
    public Vector2 jumpForce = new Vector2(0, 300);

    // Update is called once per frame
    void Update()
    {
        Time.timeScale = 1;

        // If the user presses the "w" key, force will be added to the player and the player will jump up.
        
        if (Input.GetKeyUp("w"))
        {
            GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            GetComponent<Rigidbody2D>().AddForce(jumpForce);
        }

        Vector2 screenPosition = Camera.main.WorldToScreenPoint(transform.position);
        if (screenPosition.y > Screen.height || screenPosition.y < 0)
        {
            Time.timeScale = 0;
            OnGUI();

        }
    }

    void Die()
    {
        //transform.parent.gameObject.GetComponent<GameOver>();
        //transform.parent.gameObject.AddComponent<GameOver>();
        Debug.Log("player off screen");

        


    }

    //

    void OnGUI()
    {
        const int buttonWidth = 120;
        const int buttonHeight = 60;

        if (
          GUI.Button(
            // Center in X, 1/3 of the height in Y
            new Rect(
              Screen.width / 2 - (buttonWidth / 2),
              (1 * Screen.height / 3) - (buttonHeight / 2),
              buttonWidth,
              buttonHeight
            ),
            "Retry!"
          )
        )
        {
            // Reload the level
            SceneManager.LoadScene("Level 1");
        }
    }
}
