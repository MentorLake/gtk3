namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// GtkWidgetPath is a boxed type that represents a widget hierarchy from
/// the topmost widget, typically a toplevel, to any child. This widget
/// path abstraction is used in #GtkStyleContext on behalf of the real
/// widget in order to query style information.
/// </para>
/// <para>
/// If you are using GTK+ widgets, you probably will not need to use
/// this API directly, as there is gtk_widget_get_path(), and the style
/// context returned by gtk_widget_get_style_context() will be automatically
/// updated on widget hierarchy changes.
/// </para>
/// <para>
/// The widget path generation is generally simple:
/// </para>
/// <para>
/// ## Defining a button within a window
/// </para>
/// <code>
/// {
/// {
///   GtkWidgetPath *path;
/// 
///   path = gtk_widget_path_new ();
///   gtk_widget_path_append_type (path, GTK_TYPE_WINDOW);
///   gtk_widget_path_append_type (path, GTK_TYPE_BUTTON);
/// }
/// </code>
/// <para>
/// Although more complex information, such as widget names, or
/// different classes (property that may be used by other widget
/// types) and intermediate regions may be included:
/// </para>
/// <para>
/// ## Defining the first tab widget in a notebook
/// </para>
/// <code>
/// {
/// {
///   GtkWidgetPath *path;
///   guint pos;
/// 
///   path = gtk_widget_path_new ();
/// 
///   pos = gtk_widget_path_append_type (path, GTK_TYPE_NOTEBOOK);
///   gtk_widget_path_iter_add_region (path, pos, &quot;tab&quot;, GTK_REGION_EVEN | GTK_REGION_FIRST);
/// 
///   pos = gtk_widget_path_append_type (path, GTK_TYPE_LABEL);
///   gtk_widget_path_iter_set_name (path, pos, &quot;first tab label&quot;);
/// }
/// </code>
/// <para>
/// All this information will be used to match the style information
/// that applies to the described widget.
/// </para>
/// </summary>

public class GtkWidgetPathHandle : BaseSafeHandle
{
/// <summary>
/// <para>
/// Returns an empty widget path.
/// </para>
/// </summary>

/// <return>
/// A newly created, empty, #GtkWidgetPath
/// </return>

	public static MentorLake.Gtk.GtkWidgetPathHandle New()
	{
		return GtkWidgetPathExterns.gtk_widget_path_new();
	}

}


public static class GtkWidgetPathExtensions
{
/// <summary>
/// <para>
/// Appends the data from @widget to the widget hierarchy represented
/// by @path. This function is a shortcut for adding information from
/// @widget to the given @path. This includes setting the name or
/// adding the style classes from @widget.
/// </para>
/// </summary>

/// <param name="path">
/// a widget path
/// </param>
/// <param name="widget">
/// the widget to append to the widget path
/// </param>
/// <return>
/// the position where the data was inserted
/// </return>

	public static int AppendForWidget(this MentorLake.Gtk.GtkWidgetPathHandle path, MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (path.IsInvalid) throw new Exception("Invalid handle (GtkWidgetPath)");
		return GtkWidgetPathExterns.gtk_widget_path_append_for_widget(path, widget);
	}

/// <summary>
/// <para>
/// Appends a widget type to the widget hierarchy represented by @path.
/// </para>
/// </summary>

/// <param name="path">
/// a #GtkWidgetPath
/// </param>
/// <param name="type">
/// widget type to append
/// </param>
/// <return>
/// the position where the element was inserted
/// </return>

	public static int AppendType(this MentorLake.Gtk.GtkWidgetPathHandle path, MentorLake.GObject.GType type)
	{
		if (path.IsInvalid) throw new Exception("Invalid handle (GtkWidgetPath)");
		return GtkWidgetPathExterns.gtk_widget_path_append_type(path, type);
	}

/// <summary>
/// <para>
/// Appends a widget type with all its siblings to the widget hierarchy
/// represented by @path. Using this function instead of
/// gtk_widget_path_append_type() will allow the CSS theming to use
/// sibling matches in selectors and apply :nth-child() pseudo classes.
/// In turn, it requires a lot more care in widget implementations as
/// widgets need to make sure to call gtk_widget_reset_style() on all
/// involved widgets when the @siblings path changes.
/// </para>
/// </summary>

/// <param name="path">
/// the widget path to append to
/// </param>
/// <param name="siblings">
/// a widget path describing a list of siblings. This path
///   may not contain any siblings itself and it must not be modified
///   afterwards.
/// </param>
/// <param name="sibling_index">
/// index into @siblings for where the added element is
///   positioned.
/// </param>
/// <return>
/// the position where the element was inserted.
/// </return>

	public static int AppendWithSiblings(this MentorLake.Gtk.GtkWidgetPathHandle path, MentorLake.Gtk.GtkWidgetPathHandle siblings, uint sibling_index)
	{
		if (path.IsInvalid) throw new Exception("Invalid handle (GtkWidgetPath)");
		return GtkWidgetPathExterns.gtk_widget_path_append_with_siblings(path, siblings, sibling_index);
	}

/// <summary>
/// <para>
/// Returns a copy of @path
/// </para>
/// </summary>

/// <param name="path">
/// a #GtkWidgetPath
/// </param>
/// <return>
/// a copy of @path
/// </return>

	public static MentorLake.Gtk.GtkWidgetPathHandle Copy(this MentorLake.Gtk.GtkWidgetPathHandle path)
	{
		if (path.IsInvalid) throw new Exception("Invalid handle (GtkWidgetPath)");
		return GtkWidgetPathExterns.gtk_widget_path_copy(path);
	}

/// <summary>
/// <para>
/// Decrements the reference count on @path, freeing the structure
/// if the reference count reaches 0.
/// </para>
/// </summary>

/// <param name="path">
/// a #GtkWidgetPath
/// </param>

	public static void Free(this MentorLake.Gtk.GtkWidgetPathHandle path)
	{
		if (path.IsInvalid) throw new Exception("Invalid handle (GtkWidgetPath)");
		GtkWidgetPathExterns.gtk_widget_path_free(path);
	}

/// <summary>
/// <para>
/// Returns the topmost object type, that is, the object type this path
/// is representing.
/// </para>
/// </summary>

/// <param name="path">
/// a #GtkWidget
/// </param>
/// <return>
/// The object type
/// </return>

	public static MentorLake.GObject.GType GetObjectType(this MentorLake.Gtk.GtkWidgetPathHandle path)
	{
		if (path.IsInvalid) throw new Exception("Invalid handle (GtkWidgetPath)");
		return GtkWidgetPathExterns.gtk_widget_path_get_object_type(path);
	}

/// <summary>
/// <para>
/// Returns %TRUE if any of the parents of the widget represented
/// in @path is of type @type, or any subtype of it.
/// </para>
/// </summary>

/// <param name="path">
/// a #GtkWidgetPath
/// </param>
/// <param name="type">
/// widget type to check in parents
/// </param>
/// <return>
/// %TRUE if any parent is of type @type
/// </return>

	public static bool HasParent(this MentorLake.Gtk.GtkWidgetPathHandle path, MentorLake.GObject.GType type)
	{
		if (path.IsInvalid) throw new Exception("Invalid handle (GtkWidgetPath)");
		return GtkWidgetPathExterns.gtk_widget_path_has_parent(path, type);
	}

/// <summary>
/// <para>
/// Returns %TRUE if the widget type represented by this path
/// is @type, or a subtype of it.
/// </para>
/// </summary>

/// <param name="path">
/// a #GtkWidgetPath
/// </param>
/// <param name="type">
/// widget type to match
/// </param>
/// <return>
/// %TRUE if the widget represented by @path is of type @type
/// </return>

	public static bool IsType(this MentorLake.Gtk.GtkWidgetPathHandle path, MentorLake.GObject.GType type)
	{
		if (path.IsInvalid) throw new Exception("Invalid handle (GtkWidgetPath)");
		return GtkWidgetPathExterns.gtk_widget_path_is_type(path, type);
	}

/// <summary>
/// <para>
/// Adds the class @name to the widget at position @pos in
/// the hierarchy defined in @path. See
/// gtk_style_context_add_class().
/// </para>
/// </summary>

/// <param name="path">
/// a #GtkWidget
/// </param>
/// <param name="pos">
/// position to modify, -1 for the path head
/// </param>
/// <param name="name">
/// a class name
/// </param>

	public static void IterAddClass(this MentorLake.Gtk.GtkWidgetPathHandle path, int pos, string name)
	{
		if (path.IsInvalid) throw new Exception("Invalid handle (GtkWidgetPath)");
		GtkWidgetPathExterns.gtk_widget_path_iter_add_class(path, pos, name);
	}

/// <summary>
/// <para>
/// Adds the region @name to the widget at position @pos in
/// the hierarchy defined in @path. See
/// gtk_style_context_add_region().
/// </para>
/// <para>
/// Region names must only contain lowercase letters
/// and “-”, starting always with a lowercase letter.
/// </para>
/// </summary>

/// <param name="path">
/// a #GtkWidgetPath
/// </param>
/// <param name="pos">
/// position to modify, -1 for the path head
/// </param>
/// <param name="name">
/// region name
/// </param>
/// <param name="flags">
/// flags affecting the region
/// </param>

	public static void IterAddRegion(this MentorLake.Gtk.GtkWidgetPathHandle path, int pos, string name, MentorLake.Gtk.GtkRegionFlags flags)
	{
		if (path.IsInvalid) throw new Exception("Invalid handle (GtkWidgetPath)");
		GtkWidgetPathExterns.gtk_widget_path_iter_add_region(path, pos, name, flags);
	}

/// <summary>
/// <para>
/// Removes all classes from the widget at position @pos in the
/// hierarchy defined in @path.
/// </para>
/// </summary>

/// <param name="path">
/// a #GtkWidget
/// </param>
/// <param name="pos">
/// position to modify, -1 for the path head
/// </param>

	public static void IterClearClasses(this MentorLake.Gtk.GtkWidgetPathHandle path, int pos)
	{
		if (path.IsInvalid) throw new Exception("Invalid handle (GtkWidgetPath)");
		GtkWidgetPathExterns.gtk_widget_path_iter_clear_classes(path, pos);
	}

/// <summary>
/// <para>
/// Removes all regions from the widget at position @pos in the
/// hierarchy defined in @path.
/// </para>
/// </summary>

/// <param name="path">
/// a #GtkWidgetPath
/// </param>
/// <param name="pos">
/// position to modify, -1 for the path head
/// </param>

	public static void IterClearRegions(this MentorLake.Gtk.GtkWidgetPathHandle path, int pos)
	{
		if (path.IsInvalid) throw new Exception("Invalid handle (GtkWidgetPath)");
		GtkWidgetPathExterns.gtk_widget_path_iter_clear_regions(path, pos);
	}

/// <summary>
/// <para>
/// Returns the name corresponding to the widget found at
/// the position @pos in the widget hierarchy defined by
/// @path
/// </para>
/// </summary>

/// <param name="path">
/// a #GtkWidgetPath
/// </param>
/// <param name="pos">
/// position to get the widget name for, -1 for the path head
/// </param>
/// <return>
/// The widget name, or %NULL if none was set.
/// </return>

	public static string IterGetName(this MentorLake.Gtk.GtkWidgetPathHandle path, int pos)
	{
		if (path.IsInvalid) throw new Exception("Invalid handle (GtkWidgetPath)");
		return GtkWidgetPathExterns.gtk_widget_path_iter_get_name(path, pos);
	}

/// <summary>
/// <para>
/// Returns the object name that is at position @pos in the widget
/// hierarchy defined in @path.
/// </para>
/// </summary>

/// <param name="path">
/// a #GtkWidgetPath
/// </param>
/// <param name="pos">
/// position to get the object name for, -1 for the path head
/// </param>
/// <return>
/// the name or %NULL
/// </return>

	public static string IterGetObjectName(this MentorLake.Gtk.GtkWidgetPathHandle path, int pos)
	{
		if (path.IsInvalid) throw new Exception("Invalid handle (GtkWidgetPath)");
		return GtkWidgetPathExterns.gtk_widget_path_iter_get_object_name(path, pos);
	}

/// <summary>
/// <para>
/// Returns the object #GType that is at position @pos in the widget
/// hierarchy defined in @path.
/// </para>
/// </summary>

/// <param name="path">
/// a #GtkWidgetPath
/// </param>
/// <param name="pos">
/// position to get the object type for, -1 for the path head
/// </param>
/// <return>
/// a widget type
/// </return>

	public static MentorLake.GObject.GType IterGetObjectType(this MentorLake.Gtk.GtkWidgetPathHandle path, int pos)
	{
		if (path.IsInvalid) throw new Exception("Invalid handle (GtkWidgetPath)");
		return GtkWidgetPathExterns.gtk_widget_path_iter_get_object_type(path, pos);
	}

/// <summary>
/// <para>
/// Returns the index into the list of siblings for the element at @pos as
/// returned by gtk_widget_path_iter_get_siblings(). If that function would
/// return %NULL because the element at @pos has no siblings, this function
/// will return 0.
/// </para>
/// </summary>

/// <param name="path">
/// a #GtkWidgetPath
/// </param>
/// <param name="pos">
/// position to get the sibling index for, -1 for the path head
/// </param>
/// <return>
/// 0 or the index into the list of siblings for the element at @pos.
/// </return>

	public static uint IterGetSiblingIndex(this MentorLake.Gtk.GtkWidgetPathHandle path, int pos)
	{
		if (path.IsInvalid) throw new Exception("Invalid handle (GtkWidgetPath)");
		return GtkWidgetPathExterns.gtk_widget_path_iter_get_sibling_index(path, pos);
	}

/// <summary>
/// <para>
/// Returns the list of siblings for the element at @pos. If the element
/// was not added with siblings, %NULL is returned.
/// </para>
/// </summary>

/// <param name="path">
/// a #GtkWidgetPath
/// </param>
/// <param name="pos">
/// position to get the siblings for, -1 for the path head
/// </param>
/// <return>
/// %NULL or the list of siblings for the element at @pos.
/// </return>

	public static MentorLake.Gtk.GtkWidgetPathHandle IterGetSiblings(this MentorLake.Gtk.GtkWidgetPathHandle path, int pos)
	{
		if (path.IsInvalid) throw new Exception("Invalid handle (GtkWidgetPath)");
		return GtkWidgetPathExterns.gtk_widget_path_iter_get_siblings(path, pos);
	}

/// <summary>
/// <para>
/// Returns the state flags corresponding to the widget found at
/// the position @pos in the widget hierarchy defined by
/// @path
/// </para>
/// </summary>

/// <param name="path">
/// a #GtkWidgetPath
/// </param>
/// <param name="pos">
/// position to get the state for, -1 for the path head
/// </param>
/// <return>
/// The state flags
/// </return>

	public static MentorLake.Gtk.GtkStateFlags IterGetState(this MentorLake.Gtk.GtkWidgetPathHandle path, int pos)
	{
		if (path.IsInvalid) throw new Exception("Invalid handle (GtkWidgetPath)");
		return GtkWidgetPathExterns.gtk_widget_path_iter_get_state(path, pos);
	}

/// <summary>
/// <para>
/// Returns %TRUE if the widget at position @pos has the class @name
/// defined, %FALSE otherwise.
/// </para>
/// </summary>

/// <param name="path">
/// a #GtkWidgetPath
/// </param>
/// <param name="pos">
/// position to query, -1 for the path head
/// </param>
/// <param name="name">
/// class name
/// </param>
/// <return>
/// %TRUE if the class @name is defined for the widget at @pos
/// </return>

	public static bool IterHasClass(this MentorLake.Gtk.GtkWidgetPathHandle path, int pos, string name)
	{
		if (path.IsInvalid) throw new Exception("Invalid handle (GtkWidgetPath)");
		return GtkWidgetPathExterns.gtk_widget_path_iter_has_class(path, pos, name);
	}

/// <summary>
/// <para>
/// Returns %TRUE if the widget at position @pos has the name @name,
/// %FALSE otherwise.
/// </para>
/// </summary>

/// <param name="path">
/// a #GtkWidgetPath
/// </param>
/// <param name="pos">
/// position to query, -1 for the path head
/// </param>
/// <param name="name">
/// a widget name
/// </param>
/// <return>
/// %TRUE if the widget at @pos has this name
/// </return>

	public static bool IterHasName(this MentorLake.Gtk.GtkWidgetPathHandle path, int pos, string name)
	{
		if (path.IsInvalid) throw new Exception("Invalid handle (GtkWidgetPath)");
		return GtkWidgetPathExterns.gtk_widget_path_iter_has_name(path, pos, name);
	}

/// <summary>
/// <para>
/// See gtk_widget_path_iter_has_class(). This is a version that operates
/// with GQuarks.
/// </para>
/// </summary>

/// <param name="path">
/// a #GtkWidgetPath
/// </param>
/// <param name="pos">
/// position to query, -1 for the path head
/// </param>
/// <param name="qname">
/// class name as a #GQuark
/// </param>
/// <return>
/// %TRUE if the widget at @pos has the class defined.
/// </return>

	public static bool IterHasQclass(this MentorLake.Gtk.GtkWidgetPathHandle path, int pos, MentorLake.GLib.GQuark qname)
	{
		if (path.IsInvalid) throw new Exception("Invalid handle (GtkWidgetPath)");
		return GtkWidgetPathExterns.gtk_widget_path_iter_has_qclass(path, pos, qname);
	}

/// <summary>
/// <para>
/// See gtk_widget_path_iter_has_name(). This is a version
/// that operates on #GQuarks.
/// </para>
/// </summary>

/// <param name="path">
/// a #GtkWidgetPath
/// </param>
/// <param name="pos">
/// position to query, -1 for the path head
/// </param>
/// <param name="qname">
/// widget name as a #GQuark
/// </param>
/// <return>
/// %TRUE if the widget at @pos has this name
/// </return>

	public static bool IterHasQname(this MentorLake.Gtk.GtkWidgetPathHandle path, int pos, MentorLake.GLib.GQuark qname)
	{
		if (path.IsInvalid) throw new Exception("Invalid handle (GtkWidgetPath)");
		return GtkWidgetPathExterns.gtk_widget_path_iter_has_qname(path, pos, qname);
	}

/// <summary>
/// <para>
/// See gtk_widget_path_iter_has_region(). This is a version that operates
/// with GQuarks.
/// </para>
/// </summary>

/// <param name="path">
/// a #GtkWidgetPath
/// </param>
/// <param name="pos">
/// position to query, -1 for the path head
/// </param>
/// <param name="qname">
/// region name as a #GQuark
/// </param>
/// <param name="flags">
/// return location for the region flags
/// </param>
/// <return>
/// %TRUE if the widget at @pos has the region defined.
/// </return>

	public static bool IterHasQregion(this MentorLake.Gtk.GtkWidgetPathHandle path, int pos, MentorLake.GLib.GQuark qname, out MentorLake.Gtk.GtkRegionFlags flags)
	{
		if (path.IsInvalid) throw new Exception("Invalid handle (GtkWidgetPath)");
		return GtkWidgetPathExterns.gtk_widget_path_iter_has_qregion(path, pos, qname, out flags);
	}

/// <summary>
/// <para>
/// Returns %TRUE if the widget at position @pos has the class @name
/// defined, %FALSE otherwise.
/// </para>
/// </summary>

/// <param name="path">
/// a #GtkWidgetPath
/// </param>
/// <param name="pos">
/// position to query, -1 for the path head
/// </param>
/// <param name="name">
/// region name
/// </param>
/// <param name="flags">
/// return location for the region flags
/// </param>
/// <return>
/// %TRUE if the class @name is defined for the widget at @pos
/// </return>

	public static bool IterHasRegion(this MentorLake.Gtk.GtkWidgetPathHandle path, int pos, string name, out MentorLake.Gtk.GtkRegionFlags flags)
	{
		if (path.IsInvalid) throw new Exception("Invalid handle (GtkWidgetPath)");
		return GtkWidgetPathExterns.gtk_widget_path_iter_has_region(path, pos, name, out flags);
	}

/// <summary>
/// <para>
/// Returns a list with all the class names defined for the widget
/// at position @pos in the hierarchy defined in @path.
/// </para>
/// </summary>

/// <param name="path">
/// a #GtkWidgetPath
/// </param>
/// <param name="pos">
/// position to query, -1 for the path head
/// </param>
/// <return>
/// The list of
///          classes, This is a list of strings, the #GSList contents
///          are owned by GTK+, but you should use g_slist_free() to
///          free the list itself.
/// </return>

	public static MentorLake.GLib.GSListHandle IterListClasses(this MentorLake.Gtk.GtkWidgetPathHandle path, int pos)
	{
		if (path.IsInvalid) throw new Exception("Invalid handle (GtkWidgetPath)");
		return GtkWidgetPathExterns.gtk_widget_path_iter_list_classes(path, pos);
	}

/// <summary>
/// <para>
/// Returns a list with all the region names defined for the widget
/// at position @pos in the hierarchy defined in @path.
/// </para>
/// </summary>

/// <param name="path">
/// a #GtkWidgetPath
/// </param>
/// <param name="pos">
/// position to query, -1 for the path head
/// </param>
/// <return>
/// The list of
///          regions, This is a list of strings, the #GSList contents
///          are owned by GTK+, but you should use g_slist_free() to
///          free the list itself.
/// </return>

	public static MentorLake.GLib.GSListHandle IterListRegions(this MentorLake.Gtk.GtkWidgetPathHandle path, int pos)
	{
		if (path.IsInvalid) throw new Exception("Invalid handle (GtkWidgetPath)");
		return GtkWidgetPathExterns.gtk_widget_path_iter_list_regions(path, pos);
	}

/// <summary>
/// <para>
/// Removes the class @name from the widget at position @pos in
/// the hierarchy defined in @path.
/// </para>
/// </summary>

/// <param name="path">
/// a #GtkWidgetPath
/// </param>
/// <param name="pos">
/// position to modify, -1 for the path head
/// </param>
/// <param name="name">
/// class name
/// </param>

	public static void IterRemoveClass(this MentorLake.Gtk.GtkWidgetPathHandle path, int pos, string name)
	{
		if (path.IsInvalid) throw new Exception("Invalid handle (GtkWidgetPath)");
		GtkWidgetPathExterns.gtk_widget_path_iter_remove_class(path, pos, name);
	}

/// <summary>
/// <para>
/// Removes the region @name from the widget at position @pos in
/// the hierarchy defined in @path.
/// </para>
/// </summary>

/// <param name="path">
/// a #GtkWidgetPath
/// </param>
/// <param name="pos">
/// position to modify, -1 for the path head
/// </param>
/// <param name="name">
/// region name
/// </param>

	public static void IterRemoveRegion(this MentorLake.Gtk.GtkWidgetPathHandle path, int pos, string name)
	{
		if (path.IsInvalid) throw new Exception("Invalid handle (GtkWidgetPath)");
		GtkWidgetPathExterns.gtk_widget_path_iter_remove_region(path, pos, name);
	}

/// <summary>
/// <para>
/// Sets the widget name for the widget found at position @pos
/// in the widget hierarchy defined by @path.
/// </para>
/// </summary>

/// <param name="path">
/// a #GtkWidgetPath
/// </param>
/// <param name="pos">
/// position to modify, -1 for the path head
/// </param>
/// <param name="name">
/// widget name
/// </param>

	public static void IterSetName(this MentorLake.Gtk.GtkWidgetPathHandle path, int pos, string name)
	{
		if (path.IsInvalid) throw new Exception("Invalid handle (GtkWidgetPath)");
		GtkWidgetPathExterns.gtk_widget_path_iter_set_name(path, pos, name);
	}

/// <summary>
/// <para>
/// Sets the object name for a given position in the widget hierarchy
/// defined by @path.
/// </para>
/// <para>
/// When set, the object name overrides the object type when matching
/// CSS.
/// </para>
/// </summary>

/// <param name="path">
/// a #GtkWidgetPath
/// </param>
/// <param name="pos">
/// position to modify, -1 for the path head
/// </param>
/// <param name="name">
/// object name to set or %NULL to unset
/// </param>

	public static void IterSetObjectName(this MentorLake.Gtk.GtkWidgetPathHandle path, int pos, string name)
	{
		if (path.IsInvalid) throw new Exception("Invalid handle (GtkWidgetPath)");
		GtkWidgetPathExterns.gtk_widget_path_iter_set_object_name(path, pos, name);
	}

/// <summary>
/// <para>
/// Sets the object type for a given position in the widget hierarchy
/// defined by @path.
/// </para>
/// </summary>

/// <param name="path">
/// a #GtkWidgetPath
/// </param>
/// <param name="pos">
/// position to modify, -1 for the path head
/// </param>
/// <param name="type">
/// object type to set
/// </param>

	public static void IterSetObjectType(this MentorLake.Gtk.GtkWidgetPathHandle path, int pos, MentorLake.GObject.GType type)
	{
		if (path.IsInvalid) throw new Exception("Invalid handle (GtkWidgetPath)");
		GtkWidgetPathExterns.gtk_widget_path_iter_set_object_type(path, pos, type);
	}

/// <summary>
/// <para>
/// Sets the widget name for the widget found at position @pos
/// in the widget hierarchy defined by @path.
/// </para>
/// <para>
/// If you want to update just a single state flag, you need to do
/// this manually, as this function updates all state flags.
/// </para>
/// <para>
/// ## Setting a flag
/// </para>
/// <code>
/// gtk_widget_path_iter_set_state (path, pos, gtk_widget_path_iter_get_state (path, pos) | flag);
/// gtk_widget_path_iter_set_state (path, pos, gtk_widget_path_iter_get_state (path, pos) | flag);
/// </code>
/// <para>
/// ## Unsetting a flag
/// </para>
/// <code>
/// gtk_widget_path_iter_set_state (path, pos, gtk_widget_path_iter_get_state (path, pos) &amp; ~flag);
/// gtk_widget_path_iter_set_state (path, pos, gtk_widget_path_iter_get_state (path, pos) &amp; ~flag);
/// </code>
/// </summary>

/// <param name="path">
/// a #GtkWidgetPath
/// </param>
/// <param name="pos">
/// position to modify, -1 for the path head
/// </param>
/// <param name="state">
/// state flags
/// </param>

	public static void IterSetState(this MentorLake.Gtk.GtkWidgetPathHandle path, int pos, MentorLake.Gtk.GtkStateFlags state)
	{
		if (path.IsInvalid) throw new Exception("Invalid handle (GtkWidgetPath)");
		GtkWidgetPathExterns.gtk_widget_path_iter_set_state(path, pos, state);
	}

/// <summary>
/// <para>
/// Returns the number of #GtkWidget #GTypes between the represented
/// widget and its topmost container.
/// </para>
/// </summary>

/// <param name="path">
/// a #GtkWidgetPath
/// </param>
/// <return>
/// the number of elements in the path
/// </return>

	public static int Length(this MentorLake.Gtk.GtkWidgetPathHandle path)
	{
		if (path.IsInvalid) throw new Exception("Invalid handle (GtkWidgetPath)");
		return GtkWidgetPathExterns.gtk_widget_path_length(path);
	}

/// <summary>
/// <para>
/// Prepends a widget type to the widget hierachy represented by @path.
/// </para>
/// </summary>

/// <param name="path">
/// a #GtkWidgetPath
/// </param>
/// <param name="type">
/// widget type to prepend
/// </param>

	public static void PrependType(this MentorLake.Gtk.GtkWidgetPathHandle path, MentorLake.GObject.GType type)
	{
		if (path.IsInvalid) throw new Exception("Invalid handle (GtkWidgetPath)");
		GtkWidgetPathExterns.gtk_widget_path_prepend_type(path, type);
	}

/// <summary>
/// <para>
/// Increments the reference count on @path.
/// </para>
/// </summary>

/// <param name="path">
/// a #GtkWidgetPath
/// </param>
/// <return>
/// @path itself.
/// </return>

	public static MentorLake.Gtk.GtkWidgetPathHandle Ref(this MentorLake.Gtk.GtkWidgetPathHandle path)
	{
		if (path.IsInvalid) throw new Exception("Invalid handle (GtkWidgetPath)");
		return GtkWidgetPathExterns.gtk_widget_path_ref(path);
	}

/// <summary>
/// <para>
/// Dumps the widget path into a string representation. It tries to match
/// the CSS style as closely as possible (Note that there might be paths
/// that cannot be represented in CSS).
/// </para>
/// <para>
/// The main use of this code is for debugging purposes, so that you can
/// g_print() the path or dump it in a gdb session.
/// </para>
/// </summary>

/// <param name="path">
/// the path
/// </param>
/// <return>
/// A new string describing @path.
/// </return>

	public static string ToString(this MentorLake.Gtk.GtkWidgetPathHandle path)
	{
		if (path.IsInvalid) throw new Exception("Invalid handle (GtkWidgetPath)");
		return GtkWidgetPathExterns.gtk_widget_path_to_string(path);
	}

/// <summary>
/// <para>
/// Decrements the reference count on @path, freeing the structure
/// if the reference count reaches 0.
/// </para>
/// </summary>

/// <param name="path">
/// a #GtkWidgetPath
/// </param>

	public static void Unref(this MentorLake.Gtk.GtkWidgetPathHandle path)
	{
		if (path.IsInvalid) throw new Exception("Invalid handle (GtkWidgetPath)");
		GtkWidgetPathExterns.gtk_widget_path_unref(path);
	}


	public static GtkWidgetPath Dereference(this GtkWidgetPathHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkWidgetPath>(x.DangerousGetHandle());
}
internal class GtkWidgetPathExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetPathHandle>))]
	internal static extern MentorLake.Gtk.GtkWidgetPathHandle gtk_widget_path_new();

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_widget_path_append_for_widget([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetPathHandle>))] MentorLake.Gtk.GtkWidgetPathHandle path, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_widget_path_append_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetPathHandle>))] MentorLake.Gtk.GtkWidgetPathHandle path, MentorLake.GObject.GType type);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_widget_path_append_with_siblings([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetPathHandle>))] MentorLake.Gtk.GtkWidgetPathHandle path, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetPathHandle>))] MentorLake.Gtk.GtkWidgetPathHandle siblings, uint sibling_index);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetPathHandle>))]
	internal static extern MentorLake.Gtk.GtkWidgetPathHandle gtk_widget_path_copy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetPathHandle>))] MentorLake.Gtk.GtkWidgetPathHandle path);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_path_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetPathHandle>))] MentorLake.Gtk.GtkWidgetPathHandle path);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.GObject.GType gtk_widget_path_get_object_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetPathHandle>))] MentorLake.Gtk.GtkWidgetPathHandle path);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_widget_path_has_parent([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetPathHandle>))] MentorLake.Gtk.GtkWidgetPathHandle path, MentorLake.GObject.GType type);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_widget_path_is_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetPathHandle>))] MentorLake.Gtk.GtkWidgetPathHandle path, MentorLake.GObject.GType type);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_path_iter_add_class([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetPathHandle>))] MentorLake.Gtk.GtkWidgetPathHandle path, int pos, string name);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_path_iter_add_region([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetPathHandle>))] MentorLake.Gtk.GtkWidgetPathHandle path, int pos, string name, MentorLake.Gtk.GtkRegionFlags flags);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_path_iter_clear_classes([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetPathHandle>))] MentorLake.Gtk.GtkWidgetPathHandle path, int pos);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_path_iter_clear_regions([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetPathHandle>))] MentorLake.Gtk.GtkWidgetPathHandle path, int pos);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_widget_path_iter_get_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetPathHandle>))] MentorLake.Gtk.GtkWidgetPathHandle path, int pos);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_widget_path_iter_get_object_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetPathHandle>))] MentorLake.Gtk.GtkWidgetPathHandle path, int pos);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.GObject.GType gtk_widget_path_iter_get_object_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetPathHandle>))] MentorLake.Gtk.GtkWidgetPathHandle path, int pos);

	[DllImport(GtkLibrary.Name)]
	internal static extern uint gtk_widget_path_iter_get_sibling_index([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetPathHandle>))] MentorLake.Gtk.GtkWidgetPathHandle path, int pos);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetPathHandle>))]
	internal static extern MentorLake.Gtk.GtkWidgetPathHandle gtk_widget_path_iter_get_siblings([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetPathHandle>))] MentorLake.Gtk.GtkWidgetPathHandle path, int pos);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkStateFlags gtk_widget_path_iter_get_state([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetPathHandle>))] MentorLake.Gtk.GtkWidgetPathHandle path, int pos);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_widget_path_iter_has_class([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetPathHandle>))] MentorLake.Gtk.GtkWidgetPathHandle path, int pos, string name);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_widget_path_iter_has_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetPathHandle>))] MentorLake.Gtk.GtkWidgetPathHandle path, int pos, string name);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_widget_path_iter_has_qclass([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetPathHandle>))] MentorLake.Gtk.GtkWidgetPathHandle path, int pos, MentorLake.GLib.GQuark qname);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_widget_path_iter_has_qname([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetPathHandle>))] MentorLake.Gtk.GtkWidgetPathHandle path, int pos, MentorLake.GLib.GQuark qname);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_widget_path_iter_has_qregion([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetPathHandle>))] MentorLake.Gtk.GtkWidgetPathHandle path, int pos, MentorLake.GLib.GQuark qname, out MentorLake.Gtk.GtkRegionFlags flags);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_widget_path_iter_has_region([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetPathHandle>))] MentorLake.Gtk.GtkWidgetPathHandle path, int pos, string name, out MentorLake.Gtk.GtkRegionFlags flags);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))]
	internal static extern MentorLake.GLib.GSListHandle gtk_widget_path_iter_list_classes([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetPathHandle>))] MentorLake.Gtk.GtkWidgetPathHandle path, int pos);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))]
	internal static extern MentorLake.GLib.GSListHandle gtk_widget_path_iter_list_regions([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetPathHandle>))] MentorLake.Gtk.GtkWidgetPathHandle path, int pos);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_path_iter_remove_class([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetPathHandle>))] MentorLake.Gtk.GtkWidgetPathHandle path, int pos, string name);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_path_iter_remove_region([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetPathHandle>))] MentorLake.Gtk.GtkWidgetPathHandle path, int pos, string name);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_path_iter_set_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetPathHandle>))] MentorLake.Gtk.GtkWidgetPathHandle path, int pos, string name);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_path_iter_set_object_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetPathHandle>))] MentorLake.Gtk.GtkWidgetPathHandle path, int pos, string name);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_path_iter_set_object_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetPathHandle>))] MentorLake.Gtk.GtkWidgetPathHandle path, int pos, MentorLake.GObject.GType type);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_path_iter_set_state([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetPathHandle>))] MentorLake.Gtk.GtkWidgetPathHandle path, int pos, MentorLake.Gtk.GtkStateFlags state);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_widget_path_length([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetPathHandle>))] MentorLake.Gtk.GtkWidgetPathHandle path);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_path_prepend_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetPathHandle>))] MentorLake.Gtk.GtkWidgetPathHandle path, MentorLake.GObject.GType type);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetPathHandle>))]
	internal static extern MentorLake.Gtk.GtkWidgetPathHandle gtk_widget_path_ref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetPathHandle>))] MentorLake.Gtk.GtkWidgetPathHandle path);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_widget_path_to_string([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetPathHandle>))] MentorLake.Gtk.GtkWidgetPathHandle path);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_path_unref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetPathHandle>))] MentorLake.Gtk.GtkWidgetPathHandle path);

}

/// <summary>
/// <para>
/// GtkWidgetPath is a boxed type that represents a widget hierarchy from
/// the topmost widget, typically a toplevel, to any child. This widget
/// path abstraction is used in #GtkStyleContext on behalf of the real
/// widget in order to query style information.
/// </para>
/// <para>
/// If you are using GTK+ widgets, you probably will not need to use
/// this API directly, as there is gtk_widget_get_path(), and the style
/// context returned by gtk_widget_get_style_context() will be automatically
/// updated on widget hierarchy changes.
/// </para>
/// <para>
/// The widget path generation is generally simple:
/// </para>
/// <para>
/// ## Defining a button within a window
/// </para>
/// <code>
/// {
/// {
///   GtkWidgetPath *path;
/// 
///   path = gtk_widget_path_new ();
///   gtk_widget_path_append_type (path, GTK_TYPE_WINDOW);
///   gtk_widget_path_append_type (path, GTK_TYPE_BUTTON);
/// }
/// </code>
/// <para>
/// Although more complex information, such as widget names, or
/// different classes (property that may be used by other widget
/// types) and intermediate regions may be included:
/// </para>
/// <para>
/// ## Defining the first tab widget in a notebook
/// </para>
/// <code>
/// {
/// {
///   GtkWidgetPath *path;
///   guint pos;
/// 
///   path = gtk_widget_path_new ();
/// 
///   pos = gtk_widget_path_append_type (path, GTK_TYPE_NOTEBOOK);
///   gtk_widget_path_iter_add_region (path, pos, &quot;tab&quot;, GTK_REGION_EVEN | GTK_REGION_FIRST);
/// 
///   pos = gtk_widget_path_append_type (path, GTK_TYPE_LABEL);
///   gtk_widget_path_iter_set_name (path, pos, &quot;first tab label&quot;);
/// }
/// </code>
/// <para>
/// All this information will be used to match the style information
/// that applies to the described widget.
/// </para>
/// </summary>

public struct GtkWidgetPath
{
}
