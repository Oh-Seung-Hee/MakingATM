using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainScene : MonoBehaviour
{
    [SerializeField] private GameObject checkZone;
    [SerializeField] private GameObject depositZone;
    [SerializeField] private GameObject withdrawZone;
    private Alert alertScript;

    private void Awake()
    {
        alertScript = GameObject.Find("Alert").GetComponent<Alert>();
    }

    private void Start()
    {
        // ȭ�� �ʱ�ȭ
        Init();
    }

    // ȭ�� �ʱ�ȭ
    private void Init()
    {
        // �����, �˸�â ��Ȱ��ȭ
        depositZone.SetActive(false);
        withdrawZone.SetActive(false);
        alertScript.DisableAlert();
        // ���� �ʱ�ȭ
        Money.Instance.cash = 100000;
        Money.Instance.cashTxt.text = Money.Instance.cash.ToString("N0");
        // �ܾ� �ʱ�ȭ
        Money.Instance.balance = 50000;
        Money.Instance.balanceTxt.text = Money.Instance.balance.ToString("N0");
    }

    // �Ա�â Ȱ��ȭ
    public void LoadDeoisitZone()
    {
        depositZone.SetActive(true);
        checkZone.SetActive(false);
    }

    // ���â Ȱ��ȭ
    public void LoadWithdrawZone()
    {
        withdrawZone.SetActive(true);
        checkZone.SetActive(false);
    }

    // �ڷ� ����
    public void LoadCheckZone()
    {
        checkZone.SetActive(true);
        depositZone.SetActive(false);
        withdrawZone.SetActive(false);
    }
}
