using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CollManager : MonoBehaviour
{
    public Text talkText;
    public GameObject TalkPanel;

    public Player player;
    public TalkManager talk;
    public int TalkIndex;
    private void OnTriggerStay2D(Collider2D collision)
    {
        bool isNpc = collision.gameObject.GetComponent<Obj_Data>().isNpc;

        if (isNpc == true && Input.GetKeyDown(KeyCode.Space))
        {
            Obj_Data obj = collision.gameObject.GetComponent<Obj_Data>();
            Talk(obj.id, obj.isNpc);
            TalkPanel.SetActive(true);
        }
    }

    void Talk(int id,bool isNpc)
    {
        string talkdata = talk.GetTalk(id, TalkIndex);
        if (isNpc)
        {
            talkText.text = talkdata;   
        }
        else
        {
            talkText.text = talkdata;
        }

    }
}
