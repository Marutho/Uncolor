using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaruController : MonoBehaviour
{
    public Sprite normalPlayer1;
    public Sprite normalPlayer2;
    public Sprite AngryPlayer1;

    public float speedAnim;

    [SerializeField]
    private Sprite actualSprite;

    private float time;

    void Start()
    {
        actualSprite = GetComponent<SpriteRenderer>().sprite;
        speedAnim = 5.0f;
    }

    // Update is called once per frame
    void Update()
    {
        
        //Debug.Log("El sprite normal 1: " + normalPlayer1.name);
       // Debug.Log("El sprite normal 2: " + normalPlayer2.name);
        float dt = Time.deltaTime;
        actualSprite = GetComponent<SpriteRenderer>().sprite;

        Debug.Log("El sprite actual es: " + actualSprite.name);
        if ((int)time % 2 == 0)
        {
            if (actualSprite.name == normalPlayer1.name)
            {
                Debug.Log("He entrado al sprite 1");
                actualSprite = normalPlayer2;
                GetComponent<SpriteRenderer>().sprite = actualSprite;
            }
        }
        else if ((int)time % 2 != 0)
        {
            if (actualSprite.name == normalPlayer2.name)
            {
                Debug.Log("He entrado al sprite 2");
                actualSprite = normalPlayer1;
                GetComponent<SpriteRenderer>().sprite = actualSprite;
            }
        }

        time += dt * speedAnim;
    }       
}

