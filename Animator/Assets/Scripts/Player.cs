using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            //bool boolPower = anim.GetBool("BoolPower");
            //anim.SetBool("BoolPower",!boolPower);

            //anim.SetTrigger("TriggerPower");

            float f = anim.GetFloat("FloatPower");
            if(f == 0)
            {
                f = 1;
            }
            else
            {
                f = 0;
            }

            anim.SetFloat("FloatPower", f);
        }
    }
}
