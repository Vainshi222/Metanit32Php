using System;

namespace Metanit32Php.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }

    public class Phone
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Company { get; set; }
        public int Price { get; set; }
    }
    public class Order
    {
        public int OrderId { get; set; }
        public string User { get; set; } // ��� ������� ����������
        public string Address { get; set; } // ����� ����������
        public string ContactPhone { get; set; } // ���������� ������� ����������

        public int PhoneId { get; set; } // ������ �� ��������� ������ Phone
        public Phone Phone { get; set; }
    }
}