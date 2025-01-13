using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmergencyStop : MonoBehaviour
{
   public void Reverse()
   {
      ControlArduino.sendReverse();
   }
}
