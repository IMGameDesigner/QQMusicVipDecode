

using System;
using UnityEngine;

namespace DefaultNamespace
{
    public class QQMusicVipDecode
    {
        
        public void Run(string inPath,string outPath)
        {
            
            try
            {
                var FileList=readHarddiskFile.GetFileList(inPath);
                


                int tip = 0;
                foreach (var item in FileList)
                {
                    tip++;
                    bool thisEnd = false;
                    var oldFrontName=new HarddiskFile().GetFileFrontName(item);
                    var oldName = item.Name;
                    var newName = tip+item.Extension.ToUpper();
                    
                    new HarddiskFile().Rename(inPath,oldName,newName);

                    var myCmd=new cmd(() =>
                    {
                        new HarddiskFile().Rename(inPath,newName,oldName);
                        new HarddiskFile().Rename(outPath,$"{newName}.mp3",$"{oldFrontName}.mp3");
                        thisEnd = true;
                    });
                    myCmd.RunCmdAsync($@"qmcdump {inPath}\{newName} {outPath}\{newName}.mp3");

                    myCmd.ExitAsync();

                }
                
            }
            catch (Exception ex)
            {
                Debug.LogError(ex);
            }

            
        }

    }
}