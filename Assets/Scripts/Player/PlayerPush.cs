using UnityEngine;

public class PlayerPush : MonoBehaviour
{
    public float pushForce = 10f;

    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        Rigidbody rb = hit.collider.attachedRigidbody;

        if (rb == null || rb.isKinematic) return;

        //comprobar si es una puerta empujable
        Door door = hit.collider.GetComponent<Door>();
        if (door != null && !door.canBePushed) return;

        Vector3 pushDir = new Vector3(hit.moveDirection.x, 0, hit.moveDirection.z);

        if (pushDir.magnitude < 0.1f) return;

        rb.AddForce(pushDir * pushForce, ForceMode.Force);
    }
}