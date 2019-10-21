using DefaultNamespace;
using UnityEngine;

public class doMain : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string inPath = @"C:\Users\BYWS\Desktop\vipIn";
        string outPath = @"C:\Users\BYWS\Desktop\vipOut";
        new QQMusicVipDecode().Run(inPath,outPath);

        
    }
    

    
    void Update()
    {
        
    }
}
