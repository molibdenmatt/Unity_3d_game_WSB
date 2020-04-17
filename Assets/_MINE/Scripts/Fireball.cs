using UnityEngine;
using System.Collections;

public class Fireball : MonoBehaviour
{
    public float speed = 7.0f;
    public int damage = 1;
    void Update()
    {
        transform.Translate(0, 0, speed * Time.deltaTime);
        StartCoroutine(Expire());

    }
    void OnTriggerEnter(Collider other)
    {
        DaneGracza player =
        other.GetComponent<DaneGracza>();
        if (player != null)
        {
            Debug.Log("Player hit");
        }
        Destroy(this.gameObject);
    }

    private IEnumerator Expire()
    {
        yield return new WaitForSeconds(1.0f);
        Destroy(this.gameObject);
    }
}