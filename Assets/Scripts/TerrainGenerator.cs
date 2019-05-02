using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Title: "MESH GENERATION IN UNITY - Basics"
 * Author: Brackeys
 * Date: 28/10/2018
 * Availability: https://youtu.be/eJEpeUH1EMg
 */


[RequireComponent(typeof(MeshFilter))]
public class TerrainGenerator : MonoBehaviour { 

    Mesh terrain;
    Vector3[] vertices;
    int[] triangles;
    Color[] colours;
    public Gradient terrainColour;

    float minHeight;
    float maxHeight;
    public int xSize = 256;
    public int zSize = 256; 

    public float amp = 8f;
    public float frequency = 0.1f;  

           
    void Start()
    {
        //Creates mesh for terrain
        terrain = new Mesh();
        GetComponent<MeshFilter>().mesh = terrain;      
        
    }

    
    void Update()
    {
        CreateShape();
        UpdateMesh();
    }

    void CreateShape()
    {
        //Creates map for vertices
        vertices = new Vector3[(xSize + 1) * (zSize + 1)];


        for (int i = 0,z = 0; z<= zSize; z++)
        {
            for(int x = 0; x <= xSize; x++)
            {
                //Use PerlinNoise Math function to generate the noise
                float y = Mathf.PerlinNoise(x * frequency, z * frequency) * amp;
                vertices[i] = new Vector3(x, y, z);

                if (y > maxHeight)
                {
                    maxHeight = y;
                }
                else if (y < minHeight)
                {
                    minHeight = y;
                }

                i++;
            }
        }

        //Creates array for the triangles
        triangles = new int[xSize * zSize * 6];
        int vert = 0;
        int tris = 0;

        for (int z = 0; z < zSize; z++)
        {
            for (int x = 0; x < xSize; x++)
            {

                triangles[tris + 0] = vert + 0;
                triangles[tris + 1] = vert + xSize + 1;
                triangles[tris + 2] = vert + 1;
                triangles[tris + 3] = vert + 1;
                triangles[tris + 4] = vert + xSize + 1;
                triangles[tris + 5] = vert + xSize + 2;

                vert++;
                tris += 6;
            }
            vert++;
        }

        colours = new Color[vertices.Length];

        for (int i = 0, z = 0; z <= zSize; z++)
        {
            for (int x = 0; x <= xSize; x++)
            {
                float height = Mathf.InverseLerp(minHeight, maxHeight, vertices[i].y);
                colours[i] = terrainColour.Evaluate(height);
                i++;
            }
        }

    }

    void UpdateMesh()
    {
        terrain.Clear();

        terrain.vertices = vertices;
        terrain.triangles = triangles;
        terrain.colors = colours;

        terrain.RecalculateNormals();
    }
    

}
