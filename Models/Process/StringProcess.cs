using Microsoft.AspNetCore.Mvc;

namespace NguyenThiKhamBTH.Models.Process
{
    public class StringProcess : Controller
    {

        public string Remo (string str)
        {
           string result= "";
            //Xóa bỏ ký tự đầu và cuối
            str = str.Trim();
            //Xóa bỏ ký tự khoảng trắng ở giữa
            int index = str.IndexOf("  ");
            while (index >0)
            {
                str = str.Replace("  "," ");
            }
            result = str;
            return result;
        }
        public string Lower(string strInput)
         {
             string result = "";
             //chuyen sang in hoa
             strInput = strInput.ToUpper();
             result = strInput;
             return result;
        }
         public string Upper(string strInput)
         {
             string result = "";
              //chuyen sang in thuong
             strInput = strInput.ToLower();
             result = strInput;
             return result;
        }
        public string Capital(string strInput)
         {
            string result = "";
             //viet hoa chu cai dau tien cua chuoi
             string firstCharacter = strInput.Substring(0,1).ToUpper();
             strInput = firstCharacter + strInput.Substring(1);
             result = strInput;
             return result;
        }
    }
}
         