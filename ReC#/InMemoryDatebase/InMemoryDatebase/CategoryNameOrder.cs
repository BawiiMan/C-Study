using System;

namespace InMemoryDatabase
{
    //한국식 발음: 오브설리트
    [Obsolete("OrderOption 열거형을 사용하세요.")]
    public enum CategoryNameOrder
    {
        /// <summary>
        /// 오름차순
        /// </summary>
        Asc,

        /// <summary>
        /// 내림차순
        /// </summary>
        Desc,
    }
}