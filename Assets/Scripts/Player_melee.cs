using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_melee : Player
{

    // Start is called before the first frame update
    void Start()
    {
        max_jumps = 2;
        speed_multiplier *= 2;
    }

}
