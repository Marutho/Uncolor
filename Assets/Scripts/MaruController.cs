using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaruController : MonoBehaviour
{
    public Sprite normalPlayer1;
    public Sprite normalPlayer2;
    public Sprite AngryPlayer1;

    public Sprite actualSprite;

    private float time;

    void Start()
    {
        actualSprite = GetComponent<SpriteRenderer>().sprite;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(actualSprite.name);
        float dt = Time.deltaTime;
        GetComponent<SpriteRenderer>().sprite = actualSprite;
        if ((int)time % 2 == 0)
        {
            if (actualSprite.name == normalPlayer1.name)
            {
                actualSprite = normalPlayer2;
            }
            else
            {

            }
            
        }
        else if ((int)time % 2 != 0)
        {
            if (actualSprite.name == normalPlayer2.name)
            {
                actualSprite = normalPlayer1;
            }
            else
            {

            }
        }


        time += dt * 5.0f;
    }
}
