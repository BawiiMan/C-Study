using System;

class StructVariable
{
    static void Main(string[] args)
    {
        Product product;    //구조체 형식 변수 선언

        product.Id = 1;    //구조체 변수의 각 멤버에 값을 할당
        product.Title = "좋은 책";
        product.Price = 1000M;

        //구조체 형식 변수 사용
        string message = $"번호 : {product.Id}\n상품명 : {product.Title}\n가격 : {product.Price}";
        Console.WriteLine(message);
    }

    //[1] 멤버가 3개인 Product 구조체 선언
    struct Product
    {
        public int Id;
        public string Title;
        public decimal Price;
    }
}