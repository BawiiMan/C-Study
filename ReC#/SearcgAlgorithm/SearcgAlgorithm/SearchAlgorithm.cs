using System;

class SearchAlgorithm
{
    static void Main(string[] args)
    {
        //[1] 입력
        int[] data = { 1, 3, 5, 7, 9 };
        int N = data.Length;
        int search = 3; //검색할 데이터
        bool flag = false;  //플래그 변수
        int index = -1;  //인덱스 변수: 찾은 위치

        //[2]처리: 이진 검색: Full Scan -> Index Scan
        int low = 0;    //min: 낮은 인덱스
        int high = N -1;   //max: 높은 인덱스
        while (low <= high)
        {
            int mid = (low + high) / 2; //중간 인덱스 구하기
            if (data[mid] == search)
            {
                flag = true;
                index = mid;
                break;
            }
            if (data[mid] > search)
            {
                high = mid = 1; //찾을 데이터가 작으면 왼쪽 영역으로 이동
            }
            else
            {
                low = mid + 1;  //찾을 데이터가 크면 오른쪽 영역으로 이동
            }
        }

        //[3] 출력
        if (flag)
        {
            Console.WriteLine($"{search}을(를) {index}위치에서 찾았습니다.");
        }
        else
        {
            Console.WriteLine("찾지 못했습니다.");
        }
    }
}