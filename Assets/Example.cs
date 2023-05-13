using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;
using System;
using System.Threading.Tasks;

public class Example : MonoBehaviour
{
    public Transform[] cubes;
    
    
    
    private async void lifeAsync()
    {
        for (var i = 0; i < cubes.Length; i++)
        {
          await rotateAsync(cubes[i]);
        }
    }

    private async Task rotateAsync(Transform o)
    {
        float timer = 0;
        while (timer < 3)
        {
            timer = Math.Min(timer + Time.deltaTime, 3);
            o.Rotate(Vector3.up,0.2f);
            await Task.Yield();
        }
    }



    void Start()
    {
         lifeAsync();
    }
    
    
    /*void Start()
    {
        StartCoroutine(lifeCourutin());
       
    }


/*
    IEnumerator lifeCourutin()
    {
        for (var i = 0; i < cubes.Length; i++)
        {
            yield return StartCoroutine(rotateCourutin(cubes[i]));
        }
    }

    IEnumerator rotateCourutin(Transform O)
    {
        float timer = 0;
        while (timer < 3)
        {
            timer = Math.Min(timer + Time.deltaTime, 3);
            O.Rotate(Vector3.up,0.2f);
            yield return null;
        }
        
    }

*/
}
