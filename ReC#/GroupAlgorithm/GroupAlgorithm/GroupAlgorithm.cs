using System;
using System.Collections.Generic;
using System.Linq;

class GroupAlgorithm
{
    class Record    // 테스트용 레코드 클래스
    {
        public string Name { get; set; }    // 상품 이름
        public int Quantity { get; set; }   //수량
    }

    static void Main(string[] args)
    {
        //테스트용 데이터 채우기 로컬 함수
        List<Record> GetAll()
        {
            return new List<Record>
            {
                new Record { Name = "RADIO", Quantity = 3},
                new Record { Name = "TV", Quantity = 1 },
                new Record { Name = "RADIO", Quantity = 2},
                new Record { Name = "DVD", Quantity = 4}
            };
        }
        //컬렉션 데이터 출력용 로컬 함수
        void PrintData(string message, List<Record> data)
        {
            Console.WriteLine(message);
            foreach (var item in data)
            {
                Console.WriteLine($"{item.Name,5} - {item.Quantity}");
            }
        }

        //[1] 입력
        List<Record> records = GetAll();    //입력 데이터
        List<Record> groups = new List<Record>();   //출력 데이터
        int N = records.Count;

        //[2] 처리: Group 알고리즘
        //그룹 정렬: SORT
        for (int i = 0; i < N - 1; i++)
        {
            for (int j = i + 1; j < N; j++)
            {
                if (String.Compare(records[i].Name, records[j].Name) > 0)
                {
                    var t = records[i]; records[i] = records[j]; records[j] = t;    
                }
            }
        }

        //그룹 소계: GROUP
        int subtotal = 0;   //소계
        for (int i = 0; i < N; i++)
        {
            subtotal += records[i].Quantity;    //같은 상품 이름의 수량을 누적
            if ((i + 1) == N || (records[i].Name != records[i + 1].Name))
            {
                //다음 레코드가 없거나 현재 레코드와 다음 레코드가 다르면 저장
                groups.Add(new Record
                {
                    Name = records[i].Name, //한 그룹의 키 지정
                    Quantity = subtotal //소계
                }); //한 그룹 저장

                subtotal = 0;   //한 그룹이 완료되면 소계 초기화
            }
        }

        //[3] 출력
        PrintData("[1] 정렬된 원본 데이터 : ", records);
        PrintData("[2] 이름으로 그룹화된 데이터 : ", groups);
        PrintData("[3] LINQ로 그룹화된 데이터 : ", records.GroupBy(r => r.Name).Select(g => new Record
        {
            Name = g.Key,
            Quantity = g.Sum(n => n.Quantity)
        }).ToList());

    }
}