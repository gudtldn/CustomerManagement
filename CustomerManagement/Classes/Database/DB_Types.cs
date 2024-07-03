using System;


namespace CustomerManagement.Classes
{
    interface IDatabaseID
    {
        int GetID();
    }
    
    /// <summary>
    /// 고객 정보를 나타내는 구조체입니다.
    /// </summary>
    public struct Customer : IEquatable<Customer>, IDatabaseID
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
        /// 고객에 대한 메모를 가져오거나 설정합니다.
        /// </summary>
        public string Note;

        /// <summary>
        /// Customer 구조체의 새 인스턴스를 초기화합니다.
        /// </summary>
        /// <param name="id">고객의 식별자입니다.</param>
        /// <param name="name">고객의 이름입니다.</param>
        /// <param name="phone_number">고객의 전화번호입니다.</param>
        public Customer(int id, string name, string phone_number, string note)
        {
            ID = id;
            Name = name;
            PhoneNumber = phone_number;
            Note = note;
        }

        public int GetID()
        {
            return ID;
        }

        public bool Equals(Customer other)
        {
            return (
                ID == other.ID
                && Name == other.Name
                && PhoneNumber == other.PhoneNumber
                && Note == other.Note
            );
        }

        public override bool Equals(object obj)
        {
            if (obj is Customer customer)
            {
                return Equals(customer);
            }
            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static bool operator ==(Customer left, Customer right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(Customer left, Customer right)
        {
            return !(left == right);
        }
    }

    /// <summary>
    /// 구조체로 정의된 의류 정보를 나타냅니다.
    /// </summary>
    public struct Garment : IEquatable<Garment>, IDatabaseID
    {
        /// <summary>
        /// 의류의 고유 식별자를 가져오거나 설정합니다.
        /// </summary>
        public int ID;

        /// <summary>
        /// 의류의 등록 날짜를 가져오거나 설정합니다.
        /// </summary>
        public DateTime? ReceptionDate;

        /// <summary>
        /// 의류의 처리 날짜를 가져오거나 설정합니다.
        /// </summary>
        public DateTime? ProcessingDate;

        /// <summary>
        /// 의류의 선불 여부를 가져오거나 설정합니다.
        /// </summary>
        public bool IsCompleted;

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
        /// <param name="reception_date">의류의 등록 날짜입니다.</param>
        /// <param name="processing_date">의류의 처리 날짜입니다.</param>
        /// <param name="is_completed">의류의 선불 여부입니다.</param>
        /// <param name="contents">의류의 내용입니다.</param>
        /// <param name="price">의류의 가격입니다.</param>
        /// <param name="note">의류에 대한 메모입니다.</param>
        /// <param name="customer_id">의류와 연결된 고객의 식별자입니다.</param>
        public Garment(
            int id,
            DateTime? reception_date,
            DateTime? processing_date,
            bool is_completed,
            string contents,
            int price,
            string note,
            int customer_id
        ) {
            ID = id;
            ReceptionDate = reception_date;
            ProcessingDate = processing_date;
            IsCompleted = is_completed;
            Contents = contents;
            Price = price;
            Note = note;
            CustomerID = customer_id;
        }

        public int GetID()
        {
            return ID;
        }

        public bool Equals(Garment other)
        {
            return Nullable.Compare(ReceptionDate?.Date, other.ReceptionDate?.Date) == 0
                && Nullable.Compare(ProcessingDate?.Date, other.ProcessingDate?.Date) == 0
                && IsCompleted == other.IsCompleted
                && Contents == other.Contents
                && Price == other.Price
                && Note == other.Note
                && CustomerID == other.CustomerID;
        }

        public override bool Equals(object obj)
        {
            if (obj is Garment garment)
            {
                return Equals(garment);
            }
            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static bool operator ==(Garment left, Garment right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(Garment left, Garment right)
        {
            return !(left == right);
        }
    }
}
