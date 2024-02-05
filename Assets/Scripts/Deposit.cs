using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class Deposit : MonoBehaviour
{
    [SerializeField] public GameObject alert;
    [SerializeField] private TMP_InputField inputField;

    // ��ư���� �Ա�
    public void DepositCashBtn()
    {
        // ������ ��ư �̸� �ޱ�
        string btnName = EventSystem.current.currentSelectedGameObject.name;
        // ������ ��ư ���� �� �ٸ� ���� ����
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

    // ���� �Է����� �Ա�
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
