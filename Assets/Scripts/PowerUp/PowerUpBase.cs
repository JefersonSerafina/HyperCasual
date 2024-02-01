using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class PowerUpBase : ItemCollactableBase
{
    [Header("Power Up")]
    public float duration;
    protected override void OnCollect()
    {
        base.OnCollect();
        StartPowerUp();
        PlayerController.Instance.transform.DOScale(0.7f, 0.05f).SetEase(Ease.OutBack).SetLoops(2, LoopType.Yoyo);
    }
    protected virtual void StartPowerUp()
    {
        Debug.Log("Start Power Up");
        Invoke(nameof(EndPowerUp), duration);
    }
    protected virtual void EndPowerUp()
    {
        Debug.Log("End Power Up");
    }

}
