using System;
using System.Text.Json.Serialization;

namespace DensoCreate.TutorialExtension.Model
{
	/// <summary>
	/// 本エクステンションにおけるチュートリアル用の設定値を保持する
	/// </summary>
	public class TutorialSettings
	{
		/// <summary>
		/// メッセージ
		/// </summary>
		[JsonPropertyName("message")]
		public string Message { get; set; } = "Hello";

		/// <summary>
		/// 日付
		/// </summary>
		[JsonPropertyName("date")]
		public DateTime? Date { get; set; }
	}
}
