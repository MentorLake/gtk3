namespace MentorLake.Gtk;

public class GtkIMContextSimpleHandle : GtkIMContextHandle
{
	public static MentorLake.Gtk.GtkIMContextSimpleHandle New()
	{
		return GtkIMContextSimpleHandleExterns.gtk_im_context_simple_new();
	}

}

public static class GtkIMContextSimpleHandleExtensions
{
	public static T AddComposeFile<T>(this T context_simple, string compose_file) where T : GtkIMContextSimpleHandle
	{
		if (context_simple.IsInvalid || context_simple.IsClosed) throw new Exception("Invalid or closed handle (GtkIMContextSimpleHandle)");
		GtkIMContextSimpleHandleExterns.gtk_im_context_simple_add_compose_file(context_simple, compose_file);
		return context_simple;
	}

	public static T AddTable<T>(this T context_simple, ushort[] data, int max_seq_len, int n_seqs) where T : GtkIMContextSimpleHandle
	{
		if (context_simple.IsInvalid || context_simple.IsClosed) throw new Exception("Invalid or closed handle (GtkIMContextSimpleHandle)");
		GtkIMContextSimpleHandleExterns.gtk_im_context_simple_add_table(context_simple, data, max_seq_len, n_seqs);
		return context_simple;
	}

}

internal class GtkIMContextSimpleHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkIMContextSimpleHandle gtk_im_context_simple_new();

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_im_context_simple_add_compose_file([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIMContextSimpleHandle>))] MentorLake.Gtk.GtkIMContextSimpleHandle context_simple, string compose_file);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_im_context_simple_add_table([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIMContextSimpleHandle>))] MentorLake.Gtk.GtkIMContextSimpleHandle context_simple, ushort[] data, int max_seq_len, int n_seqs);

}
