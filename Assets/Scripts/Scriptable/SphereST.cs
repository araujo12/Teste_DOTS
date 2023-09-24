using System.Collections;
using System.Collections.Generic;
using Unity.Rendering;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "New Sphere", menuName = "Personalizado/Sphere")]
public class SphereST : ScriptableObject
{
    public string nome;
    public string descricao;

    public Material material;
}
