using UnityEngine;

public class SpawnCubes : MonoBehaviour
{

    public GameObject cube;
    [SerializeField] private float spawnRadius;
    [SerializeField] private float spawnHeight;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void CubeSpawn()
    {
        // Instantiate the cube at rendom position within the spawn radius and height
        GameObject newCube = Instantiate(cube, spawnRadius * Random.insideUnitSphere + new Vector3(0, spawnHeight, 0), Random.rotationUniform);
        
        // Assign a random color to the cube
        newCube.GetComponent<Renderer>().material.color = new Color(Random.value, Random.value, Random.value);

    }
}
