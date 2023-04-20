using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour
{
    Animator anim;
    public TalkManager talkManager;
    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    public float Movespeed = 2;
    // Update is called once per frame
    void Update()
    {
        Move();
    }
    void Move()
    {
        if (Input.GetAxisRaw("Horizontal") > 0)
        {
            gameObject.transform.localScale = new Vector2(0.8f, 1);
            float dirX = Input.GetAxisRaw("Horizontal") * Time.deltaTime * Movespeed;
            this.gameObject.transform.Translate(dirX, 0, 0);//���� �����ٰ� �ӵ��� �ð��� ���Ѹ�ŭ  ���ؼ� �̵������ش�
            anim.SetBool("Is_right_Walk", true);
            anim.SetBool("Is_Left_Walk", false);
        }
        else if (Input.GetAxisRaw("Horizontal") == 0)
        {
            anim.SetBool("Is_right_Walk", false);
            anim.SetBool("Is_Left_Walk", false);
        }
        else if (Input.GetAxisRaw("Horizontal") < 0)
        {
            gameObject.transform.localScale = new Vector2(-0.8f, 1);
            float dirX = Input.GetAxisRaw("Horizontal") * Time.deltaTime * Movespeed;
            this.gameObject.transform.Translate(dirX, 0, 0);//���� �����ٰ� �ӵ��� �ð��� ���Ѹ�ŭ  ���ؼ� �̵������ش�
            anim.SetBool("Is_Left_Walk", true);
            anim.SetBool("Is_right_Walk", false);
        }
    }

}
