using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace Shaiya_Data_file_Tool
{
    [StandardModule]
    internal sealed class Module1
    {
        public static ArrayList files = new ArrayList();
        private static FileStream FSsah;
        public static string sahPath;
        public static string safPath;

        [DllImport("shaiyaCrypt.dll", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern uint encrypt(byte[] fdata, uint fsize);

        [DllImport("shaiyaCrypt.dll", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern uint decrypt(byte[] fdata, uint fsize);

        private static string Hex2(object value)
        {
            return Conversion.Hex(RuntimeHelpers.GetObjectValue(value)).ToString().PadLeft(2, '0');
        }

        private static ulong readULong(ref byte[] aByte)
        {
            string str = "";
            int index = 0;
            do
            {
                str = Hex2(aByte[index]) + str;
                checked { ++index; }
            }
            while (index <= 7);
            return Conversions.ToULong("&H" + str);
        }

        private static uint readUInteger(ref byte[] aByte)
        {
            string str = "";
            int index = 0;
            do
            {
                str = Hex2(aByte[index]) + str;
                checked { ++index; }
            }
            while (index <= 3);
            return Conversions.ToUInteger("&H" + str);
        }

        private static int readInteger(ref byte[] aByte)
        {
            string str = "";
            int index = 0;
            do
            {
                str = Hex2(aByte[index]) + str;
                checked { ++index; }
            }
            while (index <= 3);
            return Conversions.ToInteger("&H" + str);
        }

        private static object readText(int length)
        {
            byte[] array = new byte[checked(length - 1 + 1)];
            FSsah.Read(array, 0, length);
            Array.Resize(ref array, checked(array.Length - 1));
            return Encoding.ASCII.GetString(array);
        }

        public static void readFiles(string curdir, ref TreeNode node)
        {
            byte[] aByte = new byte[8];
            FSsah.Read(aByte, 0, 4);
            int num1 = readInteger(ref aByte);
            int num2 = 0;
            int num3 = checked(num1 - 1);
            int num4 = num2;
            while (num4 <= num3)
            {
                SAHfile saHfile = new SAHfile();
                saHfile.loc = checked((uint)FSsah.Position);
                Module1.FSsah.Read(aByte, 0, 4);
                string str = Module1.illPath(Conversions.ToString(Module1.readText(Module1.readInteger(ref aByte))));
                Module1.FSsah.Read(aByte, 0, 8);
                ulong num5 = Module1.readULong(ref aByte);
                Module1.FSsah.Read(aByte, 0, 4);
                uint num6 = Module1.readUInteger(ref aByte);
                Module1.FSsah.Read(aByte, 0, 4);
                saHfile.dir = false;
                saHfile.filePath = curdir + str;
                saHfile.dirPath = curdir;
                saHfile.fileName = str;
                saHfile.offset = num5;
                saHfile.len = checked((int)num6);
                Module1.files.Add((object)saHfile);
                int num7 = 1;
                if (Strings.LCase(saHfile.fileName).EndsWith(".dds") | Strings.LCase(saHfile.fileName).EndsWith(".tga") | Strings.LCase(saHfile.fileName).EndsWith(".bmp") | Strings.LCase(saHfile.fileName).EndsWith(".jpeg") | Strings.LCase(saHfile.fileName).EndsWith(".jpg"))
                    num7 = 2;
                node.Nodes.Add(str, str, num7, num7);
                checked { ++num4; }
            }
        }

        public static void readFolders(string curdir, ref TreeNode node)
        {
            byte[] aByte = new byte[8];
            FSsah.Read(aByte, 0, 4);
            int num1 = readInteger(ref aByte);
            int num2 = 0;
            int num3 = checked(num1 - 1);
            int num4 = num2;
            while (num4 <= num3)
            {
                FSsah.Read(aByte, 0, 4);
                string str = illPath(Conversions.ToString(readText(readInteger(ref aByte))));
                files.Add(new SAHfile()
                {
                    dir = true,
                    filePath = (curdir + str),
                    dirPath = curdir,
                    fileName = str,
                    offset = 0UL,
                    len = 0
                });
                TreeNode node1 = node.Nodes.Add(str, str, 0, 0);
                readFiles(curdir + str + "\\", ref node1);
                readFolders(curdir + str + "\\", ref node1);
                checked { ++num4; }
            }
        }

        public static void readSah(string fileName, ref TreeNode node)
        {
            try
            {
                FSsah = new FileStream(fileName, FileMode.Open);
                FSsah.Seek(56L, SeekOrigin.Begin);
                readFiles("Data\\", ref node);
                readFolders("Data\\", ref node);
                node.Expand();
            }
            catch (Exception ex)
            {
                ProjectData.SetProjectError(ex);
                int num = (int)Interaction.MsgBox("Error reading Data.Sah, Please make sure it is not already open.\r\n" + ex.Message, MsgBoxStyle.Exclamation, "Error 1");
                ProjectData.ClearProjectError();
            }
            finally
            {
                FSsah.Close();
            }
        }

        public static string illPath(string nom)
        {
            string str = nom.Trim().Replace("?", "_");
            char[] chArray = new char[2] { '-', '.' };
            return str.TrimStart(chArray).TrimEnd(chArray);
        }

        public static bool encryptFile(string filen)
        {
            if (!File.Exists(filen))
                return false;
            FileStream fileStream1;
            bool flag;
            try
            {
                fileStream1 = new FileStream(filen, FileMode.Open);
            }
            catch (Exception ex)
            {
                ProjectData.SetProjectError(ex);
                int num = (int)Interaction.MsgBox("Error reading sdata, Please make sure its not open.", MsgBoxStyle.Exclamation, "Error");
                flag = false;
                ProjectData.ClearProjectError();
                goto label_13;
            }
            byte[] array = new byte[checked((int)(fileStream1.Length - 1L) + 1)];
            int num1 = 0;
            int num2 = checked(array.Length - 1);
            int index = num1;
            while (index <= num2)
            {
                array[index] = new BinaryReader(fileStream1).ReadByte();
                checked { ++index; }
            }
            Array.Resize<byte>(ref array, checked(array.Length + 64 + 16));
            fileStream1.Close();
            new BinaryReader(fileStream1).Close();
            uint num3 = encrypt(array, checked((uint)(array.Length - 64 - 16)));
            if ((long)num3 < 5L)
            {
                int num4 = (int)Interaction.MsgBox("Error Encrypting file.", MsgBoxStyle.Exclamation, "Error");
                return false;
            }
            File.Delete(filen);
            BinaryWriter binaryWriter = new BinaryWriter(new FileStream(filen, FileMode.OpenOrCreate));
            long num5 = 0;
            long num6 = checked((long)num3 - 1L + 64L);
            long num7 = num5;
            while (num7 <= num6)
            {
                binaryWriter.Write(array[checked((int)num7)]);
                checked { ++num7; }
            }
            new FileStream(filen, FileMode.OpenOrCreate).Close();
            binaryWriter.Close();
            return true;
        label_13:
            return flag;
        }

        public static bool decryptFile(string filen)
        {
            if (!File.Exists(filen))
                return false;
            FileStream fileStream1;
            bool flag;
            try
            {
                fileStream1 = new FileStream(filen, FileMode.Open);
            }
            catch (Exception ex)
            {
                ProjectData.SetProjectError(ex);
                int num = (int)Interaction.MsgBox("Error reading sdata, Please make sure its not open.", MsgBoxStyle.Exclamation, "Error");
                flag = false;
                ProjectData.ClearProjectError();            
                return flag;
            }
            byte[] array = new byte[checked((int)(fileStream1.Length - 1L) + 1)];
            int num1 = 0;
            int num2 = checked((new byte[checked((int)(fileStream1.Length - 1L) + 1)]).Length - 1);
            int index = num1;
            while (index <= num2)
            {
                (new byte[checked((int)(fileStream1.Length - 1L) + 1)])[index] = new BinaryReader(fileStream1).ReadByte();
                checked { ++index; }
            }
            Array.Resize(ref array, (new byte[checked((int)(fileStream1.Length - 1L) + 1)]).Length);
            fileStream1.Close();
            new BinaryReader(fileStream1).Close();
            switch (decrypt(new byte[checked((int)(fileStream1.Length - 1L) + 1)], checked((uint)(new byte[checked((int)(fileStream1.Length - 1L) + 1)]).Length)))
            {
                case 0:
                    int num4 = (int)Interaction.MsgBox("Error decrypting file. Might not be aligned correctly.", MsgBoxStyle.Exclamation, "Error");
                    return false;
                case 1:
                    int num5 = (int)Interaction.MsgBox("Error decrypting file. Incorrect Header info.", MsgBoxStyle.Exclamation, "Error");
                    return false;
                case 2:
                    int num6 = (int)Interaction.MsgBox("Error decrypting file. CRC mismatch.", MsgBoxStyle.Exclamation, "Error");
                    return false;
                default:
                    File.Delete(filen);
                    BinaryWriter binaryWriter = new BinaryWriter((Stream)new FileStream(filen, FileMode.OpenOrCreate));
                    long num7 = 0;
                    long num8 = checked((decrypt(new byte[checked((int)(fileStream1.Length - 1L) + 1)], checked((uint)(new byte[checked((int)(fileStream1.Length - 1L) + 1)]).Length)) - 1L));
                    long num9 = num7;
                    while (num9 <= num8)
                    {
                        binaryWriter.Write((new byte[checked((int)(fileStream1.Length - 1L) + 1)])[checked((int)num9)]);
                        checked { ++num9; }
                    }
                    new FileStream(filen, FileMode.OpenOrCreate).Close();
                    binaryWriter.Close();
                    return true;
            }
        }

        [Serializable]
        public struct SAHfile
        {
            public bool dir;
            public string filePath;
            public string fileName;
            public string dirPath;
            public ulong offset;
            public int len;
            public uint loc;

            public override string ToString()
            {
                return filePath;
            }
        }
    }
}
