using DefaultNamespace;
using UnityEngine;

public class doMain : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string inPath = @"C:\Users\BYWS\Desktop\1";
        string outPath = @"C:\Users\BYWS\Desktop\out";
        new QQMusicVipDecode().Run(inPath,outPath);

        
    }
    

    
    void Update()
    {
        
    }
}
