using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cysharp.Threading.Tasks;
using System;
using System.Threading;

public class AppearEnemy : MonoBehaviour
{
    [SerializeField] GameObject EnemyKunai1;

    int AppearTime = 1;
    float DisapearTime = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        

        //CancellationToken取得
        var cancellationToken = this.GetCancellationTokenOnDestroy();

        //特定のパターンでオブジェクトのON・OFF
        EnemyPatern(cancellationToken).Forget();

        
    }

    async UniTaskVoid EnemyPatern(CancellationToken token)
    {
        await UniTask.Delay(TimeSpan.FromSeconds(1.0f), cancellationToken: token);
        await AppearEnemyStart(token);
        await UniTask.Delay(TimeSpan.FromSeconds(5.0f),cancellationToken: token);
        await DisapearEnemyStart(token);
    }

    async UniTask AppearEnemyStart(CancellationToken token)
    {
        EnemyKunai1.SetActive(true);
        await UniTask.Yield(PlayerLoopTiming.Update, token);
    }

    async UniTask DisapearEnemyStart(CancellationToken token)
    {
        EnemyKunai1.SetActive(false);
        await UniTask.Yield(PlayerLoopTiming.Update, token);
    }
}
