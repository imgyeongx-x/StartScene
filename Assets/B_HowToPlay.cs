using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class B_HowToPlay : MonoBehaviour
{  
    public void SceneChange(){
        SceneManager.LoadScene("Description");
    }
}
