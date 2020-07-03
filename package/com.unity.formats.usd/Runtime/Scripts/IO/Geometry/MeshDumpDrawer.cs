using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeshDumpDrawer : MonoBehaviour
{
    public MeshDump dump;
    public float length;

    private void OnDrawGizmos() {
        Gizmos.matrix = transform.localToWorldMatrix;

        for(int i = 0; i < dump.points.Count; i++) {
            Gizmos.color = Color.green;
            Gizmos.DrawLine(dump.points[i], dump.points[i] + dump.normals[i] * length);

            Gizmos.color = Color.blue;
            Gizmos.DrawLine(dump.points[i], dump.points[i] + dump.tangents[i] * length);
        }
    }
}
