using Unity.VisualScripting;
using UnityEngine;

public class S_HelloWorld : MonoBehaviour
{
    private float A = 10 / 3;
    
    [SerializeField] private int _numberOfTick = 0;
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Miaou");
        Debug.Log (A);
        Vcerveau();
    }

    // Update is called once per frame
    void Update()
    {
        print("Miaou");
        print("mIAOU");
        _numberOfTick++;
        Debug.Log(_numberOfTick);
    }
}
