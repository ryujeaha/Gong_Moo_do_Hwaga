using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TalkManager : MonoBehaviour
{
    Dictionary<int,string[]> talk_data;//��ųʸ� Ű�ϰ� ������ִ� ������ ���� Ÿ���� �� �ΰ� �������.


    // Start is called before the first frame update
    void Awake()
    {
        talk_data = new Dictionary<int, string[]>();
        GenerateData();
    }

    void GenerateData()
    {
        talk_data.Add(100, new string[] { "�ȳ� �̰��� �׽�Ʈ���� �¿���" });
    }

    public string GetTalk(int id,int TalkIndex)//���̵�� ����� �ε����� ���ڸ� �����ð����� �����ϱ����� �Ű�����
    {
        return talk_data[id][TalkIndex];
    }
}
