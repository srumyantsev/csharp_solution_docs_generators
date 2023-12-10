using System.Linq;

namespace SolutionFoldersProjectsTree;

//https://stackoverflow.com/questions/19648166/nice-universal-way-to-convert-list-of-items-to-tree
//https://stackoverflow.com/questions/66893/tree-data-structure-in-c-sharp
public class TreeItem<T>
{
    public T Item { get; set; }
    public IEnumerable<TreeItem<T>> Children { get; set; }
}

public static class TreeHelpers
{
    /// <summary>
    /// Generates tree of items from item list
    /// </summary>
    /// 
    /// <typeparam name="T">Type of item in collection</typeparam>
    /// <typeparam name="K">Type of parent_id</typeparam>
    /// 
    /// <param name="collection">Collection of items</param>
    /// <param name="id_selector">Function extracting item's id</param>
    /// <param name="parent_ids_selector">Function extracting item's parent_ids</param>
    /// <param name="root_id">Root element id</param>
    /// 
    /// <returns>Tree of items</returns>
    public static IEnumerable<TreeItem<T>> GenerateTree<T, K, S>(
        this IEnumerable<T> collection,
        Func<T, K> id_selector,
        Func<T, IEnumerable<K>> parent_ids_selector,
        K root_id = default,
        Func<T, S>? sortFunc = default)
    {
        Func<T, bool> parentSelectorPredicate = c =>
            root_id != null ? parent_ids_selector(c).Contains(root_id) : !parent_ids_selector(c).Any();
        foreach (var c in collection.Where(parentSelectorPredicate).OrderBy(sortFunc))
        {
            yield return new TreeItem<T>
            {
                Item = c,
                Children = collection.GenerateTree(id_selector, parent_ids_selector, id_selector(c), sortFunc).ToList()
            };
        }
    }

    //public static void Visit2<T>(this IEnumerable<TreeItem<T>> tree, Action<TreeItem<T>> visitor) {
    //	foreach (TreeItem<T> rootTreeItem in tree) {
    //		Visit2(rootTreeItem, visitor);
    //	}
    //}

    //private static void Visit2<T>(TreeItem<T> treeItem, Action<TreeItem<T>> visitor) {
    //	visitor(treeItem);
    //	foreach (TreeItem<T> treeItemChild in treeItem.Children) {
    //		Visit2(treeItemChild, visitor);
    //	}
    //}

    public static void Visit<T>(this IEnumerable<TreeItem<T>> tree, Action<TreeItem<T>, TreeItem<T>?, int> visitor,
        TreeItem<T>? parentTreeItem = null, int depth = 1)
    {
        foreach (TreeItem<T> treeItem in tree)
        {
            visitor(treeItem, parentTreeItem, depth);
            Visit(treeItem.Children, visitor, treeItem, depth + 1);
        }
    }

    public static IEnumerable<TreeItem<T2>> CopyTree<T1, T2>(this IEnumerable<TreeItem<T1>> sourceTree,
        Func<T1, T2> typeCreator)
    {
        foreach (TreeItem<T1> sourceTreeItem in sourceTree)
        {
            T2 targetItem = typeCreator(sourceTreeItem.Item);
            yield return new TreeItem<T2>
            {
                Item = targetItem,
                Children = sourceTreeItem.Children.CopyTree(typeCreator).ToList()
            };
        }
    }
}