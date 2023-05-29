using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CollManager : MonoBehaviour
{
    public Player player;

    private void Start()
    {
        player.Talk(101, true);
        player.TalkPanel.SetActive(true);
    }

}
