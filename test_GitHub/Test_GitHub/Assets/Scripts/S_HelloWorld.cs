using Unity.VisualScripting;
using UnityEngine;

public class S_HelloWorld : MonoBehaviour
{
    private float A = 10 / 3;
    [SerializeField] private int DarknessLock = 1;
    
    [SerializeField] private int _numberOfTick = 0;
    private enum State
    {
        M,
        Mi,
        Mia,
        Miao,
        Miaou
    }
    
    
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
        _numberOfTick++;

        if (_numberOfTick > DarknessLock)
        {
            print("Darkness arrêts tes conneries");
        }
        
        else
        {
            Debug.Log(_numberOfTick);
            Debug.Log(State.Miao);   
        }
        
    }
}
