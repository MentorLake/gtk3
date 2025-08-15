namespace MentorLake.GLib;

/// <summary>
/// <para>
/// Specifies the type of traversal performed by g_tree_traverse(),
/// g_node_traverse() and g_node_find().
/// </para>
/// <para>
/// The different orders are illustrated here:
/// </para>
/// <para>
/// - In order: A, B, C, D, E, F, G, H, I
///   &amp;lt;picture&amp;gt;
///     &amp;lt;source srcset=&quot;Sorted_binary_tree_inorder-dark.svg&quot;
///      media=&quot;(prefers-color-scheme: dark)&quot;&amp;gt;
///     &amp;lt;img src=&quot;Sorted_binary_tree_inorder.svg&quot;
///      alt=&quot;Sorted binary tree, in-order traversal&quot;&amp;gt;
///   &amp;lt;/picture&amp;gt;
/// - Pre order: F, B, A, D, C, E, G, I, H
///   &amp;lt;picture&amp;gt;
///     &amp;lt;source srcset=&quot;Sorted_binary_tree_preorder-dark.svg&quot;
///      media=&quot;(prefers-color-scheme: dark)&quot;&amp;gt;
///     &amp;lt;img src=&quot;Sorted_binary_tree_preorder.svg&quot;
///      alt=&quot;Sorted binary tree, pre-order traversal&quot;&amp;gt;
///   &amp;lt;/picture&amp;gt;
/// - Post order: A, C, E, D, B, H, I, G, F
///   &amp;lt;picture&amp;gt;
///     &amp;lt;source srcset=&quot;Sorted_binary_tree_postorder-dark.svg&quot;
///      media=&quot;(prefers-color-scheme: dark)&quot;&amp;gt;
///     &amp;lt;img src=&quot;Sorted_binary_tree_postorder.svg&quot;
///      alt=&quot;Sorted binary tree, post-order traversal&quot;&amp;gt;
///   &amp;lt;/picture&amp;gt;
/// - Level order: F, B, G, A, D, I, C, E, H
///   &amp;lt;picture&amp;gt;
///     &amp;lt;source srcset=&quot;Sorted_binary_tree_breadth-first_traversal-dark.svg&quot;
///      media=&quot;(prefers-color-scheme: dark)&quot;&amp;gt;
///     &amp;lt;img src=&quot;Sorted_binary_tree_breadth-first_traversal.svg&quot;
///      alt=&quot;Sorted binary tree, breadth-first level order traversal&quot;&amp;gt;
///   &amp;lt;/picture&amp;gt;
/// </para>
/// </summary>

[Flags]
public enum GTraverseType
{
/// <summary>
/// <para>
/// vists a node&apos;s left child first, then the node itself,
///              then its right child. This is the one to use if you
///              want the output sorted according to the compare
///              function.
/// </para>
/// </summary>

	G_IN_ORDER = 0,
/// <summary>
/// <para>
/// visits a node, then its children.
/// </para>
/// </summary>

	G_PRE_ORDER = 1,
/// <summary>
/// <para>
/// visits the node&apos;s children, then the node itself.
/// </para>
/// </summary>

	G_POST_ORDER = 2,
/// <summary>
/// <para>
/// is not implemented for
///              [balanced binary trees][glib-Balanced-Binary-Trees].
///              For [n-ary trees][glib-N-ary-Trees], it
///              vists the root node first, then its children, then
///              its grandchildren, and so on. Note that this is less
///              efficient than the other orders.
/// </para>
/// </summary>

	G_LEVEL_ORDER = 3
}
