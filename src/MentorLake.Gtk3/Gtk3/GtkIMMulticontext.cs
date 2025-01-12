namespace MentorLake.Gtk3.Gtk3;

public class GtkIMMulticontextHandle : GtkIMContextHandle
{
	public static GtkIMMulticontextHandle GtkImMulticontextNew()
	{
		return GtkIMMulticontextExterns.gtk_im_multicontext_new();
	}

}

public static class GtkIMMulticontextHandleExtensions
{
	public static T GtkImMulticontextAppendMenuitems<T>(this T context, GtkMenuShellHandle menushell) where T : GtkIMMulticontextHandle
	{
		GtkIMMulticontextExterns.gtk_im_multicontext_append_menuitems(context, menushell);
		return context;
	}

	public static string GtkImMulticontextGetContextId(this GtkIMMulticontextHandle context)
	{
		return GtkIMMulticontextExterns.gtk_im_multicontext_get_context_id(context);
	}

	public static T GtkImMulticontextSetContextId<T>(this T context, string context_id) where T : GtkIMMulticontextHandle
	{
		GtkIMMulticontextExterns.gtk_im_multicontext_set_context_id(context, context_id);
		return context;
	}

}

internal class GtkIMMulticontextExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkIMMulticontextHandle gtk_im_multicontext_new();

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_im_multicontext_append_menuitems(GtkIMMulticontextHandle context, GtkMenuShellHandle menushell);

	[DllImport(Libraries.Gtk3)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_im_multicontext_get_context_id(GtkIMMulticontextHandle context);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_im_multicontext_set_context_id(GtkIMMulticontextHandle context, string context_id);

}
