using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainScene : MonoBehaviour
{
    [SerializeField] private GameObject checkZone;
    [SerializeField] private GameObject depositZone;
    [SerializeField] private GameObject withdrawZone;
    [SerializeField] public GameObject alert;

    private void Start()
    {
        // 화면 초기화
        Init();
    }

    // 화면 초기화
    private void Init()
    {
        // 입출금, 알림창 비활성화
        depositZone.SetActive(false);
        withdrawZone.SetActive(false);
        alert.SetActive(false);
        // 현금 초기화
        Money.Instance.cash = 100000;
        Money.Instance.cashTxt.text = Money.Instance.cash.ToString("N0");
        // 잔액 초기화
        Money.Instance.balance = 50000;
        Money.Instance.balanceTxt.text = Money.Instance.balance.ToString("N0");
    }

    // 입금창 활성화
    public void LoadDeoisitZone()
    {
        depositZone.SetActive(true);
        checkZone.SetActive(false);
    }

    // 출금창 활성화
    public void LoadWithdrawZone()
    {
        withdrawZone.SetActive(true);
        checkZone.SetActive(false);
    }

    // 뒤로 가기
    public void LoadCheckZone()
    {
        checkZone.SetActive(true);
        depositZone.SetActive(false);
        withdrawZone.SetActive(false);
    }
}
