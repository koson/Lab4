using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            // การ copy สามารถเลื่อน cursor ไปยังบรรทัดที่ต้องการจะ copy
            // แล้วกด Ctrl+C โดยไม่ต้องทำแถบเลือก โปรแกรมจะ copy ให้ทั้งบรรทัด
            // จากนั้นกด Ctrl+V จะเป็นการวางทั้งบรรทัด
            Console.WriteLine("This is text 1.");
            Console.WriteLine("This is text 2.");
            Console.WriteLine("This is text 3.");

            // ใน string ของภาษา C# มีความสามารถในการเพิ่ม field ที่จะแสดงผล
            // เรียกว่า place holder ที่รับอินพุตเข้าสู่ place holder
            // โดย Console.Write จะตรวจสอบชนิดข้อมูลและแสดงผลให้ตรงตามชนิด
            // โดยที่เราไม่ต้องท่องจำเหมือนในภาษา C, C++

            Console.WriteLine("The number are {0} and {1}", 3, 6);
        }
    }
}
