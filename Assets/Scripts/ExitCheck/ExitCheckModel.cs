using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitCheckModel : MonoBehaviour
{
  public bool openExit;
  public Sprite doorOpen;
  public Sprite doorClose;
  [HideInInspector] 
  public IsEnd[] allObjects;
  public bool nextLevel;

  void Start()
  {
   gameObject.AddComponent<ExitCheckController>();
   gameObject.AddComponent<ExitCheckView>();
   openExit = false;
   nextLevel = false;
  }

  void Update()
  {
    allObjects = GameObject.FindObjectsOfType<IsEnd>();
  }

  private void OnTriggerEnter2D(Collider2D collision)
  {
    if(openExit == true && collision.tag == "Player")
    {
      nextLevel = true;
    }
  }

}