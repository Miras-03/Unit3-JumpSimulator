using System.Collections;
using UnityEngine;

public sealed class MoveLeft : MonoBehaviour, IDeathObserver
{
    private Coroutine coroutine;
    [SerializeField] private int speed = 10;

    private void OnEnable() => StartCoroutine(Move());

    private IEnumerator Move()
    {
        while (true)
        {
            yield return new WaitForFixedUpdate();
            transform.Translate(Vector3.left * speed * Time.fixedDeltaTime);
        }
    }

    public void ExecuteDeath() => StopCoroutine(coroutine);
}