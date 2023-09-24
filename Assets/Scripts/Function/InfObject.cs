using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Rendering;

public class InfObject : MonoBehaviour
{
    public SphereST sphereST;

    public string nome;
    public string descricao;
    public MeshRenderer material;

    void Start()
    {
        nome = sphereST.nome;
        descricao = sphereST.descricao;

        material = GetComponent<MeshRenderer>();
        material.material = sphereST.material;


    }
}
