using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TalkManager : MonoBehaviour
{
    Dictionary<int,string[]> talk_data;//딕셔너리 키하고 연결되있는 벨류를 저장 타입을 꼭 두개 써줘야함.


    // Start is called before the first frame update
    void Awake()
    {
        talk_data = new Dictionary<int, string[]>();
        GenerateData();
    }

    void GenerateData()
    {
        talk_data.Add(100, new string[] { "안녕 이것은 테스트란다 승연아" });
    }

    public string GetTalk(int id,int TalkIndex)//아이디와 몇번쨰 인덱스의 문자를 가져올것인지 지정하기위한 매개변수
    {
        return talk_data[id][TalkIndex];
    }
}
