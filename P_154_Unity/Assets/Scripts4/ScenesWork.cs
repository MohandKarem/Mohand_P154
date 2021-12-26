using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesWork : MonoBehaviour
{
  public int index;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))      
      {
         SceneLoaderName();
      }

         if (Input.GetMouseButtonDown(1))      
      {
         SceneLoaderIndex();
      }

         if (Input.GetMouseButtonDown(2))      
      {
         SceneLoaderPublicIndex();
      }

    }    


    void SceneLoaderName()
     {
       SceneManager.LoadScene("level2");
       print("Loaded by NAME");
     }
    
    void SceneLoaderIndex()
     {
       SceneManager.LoadScene(1);
       print("Loaded by INDEX");
     }

    void SceneLoaderPublicIndex()
     {
       SceneManager.LoadScene(1);
       print("Loaded by PUBLIC INDEX");
     }

}
