using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Observable;
public class HpBar : MonoBehaviour
{
    public Image bar;

    public int HpMax = 10;
    private void Awake()
    {
        bar = GetComponent<Image>();

        Observable.PlayerController playerController = FindObjectOfType<Observable.PlayerController>();
        playerController.Hp.OnChange += (int hp) =>
        {
            bar.fillAmount = Mathf.Clamp01(((float)hp / (float)HpMax));
        };
    }
}
