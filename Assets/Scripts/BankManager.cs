using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BankManager : MonoBehaviour
{
    static BankManager s_instance;
    public static BankManager Instance {  get { Init(); return s_instance; } }

    // Start is called before the first frame update
    void Start()
    {
        Init();   
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    static void Init()
    {
        if(s_instance == null)
        {
            GameObject go = GameObject.Find("BankManager");
            if(go == null)
            {
                go = new GameObject { name = "BankManager" };
                go.AddComponent<BankManager>();


                DontDestroyOnLoad(go);
                s_instance = go.GetComponent<BankManager>();
            }

        }
    }

}
