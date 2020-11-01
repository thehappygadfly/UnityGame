using System;
using UnityEngine;


namespace UnityStandardAssets.Utility
{
    public class FollowTarget : MonoBehaviour
    {
        public GameObject target;
        public Vector3 offset = new Vector3(0f, 7.5f, 0f);
        // private float rotateSpeed = 10f;


        private void LateUpdate()
        {
            transform.position = target.transform.position + offset;
            //Vector3 targetDir = target.transform.forward;
            //Quaternion newRotation = Quaternion.LookRotation(targetDir, Vector3.up);
            // transform.rotation = Quaternion.Lerp(transform.rotation, newRotation, rotateSpeed * Time.deltaTime);
        }
    }
}
