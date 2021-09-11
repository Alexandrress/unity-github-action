using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingSphere : MonoBehaviour
{
    [SerializeField]
    private GameObject sphere;
    private Vector3 sphereStartPosition;

    // Start is called before the first frame update
    void Start()
    {
        sphereStartPosition = sphere.transform.position;
        StartCoroutine(teleportBackToTheTop());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator teleportBackToTheTop()
    {
        while (true)
        {
            yield return new WaitForSeconds(4.0f);
            sphere.transform.position = sphereStartPosition;
        }
    }
}
