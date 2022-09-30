using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightningReview.ExtensionFramework.LightningReview.Host
{
	/// <summary>
	/// エンティティのメタデータを取得・更新するインターフェイス
	/// </summary>
	public interface IMetaData
	{
		#region プロパティ

		/// <summary>
		/// キー
		/// </summary>
		string Key {get;}

		/// <summary>
		/// 暗号化されているか
		/// </summary>
		bool Encrypted {get;}
		
		#endregion

		#region 公開サービス

		/// <summary>
		/// 値を設定する
		/// </summary>
		/// <param name="value">設定する値</param>
		/// <param name="encrypt">値を暗号化するか(値がstring型の場合のみ暗号化可能)</param>
		void SetValue(object value, bool encrypt = false);

		/// <summary>
		/// 型を指定して値を取得する
		/// </summary>
		/// <typeparam name="T">取得する型</typeparam>
		/// <param name="defaultValue">値が取得できなかった場合の値</param>
		/// <param name="decrypt">値を復号化するか</param>
		/// <returns>取得する値</returns>
		T GetValue<T>(T defaultValue = default, bool decrypt = false);

		#endregion
	}
}
