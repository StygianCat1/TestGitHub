using UnityEngine;

public class S_HelloWorld : MonoBehaviour
{
    private float A = 10 / 3;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Miaou");
        Debug.Log (A);
    }

    // Update is called once per frame
    void Update()
    {
        print("Miaou");
        print("mIAOU");
    }
}
