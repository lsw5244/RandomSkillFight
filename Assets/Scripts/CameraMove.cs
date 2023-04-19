using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed = 1f;
    int screenWidth = Screen.width;
    int screenHeight = Screen.height;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked; /* 마우스 위치를 중앙에서 벗어나지 못하도록 잠궈줍니다. */
        Cursor.lockState = CursorLockMode.Confined; /* 게임 창 밖으로 나가는 것을 막아줍니다. */
        Cursor.lockState = CursorLockMode.None; /* 마우스 커서의 제한을 풀어줍니다. (기본 옵션) */

        Debug.Log($"screenWidth : {screenWidth}");
        Debug.Log($"screenHeight : {screenHeight}");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            Debug.Log($"마우스의 위치는 {Input.mousePosition}");
        }

        if(Input.mousePosition.x >= screenWidth)
        {
            transform.Translate(moveSpeed * Time.deltaTime, 0, 0, Space.World);
        }

        if (Input.mousePosition.x <= 0)
        {
            transform.Translate(-moveSpeed * Time.deltaTime, 0, 0, Space.World);
        }

        if (Input.mousePosition.y >= screenHeight)
        {
            transform.Translate(0, 0, moveSpeed * Time.deltaTime, Space.World);
        }
        
        if (Input.mousePosition.y <= 0)
        {
            transform.Translate(0, 0, -moveSpeed * Time.deltaTime, Space.World);
        }
    }
}
