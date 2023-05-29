using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Player : MonoBehaviour
{

    public Text talkText;
    public GameObject TalkPanel;

    public TalkManager talk;
    public int TalkIndex;

    public bool isAction;
    public bool stop;
    public bool Action_more;
    Vector3 ray;

   
   
    public GameObject Target;
    public Rigidbody2D myrigid;
    public float Movespeed = 2;
    // Update is called once per frame
    void Move()
    {
        if (!stop)
        {
            if (Input.GetAxisRaw("Horizontal") > 0)
            {
                gameObject.transform.localScale = new Vector2(0.8f, 0.8f);
                float dirX = Input.GetAxisRaw("Horizontal") * Time.deltaTime * Movespeed;
                this.gameObject.transform.Translate(dirX, 0, 0);//받은 값에다가 속도와 시간을 곱한만큼  더해서 이동시켜준다
                ray = new Vector3(1, 0, 1);
            }
            else if (Input.GetAxisRaw("Horizontal") == 0)
            {
                ray = new Vector3(1, 0, 1);
            }
            else if (Input.GetAxisRaw("Horizontal") < 0)
            {
                gameObject.transform.localScale = new Vector2(-0.8f, 0.8f);
                float dirX = Input.GetAxisRaw("Horizontal") * Time.deltaTime * Movespeed;
                this.gameObject.transform.Translate(dirX, 0, 0);//받은 값에다가 속도와 시간을 곱한만큼  더해서 이동시켜준다
                ray = new Vector3(-1, 0, 1);
            }
        }
        else//못움직이는 경우
        {
            ray = new Vector3(1, 0, 1);
        }
    }

    private void Update()
    {
        Debug.DrawRay(myrigid.position,ray * 2.5f, new Color(0, 1, 0));
        RaycastHit2D rayhit = Physics2D.Raycast(myrigid.position, ray,2.5f,LayerMask.GetMask("NPC"));

        if(rayhit.collider != null)
        {
            Target = rayhit.collider.gameObject;
            bool isNpc = Target.gameObject.GetComponent<Obj_Data>().isNpc;
           
            if (isNpc == true && Input.GetKeyDown(KeyCode.Space))
            {
                Action(Target);
            }
        }
        else
        {
            Target = null;
        }
        Move();
    }
    public void Action(GameObject collision)
    {
        Obj_Data obj = collision.gameObject.GetComponent<Obj_Data>();
        Talk(obj.id, obj.isNpc);
        TalkPanel.SetActive(isAction);
    }
    public void Talk(int id, bool isNpc)
    {
        string talkdata = talk.GetTalk(id, TalkIndex);

        if (talkdata == null)
        {
            isAction = false;
            TalkIndex = 0;
            Scene_Move(id);
            return;//대화가 끝나면 대화창을 꺼주고 함수 강제종료로 트루까지 안내려가게함'
            
        }
       else if (isNpc)
        {
           StartCoroutine(Typing(talkText, talkdata, 0.1f));
            //talkText.text = talkdata;
        }
        else
        {
           StartCoroutine(Typing(talkText, talkdata, 0.1f));
            //talkText.text = talkdata;
        }
        
        if (isAction == true)
        {
            TalkIndex = TalkIndex+1;
        }
    }
    IEnumerator Typing(Text typingText, string message, float speed)
    {
        for (int i = 1; i <= message.Length; i++)
        {
            typingText.text = message.Substring(0, i);
            yield return new WaitForSeconds(speed);
        }
        isAction = true;
    }

    void Scene_Move(int id)
    {
        if (id == 100)//방금 끝난 대화가 할아버지와의 대화라면
        {
            SceneManager.LoadScene("scene2");
        }
       else if (id == 102)//방금 끝난 대화가 할아버지와의 대화라면
        {
            SceneManager.LoadScene("scene3");
        }
       else if (id == 103)//방금 끝난 대화가 할아버지와의 대화라면
        {
            SceneManager.LoadScene("scene4");
        }
        else if (id == 104)//방금 끝난 대화가 할아버지와의 대화라면
        {
            SceneManager.LoadScene("scene5");
        }
        else if (id == 105)//방금 끝난 대화가 할아버지와의 대화라면
        {
            SceneManager.LoadScene("scene6");
        }
        else if (id == 106)//방금 끝난 대화가 할아버지와의 대화라면
        {
            SceneManager.LoadScene("scene7");
        }
        else if (id == 107)//방금 끝난 대화가 할아버지와의 대화라면
        {
            SceneManager.LoadScene("scene8");
        }
        else if (id == 109)//방금 끝난 대화가 할아버지와의 대화라면
        {
            SceneManager.LoadScene("scene9");
        }
    }
}
