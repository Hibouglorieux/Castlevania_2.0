using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouvements : MonoBehaviour
{
    public float x_mvt = 0;
    public float y_mvt = 0;
    [SerializeField] private GameObject player;

    void chut()
    {
        if (right && x_mvt < max_speed)
        {
            if (acceleration + x_mvt < max_speed)
                translate(Acceleration + x_mvt);
            else
                translate(max_speed);
        }Transform.Translate(x, y z);
    }

void Start()
    {
        
    }

}
