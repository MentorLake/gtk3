namespace MentorLake.GLib;

/// <summary>
/// <para>
/// Specifies which nodes are visited during several of the tree
/// functions, including g_node_traverse() and g_node_find().
/// </para>
/// </summary>

[Flags]
public enum GTraverseFlags : uint
{
/// <summary>
/// <para>
/// only leaf nodes should be visited. This name has
///                     been introduced in 2.6, for older version use
///                     %G_TRAVERSE_LEAFS.
/// </para>
/// </summary>

	G_TRAVERSE_LEAVES = 1,
/// <summary>
/// <para>
/// only non-leaf nodes should be visited. This
///                         name has been introduced in 2.6, for older
///                         version use %G_TRAVERSE_NON_LEAFS.
/// </para>
/// </summary>

	G_TRAVERSE_NON_LEAVES = 2,
/// <summary>
/// <para>
/// all nodes should be visited.
/// </para>
/// </summary>

	G_TRAVERSE_ALL = 3,
/// <summary>
/// <para>
/// a mask of all traverse flags.
/// </para>
/// </summary>

	G_TRAVERSE_MASK = 3,
/// <summary>
/// <para>
/// identical to %G_TRAVERSE_LEAVES.
/// </para>
/// </summary>

	G_TRAVERSE_LEAFS = 1,
/// <summary>
/// <para>
/// identical to %G_TRAVERSE_NON_LEAVES.
/// </para>
/// </summary>

	G_TRAVERSE_NON_LEAFS = 2
}
