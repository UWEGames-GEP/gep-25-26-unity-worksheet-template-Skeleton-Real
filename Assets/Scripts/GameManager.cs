using UnityEngine;

public class GameManagerScript : MonoBehaviour
{
    public enum state
    {
        GAMEPLAY,
        PAUSE
    }

    public state gameState = state.GAMEPLAY;

    bool stateChangeFrame = false;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //state gameState = state.GAMEPLAY;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameState == state.GAMEPLAY)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                gameState = state.PAUSE;
                stateChangeFrame = true;
            }
        }
        else if (gameState == state.PAUSE)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                gameState = state.GAMEPLAY;
                stateChangeFrame = true;
            }
        }
        }

    private void LateUpdate()
    {
        if (stateChangeFrame)
        {
            stateChangeFrame = false;
            if (gameState == state.GAMEPLAY)
                Time.timeScale = 1.0f;
            if (gameState == state.PAUSE)
                Time.timeScale = 0.0f;
        }
    }
}

