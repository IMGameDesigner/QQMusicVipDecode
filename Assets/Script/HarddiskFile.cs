using System.IO;
using UnityEngine;

namespace DefaultNamespace
{
    public class HarddiskFile
    {
        public void Rename(string path, string oldName, string newName)
        {
            File.Move(path+"\\"+oldName,path+"\\"+newName);
            if(File.Exists(path+"\\"+newName))Debug.Log(path+"\\"+oldName+"---->"+path+"\\"+newName+"success");
        }

        public string GetFileFrontName(FileInfo file)
        {
            return file.Name.Substring(0, file.Name.Length - file.Extension.ToUpper().Length);
        }
    }
}