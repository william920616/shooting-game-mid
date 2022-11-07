using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // 添加這行載入場景管理類別

public class NextSceneBtn : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {

    }

    // 當碰撞(Trigger)發生時
    private void OnTriggerEnter(Collider other)
    {
        // 切換場景到 Level2
        SceneManager.LoadScene("Level2");
    }
}