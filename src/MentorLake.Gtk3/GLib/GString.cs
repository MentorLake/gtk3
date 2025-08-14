namespace MentorLake.GLib;

/// <summary>
/// <para>
/// A `GString` is an object that handles the memory management of a C string.
/// </para>
/// <para>
/// The emphasis of `GString` is on text, typically UTF-8. Crucially, the "str" member
/// of a `GString` is guaranteed to have a trailing nul character, and it is therefore
/// always safe to call functions such as `strchr()` or `strdup()` on it.
/// </para>
/// <para>
/// However, a `GString` can also hold arbitrary binary data, because it has a "len" member,
/// which includes any possible embedded nul characters in the data. Conceptually then,
/// `GString` is like a `GByteArray` with the addition of many convenience methods for
/// text, and a guaranteed nul terminator.
/// </para>
/// </summary>

public class GStringHandle : BaseSafeHandle
{
/// <summary>
/// <para>
/// Creates a new #GString, initialized with the given string.
/// </para>
/// </summary>

/// <param name="init">
/// the initial text to copy into the string, or %NULL to
///   start with an empty string
/// </param>
/// <return>
/// the new #GString
/// </return>

	public static MentorLake.GLib.GStringHandle New(string init)
	{
		return GStringExterns.g_string_new(init);
	}

/// <summary>
/// <para>
/// Creates a new #GString with @len bytes of the @init buffer.
/// Because a length is provided, @init need not be nul-terminated,
/// and can contain embedded nul bytes.
/// </para>
/// <para>
/// Since this function does not stop at nul bytes, it is the caller's
/// responsibility to ensure that @init has at least @len addressable
/// bytes.
/// </para>
/// </summary>

/// <param name="init">
/// initial contents of the string
/// </param>
/// <param name="len">
/// length of @init to use
/// </param>
/// <return>
/// a new #GString
/// </return>

	public static MentorLake.GLib.GStringHandle NewLen(string init, UIntPtr len)
	{
		return GStringExterns.g_string_new_len(init, len);
	}

/// <summary>
/// <para>
/// Creates a new #GString, initialized with the given string.
/// </para>
/// <para>
/// After this call, @init belongs to the #GString and may no longer be
/// modified by the caller. The memory of @data has to be dynamically
/// allocated and will eventually be freed with g_free().
/// </para>
/// </summary>

/// <param name="init">
/// initial text used as the string.
///     Ownership of the string is transferred to the #GString.
///     Passing %NULL creates an empty string.
/// </param>
/// <return>
/// the new #GString
/// </return>

	public static MentorLake.GLib.GStringHandle NewTake(string init)
	{
		return GStringExterns.g_string_new_take(init);
	}

/// <summary>
/// <para>
/// Creates a new #GString, with enough space for @dfl_size
/// bytes. This is useful if you are going to add a lot of
/// text to the string and don't want it to be reallocated
/// too often.
/// </para>
/// </summary>

/// <param name="dfl_size">
/// the default size of the space allocated to hold the string
/// </param>
/// <return>
/// the new #GString
/// </return>

	public static MentorLake.GLib.GStringHandle SizedNew(UIntPtr dfl_size)
	{
		return GStringExterns.g_string_sized_new(dfl_size);
	}

}


public static class GStringExtensions
{
/// <summary>
/// <para>
/// Adds a string onto the end of a #GString, expanding
/// it if necessary.
/// </para>
/// </summary>

/// <param name="@string">
/// a #GString
/// </param>
/// <param name="val">
/// the string to append onto the end of @string
/// </param>
/// <return>
/// @string
/// </return>

	public static MentorLake.GLib.GStringHandle Append(this MentorLake.GLib.GStringHandle @string, string val)
	{
		if (@string.IsInvalid) throw new Exception("Invalid handle (GString)");
		return GStringExterns.g_string_append(@string, val);
	}

/// <summary>
/// <para>
/// Adds a byte onto the end of a #GString, expanding
/// it if necessary.
/// </para>
/// </summary>

/// <param name="@string">
/// a #GString
/// </param>
/// <param name="c">
/// the byte to append onto the end of @string
/// </param>
/// <return>
/// @string
/// </return>

	public static MentorLake.GLib.GStringHandle AppendC(this MentorLake.GLib.GStringHandle @string, char c)
	{
		if (@string.IsInvalid) throw new Exception("Invalid handle (GString)");
		return GStringExterns.g_string_append_c(@string, c);
	}

/// <summary>
/// <para>
/// Appends @len bytes of @val to @string.
/// </para>
/// <para>
/// If @len is positive, @val may contain embedded nuls and need
/// not be nul-terminated. It is the caller's responsibility to
/// ensure that @val has at least @len addressable bytes.
/// </para>
/// <para>
/// If @len is negative, @val must be nul-terminated and @len
/// is considered to request the entire string length. This
/// makes g_string_append_len() equivalent to g_string_append().
/// </para>
/// </summary>

/// <param name="@string">
/// a #GString
/// </param>
/// <param name="val">
/// bytes to append
/// </param>
/// <param name="len">
/// number of bytes of @val to use, or -1 for all of @val
/// </param>
/// <return>
/// @string
/// </return>

	public static MentorLake.GLib.GStringHandle AppendLen(this MentorLake.GLib.GStringHandle @string, string val, UIntPtr len)
	{
		if (@string.IsInvalid) throw new Exception("Invalid handle (GString)");
		return GStringExterns.g_string_append_len(@string, val, len);
	}

/// <summary>
/// <para>
/// Appends a formatted string onto the end of a #GString.
/// This function is similar to g_string_printf() except
/// that the text is appended to the #GString.
/// </para>
/// </summary>

/// <param name="@string">
/// a #GString
/// </param>
/// <param name="format">
/// the string format. See the printf() documentation
/// </param>
/// <param name="@__arglist">
/// the parameters to insert into the format string
/// </param>

	public static void AppendPrintf(this MentorLake.GLib.GStringHandle @string, string format, IntPtr @__arglist)
	{
		if (@string.IsInvalid) throw new Exception("Invalid handle (GString)");
		GStringExterns.g_string_append_printf(@string, format, @__arglist);
	}

/// <summary>
/// <para>
/// Converts a Unicode character into UTF-8, and appends it
/// to the string.
/// </para>
/// </summary>

/// <param name="@string">
/// a #GString
/// </param>
/// <param name="wc">
/// a Unicode character
/// </param>
/// <return>
/// @string
/// </return>

	public static MentorLake.GLib.GStringHandle AppendUnichar(this MentorLake.GLib.GStringHandle @string, char wc)
	{
		if (@string.IsInvalid) throw new Exception("Invalid handle (GString)");
		return GStringExterns.g_string_append_unichar(@string, wc);
	}

/// <summary>
/// <para>
/// Appends @unescaped to @string, escaping any characters that
/// are reserved in URIs using URI-style escape sequences.
/// </para>
/// </summary>

/// <param name="@string">
/// a #GString
/// </param>
/// <param name="unescaped">
/// a string
/// </param>
/// <param name="reserved_chars_allowed">
/// a string of reserved characters allowed
///     to be used, or %NULL
/// </param>
/// <param name="allow_utf8">
/// set %TRUE if the escaped string may include UTF8 characters
/// </param>
/// <return>
/// @string
/// </return>

	public static MentorLake.GLib.GStringHandle AppendUriEscaped(this MentorLake.GLib.GStringHandle @string, string unescaped, string reserved_chars_allowed, bool allow_utf8)
	{
		if (@string.IsInvalid) throw new Exception("Invalid handle (GString)");
		return GStringExterns.g_string_append_uri_escaped(@string, unescaped, reserved_chars_allowed, allow_utf8);
	}

/// <summary>
/// <para>
/// Appends a formatted string onto the end of a #GString.
/// This function is similar to g_string_append_printf()
/// except that the arguments to the format string are passed
/// as a va_list.
/// </para>
/// </summary>

/// <param name="@string">
/// a #GString
/// </param>
/// <param name="format">
/// the string format. See the printf() documentation
/// </param>
/// <param name="args">
/// the list of arguments to insert in the output
/// </param>

	public static void AppendVprintf(this MentorLake.GLib.GStringHandle @string, string format, IntPtr args)
	{
		if (@string.IsInvalid) throw new Exception("Invalid handle (GString)");
		GStringExterns.g_string_append_vprintf(@string, format, args);
	}

/// <summary>
/// <para>
/// Converts all uppercase ASCII letters to lowercase ASCII letters.
/// </para>
/// </summary>

/// <param name="@string">
/// a GString
/// </param>
/// <return>
/// passed-in @string pointer, with all the
///     uppercase characters converted to lowercase in place,
///     with semantics that exactly match g_ascii_tolower().
/// </return>

	public static MentorLake.GLib.GStringHandle AsciiDown(this MentorLake.GLib.GStringHandle @string)
	{
		if (@string.IsInvalid) throw new Exception("Invalid handle (GString)");
		return GStringExterns.g_string_ascii_down(@string);
	}

/// <summary>
/// <para>
/// Converts all lowercase ASCII letters to uppercase ASCII letters.
/// </para>
/// </summary>

/// <param name="@string">
/// a GString
/// </param>
/// <return>
/// passed-in @string pointer, with all the
///     lowercase characters converted to uppercase in place,
///     with semantics that exactly match g_ascii_toupper().
/// </return>

	public static MentorLake.GLib.GStringHandle AsciiUp(this MentorLake.GLib.GStringHandle @string)
	{
		if (@string.IsInvalid) throw new Exception("Invalid handle (GString)");
		return GStringExterns.g_string_ascii_up(@string);
	}

/// <summary>
/// <para>
/// Copies the bytes from a string into a #GString,
/// destroying any previous contents. It is rather like
/// the standard strcpy() function, except that you do not
/// have to worry about having enough space to copy the string.
/// </para>
/// </summary>

/// <param name="@string">
/// the destination #GString. Its current contents
///          are destroyed.
/// </param>
/// <param name="rval">
/// the string to copy into @string
/// </param>
/// <return>
/// @string
/// </return>

	public static MentorLake.GLib.GStringHandle Assign(this MentorLake.GLib.GStringHandle @string, string rval)
	{
		if (@string.IsInvalid) throw new Exception("Invalid handle (GString)");
		return GStringExterns.g_string_assign(@string, rval);
	}

/// <summary>
/// <para>
/// Converts a #GString to lowercase.
/// </para>
/// </summary>

/// <param name="@string">
/// a #GString
/// </param>
/// <return>
/// the #GString
/// </return>

	public static MentorLake.GLib.GStringHandle Down(this MentorLake.GLib.GStringHandle @string)
	{
		if (@string.IsInvalid) throw new Exception("Invalid handle (GString)");
		return GStringExterns.g_string_down(@string);
	}

/// <summary>
/// <para>
/// Compares two strings for equality, returning %TRUE if they are equal.
/// For use with #GHashTable.
/// </para>
/// </summary>

/// <param name="v">
/// a #GString
/// </param>
/// <param name="v2">
/// another #GString
/// </param>
/// <return>
/// %TRUE if the strings are the same length and contain the
///     same bytes
/// </return>

	public static bool Equal(this MentorLake.GLib.GStringHandle v, MentorLake.GLib.GStringHandle v2)
	{
		if (v.IsInvalid) throw new Exception("Invalid handle (GString)");
		return GStringExterns.g_string_equal(v, v2);
	}

/// <summary>
/// <para>
/// Removes @len bytes from a #GString, starting at position @pos.
/// The rest of the #GString is shifted down to fill the gap.
/// </para>
/// </summary>

/// <param name="@string">
/// a #GString
/// </param>
/// <param name="pos">
/// the position of the content to remove
/// </param>
/// <param name="len">
/// the number of bytes to remove, or -1 to remove all
///       following bytes
/// </param>
/// <return>
/// @string
/// </return>

	public static MentorLake.GLib.GStringHandle Erase(this MentorLake.GLib.GStringHandle @string, UIntPtr pos, UIntPtr len)
	{
		if (@string.IsInvalid) throw new Exception("Invalid handle (GString)");
		return GStringExterns.g_string_erase(@string, pos, len);
	}

/// <summary>
/// <para>
/// Frees the memory allocated for the #GString.
/// If @free_segment is %TRUE it also frees the character data.  If
/// it's %FALSE, the caller gains ownership of the buffer and must
/// free it after use with g_free().
/// </para>
/// <para>
/// Instead of passing %FALSE to this function, consider using
/// g_string_free_and_steal().
/// </para>
/// </summary>

/// <param name="@string">
/// a #GString
/// </param>
/// <param name="free_segment">
/// if %TRUE, the actual character data is freed as well
/// </param>
/// <return>
/// the character data of @string
///          (i.e. %NULL if @free_segment is %TRUE)
/// </return>

	public static string Free(this MentorLake.GLib.GStringHandle @string, bool free_segment)
	{
		if (@string.IsInvalid) throw new Exception("Invalid handle (GString)");
		return GStringExterns.g_string_free(@string, free_segment);
	}

/// <summary>
/// <para>
/// Frees the memory allocated for the #GString.
/// </para>
/// <para>
/// The caller gains ownership of the buffer and
/// must free it after use with g_free().
/// </para>
/// </summary>

/// <param name="@string">
/// a #GString
/// </param>
/// <return>
/// the character data of @string
/// </return>

	public static string FreeAndSteal(this MentorLake.GLib.GStringHandle @string)
	{
		if (@string.IsInvalid) throw new Exception("Invalid handle (GString)");
		return GStringExterns.g_string_free_and_steal(@string);
	}

/// <summary>
/// <para>
/// Transfers ownership of the contents of @string to a newly allocated
/// #GBytes.  The #GString structure itself is deallocated, and it is
/// therefore invalid to use @string after invoking this function.
/// </para>
/// <para>
/// Note that while #GString ensures that its buffer always has a
/// trailing nul character (not reflected in its "len"), the returned
/// #GBytes does not include this extra nul; i.e. it has length exactly
/// equal to the "len" member.
/// </para>
/// </summary>

/// <param name="@string">
/// a #GString
/// </param>
/// <return>
/// A newly allocated #GBytes containing contents of @string; @string itself is freed
/// </return>

	public static MentorLake.GLib.GBytesHandle FreeToBytes(this MentorLake.GLib.GStringHandle @string)
	{
		if (@string.IsInvalid) throw new Exception("Invalid handle (GString)");
		return GStringExterns.g_string_free_to_bytes(@string);
	}

/// <summary>
/// <para>
/// Creates a hash code for @str; for use with #GHashTable.
/// </para>
/// </summary>

/// <param name="str">
/// a string to hash
/// </param>
/// <return>
/// hash code for @str
/// </return>

	public static uint Hash(this MentorLake.GLib.GStringHandle str)
	{
		if (str.IsInvalid) throw new Exception("Invalid handle (GString)");
		return GStringExterns.g_string_hash(str);
	}

/// <summary>
/// <para>
/// Inserts a copy of a string into a #GString,
/// expanding it if necessary.
/// </para>
/// </summary>

/// <param name="@string">
/// a #GString
/// </param>
/// <param name="pos">
/// the position to insert the copy of the string
/// </param>
/// <param name="val">
/// the string to insert
/// </param>
/// <return>
/// @string
/// </return>

	public static MentorLake.GLib.GStringHandle Insert(this MentorLake.GLib.GStringHandle @string, UIntPtr pos, string val)
	{
		if (@string.IsInvalid) throw new Exception("Invalid handle (GString)");
		return GStringExterns.g_string_insert(@string, pos, val);
	}

/// <summary>
/// <para>
/// Inserts a byte into a #GString, expanding it if necessary.
/// </para>
/// </summary>

/// <param name="@string">
/// a #GString
/// </param>
/// <param name="pos">
/// the position to insert the byte
/// </param>
/// <param name="c">
/// the byte to insert
/// </param>
/// <return>
/// @string
/// </return>

	public static MentorLake.GLib.GStringHandle InsertC(this MentorLake.GLib.GStringHandle @string, UIntPtr pos, char c)
	{
		if (@string.IsInvalid) throw new Exception("Invalid handle (GString)");
		return GStringExterns.g_string_insert_c(@string, pos, c);
	}

/// <summary>
/// <para>
/// Inserts @len bytes of @val into @string at @pos.
/// </para>
/// <para>
/// If @len is positive, @val may contain embedded nuls and need
/// not be nul-terminated. It is the caller's responsibility to
/// ensure that @val has at least @len addressable bytes.
/// </para>
/// <para>
/// If @len is negative, @val must be nul-terminated and @len
/// is considered to request the entire string length.
/// </para>
/// <para>
/// If @pos is -1, bytes are inserted at the end of the string.
/// </para>
/// </summary>

/// <param name="@string">
/// a #GString
/// </param>
/// <param name="pos">
/// position in @string where insertion should
///       happen, or -1 for at the end
/// </param>
/// <param name="val">
/// bytes to insert
/// </param>
/// <param name="len">
/// number of bytes of @val to insert, or -1 for all of @val
/// </param>
/// <return>
/// @string
/// </return>

	public static MentorLake.GLib.GStringHandle InsertLen(this MentorLake.GLib.GStringHandle @string, UIntPtr pos, string val, UIntPtr len)
	{
		if (@string.IsInvalid) throw new Exception("Invalid handle (GString)");
		return GStringExterns.g_string_insert_len(@string, pos, val, len);
	}

/// <summary>
/// <para>
/// Converts a Unicode character into UTF-8, and insert it
/// into the string at the given position.
/// </para>
/// </summary>

/// <param name="@string">
/// a #GString
/// </param>
/// <param name="pos">
/// the position at which to insert character, or -1
///     to append at the end of the string
/// </param>
/// <param name="wc">
/// a Unicode character
/// </param>
/// <return>
/// @string
/// </return>

	public static MentorLake.GLib.GStringHandle InsertUnichar(this MentorLake.GLib.GStringHandle @string, UIntPtr pos, char wc)
	{
		if (@string.IsInvalid) throw new Exception("Invalid handle (GString)");
		return GStringExterns.g_string_insert_unichar(@string, pos, wc);
	}

/// <summary>
/// <para>
/// Overwrites part of a string, lengthening it if necessary.
/// </para>
/// </summary>

/// <param name="@string">
/// a #GString
/// </param>
/// <param name="pos">
/// the position at which to start overwriting
/// </param>
/// <param name="val">
/// the string that will overwrite the @string starting at @pos
/// </param>
/// <return>
/// @string
/// </return>

	public static MentorLake.GLib.GStringHandle Overwrite(this MentorLake.GLib.GStringHandle @string, UIntPtr pos, string val)
	{
		if (@string.IsInvalid) throw new Exception("Invalid handle (GString)");
		return GStringExterns.g_string_overwrite(@string, pos, val);
	}

/// <summary>
/// <para>
/// Overwrites part of a string, lengthening it if necessary.
/// This function will work with embedded nuls.
/// </para>
/// </summary>

/// <param name="@string">
/// a #GString
/// </param>
/// <param name="pos">
/// the position at which to start overwriting
/// </param>
/// <param name="val">
/// the string that will overwrite the @string starting at @pos
/// </param>
/// <param name="len">
/// the number of bytes to write from @val
/// </param>
/// <return>
/// @string
/// </return>

	public static MentorLake.GLib.GStringHandle OverwriteLen(this MentorLake.GLib.GStringHandle @string, UIntPtr pos, string val, UIntPtr len)
	{
		if (@string.IsInvalid) throw new Exception("Invalid handle (GString)");
		return GStringExterns.g_string_overwrite_len(@string, pos, val, len);
	}

/// <summary>
/// <para>
/// Adds a string on to the start of a #GString,
/// expanding it if necessary.
/// </para>
/// </summary>

/// <param name="@string">
/// a #GString
/// </param>
/// <param name="val">
/// the string to prepend on the start of @string
/// </param>
/// <return>
/// @string
/// </return>

	public static MentorLake.GLib.GStringHandle Prepend(this MentorLake.GLib.GStringHandle @string, string val)
	{
		if (@string.IsInvalid) throw new Exception("Invalid handle (GString)");
		return GStringExterns.g_string_prepend(@string, val);
	}

/// <summary>
/// <para>
/// Adds a byte onto the start of a #GString,
/// expanding it if necessary.
/// </para>
/// </summary>

/// <param name="@string">
/// a #GString
/// </param>
/// <param name="c">
/// the byte to prepend on the start of the #GString
/// </param>
/// <return>
/// @string
/// </return>

	public static MentorLake.GLib.GStringHandle PrependC(this MentorLake.GLib.GStringHandle @string, char c)
	{
		if (@string.IsInvalid) throw new Exception("Invalid handle (GString)");
		return GStringExterns.g_string_prepend_c(@string, c);
	}

/// <summary>
/// <para>
/// Prepends @len bytes of @val to @string.
/// </para>
/// <para>
/// If @len is positive, @val may contain embedded nuls and need
/// not be nul-terminated. It is the caller's responsibility to
/// ensure that @val has at least @len addressable bytes.
/// </para>
/// <para>
/// If @len is negative, @val must be nul-terminated and @len
/// is considered to request the entire string length. This
/// makes g_string_prepend_len() equivalent to g_string_prepend().
/// </para>
/// </summary>

/// <param name="@string">
/// a #GString
/// </param>
/// <param name="val">
/// bytes to prepend
/// </param>
/// <param name="len">
/// number of bytes in @val to prepend, or -1 for all of @val
/// </param>
/// <return>
/// @string
/// </return>

	public static MentorLake.GLib.GStringHandle PrependLen(this MentorLake.GLib.GStringHandle @string, string val, UIntPtr len)
	{
		if (@string.IsInvalid) throw new Exception("Invalid handle (GString)");
		return GStringExterns.g_string_prepend_len(@string, val, len);
	}

/// <summary>
/// <para>
/// Converts a Unicode character into UTF-8, and prepends it
/// to the string.
/// </para>
/// </summary>

/// <param name="@string">
/// a #GString
/// </param>
/// <param name="wc">
/// a Unicode character
/// </param>
/// <return>
/// @string
/// </return>

	public static MentorLake.GLib.GStringHandle PrependUnichar(this MentorLake.GLib.GStringHandle @string, char wc)
	{
		if (@string.IsInvalid) throw new Exception("Invalid handle (GString)");
		return GStringExterns.g_string_prepend_unichar(@string, wc);
	}

/// <summary>
/// <para>
/// Writes a formatted string into a #GString.
/// This is similar to the standard sprintf() function,
/// except that the #GString buffer automatically expands
/// to contain the results. The previous contents of the
/// #GString are destroyed.
/// </para>
/// </summary>

/// <param name="@string">
/// a #GString
/// </param>
/// <param name="format">
/// the string format. See the printf() documentation
/// </param>
/// <param name="@__arglist">
/// the parameters to insert into the format string
/// </param>

	public static void Printf(this MentorLake.GLib.GStringHandle @string, string format, IntPtr @__arglist)
	{
		if (@string.IsInvalid) throw new Exception("Invalid handle (GString)");
		GStringExterns.g_string_printf(@string, format, @__arglist);
	}

/// <summary>
/// <para>
/// Replaces the string @find with the string @replace in a #GString up to
/// @limit times. If the number of instances of @find in the #GString is
/// less than @limit, all instances are replaced. If @limit is `0`,
/// all instances of @find are replaced.
/// </para>
/// <para>
/// If @find is the empty string, since versions 2.69.1 and 2.68.4 the
/// replacement will be inserted no more than once per possible position
/// (beginning of string, end of string and between characters). This did
/// not work correctly in earlier versions.
/// </para>
/// </summary>

/// <param name="@string">
/// a #GString
/// </param>
/// <param name="find">
/// the string to find in @string
/// </param>
/// <param name="replace">
/// the string to insert in place of @find
/// </param>
/// <param name="limit">
/// the maximum instances of @find to replace with @replace, or `0` for
/// no limit
/// </param>
/// <return>
/// the number of find and replace operations performed.
/// </return>

	public static uint Replace(this MentorLake.GLib.GStringHandle @string, string find, string replace, uint limit)
	{
		if (@string.IsInvalid) throw new Exception("Invalid handle (GString)");
		return GStringExterns.g_string_replace(@string, find, replace, limit);
	}

/// <summary>
/// <para>
/// Sets the length of a #GString. If the length is less than
/// the current length, the string will be truncated. If the
/// length is greater than the current length, the contents
/// of the newly added area are undefined. (However, as
/// always, string->str[string->len] will be a nul byte.)
/// </para>
/// </summary>

/// <param name="@string">
/// a #GString
/// </param>
/// <param name="len">
/// the new length
/// </param>
/// <return>
/// @string
/// </return>

	public static MentorLake.GLib.GStringHandle SetSize(this MentorLake.GLib.GStringHandle @string, UIntPtr len)
	{
		if (@string.IsInvalid) throw new Exception("Invalid handle (GString)");
		return GStringExterns.g_string_set_size(@string, len);
	}

/// <summary>
/// <para>
/// Cuts off the end of the GString, leaving the first @len bytes.
/// </para>
/// </summary>

/// <param name="@string">
/// a #GString
/// </param>
/// <param name="len">
/// the new size of @string
/// </param>
/// <return>
/// @string
/// </return>

	public static MentorLake.GLib.GStringHandle Truncate(this MentorLake.GLib.GStringHandle @string, UIntPtr len)
	{
		if (@string.IsInvalid) throw new Exception("Invalid handle (GString)");
		return GStringExterns.g_string_truncate(@string, len);
	}

/// <summary>
/// <para>
/// Converts a #GString to uppercase.
/// </para>
/// </summary>

/// <param name="@string">
/// a #GString
/// </param>
/// <return>
/// @string
/// </return>

	public static MentorLake.GLib.GStringHandle Up(this MentorLake.GLib.GStringHandle @string)
	{
		if (@string.IsInvalid) throw new Exception("Invalid handle (GString)");
		return GStringExterns.g_string_up(@string);
	}

/// <summary>
/// <para>
/// Writes a formatted string into a #GString.
/// This function is similar to g_string_printf() except that
/// the arguments to the format string are passed as a va_list.
/// </para>
/// </summary>

/// <param name="@string">
/// a #GString
/// </param>
/// <param name="format">
/// the string format. See the printf() documentation
/// </param>
/// <param name="args">
/// the parameters to insert into the format string
/// </param>

	public static void Vprintf(this MentorLake.GLib.GStringHandle @string, string format, IntPtr args)
	{
		if (@string.IsInvalid) throw new Exception("Invalid handle (GString)");
		GStringExterns.g_string_vprintf(@string, format, args);
	}


	public static GString Dereference(this GStringHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GString>(x.DangerousGetHandle());
}
internal class GStringExterns
{
	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStringHandle>))]
	internal static extern MentorLake.GLib.GStringHandle g_string_new(string init);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStringHandle>))]
	internal static extern MentorLake.GLib.GStringHandle g_string_new_len(string init, UIntPtr len);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStringHandle>))]
	internal static extern MentorLake.GLib.GStringHandle g_string_new_take(string init);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStringHandle>))]
	internal static extern MentorLake.GLib.GStringHandle g_string_sized_new(UIntPtr dfl_size);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStringHandle>))]
	internal static extern MentorLake.GLib.GStringHandle g_string_append([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStringHandle>))] MentorLake.GLib.GStringHandle @string, string val);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStringHandle>))]
	internal static extern MentorLake.GLib.GStringHandle g_string_append_c([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStringHandle>))] MentorLake.GLib.GStringHandle @string, char c);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStringHandle>))]
	internal static extern MentorLake.GLib.GStringHandle g_string_append_len([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStringHandle>))] MentorLake.GLib.GStringHandle @string, string val, UIntPtr len);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_string_append_printf([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStringHandle>))] MentorLake.GLib.GStringHandle @string, string format, IntPtr @__arglist);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStringHandle>))]
	internal static extern MentorLake.GLib.GStringHandle g_string_append_unichar([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStringHandle>))] MentorLake.GLib.GStringHandle @string, char wc);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStringHandle>))]
	internal static extern MentorLake.GLib.GStringHandle g_string_append_uri_escaped([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStringHandle>))] MentorLake.GLib.GStringHandle @string, string unescaped, string reserved_chars_allowed, bool allow_utf8);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_string_append_vprintf([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStringHandle>))] MentorLake.GLib.GStringHandle @string, string format, IntPtr args);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStringHandle>))]
	internal static extern MentorLake.GLib.GStringHandle g_string_ascii_down([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStringHandle>))] MentorLake.GLib.GStringHandle @string);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStringHandle>))]
	internal static extern MentorLake.GLib.GStringHandle g_string_ascii_up([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStringHandle>))] MentorLake.GLib.GStringHandle @string);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStringHandle>))]
	internal static extern MentorLake.GLib.GStringHandle g_string_assign([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStringHandle>))] MentorLake.GLib.GStringHandle @string, string rval);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStringHandle>))]
	internal static extern MentorLake.GLib.GStringHandle g_string_down([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStringHandle>))] MentorLake.GLib.GStringHandle @string);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_string_equal([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStringHandle>))] MentorLake.GLib.GStringHandle v, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStringHandle>))] MentorLake.GLib.GStringHandle v2);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStringHandle>))]
	internal static extern MentorLake.GLib.GStringHandle g_string_erase([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStringHandle>))] MentorLake.GLib.GStringHandle @string, UIntPtr pos, UIntPtr len);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_string_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStringHandle>))] MentorLake.GLib.GStringHandle @string, bool free_segment);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_string_free_and_steal([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStringHandle>))] MentorLake.GLib.GStringHandle @string);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBytesHandle>))]
	internal static extern MentorLake.GLib.GBytesHandle g_string_free_to_bytes([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStringHandle>))] MentorLake.GLib.GStringHandle @string);

	[DllImport(GLibLibrary.Name)]
	internal static extern uint g_string_hash([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStringHandle>))] MentorLake.GLib.GStringHandle str);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStringHandle>))]
	internal static extern MentorLake.GLib.GStringHandle g_string_insert([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStringHandle>))] MentorLake.GLib.GStringHandle @string, UIntPtr pos, string val);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStringHandle>))]
	internal static extern MentorLake.GLib.GStringHandle g_string_insert_c([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStringHandle>))] MentorLake.GLib.GStringHandle @string, UIntPtr pos, char c);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStringHandle>))]
	internal static extern MentorLake.GLib.GStringHandle g_string_insert_len([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStringHandle>))] MentorLake.GLib.GStringHandle @string, UIntPtr pos, string val, UIntPtr len);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStringHandle>))]
	internal static extern MentorLake.GLib.GStringHandle g_string_insert_unichar([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStringHandle>))] MentorLake.GLib.GStringHandle @string, UIntPtr pos, char wc);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStringHandle>))]
	internal static extern MentorLake.GLib.GStringHandle g_string_overwrite([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStringHandle>))] MentorLake.GLib.GStringHandle @string, UIntPtr pos, string val);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStringHandle>))]
	internal static extern MentorLake.GLib.GStringHandle g_string_overwrite_len([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStringHandle>))] MentorLake.GLib.GStringHandle @string, UIntPtr pos, string val, UIntPtr len);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStringHandle>))]
	internal static extern MentorLake.GLib.GStringHandle g_string_prepend([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStringHandle>))] MentorLake.GLib.GStringHandle @string, string val);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStringHandle>))]
	internal static extern MentorLake.GLib.GStringHandle g_string_prepend_c([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStringHandle>))] MentorLake.GLib.GStringHandle @string, char c);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStringHandle>))]
	internal static extern MentorLake.GLib.GStringHandle g_string_prepend_len([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStringHandle>))] MentorLake.GLib.GStringHandle @string, string val, UIntPtr len);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStringHandle>))]
	internal static extern MentorLake.GLib.GStringHandle g_string_prepend_unichar([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStringHandle>))] MentorLake.GLib.GStringHandle @string, char wc);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_string_printf([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStringHandle>))] MentorLake.GLib.GStringHandle @string, string format, IntPtr @__arglist);

	[DllImport(GLibLibrary.Name)]
	internal static extern uint g_string_replace([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStringHandle>))] MentorLake.GLib.GStringHandle @string, string find, string replace, uint limit);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStringHandle>))]
	internal static extern MentorLake.GLib.GStringHandle g_string_set_size([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStringHandle>))] MentorLake.GLib.GStringHandle @string, UIntPtr len);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStringHandle>))]
	internal static extern MentorLake.GLib.GStringHandle g_string_truncate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStringHandle>))] MentorLake.GLib.GStringHandle @string, UIntPtr len);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStringHandle>))]
	internal static extern MentorLake.GLib.GStringHandle g_string_up([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStringHandle>))] MentorLake.GLib.GStringHandle @string);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_string_vprintf([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStringHandle>))] MentorLake.GLib.GStringHandle @string, string format, IntPtr args);

}

/// <summary>
/// <para>
/// A `GString` is an object that handles the memory management of a C string.
/// </para>
/// <para>
/// The emphasis of `GString` is on text, typically UTF-8. Crucially, the "str" member
/// of a `GString` is guaranteed to have a trailing nul character, and it is therefore
/// always safe to call functions such as `strchr()` or `strdup()` on it.
/// </para>
/// <para>
/// However, a `GString` can also hold arbitrary binary data, because it has a "len" member,
/// which includes any possible embedded nul characters in the data. Conceptually then,
/// `GString` is like a `GByteArray` with the addition of many convenience methods for
/// text, and a guaranteed nul terminator.
/// </para>
/// </summary>

public struct GString
{
	/// <summary>
/// <para>
/// points to the character data. It may move as text is added.
///   The @str field is null-terminated and so
///   can be used as an ordinary C string.
/// </para>
/// </summary>

public string str;
	/// <summary>
/// <para>
/// contains the length of the string, not including the
///   terminating nul byte.
/// </para>
/// </summary>

public UIntPtr len;
	/// <summary>
/// <para>
/// the number of bytes that can be stored in the
///   string before it needs to be reallocated. May be larger than @len.
/// </para>
/// </summary>

public UIntPtr allocated_len;
}
