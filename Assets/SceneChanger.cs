using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class SceneChanger : MonoBehaviour
{
    public void loadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Back() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    private void OnSceneNext(InputValue value){
        Debug.Log("Scene Next" + value.Get<float>());
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    private void OnSceneBack(InputValue value){
        Debug.Log("Scene Back" + value.Get<float>());
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
