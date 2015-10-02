using System;
using System.Collections.Generic;   // ไม่ได้ใช้ประโยชน์ ใน Lab นี้
using System.Linq;                  // ไม่ได้ใช้ประโยชน์ ใน Lab นี้
using System.Text;                  // ไม่ได้ใช้ประโยชน์ ใน Lab นี้
using System.Threading.Tasks;       // ไม่ได้ใช้ประโยชน์ ใน Lab นี้
// ใบงานที่ 4 ศึกษาเรื่องการใช้งาน Console.Write
// และคำสั่ง Console.WriteLine อย่างง่ายๆ
namespace Lab4 
{
    class Program

    {
        static void Main(string[] args)
        {
            // การเขียน Control.WriteLine มีวิธีลัดคือ
            // พิมพ์ cw แล้วกดปุ่ม Tab 2 ครั้ง
            Console.Write ("Hello ");
            Console.WriteLine("World!");

            // การรันโปรแกรมโดยให้หน้าจอ Console ยังคงค้างอยู่ ไม่หายไป
            // ทำได้โดยการกด Ctrl+F5
            // หรือเลือกเมนู Debug->Start without debugging


        }
    }
}
