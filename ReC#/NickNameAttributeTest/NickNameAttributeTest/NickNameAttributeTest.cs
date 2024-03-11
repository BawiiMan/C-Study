using System;

//[1] AttributeUsage 특성을 사용하여 특성에 제약 조건 등 설정
[AttributeUsage(
    AttributeTargets.Method | AttributeTargets.Class, AllowMultiple = true)]
public class NickNameAttribute : Attribute
{
    public string Name { get; set; }
    public NickNameAttribute(string name) { Name = name; }

    //[2] AllowMultiple로 여러 번 설정 가능
    [NickName("길벗")]
    [NickName("RedPlus")]
    class NickNameAttributeTest
    {
        static void Main() => ShowMetaData();

        static void ShowMetaData()
        {
            //모든 커스텀 어트리뷰트 가져오기
            Attribute[] attrs = 
                Attribute.GetCustomAttributes(typeof(NickNameAttributeTest));
            foreach (var attr in attrs)
            {
                //[a] is 연산자를 사용하여 커스텀 어트리뷰트의 Name 속성 출력
                if (attr is NickNameAttribute)
                {
                    NickNameAttribute ais = (NickNameAttribute)attr;
                    Console.WriteLine("{0}", ais.Name);
                }
                //[b] as 연산자를 사용하여 커스텀 어트리뷰터 Name 속성 출력
                NickNameAttribute aas = attr as NickNameAttribute;
                if (aas != null)
                {
                    Console.WriteLine("{0}", aas.Name);
                }
            }
        }
    }
}