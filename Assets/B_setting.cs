using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class B_setting : MonoBehaviour
{

    public void SceneChange(){
        SceneManager.LoadScene("Settings");
    }

}
