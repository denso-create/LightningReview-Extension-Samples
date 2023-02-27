using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightningReview.ExtensionFramework.LightningReview
{
    /// <summary>
    /// エンティティのコレクションの操作を実現するインタフェースです。
    /// </summary>
    public interface IEntityCollection<T> : IEnumerable<T> where T : IEntityBase
    {
        /// <summary>
        /// エンティティをコレクションに追加します。
        /// </summary>
        /// <returns>追加したエンティティ。</returns>
	    T Add();

        /// <summary>
        /// エンティティをコレクションから削除します。
        /// </summary>
        /// <param name="entity">削除するエンティティ。</param>
        void Remove(T entity);

        /// <summary>
        /// インデックスを指定してエンティティをコレクションから削除します。
        /// </summary>
        /// <param name="index">削除するエンティティのインデックス。</param>
	    void RemoveAt(int index);
    }
}
