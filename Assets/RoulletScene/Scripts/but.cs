using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class but : MonoBehaviour
{
    public void back()
    {
        SceneManager.LoadScene(0);
    }
}
