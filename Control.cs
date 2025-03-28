using UnityEngine;

public class Control : MonoBehaviour
{
    float roSpeed = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0,0,roSpeed);
        roSpeed *= 0.999f;
        if(Input.GetMouseButtonDown(0)){
            roSpeed = 5;
        }

        if(Input.GetKeyDown(KeyCode.Escape)){
            Application.Quit();
        }
    }
}
