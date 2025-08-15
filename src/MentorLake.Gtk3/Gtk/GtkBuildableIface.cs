namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// The #GtkBuildableIface interface contains method that are
/// necessary to allow #GtkBuilder to construct an object from
/// a #GtkBuilder UI definition.
/// </para>
/// </summary>

public class GtkBuildableIfaceHandle : BaseSafeHandle
{
}


public static class GtkBuildableIfaceExtensions
{

	public static GtkBuildableIface Dereference(this GtkBuildableIfaceHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkBuildableIface>(x.DangerousGetHandle());
}
internal class GtkBuildableIfaceExterns
{
}

/// <summary>
/// <para>
/// The #GtkBuildableIface interface contains method that are
/// necessary to allow #GtkBuilder to construct an object from
/// a #GtkBuilder UI definition.
/// </para>
/// </summary>

public struct GtkBuildableIface
{
	/// <summary>
/// <para>
/// the parent class
/// </para>
/// </summary>

public GTypeInterface g_iface;
	/// <summary>
/// <para>
/// Stores the name attribute given in the GtkBuilder UI definition.
///  #GtkWidget stores the name as object data. Implement this method if your
///  object has some notion of “name” and it makes sense to map the XML name
///  attribute to it.
/// </para>
/// </summary>

public IntPtr set_name;
	/// <summary>
/// <para>
/// The getter corresponding to @set_name. Implement this
///  if you implement @set_name.
/// </para>
/// </summary>

public IntPtr get_name;
	/// <summary>
/// <para>
/// Adds a child. The @type parameter can be used to
///  differentiate the kind of child. #GtkContainer implements this
///  to add add a child widget to the container, #GtkNotebook uses
///  the @type to distinguish between page labels (of type &quot;page-label&quot;)
///  and normal children.
/// </para>
/// </summary>

public IntPtr add_child;
	/// <summary>
/// <para>
/// Sets a property of a buildable object.
///  It is normally not necessary to implement this, g_object_set_property()
///  is used by default. #GtkWindow implements this to delay showing itself
///  (i.e. setting the #GtkWidget:visible property) until the whole interface
///  is created.
/// </para>
/// </summary>

public IntPtr set_buildable_property;
	/// <summary>
/// <para>
/// Constructs a child of a buildable that has been
///  specified as “constructor” in the UI definition. #GtkUIManager implements
///  this to reference to a widget created in a `&amp;lt;ui&amp;gt;` tag which is outside
///  of the normal GtkBuilder UI definition hierarchy.  A reference to the
///  constructed object is returned and becomes owned by the caller.
/// </para>
/// </summary>

public IntPtr construct_child;
	/// <summary>
/// <para>
/// Implement this if the buildable needs to parse
///  content below `&amp;lt;child&amp;gt;`. To handle an element, the implementation
///  must fill in the @parser and @user_data and return %TRUE.
///  #GtkWidget implements this to parse keyboard accelerators specified
///  in `&amp;lt;accelerator&amp;gt;` elements. #GtkContainer implements it to map
///  properties defined via `&amp;lt;packing&amp;gt;` elements to child properties.
///  Note that @user_data must be freed in @custom_tag_end or @custom_finished.
/// </para>
/// </summary>

public IntPtr custom_tag_start;
	/// <summary>
/// <para>
/// Called for the end tag of each custom element that is
///  handled by the buildable (see @custom_tag_start).
/// </para>
/// </summary>

public IntPtr custom_tag_end;
	/// <summary>
/// <para>
/// Called for each custom tag handled by the buildable
///  when the builder finishes parsing (see @custom_tag_start)
/// </para>
/// </summary>

public IntPtr custom_finished;
	/// <summary>
/// <para>
/// Called when a builder finishes the parsing
///  of a UI definition. It is normally not necessary to implement this,
///  unless you need to perform special cleanup actions. #GtkWindow sets
///  the #GtkWidget:visible property here.
/// </para>
/// </summary>

public IntPtr parser_finished;
	/// <summary>
/// <para>
/// Returns an internal child of a buildable.
///  #GtkDialog implements this to give access to its @vbox, making
///  it possible to add children to the vbox in a UI definition.
///  Implement this if the buildable has internal children that may
///  need to be accessed from a UI definition.
/// </para>
/// </summary>

public IntPtr get_internal_child;
}
