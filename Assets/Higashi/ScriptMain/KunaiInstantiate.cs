using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Threading;
using Cysharp.Threading.Tasks;

public class KunaiInstantiate : MonoBehaviour
{
    [SerializeField] GameObject Kunai;
    float fai = 25;
    float KunaiReleaseTiming = 0.1f;
    // Start is called before the first frame update
    void Start()
    { 
        //特定のパターンでオブジェクトを移動させる

        var calcellationToken = this.GetCancellationTokenOnDestroy();
        KunaiFiveWay(calcellationToken).Forget();

    }


    private async UniTaskVoid KunaiFiveWay(CancellationToken token)
    {
        var TimingToken = this.GetCancellationTokenOnDestroy();


        await UniTask.Delay(TimeSpan.FromSeconds(1f), cancellationToken: token);
        Instantiate(Kunai, transform.position, transform.rotation * Quaternion.Euler(1 * fai, 0, 0));
        await UniTask.Delay(TimeSpan.FromSeconds(KunaiReleaseTiming), cancellationToken: token);
        Instantiate(Kunai, transform.position, transform.rotation * Quaternion.Euler(2 * fai, 0, 0));
        await UniTask.Delay(TimeSpan.FromSeconds(KunaiReleaseTiming), cancellationToken: token);
        Instantiate(Kunai, transform.position, transform.rotation * Quaternion.Euler(3 * fai, 0, 0));
        await UniTask.Delay(TimeSpan.FromSeconds(KunaiReleaseTiming), cancellationToken: token);
        Instantiate(Kunai, transform.position, transform.rotation * Quaternion.Euler(4 * fai, 0, 0));
        await UniTask.Delay(TimeSpan.FromSeconds(KunaiReleaseTiming), cancellationToken: token);
        Instantiate(Kunai, transform.position, transform.rotation * Quaternion.Euler(5 * fai, 0, 0));
    }

}
