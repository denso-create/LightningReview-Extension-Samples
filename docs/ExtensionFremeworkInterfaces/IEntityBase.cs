using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LightningReview.ExtensionFramework.LightningReview.Host;

namespace LightningReview.ExtensionFramework
{
	/// <summary>
	/// 各エンティティに共通するプロパティの編集を実現するインターフェース
	/// </summary>
	public interface IEntityBase 
	{
		#region プロパティ

		/// <summary>
		/// グローバルID
		/// 
		/// オブジェクトを一意に識別するためのID
		/// アプリケーション側でインスタンス生成ごとに割り当てて、永遠に変更しない。
		/// レビューファイルのマージで、同一インスタンスを識別するために使用する。
		/// </summary>
		string GID { get; }

		/// <summary>
		/// ローカルID
		/// 
		/// ユーザがオブジェクトを識別するために使用するID
		/// インスタンス作成直後は不定値（ユーザには表示せず、内部的には定数値）とし、
		/// ファイルへ保存した時点で、ファイル内でユニークな連番を割り当てる。
		/// 
		/// レビューごとに、そのデータ種別に対するユニーク性を保証する。
		/// つまり、あるレビューで同じLIDをもつエンティティは、データ種別ごとに最大1つである。
		/// データを削除した場合、そのLIDは欠番として再利用しない。
		/// 最大のLIDをもつデータを削除した場合でも、再利用はしない。
		/// （つまり、過去に割り当てた最大値＋１を割り当てる）
		/// </summary>
		string Id { get; set; }

		/// <summary>
		/// 作成者
		/// </summary>
		string CreatedBy { get; set; }

		/// <summary>
		/// 作成日時
		/// </summary>
		DateTime? CreatedDateTime { get; set; }

		/// <summary>
		/// 最終更新者
		/// </summary>
		string LastUpdatedBy { get; set; }

		/// <summary>
		/// 最終更新日時
		/// </summary>
		DateTime? LastUpdatedDateTime { get; set; }

		/// <summary>
		/// メタデータのコレクション
		/// </summary>
		IEnumerable<IMetaData> MetaDatas {get;}

		#endregion

		#region 公開サービス

		/// <summary>
		/// 指定したキーのメタデータを設定する。
		/// すでにキーが存在している場合いは上書きする。
		/// </summary>
		/// <param name="key">キー</param>
		/// <param name="value">値</param>
		/// <param name="encrypt">値を暗号化するか(値がstring型の場合のみ暗号化可能)</param>
		/// <returns>設定したメタデータ</returns>
		IMetaData SetMetaData(string key, object value, bool encrypt = false);

		/// <summary>
		/// 指定したキーのメタデータを取得する。
		/// </summary>
		/// <param name="key">キー</param>
		/// <param name="defaultValue">値が取得できなかった場合の値</param>
		/// <param name="decrypt">値を復号化するか</param>
		/// <returns>取得する値</returns>
		T GetMetaData<T>(string key, T defaultValue = default, bool decrypt = false);

		/// <summary>
		/// 指定したキーのメタデータを削除する。
		/// キーが存在しなければfalseを返す。
		/// </summary>
		/// <param name="key">キー</param>
		/// <returns>削除を実行したか</returns>
		bool RemoveMetaData(string key);

		#endregion
	}
}