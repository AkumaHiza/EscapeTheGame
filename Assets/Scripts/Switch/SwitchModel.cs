using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchModel : MonoBehaviour
{
   public bool isOn = false;
   public bool isPositionImportant = false;
   public bool shouldBeOn = true;

   public bool isInRange;
   public KeyCode interactKey = KeyCode.E; 

   void Start()
    {
      gameObject.AddComponent<SwitchController>();
    }
}
