namespace MentorLake.GLib;

public class GScannerHandle : BaseSafeHandle
{
}


public static class GScannerExtensions
{
	public static uint CurLine(this MentorLake.GLib.GScannerHandle scanner)
	{
		return GScannerExterns.g_scanner_cur_line(scanner);
	}

	public static uint CurPosition(this MentorLake.GLib.GScannerHandle scanner)
	{
		return GScannerExterns.g_scanner_cur_position(scanner);
	}

	public static MentorLake.GLib.GTokenType CurToken(this MentorLake.GLib.GScannerHandle scanner)
	{
		return GScannerExterns.g_scanner_cur_token(scanner);
	}

	public static MentorLake.GLib.GTokenValue CurValue(this MentorLake.GLib.GScannerHandle scanner)
	{
		return GScannerExterns.g_scanner_cur_value(scanner);
	}

	public static void Destroy(this MentorLake.GLib.GScannerHandle scanner)
	{
		GScannerExterns.g_scanner_destroy(scanner);
	}

	public static bool Eof(this MentorLake.GLib.GScannerHandle scanner)
	{
		return GScannerExterns.g_scanner_eof(scanner);
	}

	public static void Error(this MentorLake.GLib.GScannerHandle scanner, string format, IntPtr @__arglist)
	{
		GScannerExterns.g_scanner_error(scanner, format, @__arglist);
	}

	public static MentorLake.GLib.GTokenType GetNextToken(this MentorLake.GLib.GScannerHandle scanner)
	{
		return GScannerExterns.g_scanner_get_next_token(scanner);
	}

	public static void InputFile(this MentorLake.GLib.GScannerHandle scanner, int input_fd)
	{
		GScannerExterns.g_scanner_input_file(scanner, input_fd);
	}

	public static void InputText(this MentorLake.GLib.GScannerHandle scanner, string text, uint text_len)
	{
		GScannerExterns.g_scanner_input_text(scanner, text, text_len);
	}

	public static IntPtr LookupSymbol(this MentorLake.GLib.GScannerHandle scanner, string symbol)
	{
		return GScannerExterns.g_scanner_lookup_symbol(scanner, symbol);
	}

	public static MentorLake.GLib.GTokenType PeekNextToken(this MentorLake.GLib.GScannerHandle scanner)
	{
		return GScannerExterns.g_scanner_peek_next_token(scanner);
	}

	public static void ScopeAddSymbol(this MentorLake.GLib.GScannerHandle scanner, uint scope_id, string symbol, IntPtr value)
	{
		GScannerExterns.g_scanner_scope_add_symbol(scanner, scope_id, symbol, value);
	}

	public static void ScopeForeachSymbol(this MentorLake.GLib.GScannerHandle scanner, uint scope_id, MentorLake.GLib.GHFunc func, IntPtr user_data)
	{
		GScannerExterns.g_scanner_scope_foreach_symbol(scanner, scope_id, func, user_data);
	}

	public static IntPtr ScopeLookupSymbol(this MentorLake.GLib.GScannerHandle scanner, uint scope_id, string symbol)
	{
		return GScannerExterns.g_scanner_scope_lookup_symbol(scanner, scope_id, symbol);
	}

	public static void ScopeRemoveSymbol(this MentorLake.GLib.GScannerHandle scanner, uint scope_id, string symbol)
	{
		GScannerExterns.g_scanner_scope_remove_symbol(scanner, scope_id, symbol);
	}

	public static uint SetScope(this MentorLake.GLib.GScannerHandle scanner, uint scope_id)
	{
		return GScannerExterns.g_scanner_set_scope(scanner, scope_id);
	}

	public static void SyncFileOffset(this MentorLake.GLib.GScannerHandle scanner)
	{
		GScannerExterns.g_scanner_sync_file_offset(scanner);
	}

	public static void UnexpToken(this MentorLake.GLib.GScannerHandle scanner, MentorLake.GLib.GTokenType expected_token, string identifier_spec, string symbol_spec, string symbol_name, string message, int is_error)
	{
		GScannerExterns.g_scanner_unexp_token(scanner, expected_token, identifier_spec, symbol_spec, symbol_name, message, is_error);
	}

	public static void Warn(this MentorLake.GLib.GScannerHandle scanner, string format, IntPtr @__arglist)
	{
		GScannerExterns.g_scanner_warn(scanner, format, @__arglist);
	}


	public static GScanner Dereference(this GScannerHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GScanner>(x.DangerousGetHandle());
}
internal class GScannerExterns
{
	[DllImport(GLibLibrary.Name)]
	internal static extern uint g_scanner_cur_line([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GScannerHandle>))] MentorLake.GLib.GScannerHandle scanner);

	[DllImport(GLibLibrary.Name)]
	internal static extern uint g_scanner_cur_position([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GScannerHandle>))] MentorLake.GLib.GScannerHandle scanner);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GTokenType g_scanner_cur_token([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GScannerHandle>))] MentorLake.GLib.GScannerHandle scanner);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GTokenValue g_scanner_cur_value([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GScannerHandle>))] MentorLake.GLib.GScannerHandle scanner);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_scanner_destroy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GScannerHandle>))] MentorLake.GLib.GScannerHandle scanner);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_scanner_eof([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GScannerHandle>))] MentorLake.GLib.GScannerHandle scanner);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_scanner_error([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GScannerHandle>))] MentorLake.GLib.GScannerHandle scanner, string format, IntPtr @__arglist);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GTokenType g_scanner_get_next_token([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GScannerHandle>))] MentorLake.GLib.GScannerHandle scanner);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_scanner_input_file([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GScannerHandle>))] MentorLake.GLib.GScannerHandle scanner, int input_fd);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_scanner_input_text([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GScannerHandle>))] MentorLake.GLib.GScannerHandle scanner, string text, uint text_len);

	[DllImport(GLibLibrary.Name)]
	internal static extern IntPtr g_scanner_lookup_symbol([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GScannerHandle>))] MentorLake.GLib.GScannerHandle scanner, string symbol);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GTokenType g_scanner_peek_next_token([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GScannerHandle>))] MentorLake.GLib.GScannerHandle scanner);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_scanner_scope_add_symbol([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GScannerHandle>))] MentorLake.GLib.GScannerHandle scanner, uint scope_id, string symbol, IntPtr value);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_scanner_scope_foreach_symbol([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GScannerHandle>))] MentorLake.GLib.GScannerHandle scanner, uint scope_id, MentorLake.GLib.GHFunc func, IntPtr user_data);

	[DllImport(GLibLibrary.Name)]
	internal static extern IntPtr g_scanner_scope_lookup_symbol([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GScannerHandle>))] MentorLake.GLib.GScannerHandle scanner, uint scope_id, string symbol);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_scanner_scope_remove_symbol([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GScannerHandle>))] MentorLake.GLib.GScannerHandle scanner, uint scope_id, string symbol);

	[DllImport(GLibLibrary.Name)]
	internal static extern uint g_scanner_set_scope([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GScannerHandle>))] MentorLake.GLib.GScannerHandle scanner, uint scope_id);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_scanner_sync_file_offset([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GScannerHandle>))] MentorLake.GLib.GScannerHandle scanner);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_scanner_unexp_token([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GScannerHandle>))] MentorLake.GLib.GScannerHandle scanner, MentorLake.GLib.GTokenType expected_token, string identifier_spec, string symbol_spec, string symbol_name, string message, int is_error);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_scanner_warn([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GScannerHandle>))] MentorLake.GLib.GScannerHandle scanner, string format, IntPtr @__arglist);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GScannerHandle g_scanner_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GScannerConfigHandle>))] MentorLake.GLib.GScannerConfigHandle config_templ);

}

public struct GScanner
{
	public IntPtr user_data;
	public uint max_parse_errors;
	public uint parse_errors;
	public string input_name;
	public IntPtr qdata;
	public IntPtr config;
	public GTokenType token;
	public GTokenValue value;
	public uint line;
	public uint position;
	public GTokenType next_token;
	public GTokenValue next_value;
	public uint next_line;
	public uint next_position;
	public GScannerMsgFunc msg_handler;
	public static MentorLake.GLib.GScannerHandle New(MentorLake.GLib.GScannerConfigHandle config_templ)
	{
		return GScannerExterns.g_scanner_new(config_templ);
	}

}
