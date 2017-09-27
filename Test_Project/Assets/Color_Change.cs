using UnityEngine;
using System.Collections;

public class Color_Change : MonoBehaviour {
    public Light lt;
    void Start() {
        lt = GetComponent<Light>();
    }
    void Update() {

    }

	void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Blue_PickUp"))
        lt.color -= Color.blue;
        Destroy(other.gameObject);
}
}