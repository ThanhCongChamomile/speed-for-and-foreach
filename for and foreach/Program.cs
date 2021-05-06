using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_and_foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            #region tốc độ 2 loop trong mảng 1 chiều (có khả năng truy suất ngẫu nhiên)
            /* Kiểm tra tốc độ của for */

            /*
                         * Sử dụng 1 cái đồng hồ để đo thời gian chạy của 2 vòng lặp for và foreach
                         * Ở đây mình chỉ kiểm tra tốc độ chứ không tập trung giải thích cú pháp
                         * Các bạn có thể tìm hiểu thêm.
                         */
            //Stopwatch start = new Stopwatch();
            //start.Start();

            //int[] IntArray = new int[Int32.MaxValue / 100];
            //int s = 0;
            //int Length = IntArray.Length;
            //for (int i = 0; i < Length; i++)
            //{
            //    s += IntArray[i];
            //}

            //start.Stop();
            //Console.WriteLine(" Thoi gian chay cua for: {0} giay {1} mili giay", start.Elapsed.Seconds, start.Elapsed.Milliseconds);

            ///* Kiểm tra tốc độ của foreach */
            //Stopwatch start2 = new Stopwatch();
            //start2.Start();

            //int[] IntArray2 = new int[Int32.MaxValue / 100];
            //int s2 = 0;

            //foreach (int item in IntArray2)
            //{
            //    s2 += item;
            //}

            //start2.Stop();
            //Console.WriteLine(" Thoi gian chay cua foreach: {0} giay {1} mili giay", start2.Elapsed.Seconds, start2.Elapsed.Milliseconds);

            //Console.ReadKey();
            #endregion

            #region tốc độ duyệt qua 1 list (ko có khả năng truy xuất ngẫu nhiên)
            /*
             * Khai báo 1 LinkedList chưa các số nguyên int và khởi tạo giá trị cho nó.
             */
            LinkedList<int> list = new LinkedList<int>();

            for (int i = 0; i < 100000; i++)
            {
                list.AddLast(i);
            }

            /* Kiểm tra tốc độ của for */
            Stopwatch st = new Stopwatch();
            int s1 = 0, length = list.Count;
            st.Start();
            for (int i = 0; i < length; i++)
            {
                /*
                 * Vì LinkedList không thể truy xuất thông qua chỉ số phần tử
                 * nên mình phải sử dụng 1 phương thức hỗ trợ làm điều này.
                 * Và đây chính là sự hạn chế của for đối với các cấu trúc dữ liệu tương tự như danh sách liên kết này.
                 */
                s1 += list.ElementAt(i);
            }
            st.Stop();

            /* Kiểm tra tốc độ của foreach */
            Stopwatch st3 = new Stopwatch();
            int s3 = 0;
            st3.Start();
            foreach (int item in list)
            {
                /*
                 * Vì foreach không quan tâm đến chỉ số phần tử nên code viết rất ngắn gọn
                 */
                s3 += item;
            }
            st3.Stop();

            /* In ra giá trị tính tổng giá trị các phần tử khi duyệt bằng for và foreach để chắc chắn rằng cả 2 đều chạy đúng */
            Console.WriteLine(" s1 = {0}   s2 = {1}", s1, s3);
            Console.WriteLine(" Thoi gian chay cua for = {0} giay {1} mili giay", st.Elapsed.Seconds, st.Elapsed.Milliseconds);
            Console.WriteLine(" Thoi gian chay cua foreach = {0} giay {1} mini giay", st3.Elapsed.Seconds, st3.Elapsed.Milliseconds);

            Console.ReadKey();

            #endregion
        }
    }
}
