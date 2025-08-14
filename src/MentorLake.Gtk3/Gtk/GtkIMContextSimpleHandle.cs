namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// GtkIMContextSimple is a simple input method context supporting table-based
/// input methods. It has a built-in table of compose sequences that is derived
/// from the X11 Compose files.
/// </para>
/// <para>
/// GtkIMContextSimple reads additional compose sequences from the first of the
/// following files that is found: ~/.config/gtk-3.0/Compose, ~/.XCompose,
/// /usr/share/X11/locale/$locale/Compose (for locales that have a nontrivial
/// Compose file). The syntax of these files is described in the Compose(5)
/// manual page.
/// </para>
/// <para>
/// ## Unicode characters
/// </para>
/// <para>
/// GtkIMContextSimple also supports numeric entry of Unicode characters
/// by typing Ctrl-Shift-u, followed by a hexadecimal Unicode codepoint.
/// For example, Ctrl-Shift-u 1 2 3 Enter yields U+0123 LATIN SMALL LETTER
/// G WITH CEDILLA, i.e. ģ.
/// </para>
/// </summary>

public class GtkIMContextSimpleHandle : GtkIMContextHandle
{
/// <summary>
/// <para>
/// Creates a new #GtkIMContextSimple.
/// </para>
/// </summary>

/// <return>
/// a new #GtkIMContextSimple.
/// </return>

	public static MentorLake.Gtk.GtkIMContextSimpleHandle New()
	{
		return GtkIMContextSimpleHandleExterns.gtk_im_context_simple_new();
	}

}

public static class GtkIMContextSimpleHandleExtensions
{
/// <summary>
/// <para>
/// Adds an additional table from the X11 compose file.
/// </para>
/// </summary>

/// <param name="context_simple">
/// A #GtkIMContextSimple
/// </param>
/// <param name="compose_file">
/// The path of compose file
/// </param>

	public static T AddComposeFile<T>(this T context_simple, string compose_file) where T : GtkIMContextSimpleHandle
	{
		if (context_simple.IsInvalid) throw new Exception("Invalid handle (GtkIMContextSimpleHandle)");
		GtkIMContextSimpleHandleExterns.gtk_im_context_simple_add_compose_file(context_simple, compose_file);
		return context_simple;
	}

/// <summary>
/// <para>
/// Adds an additional table to search to the input context.
/// Each row of the table consists of @max_seq_len key symbols
/// followed by two #guint16 interpreted as the high and low
/// words of a #gunicode value. Tables are searched starting
/// from the last added.
/// </para>
/// <para>
/// The table must be sorted in dictionary order on the
/// numeric value of the key symbol fields. (Values beyond
/// the length of the sequence should be zero.)
/// </para>
/// </summary>

/// <param name="context_simple">
/// A #GtkIMContextSimple
/// </param>
/// <param name="data">
/// the table
/// </param>
/// <param name="max_seq_len">
/// Maximum length of a sequence in the table
/// </param>
/// <param name="n_seqs">
/// number of sequences in the table
/// </param>

	public static T AddTable<T>(this T context_simple, ushort[] data, int max_seq_len, int n_seqs) where T : GtkIMContextSimpleHandle
	{
		if (context_simple.IsInvalid) throw new Exception("Invalid handle (GtkIMContextSimpleHandle)");
		GtkIMContextSimpleHandleExterns.gtk_im_context_simple_add_table(context_simple, data, max_seq_len, n_seqs);
		return context_simple;
	}

}

internal class GtkIMContextSimpleHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkIMContextSimpleHandle>))]
	internal static extern MentorLake.Gtk.GtkIMContextSimpleHandle gtk_im_context_simple_new();

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_im_context_simple_add_compose_file([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIMContextSimpleHandle>))] MentorLake.Gtk.GtkIMContextSimpleHandle context_simple, string compose_file);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_im_context_simple_add_table([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkIMContextSimpleHandle>))] MentorLake.Gtk.GtkIMContextSimpleHandle context_simple, ushort[] data, int max_seq_len, int n_seqs);

}
