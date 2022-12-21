using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCollor : MonoBehaviour {

    public Transform pivot; // the object being followed
    public Vector3 pivotOffset = Vector3.zero; // offset from target's pivot
    public Transform target; // like a selected object (used with checking if objects between cam and target)

    public float distance = 10.0f; // distance from target (used with zoom)
    public float minDistance = 2f;
    public float maxDistance = 15f;
    public float zoomSpeed = 1f;
    public float TargetBodyRotateLerp = 0.3f;
    private Vector3 offset;

    public float xSpeed = 250.0f;
    public float ySpeed = 120.0f;

    public bool allowYTilt = true;
    public float yMinLimit = 30f;
    public float yMaxLimit = 80f;

    private float x = 0.0f;
    private float y = 0.0f;

    private float targetX = 0f;
    private float targetY = 0f;
    private float targetDistance = 0f;
    private float xVelocity = 1f;
    private float yVelocity = 1f;
    private float zoomVelocity = 1f;
    private Vector3 PredictCameraPosition;
    private Vector3 wallHit;

    void Start()
    {
       
        var angles = transform.eulerAngles;
        targetX = x = angles.x;
        targetY = y = ClampAngle(angles.y, yMinLimit, yMaxLimit);
        targetDistance = distance;
 
    }

    void Update()
    {
        target = GameObject.FindGameObjectWithTag("Playerzt").transform;
        pivot = GameObject.FindGameObjectWithTag("playerHit").transform;
    }
    bool Inwall()
    {

        RaycastHit hit;
        LayerMask mask = (1 << LayerMask.NameToLayer("Player")) | (1 << LayerMask.NameToLayer("Ignore Raycast")) | (1 << LayerMask.NameToLayer("Mob")) | (1 << LayerMask.NameToLayer("Weapon")); 
        mask = ~mask;
           Debug.DrawLine(pivot.transform.position, transform.position - transform.forward, Color.red);

        PredictCameraPosition = pivot.transform.position + offset.normalized * distance;
        if (Physics.Linecast(pivot.transform.position, PredictCameraPosition, out hit, mask))
        {
            

            wallHit = hit.point;
            Debug.DrawLine(transform.position, wallHit, Color.green);
            return true;
        }
        else
        {
            return false;
        }
    }
   
        void LateUpdate()
    {
        FreeCamera();

        if (Inwall())
        {
           

            transform.position = pivot.transform.position + (wallHit - pivot.transform.position) * 0.8f;

            return;


        }
        else
        {
            if (pivot)
            {
              
                targetDistance = Mathf.Clamp(targetDistance, minDistance, maxDistance);



                targetX += ETCInput.GetAxis("H") * xSpeed * 0.02f;
                if (allowYTilt)
                {
                    targetY -= ETCInput.GetAxis("V") * ySpeed * 0.02f;
                    targetY = ClampAngle(targetY, yMinLimit, yMaxLimit);
                }

                x = Mathf.SmoothDampAngle(x, targetX, ref xVelocity, 0.3f);
                if (allowYTilt) y = Mathf.SmoothDampAngle(y, targetY, ref yVelocity, 0.3f);
                else y = targetY;
                Quaternion rotation = Quaternion.Euler(y, x, 0);
                distance = Mathf.SmoothDamp(distance, targetDistance, ref zoomVelocity, 0.5f);


                Vector3 position = rotation * new Vector3(0.0f, 0.0f, -distance) + pivot.position + pivotOffset;
                transform.rotation = rotation;
                transform.position = position;

            }
        }
    }

    private float ClampAngle(float angle, float min, float max)
    {
        if (angle < -360) angle += 360;
        if (angle > 360) angle -= 360;
        return Mathf.Clamp(angle, min, max);
    }

    void FreeCamera()
    {
        float H = ETCInput.GetAxis("HHH");
        float V = ETCInput.GetAxis("VVV");
        float H1 = ETCInput.GetAxis("HJN");
        float V1 = ETCInput.GetAxis("VJN");

        offset = offset.normalized * distance;
        offset = transform.position - pivot.transform.position;
        transform.position = pivot.transform.position + offset;

       
            Quaternion TargetBodyCurrentRotation = target.transform.rotation;

            if (H < 0||H1<0)
            {
                if (V > 0||V1>0)
                {
                target.transform.rotation = Quaternion.Lerp(TargetBodyCurrentRotation, Quaternion.Euler(new Vector3(target.transform.localEulerAngles.x, transform.localEulerAngles.y - 45, target.transform.localEulerAngles.z)), TargetBodyRotateLerp);
                }
                else if (V < 0||V1<0)
                {
                target.transform.rotation = Quaternion.Lerp(TargetBodyCurrentRotation, Quaternion.Euler(new Vector3(target.transform.localEulerAngles.x, transform.localEulerAngles.y - 135, target.transform.localEulerAngles.z)), TargetBodyRotateLerp);
                }


                else if (V == 0||V1==0)
                {
                target.transform.rotation = Quaternion.Lerp(TargetBodyCurrentRotation, Quaternion.Euler(new Vector3(target.transform.localEulerAngles.x, transform.localEulerAngles.y - 90, target.transform.localEulerAngles.z)), TargetBodyRotateLerp);
                }
            }
            else if (H > 0||H1>0)
            {
                if (V > 0||V1>0)
                {
                target.transform.rotation = Quaternion.Lerp(TargetBodyCurrentRotation, Quaternion.Euler(new Vector3(target.transform.localEulerAngles.x, transform.localEulerAngles.y + 45, target.transform.localEulerAngles.z)), TargetBodyRotateLerp);
                }
                else if (V < 0||V1<0)
                {
                target.transform.rotation = Quaternion.Lerp(TargetBodyCurrentRotation, Quaternion.Euler(new Vector3(target.transform.localEulerAngles.x, transform.localEulerAngles.y + 135, target.transform.localEulerAngles.z)), TargetBodyRotateLerp);
                }

                else if (V == 0||V1==0)
                {
                target.transform.rotation = Quaternion.Lerp(TargetBodyCurrentRotation, Quaternion.Euler(new Vector3(target.transform.localEulerAngles.x, transform.localEulerAngles.y + 90, target.transform.localEulerAngles.z)), TargetBodyRotateLerp);
                }
            }
            else if (V > 0||V1>0)
            {
            target.transform.rotation = Quaternion.Lerp(TargetBodyCurrentRotation, Quaternion.Euler(new Vector3(target.transform.localEulerAngles.x, transform.localEulerAngles.y, target.transform.localEulerAngles.z)), TargetBodyRotateLerp);

            }
            else if (V < 0||V1<0)
            {
            target.transform.rotation = Quaternion.Lerp(TargetBodyCurrentRotation, Quaternion.Euler(new Vector3(target.transform.localEulerAngles.x, transform.localEulerAngles.y - 180, target.transform.localEulerAngles.z)), TargetBodyRotateLerp);

            }
       
       
    }

   

  


}

