namespace MentorLake.Gtk;

public class GtkIMMulticontextHandle : GtkIMContextHandle
{
	public static MentorLake.Gtk.GtkIMMulticontextHandle New()
	{
		return GtkIMMulticontextHandleExterns.gtk_im_multicontext_new();
	}

}

public static class GtkIMMulticontextHandleExtensions
{
	public static T AppendMenuitems<T>(this T context, MentorLake.Gtk.GtkMenuShellHandle menushell) where T : GtkIMMulticontextHandle
	{
		if (context.IsInvalid || context.IsClosed) throw new Exception("Invalid or closed handle (GtkIMMulticontextHandle)");
		GtkIMMulticontextHandleExterns.gtk_im_multicontext_append_menuitems(context, menushell);
		return context;
	}

	public static string GetContextId(this MentorLake.Gtk.GtkIMMulticontextHandle context)
	{
		if (context.IsInvalid || context.IsClosed) throw new Exception("Invalid or closed handle (GtkIMMulticontextHandle)");
		return GtkIMMulticontextHandleExterns.gtk_im_multicontext_get_context_id(context);
	}

	public static T SetContextId<T>(this T context, string context_id) where T : GtkIMMulticontextHandle
	{
		if (context.IsInvalid || context.IsClosed) throw new Exception("Invalid or closed handle (GtkIMMulticontextHandle)");
		GtkIMMulticontextHandleExterns.gtk_im_multicontext_set_context_id(context, context_id);
		return context;
	}

}

internal class GtkIMMulticontextHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkIMMulticontextHandle gtk_im_multicontext_new();

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_im_multicontext_append_menuitems([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIMMulticontextHandle>))] MentorLake.Gtk.GtkIMMulticontextHandle context, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuShellHandle>))] MentorLake.Gtk.GtkMenuShellHandle menushell);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_im_multicontext_get_context_id([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIMMulticontextHandle>))] MentorLake.Gtk.GtkIMMulticontextHandle context);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_im_multicontext_set_context_id([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIMMulticontextHandle>))] MentorLake.Gtk.GtkIMMulticontextHandle context, string context_id);

}
