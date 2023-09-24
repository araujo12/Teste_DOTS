using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Mathematics;
using Unity.Jobs;
using Unity.Collections;
using Unity.Burst;
using UnityEngine.UI;
using TMPro;

public class CalculoPesado : MonoBehaviour
{
    public float calcs;
    public bool jobsOn;

    public float mainThread, paralelo;
    public string mainThreadText, paraleloText;
    public TextMeshProUGUI mainThreadUI, paralelaUI;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        /*if(jobsOn)
        {
            Calculospesados();
        }
        else
        {
            HardTask();
        }*/
        Calculospesados();
        HardTask();

    }

    void Calculospesados()
    {
        float startTime = Time.realtimeSinceStartup;

        NativeArray<JobHandle> jobList = new NativeArray<JobHandle>(10, Allocator.TempJob);

        for (int j = 0; j < 10; j++)
        {
            var job = new CalculosPesadosJob
            {
                calcs = calcs
            };

            jobList[j] = job.Schedule();
        }

        JobHandle.CompleteAll(jobList);

        jobList.Dispose();

        //Debug.Log(((Time.realtimeSinceStartup - startTime) * 1000f) + "ms");
        paralelo = (Time.realtimeSinceStartup - startTime) * 1000f;
        paraleloText = paralelo.ToString();
        paralelaUI.text = paraleloText + " ms.";

    }

    void HardTask()
    {
        float startTime = Time.realtimeSinceStartup;

        for (int j = 0; j < 10; j++)
        {

            float value = 0;

            for (int i = 0; i < calcs; i++)
            {
                value = math.exp10(math.sqrt(value));
            }
        }

        //Debug.Log(((Time.realtimeSinceStartup - startTime) * 1000f) + "ms");
        mainThread = (Time.realtimeSinceStartup - startTime) * 1000f;
        mainThreadText = mainThread.ToString();
        mainThreadUI.text = mainThreadText + " ms.";

    }
}

[BurstCompile]
public struct CalculosPesadosJob : IJob
{
    public float calcs;
    public void Execute()
    {
        float value = 0;

        for (int i = 0; i < calcs; i++)
        {
            value = math.exp10(math.sqrt(value));
        }
    }
}
