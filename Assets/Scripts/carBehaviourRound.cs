using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carBehaviourRound : MonoBehaviour
{
    public GameObject rotonda;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.RotateAround(rotonda.transform.position, new Vector3(0,0,1), 60 *Time.deltaTime);
    }
}
