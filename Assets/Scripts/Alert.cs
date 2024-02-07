using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alert : MonoBehaviour
{
    [SerializeField] private GameObject alert;
    [SerializeField] private GameObject okBtn;

    public void OnClickOK()
    {
        gameObject.SetActive(false);
    }

    public void EnableAlert()
    {
        alert.SetActive(true);
    }

    public void DisableAlert()
    {
        alert.SetActive(false);
    }
}
