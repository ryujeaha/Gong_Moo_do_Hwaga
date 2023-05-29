using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TalkManager : MonoBehaviour
{
  public  Dictionary<int,string[]> talk_data;//��ųʸ� Ű�ϰ� ������ִ� ������ ���� Ÿ���� �� �ΰ� �������.


    // Start is called before the first frame update
    void Awake()
    {
        talk_data = new Dictionary<int, string[]>();
        GenerateData();
    }

    void GenerateData()
    {
        talk_data.Add(100, new string[] { "������","���������~","�츮 ������ ���õ� �Ҿƹ������� �����̾߱� ������ �Գ�������~","�׷� ������ �� �Ҿƹ�����","����ִ� �������ϰ� ��⸦ ���ְڴܴ�.","������.."});
        talk_data.Add(101, new string[] { "�������� ���� ���������� �����ڰ��� ������� �־��ܴ�." });
    }

    public string GetTalk(int id,int TalkIndex)//���̵�� ����� �ε����� ���ڸ� �����ð����� �����ϱ����� �Ű�����
    {
        if(TalkIndex == talk_data[id].Length)
        {
            return null;//��ȭ�� ��������� ��ȭ�� �����شٴ�
        }
        else//��ȭ�� ���� ������ �ʾ� ������ȭ�� ����ؾ��Ұ��
        {
            return talk_data[id][TalkIndex];
        }
        
    }
}
