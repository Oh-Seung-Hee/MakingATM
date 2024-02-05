using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class Deposit : MonoBehaviour
{
    [SerializeField] public GameObject alert;
    [SerializeField] private TMP_InputField inputField;

    // 버튼으로 입금
    public void DepositCashBtn()
    {
        // 선택한 버튼 이름 받기
        string btnName = EventSystem.current.currentSelectedGameObject.name;
        // 선택한 버튼 숫자 외 다른 정보 제거
        btnName = btnName.Replace(",", "");
        btnName = btnName.Replace("Btn", "");

        if (Money.Instance.cash >= int.Parse(btnName))
        {
            Money.Instance.cash -= int.Parse(btnName);
            Money.Instance.balance += int.Parse(btnName);
        }
        else
        {
            alert.SetActive(true);
        }
    }

    // 직접 입력으로 입금
    public void DepositCashInput()
    {
        if (Money.Instance.cash >= int.Parse(inputField.text))
        {
            Money.Instance.cash -= int.Parse(inputField.text);
            Money.Instance.balance += int.Parse(inputField.text);
        }
        else
        {
            alert.SetActive(true);
        }
    }
}
