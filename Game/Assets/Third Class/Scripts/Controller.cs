using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public Vector3 direction;
    public float speed = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        //  transform.position : ���� ������Ʈ�� ���� ��ġ�� �ǹ��մϴ�.
        Debug.Log(transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        direction.x = Input.GetAxisRaw("Horizontal");
        direction.z = Input.GetAxisRaw("Vertical");

        //  ������ ����ȭ
        direction.Normalize();

        // Time.deltaTime : ������ �� �̵������� �ð� ����
        transform.position = transform.position + direction * speed * Time.deltaTime;
    }
}
