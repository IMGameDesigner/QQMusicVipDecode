using System.Collections.Generic;
using System.IO;
using UnityEngine;

namespace DefaultNamespace
{
    public class readHarddiskFile
    {
        public static List<string> GetNameList(string folderPath)
        {
            DirectoryInfo dir = new DirectoryInfo(folderPath);
            List<string> nameList=new List<string>();
            foreach (FileInfo dChild in dir.GetFiles("*"))
            {
                if (dChild.Extension.ToUpper() == ".RESX")
                {
                    //......可以将dchild保存到一个Array或者List中
                    
                }
                nameList.Add(dChild.Name);
                //Debug.Log(dChild.Name);
            }

            return nameList;
        }
        
        public static List<FileInfo> GetFileList(string folderPath)
        {
            DirectoryInfo dir = new DirectoryInfo(folderPath);
            List<FileInfo> FileInfoList=new List<FileInfo>();
            foreach (FileInfo dChild in dir.GetFiles("*"))
            {
                FileInfoList.Add(dChild);
            }

            return FileInfoList;
        }
        
        public static string[] GetNameArray(string folderPath)
        {
            DirectoryInfo dir = new DirectoryInfo(folderPath);
            var sum = 0;
            foreach (FileInfo dChild in dir.GetFiles("*"))
            {
                sum++;
            }
            var arr = new string[sum];
            var tip = 0;
            foreach (FileInfo dChild in dir.GetFiles("*"))
            {
                arr[tip] = dChild.Name;
                tip++;
            }

            return arr;
        }
    }
}