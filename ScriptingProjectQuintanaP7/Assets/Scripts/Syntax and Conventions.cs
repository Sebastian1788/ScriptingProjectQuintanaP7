using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Jobs;

public class ConventionsandSyntax : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //this line is there to tell me the x position of my objects

        /*Hi there!
         * this is two lines!
         * */
        Debug.Log(transform.position.x);

        if(transform.position.y <= 5f)
        {
            Debug.Log("I'm  about to hit the ground!");
        }

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
