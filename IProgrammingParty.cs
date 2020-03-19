using System.Collections.Generic;

namespace ProgrammingParty
{
    /// <summary>
    /// メインメソッドの処理を共通化させるための基本インタフェース
    /// </summary>
    public interface IProgrammingParty
    {
        /// <summary>
        /// 本メソッド内でConsole.Write(Concole.WriteLine)で出力してください。
        /// </summary>
        /// <param name="src">入力データ</param>
        void Start(IEnumerable<int> src);
    }
}
