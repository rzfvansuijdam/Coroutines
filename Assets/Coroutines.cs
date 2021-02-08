using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coroutines : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Coroutine());
    }

    public IEnumerator Coroutine()
    {
        print("Ik start nu de coroutine ");
        yield return new WaitForSeconds(.5f);
        print("coroutine update ");
        yield return new WaitForSeconds(.5f);
        print("coroutine einde ");
        yield return null;

    }
}