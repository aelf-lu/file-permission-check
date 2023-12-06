using System;
using System.IO;

namespace FilePermissionCheck.Web;

public class FilePermissionCheckHelper
{
    public static bool Check(string filePath)
    {
        try
        {
            // 获取文件权限信息
            FileAttributes attributes = File.GetAttributes(filePath);

            // 检查文件的读权限
            if ((attributes & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
            {
                Console.WriteLine("文件具有读权限。");
                return true;
            }
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("无法访问文件。");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("文件未找到。");
        }

        Console.WriteLine("文件没有读权限。");
        return false;
    }
}