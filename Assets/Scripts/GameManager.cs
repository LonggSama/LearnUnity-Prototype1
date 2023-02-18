using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject _mainCamera;
    [SerializeField] GameObject _altCamera;
    [SerializeField] GameObject _single;
    [SerializeField] GameObject _player1;
    [SerializeField] GameObject _player2;
    [SerializeField] GameObject _player1Camera;
    [SerializeField] GameObject _player2Camera;
    [SerializeField] GameObject _alt1Camera;
    [SerializeField] GameObject _alt2Camera;

    private bool cameraActive;
    private bool camera1Active;
    private bool camera2Active;
    private bool playerCheck;
    // Update is called once per frame

    private void Start()
    {
        playerCheck = true;
        _single.SetActive(playerCheck);
        _player1.SetActive(!playerCheck);
        _player2.SetActive(!playerCheck);
        cameraActive = false;
        _altCamera.SetActive(cameraActive);
        _mainCamera.SetActive(!cameraActive);
    }
    void Update()
    {
        if (Input.GetKeyDown("v"))
        {
            cameraActive = !cameraActive;
            _mainCamera.SetActive(cameraActive);
            _altCamera.SetActive(!cameraActive);
        }

        if (Input.GetKeyDown("`"))
        {
            playerCheck = !playerCheck;
            _single.SetActive(playerCheck);
            _mainCamera.SetActive(playerCheck);
            _player1.SetActive(!playerCheck);
            _player2.SetActive(!playerCheck);
        }
        if (_single.activeSelf == false)
        {
            if (Input.GetKeyDown("1"))
            {
                camera1Active = !camera1Active;
                _player1Camera.SetActive(camera1Active);
                _alt1Camera.SetActive(!camera1Active);
            }

            if (Input.GetKeyDown("2"))
            {
                camera2Active = !camera2Active;
                _player2Camera.SetActive(camera2Active);
                _alt2Camera.SetActive(!camera2Active);
            }
        }
        
    }
}
