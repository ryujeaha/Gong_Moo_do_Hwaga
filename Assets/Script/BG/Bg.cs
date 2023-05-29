using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bg : MonoBehaviour
{
    private MeshRenderer mesh;

    public float ofset;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        mesh = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        ofset += Time.deltaTime * speed;
        mesh.material.mainTextureOffset = new Vector2(ofset, 0);
    }
}
