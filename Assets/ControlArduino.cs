using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;
using System.Threading;

public class ControlArduino: MonoBehaviour
{
    // PUT here your port name 
    public static SerialPort sp = new SerialPort("COM5", 9600);
    
    // Start is called before the first frame update
    void Start()
    {
        OpenConnection();
        
    }

    public void OpenConnection()
    {
        if (sp!=null)
        {
            if(sp.IsOpen)
            {
                sp.Close();
                print("Closing port, because it's already open");
            }
            else
            {
                sp.Open();
                sp.ReadTimeout = 100;
                print("port open");
            }
        }
        else 
        {
            if(sp.IsOpen)
            {
                print("port is already open");
            }
            else{
                print("port == null");
            }
        }
        
    } 

    void OnApplicationQuit()
    {
        sp.Close();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            sendTrue();
        }
    }

    public static void sendTrue(){
        sp.Write("t");
    }
    
    public static void sendFalse(){
        sp.Write("f");
    }

    public static void sendChoke(){
        sp.Write("c");
    }
    
    public static void sendStop(){
        sp.Write("s");
    }
    
    public static void sendReverse(){
        sp.Write("r");
    }
}
