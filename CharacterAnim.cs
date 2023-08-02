using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnim : MonoBehaviour
{
    public Animator animka;
    int walkHash, runHash;

    void Start()
    {
        walkHash = Animator.StringToHash("walk");
        runHash = Animator.StringToHash("run");
    }

    void Update()
    {
        bool run = animka.GetBool(runHash);
        bool walk = animka.GetBool(walkHash);
        bool forwardPresed = Input.GetKey("w");
        bool runPresed = Input.GetKey("q");

        if(!walk && forwardPresed)
        {
            animka.SetBool("walk", true);
        }

        if (walk && !forwardPresed)
        {
            animka.SetBool("walk", false);
        }

        if (!run && (forwardPresed && runPresed))
        {
            animka.SetBool("run", true);
        }

        if (run && (!forwardPresed || !runPresed))
        {
            animka.SetBool("run", false);
        }
    }
}
