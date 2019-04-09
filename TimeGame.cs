using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeGame : MonoBehaviour
{
    float roundStartDelayTime = 3;
    float roundStartTime;
    int waitTime;
    bool roundStarted;

    // Start is called before the first frame update
    void Start()
    {
        print("Press the spacebar once you think the allotted time is up.");
        Invoke("SetNewRandomTime", roundStartDelayTime); // Invoke sets a delay (function, time)
    }

    // Update is called once per frame
    void Update(){
        if (Input.GetKeyDown(KeyCode.Space) && roundStarted){
            InputReceived();
        }
    }

    void InputReceived()
    {
        roundStarted = false;
        float playerWaitTime = Time.time - roundStartTime;
        float error = Mathf.Abs(waitTime - playerWaitTime);

        print("Error you waited for " + playerWaitTime + " seconds. That's " + error + " seconds off");
        SetNewRandomTime();
    }

    void SetNewRandomTime()
    {
        waitTime = Random.Range(5, 21);
        roundStartTime = Time.time;
        roundStarted = true;

        print(waitTime + " seconds.");
    }
}
