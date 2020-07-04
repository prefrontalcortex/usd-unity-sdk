using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeshDumpDrawer : MonoBehaviour
{
    public MeshDump dump;
    public float length;

    private void OnDrawGizmos() {
        // Gizmos.matrix = transform.localToWorldMatrix;

        // for(int i = 0; i < dump.points.Count; i++) {
        //     Gizmos.color = Color.green;
        //     Gizmos.DrawLine(dump.points[i], dump.points[i] + dump.normals[i] * length);

        //     // Gizmos.color = Color.blue;
        //     // Gizmos.DrawLine(dump.points[i], dump.points[i] + dump.tangents[i] * length);
        // }
        if(dump)
            ShowVertexInfo(dump);
        else{
           var mf = GetComponent<MeshFilter>();
           ShowVertexInfo(mf.sharedMesh); 
        }
    }
    static Color NormalColor = Color.magenta;
    static Color TangentColor = Color.green;
    static Color BinormalColor = Color.blue;

    [HideInInspector]
    MeshDump tempDump;
    Mesh tempMesh;

    void ShowVertexInfo(Mesh mesh) {
        if(!mesh) return;
        if(!tempDump || tempMesh != mesh) {
            tempDump = ScriptableObject.CreateInstance<MeshDump>();
            tempDump.points = new List<Vector3>(mesh.vertices);
            tempDump.normals = new List<Vector3>(mesh.normals);
            tempDump.tangents = new List<Vector4>(mesh.tangents);
            tempMesh = mesh;
        }

        ShowVertexInfo(tempDump);
    }

    public int range = 0;
    
    void ShowVertexInfo(MeshDump  mesh)
    {
        var vertices = mesh.points;
        var normals = mesh.normals;
        var tangents = mesh.tangents;

        for (int i = 0; i < vertices.Count; i++)
        {
            if(range >= 0 && range != i) continue;

            Vector3 vertex = transform.TransformPoint(vertices[i]);
            Vector3 normal = (normals != null && i < normals.Count) ? transform.TransformDirection(normals[i]) : Vector3.zero;
            Vector4 tangent4 = Vector4.zero;
            Vector3 tangnet3 = Vector3.zero;
            if (tangents != null && i < tangents.Count) {
                tangent4 = tangents[i];
                tangnet3 = transform.TransformDirection(tangent4.x, tangent4.y, tangent4.z);
            }
            DrawVertexInfo(vertex, normal, tangnet3, tangent4.w);
        }
    }

    void DrawVertexInfo(Vector3 vertex, Vector3 normal, Vector3 tangnet, float binormalSign)
    {
        // if (EnableInfoType(InfoType.Normal))
        {
            Gizmos.color = NormalColor;
            Gizmos.DrawLine(vertex, vertex + normal * length);
            Gizmos.color = Color.white;
        }
        
        // if (EnableInfoType(InfoType.Tangent))
        {
            Gizmos.color = TangentColor;
            Gizmos.DrawLine(vertex, vertex + tangnet * length);
            Gizmos.color = Color.white;
        }

        // if (EnableInfoType(InfoType.Binormal))
        {
            Gizmos.color = BinormalColor;
            Vector3 binormal = Vector3.Cross(normal, tangnet) * Mathf.Sign(binormalSign);
            Gizmos.DrawLine(vertex, vertex + binormal  * length);
            Gizmos.color = Color.white;
        }
    }
}
