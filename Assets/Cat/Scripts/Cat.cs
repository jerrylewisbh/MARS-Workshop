using UnityEngine;
using System.Collections;

public class Cat : MonoBehaviour {
    Animator cat;
    public IEnumerator coroutine;
	// Use this for initialization
	void Start () {
        cat = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.Alpha1))
        {
            cat.SetBool("Idle", true);
            cat.SetBool("Walking", false);
        }
        if (Input.GetKey(KeyCode.Alpha2))
        {
            cat.SetBool("Walking", true);
            cat.SetBool("Idle", false);
            cat.SetBool("Turnright", false);
            cat.SetBool("Turnleft", false);
        }
        if (Input.GetKey(KeyCode.Alpha3))
        {
            cat.SetBool("Turnright", true);
            cat.SetBool("Walking", false);
            walk();
        }
        if (Input.GetKey(KeyCode.Alpha4))
        {
            cat.SetBool("Turnleft", true);
            cat.SetBool("Walking", false);
            walk();
        }
        if (Input.GetKey(KeyCode.Alpha5))
        {
            cat.SetBool("Trotting", true);
            cat.SetBool("Walking", false);
        }
        if (Input.GetKey(KeyCode.Alpha6))
        {
            cat.SetBool("Running", true);
            cat.SetBool("Trotting", false);
        }
        if (Input.GetKey(KeyCode.Alpha7))
        {
            cat.SetBool("Jumping", true);
            cat.SetBool("Running", false);
        }
        if (Input.GetKey(KeyCode.Alpha8))
        {
            cat.SetBool("Sneaking", true);
            cat.SetBool("Jumping", false);
            cat.SetBool("Attack", false);
        }
        if (Input.GetKey(KeyCode.Alpha9))
        {
            cat.SetBool("Attack", true);
            cat.SetBool("Sneaking", false);
        }
        if (Input.GetKey(KeyCode.Alpha0))
        {
            cat.SetBool("Sitting", true);
            cat.SetBool("Attack", false);
        }
        if (Input.GetKey(KeyCode.Keypad0))
        {
            cat.SetBool("Meow", true);
            cat.SetBool("Sitting", false);
        }
        if (Input.GetKey(KeyCode.Keypad1))
        {
            cat.SetBool("Getup", true);
            cat.SetBool("Meow", false);
        }
        if (Input.GetKey(KeyCode.Keypad2))
        {
            cat.SetBool("Eating", true);
            cat.SetBool("Getup", false);
        }
        if (Input.GetKey(KeyCode.Keypad3))
        {
            cat.SetBool("Licking", true);
            cat.SetBool("Eating", false);
        }
        if (Input.GetKey(KeyCode.Keypad4))
        {
            cat.SetBool("Attack2", true);
            cat.SetBool("Licking", false);
            cat.SetBool("Hited", false);
        }
        if (Input.GetKey(KeyCode.Keypad5))
        {
            cat.SetBool("Hited", true);
            cat.SetBool("Attack2", false);
        }
        if (Input.GetKey(KeyCode.Keypad6))
        {
            cat.SetBool("Died", true);
            cat.SetBool("Hited", false);
        }
    }
    IEnumerator walk()
    {
        yield return new WaitForSeconds(0.9f);
        cat.SetBool("Walking", true);
        cat.SetBool("Turnright", false);
        cat.SetBool("Turnleft", false);
    }
}
