using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CustomerManagement.Classes
{
    /// <summary>
    /// 고객 정보를 나타내는 구조체입니다.
    /// </summary>
    public struct Customer
    {
        /// <summary>
        /// 고객의 식별자를 가져오거나 설정합니다.
        /// </summary>
        public int ID;

        /// <summary>
        /// 고객의 이름을 가져오거나 설정합니다.
        /// </summary>
        public string Name;

        /// <summary>
        /// 고객의 전화번호를 가져오거나 설정합니다.
        /// </summary>
        public string PhoneNumber;

        /// <summary>
        /// Customer 구조체의 새 인스턴스를 초기화합니다.
        /// </summary>
        /// <param name="id">고객의 식별자입니다.</param>
        /// <param name="name">고객의 이름입니다.</param>
        /// <param name="phone_number">고객의 전화번호입니다.</param>
        public Customer(int id, string name, string phone_number)
        {
            ID = id;
            Name = name;
            PhoneNumber = phone_number;
        }
    }

    /// <summary>
    /// 구조체로 정의된 의류 정보를 나타냅니다.
    /// </summary>
    public struct Garment
    {
        /// <summary>
        /// 의류의 고유 식별자를 가져오거나 설정합니다.
        /// </summary>
        public int ID;

        /// <summary>
        /// 의류의 등록 날짜를 가져오거나 설정합니다.
        /// </summary>
        public string RegisteredDate;

        /// <summary>
        /// 의류의 처리 날짜를 가져오거나 설정합니다.
        /// </summary>
        public string ProcessingDate;

        /// <summary>
        /// 의류의 완료 여부를 가져오거나 설정합니다.
        /// </summary>
        public string IsCompleted;

        /// <summary>
        /// 의류의 내용을 가져오거나 설정합니다.
        /// </summary>
        public string Contents;

        /// <summary>
        /// 의류의 가격을 가져오거나 설정합니다.
        /// </summary>
        public int Price;

        /// <summary>
        /// 의류에 대한 메모를 가져오거나 설정합니다.
        /// </summary>
        public string Note;

        /// <summary>
        /// 의류와 연결된 고객의 식별자를 가져오거나 설정합니다.
        /// </summary>
        public int CustomerID;

        /// <summary>
        /// Garment 구조체의 새 인스턴스를 초기화합니다.
        /// </summary>
        /// <param name="id">의류의 고유 식별자입니다.</param>
        /// <param name="registered_date">의류의 등록 날짜입니다.</param>
        /// <param name="processing_date">의류의 처리 날짜입니다.</param>
        /// <param name="is_completed">의류의 완료 여부입니다.</param>
        /// <param name="contents">의류의 내용입니다.</param>
        /// <param name="price">의류의 가격입니다.</param>
        /// <param name="note">의류에 대한 메모입니다.</param>
        /// <param name="customer_id">의류와 연결된 고객의 식별자입니다.</param>
        public Garment(
            int id,
            string registered_date,
            string processing_date,
            string is_completed,
            string contents,
            int price,
            string note,
            int customer_id
        ) {
            ID = id;
            RegisteredDate = registered_date;
            ProcessingDate = processing_date;
            IsCompleted = is_completed;
            Contents = contents;
            Price = price;
            Note = note;
            CustomerID = customer_id;
        }
    }
}
