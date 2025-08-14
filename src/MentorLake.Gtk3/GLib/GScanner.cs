namespace MentorLake.GLib;

/// <summary>
/// <para>
/// `GScanner` provides a general-purpose lexical scanner.
/// </para>
/// <para>
/// You should set @input_name after creating the scanner, since
/// it is used by the default message handler when displaying
/// warnings and errors. If you are scanning a file, the filename
/// would be a good choice.
/// </para>
/// <para>
/// The @user_data and @max_parse_errors fields are not used.
/// If you need to associate extra data with the scanner you
/// can place them here.
/// </para>
/// <para>
/// If you want to use your own message handler you can set the
/// @msg_handler field. The type of the message handler function
/// is declared by #GScannerMsgFunc.
/// </para>
/// </summary>

public class GScannerHandle : BaseSafeHandle
{
}


public static class GScannerExtensions
{
/// <summary>
/// <para>
/// Returns the current line in the input stream (counting
/// from 1). This is the line of the last token parsed via
/// g_scanner_get_next_token().
/// </para>
/// </summary>

/// <param name="scanner">
/// a #GScanner
/// </param>
/// <return>
/// the current line
/// </return>

	public static uint CurLine(this MentorLake.GLib.GScannerHandle scanner)
	{
		if (scanner.IsInvalid) throw new Exception("Invalid handle (GScanner)");
		return GScannerExterns.g_scanner_cur_line(scanner);
	}

/// <summary>
/// <para>
/// Returns the current position in the current line (counting
/// from 0). This is the position of the last token parsed via
/// g_scanner_get_next_token().
/// </para>
/// </summary>

/// <param name="scanner">
/// a #GScanner
/// </param>
/// <return>
/// the current position on the line
/// </return>

	public static uint CurPosition(this MentorLake.GLib.GScannerHandle scanner)
	{
		if (scanner.IsInvalid) throw new Exception("Invalid handle (GScanner)");
		return GScannerExterns.g_scanner_cur_position(scanner);
	}

/// <summary>
/// <para>
/// Gets the current token type. This is simply the @token
/// field in the #GScanner structure.
/// </para>
/// </summary>

/// <param name="scanner">
/// a #GScanner
/// </param>
/// <return>
/// the current token type
/// </return>

	public static MentorLake.GLib.GTokenType CurToken(this MentorLake.GLib.GScannerHandle scanner)
	{
		if (scanner.IsInvalid) throw new Exception("Invalid handle (GScanner)");
		return GScannerExterns.g_scanner_cur_token(scanner);
	}

/// <summary>
/// <para>
/// Gets the current token value. This is simply the @value
/// field in the #GScanner structure.
/// </para>
/// </summary>

/// <param name="scanner">
/// a #GScanner
/// </param>
/// <return>
/// the current token value
/// </return>

	public static MentorLake.GLib.GTokenValue CurValue(this MentorLake.GLib.GScannerHandle scanner)
	{
		if (scanner.IsInvalid) throw new Exception("Invalid handle (GScanner)");
		return GScannerExterns.g_scanner_cur_value(scanner);
	}

/// <summary>
/// <para>
/// Frees all memory used by the #GScanner.
/// </para>
/// </summary>

/// <param name="scanner">
/// a #GScanner
/// </param>

	public static void Destroy(this MentorLake.GLib.GScannerHandle scanner)
	{
		if (scanner.IsInvalid) throw new Exception("Invalid handle (GScanner)");
		GScannerExterns.g_scanner_destroy(scanner);
	}

/// <summary>
/// <para>
/// Returns %TRUE if the scanner has reached the end of
/// the file or text buffer.
/// </para>
/// </summary>

/// <param name="scanner">
/// a #GScanner
/// </param>
/// <return>
/// %TRUE if the scanner has reached the end of
///     the file or text buffer
/// </return>

	public static bool Eof(this MentorLake.GLib.GScannerHandle scanner)
	{
		if (scanner.IsInvalid) throw new Exception("Invalid handle (GScanner)");
		return GScannerExterns.g_scanner_eof(scanner);
	}

/// <summary>
/// <para>
/// Outputs an error message, via the #GScanner message handler.
/// </para>
/// </summary>

/// <param name="scanner">
/// a #GScanner
/// </param>
/// <param name="format">
/// the message format. See the printf() documentation
/// </param>
/// <param name="@__arglist">
/// the parameters to insert into the format string
/// </param>

	public static void Error(this MentorLake.GLib.GScannerHandle scanner, string format, IntPtr @__arglist)
	{
		if (scanner.IsInvalid) throw new Exception("Invalid handle (GScanner)");
		GScannerExterns.g_scanner_error(scanner, format, @__arglist);
	}

/// <summary>
/// <para>
/// Parses the next token just like g_scanner_peek_next_token()
/// and also removes it from the input stream. The token data is
/// placed in the @token, @value, @line, and @position fields of
/// the #GScanner structure.
/// </para>
/// </summary>

/// <param name="scanner">
/// a #GScanner
/// </param>
/// <return>
/// the type of the token
/// </return>

	public static MentorLake.GLib.GTokenType GetNextToken(this MentorLake.GLib.GScannerHandle scanner)
	{
		if (scanner.IsInvalid) throw new Exception("Invalid handle (GScanner)");
		return GScannerExterns.g_scanner_get_next_token(scanner);
	}

/// <summary>
/// <para>
/// Prepares to scan a file.
/// </para>
/// </summary>

/// <param name="scanner">
/// a #GScanner
/// </param>
/// <param name="input_fd">
/// a file descriptor
/// </param>

	public static void InputFile(this MentorLake.GLib.GScannerHandle scanner, int input_fd)
	{
		if (scanner.IsInvalid) throw new Exception("Invalid handle (GScanner)");
		GScannerExterns.g_scanner_input_file(scanner, input_fd);
	}

/// <summary>
/// <para>
/// Prepares to scan a text buffer.
/// </para>
/// </summary>

/// <param name="scanner">
/// a #GScanner
/// </param>
/// <param name="text">
/// the text buffer to scan
/// </param>
/// <param name="text_len">
/// the length of the text buffer
/// </param>

	public static void InputText(this MentorLake.GLib.GScannerHandle scanner, string text, uint text_len)
	{
		if (scanner.IsInvalid) throw new Exception("Invalid handle (GScanner)");
		GScannerExterns.g_scanner_input_text(scanner, text, text_len);
	}

/// <summary>
/// <para>
/// Looks up a symbol in the current scope and return its value.
/// If the symbol is not bound in the current scope, %NULL is
/// returned.
/// </para>
/// </summary>

/// <param name="scanner">
/// a #GScanner
/// </param>
/// <param name="symbol">
/// the symbol to look up
/// </param>
/// <return>
/// the value of @symbol in the current scope, or %NULL
///     if @symbol is not bound in the current scope
/// </return>

	public static IntPtr LookupSymbol(this MentorLake.GLib.GScannerHandle scanner, string symbol)
	{
		if (scanner.IsInvalid) throw new Exception("Invalid handle (GScanner)");
		return GScannerExterns.g_scanner_lookup_symbol(scanner, symbol);
	}

/// <summary>
/// <para>
/// Parses the next token, without removing it from the input stream.
/// The token data is placed in the @next_token, @next_value, @next_line,
/// and @next_position fields of the #GScanner structure.
/// </para>
/// <para>
/// Note that, while the token is not removed from the input stream
/// (i.e. the next call to g_scanner_get_next_token() will return the
/// same token), it will not be reevaluated. This can lead to surprising
/// results when changing scope or the scanner configuration after peeking
/// the next token. Getting the next token after switching the scope or
/// configuration will return whatever was peeked before, regardless of
/// any symbols that may have been added or removed in the new scope.
/// </para>
/// </summary>

/// <param name="scanner">
/// a #GScanner
/// </param>
/// <return>
/// the type of the token
/// </return>

	public static MentorLake.GLib.GTokenType PeekNextToken(this MentorLake.GLib.GScannerHandle scanner)
	{
		if (scanner.IsInvalid) throw new Exception("Invalid handle (GScanner)");
		return GScannerExterns.g_scanner_peek_next_token(scanner);
	}

/// <summary>
/// <para>
/// Adds a symbol to the given scope.
/// </para>
/// </summary>

/// <param name="scanner">
/// a #GScanner
/// </param>
/// <param name="scope_id">
/// the scope id
/// </param>
/// <param name="symbol">
/// the symbol to add
/// </param>
/// <param name="value">
/// the value of the symbol
/// </param>

	public static void ScopeAddSymbol(this MentorLake.GLib.GScannerHandle scanner, uint scope_id, string symbol, IntPtr value)
	{
		if (scanner.IsInvalid) throw new Exception("Invalid handle (GScanner)");
		GScannerExterns.g_scanner_scope_add_symbol(scanner, scope_id, symbol, value);
	}

/// <summary>
/// <para>
/// Calls the given function for each of the symbol/value pairs
/// in the given scope of the #GScanner. The function is passed
/// the symbol and value of each pair, and the given @user_data
/// parameter.
/// </para>
/// </summary>

/// <param name="scanner">
/// a #GScanner
/// </param>
/// <param name="scope_id">
/// the scope id
/// </param>
/// <param name="func">
/// the function to call for each symbol/value pair
/// </param>
/// <param name="user_data">
/// user data to pass to the function
/// </param>

	public static void ScopeForeachSymbol(this MentorLake.GLib.GScannerHandle scanner, uint scope_id, MentorLake.GLib.GHFunc func, IntPtr user_data)
	{
		if (scanner.IsInvalid) throw new Exception("Invalid handle (GScanner)");
		GScannerExterns.g_scanner_scope_foreach_symbol(scanner, scope_id, func, user_data);
	}

/// <summary>
/// <para>
/// Looks up a symbol in a scope and return its value. If the
/// symbol is not bound in the scope, %NULL is returned.
/// </para>
/// </summary>

/// <param name="scanner">
/// a #GScanner
/// </param>
/// <param name="scope_id">
/// the scope id
/// </param>
/// <param name="symbol">
/// the symbol to look up
/// </param>
/// <return>
/// the value of @symbol in the given scope, or %NULL
///     if @symbol is not bound in the given scope.
/// </return>

	public static IntPtr ScopeLookupSymbol(this MentorLake.GLib.GScannerHandle scanner, uint scope_id, string symbol)
	{
		if (scanner.IsInvalid) throw new Exception("Invalid handle (GScanner)");
		return GScannerExterns.g_scanner_scope_lookup_symbol(scanner, scope_id, symbol);
	}

/// <summary>
/// <para>
/// Removes a symbol from a scope.
/// </para>
/// </summary>

/// <param name="scanner">
/// a #GScanner
/// </param>
/// <param name="scope_id">
/// the scope id
/// </param>
/// <param name="symbol">
/// the symbol to remove
/// </param>

	public static void ScopeRemoveSymbol(this MentorLake.GLib.GScannerHandle scanner, uint scope_id, string symbol)
	{
		if (scanner.IsInvalid) throw new Exception("Invalid handle (GScanner)");
		GScannerExterns.g_scanner_scope_remove_symbol(scanner, scope_id, symbol);
	}

/// <summary>
/// <para>
/// Sets the current scope.
/// </para>
/// </summary>

/// <param name="scanner">
/// a #GScanner
/// </param>
/// <param name="scope_id">
/// the new scope id
/// </param>
/// <return>
/// the old scope id
/// </return>

	public static uint SetScope(this MentorLake.GLib.GScannerHandle scanner, uint scope_id)
	{
		if (scanner.IsInvalid) throw new Exception("Invalid handle (GScanner)");
		return GScannerExterns.g_scanner_set_scope(scanner, scope_id);
	}

/// <summary>
/// <para>
/// Rewinds the filedescriptor to the current buffer position
/// and blows the file read ahead buffer. This is useful for
/// third party uses of the scanners filedescriptor, which hooks
/// onto the current scanning position.
/// </para>
/// </summary>

/// <param name="scanner">
/// a #GScanner
/// </param>

	public static void SyncFileOffset(this MentorLake.GLib.GScannerHandle scanner)
	{
		if (scanner.IsInvalid) throw new Exception("Invalid handle (GScanner)");
		GScannerExterns.g_scanner_sync_file_offset(scanner);
	}

/// <summary>
/// <para>
/// Outputs a message through the scanner's msg_handler,
/// resulting from an unexpected token in the input stream.
/// Note that you should not call g_scanner_peek_next_token()
/// followed by g_scanner_unexp_token() without an intermediate
/// call to g_scanner_get_next_token(), as g_scanner_unexp_token()
/// evaluates the scanner's current token (not the peeked token)
/// to construct part of the message.
/// </para>
/// </summary>

/// <param name="scanner">
/// a #GScanner
/// </param>
/// <param name="expected_token">
/// the expected token
/// </param>
/// <param name="identifier_spec">
/// a string describing how the scanner's user
///     refers to identifiers (%NULL defaults to "identifier").
///     This is used if @expected_token is %G_TOKEN_IDENTIFIER or
///     %G_TOKEN_IDENTIFIER_NULL.
/// </param>
/// <param name="symbol_spec">
/// a string describing how the scanner's user refers
///     to symbols (%NULL defaults to "symbol"). This is used if
///     @expected_token is %G_TOKEN_SYMBOL or any token value greater
///     than %G_TOKEN_LAST.
/// </param>
/// <param name="symbol_name">
/// the name of the symbol, if the scanner's current
///     token is a symbol.
/// </param>
/// <param name="message">
/// a message string to output at the end of the
///     warning/error, or %NULL.
/// </param>
/// <param name="is_error">
/// if %TRUE it is output as an error. If %FALSE it is
///     output as a warning.
/// </param>

	public static void UnexpToken(this MentorLake.GLib.GScannerHandle scanner, MentorLake.GLib.GTokenType expected_token, string identifier_spec, string symbol_spec, string symbol_name, string message, int is_error)
	{
		if (scanner.IsInvalid) throw new Exception("Invalid handle (GScanner)");
		GScannerExterns.g_scanner_unexp_token(scanner, expected_token, identifier_spec, symbol_spec, symbol_name, message, is_error);
	}

/// <summary>
/// <para>
/// Outputs a warning message, via the #GScanner message handler.
/// </para>
/// </summary>

/// <param name="scanner">
/// a #GScanner
/// </param>
/// <param name="format">
/// the message format. See the printf() documentation
/// </param>
/// <param name="@__arglist">
/// the parameters to insert into the format string
/// </param>

	public static void Warn(this MentorLake.GLib.GScannerHandle scanner, string format, IntPtr @__arglist)
	{
		if (scanner.IsInvalid) throw new Exception("Invalid handle (GScanner)");
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
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GScannerHandle>))]
	internal static extern MentorLake.GLib.GScannerHandle g_scanner_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GScannerConfigHandle>))] MentorLake.GLib.GScannerConfigHandle config_templ);

}

/// <summary>
/// <para>
/// `GScanner` provides a general-purpose lexical scanner.
/// </para>
/// <para>
/// You should set @input_name after creating the scanner, since
/// it is used by the default message handler when displaying
/// warnings and errors. If you are scanning a file, the filename
/// would be a good choice.
/// </para>
/// <para>
/// The @user_data and @max_parse_errors fields are not used.
/// If you need to associate extra data with the scanner you
/// can place them here.
/// </para>
/// <para>
/// If you want to use your own message handler you can set the
/// @msg_handler field. The type of the message handler function
/// is declared by #GScannerMsgFunc.
/// </para>
/// </summary>

public struct GScanner
{
	/// <summary>
/// <para>
/// unused
/// </para>
/// </summary>

public IntPtr user_data;
	/// <summary>
/// <para>
/// unused
/// </para>
/// </summary>

public uint max_parse_errors;
	/// <summary>
/// <para>
/// g_scanner_error() increments this field
/// </para>
/// </summary>

public uint parse_errors;
	/// <summary>
/// <para>
/// name of input stream, featured by the default message handler
/// </para>
/// </summary>

public string input_name;
	/// <summary>
/// <para>
/// quarked data
/// </para>
/// </summary>

public IntPtr qdata;
	/// <summary>
/// <para>
/// link into the scanner configuration
/// </para>
/// </summary>

public IntPtr config;
	/// <summary>
/// <para>
/// token parsed by the last g_scanner_get_next_token()
/// </para>
/// </summary>

public GTokenType token;
	/// <summary>
/// <para>
/// value of the last token from g_scanner_get_next_token()
/// </para>
/// </summary>

public GTokenValue value;
	/// <summary>
/// <para>
/// line number of the last token from g_scanner_get_next_token()
/// </para>
/// </summary>

public uint line;
	/// <summary>
/// <para>
/// char number of the last token from g_scanner_get_next_token()
/// </para>
/// </summary>

public uint position;
	/// <summary>
/// <para>
/// token parsed by the last g_scanner_peek_next_token()
/// </para>
/// </summary>

public GTokenType next_token;
	/// <summary>
/// <para>
/// value of the last token from g_scanner_peek_next_token()
/// </para>
/// </summary>

public GTokenValue next_value;
	/// <summary>
/// <para>
/// line number of the last token from g_scanner_peek_next_token()
/// </para>
/// </summary>

public uint next_line;
	/// <summary>
/// <para>
/// char number of the last token from g_scanner_peek_next_token()
/// </para>
/// </summary>

public uint next_position;
	/// <summary>
/// <para>
/// handler function for _warn and _error
/// </para>
/// </summary>

public GScannerMsgFunc msg_handler;
/// <summary>
/// <para>
/// Creates a new #GScanner.
/// </para>
/// <para>
/// The @config_templ structure specifies the initial settings
/// of the scanner, which are copied into the #GScanner
/// @config field. If you pass %NULL then the default settings
/// are used.
/// </para>
/// </summary>

/// <param name="config_templ">
/// the initial scanner settings
/// </param>
/// <return>
/// the new #GScanner
/// </return>

	public static MentorLake.GLib.GScannerHandle New(MentorLake.GLib.GScannerConfigHandle config_templ)
	{
		return GScannerExterns.g_scanner_new(config_templ);
	}

}
