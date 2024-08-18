using System.Collections;
using UnityEngine;

public class Cube : MonoBehaviour
{
    private IEnumerator Start()
    {
        while (true)
        {
            transform.position += new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), 0f).normalized * 4f * Time.deltaTime;

            yield return null;
        }
    }
}
