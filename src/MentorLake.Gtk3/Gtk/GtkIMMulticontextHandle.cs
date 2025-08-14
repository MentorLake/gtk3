namespace MentorLake.Gtk;


public class GtkIMMulticontextHandle : GtkIMContextHandle
{
/// <summary>
/// <para>
/// Creates a new #GtkIMMulticontext.
/// </para>
/// </summary>

/// <return>
/// a new #GtkIMMulticontext.
/// </return>

	public static MentorLake.Gtk.GtkIMMulticontextHandle New()
	{
		return GtkIMMulticontextHandleExterns.gtk_im_multicontext_new();
	}

}

public static class GtkIMMulticontextHandleExtensions
{
/// <summary>
/// <para>
/// Add menuitems for various available input methods to a menu;
/// the menuitems, when selected, will switch the input method
/// for the context and the global default input method.
/// </para>
/// </summary>

/// <param name="context">
/// a #GtkIMMulticontext
/// </param>
/// <param name="menushell">
/// a #GtkMenuShell
/// </param>

	public static T AppendMenuitems<T>(this T context, MentorLake.Gtk.GtkMenuShellHandle menushell) where T : GtkIMMulticontextHandle
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GtkIMMulticontextHandle)");
		GtkIMMulticontextHandleExterns.gtk_im_multicontext_append_menuitems(context, menushell);
		return context;
	}

/// <summary>
/// <para>
/// Gets the id of the currently active slave of the @context.
/// </para>
/// </summary>

/// <param name="context">
/// a #GtkIMMulticontext
/// </param>
/// <return>
/// the id of the currently active slave
/// </return>

	public static string GetContextId(this MentorLake.Gtk.GtkIMMulticontextHandle context)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GtkIMMulticontextHandle)");
		return GtkIMMulticontextHandleExterns.gtk_im_multicontext_get_context_id(context);
	}

/// <summary>
/// <para>
/// Sets the context id for @context.
/// </para>
/// <para>
/// This causes the currently active slave of @context to be
/// replaced by the slave corresponding to the new context id.
/// </para>
/// </summary>

/// <param name="context">
/// a #GtkIMMulticontext
/// </param>
/// <param name="context_id">
/// the id to use
/// </param>

	public static T SetContextId<T>(this T context, string context_id) where T : GtkIMMulticontextHandle
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GtkIMMulticontextHandle)");
		GtkIMMulticontextHandleExterns.gtk_im_multicontext_set_context_id(context, context_id);
		return context;
	}

}

internal class GtkIMMulticontextHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkIMMulticontextHandle>))]
	internal static extern MentorLake.Gtk.GtkIMMulticontextHandle gtk_im_multicontext_new();

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_im_multicontext_append_menuitems([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIMMulticontextHandle>))] MentorLake.Gtk.GtkIMMulticontextHandle context, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuShellHandle>))] MentorLake.Gtk.GtkMenuShellHandle menushell);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_im_multicontext_get_context_id([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIMMulticontextHandle>))] MentorLake.Gtk.GtkIMMulticontextHandle context);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_im_multicontext_set_context_id([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIMMulticontextHandle>))] MentorLake.Gtk.GtkIMMulticontextHandle context, string context_id);

}
