using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class burSpawner : MonoBehaviour
{
    [SerializeField] private GameObject bur;
    //Generate bur
    [SerializeField] private float heightOffset;
    [SerializeField] private float widthOffset;
    [SerializeField] private float coolDown;
    [SerializeField] private float moveSpeed;
    [SerializeField] private float timer;
    private Vector3 endPoint;
    private GameObject Bur;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        float highestPoint = 10 - heightOffset;
        float lowestPoint = -10 + heightOffset;
        float mostLeftPoint = -27 + widthOffset;
        float mostRightPoint = 27 - widthOffset;

        if (timer > coolDown)
        {
            Vector3 startPoint = new Vector3(Random.Range(13, -13), transform.position.y, transform.position.z);
            endPoint = new Vector3(Random.Range(mostRightPoint, mostLeftPoint), Random.Range(highestPoint, lowestPoint), transform.position.z);
            Bur = Instantiate(bur, startPoint, transform.rotation);
            Debug.Log(endPoint);
            timer = 0;
        }
        if (Bur)
        {

            Bur.transform.position = Vector3.MoveTowards(Bur.transform.position, endPoint, moveSpeed * Time.deltaTime);
        }
    }
}
