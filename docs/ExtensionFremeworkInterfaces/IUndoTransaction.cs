using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightningReview.ExtensionFramework.LightningReview
{
	/// <summary>
	/// アンドゥのトランザクションを実現するインターフェース
	/// </summary>
	public interface IUndoTransaction : IDisposable
	{
		#region 公開サービス

		/// <summary>
		/// トランザクションを開始してからの編集をコミットします
		/// </summary>
		void Commit();

		/// <summary>
		/// トランザクションを開始してからの編集をロールバックします
		/// </summary>
		void Rollback();

		#endregion
	}
}
