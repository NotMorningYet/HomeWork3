
using UnityEngine;

public abstract class Coin : MonoBehaviour
{
    private float RotateSpeed = 50f;

    void Update()
    {
        rotateCoin();
    }

    private void rotateCoin()
    {
        transform.Rotate(new Vector3(0f,  RotateSpeed * Time.deltaTime, 0f));
    }

}
