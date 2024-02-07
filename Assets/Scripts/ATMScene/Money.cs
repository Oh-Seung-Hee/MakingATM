using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Money : MonoBehaviour
{
    public static Money Instance { get; private set; }

    [SerializeField] public TMP_Text cashTxt;
    [SerializeField] public TMP_Text balanceTxt;

    public int cash;
    public int balance;

    private void Awake()
    {
        // ΩÃ±€≈Ê
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Update()
    {
        cashTxt.text = cash.ToString("N0");
        balanceTxt.text = balance.ToString("N0");
    }
}
