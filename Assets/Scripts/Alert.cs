using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alert : MonoBehaviour
{
    [SerializeField] private GameObject okBtn;

    public void OnClickOK()
    {
        gameObject.SetActive(false);
    }
}
