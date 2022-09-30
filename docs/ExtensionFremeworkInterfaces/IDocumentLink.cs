using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightningReview.ExtensionFramework.LightningReview
{
    /// <summary>
    /// ドキュメントの関連リンクの編集を実現するインタフェースです。
    /// </summary>
    public interface IDocumentLink : IEntityBase
    {
        /// <summary>
        /// ドキュメントの関連リンクの名前です。
        /// </summary>
        /// <value>リンク名の文字列。</value>
        string Name { get; set; }

        /// <summary>
        /// ドキュメントの関連リンクのパスです。
        /// </summary>
        /// <value>リンクの絶対パスの文字列。</value>
        string Path { get; set; }

        /// <summary>
        /// ドキュメントの関連リンクのタグです。
        /// </summary>
        /// <remarks>
        /// タグはAPIでのみ設定可能です。
        /// UIでは設定することができません。
        /// </remarks>
        /// <value>リンクのタグの文字列。</value>
        string Tag { get; set; }
    }
}
