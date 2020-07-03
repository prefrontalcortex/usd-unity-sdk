using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class MeshDump : ScriptableObject {
    public List<Vector3> points;
    public List<Vector3> normals;
    public List<Vector4> tangents;
    public List<Vector2> uv;
    public List<int> faceVertexCounts;
    public List<int> faceVertexIndices;
}