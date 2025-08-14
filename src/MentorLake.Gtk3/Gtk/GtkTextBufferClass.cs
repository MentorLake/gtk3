namespace MentorLake.Gtk;


public class GtkTextBufferClassHandle : BaseSafeHandle
{
}


public static class GtkTextBufferClassExtensions
{

	public static GtkTextBufferClass Dereference(this GtkTextBufferClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkTextBufferClass>(x.DangerousGetHandle());
}
internal class GtkTextBufferClassExterns
{
}


public struct GtkTextBufferClass
{
	/// <summary>
/// <para>
/// The object class structure needs to be the first.
/// </para>
/// </summary>

public GObjectClass parent_class;
	/// <summary>
/// <para>
/// The class handler for the #GtkTextBuffer::insert-text signal.
/// </para>
/// </summary>

public IntPtr insert_text;
	/// <summary>
/// <para>
/// The class handler for the #GtkTextBuffer::insert-pixbuf
///   signal.
/// </para>
/// </summary>

public IntPtr insert_pixbuf;
	/// <summary>
/// <para>
/// The class handler for the
///   #GtkTextBuffer::insert-child-anchor signal.
/// </para>
/// </summary>

public IntPtr insert_child_anchor;
	/// <summary>
/// <para>
/// The class handler for the #GtkTextBuffer::delete-range signal.
/// </para>
/// </summary>

public IntPtr delete_range;
	/// <summary>
/// <para>
/// The class handler for the #GtkTextBuffer::changed signal.
/// </para>
/// </summary>

public IntPtr changed;
	/// <summary>
/// <para>
/// The class handler for the #GtkTextBuffer::modified-changed
///   signal.
/// </para>
/// </summary>

public IntPtr modified_changed;
	/// <summary>
/// <para>
/// The class handler for the #GtkTextBuffer::mark-set signal.
/// </para>
/// </summary>

public IntPtr mark_set;
	/// <summary>
/// <para>
/// The class handler for the #GtkTextBuffer::mark-deleted signal.
/// </para>
/// </summary>

public IntPtr mark_deleted;
	/// <summary>
/// <para>
/// The class handler for the #GtkTextBuffer::apply-tag signal.
/// </para>
/// </summary>

public IntPtr apply_tag;
	/// <summary>
/// <para>
/// The class handler for the #GtkTextBuffer::remove-tag signal.
/// </para>
/// </summary>

public IntPtr remove_tag;
	/// <summary>
/// <para>
/// The class handler for the
///   #GtkTextBuffer::begin-user-action signal.
/// </para>
/// </summary>

public IntPtr begin_user_action;
	/// <summary>
/// <para>
/// The class handler for the #GtkTextBuffer::end-user-action
///   signal.
/// </para>
/// </summary>

public IntPtr end_user_action;
	/// <summary>
/// <para>
/// The class handler for the #GtkTextBuffer::paste-done signal.
/// </para>
/// </summary>

public IntPtr paste_done;
	
public IntPtr _gtk_reserved1;
	
public IntPtr _gtk_reserved2;
	
public IntPtr _gtk_reserved3;
	
public IntPtr _gtk_reserved4;
}
