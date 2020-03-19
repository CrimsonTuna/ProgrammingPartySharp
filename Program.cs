using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingParty
{
    class Program
    {
        static void Main(string[] args)
        {
            // 実行時間計測用
            Stopwatch watch = new Stopwatch();

            try
            {
                // 処理プログラムの選択
                IProgrammingParty party = new SimpleParty();

                // 入力値の生成
                IEnumerable<int> source = Enumerable.Range(1, 100);

                // 計測開始
                watch.Start();

                // 処理開始
                party.Start(source);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                // 計測終了
                watch.Stop();

                Console.WriteLine($"Processing Time = {watch.ElapsedMilliseconds} [msec]");
                Console.WriteLine("Press Any Key To Exit..");
                Console.ReadKey();
            }
        }
    }
}
