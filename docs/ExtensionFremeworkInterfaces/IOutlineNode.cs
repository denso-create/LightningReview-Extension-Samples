using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LightningReview.ExtensionFramework.LightningReview;

namespace LightningReview.ExtensionFramework
{
	/// <summary>
	/// アウトラインの編集を実現するインタフェース
	/// </summary>
	public interface IOutlineNode : IEntityBase
	{
		#region 公開プロパティ

		/// <summary>
		/// ノード名
		/// </summary>
		string Name { get; set; }

		/// <summary>
		/// ドキュメントにおける物理位置をXML形式で表現したもの
		/// </summary>
		string PhysicalLocationXml { get; set; }

		/// <summary>
		/// ノードパス
		/// トップレベルからのノード名をデリミタ "/" で結合した文字列です。
		/// 文字列の先頭にもデリミタが付きます。
		/// デリミタで区切られた最初のノード名は必ずドキュメント名になります。
		/// <example>
		/// 以下の親子階層になっている場合、ノードパスは "/AAA/BBB/CCC" となります。
		/// 　AAA -> BBB -> CCC
		/// </example>
		/// </summary>
		string Path { get; }

		/// <summary>
		/// アウトラインレベル
		/// トップレベルを１とした深さを表します。
		/// </summary>
		int Level { get; }

		/// <summary>
		/// このノードが属するドキュメント
		/// </summary>
		IDocument Document { get; }

		/// <summary>
		/// 親ノード
		/// nullの場合はルートレベルのノードです。
		/// </summary>
		IOutlineNode Parent { get; }

		/// <summary>
		/// 子ノードのアウトライン順コレクション
		/// </summary>
		IEnumerable<IOutlineNode> ChildNodes { get; }

		/// <summary>
		/// このノードに関連付いている指摘のコレクション
		/// </summary>
		IEnumerable<IIssue> Issues { get; }

		#endregion

		#region 公開メソッド

		/// <summary>
		/// 子にアウトラインを追加する
		/// </summary>
		/// <param name="nodeName"></param>
		/// <returns></returns>
		IOutlineNode AddChild(string nodeName);

		/// <summary>
		/// ドキュメントにおける物理位置を指定して、子にアウトラインを追加する
		/// </summary>
		/// <param name="nodeName"></param>
		/// <param name="physicalLocationXml"></param>
		/// <returns></returns>
		IOutlineNode AddChild(string nodeName, string physicalLocationXml);

		/// <summary>
		/// 子ノードを削除
		/// </summary>
		/// <param name="child"></param>
		void DeleteChild(IOutlineNode child);

		/// <summary>
		/// 子ノードをすべてクリア
		/// </summary>
		void ClearChildren();

		/// <summary>
		/// 指摘を追加する
		/// </summary>
		/// <returns>指摘</returns>
		IIssue AddIssue();

		#endregion

	}
}