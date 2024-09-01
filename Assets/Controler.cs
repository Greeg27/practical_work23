using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controler : MonoBehaviour
{
    [SerializeField] GameObject[] gameObjects;
    
    private Animator animator;

    private float scrollValue;
    private int objectActiv;
    private int objectSum;

    void Awake()
    {
        animator = GetComponent<Animator>();
        objectSum = gameObjects.Length;
        objectActiv = 0;
        gameObjects[objectActiv].SetActive(true);
    }

    void Update()
    {
        scrollValue = Input.GetAxis("Mouse ScrollWheel") * 10;
        if(scrollValue !=0) objectChange((int)scrollValue);

        if (Input.GetKey("1"))
        {
            animator.SetTrigger("1");
        }

        if (Input.GetKey("2"))
        {
            animator.SetTrigger("2");
        }

        if (Input.GetKey("3"))
        {
            animator.SetTrigger("3");
        }

        if (Input.GetKey("4"))
        {
            animator.SetTrigger("4");
        }

        if (Input.GetKey("5"))
        {
            animator.SetTrigger("5"); ;
        }
    }

    private void objectChange(int i)
    {
        gameObjects[objectActiv].SetActive(false);

        objectActiv += i;

        if(objectActiv == objectSum)
        {
            objectActiv = 0;
        }

        if(objectActiv < 0)
        {
            objectActiv = objectSum - 1;
        }

        gameObjects[objectActiv].SetActive(true);
    }

}
