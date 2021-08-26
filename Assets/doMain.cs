using DefaultNamespace;
using UnityEngine;
using UnityEngine.UI;

public class doMain : MonoBehaviour
{
    // Start is called before the first frame update
    public static string log = "";
    public Text text;
    void Start()
    {
        string inPath = @"C:\Users\BYWS\Desktop\vipIn";
        string outPath = @"C:\Users\BYWS\Desktop\vipOut";
        new QQMusicVipDecode().Run(inPath,outPath);

        
    }
    

    
    void Update()
    {
        text.text = log;
    }
}
