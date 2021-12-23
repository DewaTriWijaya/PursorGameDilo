using UnityEngine;

public class BlockManager : MonoBehaviour
{
    public GameObject resourcePrefabs1;
    public int count = 1;

    [Header("Radius")]
    public Transform x;
    public Transform y;
    public float offset = 0f;

    private float _xRadius;
    private float _yRadius;

    private void Awake()
    {
        _xRadius = x.position.x;
        _yRadius = y.position.y;
    }

    private void Start()
    {
        for (int i = 0; i < count; i++)
            SpawnResource(_xRadius, _yRadius);
    }

    public void SpawnResourceDelay()
    {
        Invoke("SpawnResource", 3f);
    }

    private void SpawnResource()
    {
        SpawnResource(_xRadius, _yRadius);
    }

    private void SpawnResource(float x, float y)
    {
        Vector2 pos = RandomRadiusPosition(x, y);

        if (GameObject.FindGameObjectWithTag("Player").GetComponent<CircleCollider2D>().bounds.Contains(pos))
        {
            SpawnResource(x, y);
            return;
        }

        Instantiate(resourcePrefabs1, pos, Quaternion.identity);
    }

    private Vector2 RandomRadiusPosition(float x, float y)
    {
        return new Vector2(Random.Range(-x - offset, x + offset), Random.Range(-y - offset, y + offset));
    }
}

