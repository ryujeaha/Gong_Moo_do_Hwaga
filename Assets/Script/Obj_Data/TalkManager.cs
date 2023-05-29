using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TalkManager : MonoBehaviour
{
  public  Dictionary<int,string[]> talk_data;//딕셔너리 키하고 연결되있는 벨류를 저장 타입을 꼭 두개 써줘야함.


    // Start is called before the first frame update
    void Awake()
    {
        talk_data = new Dictionary<int, string[]>();
        GenerateData();
    }

    void GenerateData()
    {
        talk_data.Add(100, new string[] { "허허허","어서오려무나~","우리 성연이 오늘도 할아버지한테 옛날이야기 들으러 왔나보구나~","그럼 오늘은 이 할아버지가","재미있는 공무도하가 얘기를 해주겠단다.","허허허.."});
        talk_data.Add(101, new string[] { "옛날옛날 아주 오랜옛날에 곽리자고라는 뱃장수가 있었단다." });
    }

    public string GetTalk(int id,int TalkIndex)//아이디와 몇번쨰 인덱스의 문자를 가져올것인지 지정하기위한 매개변수
    {
        if(TalkIndex == talk_data[id].Length)
        {
            return null;//대화가 끝났을경우 대화를 끝내준다다
        }
        else//대화가 아직 끝나지 않아 다음대화를 출력해야할경우
        {
            return talk_data[id][TalkIndex];
        }
        
    }
}
