﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetController : MonoBehaviour
{
    //TODO build a more structured connection
    public static ITargetable CurrentTarget;
    // interfaces don't serialize so need class reference
    [SerializeField] Creature _objectToTarget = null;

    // Update is called once per frame
    void Update()
    {
        //target the object when '1' is pressed 
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            //taregt the object, if it is targetable
            ITargetable possibleTarget =
                _objectToTarget.GetComponent<ITargetable>();
            if(possibleTarget != null)
            {
                Debug.Log("New target aquired!");
                CurrentTarget = possibleTarget;
                _objectToTarget.Target();
            }
        }
    }
}
