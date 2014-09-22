using UnityEngine;
using System.Collections;

public class Jump : MonoBehaviour
{
    public float jumpForce;
    GameObject hero;
	private PlatformInputHandler inputHandler;

    // Use this for initialization
    void Start()
    {
		inputHandler = InputHandler.PlatformInput;
		hero = GameObject.Find("Hero");
		Debug.Log(hero);
    }
    
    // Update is called once per frame
    void Update()
    {
		if (inputHandler.TouchBegin())
		{ 
			CheckTouch(inputHandler.TouchPosition(), "began");
		} else if (inputHandler.TouchEnd())
		{
			CheckTouch(inputHandler.TouchPosition(), "ended");
		}

    }

    void CheckTouch(Vector3 pos, string phase)
    {
        Vector3 wp = Camera.main.ScreenToWorldPoint(pos);
        Vector2 touchPos = new Vector2(wp.x, wp.y);
        Collider2D hit = Physics2D.OverlapPoint(touchPos);
        
        if (hit &&hit.gameObject.name == "JumpButton" && phase == "began")
        {
            hero.rigidbody2D.AddForce(new Vector2(0f, jumpForce));
            audio.Play();
        }
    }
}