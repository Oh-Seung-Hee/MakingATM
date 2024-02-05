using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class Withdraw : MonoBehaviour
{
    [SerializeField] public GameObject alert;
    [SerializeField] private TMP_InputField inputField;

    // ��ư���� ���
    public void WithdrawCashBtn()
    {
        // ������ ��ư �̸� �ޱ�
        string btnName = EventSystem.current.currentSelectedGameObject.name;
        // ������ ��ư ���� �� �ٸ� ���� ����
        btnName = btnName.Replace(",", "");
        btnName = btnName.Replace("Btn", "");

        if (Money.Instance.balance >= int.Parse(btnName))
        {
            Money.Instance.cash += int.Parse(btnName);
            Money.Instance.balance -= int.Parse(btnName);
        }
        else
        {
            alert.SetActive(true);
        }
    }

    // ���� �Է����� �Ա�
    public void WithdrawCashInput()
    {
        if (Money.Instance.balance >= int.Parse(inputField.text))
        {
            Money.Instance.cash += int.Parse(inputField.text);
            Money.Instance.balance -= int.Parse(inputField.text);
        }
        else
        {
            alert.SetActive(true);
        }
    }
}
