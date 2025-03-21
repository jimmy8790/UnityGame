using UnityEditor.ShaderGraph;
using UnityEngine;

public class AppleControl : MonoBehaviour
{
    private Color[] myColor = {
        Color.red,
        new Color(1f,0.5f,0f),
        Color.yellow,
        Color.green,
        Color.cyan,
        Color.magenta,
        new Color(0.5f,0f,0.5f),
    };
    void OnTriggerEnter2D(Collider2D other)
    {
        float newX = Random.Range(-10,10);
        float newY = Random.Range(-4,4);
        transform.position = new Vector3(newX,newY,0);
    }
}
