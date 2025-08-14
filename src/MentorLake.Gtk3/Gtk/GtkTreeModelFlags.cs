namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// These flags indicate various properties of a #GtkTreeModel.
/// </para>
/// <para>
/// They are returned by gtk_tree_model_get_flags(), and must be
/// static for the lifetime of the object. A more complete description
/// of #GTK_TREE_MODEL_ITERS_PERSIST can be found in the overview of
/// this section.
/// </para>
/// </summary>

[Flags]
public enum GtkTreeModelFlags : uint
{
/// <summary>
/// <para>
/// iterators survive all signals
///     emitted by the tree
/// </para>
/// </summary>

	GTK_TREE_MODEL_ITERS_PERSIST = 1,
/// <summary>
/// <para>
/// the model is a list only, and never
///     has children
/// </para>
/// </summary>

	GTK_TREE_MODEL_LIST_ONLY = 2
}
