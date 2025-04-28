using GameFramework;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityGameFramework.Runtime;

public class Test001 : MonoBehaviour, IReference
{
    public void Clear()
    {
       
    }

    // Start is called before the first frame update
    void Start()
    {
        Log.Info("Hello Game Framework {0}+++++++{1}++++{2}.",new object[3] { 1, 2, Version.GameFrameworkVersion.ToString() });

       string a= Utility.Text.Format("Hello Game Framework {0}+++++++{1}++++{2}.", new object[3] { 1, 2, Version.GameFrameworkVersion.ToString() });
        Debug.Log(a);
        Log.Info("a");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
