using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class ChargeBar : MonoBehaviour
{
    Slider chargeBar;
    private int gaugeType; //1. 상호작용(Bool값 리턴) 2. 스킬(단순 게이지 표시)
    private float minValue;
    private float maxValue;
    private float timer;
    private TextMeshProUGUI renderText;
    GameObject barUi;
    // Start is called before the first frame update
    void Start()
    {
        barUi = GameObject.Find("ChargeBar");
        chargeBar.value = 0;
        minValue = 0f;
        timer = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        UpdateGauge();
    }

    public void SetValue(int gaugeTypeNum, float getMaxValue, string text)
    {
        gaugeType = gaugeTypeNum;
        maxValue = getMaxValue;
        renderText.text = text;
        barUi.SetActive(true);
    }

    private void UpdateGauge()
    {
        timer += Time.deltaTime;
        chargeBar.value = Mathf.Lerp(timer, maxValue, Time.time);
    }

}
