using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialPopup : MonoBehaviour
{
    public GameObject TutorialBox;
    public GameObject Player;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    void OnTriggerEnter(Collider Trigger)
    {
        TutorialBox.SetActive(true);
        Player.GetComponent<PlayerMovement>().enabled = false;
        Cursor.lockState = CursorLockMode.None;
    }


    public void Exit()
    {
        TutorialBox.SetActive(false);
        Player.GetComponent<PlayerMovement>().enabled = true;
        Cursor.lockState = CursorLockMode.Locked;
    }
}
