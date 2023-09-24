using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DisplayInfo : MonoBehaviour
{
    public SphereST sphereST;

    public TextMeshProUGUI nameText;
    public TextMeshProUGUI descriptionText;
    void Start()
    {
        nameText.text = sphereST.nome;
        descriptionText.text = sphereST.descricao;
    }

}
