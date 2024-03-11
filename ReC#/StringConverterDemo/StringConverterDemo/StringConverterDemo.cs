using System;

namespace StringConverterDemo
{
	public class StringConverter
	{
		public static string ConvertToSimpleEncoding(string original)
		{
			byte[] byt = System.Text.Encoding.UTF8.GetBytes(original);
			return System.Convert.ToBase64String(byt);	//암호화
		}

		public static string ConvertToSimpleDecoding(string modified)
		{
			byte[] byt = System.Convert.FromBase64String(modified);
			return System.Text.Encoding.UTF8.GetString(byt);	//복호화
		}
	}
	class StringConverterDemo
	{
        static void Main(string[] args)
        {
			string s = "안녕하세요.";
            Console.WriteLine("[1] 원본 : {0}", s);

			s = StringConverter.ConvertToSimpleEncoding(s); //인코딩
			Console.WriteLine("[2] 인코딩 : {0}", s);
			
			s = StringConverter.ConvertToSimpleDecoding(s); //디코딩
			Console.WriteLine("[3] 디코딩 : {0}", s);
		}
	}
}