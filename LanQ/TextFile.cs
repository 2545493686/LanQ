using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanQ
{
    public class TextFile
    {
        public string Path { get; }
        protected FileStream FileStream { get; }

        public TextFile(string path, FileMode fileMode = FileMode.OpenOrCreate)
        {
            Path = path;
            FileStream = new FileStream(path, fileMode); 
        }

        public string ReadToEnd()
        {
            StreamReader streamReader = new StreamReader(FileStream);
            string retText = streamReader.ReadToEnd();
            streamReader.Close();
            return retText;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="text">要被插入的文本</param>
        /// <param name="position">默认值 "-1"，插入文件尾部</param>
        /// <param name="encoding">默认值 "UTF-8"，编码</param>
        public void WriteLine(string text, int position = -1, string encoding = "UTF-8")
        {
            byte[] contents = Encoding.GetEncoding(encoding).GetBytes(text + "\n\r");
            FileStream.Position = position == -1 ? FileStream.Length : position;
            FileStream.Write(contents, 0, contents.Length);
        }

        public void Close()
        {
            FileStream.Close();
        }
    }
}
