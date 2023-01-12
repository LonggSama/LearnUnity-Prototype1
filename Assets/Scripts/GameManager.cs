using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject _mainCamera;
    [SerializeField] GameObject _altCamera;
    private bool cameraActive;
    // Update is called once per frame

    private void Start()
    {
        cameraActive = true;
        _altCamera.SetActive(false);
        _mainCamera.SetActive(true);
    }
    void Update()
    {
        if (Input.GetKeyDown("v"))
        {
            cameraActive = !cameraActive;
            _mainCamera.SetActive(cameraActive);
            _altCamera.SetActive(!cameraActive);
        }
    }
}
