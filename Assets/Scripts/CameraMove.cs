using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed = 10f;
    [SerializeField]
    private float zoomSpeed = 2000f;

    int screenWidth = Screen.width;
    int screenHeight = Screen.height;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked; /* ���콺 ��ġ�� �߾ӿ��� ����� ���ϵ��� ����ݴϴ�. */
        Cursor.lockState = CursorLockMode.Confined; /* ���� â ������ ������ ���� �����ݴϴ�. */
        Cursor.lockState = CursorLockMode.None; /* ���콺 Ŀ���� ������ Ǯ���ݴϴ�. (�⺻ �ɼ�) */

        Debug.Log($"screenWidth : {screenWidth}");
        Debug.Log($"screenHeight : {screenHeight}");
    }

    // Update is called once per frame
    void Update()
    {
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

        float scrollWheel = Input.GetAxis("Mouse ScrollWheel");
        Debug.Log(scrollWheel);

        //if(scrollWheel != 0f)
        //{
        //    transform.Translate(0, 0, scrollWheel * zoomSpeed * Time.deltaTime, Space.Self);
        //}
        if (scrollWheel > 0f)
        {
            //++
            transform.Translate(0, 0, zoomSpeed * Time.deltaTime, Space.Self);
        }
        else if (scrollWheel < 0f)
        {
            //--
            transform.Translate(0, 0, -zoomSpeed * Time.deltaTime, Space.Self);
        }
    }
}
