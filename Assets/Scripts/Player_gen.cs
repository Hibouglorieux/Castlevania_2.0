using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_gen : MonoBehaviour
{
    public GameObject abc;
    void Load_char(int i)
    {
        if (i == 0)
            ;
        Instantiate(abc, new Vector3(0, 2, -10), new Quaternion());
    }
    void Start()
    {
        Load_char(0);
    }

    void Update()
    {
        
    }
}
