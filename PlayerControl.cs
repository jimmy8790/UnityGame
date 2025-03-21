using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    float speed = 10f;
    float nomalspeed = 10f;
    float boostspeed = 20f;
    Vector3 dir = Vector3.zero;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");
        speed = Input.GetKey(KeyCode.Space) ? boostspeed : nomalspeed;

        dir = new Vector3(x,y,0);

        transform.position += dir * speed * Time.deltaTime;
    }
}
