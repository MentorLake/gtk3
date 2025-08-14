namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// The #GtkTreeModel interface defines a generic tree interface for
/// use by the #GtkTreeView widget. It is an abstract interface, and
/// is designed to be usable with any appropriate data structure. The
/// programmer just has to implement this interface on their own data
/// type for it to be viewable by a #GtkTreeView widget.
/// </para>
/// <para>
/// The model is represented as a hierarchical tree of strongly-typed,
/// columned data. In other words, the model can be seen as a tree where
/// every node has different values depending on which column is being
/// queried. The type of data found in a column is determined by using
/// the GType system (ie. #G_TYPE_INT, #GTK_TYPE_BUTTON, #G_TYPE_POINTER,
/// etc). The types are homogeneous per column across all nodes. It is
/// important to note that this interface only provides a way of examining
/// a model and observing changes. The implementation of each individual
/// model decides how and if changes are made.
/// </para>
/// <para>
/// In order to make life simpler for programmers who do not need to
/// write their own specialized model, two generic models are provided
/// — the #GtkTreeStore and the #GtkListStore. To use these, the
/// developer simply pushes data into these models as necessary. These
/// models provide the data structure as well as all appropriate tree
/// interfaces. As a result, implementing drag and drop, sorting, and
/// storing data is trivial. For the vast majority of trees and lists,
/// these two models are sufficient.
/// </para>
/// <para>
/// Models are accessed on a node/column level of granularity. One can
/// query for the value of a model at a certain node and a certain
/// column on that node. There are two structures used to reference a
/// particular node in a model. They are the #GtkTreePath-struct and
/// the #GtkTreeIter-struct (“iter” is short for iterator). Most of the
/// interface consists of operations on a #GtkTreeIter-struct.
/// </para>
/// <para>
/// A path is essentially a potential node. It is a location on a model
/// that may or may not actually correspond to a node on a specific
/// model. The #GtkTreePath-struct can be converted into either an
/// array of unsigned integers or a string. The string form is a list
/// of numbers separated by a colon. Each number refers to the offset
/// at that level. Thus, the path `0` refers to the root
/// node and the path `2:4` refers to the fifth child of
/// the third node.
/// </para>
/// <para>
/// By contrast, a #GtkTreeIter-struct is a reference to a specific node on
/// a specific model. It is a generic struct with an integer and three
/// generic pointers. These are filled in by the model in a model-specific
/// way. One can convert a path to an iterator by calling
/// gtk_tree_model_get_iter(). These iterators are the primary way
/// of accessing a model and are similar to the iterators used by
/// #GtkTextBuffer. They are generally statically allocated on the
/// stack and only used for a short time. The model interface defines
/// a set of operations using them for navigating the model.
/// </para>
/// <para>
/// It is expected that models fill in the iterator with private data.
/// For example, the #GtkListStore model, which is internally a simple
/// linked list, stores a list node in one of the pointers. The
/// #GtkTreeModelSort stores an array and an offset in two of the
/// pointers. Additionally, there is an integer field. This field is
/// generally filled with a unique stamp per model. This stamp is for
/// catching errors resulting from using invalid iterators with a model.
/// </para>
/// <para>
/// The lifecycle of an iterator can be a little confusing at first.
/// Iterators are expected to always be valid for as long as the model
/// is unchanged (and doesn’t emit a signal). The model is considered
/// to own all outstanding iterators and nothing needs to be done to
/// free them from the user’s point of view. Additionally, some models
/// guarantee that an iterator is valid for as long as the node it refers
/// to is valid (most notably the #GtkTreeStore and #GtkListStore).
/// Although generally uninteresting, as one always has to allow for
/// the case where iterators do not persist beyond a signal, some very
/// important performance enhancements were made in the sort model.
/// As a result, the #GTK_TREE_MODEL_ITERS_PERSIST flag was added to
/// indicate this behavior.
/// </para>
/// <para>
/// To help show some common operation of a model, some examples are
/// provided. The first example shows three ways of getting the iter at
/// the location `3:2:5`. While the first method shown is
/// easier, the second is much more common, as you often get paths from
/// callbacks.
/// </para>
/// <para>
/// ## Acquiring a #GtkTreeIter-struct
/// </para>
/// <para>
/// |[<!-- language="C" -->
/// // Three ways of getting the iter pointing to the location
/// GtkTreePath *path;
/// GtkTreeIter iter;
/// GtkTreeIter parent_iter;
/// </para>
/// <para>
/// // get the iterator from a string
/// gtk_tree_model_get_iter_from_string (model,
///                                      &iter,
///                                      "3:2:5");
/// </para>
/// <para>
/// // get the iterator from a path
/// path = gtk_tree_path_new_from_string ("3:2:5");
/// gtk_tree_model_get_iter (model, &iter, path);
/// gtk_tree_path_free (path);
/// </para>
/// <para>
/// // walk the tree to find the iterator
/// gtk_tree_model_iter_nth_child (model, &iter,
///                                NULL, 3);
/// parent_iter = iter;
/// gtk_tree_model_iter_nth_child (model, &iter,
///                                &parent_iter, 2);
/// parent_iter = iter;
/// gtk_tree_model_iter_nth_child (model, &iter,
///                                &parent_iter, 5);
/// ]|
/// </para>
/// <para>
/// This second example shows a quick way of iterating through a list
/// and getting a string and an integer from each row. The
/// populate_model() function used below is not
/// shown, as it is specific to the #GtkListStore. For information on
/// how to write such a function, see the #GtkListStore documentation.
/// </para>
/// <para>
/// ## Reading data from a #GtkTreeModel
/// </para>
/// <para>
/// |[<!-- language="C" -->
/// enum
/// {
///   STRING_COLUMN,
///   INT_COLUMN,
///   N_COLUMNS
/// };
/// </para>
/// <para>
/// ...
/// </para>
/// <para>
/// GtkTreeModel *list_store;
/// GtkTreeIter iter;
/// gboolean valid;
/// gint row_count = 0;
/// </para>
/// <para>
/// // make a new list_store
/// list_store = gtk_list_store_new (N_COLUMNS,
///                                  G_TYPE_STRING,
///                                  G_TYPE_INT);
/// </para>
/// <para>
/// // Fill the list store with data
/// populate_model (list_store);
/// </para>
/// <para>
/// // Get the first iter in the list, check it is valid and walk
/// // through the list, reading each row.
/// </para>
/// <para>
/// valid = gtk_tree_model_get_iter_first (list_store,
///                                        &iter);
/// while (valid)
///  {
///    gchar *str_data;
///    gint   int_data;
/// </para>
/// <para>
///    // Make sure you terminate calls to gtk_tree_model_get() with a “-1” value
///    gtk_tree_model_get (list_store, &iter,
///                        STRING_COLUMN, &str_data,
///                        INT_COLUMN, &int_data,
///                        -1);
/// </para>
/// <para>
///    // Do something with the data
///    g_print ("Row %d: (%s,%d)\n",
///             row_count, str_data, int_data);
///    g_free (str_data);
/// </para>
/// <para>
///    valid = gtk_tree_model_iter_next (list_store,
///                                      &iter);
///    row_count++;
///  }
/// ]|
/// </para>
/// <para>
/// The #GtkTreeModel interface contains two methods for reference
/// counting: gtk_tree_model_ref_node() and gtk_tree_model_unref_node().
/// These two methods are optional to implement. The reference counting
/// is meant as a way for views to let models know when nodes are being
/// displayed. #GtkTreeView will take a reference on a node when it is
/// visible, which means the node is either in the toplevel or expanded.
/// Being displayed does not mean that the node is currently directly
/// visible to the user in the viewport. Based on this reference counting
/// scheme a caching model, for example, can decide whether or not to cache
/// a node based on the reference count. A file-system based model would
/// not want to keep the entire file hierarchy in memory, but just the
/// folders that are currently expanded in every current view.
/// </para>
/// <para>
/// When working with reference counting, the following rules must be taken
/// into account:
/// </para>
/// <para>
/// - Never take a reference on a node without owning a reference on its parent.
///   This means that all parent nodes of a referenced node must be referenced
///   as well.
/// </para>
/// <para>
/// - Outstanding references on a deleted node are not released. This is not
///   possible because the node has already been deleted by the time the
///   row-deleted signal is received.
/// </para>
/// <para>
/// - Models are not obligated to emit a signal on rows of which none of its
///   siblings are referenced. To phrase this differently, signals are only
///   required for levels in which nodes are referenced. For the root level
///   however, signals must be emitted at all times (however the root level
///   is always referenced when any view is attached).
/// </para>
/// </summary>

public interface GtkTreeModelHandle
{
	public bool IsInvalid { get; }
	public bool IsClosed { get; }
}

internal class GtkTreeModelHandleImpl : BaseSafeHandle, GtkTreeModelHandle
{
}

public static class GtkTreeModelHandleExtensions
{
/// <summary>
/// <para>
/// Creates a new #GtkTreeModel, with @child_model as the child_model
/// and @root as the virtual root.
/// </para>
/// </summary>

/// <param name="child_model">
/// A #GtkTreeModel.
/// </param>
/// <param name="root">
/// A #GtkTreePath or %NULL.
/// </param>
/// <return>
/// A new #GtkTreeModel.
/// </return>

	public static MentorLake.Gtk.GtkTreeModelHandle FilterNew(this MentorLake.Gtk.GtkTreeModelHandle child_model, MentorLake.Gtk.GtkTreePathHandle root)
	{
		if (child_model.IsInvalid) throw new Exception("Invalid handle (GtkTreeModelHandle)");
		return GtkTreeModelHandleExterns.gtk_tree_model_filter_new(child_model, root);
	}

/// <summary>
/// <para>
/// Calls func on each node in model in a depth-first fashion.
/// </para>
/// <para>
/// If @func returns %TRUE, then the tree ceases to be walked,
/// and gtk_tree_model_foreach() returns.
/// </para>
/// </summary>

/// <param name="model">
/// a #GtkTreeModel
/// </param>
/// <param name="func">
/// a function to be called on each row
/// </param>
/// <param name="user_data">
/// user data to passed to @func
/// </param>

	public static T Foreach<T>(this T model, MentorLake.Gtk.GtkTreeModelForeachFunc func, IntPtr user_data) where T : GtkTreeModelHandle
	{
		if (model.IsInvalid) throw new Exception("Invalid handle (GtkTreeModelHandle)");
		GtkTreeModelHandleExterns.gtk_tree_model_foreach(model, func, user_data);
		return model;
	}

/// <summary>
/// <para>
/// Gets the value of one or more cells in the row referenced by @iter.
/// The variable argument list should contain integer column numbers,
/// each column number followed by a place to store the value being
/// retrieved.  The list is terminated by a -1. For example, to get a
/// value from column 0 with type %G_TYPE_STRING, you would
/// write: `gtk_tree_model_get (model, iter, 0, &place_string_here, -1)`,
/// where `place_string_here` is a #gchararray
/// to be filled with the string.
/// </para>
/// <para>
/// Returned values with type %G_TYPE_OBJECT have to be unreferenced,
/// values with type %G_TYPE_STRING or %G_TYPE_BOXED have to be freed.
/// Other values are passed by value.
/// </para>
/// </summary>

/// <param name="tree_model">
/// a #GtkTreeModel
/// </param>
/// <param name="iter">
/// a row in @tree_model
/// </param>
/// <param name="@__arglist">
/// pairs of column number and value return locations,
///     terminated by -1
/// </param>

	public static T Get<T>(this T tree_model, MentorLake.Gtk.GtkTreeIterHandle iter, IntPtr @__arglist) where T : GtkTreeModelHandle
	{
		if (tree_model.IsInvalid) throw new Exception("Invalid handle (GtkTreeModelHandle)");
		GtkTreeModelHandleExterns.gtk_tree_model_get(tree_model, iter, @__arglist);
		return tree_model;
	}

/// <summary>
/// <para>
/// Returns the type of the column.
/// </para>
/// </summary>

/// <param name="tree_model">
/// a #GtkTreeModel
/// </param>
/// <param name="index_">
/// the column index
/// </param>
/// <return>
/// the type of the column
/// </return>

	public static MentorLake.GObject.GType GetColumnType(this MentorLake.Gtk.GtkTreeModelHandle tree_model, int index_)
	{
		if (tree_model.IsInvalid) throw new Exception("Invalid handle (GtkTreeModelHandle)");
		return GtkTreeModelHandleExterns.gtk_tree_model_get_column_type(tree_model, index_);
	}

/// <summary>
/// <para>
/// Returns a set of flags supported by this interface.
/// </para>
/// <para>
/// The flags are a bitwise combination of #GtkTreeModelFlags.
/// The flags supported should not change during the lifetime
/// of the @tree_model.
/// </para>
/// </summary>

/// <param name="tree_model">
/// a #GtkTreeModel
/// </param>
/// <return>
/// the flags supported by this interface
/// </return>

	public static MentorLake.Gtk.GtkTreeModelFlags GetFlags(this MentorLake.Gtk.GtkTreeModelHandle tree_model)
	{
		if (tree_model.IsInvalid) throw new Exception("Invalid handle (GtkTreeModelHandle)");
		return GtkTreeModelHandleExterns.gtk_tree_model_get_flags(tree_model);
	}

/// <summary>
/// <para>
/// Sets @iter to a valid iterator pointing to @path.  If @path does
/// not exist, @iter is set to an invalid iterator and %FALSE is returned.
/// </para>
/// </summary>

/// <param name="tree_model">
/// a #GtkTreeModel
/// </param>
/// <param name="iter">
/// the uninitialized #GtkTreeIter-struct
/// </param>
/// <param name="path">
/// the #GtkTreePath-struct
/// </param>
/// <return>
/// %TRUE, if @iter was set
/// </return>

	public static bool GetIter(this MentorLake.Gtk.GtkTreeModelHandle tree_model, out MentorLake.Gtk.GtkTreeIter iter, MentorLake.Gtk.GtkTreePathHandle path)
	{
		if (tree_model.IsInvalid) throw new Exception("Invalid handle (GtkTreeModelHandle)");
		return GtkTreeModelHandleExterns.gtk_tree_model_get_iter(tree_model, out iter, path);
	}

/// <summary>
/// <para>
/// Initializes @iter with the first iterator in the tree
/// (the one at the path "0") and returns %TRUE. Returns
/// %FALSE if the tree is empty.
/// </para>
/// </summary>

/// <param name="tree_model">
/// a #GtkTreeModel
/// </param>
/// <param name="iter">
/// the uninitialized #GtkTreeIter-struct
/// </param>
/// <return>
/// %TRUE, if @iter was set
/// </return>

	public static bool GetIterFirst(this MentorLake.Gtk.GtkTreeModelHandle tree_model, out MentorLake.Gtk.GtkTreeIter iter)
	{
		if (tree_model.IsInvalid) throw new Exception("Invalid handle (GtkTreeModelHandle)");
		return GtkTreeModelHandleExterns.gtk_tree_model_get_iter_first(tree_model, out iter);
	}

/// <summary>
/// <para>
/// Sets @iter to a valid iterator pointing to @path_string, if it
/// exists. Otherwise, @iter is left invalid and %FALSE is returned.
/// </para>
/// </summary>

/// <param name="tree_model">
/// a #GtkTreeModel
/// </param>
/// <param name="iter">
/// an uninitialized #GtkTreeIter-struct
/// </param>
/// <param name="path_string">
/// a string representation of a #GtkTreePath-struct
/// </param>
/// <return>
/// %TRUE, if @iter was set
/// </return>

	public static bool GetIterFromString(this MentorLake.Gtk.GtkTreeModelHandle tree_model, out MentorLake.Gtk.GtkTreeIter iter, string path_string)
	{
		if (tree_model.IsInvalid) throw new Exception("Invalid handle (GtkTreeModelHandle)");
		return GtkTreeModelHandleExterns.gtk_tree_model_get_iter_from_string(tree_model, out iter, path_string);
	}

/// <summary>
/// <para>
/// Returns the number of columns supported by @tree_model.
/// </para>
/// </summary>

/// <param name="tree_model">
/// a #GtkTreeModel
/// </param>
/// <return>
/// the number of columns
/// </return>

	public static int GetNColumns(this MentorLake.Gtk.GtkTreeModelHandle tree_model)
	{
		if (tree_model.IsInvalid) throw new Exception("Invalid handle (GtkTreeModelHandle)");
		return GtkTreeModelHandleExterns.gtk_tree_model_get_n_columns(tree_model);
	}

/// <summary>
/// <para>
/// Returns a newly-created #GtkTreePath-struct referenced by @iter.
/// </para>
/// <para>
/// This path should be freed with gtk_tree_path_free().
/// </para>
/// </summary>

/// <param name="tree_model">
/// a #GtkTreeModel
/// </param>
/// <param name="iter">
/// the #GtkTreeIter-struct
/// </param>
/// <return>
/// a newly-created #GtkTreePath-struct
/// </return>

	public static MentorLake.Gtk.GtkTreePathHandle GetPath(this MentorLake.Gtk.GtkTreeModelHandle tree_model, MentorLake.Gtk.GtkTreeIterHandle iter)
	{
		if (tree_model.IsInvalid) throw new Exception("Invalid handle (GtkTreeModelHandle)");
		return GtkTreeModelHandleExterns.gtk_tree_model_get_path(tree_model, iter);
	}

/// <summary>
/// <para>
/// Generates a string representation of the iter.
/// </para>
/// <para>
/// This string is a “:” separated list of numbers.
/// For example, “4:10:0:3” would be an acceptable
/// return value for this string.
/// </para>
/// </summary>

/// <param name="tree_model">
/// a #GtkTreeModel
/// </param>
/// <param name="iter">
/// a #GtkTreeIter-struct
/// </param>
/// <return>
/// a newly-allocated string.
///     Must be freed with g_free().
/// </return>

	public static string GetStringFromIter(this MentorLake.Gtk.GtkTreeModelHandle tree_model, MentorLake.Gtk.GtkTreeIterHandle iter)
	{
		if (tree_model.IsInvalid) throw new Exception("Invalid handle (GtkTreeModelHandle)");
		return GtkTreeModelHandleExterns.gtk_tree_model_get_string_from_iter(tree_model, iter);
	}

/// <summary>
/// <para>
/// See gtk_tree_model_get(), this version takes a va_list
/// for language bindings to use.
/// </para>
/// </summary>

/// <param name="tree_model">
/// a #GtkTreeModel
/// </param>
/// <param name="iter">
/// a row in @tree_model
/// </param>
/// <param name="var_args">
/// va_list of column/return location pairs
/// </param>

	public static T GetValist<T>(this T tree_model, MentorLake.Gtk.GtkTreeIterHandle iter, IntPtr var_args) where T : GtkTreeModelHandle
	{
		if (tree_model.IsInvalid) throw new Exception("Invalid handle (GtkTreeModelHandle)");
		GtkTreeModelHandleExterns.gtk_tree_model_get_valist(tree_model, iter, var_args);
		return tree_model;
	}

/// <summary>
/// <para>
/// Initializes and sets @value to that at @column.
/// </para>
/// <para>
/// When done with @value, g_value_unset() needs to be called
/// to free any allocated memory.
/// </para>
/// </summary>

/// <param name="tree_model">
/// a #GtkTreeModel
/// </param>
/// <param name="iter">
/// the #GtkTreeIter-struct
/// </param>
/// <param name="column">
/// the column to lookup the value at
/// </param>
/// <param name="value">
/// an empty #GValue to set
/// </param>

	public static T GetValue<T>(this T tree_model, MentorLake.Gtk.GtkTreeIterHandle iter, int column, out MentorLake.GObject.GValue value) where T : GtkTreeModelHandle
	{
		if (tree_model.IsInvalid) throw new Exception("Invalid handle (GtkTreeModelHandle)");
		GtkTreeModelHandleExterns.gtk_tree_model_get_value(tree_model, iter, column, out value);
		return tree_model;
	}

/// <summary>
/// <para>
/// Sets @iter to point to the first child of @parent.
/// </para>
/// <para>
/// If @parent has no children, %FALSE is returned and @iter is
/// set to be invalid. @parent will remain a valid node after this
/// function has been called.
/// </para>
/// <para>
/// If @parent is %NULL returns the first node, equivalent to
/// `gtk_tree_model_get_iter_first (tree_model, iter);`
/// </para>
/// </summary>

/// <param name="tree_model">
/// a #GtkTreeModel
/// </param>
/// <param name="iter">
/// the new #GtkTreeIter-struct to be set to the child
/// </param>
/// <param name="parent">
/// the #GtkTreeIter-struct, or %NULL
/// </param>
/// <return>
/// %TRUE, if @iter has been set to the first child
/// </return>

	public static bool IterChildren(this MentorLake.Gtk.GtkTreeModelHandle tree_model, out MentorLake.Gtk.GtkTreeIter iter, MentorLake.Gtk.GtkTreeIterHandle parent)
	{
		if (tree_model.IsInvalid) throw new Exception("Invalid handle (GtkTreeModelHandle)");
		return GtkTreeModelHandleExterns.gtk_tree_model_iter_children(tree_model, out iter, parent);
	}

/// <summary>
/// <para>
/// Returns %TRUE if @iter has children, %FALSE otherwise.
/// </para>
/// </summary>

/// <param name="tree_model">
/// a #GtkTreeModel
/// </param>
/// <param name="iter">
/// the #GtkTreeIter-struct to test for children
/// </param>
/// <return>
/// %TRUE if @iter has children
/// </return>

	public static bool IterHasChild(this MentorLake.Gtk.GtkTreeModelHandle tree_model, MentorLake.Gtk.GtkTreeIterHandle iter)
	{
		if (tree_model.IsInvalid) throw new Exception("Invalid handle (GtkTreeModelHandle)");
		return GtkTreeModelHandleExterns.gtk_tree_model_iter_has_child(tree_model, iter);
	}

/// <summary>
/// <para>
/// Returns the number of children that @iter has.
/// </para>
/// <para>
/// As a special case, if @iter is %NULL, then the number
/// of toplevel nodes is returned.
/// </para>
/// </summary>

/// <param name="tree_model">
/// a #GtkTreeModel
/// </param>
/// <param name="iter">
/// the #GtkTreeIter-struct, or %NULL
/// </param>
/// <return>
/// the number of children of @iter
/// </return>

	public static int IterNChildren(this MentorLake.Gtk.GtkTreeModelHandle tree_model, MentorLake.Gtk.GtkTreeIterHandle iter)
	{
		if (tree_model.IsInvalid) throw new Exception("Invalid handle (GtkTreeModelHandle)");
		return GtkTreeModelHandleExterns.gtk_tree_model_iter_n_children(tree_model, iter);
	}

/// <summary>
/// <para>
/// Sets @iter to point to the node following it at the current level.
/// </para>
/// <para>
/// If there is no next @iter, %FALSE is returned and @iter is set
/// to be invalid.
/// </para>
/// </summary>

/// <param name="tree_model">
/// a #GtkTreeModel
/// </param>
/// <param name="iter">
/// the #GtkTreeIter-struct
/// </param>
/// <return>
/// %TRUE if @iter has been changed to the next node
/// </return>

	public static bool IterNext(this MentorLake.Gtk.GtkTreeModelHandle tree_model, MentorLake.Gtk.GtkTreeIterHandle iter)
	{
		if (tree_model.IsInvalid) throw new Exception("Invalid handle (GtkTreeModelHandle)");
		return GtkTreeModelHandleExterns.gtk_tree_model_iter_next(tree_model, iter);
	}

/// <summary>
/// <para>
/// Sets @iter to be the child of @parent, using the given index.
/// </para>
/// <para>
/// The first index is 0. If @n is too big, or @parent has no children,
/// @iter is set to an invalid iterator and %FALSE is returned. @parent
/// will remain a valid node after this function has been called. As a
/// special case, if @parent is %NULL, then the @n-th root node
/// is set.
/// </para>
/// </summary>

/// <param name="tree_model">
/// a #GtkTreeModel
/// </param>
/// <param name="iter">
/// the #GtkTreeIter-struct to set to the nth child
/// </param>
/// <param name="parent">
/// the #GtkTreeIter-struct to get the child from, or %NULL.
/// </param>
/// <param name="n">
/// the index of the desired child
/// </param>
/// <return>
/// %TRUE, if @parent has an @n-th child
/// </return>

	public static bool IterNthChild(this MentorLake.Gtk.GtkTreeModelHandle tree_model, out MentorLake.Gtk.GtkTreeIter iter, MentorLake.Gtk.GtkTreeIterHandle parent, int n)
	{
		if (tree_model.IsInvalid) throw new Exception("Invalid handle (GtkTreeModelHandle)");
		return GtkTreeModelHandleExterns.gtk_tree_model_iter_nth_child(tree_model, out iter, parent, n);
	}

/// <summary>
/// <para>
/// Sets @iter to be the parent of @child.
/// </para>
/// <para>
/// If @child is at the toplevel, and doesn’t have a parent, then
/// @iter is set to an invalid iterator and %FALSE is returned.
/// @child will remain a valid node after this function has been
/// called.
/// </para>
/// <para>
/// @iter will be initialized before the lookup is performed, so @child
/// and @iter cannot point to the same memory location.
/// </para>
/// </summary>

/// <param name="tree_model">
/// a #GtkTreeModel
/// </param>
/// <param name="iter">
/// the new #GtkTreeIter-struct to set to the parent
/// </param>
/// <param name="child">
/// the #GtkTreeIter-struct
/// </param>
/// <return>
/// %TRUE, if @iter is set to the parent of @child
/// </return>

	public static bool IterParent(this MentorLake.Gtk.GtkTreeModelHandle tree_model, out MentorLake.Gtk.GtkTreeIter iter, MentorLake.Gtk.GtkTreeIterHandle child)
	{
		if (tree_model.IsInvalid) throw new Exception("Invalid handle (GtkTreeModelHandle)");
		return GtkTreeModelHandleExterns.gtk_tree_model_iter_parent(tree_model, out iter, child);
	}

/// <summary>
/// <para>
/// Sets @iter to point to the previous node at the current level.
/// </para>
/// <para>
/// If there is no previous @iter, %FALSE is returned and @iter is
/// set to be invalid.
/// </para>
/// </summary>

/// <param name="tree_model">
/// a #GtkTreeModel
/// </param>
/// <param name="iter">
/// the #GtkTreeIter-struct
/// </param>
/// <return>
/// %TRUE if @iter has been changed to the previous node
/// </return>

	public static bool IterPrevious(this MentorLake.Gtk.GtkTreeModelHandle tree_model, MentorLake.Gtk.GtkTreeIterHandle iter)
	{
		if (tree_model.IsInvalid) throw new Exception("Invalid handle (GtkTreeModelHandle)");
		return GtkTreeModelHandleExterns.gtk_tree_model_iter_previous(tree_model, iter);
	}

/// <summary>
/// <para>
/// Lets the tree ref the node.
/// </para>
/// <para>
/// This is an optional method for models to implement.
/// To be more specific, models may ignore this call as it exists
/// primarily for performance reasons.
/// </para>
/// <para>
/// This function is primarily meant as a way for views to let
/// caching models know when nodes are being displayed (and hence,
/// whether or not to cache that node). Being displayed means a node
/// is in an expanded branch, regardless of whether the node is currently
/// visible in the viewport. For example, a file-system based model
/// would not want to keep the entire file-hierarchy in memory,
/// just the sections that are currently being displayed by
/// every current view.
/// </para>
/// <para>
/// A model should be expected to be able to get an iter independent
/// of its reffed state.
/// </para>
/// </summary>

/// <param name="tree_model">
/// a #GtkTreeModel
/// </param>
/// <param name="iter">
/// the #GtkTreeIter-struct
/// </param>

	public static T RefNode<T>(this T tree_model, MentorLake.Gtk.GtkTreeIterHandle iter) where T : GtkTreeModelHandle
	{
		if (tree_model.IsInvalid) throw new Exception("Invalid handle (GtkTreeModelHandle)");
		GtkTreeModelHandleExterns.gtk_tree_model_ref_node(tree_model, iter);
		return tree_model;
	}

/// <summary>
/// <para>
/// Emits the #GtkTreeModel::row-changed signal on @tree_model.
/// </para>
/// </summary>

/// <param name="tree_model">
/// a #GtkTreeModel
/// </param>
/// <param name="path">
/// a #GtkTreePath-struct pointing to the changed row
/// </param>
/// <param name="iter">
/// a valid #GtkTreeIter-struct pointing to the changed row
/// </param>

	public static T RowChanged<T>(this T tree_model, MentorLake.Gtk.GtkTreePathHandle path, MentorLake.Gtk.GtkTreeIterHandle iter) where T : GtkTreeModelHandle
	{
		if (tree_model.IsInvalid) throw new Exception("Invalid handle (GtkTreeModelHandle)");
		GtkTreeModelHandleExterns.gtk_tree_model_row_changed(tree_model, path, iter);
		return tree_model;
	}

/// <summary>
/// <para>
/// Emits the #GtkTreeModel::row-deleted signal on @tree_model.
/// </para>
/// <para>
/// This should be called by models after a row has been removed.
/// The location pointed to by @path should be the location that
/// the row previously was at. It may not be a valid location anymore.
/// </para>
/// <para>
/// Nodes that are deleted are not unreffed, this means that any
/// outstanding references on the deleted node should not be released.
/// </para>
/// </summary>

/// <param name="tree_model">
/// a #GtkTreeModel
/// </param>
/// <param name="path">
/// a #GtkTreePath-struct pointing to the previous location of
///     the deleted row
/// </param>

	public static T RowDeleted<T>(this T tree_model, MentorLake.Gtk.GtkTreePathHandle path) where T : GtkTreeModelHandle
	{
		if (tree_model.IsInvalid) throw new Exception("Invalid handle (GtkTreeModelHandle)");
		GtkTreeModelHandleExterns.gtk_tree_model_row_deleted(tree_model, path);
		return tree_model;
	}

/// <summary>
/// <para>
/// Emits the #GtkTreeModel::row-has-child-toggled signal on
/// @tree_model. This should be called by models after the child
/// state of a node changes.
/// </para>
/// </summary>

/// <param name="tree_model">
/// a #GtkTreeModel
/// </param>
/// <param name="path">
/// a #GtkTreePath-struct pointing to the changed row
/// </param>
/// <param name="iter">
/// a valid #GtkTreeIter-struct pointing to the changed row
/// </param>

	public static T RowHasChildToggled<T>(this T tree_model, MentorLake.Gtk.GtkTreePathHandle path, MentorLake.Gtk.GtkTreeIterHandle iter) where T : GtkTreeModelHandle
	{
		if (tree_model.IsInvalid) throw new Exception("Invalid handle (GtkTreeModelHandle)");
		GtkTreeModelHandleExterns.gtk_tree_model_row_has_child_toggled(tree_model, path, iter);
		return tree_model;
	}

/// <summary>
/// <para>
/// Emits the #GtkTreeModel::row-inserted signal on @tree_model.
/// </para>
/// </summary>

/// <param name="tree_model">
/// a #GtkTreeModel
/// </param>
/// <param name="path">
/// a #GtkTreePath-struct pointing to the inserted row
/// </param>
/// <param name="iter">
/// a valid #GtkTreeIter-struct pointing to the inserted row
/// </param>

	public static T RowInserted<T>(this T tree_model, MentorLake.Gtk.GtkTreePathHandle path, MentorLake.Gtk.GtkTreeIterHandle iter) where T : GtkTreeModelHandle
	{
		if (tree_model.IsInvalid) throw new Exception("Invalid handle (GtkTreeModelHandle)");
		GtkTreeModelHandleExterns.gtk_tree_model_row_inserted(tree_model, path, iter);
		return tree_model;
	}

/// <summary>
/// <para>
/// Emits the #GtkTreeModel::rows-reordered signal on @tree_model.
/// </para>
/// <para>
/// This should be called by models when their rows have been
/// reordered.
/// </para>
/// </summary>

/// <param name="tree_model">
/// a #GtkTreeModel
/// </param>
/// <param name="path">
/// a #GtkTreePath-struct pointing to the tree node whose children
///     have been reordered
/// </param>
/// <param name="iter">
/// a valid #GtkTreeIter-struct pointing to the node whose children
///     have been reordered, or %NULL if the depth of @path is 0
/// </param>
/// <param name="new_order">
/// an array of integers mapping the current position of
///     each child to its old position before the re-ordering,
///     i.e. @new_order`[newpos] = oldpos`
/// </param>

	public static T RowsReordered<T>(this T tree_model, MentorLake.Gtk.GtkTreePathHandle path, MentorLake.Gtk.GtkTreeIterHandle iter, int new_order) where T : GtkTreeModelHandle
	{
		if (tree_model.IsInvalid) throw new Exception("Invalid handle (GtkTreeModelHandle)");
		GtkTreeModelHandleExterns.gtk_tree_model_rows_reordered(tree_model, path, iter, new_order);
		return tree_model;
	}

/// <summary>
/// <para>
/// Emits the #GtkTreeModel::rows-reordered signal on @tree_model.
/// </para>
/// <para>
/// This should be called by models when their rows have been
/// reordered.
/// </para>
/// </summary>

/// <param name="tree_model">
/// a #GtkTreeModel
/// </param>
/// <param name="path">
/// a #GtkTreePath-struct pointing to the tree node whose children
///     have been reordered
/// </param>
/// <param name="iter">
/// a valid #GtkTreeIter-struct pointing to the node
///     whose children have been reordered, or %NULL if the depth
///     of @path is 0
/// </param>
/// <param name="new_order">
/// an array of integers
///     mapping the current position of each child to its old
///     position before the re-ordering,
///     i.e. @new_order`[newpos] = oldpos`
/// </param>
/// <param name="length">
/// length of @new_order array
/// </param>

	public static T RowsReorderedWithLength<T>(this T tree_model, MentorLake.Gtk.GtkTreePathHandle path, MentorLake.Gtk.GtkTreeIterHandle iter, int[] new_order, int length) where T : GtkTreeModelHandle
	{
		if (tree_model.IsInvalid) throw new Exception("Invalid handle (GtkTreeModelHandle)");
		GtkTreeModelHandleExterns.gtk_tree_model_rows_reordered_with_length(tree_model, path, iter, new_order, length);
		return tree_model;
	}

/// <summary>
/// <para>
/// Lets the tree unref the node.
/// </para>
/// <para>
/// This is an optional method for models to implement.
/// To be more specific, models may ignore this call as it exists
/// primarily for performance reasons. For more information on what
/// this means, see gtk_tree_model_ref_node().
/// </para>
/// <para>
/// Please note that nodes that are deleted are not unreffed.
/// </para>
/// </summary>

/// <param name="tree_model">
/// a #GtkTreeModel
/// </param>
/// <param name="iter">
/// the #GtkTreeIter-struct
/// </param>

	public static T UnrefNode<T>(this T tree_model, MentorLake.Gtk.GtkTreeIterHandle iter) where T : GtkTreeModelHandle
	{
		if (tree_model.IsInvalid) throw new Exception("Invalid handle (GtkTreeModelHandle)");
		GtkTreeModelHandleExterns.gtk_tree_model_unref_node(tree_model, iter);
		return tree_model;
	}

}

internal class GtkTreeModelHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeModelHandleImpl>))]
	internal static extern MentorLake.Gtk.GtkTreeModelHandle gtk_tree_model_filter_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeModelHandleImpl>))] MentorLake.Gtk.GtkTreeModelHandle child_model, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] MentorLake.Gtk.GtkTreePathHandle root);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_model_foreach([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeModelHandleImpl>))] MentorLake.Gtk.GtkTreeModelHandle model, MentorLake.Gtk.GtkTreeModelForeachFunc func, IntPtr user_data);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_model_get([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeModelHandleImpl>))] MentorLake.Gtk.GtkTreeModelHandle tree_model, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeIterHandle>))] MentorLake.Gtk.GtkTreeIterHandle iter, IntPtr @__arglist);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.GObject.GType gtk_tree_model_get_column_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeModelHandleImpl>))] MentorLake.Gtk.GtkTreeModelHandle tree_model, int index_);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkTreeModelFlags gtk_tree_model_get_flags([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeModelHandleImpl>))] MentorLake.Gtk.GtkTreeModelHandle tree_model);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_tree_model_get_iter([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeModelHandleImpl>))] MentorLake.Gtk.GtkTreeModelHandle tree_model, out MentorLake.Gtk.GtkTreeIter iter, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] MentorLake.Gtk.GtkTreePathHandle path);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_tree_model_get_iter_first([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeModelHandleImpl>))] MentorLake.Gtk.GtkTreeModelHandle tree_model, out MentorLake.Gtk.GtkTreeIter iter);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_tree_model_get_iter_from_string([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeModelHandleImpl>))] MentorLake.Gtk.GtkTreeModelHandle tree_model, out MentorLake.Gtk.GtkTreeIter iter, string path_string);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_tree_model_get_n_columns([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeModelHandleImpl>))] MentorLake.Gtk.GtkTreeModelHandle tree_model);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))]
	internal static extern MentorLake.Gtk.GtkTreePathHandle gtk_tree_model_get_path([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeModelHandleImpl>))] MentorLake.Gtk.GtkTreeModelHandle tree_model, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeIterHandle>))] MentorLake.Gtk.GtkTreeIterHandle iter);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_tree_model_get_string_from_iter([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeModelHandleImpl>))] MentorLake.Gtk.GtkTreeModelHandle tree_model, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeIterHandle>))] MentorLake.Gtk.GtkTreeIterHandle iter);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_model_get_valist([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeModelHandleImpl>))] MentorLake.Gtk.GtkTreeModelHandle tree_model, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeIterHandle>))] MentorLake.Gtk.GtkTreeIterHandle iter, IntPtr var_args);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_model_get_value([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeModelHandleImpl>))] MentorLake.Gtk.GtkTreeModelHandle tree_model, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeIterHandle>))] MentorLake.Gtk.GtkTreeIterHandle iter, int column, out MentorLake.GObject.GValue value);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_tree_model_iter_children([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeModelHandleImpl>))] MentorLake.Gtk.GtkTreeModelHandle tree_model, out MentorLake.Gtk.GtkTreeIter iter, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeIterHandle>))] MentorLake.Gtk.GtkTreeIterHandle parent);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_tree_model_iter_has_child([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeModelHandleImpl>))] MentorLake.Gtk.GtkTreeModelHandle tree_model, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeIterHandle>))] MentorLake.Gtk.GtkTreeIterHandle iter);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_tree_model_iter_n_children([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeModelHandleImpl>))] MentorLake.Gtk.GtkTreeModelHandle tree_model, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeIterHandle>))] MentorLake.Gtk.GtkTreeIterHandle iter);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_tree_model_iter_next([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeModelHandleImpl>))] MentorLake.Gtk.GtkTreeModelHandle tree_model, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeIterHandle>))] MentorLake.Gtk.GtkTreeIterHandle iter);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_tree_model_iter_nth_child([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeModelHandleImpl>))] MentorLake.Gtk.GtkTreeModelHandle tree_model, out MentorLake.Gtk.GtkTreeIter iter, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeIterHandle>))] MentorLake.Gtk.GtkTreeIterHandle parent, int n);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_tree_model_iter_parent([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeModelHandleImpl>))] MentorLake.Gtk.GtkTreeModelHandle tree_model, out MentorLake.Gtk.GtkTreeIter iter, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeIterHandle>))] MentorLake.Gtk.GtkTreeIterHandle child);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_tree_model_iter_previous([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeModelHandleImpl>))] MentorLake.Gtk.GtkTreeModelHandle tree_model, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeIterHandle>))] MentorLake.Gtk.GtkTreeIterHandle iter);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_model_ref_node([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeModelHandleImpl>))] MentorLake.Gtk.GtkTreeModelHandle tree_model, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeIterHandle>))] MentorLake.Gtk.GtkTreeIterHandle iter);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_model_row_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeModelHandleImpl>))] MentorLake.Gtk.GtkTreeModelHandle tree_model, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] MentorLake.Gtk.GtkTreePathHandle path, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeIterHandle>))] MentorLake.Gtk.GtkTreeIterHandle iter);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_model_row_deleted([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeModelHandleImpl>))] MentorLake.Gtk.GtkTreeModelHandle tree_model, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] MentorLake.Gtk.GtkTreePathHandle path);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_model_row_has_child_toggled([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeModelHandleImpl>))] MentorLake.Gtk.GtkTreeModelHandle tree_model, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] MentorLake.Gtk.GtkTreePathHandle path, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeIterHandle>))] MentorLake.Gtk.GtkTreeIterHandle iter);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_model_row_inserted([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeModelHandleImpl>))] MentorLake.Gtk.GtkTreeModelHandle tree_model, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] MentorLake.Gtk.GtkTreePathHandle path, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeIterHandle>))] MentorLake.Gtk.GtkTreeIterHandle iter);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_model_rows_reordered([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeModelHandleImpl>))] MentorLake.Gtk.GtkTreeModelHandle tree_model, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] MentorLake.Gtk.GtkTreePathHandle path, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeIterHandle>))] MentorLake.Gtk.GtkTreeIterHandle iter, int new_order);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_model_rows_reordered_with_length([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeModelHandleImpl>))] MentorLake.Gtk.GtkTreeModelHandle tree_model, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] MentorLake.Gtk.GtkTreePathHandle path, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeIterHandle>))] MentorLake.Gtk.GtkTreeIterHandle iter, int[] new_order, int length);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_model_unref_node([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeModelHandleImpl>))] MentorLake.Gtk.GtkTreeModelHandle tree_model, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeIterHandle>))] MentorLake.Gtk.GtkTreeIterHandle iter);

}
