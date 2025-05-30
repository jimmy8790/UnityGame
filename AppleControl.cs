using UnityEditor.ShaderGraph;
using UnityEngine;

public class AppleControl : MonoBehaviour
{
    private Sprite apple1;
    public Sprite apple2;
    private SpriteRenderer appleSprite;

    void Start(){
        appleSprite = GetComponent<SpriteRenderer>();
        apple1 = appleSprite.sprite;
    }
    private Color[] myColor = {
        Color.red,
        new Color(1f,0.5f,0f),
        Color.yellow,
        Color.green,
        Color.cyan,
        Color.magenta,
        new Color(0.5f,0f,0.5f),
    };

    private int colorIndex=0;
    void OnTriggerEnter2D(Collider2D other)
    {
        appleSprite.sprite = apple2;
        Invoke("origin",0.5f);

        SpriteRenderer playSprite = other.GetComponent<SpriteRenderer>();
        playSprite.color = myColor[colorIndex];
        colorIndex=(colorIndex+1)%myColor.Length;
    }
    void origin(){
        appleSprite.sprite = apple1;
        float newX = Random.Range(-10,10);
        float newY = Random.Range(-4,4);
        transform.position = new Vector3(newX,newY,0);
    }
}
