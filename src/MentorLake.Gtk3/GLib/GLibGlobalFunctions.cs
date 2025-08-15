namespace MentorLake.GLib;

public class GLibGlobalFunctions
{
/// <summary>
/// <para>
/// A wrapper for the POSIX access() function. This function is used to
/// test a pathname for one or several of read, write or execute
/// permissions, or just existence.
/// </para>
/// <para>
/// On Windows, the file protection mechanism is not at all POSIX-like,
/// and the underlying function in the C library only checks the
/// FAT-style READONLY attribute, and does not look at the ACL of a
/// file at all. This function is this in practise almost useless on
/// Windows. Software that needs to handle file permissions on Windows
/// more exactly should use the Win32 API.
/// </para>
/// <para>
/// See your C library manual for more details about access().
/// </para>
/// </summary>

/// <param name="filename">
/// a pathname in the GLib file name encoding
///     (UTF-8 on Windows)
/// </param>
/// <param name="mode">
/// as in access()
/// </param>
/// <return>
/// zero if the pathname refers to an existing file system
///     object that has all the tested permissions, or -1 otherwise
///     or on error.
/// </return>

	public static int Access(string filename, int mode)
	{
		return GLibGlobalFunctionsExterns.g_access(filename, mode);
	}

/// <summary>
/// <para>
/// This function is similar to g_malloc(), allocating (@n_blocks * @n_block_bytes)
/// bytes, but care is taken to align the allocated memory to with the given
/// alignment value. Additionally, it will detect possible overflow during
/// multiplication.
/// </para>
/// <para>
/// If the allocation fails (because the system is out of memory),
/// the program is terminated.
/// </para>
/// <para>
/// Aligned memory allocations returned by this function can only be
/// freed using g_aligned_free_sized() or g_aligned_free().
/// </para>
/// </summary>

/// <param name="n_blocks">
/// the number of blocks to allocate
/// </param>
/// <param name="n_block_bytes">
/// the size of each block in bytes
/// </param>
/// <param name="alignment">
/// the alignment to be enforced, which must be a positive power of 2
///   and a multiple of `sizeof(void*)`
/// </param>
/// <return>
/// the allocated memory
/// </return>

	public static IntPtr AlignedAlloc(UIntPtr n_blocks, UIntPtr n_block_bytes, UIntPtr alignment)
	{
		return GLibGlobalFunctionsExterns.g_aligned_alloc(n_blocks, n_block_bytes, alignment);
	}

/// <summary>
/// <para>
/// This function is similar to g_aligned_alloc(), but it will
/// also clear the allocated memory before returning it.
/// </para>
/// </summary>

/// <param name="n_blocks">
/// the number of blocks to allocate
/// </param>
/// <param name="n_block_bytes">
/// the size of each block in bytes
/// </param>
/// <param name="alignment">
/// the alignment to be enforced, which must be a positive power of 2
///   and a multiple of `sizeof(void*)`
/// </param>
/// <return>
/// the allocated, cleared memory
/// </return>

	public static IntPtr AlignedAlloc0(UIntPtr n_blocks, UIntPtr n_block_bytes, UIntPtr alignment)
	{
		return GLibGlobalFunctionsExterns.g_aligned_alloc0(n_blocks, n_block_bytes, alignment);
	}

/// <summary>
/// <para>
/// Frees the memory allocated by g_aligned_alloc().
/// </para>
/// </summary>

/// <param name="mem">
/// the memory to deallocate
/// </param>

	public static void AlignedFree(IntPtr mem)
	{
		GLibGlobalFunctionsExterns.g_aligned_free(mem);
	}

/// <summary>
/// <para>
/// Frees the memory pointed to by @mem, assuming it is has the given @size and
/// @alignment.
/// </para>
/// <para>
/// If @mem is %NULL this is a no-op (and @size is ignored).
/// </para>
/// <para>
/// It is an error if @size doesn’t match the size, or @alignment doesn’t match
/// the alignment, passed when @mem was allocated. @size and @alignment are
/// passed to this function to allow optimizations in the allocator. If you
/// don’t know either of them, use g_aligned_free() instead.
/// </para>
/// </summary>

/// <param name="mem">
/// the memory to free
/// </param>
/// <param name="alignment">
/// alignment of @mem
/// </param>
/// <param name="size">
/// size of @mem, in bytes
/// </param>

	public static void AlignedFreeSized(IntPtr mem, UIntPtr alignment, UIntPtr size)
	{
		GLibGlobalFunctionsExterns.g_aligned_free_sized(mem, alignment, size);
	}

/// <summary>
/// <para>
/// Creates a new #GArray with @data as array data, @len as length and a
/// reference count of 1.
/// </para>
/// <para>
/// This avoids having to copy the data manually, when it can just be
/// inherited.
/// After this call, @data belongs to the #GArray and may no longer be
/// modified by the caller. The memory of @data has to be dynamically
/// allocated and will eventually be freed with g_free().
/// </para>
/// <para>
/// In case the elements need to be cleared when the array is freed, use
/// g_array_set_clear_func() to set a #GDestroyNotify function to perform
/// such task.
/// </para>
/// <para>
/// Do not use it if @len or @element_size are greater than %G_MAXUINT.
/// #GArray stores the length of its data in #guint, which may be shorter
/// than #gsize.
/// </para>
/// </summary>

/// <param name="data">
/// an array of
///   elements of @element_size, or %NULL for an empty array
/// </param>
/// <param name="len">
/// the number of elements in @data
/// </param>
/// <param name="clear">
/// %TRUE if #GArray elements should be automatically cleared
///     to 0 when they are allocated
/// </param>
/// <param name="element_size">
/// the size of each element in bytes
/// </param>
/// <return>
/// A new #GArray
/// </return>

	public static MentorLake.GLib.GArrayHandle ArrayNewTake(IntPtr[] data, UIntPtr len, bool clear, UIntPtr element_size)
	{
		return GLibGlobalFunctionsExterns.g_array_new_take(data, len, clear, element_size);
	}

/// <summary>
/// <para>
/// Creates a new #GArray with @data as array data, computing the length of it
/// and setting the reference count to 1.
/// </para>
/// <para>
/// This avoids having to copy the data manually, when it can just be
/// inherited.
/// After this call, @data belongs to the #GArray and may no longer be
/// modified by the caller. The memory of @data has to be dynamically
/// allocated and will eventually be freed with g_free().
/// </para>
/// <para>
/// The length is calculated by iterating through @data until the first %NULL
/// element is found.
/// </para>
/// <para>
/// In case the elements need to be cleared when the array is freed, use
/// g_array_set_clear_func() to set a #GDestroyNotify function to perform
/// such task.
/// </para>
/// <para>
/// Do not use it if @data length or @element_size are greater than %G_MAXUINT.
/// #GArray stores the length of its data in #guint, which may be shorter
/// than #gsize.
/// </para>
/// </summary>

/// <param name="data">
/// an array of elements of @element_size
/// </param>
/// <param name="clear">
/// %TRUE if #GArray elements should be automatically cleared
///     to 0 when they are allocated
/// </param>
/// <param name="element_size">
/// the size of each element in bytes
/// </param>
/// <return>
/// A new #GArray
/// </return>

	public static MentorLake.GLib.GArrayHandle ArrayNewTakeZeroTerminated(IntPtr[] data, bool clear, UIntPtr element_size)
	{
		return GLibGlobalFunctionsExterns.g_array_new_take_zero_terminated(data, clear, element_size);
	}

/// <summary>
/// <para>
/// Determines the numeric value of a character as a decimal digit. If the
/// character is not a decimal digit according to [func@GLib.ascii_isdigit],
/// `-1` is returned.
/// </para>
/// <para>
/// Differs from [func@GLib.unichar_digit_value] because it takes a char, so
/// there&apos;s no worry about sign extension if characters are signed.
/// </para>
/// </summary>

/// <param name="c">
/// an ASCII character
/// </param>
/// <return>
/// the numerical value of @c if it is a decimal digit, `-1` otherwise
/// </return>

	public static int AsciiDigitValue(char c)
	{
		return GLibGlobalFunctionsExterns.g_ascii_digit_value(c);
	}

/// <summary>
/// <para>
/// Converts a `gdouble` to a string, using the &apos;.&apos; as
/// decimal point.
/// </para>
/// <para>
/// This function generates enough precision that converting
/// the string back using [func@GLib.ascii_strtod] gives the same machine-number
/// (on machines with IEEE compatible 64bit doubles). It is
/// guaranteed that the size of the resulting string will never
/// be larger than [const@GLib.ASCII_DTOSTR_BUF_SIZE] bytes, including the terminating
/// nul character, which is always added.
/// </para>
/// </summary>

/// <param name="buffer">
/// a buffer to place the resulting string in
/// </param>
/// <param name="buf_len">
/// the length of the buffer
/// </param>
/// <param name="d">
/// the value to convert
/// </param>
/// <return>
/// the pointer to the buffer with the converted string
/// </return>

	public static string AsciiDtostr(string buffer, int buf_len, double d)
	{
		return GLibGlobalFunctionsExterns.g_ascii_dtostr(buffer, buf_len, d);
	}

/// <summary>
/// <para>
/// Converts a `gdouble` to a string, using the &apos;.&apos; as
/// decimal point. To format the number you pass in
/// a `printf()`-style format string. Allowed conversion
/// specifiers are &apos;e&apos;, &apos;E&apos;, &apos;f&apos;, &apos;F&apos;, &apos;g&apos; and &apos;G&apos;.
/// </para>
/// <para>
/// The @format must just be a single format specifier
/// starting with `%`, expecting a `gdouble` argument.
/// </para>
/// <para>
/// The returned buffer is guaranteed to be nul-terminated.
/// </para>
/// <para>
/// If you just want to want to serialize the value into a
/// string, use [func@GLib.ascii_dtostr].
/// </para>
/// </summary>

/// <param name="buffer">
/// a buffer to place the resulting string in
/// </param>
/// <param name="buf_len">
/// the length of the buffer
/// </param>
/// <param name="format">
/// the `printf()`-style format to use for the
///   code to use for converting
/// </param>
/// <param name="d">
/// the value to convert
/// </param>
/// <return>
/// the pointer to the buffer with the converted string
/// </return>

	public static string AsciiFormatd(string buffer, int buf_len, string format, double d)
	{
		return GLibGlobalFunctionsExterns.g_ascii_formatd(buffer, buf_len, format, d);
	}

/// <summary>
/// <para>
/// Compare two strings, ignoring the case of ASCII characters.
/// </para>
/// <para>
/// Unlike the BSD `strcasecmp()` function, this only recognizes standard
/// ASCII letters and ignores the locale, treating all non-ASCII
/// bytes as if they are not letters.
/// </para>
/// <para>
/// This function should be used only on strings that are known to be
/// in encodings where the bytes corresponding to ASCII letters always
/// represent themselves. This includes UTF-8 and the ISO-8859-*
/// charsets, but not for instance double-byte encodings like the
/// Windows Codepage 932, where the trailing bytes of double-byte
/// characters include all ASCII letters. If you compare two CP932
/// strings using this function, you will get false matches.
/// </para>
/// <para>
/// Both @s1 and @s2 must be non-`NULL`.
/// </para>
/// </summary>

/// <param name="s1">
/// string to compare with @s2
/// </param>
/// <param name="s2">
/// string to compare with @s1
/// </param>
/// <return>
/// 0 if the strings match, a negative value if @s1 &amp;lt; @s2,
///   or a positive value if @s1 &amp;gt; @s2
/// </return>

	public static int AsciiStrcasecmp(string s1, string s2)
	{
		return GLibGlobalFunctionsExterns.g_ascii_strcasecmp(s1, s2);
	}

/// <summary>
/// <para>
/// Converts all upper case ASCII letters to lower case ASCII letters, with
/// semantics that exactly match [func@GLib.ascii_tolower].
/// </para>
/// </summary>

/// <param name="str">
/// a string
/// </param>
/// <param name="len">
/// length of @str in bytes, or `-1` if @str is nul-terminated
/// </param>
/// <return>
/// a newly-allocated string, with all the upper case characters in
///   @str converted to lower case. (Note that this is unlike the old
///   [func@GLib.strdown], which modified the string in place.)
/// </return>

	public static string AsciiStrdown(string str, UIntPtr len)
	{
		return GLibGlobalFunctionsExterns.g_ascii_strdown(str, len);
	}

/// <summary>
/// <para>
/// A convenience function for converting a string to a signed number.
/// </para>
/// <para>
/// This function assumes that @str contains only a number of the given
/// @base that is within inclusive bounds limited by @min and @max. If
/// this is true, then the converted number is stored in @out_num. An
/// empty string is not a valid input. A string with leading or
/// trailing whitespace is also an invalid input.
/// </para>
/// <para>
/// @base can be between 2 and 36 inclusive. Hexadecimal numbers must
/// not be prefixed with &quot;0x&quot; or &quot;0X&quot;. Such a problem does not exist
/// for octal numbers, since they were usually prefixed with a zero
/// which does not change the value of the parsed number.
/// </para>
/// <para>
/// Parsing failures result in an error with the `G_NUMBER_PARSER_ERROR`
/// domain. If the input is invalid, the error code will be
/// [error@GLib.NumberParserError.INVALID]. If the parsed number is out of
/// bounds - [error@GLib.NumberParserError.OUT_OF_BOUNDS].
/// </para>
/// <para>
/// See [func@GLib.ascii_strtoll] if you have more complex needs such as
/// parsing a string which starts with a number, but then has other
/// characters.
/// </para>
/// </summary>

/// <param name="str">
/// a string to convert
/// </param>
/// <param name="@base">
/// base of a parsed number
/// </param>
/// <param name="min">
/// a lower bound (inclusive)
/// </param>
/// <param name="max">
/// an upper bound (inclusive)
/// </param>
/// <param name="out_num">
/// a return location for a number
/// </param>
/// <return>
/// true if @str was a number, false otherwise
/// </return>

	public static bool AsciiStringToSigned(string str, uint @base, long min, long max, out long out_num)
	{
		var externCallResult = GLibGlobalFunctionsExterns.g_ascii_string_to_signed(str, @base, min, max, out out_num, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// A convenience function for converting a string to an unsigned number.
/// </para>
/// <para>
/// This function assumes that @str contains only a number of the given
/// @base that is within inclusive bounds limited by @min and @max. If
/// this is true, then the converted number is stored in @out_num. An
/// empty string is not a valid input. A string with leading or
/// trailing whitespace is also an invalid input. A string with a leading sign
/// (`-` or `+`) is not a valid input for the unsigned parser.
/// </para>
/// <para>
/// @base can be between 2 and 36 inclusive. Hexadecimal numbers must
/// not be prefixed with &quot;0x&quot; or &quot;0X&quot;. Such a problem does not exist
/// for octal numbers, since they were usually prefixed with a zero
/// which does not change the value of the parsed number.
/// </para>
/// <para>
/// Parsing failures result in an error with the `G_NUMBER_PARSER_ERROR`
/// domain. If the input is invalid, the error code will be
/// [error@GLib.NumberParserError.INVALID]. If the parsed number is out of
/// bounds - [error@GLib.NumberParserError.OUT_OF_BOUNDS].
/// </para>
/// <para>
/// See [func@GLib.ascii_strtoull] if you have more complex needs such as
/// parsing a string which starts with a number, but then has other
/// characters.
/// </para>
/// </summary>

/// <param name="str">
/// a string
/// </param>
/// <param name="@base">
/// base of a parsed number
/// </param>
/// <param name="min">
/// a lower bound (inclusive)
/// </param>
/// <param name="max">
/// an upper bound (inclusive)
/// </param>
/// <param name="out_num">
/// a return location for a number
/// </param>
/// <return>
/// true if @str was a number, false otherwise
/// </return>

	public static bool AsciiStringToUnsigned(string str, uint @base, ulong min, ulong max, out ulong out_num)
	{
		var externCallResult = GLibGlobalFunctionsExterns.g_ascii_string_to_unsigned(str, @base, min, max, out out_num, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Compare @s1 and @s2, ignoring the case of ASCII characters and any
/// characters after the first @n in each string. If either string is
/// less than @n bytes long, comparison will stop at the first nul byte
/// encountered.
/// </para>
/// <para>
/// Unlike the BSD `strncasecmp()` function, this only recognizes standard
/// ASCII letters and ignores the locale, treating all non-ASCII
/// characters as if they are not letters.
/// </para>
/// <para>
/// The same warning as in [func@GLib.ascii_strcasecmp] applies: Use this
/// function only on strings known to be in encodings where bytes
/// corresponding to ASCII letters always represent themselves.
/// </para>
/// </summary>

/// <param name="s1">
/// string to compare with @s2
/// </param>
/// <param name="s2">
/// string to compare with @s1
/// </param>
/// <param name="n">
/// number of characters to compare
/// </param>
/// <return>
/// 0 if the strings match, a negative value if @s1 &amp;lt; @s2,
///   or a positive value if @s1 &amp;gt; @s2
/// </return>

	public static int AsciiStrncasecmp(string s1, string s2, UIntPtr n)
	{
		return GLibGlobalFunctionsExterns.g_ascii_strncasecmp(s1, s2, n);
	}

/// <summary>
/// <para>
/// Converts a string to a floating point value.
/// </para>
/// <para>
/// This function behaves like the standard `strtod()` function
/// does in the C locale. It does this without actually changing
/// the current locale, since that would not be thread-safe.
/// A limitation of the implementation is that this function
/// will still accept localized versions of infinities and NANs.
/// </para>
/// <para>
/// This function is typically used when reading configuration
/// files or other non-user input that should be locale independent.
/// To handle input from the user you should normally use the
/// locale-sensitive system `strtod()` function.
/// </para>
/// <para>
/// To convert from a gdouble to a string in a locale-insensitive
/// way, use [func@GLib.ascii_dtostr].
/// </para>
/// <para>
/// If the correct value would cause overflow, plus or minus `HUGE_VAL`
/// is returned (according to the sign of the value), and `ERANGE` is
/// stored in `errno`. If the correct value would cause underflow,
/// zero is returned and `ERANGE` is stored in `errno`.
/// </para>
/// <para>
/// This function resets `errno` before calling `strtod()` so that
/// you can reliably detect overflow and underflow.
/// </para>
/// </summary>

/// <param name="nptr">
/// the string to convert to a numeric value
/// </param>
/// <param name="endptr">
/// if non-`NULL`, it returns the
///   character after the last character used in the conversion
/// </param>
/// <return>
/// the converted value
/// </return>

	public static double AsciiStrtod(string nptr, out string endptr)
	{
		return GLibGlobalFunctionsExterns.g_ascii_strtod(nptr, out endptr);
	}

/// <summary>
/// <para>
/// Converts a string to a `gint64` value.
/// </para>
/// <para>
/// This function behaves like the standard `strtoll()` function
/// does in the C locale. It does this without actually
/// changing the current locale, since that would not be
/// thread-safe.
/// </para>
/// <para>
/// This function is typically used when reading configuration
/// files or other non-user input that should be locale independent.
/// To handle input from the user you should normally use the
/// locale-sensitive system `strtoll()` function.
/// </para>
/// <para>
/// If the correct value would cause overflow, [const@GLib.MAXINT64] or
/// [const@GLib.MININT64] is returned, and `ERANGE` is stored in `errno`.
/// If the base is outside the valid range, zero is returned, and
/// `EINVAL` is stored in `errno`. If the
/// string conversion fails, zero is returned, and @endptr returns @nptr
/// (if @endptr is non-`NULL`).
/// </para>
/// </summary>

/// <param name="nptr">
/// the string to convert to a numeric value
/// </param>
/// <param name="endptr">
/// if non-`NULL`, it returns the
///   character after the last character used in the conversion
/// </param>
/// <param name="@base">
/// to be used for the conversion, 2..36 or 0
/// </param>
/// <return>
/// the converted value, or zero on error
/// </return>

	public static long AsciiStrtoll(string nptr, out string endptr, uint @base)
	{
		return GLibGlobalFunctionsExterns.g_ascii_strtoll(nptr, out endptr, @base);
	}

/// <summary>
/// <para>
/// Converts a string to a `guint64` value.
/// </para>
/// <para>
/// This function behaves like the standard `strtoull()` function
/// does in the C locale. It does this without actually
/// changing the current locale, since that would not be
/// thread-safe.
/// </para>
/// <para>
/// Note that input with a leading minus sign (`-`) is accepted, and will return
/// the negation of the parsed number, unless that would overflow a `guint64`.
/// Critically, this means you cannot assume that a short fixed length input will
/// result in a low return value, as the input could have a leading `-`.
/// </para>
/// <para>
/// This function is typically used when reading configuration
/// files or other non-user input that should be locale independent.
/// To handle input from the user you should normally use the
/// locale-sensitive system `strtoull()` function.
/// </para>
/// <para>
/// If the correct value would cause overflow, [const@GLib.MAXUINT64]
/// is returned, and `ERANGE` is stored in `errno`.
/// If the base is outside the valid range, zero is returned, and
/// `EINVAL` is stored in `errno`.
/// If the string conversion fails, zero is returned, and @endptr returns
/// @nptr (if @endptr is non-`NULL`).
/// </para>
/// </summary>

/// <param name="nptr">
/// the string to convert to a numeric value
/// </param>
/// <param name="endptr">
/// if non-`NULL`, it returns the
///   character after the last character used in the conversion
/// </param>
/// <param name="@base">
/// to be used for the conversion, 2..36 or 0
/// </param>
/// <return>
/// the converted value, or zero on error
/// </return>

	public static ulong AsciiStrtoull(string nptr, out string endptr, uint @base)
	{
		return GLibGlobalFunctionsExterns.g_ascii_strtoull(nptr, out endptr, @base);
	}

/// <summary>
/// <para>
/// Converts all lower case ASCII letters to upper case ASCII letters, with
/// semantics that exactly match [func@GLib.ascii_toupper].
/// </para>
/// </summary>

/// <param name="str">
/// a string
/// </param>
/// <param name="len">
/// length of @str in bytes, or `-1` if @str is nul-terminated
/// </param>
/// <return>
/// a newly-allocated string, with all the lower case characters
///   in @str converted to upper case. (Note that this is unlike the old
///   [func@GLib.strup], which modified the string in place.)
/// </return>

	public static string AsciiStrup(string str, UIntPtr len)
	{
		return GLibGlobalFunctionsExterns.g_ascii_strup(str, len);
	}

/// <summary>
/// <para>
/// Convert a character to ASCII lower case. If the character is not an
/// ASCII upper case letter, it is returned unchanged.
/// </para>
/// <para>
/// Unlike the standard C library `tolower()` function, this only
/// recognizes standard ASCII letters and ignores the locale, returning
/// all non-ASCII characters unchanged, even if they are lower case
/// letters in a particular character set. Also unlike the standard
/// library function, this takes and returns a char, not an int, so
/// don&apos;t call it on `EOF` but no need to worry about casting to `guchar`
/// before passing a possibly non-ASCII character in.
/// </para>
/// </summary>

/// <param name="c">
/// any character
/// </param>
/// <return>
/// the result of the conversion
/// </return>

	public static char AsciiTolower(char c)
	{
		return GLibGlobalFunctionsExterns.g_ascii_tolower(c);
	}

/// <summary>
/// <para>
/// Convert a character to ASCII upper case. If the character is not an
/// ASCII lower case letter, it is returned unchanged.
/// </para>
/// <para>
/// Unlike the standard C library `toupper()` function, this only
/// recognizes standard ASCII letters and ignores the locale, returning
/// all non-ASCII characters unchanged, even if they are upper case
/// letters in a particular character set. Also unlike the standard
/// library function, this takes and returns a char, not an int, so
/// don&apos;t call it on `EOF` but no need to worry about casting to `guchar`
/// before passing a possibly non-ASCII character in.
/// </para>
/// </summary>

/// <param name="c">
/// any character
/// </param>
/// <return>
/// the result of the conversion
/// </return>

	public static char AsciiToupper(char c)
	{
		return GLibGlobalFunctionsExterns.g_ascii_toupper(c);
	}

/// <summary>
/// <para>
/// Determines the numeric value of a character as a hexadecimal digit. If the
/// character is not a hex digit according to [func@GLib.ascii_isxdigit],
/// `-1` is returned.
/// </para>
/// <para>
/// Differs from [func@GLib.unichar_xdigit_value] because it takes a char, so
/// there&apos;s no worry about sign extension if characters are signed.
/// </para>
/// <para>
/// Differs from [func@GLib.unichar_xdigit_value] because it takes a char, so
/// there&apos;s no worry about sign extension if characters are signed.
/// </para>
/// </summary>

/// <param name="c">
/// an ASCII character
/// </param>
/// <return>
/// the numerical value of @c if it is a hex digit, `-1` otherwise
/// </return>

	public static int AsciiXdigitValue(char c)
	{
		return GLibGlobalFunctionsExterns.g_ascii_xdigit_value(c);
	}


/// <param name="log_domain">
/// </param>
/// <param name="file">
/// </param>
/// <param name="line">
/// </param>
/// <param name="pretty_function">
/// </param>
/// <param name="expression">
/// </param>

	public static void AssertWarning(string log_domain, string file, int line, string pretty_function, string expression)
	{
		GLibGlobalFunctionsExterns.g_assert_warning(log_domain, file, line, pretty_function, expression);
	}


/// <param name="domain">
/// </param>
/// <param name="file">
/// </param>
/// <param name="line">
/// </param>
/// <param name="func">
/// </param>
/// <param name="message">
/// </param>

	public static void AssertionMessage(string domain, string file, int line, string func, string message)
	{
		GLibGlobalFunctionsExterns.g_assertion_message(domain, file, line, func, message);
	}


/// <param name="domain">
/// </param>
/// <param name="file">
/// </param>
/// <param name="line">
/// </param>
/// <param name="func">
/// </param>
/// <param name="expr">
/// </param>
/// <param name="arg1">
/// </param>
/// <param name="cmp">
/// </param>
/// <param name="arg2">
/// </param>
/// <param name="numtype">
/// </param>

	public static void AssertionMessageCmpint(string domain, string file, int line, string func, string expr, ulong arg1, string cmp, ulong arg2, char numtype)
	{
		GLibGlobalFunctionsExterns.g_assertion_message_cmpint(domain, file, line, func, expr, arg1, cmp, arg2, numtype);
	}


/// <param name="domain">
/// </param>
/// <param name="file">
/// </param>
/// <param name="line">
/// </param>
/// <param name="func">
/// </param>
/// <param name="expr">
/// </param>
/// <param name="arg1">
/// </param>
/// <param name="cmp">
/// </param>
/// <param name="arg2">
/// </param>
/// <param name="numtype">
/// </param>

	public static void AssertionMessageCmpnum(string domain, string file, int line, string func, string expr, long arg1, string cmp, long arg2, char numtype)
	{
		GLibGlobalFunctionsExterns.g_assertion_message_cmpnum(domain, file, line, func, expr, arg1, cmp, arg2, numtype);
	}


/// <param name="domain">
/// </param>
/// <param name="file">
/// </param>
/// <param name="line">
/// </param>
/// <param name="func">
/// </param>
/// <param name="expr">
/// </param>
/// <param name="arg1">
/// </param>
/// <param name="cmp">
/// </param>
/// <param name="arg2">
/// </param>

	public static void AssertionMessageCmpstr(string domain, string file, int line, string func, string expr, string arg1, string cmp, string arg2)
	{
		GLibGlobalFunctionsExterns.g_assertion_message_cmpstr(domain, file, line, func, expr, arg1, cmp, arg2);
	}


/// <param name="domain">
/// </param>
/// <param name="file">
/// </param>
/// <param name="line">
/// </param>
/// <param name="func">
/// </param>
/// <param name="expr">
/// </param>
/// <param name="arg1">
/// </param>
/// <param name="arg2">
/// </param>
/// <param name="first_wrong_idx">
/// </param>

	public static void AssertionMessageCmpstrv(string domain, string file, int line, string func, string expr, string arg1, string arg2, UIntPtr first_wrong_idx)
	{
		GLibGlobalFunctionsExterns.g_assertion_message_cmpstrv(domain, file, line, func, expr, arg1, arg2, first_wrong_idx);
	}


/// <param name="domain">
/// </param>
/// <param name="file">
/// </param>
/// <param name="line">
/// </param>
/// <param name="func">
/// </param>
/// <param name="expr">
/// </param>
/// <param name="error">
/// </param>
/// <param name="error_domain">
/// </param>
/// <param name="error_code">
/// </param>

	public static void AssertionMessageError(string domain, string file, int line, string func, string expr, MentorLake.GLib.GErrorHandle error, MentorLake.GLib.GQuark error_domain, int error_code)
	{
		GLibGlobalFunctionsExterns.g_assertion_message_error(domain, file, line, func, expr, error, error_domain, error_code);
	}

/// <summary>
/// <para>
/// Internal function used to print messages from the public
/// g_assert() and g_assert_not_reached() macros.
/// </para>
/// </summary>

/// <param name="domain">
/// log domain
/// </param>
/// <param name="file">
/// file containing the assertion
/// </param>
/// <param name="line">
/// line number of the assertion
/// </param>
/// <param name="func">
/// function containing the assertion
/// </param>
/// <param name="expr">
/// expression which failed
/// </param>

	public static void AssertionMessageExpr(string domain, string file, int line, string func, string expr)
	{
		GLibGlobalFunctionsExterns.g_assertion_message_expr(domain, file, line, func, expr);
	}

/// <summary>
/// <para>
/// Creates a new asynchronous queue.
/// </para>
/// </summary>

/// <return>
/// a new #GAsyncQueue. Free with g_async_queue_unref()
/// </return>

	public static MentorLake.GLib.GAsyncQueueHandle AsyncQueueNew()
	{
		return GLibGlobalFunctionsExterns.g_async_queue_new();
	}

/// <summary>
/// <para>
/// Creates a new asynchronous queue and sets up a destroy notify
/// function that is used to free any remaining queue items when
/// the queue is destroyed after the final unref.
/// </para>
/// </summary>

/// <param name="item_free_func">
/// function to free queue elements
/// </param>
/// <return>
/// a new #GAsyncQueue. Free with g_async_queue_unref()
/// </return>

	public static MentorLake.GLib.GAsyncQueueHandle AsyncQueueNewFull(MentorLake.GLib.GDestroyNotify item_free_func)
	{
		return GLibGlobalFunctionsExterns.g_async_queue_new_full(item_free_func);
	}

/// <summary>
/// <para>
/// Specifies a function to be called at normal program termination.
/// </para>
/// <para>
/// Since GLib 2.8.2, on Windows g_atexit() actually is a preprocessor
/// macro that maps to a call to the atexit() function in the C
/// library. This means that in case the code that calls g_atexit(),
/// i.e. atexit(), is in a DLL, the function will be called when the
/// DLL is detached from the program. This typically makes more sense
/// than that the function is called when the GLib DLL is detached,
/// which happened earlier when g_atexit() was a function in the GLib
/// DLL.
/// </para>
/// <para>
/// The behaviour of atexit() in the context of dynamically loaded
/// modules is not formally specified and varies wildly.
/// </para>
/// <para>
/// On POSIX systems, calling g_atexit() (or atexit()) in a dynamically
/// loaded module which is unloaded before the program terminates might
/// well cause a crash at program exit.
/// </para>
/// <para>
/// Some POSIX systems implement atexit() like Windows, and have each
/// dynamically loaded module maintain an own atexit chain that is
/// called when the module is unloaded.
/// </para>
/// <para>
/// On other POSIX systems, before a dynamically loaded module is
/// unloaded, the registered atexit functions (if any) residing in that
/// module are called, regardless where the code that registered them
/// resided. This is presumably the most robust approach.
/// </para>
/// <para>
/// As can be seen from the above, for portability it&apos;s best to avoid
/// calling g_atexit() (or atexit()) except in the main executable of a
/// program.
/// </para>
/// </summary>

/// <param name="func">
/// the function to call on normal program termination.
/// </param>

	public static void Atexit(MentorLake.GLib.GVoidFunc func)
	{
		GLibGlobalFunctionsExterns.g_atexit(func);
	}

/// <summary>
/// <para>
/// Atomically adds @val to the value of @atomic.
/// </para>
/// <para>
/// Think of this operation as an atomic version of
/// `{ tmp = *atomic; *atomic += val; return tmp; }`.
/// </para>
/// <para>
/// This call acts as a full compiler and hardware memory barrier.
/// </para>
/// <para>
/// Before version 2.30, this function did not return a value
/// (but g_atomic_int_exchange_and_add() did, and had the same meaning).
/// </para>
/// <para>
/// While @atomic has a `volatile` qualifier, this is a historical artifact and
/// the pointer passed to it should not be `volatile`.
/// </para>
/// </summary>

/// <param name="atomic">
/// a pointer to a #gint or #guint
/// </param>
/// <param name="val">
/// the value to add
/// </param>
/// <return>
/// the value of @atomic before the add, signed
/// </return>

	public static int AtomicIntAdd(int atomic, int val)
	{
		return GLibGlobalFunctionsExterns.g_atomic_int_add(atomic, val);
	}

/// <summary>
/// <para>
/// Performs an atomic bitwise &apos;and&apos; of the value of @atomic and @val,
/// storing the result back in @atomic.
/// </para>
/// <para>
/// This call acts as a full compiler and hardware memory barrier.
/// </para>
/// <para>
/// Think of this operation as an atomic version of
/// `{ tmp = *atomic; *atomic &amp;= val; return tmp; }`.
/// </para>
/// <para>
/// While @atomic has a `volatile` qualifier, this is a historical artifact and
/// the pointer passed to it should not be `volatile`.
/// </para>
/// </summary>

/// <param name="atomic">
/// a pointer to a #gint or #guint
/// </param>
/// <param name="val">
/// the value to &apos;and&apos;
/// </param>
/// <return>
/// the value of @atomic before the operation, unsigned
/// </return>

	public static uint AtomicIntAnd(uint atomic, uint val)
	{
		return GLibGlobalFunctionsExterns.g_atomic_int_and(atomic, val);
	}

/// <summary>
/// <para>
/// Compares @atomic to @oldval and, if equal, sets it to @newval.
/// If @atomic was not equal to @oldval then no change occurs.
/// </para>
/// <para>
/// This compare and exchange is done atomically.
/// </para>
/// <para>
/// Think of this operation as an atomic version of
/// `{ if (*atomic == oldval) { *atomic = newval; return TRUE; } else return FALSE; }`.
/// </para>
/// <para>
/// This call acts as a full compiler and hardware memory barrier.
/// </para>
/// <para>
/// While @atomic has a `volatile` qualifier, this is a historical artifact and
/// the pointer passed to it should not be `volatile`.
/// </para>
/// </summary>

/// <param name="atomic">
/// a pointer to a #gint or #guint
/// </param>
/// <param name="oldval">
/// the value to compare with
/// </param>
/// <param name="newval">
/// the value to conditionally replace with
/// </param>
/// <return>
/// %TRUE if the exchange took place
/// </return>

	public static bool AtomicIntCompareAndExchange(int atomic, int oldval, int newval)
	{
		return GLibGlobalFunctionsExterns.g_atomic_int_compare_and_exchange(atomic, oldval, newval);
	}

/// <summary>
/// <para>
/// Compares @atomic to @oldval and, if equal, sets it to @newval.
/// If @atomic was not equal to @oldval then no change occurs.
/// In any case the value of @atomic before this operation is stored in @preval.
/// </para>
/// <para>
/// This compare and exchange is done atomically.
/// </para>
/// <para>
/// Think of this operation as an atomic version of
/// `{ *preval = *atomic; if (*atomic == oldval) { *atomic = newval; return TRUE; } else return FALSE; }`.
/// </para>
/// <para>
/// This call acts as a full compiler and hardware memory barrier.
/// </para>
/// <para>
/// See also g_atomic_int_compare_and_exchange()
/// </para>
/// </summary>

/// <param name="atomic">
/// a pointer to a #gint or #guint
/// </param>
/// <param name="oldval">
/// the value to compare with
/// </param>
/// <param name="newval">
/// the value to conditionally replace with
/// </param>
/// <param name="preval">
/// the contents of @atomic before this operation
/// </param>
/// <return>
/// %TRUE if the exchange took place
/// </return>

	public static bool AtomicIntCompareAndExchangeFull(int atomic, int oldval, int newval, out int preval)
	{
		return GLibGlobalFunctionsExterns.g_atomic_int_compare_and_exchange_full(atomic, oldval, newval, out preval);
	}

/// <summary>
/// <para>
/// Decrements the value of @atomic by 1.
/// </para>
/// <para>
/// Think of this operation as an atomic version of
/// `{ *atomic -= 1; return (*atomic == 0); }`.
/// </para>
/// <para>
/// This call acts as a full compiler and hardware memory barrier.
/// </para>
/// <para>
/// While @atomic has a `volatile` qualifier, this is a historical artifact and
/// the pointer passed to it should not be `volatile`.
/// </para>
/// </summary>

/// <param name="atomic">
/// a pointer to a #gint or #guint
/// </param>
/// <return>
/// %TRUE if the resultant value is zero
/// </return>

	public static bool AtomicIntDecAndTest(int atomic)
	{
		return GLibGlobalFunctionsExterns.g_atomic_int_dec_and_test(atomic);
	}

/// <summary>
/// <para>
/// Sets the @atomic to @newval and returns the old value from @atomic.
/// </para>
/// <para>
/// This exchange is done atomically.
/// </para>
/// <para>
/// Think of this operation as an atomic version of
/// `{ tmp = *atomic; *atomic = val; return tmp; }`.
/// </para>
/// <para>
/// This call acts as a full compiler and hardware memory barrier.
/// </para>
/// </summary>

/// <param name="atomic">
/// a pointer to a #gint or #guint
/// </param>
/// <param name="newval">
/// the value to replace with
/// </param>
/// <return>
/// the value of @atomic before the exchange, signed
/// </return>

	public static int AtomicIntExchange(int atomic, int newval)
	{
		return GLibGlobalFunctionsExterns.g_atomic_int_exchange(atomic, newval);
	}

/// <summary>
/// <para>
/// This function existed before g_atomic_int_add() returned the prior
/// value of the integer (which it now does).  It is retained only for
/// compatibility reasons.  Don&apos;t use this function in new code.
/// </para>
/// </summary>

/// <param name="atomic">
/// a pointer to a #gint
/// </param>
/// <param name="val">
/// the value to add
/// </param>
/// <return>
/// the value of @atomic before the add, signed
/// </return>

	public static int AtomicIntExchangeAndAdd(int atomic, int val)
	{
		return GLibGlobalFunctionsExterns.g_atomic_int_exchange_and_add(atomic, val);
	}

/// <summary>
/// <para>
/// Gets the current value of @atomic.
/// </para>
/// <para>
/// This call acts as a full compiler and hardware
/// memory barrier (before the get).
/// </para>
/// <para>
/// While @atomic has a `volatile` qualifier, this is a historical artifact and
/// the pointer passed to it should not be `volatile`.
/// </para>
/// </summary>

/// <param name="atomic">
/// a pointer to a #gint or #guint
/// </param>
/// <return>
/// the value of the integer
/// </return>

	public static int AtomicIntGet(int atomic)
	{
		return GLibGlobalFunctionsExterns.g_atomic_int_get(atomic);
	}

/// <summary>
/// <para>
/// Increments the value of @atomic by 1.
/// </para>
/// <para>
/// Think of this operation as an atomic version of `{ *atomic += 1; }`.
/// </para>
/// <para>
/// This call acts as a full compiler and hardware memory barrier.
/// </para>
/// <para>
/// While @atomic has a `volatile` qualifier, this is a historical artifact and
/// the pointer passed to it should not be `volatile`.
/// </para>
/// </summary>

/// <param name="atomic">
/// a pointer to a #gint or #guint
/// </param>

	public static void AtomicIntInc(int atomic)
	{
		GLibGlobalFunctionsExterns.g_atomic_int_inc(atomic);
	}

/// <summary>
/// <para>
/// Performs an atomic bitwise &apos;or&apos; of the value of @atomic and @val,
/// storing the result back in @atomic.
/// </para>
/// <para>
/// Think of this operation as an atomic version of
/// `{ tmp = *atomic; *atomic |= val; return tmp; }`.
/// </para>
/// <para>
/// This call acts as a full compiler and hardware memory barrier.
/// </para>
/// <para>
/// While @atomic has a `volatile` qualifier, this is a historical artifact and
/// the pointer passed to it should not be `volatile`.
/// </para>
/// </summary>

/// <param name="atomic">
/// a pointer to a #gint or #guint
/// </param>
/// <param name="val">
/// the value to &apos;or&apos;
/// </param>
/// <return>
/// the value of @atomic before the operation, unsigned
/// </return>

	public static uint AtomicIntOr(uint atomic, uint val)
	{
		return GLibGlobalFunctionsExterns.g_atomic_int_or(atomic, val);
	}

/// <summary>
/// <para>
/// Sets the value of @atomic to @newval.
/// </para>
/// <para>
/// This call acts as a full compiler and hardware
/// memory barrier (after the set).
/// </para>
/// <para>
/// While @atomic has a `volatile` qualifier, this is a historical artifact and
/// the pointer passed to it should not be `volatile`.
/// </para>
/// </summary>

/// <param name="atomic">
/// a pointer to a #gint or #guint
/// </param>
/// <param name="newval">
/// a new value to store
/// </param>

	public static void AtomicIntSet(int atomic, int newval)
	{
		GLibGlobalFunctionsExterns.g_atomic_int_set(atomic, newval);
	}

/// <summary>
/// <para>
/// Performs an atomic bitwise &apos;xor&apos; of the value of @atomic and @val,
/// storing the result back in @atomic.
/// </para>
/// <para>
/// Think of this operation as an atomic version of
/// `{ tmp = *atomic; *atomic ^= val; return tmp; }`.
/// </para>
/// <para>
/// This call acts as a full compiler and hardware memory barrier.
/// </para>
/// <para>
/// While @atomic has a `volatile` qualifier, this is a historical artifact and
/// the pointer passed to it should not be `volatile`.
/// </para>
/// </summary>

/// <param name="atomic">
/// a pointer to a #gint or #guint
/// </param>
/// <param name="val">
/// the value to &apos;xor&apos;
/// </param>
/// <return>
/// the value of @atomic before the operation, unsigned
/// </return>

	public static uint AtomicIntXor(uint atomic, uint val)
	{
		return GLibGlobalFunctionsExterns.g_atomic_int_xor(atomic, val);
	}

/// <summary>
/// <para>
/// Atomically adds @val to the value of @atomic.
/// </para>
/// <para>
/// Think of this operation as an atomic version of
/// `{ tmp = *atomic; *atomic += val; return tmp; }`.
/// </para>
/// <para>
/// This call acts as a full compiler and hardware memory barrier.
/// </para>
/// <para>
/// While @atomic has a `volatile` qualifier, this is a historical artifact and
/// the pointer passed to it should not be `volatile`.
/// </para>
/// <para>
/// In GLib 2.80, the return type was changed from #gssize to #gintptr to add
/// support for platforms with 128-bit pointers. This should not affect existing
/// code.
/// </para>
/// </summary>

/// <param name="atomic">
/// a pointer to a #gpointer-sized value
/// </param>
/// <param name="val">
/// the value to add
/// </param>
/// <return>
/// the value of @atomic before the add, signed
/// </return>

	public static int AtomicPointerAdd(IntPtr atomic, UIntPtr val)
	{
		return GLibGlobalFunctionsExterns.g_atomic_pointer_add(atomic, val);
	}

/// <summary>
/// <para>
/// Performs an atomic bitwise &apos;and&apos; of the value of @atomic and @val,
/// storing the result back in @atomic.
/// </para>
/// <para>
/// Think of this operation as an atomic version of
/// `{ tmp = *atomic; *atomic &amp;= val; return tmp; }`.
/// </para>
/// <para>
/// This call acts as a full compiler and hardware memory barrier.
/// </para>
/// <para>
/// While @atomic has a `volatile` qualifier, this is a historical artifact and
/// the pointer passed to it should not be `volatile`.
/// </para>
/// <para>
/// In GLib 2.80, the return type was changed from #gsize to #guintptr to add
/// support for platforms with 128-bit pointers. This should not affect existing
/// code.
/// </para>
/// </summary>

/// <param name="atomic">
/// a pointer to a #gpointer-sized value
/// </param>
/// <param name="val">
/// the value to &apos;and&apos;
/// </param>
/// <return>
/// the value of @atomic before the operation, unsigned
/// </return>

	public static uint AtomicPointerAnd(IntPtr atomic, UIntPtr val)
	{
		return GLibGlobalFunctionsExterns.g_atomic_pointer_and(atomic, val);
	}

/// <summary>
/// <para>
/// Compares @atomic to @oldval and, if equal, sets it to @newval.
/// If @atomic was not equal to @oldval then no change occurs.
/// </para>
/// <para>
/// This compare and exchange is done atomically.
/// </para>
/// <para>
/// Think of this operation as an atomic version of
/// `{ if (*atomic == oldval) { *atomic = newval; return TRUE; } else return FALSE; }`.
/// </para>
/// <para>
/// This call acts as a full compiler and hardware memory barrier.
/// </para>
/// <para>
/// While @atomic has a `volatile` qualifier, this is a historical artifact and
/// the pointer passed to it should not be `volatile`.
/// </para>
/// </summary>

/// <param name="atomic">
/// a pointer to a #gpointer-sized value
/// </param>
/// <param name="oldval">
/// the value to compare with
/// </param>
/// <param name="newval">
/// the value to conditionally replace with
/// </param>
/// <return>
/// %TRUE if the exchange took place
/// </return>

	public static bool AtomicPointerCompareAndExchange(IntPtr atomic, IntPtr oldval, IntPtr newval)
	{
		return GLibGlobalFunctionsExterns.g_atomic_pointer_compare_and_exchange(atomic, oldval, newval);
	}

/// <summary>
/// <para>
/// Compares @atomic to @oldval and, if equal, sets it to @newval.
/// If @atomic was not equal to @oldval then no change occurs.
/// In any case the value of @atomic before this operation is stored in @preval.
/// </para>
/// <para>
/// This compare and exchange is done atomically.
/// </para>
/// <para>
/// Think of this operation as an atomic version of
/// `{ *preval = *atomic; if (*atomic == oldval) { *atomic = newval; return TRUE; } else return FALSE; }`.
/// </para>
/// <para>
/// This call acts as a full compiler and hardware memory barrier.
/// </para>
/// <para>
/// See also g_atomic_pointer_compare_and_exchange()
/// </para>
/// </summary>

/// <param name="atomic">
/// a pointer to a #gpointer-sized value
/// </param>
/// <param name="oldval">
/// the value to compare with
/// </param>
/// <param name="newval">
/// the value to conditionally replace with
/// </param>
/// <param name="preval">
/// the contents of @atomic before this operation
/// </param>
/// <return>
/// %TRUE if the exchange took place
/// </return>

	public static bool AtomicPointerCompareAndExchangeFull(IntPtr atomic, IntPtr oldval, IntPtr newval, out IntPtr preval)
	{
		return GLibGlobalFunctionsExterns.g_atomic_pointer_compare_and_exchange_full(atomic, oldval, newval, out preval);
	}

/// <summary>
/// <para>
/// Sets the @atomic to @newval and returns the old value from @atomic.
/// </para>
/// <para>
/// This exchange is done atomically.
/// </para>
/// <para>
/// Think of this operation as an atomic version of
/// `{ tmp = *atomic; *atomic = val; return tmp; }`.
/// </para>
/// <para>
/// This call acts as a full compiler and hardware memory barrier.
/// </para>
/// </summary>

/// <param name="atomic">
/// a pointer to a #gpointer-sized value
/// </param>
/// <param name="newval">
/// the value to replace with
/// </param>
/// <return>
/// the value of @atomic before the exchange
/// </return>

	public static IntPtr AtomicPointerExchange(IntPtr atomic, IntPtr newval)
	{
		return GLibGlobalFunctionsExterns.g_atomic_pointer_exchange(atomic, newval);
	}

/// <summary>
/// <para>
/// Gets the current value of @atomic.
/// </para>
/// <para>
/// This call acts as a full compiler and hardware
/// memory barrier (before the get).
/// </para>
/// <para>
/// While @atomic has a `volatile` qualifier, this is a historical artifact and
/// the pointer passed to it should not be `volatile`.
/// </para>
/// </summary>

/// <param name="atomic">
/// a pointer to a #gpointer-sized value
/// </param>
/// <return>
/// the value of the pointer
/// </return>

	public static IntPtr AtomicPointerGet(IntPtr atomic)
	{
		return GLibGlobalFunctionsExterns.g_atomic_pointer_get(atomic);
	}

/// <summary>
/// <para>
/// Performs an atomic bitwise &apos;or&apos; of the value of @atomic and @val,
/// storing the result back in @atomic.
/// </para>
/// <para>
/// Think of this operation as an atomic version of
/// `{ tmp = *atomic; *atomic |= val; return tmp; }`.
/// </para>
/// <para>
/// This call acts as a full compiler and hardware memory barrier.
/// </para>
/// <para>
/// While @atomic has a `volatile` qualifier, this is a historical artifact and
/// the pointer passed to it should not be `volatile`.
/// </para>
/// <para>
/// In GLib 2.80, the return type was changed from #gsize to #guintptr to add
/// support for platforms with 128-bit pointers. This should not affect existing
/// code.
/// </para>
/// </summary>

/// <param name="atomic">
/// a pointer to a #gpointer-sized value
/// </param>
/// <param name="val">
/// the value to &apos;or&apos;
/// </param>
/// <return>
/// the value of @atomic before the operation, unsigned
/// </return>

	public static uint AtomicPointerOr(IntPtr atomic, UIntPtr val)
	{
		return GLibGlobalFunctionsExterns.g_atomic_pointer_or(atomic, val);
	}

/// <summary>
/// <para>
/// Sets the value of @atomic to @newval.
/// </para>
/// <para>
/// This call acts as a full compiler and hardware
/// memory barrier (after the set).
/// </para>
/// <para>
/// While @atomic has a `volatile` qualifier, this is a historical artifact and
/// the pointer passed to it should not be `volatile`.
/// </para>
/// </summary>

/// <param name="atomic">
/// a pointer to a #gpointer-sized value
/// </param>
/// <param name="newval">
/// a new value to store
/// </param>

	public static void AtomicPointerSet(IntPtr atomic, IntPtr newval)
	{
		GLibGlobalFunctionsExterns.g_atomic_pointer_set(atomic, newval);
	}

/// <summary>
/// <para>
/// Performs an atomic bitwise &apos;xor&apos; of the value of @atomic and @val,
/// storing the result back in @atomic.
/// </para>
/// <para>
/// Think of this operation as an atomic version of
/// `{ tmp = *atomic; *atomic ^= val; return tmp; }`.
/// </para>
/// <para>
/// This call acts as a full compiler and hardware memory barrier.
/// </para>
/// <para>
/// While @atomic has a `volatile` qualifier, this is a historical artifact and
/// the pointer passed to it should not be `volatile`.
/// </para>
/// <para>
/// In GLib 2.80, the return type was changed from #gsize to #guintptr to add
/// support for platforms with 128-bit pointers. This should not affect existing
/// code.
/// </para>
/// </summary>

/// <param name="atomic">
/// a pointer to a #gpointer-sized value
/// </param>
/// <param name="val">
/// the value to &apos;xor&apos;
/// </param>
/// <return>
/// the value of @atomic before the operation, unsigned
/// </return>

	public static uint AtomicPointerXor(IntPtr atomic, UIntPtr val)
	{
		return GLibGlobalFunctionsExterns.g_atomic_pointer_xor(atomic, val);
	}

/// <summary>
/// <para>
/// Atomically acquires a reference on the data pointed by @mem_block.
/// </para>
/// </summary>

/// <param name="mem_block">
/// a pointer to reference counted data
/// </param>
/// <return>
/// a pointer to the data,
///   with its reference count increased
/// </return>

	public static IntPtr AtomicRcBoxAcquire(IntPtr mem_block)
	{
		return GLibGlobalFunctionsExterns.g_atomic_rc_box_acquire(mem_block);
	}

/// <summary>
/// <para>
/// Allocates @block_size bytes of memory, and adds atomic
/// reference counting semantics to it.
/// </para>
/// <para>
/// The data will be freed when its reference count drops to
/// zero.
/// </para>
/// <para>
/// The allocated data is guaranteed to be suitably aligned for any
/// built-in type.
/// </para>
/// </summary>

/// <param name="block_size">
/// the size of the allocation, must be greater than 0
/// </param>
/// <return>
/// a pointer to the allocated memory
/// </return>

	public static IntPtr AtomicRcBoxAlloc(UIntPtr block_size)
	{
		return GLibGlobalFunctionsExterns.g_atomic_rc_box_alloc(block_size);
	}

/// <summary>
/// <para>
/// Allocates @block_size bytes of memory, and adds atomic
/// reference counting semantics to it.
/// </para>
/// <para>
/// The contents of the returned data is set to zero.
/// </para>
/// <para>
/// The data will be freed when its reference count drops to
/// zero.
/// </para>
/// <para>
/// The allocated data is guaranteed to be suitably aligned for any
/// built-in type.
/// </para>
/// </summary>

/// <param name="block_size">
/// the size of the allocation, must be greater than 0
/// </param>
/// <return>
/// a pointer to the allocated memory
/// </return>

	public static IntPtr AtomicRcBoxAlloc0(UIntPtr block_size)
	{
		return GLibGlobalFunctionsExterns.g_atomic_rc_box_alloc0(block_size);
	}

/// <summary>
/// <para>
/// Allocates a new block of data with atomic reference counting
/// semantics, and copies @block_size bytes of @mem_block
/// into it.
/// </para>
/// </summary>

/// <param name="block_size">
/// the number of bytes to copy, must be greater than 0
/// </param>
/// <param name="mem_block">
/// the memory to copy
/// </param>
/// <return>
/// a pointer to the allocated
///   memory
/// </return>

	public static IntPtr AtomicRcBoxDup(UIntPtr block_size, IntPtr mem_block)
	{
		return GLibGlobalFunctionsExterns.g_atomic_rc_box_dup(block_size, mem_block);
	}

/// <summary>
/// <para>
/// Retrieves the size of the reference counted data pointed by @mem_block.
/// </para>
/// </summary>

/// <param name="mem_block">
/// a pointer to reference counted data
/// </param>
/// <return>
/// the size of the data, in bytes
/// </return>

	public static UIntPtr AtomicRcBoxGetSize(IntPtr mem_block)
	{
		return GLibGlobalFunctionsExterns.g_atomic_rc_box_get_size(mem_block);
	}

/// <summary>
/// <para>
/// Atomically releases a reference on the data pointed by @mem_block.
/// </para>
/// <para>
/// If the reference was the last one, it will free the
/// resources allocated for @mem_block.
/// </para>
/// </summary>

/// <param name="mem_block">
/// a pointer to reference counted data
/// </param>

	public static void AtomicRcBoxRelease(IntPtr mem_block)
	{
		GLibGlobalFunctionsExterns.g_atomic_rc_box_release(mem_block);
	}

/// <summary>
/// <para>
/// Atomically releases a reference on the data pointed by @mem_block.
/// </para>
/// <para>
/// If the reference was the last one, it will call @clear_func
/// to clear the contents of @mem_block, and then will free the
/// resources allocated for @mem_block.
/// </para>
/// <para>
/// Note that implementing weak references via @clear_func is not thread-safe:
/// clearing a pointer to the memory from the callback can race with another
/// thread trying to access it as @mem_block already has a reference count of 0
/// when the callback is called and will be freed.
/// </para>
/// </summary>

/// <param name="mem_block">
/// a pointer to reference counted data
/// </param>
/// <param name="clear_func">
/// a function to call when clearing the data
/// </param>

	public static void AtomicRcBoxReleaseFull(IntPtr mem_block, MentorLake.GLib.GDestroyNotify clear_func)
	{
		GLibGlobalFunctionsExterns.g_atomic_rc_box_release_full(mem_block, clear_func);
	}

/// <summary>
/// <para>
/// Atomically compares the current value of @arc with @val.
/// </para>
/// </summary>

/// <param name="arc">
/// the address of an atomic reference count variable
/// </param>
/// <param name="val">
/// the value to compare
/// </param>
/// <return>
/// %TRUE if the reference count is the same
///   as the given value
/// </return>

	public static bool AtomicRefCountCompare(int arc, int val)
	{
		return GLibGlobalFunctionsExterns.g_atomic_ref_count_compare(arc, val);
	}

/// <summary>
/// <para>
/// Atomically decreases the reference count.
/// </para>
/// <para>
/// If %TRUE is returned, the reference count reached 0. After this point, @arc
/// is an undefined state and must be reinitialized with
/// g_atomic_ref_count_init() to be used again.
/// </para>
/// </summary>

/// <param name="arc">
/// the address of an atomic reference count variable
/// </param>
/// <return>
/// %TRUE if the reference count reached 0, and %FALSE otherwise
/// </return>

	public static bool AtomicRefCountDec(int arc)
	{
		return GLibGlobalFunctionsExterns.g_atomic_ref_count_dec(arc);
	}

/// <summary>
/// <para>
/// Atomically increases the reference count.
/// </para>
/// </summary>

/// <param name="arc">
/// the address of an atomic reference count variable
/// </param>

	public static void AtomicRefCountInc(int arc)
	{
		GLibGlobalFunctionsExterns.g_atomic_ref_count_inc(arc);
	}

/// <summary>
/// <para>
/// Initializes a reference count variable to 1.
/// </para>
/// </summary>

/// <param name="arc">
/// the address of an atomic reference count variable
/// </param>

	public static void AtomicRefCountInit(int arc)
	{
		GLibGlobalFunctionsExterns.g_atomic_ref_count_init(arc);
	}

/// <summary>
/// <para>
/// Decode a sequence of Base-64 encoded text into binary data.  Note
/// that the returned binary data is not necessarily zero-terminated,
/// so it should not be used as a character string.
/// </para>
/// </summary>

/// <param name="text">
/// zero-terminated string with base64 text to decode
/// </param>
/// <param name="out_len">
/// The length of the decoded data is written here
/// </param>
/// <return>
/// 
///               newly allocated buffer containing the binary data
///               that @text represents. The returned buffer must
///               be freed with g_free().
/// </return>

	public static byte[] Base64Decode(string text, out UIntPtr out_len)
	{
		return GLibGlobalFunctionsExterns.g_base64_decode(text, out out_len);
	}

/// <summary>
/// <para>
/// Decode a sequence of Base-64 encoded text into binary data
/// by overwriting the input data.
/// </para>
/// </summary>

/// <param name="text">
/// zero-terminated
///        string with base64 text to decode
/// </param>
/// <param name="out_len">
/// The length of the decoded data is written here
/// </param>
/// <return>
/// The binary data that @text responds. This pointer
///               is the same as the input @text.
/// </return>

	public static byte Base64DecodeInplace(ref byte[] text, ref UIntPtr out_len)
	{
		return GLibGlobalFunctionsExterns.g_base64_decode_inplace(ref text, ref out_len);
	}

/// <summary>
/// <para>
/// Incrementally decode a sequence of binary data from its Base-64 stringified
/// representation. By calling this function multiple times you can convert
/// data in chunks to avoid having to have the full encoded data in memory.
/// </para>
/// <para>
/// The output buffer must be large enough to fit all the data that will
/// be written to it. Since base64 encodes 3 bytes in 4 chars you need
/// at least: (@len / 4) * 3 + 3 bytes (+ 3 may be needed in case of non-zero
/// state).
/// </para>
/// </summary>

/// <param name="@in">
/// binary input data
/// </param>
/// <param name="len">
/// max length of @in data to decode
/// </param>
/// <param name="@out">
/// output buffer
/// </param>
/// <param name="state">
/// Saved state between steps, initialize to 0
/// </param>
/// <param name="save">
/// Saved state between steps, initialize to 0
/// </param>
/// <return>
/// The number of bytes of output that was written
/// </return>

	public static UIntPtr Base64DecodeStep(byte[] @in, UIntPtr len, out byte[] @out, ref int state, ref uint save)
	{
		return GLibGlobalFunctionsExterns.g_base64_decode_step(@in, len, out @out, ref state, ref save);
	}

/// <summary>
/// <para>
/// Encode a sequence of binary data into its Base-64 stringified
/// representation.
/// </para>
/// </summary>

/// <param name="data">
/// the binary data to encode
/// </param>
/// <param name="len">
/// the length of @data
/// </param>
/// <return>
/// a newly allocated, zero-terminated Base-64
///               encoded string representing @data. The returned string must
///               be freed with g_free().
/// </return>

	public static string Base64Encode(byte[] data, UIntPtr len)
	{
		return GLibGlobalFunctionsExterns.g_base64_encode(data, len);
	}

/// <summary>
/// <para>
/// Flush the status from a sequence of calls to g_base64_encode_step().
/// </para>
/// <para>
/// The output buffer must be large enough to fit all the data that will
/// be written to it. It will need up to 4 bytes, or up to 5 bytes if
/// line-breaking is enabled.
/// </para>
/// <para>
/// The @out array will not be automatically nul-terminated.
/// </para>
/// </summary>

/// <param name="break_lines">
/// whether to break long lines
/// </param>
/// <param name="@out">
/// pointer to destination buffer
/// </param>
/// <param name="state">
/// Saved state from g_base64_encode_step()
/// </param>
/// <param name="save">
/// Saved state from g_base64_encode_step()
/// </param>
/// <return>
/// The number of bytes of output that was written
/// </return>

	public static UIntPtr Base64EncodeClose(bool break_lines, out byte[] @out, ref int state, ref int save)
	{
		return GLibGlobalFunctionsExterns.g_base64_encode_close(break_lines, out @out, ref state, ref save);
	}

/// <summary>
/// <para>
/// Incrementally encode a sequence of binary data into its Base-64 stringified
/// representation. By calling this function multiple times you can convert
/// data in chunks to avoid having to have the full encoded data in memory.
/// </para>
/// <para>
/// When all of the data has been converted you must call
/// g_base64_encode_close() to flush the saved state.
/// </para>
/// <para>
/// The output buffer must be large enough to fit all the data that will
/// be written to it. Due to the way base64 encodes you will need
/// at least: (@len / 3 + 1) * 4 + 4 bytes (+ 4 may be needed in case of
/// non-zero state). If you enable line-breaking you will need at least:
/// ((@len / 3 + 1) * 4 + 4) / 76 + 1 bytes of extra space.
/// </para>
/// <para>
/// @break_lines is typically used when putting base64-encoded data in emails.
/// It breaks the lines at 76 columns instead of putting all of the text on
/// the same line. This avoids problems with long lines in the email system.
/// Note however that it breaks the lines with `LF` characters, not
/// `CR LF` sequences, so the result cannot be passed directly to SMTP
/// or certain other protocols.
/// </para>
/// </summary>

/// <param name="@in">
/// the binary data to encode
/// </param>
/// <param name="len">
/// the length of @in
/// </param>
/// <param name="break_lines">
/// whether to break long lines
/// </param>
/// <param name="@out">
/// pointer to destination buffer
/// </param>
/// <param name="state">
/// Saved state between steps, initialize to 0
/// </param>
/// <param name="save">
/// Saved state between steps, initialize to 0
/// </param>
/// <return>
/// The number of bytes of output that was written
/// </return>

	public static UIntPtr Base64EncodeStep(byte[] @in, UIntPtr len, bool break_lines, out byte[] @out, ref int state, ref int save)
	{
		return GLibGlobalFunctionsExterns.g_base64_encode_step(@in, len, break_lines, out @out, ref state, ref save);
	}

/// <summary>
/// <para>
/// Gets the name of the file without any leading directory
/// components. It returns a pointer into the given file name
/// string.
/// </para>
/// </summary>

/// <param name="file_name">
/// the name of the file
/// </param>
/// <return>
/// the name of the file without any leading
///   directory components
/// </return>

	public static string Basename(string file_name)
	{
		return GLibGlobalFunctionsExterns.g_basename(file_name);
	}

/// <summary>
/// <para>
/// Sets the indicated @lock_bit in @address.  If the bit is already
/// set, this call will block until g_bit_unlock() unsets the
/// corresponding bit.
/// </para>
/// <para>
/// Attempting to lock on two different bits within the same integer is
/// not supported and will very probably cause deadlocks.
/// </para>
/// <para>
/// The value of the bit that is set is (1u &amp;lt;&amp;lt; @bit).  If @bit is not
/// between 0 and 31 then the result is undefined.
/// </para>
/// <para>
/// This function accesses @address atomically.  All other accesses to
/// @address must be atomic in order for this function to work
/// reliably. While @address has a `volatile` qualifier, this is a historical
/// artifact and the argument passed to it should not be `volatile`.
/// </para>
/// </summary>

/// <param name="address">
/// a pointer to an integer
/// </param>
/// <param name="lock_bit">
/// a bit value between 0 and 31
/// </param>

	public static void BitLock(int address, int lock_bit)
	{
		GLibGlobalFunctionsExterns.g_bit_lock(address, lock_bit);
	}

/// <summary>
/// <para>
/// Find the position of the first bit set in @mask, searching
/// from (but not including) @nth_bit upwards. Bits are numbered
/// from 0 (least significant) to sizeof(#gulong) * 8 - 1 (31 or 63,
/// usually). To start searching from the 0th bit, set @nth_bit to -1.
/// </para>
/// </summary>

/// <param name="mask">
/// a #gulong containing flags
/// </param>
/// <param name="nth_bit">
/// the index of the bit to start the search from
/// </param>
/// <return>
/// the index of the first bit set which is higher than @nth_bit, or -1
///    if no higher bits are set
/// </return>

	public static int BitNthLsf(ulong mask, int nth_bit)
	{
		return GLibGlobalFunctionsExterns.g_bit_nth_lsf(mask, nth_bit);
	}

/// <summary>
/// <para>
/// Find the position of the first bit set in @mask, searching
/// from (but not including) @nth_bit downwards. Bits are numbered
/// from 0 (least significant) to sizeof(#gulong) * 8 - 1 (31 or 63,
/// usually). To start searching from the last bit, set @nth_bit to
/// -1 or GLIB_SIZEOF_LONG * 8.
/// </para>
/// </summary>

/// <param name="mask">
/// a #gulong containing flags
/// </param>
/// <param name="nth_bit">
/// the index of the bit to start the search from
/// </param>
/// <return>
/// the index of the first bit set which is lower than @nth_bit, or -1
///    if no lower bits are set
/// </return>

	public static int BitNthMsf(ulong mask, int nth_bit)
	{
		return GLibGlobalFunctionsExterns.g_bit_nth_msf(mask, nth_bit);
	}

/// <summary>
/// <para>
/// Gets the number of bits used to hold @number,
/// e.g. if @number is 4, 3 bits are needed.
/// </para>
/// </summary>

/// <param name="number">
/// a #guint
/// </param>
/// <return>
/// the number of bits used to hold @number
/// </return>

	public static uint BitStorage(ulong number)
	{
		return GLibGlobalFunctionsExterns.g_bit_storage(number);
	}

/// <summary>
/// <para>
/// Sets the indicated @lock_bit in @address, returning %TRUE if
/// successful.  If the bit is already set, returns %FALSE immediately.
/// </para>
/// <para>
/// Attempting to lock on two different bits within the same integer is
/// not supported.
/// </para>
/// <para>
/// The value of the bit that is set is (1u &amp;lt;&amp;lt; @bit).  If @bit is not
/// between 0 and 31 then the result is undefined.
/// </para>
/// <para>
/// This function accesses @address atomically.  All other accesses to
/// @address must be atomic in order for this function to work
/// reliably. While @address has a `volatile` qualifier, this is a historical
/// artifact and the argument passed to it should not be `volatile`.
/// </para>
/// </summary>

/// <param name="address">
/// a pointer to an integer
/// </param>
/// <param name="lock_bit">
/// a bit value between 0 and 31
/// </param>
/// <return>
/// %TRUE if the lock was acquired
/// </return>

	public static bool BitTrylock(int address, int lock_bit)
	{
		return GLibGlobalFunctionsExterns.g_bit_trylock(address, lock_bit);
	}

/// <summary>
/// <para>
/// Clears the indicated @lock_bit in @address.  If another thread is
/// currently blocked in g_bit_lock() on this same bit then it will be
/// woken up.
/// </para>
/// <para>
/// This function accesses @address atomically.  All other accesses to
/// @address must be atomic in order for this function to work
/// reliably. While @address has a `volatile` qualifier, this is a historical
/// artifact and the argument passed to it should not be `volatile`.
/// </para>
/// </summary>

/// <param name="address">
/// a pointer to an integer
/// </param>
/// <param name="lock_bit">
/// a bit value between 0 and 31
/// </param>

	public static void BitUnlock(int address, int lock_bit)
	{
		GLibGlobalFunctionsExterns.g_bit_unlock(address, lock_bit);
	}



	public static void BlowChunks()
	{
		GLibGlobalFunctionsExterns.g_blow_chunks();
	}



	public static MentorLake.GLib.GQuark BookmarkFileErrorQuark()
	{
		return GLibGlobalFunctionsExterns.g_bookmark_file_error_quark();
	}

/// <summary>
/// <para>
/// Creates a filename from a series of elements using the correct
/// separator for the current platform.
/// </para>
/// <para>
/// On Unix, this function behaves identically to `g_build_path
/// (G_DIR_SEPARATOR_S, first_element, ....)`.
/// </para>
/// <para>
/// On Windows, it takes into account that either the backslash
/// (`\` or slash (`/`) can be used as separator in filenames, but
/// otherwise behaves as on UNIX. When file pathname separators need
/// to be inserted, the one that last previously occurred in the
/// parameters (reading from left to right) is used.
/// </para>
/// <para>
/// No attempt is made to force the resulting filename to be an absolute
/// path. If the first element is a relative path, the result will
/// be a relative path.
/// </para>
/// <para>
/// If you are building a path programmatically you may want to use
/// #GPathBuf instead.
/// </para>
/// </summary>

/// <param name="first_element">
/// the first element in the path
/// </param>
/// <param name="@__arglist">
/// remaining elements in path, terminated by %NULL
/// </param>
/// <return>
/// the newly allocated path
/// </return>

	public static string BuildFilename(string first_element, IntPtr @__arglist)
	{
		return GLibGlobalFunctionsExterns.g_build_filename(first_element, @__arglist);
	}

/// <summary>
/// <para>
/// Creates a filename from a list of elements using the correct
/// separator for the current platform.
/// </para>
/// <para>
/// Behaves exactly like g_build_filename(), but takes the path elements
/// as a va_list.
/// </para>
/// <para>
/// This function is mainly meant for implementing other variadic arguments
/// functions.
/// </para>
/// </summary>

/// <param name="first_element">
/// the first element in the path
/// </param>
/// <param name="args">
/// va_list of remaining elements in path
/// </param>
/// <return>
/// the newly allocated path
/// </return>

	public static string BuildFilenameValist(string first_element, IntPtr args)
	{
		return GLibGlobalFunctionsExterns.g_build_filename_valist(first_element, args);
	}

/// <summary>
/// <para>
/// Creates a filename from a vector of elements using the correct
/// separator for the current platform.
/// </para>
/// <para>
/// This function behaves exactly like g_build_filename(), but takes the path
/// elements as a string array, instead of varargs. This function is mainly
/// meant for language bindings.
/// </para>
/// <para>
/// If you are building a path programmatically you may want to use
/// #GPathBuf instead.
/// </para>
/// </summary>

/// <param name="args">
/// %NULL-terminated
///   array of strings containing the path elements.
/// </param>
/// <return>
/// the newly allocated path
/// </return>

	public static string BuildFilenamev(string[] args)
	{
		return GLibGlobalFunctionsExterns.g_build_filenamev(args);
	}

/// <summary>
/// <para>
/// Creates a path from a series of elements using @separator as the
/// separator between elements.
/// </para>
/// <para>
/// At the boundary between two elements, any trailing occurrences of
/// separator in the first element, or leading occurrences of separator
/// in the second element are removed and exactly one copy of the
/// separator is inserted.
/// </para>
/// <para>
/// Empty elements are ignored.
/// </para>
/// <para>
/// The number of leading copies of the separator on the result is
/// the same as the number of leading copies of the separator on
/// the first non-empty element.
/// </para>
/// <para>
/// The number of trailing copies of the separator on the result is
/// the same as the number of trailing copies of the separator on
/// the last non-empty element. (Determination of the number of
/// trailing copies is done without stripping leading copies, so
/// if the separator is `ABA`, then `ABABA` has 1 trailing copy.)
/// </para>
/// <para>
/// However, if there is only a single non-empty element, and there
/// are no characters in that element not part of the leading or
/// trailing separators, then the result is exactly the original value
/// of that element.
/// </para>
/// <para>
/// Other than for determination of the number of leading and trailing
/// copies of the separator, elements consisting only of copies
/// of the separator are ignored.
/// </para>
/// </summary>

/// <param name="separator">
/// a string used to separator the elements of the path.
/// </param>
/// <param name="first_element">
/// the first element in the path
/// </param>
/// <param name="@__arglist">
/// remaining elements in path, terminated by %NULL
/// </param>
/// <return>
/// the newly allocated path
/// </return>

	public static string BuildPath(string separator, string first_element, IntPtr @__arglist)
	{
		return GLibGlobalFunctionsExterns.g_build_path(separator, first_element, @__arglist);
	}

/// <summary>
/// <para>
/// Behaves exactly like g_build_path(), but takes the path elements
/// as a string array, instead of variadic arguments.
/// </para>
/// <para>
/// This function is mainly meant for language bindings.
/// </para>
/// </summary>

/// <param name="separator">
/// a string used to separator the elements of the path.
/// </param>
/// <param name="args">
/// %NULL-terminated
///   array of strings containing the path elements.
/// </param>
/// <return>
/// a newly-allocated string that
///     must be freed with g_free().
/// </return>

	public static string BuildPathv(string separator, string[] args)
	{
		return GLibGlobalFunctionsExterns.g_build_pathv(separator, args);
	}

/// <summary>
/// <para>
/// Adds the given bytes to the end of the #GByteArray.
/// The array will grow in size automatically if necessary.
/// </para>
/// </summary>

/// <param name="array">
/// a #GByteArray
/// </param>
/// <param name="data">
/// the byte data to be added
/// </param>
/// <param name="len">
/// the number of bytes to add
/// </param>
/// <return>
/// the #GByteArray
/// </return>

	public static MentorLake.GLib.GByteArrayHandle ByteArrayAppend(MentorLake.GLib.GByteArrayHandle array, byte data, uint len)
	{
		return GLibGlobalFunctionsExterns.g_byte_array_append(array, data, len);
	}

/// <summary>
/// <para>
/// Frees the memory allocated by the #GByteArray. If @free_segment is
/// %TRUE it frees the actual byte data. If the reference count of
/// @array is greater than one, the #GByteArray wrapper is preserved but
/// the size of @array will be set to zero.
/// </para>
/// </summary>

/// <param name="array">
/// a #GByteArray
/// </param>
/// <param name="free_segment">
/// if %TRUE the actual byte data is freed as well
/// </param>
/// <return>
/// the element data if @free_segment is %FALSE, otherwise
///          %NULL.  The element data should be freed using g_free().
/// </return>

	public static byte ByteArrayFree(MentorLake.GLib.GByteArrayHandle array, bool free_segment)
	{
		return GLibGlobalFunctionsExterns.g_byte_array_free(array, free_segment);
	}

/// <summary>
/// <para>
/// Transfers the data from the #GByteArray into a new immutable #GBytes.
/// </para>
/// <para>
/// The #GByteArray is freed unless the reference count of @array is greater
/// than one, the #GByteArray wrapper is preserved but the size of @array
/// will be set to zero.
/// </para>
/// <para>
/// This is identical to using g_bytes_new_take() and g_byte_array_free()
/// together.
/// </para>
/// </summary>

/// <param name="array">
/// a #GByteArray
/// </param>
/// <return>
/// a new immutable #GBytes representing same
///     byte data that was in the array
/// </return>

	public static MentorLake.GLib.GBytesHandle ByteArrayFreeToBytes(MentorLake.GLib.GByteArrayHandle array)
	{
		return GLibGlobalFunctionsExterns.g_byte_array_free_to_bytes(array);
	}

/// <summary>
/// <para>
/// Creates a new #GByteArray with a reference count of 1.
/// </para>
/// </summary>

/// <return>
/// the new #GByteArray
/// </return>

	public static MentorLake.GLib.GByteArrayHandle ByteArrayNew()
	{
		return GLibGlobalFunctionsExterns.g_byte_array_new();
	}

/// <summary>
/// <para>
/// Creates a byte array containing the @data.
/// After this call, @data belongs to the #GByteArray and may no longer be
/// modified by the caller. The memory of @data has to be dynamically
/// allocated and will eventually be freed with g_free().
/// </para>
/// <para>
/// Do not use it if @len is greater than %G_MAXUINT. #GByteArray
/// stores the length of its data in #guint, which may be shorter than
/// #gsize.
/// </para>
/// </summary>

/// <param name="data">
/// byte data for the array
/// </param>
/// <param name="len">
/// length of @data
/// </param>
/// <return>
/// a new #GByteArray
/// </return>

	public static MentorLake.GLib.GByteArrayHandle ByteArrayNewTake(byte[] data, UIntPtr len)
	{
		return GLibGlobalFunctionsExterns.g_byte_array_new_take(data, len);
	}

/// <summary>
/// <para>
/// Adds the given data to the start of the #GByteArray.
/// The array will grow in size automatically if necessary.
/// </para>
/// </summary>

/// <param name="array">
/// a #GByteArray
/// </param>
/// <param name="data">
/// the byte data to be added
/// </param>
/// <param name="len">
/// the number of bytes to add
/// </param>
/// <return>
/// the #GByteArray
/// </return>

	public static MentorLake.GLib.GByteArrayHandle ByteArrayPrepend(MentorLake.GLib.GByteArrayHandle array, byte data, uint len)
	{
		return GLibGlobalFunctionsExterns.g_byte_array_prepend(array, data, len);
	}

/// <summary>
/// <para>
/// Atomically increments the reference count of @array by one.
/// This function is thread-safe and may be called from any thread.
/// </para>
/// </summary>

/// <param name="array">
/// A #GByteArray
/// </param>
/// <return>
/// The passed in #GByteArray
/// </return>

	public static MentorLake.GLib.GByteArrayHandle ByteArrayRef(MentorLake.GLib.GByteArrayHandle array)
	{
		return GLibGlobalFunctionsExterns.g_byte_array_ref(array);
	}

/// <summary>
/// <para>
/// Removes the byte at the given index from a #GByteArray.
/// The following bytes are moved down one place.
/// </para>
/// </summary>

/// <param name="array">
/// a #GByteArray
/// </param>
/// <param name="index_">
/// the index of the byte to remove
/// </param>
/// <return>
/// the #GByteArray
/// </return>

	public static MentorLake.GLib.GByteArrayHandle ByteArrayRemoveIndex(MentorLake.GLib.GByteArrayHandle array, uint index_)
	{
		return GLibGlobalFunctionsExterns.g_byte_array_remove_index(array, index_);
	}

/// <summary>
/// <para>
/// Removes the byte at the given index from a #GByteArray. The last
/// element in the array is used to fill in the space, so this function
/// does not preserve the order of the #GByteArray. But it is faster
/// than g_byte_array_remove_index().
/// </para>
/// </summary>

/// <param name="array">
/// a #GByteArray
/// </param>
/// <param name="index_">
/// the index of the byte to remove
/// </param>
/// <return>
/// the #GByteArray
/// </return>

	public static MentorLake.GLib.GByteArrayHandle ByteArrayRemoveIndexFast(MentorLake.GLib.GByteArrayHandle array, uint index_)
	{
		return GLibGlobalFunctionsExterns.g_byte_array_remove_index_fast(array, index_);
	}

/// <summary>
/// <para>
/// Removes the given number of bytes starting at the given index from a
/// #GByteArray.  The following elements are moved to close the gap.
/// </para>
/// </summary>

/// <param name="array">
/// a @GByteArray
/// </param>
/// <param name="index_">
/// the index of the first byte to remove
/// </param>
/// <param name="length">
/// the number of bytes to remove
/// </param>
/// <return>
/// the #GByteArray
/// </return>

	public static MentorLake.GLib.GByteArrayHandle ByteArrayRemoveRange(MentorLake.GLib.GByteArrayHandle array, uint index_, uint length)
	{
		return GLibGlobalFunctionsExterns.g_byte_array_remove_range(array, index_, length);
	}

/// <summary>
/// <para>
/// Sets the size of the #GByteArray, expanding it if necessary.
/// </para>
/// </summary>

/// <param name="array">
/// a #GByteArray
/// </param>
/// <param name="length">
/// the new size of the #GByteArray
/// </param>
/// <return>
/// the #GByteArray
/// </return>

	public static MentorLake.GLib.GByteArrayHandle ByteArraySetSize(MentorLake.GLib.GByteArrayHandle array, uint length)
	{
		return GLibGlobalFunctionsExterns.g_byte_array_set_size(array, length);
	}

/// <summary>
/// <para>
/// Creates a new #GByteArray with @reserved_size bytes preallocated.
/// This avoids frequent reallocation, if you are going to add many
/// bytes to the array. Note however that the size of the array is still
/// 0.
/// </para>
/// </summary>

/// <param name="reserved_size">
/// number of bytes preallocated
/// </param>
/// <return>
/// the new #GByteArray
/// </return>

	public static MentorLake.GLib.GByteArrayHandle ByteArraySizedNew(uint reserved_size)
	{
		return GLibGlobalFunctionsExterns.g_byte_array_sized_new(reserved_size);
	}

/// <summary>
/// <para>
/// Sorts a byte array, using @compare_func which should be a
/// qsort()-style comparison function (returns less than zero for first
/// arg is less than second arg, zero for equal, greater than zero if
/// first arg is greater than second arg).
/// </para>
/// <para>
/// If two array elements compare equal, their order in the sorted array
/// is undefined. If you want equal elements to keep their order (i.e.
/// you want a stable sort) you can write a comparison function that,
/// if two elements would otherwise compare equal, compares them by
/// their addresses.
/// </para>
/// </summary>

/// <param name="array">
/// a #GByteArray
/// </param>
/// <param name="compare_func">
/// comparison function
/// </param>

	public static void ByteArraySort(MentorLake.GLib.GByteArrayHandle array, MentorLake.GLib.GCompareFunc compare_func)
	{
		GLibGlobalFunctionsExterns.g_byte_array_sort(array, compare_func);
	}

/// <summary>
/// <para>
/// Like g_byte_array_sort(), but the comparison function takes an extra
/// user data argument.
/// </para>
/// </summary>

/// <param name="array">
/// a #GByteArray
/// </param>
/// <param name="compare_func">
/// comparison function
/// </param>
/// <param name="user_data">
/// data to pass to @compare_func
/// </param>

	public static void ByteArraySortWithData(MentorLake.GLib.GByteArrayHandle array, MentorLake.GLib.GCompareDataFunc compare_func, IntPtr user_data)
	{
		GLibGlobalFunctionsExterns.g_byte_array_sort_with_data(array, compare_func, user_data);
	}

/// <summary>
/// <para>
/// Frees the data in the array and resets the size to zero, while
/// the underlying array is preserved for use elsewhere and returned
/// to the caller.
/// </para>
/// </summary>

/// <param name="array">
/// a #GByteArray.
/// </param>
/// <param name="len">
/// pointer to retrieve the number of
///    elements of the original array
/// </param>
/// <return>
/// the element data, which should be
///     freed using g_free().
/// </return>

	public static byte ByteArraySteal(MentorLake.GLib.GByteArrayHandle array, out UIntPtr len)
	{
		return GLibGlobalFunctionsExterns.g_byte_array_steal(array, out len);
	}

/// <summary>
/// <para>
/// Atomically decrements the reference count of @array by one. If the
/// reference count drops to 0, all memory allocated by the array is
/// released. This function is thread-safe and may be called from any
/// thread.
/// </para>
/// </summary>

/// <param name="array">
/// A #GByteArray
/// </param>

	public static void ByteArrayUnref(MentorLake.GLib.GByteArrayHandle array)
	{
		GLibGlobalFunctionsExterns.g_byte_array_unref(array);
	}

/// <summary>
/// <para>
/// Gets the canonical file name from @filename. All triple slashes are turned into
/// single slashes, and all `..` and `.`s resolved against @relative_to.
/// </para>
/// <para>
/// Symlinks are not followed, and the returned path is guaranteed to be absolute.
/// </para>
/// <para>
/// If @filename is an absolute path, @relative_to is ignored. Otherwise,
/// @relative_to will be prepended to @filename to make it absolute. @relative_to
/// must be an absolute path, or %NULL. If @relative_to is %NULL, it&apos;ll fallback
/// to g_get_current_dir().
/// </para>
/// <para>
/// This function never fails, and will canonicalize file paths even if they don&apos;t
/// exist.
/// </para>
/// <para>
/// No file system I/O is done.
/// </para>
/// </summary>

/// <param name="filename">
/// the name of the file
/// </param>
/// <param name="relative_to">
/// the relative directory, or %NULL
/// to use the current working directory
/// </param>
/// <return>
/// a newly allocated string with the
///   canonical file path
/// </return>

	public static string CanonicalizeFilename(string filename, string relative_to)
	{
		return GLibGlobalFunctionsExterns.g_canonicalize_filename(filename, relative_to);
	}

/// <summary>
/// <para>
/// A wrapper for the POSIX chdir() function. The function changes the
/// current directory of the process to @path.
/// </para>
/// <para>
/// See your C library manual for more details about chdir().
/// </para>
/// </summary>

/// <param name="path">
/// a pathname in the GLib file name encoding
///     (UTF-8 on Windows)
/// </param>
/// <return>
/// 0 on success, -1 if an error occurred.
/// </return>

	public static int Chdir(string path)
	{
		return GLibGlobalFunctionsExterns.g_chdir(path);
	}

/// <summary>
/// <para>
/// Checks that the GLib library in use is compatible with the
/// given version.
/// </para>
/// <para>
/// Generally you would pass in the constants %GLIB_MAJOR_VERSION,
/// %GLIB_MINOR_VERSION, %GLIB_MICRO_VERSION as the three arguments
/// to this function; that produces a check that the library in use
/// is compatible with the version of GLib the application or module
/// was compiled against.
/// </para>
/// <para>
/// Compatibility is defined by two things: first the version
/// of the running library is newer than the version
/// `@required_major.required_minor.@required_micro`. Second
/// the running library must be binary compatible with the
/// version `@required_major.@required_minor.@required_micro`
/// (same major version.)
/// </para>
/// </summary>

/// <param name="required_major">
/// the required major version
/// </param>
/// <param name="required_minor">
/// the required minor version
/// </param>
/// <param name="required_micro">
/// the required micro version
/// </param>
/// <return>
/// %NULL if the GLib library is
///   compatible with the given version, or a string describing the
///   version mismatch. The returned string is owned by GLib and must
///   not be modified or freed.
/// </return>

	public static string CheckVersion(uint required_major, uint required_minor, uint required_micro)
	{
		return GLibGlobalFunctionsExterns.glib_check_version(required_major, required_minor, required_micro);
	}

/// <summary>
/// <para>
/// Gets the length in bytes of digests of type @checksum_type
/// </para>
/// </summary>

/// <param name="checksum_type">
/// a #GChecksumType
/// </param>
/// <return>
/// the checksum length, or -1 if @checksum_type is
/// not supported.
/// </return>

	public static UIntPtr ChecksumTypeGetLength(MentorLake.GLib.GChecksumType checksum_type)
	{
		return GLibGlobalFunctionsExterns.g_checksum_type_get_length(checksum_type);
	}

/// <summary>
/// <para>
/// Sets a function to be called when the child indicated by @pid
/// exits, at a default priority, [const@GLib.PRIORITY_DEFAULT].
/// </para>
/// <para>
/// If you obtain @pid from [func@GLib.spawn_async] or
/// [func@GLib.spawn_async_with_pipes] you will need to pass
/// %G_SPAWN_DO_NOT_REAP_CHILD as flag to the spawn function for the child
/// watching to work.
/// </para>
/// <para>
/// Note that on platforms where #GPid must be explicitly closed
/// (see [func@GLib.spawn_close_pid]) @pid must not be closed while the
/// source is still active. Typically, you will want to call
/// [func@GLib.spawn_close_pid] in the callback function for the source.
/// </para>
/// <para>
/// GLib supports only a single callback per process id.
/// On POSIX platforms, the same restrictions mentioned for
/// [func@GLib.child_watch_source_new] apply to this function.
/// </para>
/// <para>
/// This internally creates a main loop source using
/// [func@GLib.child_watch_source_new] and attaches it to the main loop context
/// using [method@GLib.Source.attach]. You can do these steps manually if you
/// need greater control.
/// </para>
/// </summary>

/// <param name="pid">
/// process id to watch. On POSIX the positive pid of a child
///   process. On Windows a handle for a process (which doesn&apos;t have
///   to be a child).
/// </param>
/// <param name="function">
/// function to call
/// </param>
/// <param name="data">
/// data to pass to @function
/// </param>
/// <return>
/// the ID (greater than 0) of the event source.
/// </return>

	public static uint ChildWatchAdd(MentorLake.GLib.GPid pid, MentorLake.GLib.GChildWatchFunc function, IntPtr data)
	{
		return GLibGlobalFunctionsExterns.g_child_watch_add(pid, function, data);
	}

/// <summary>
/// <para>
/// Sets a function to be called when the child indicated by @pid
/// exits, at the priority @priority.
/// </para>
/// <para>
/// If you obtain @pid from [func@GLib.spawn_async] or
/// [func@GLib.spawn_async_with_pipes] you will need to pass
/// %G_SPAWN_DO_NOT_REAP_CHILD as flag to the spawn function for the child
/// watching to work.
/// </para>
/// <para>
/// In many programs, you will want to call [func@GLib.spawn_check_wait_status]
/// in the callback to determine whether or not the child exited
/// successfully.
/// </para>
/// <para>
/// Also, note that on platforms where #GPid must be explicitly closed
/// (see [func@GLib.spawn_close_pid]) @pid must not be closed while the source
/// is still active.  Typically, you should invoke [func@GLib.spawn_close_pid]
/// in the callback function for the source.
/// </para>
/// <para>
/// GLib supports only a single callback per process id.
/// On POSIX platforms, the same restrictions mentioned for
/// [func@GLib.child_watch_source_new] apply to this function.
/// </para>
/// <para>
/// This internally creates a main loop source using
/// [func@GLib.child_watch_source_new] and attaches it to the main loop context
/// using [method@GLib.Source.attach]. You can do these steps manually if you
/// need greater control.
/// </para>
/// </summary>

/// <param name="priority">
/// the priority of the idle source. Typically this will be in the
///   range between [const@GLib.PRIORITY_DEFAULT_IDLE] and
///   [const@GLib.PRIORITY_HIGH_IDLE].
/// </param>
/// <param name="pid">
/// process to watch. On POSIX the positive pid of a child process. On
/// Windows a handle for a process (which doesn&apos;t have to be a child).
/// </param>
/// <param name="function">
/// function to call
/// </param>
/// <param name="data">
/// data to pass to @function
/// </param>
/// <param name="notify">
/// function to call when the idle is removed, or %NULL
/// </param>
/// <return>
/// the ID (greater than 0) of the event source.
/// </return>

	public static uint ChildWatchAddFull(int priority, MentorLake.GLib.GPid pid, MentorLake.GLib.GChildWatchFunc function, IntPtr data, MentorLake.GLib.GDestroyNotify notify)
	{
		return GLibGlobalFunctionsExterns.g_child_watch_add_full(priority, pid, function, data, notify);
	}

/// <summary>
/// <para>
/// Creates a new child_watch source.
/// </para>
/// <para>
/// The source will not initially be associated with any
/// [struct@GLib.MainContext] and must be added to one with
/// [method@GLib.Source.attach] before it will be executed.
/// </para>
/// <para>
/// Note that child watch sources can only be used in conjunction with
/// `g_spawn...` when the %G_SPAWN_DO_NOT_REAP_CHILD flag is used.
/// </para>
/// <para>
/// Note that on platforms where #GPid must be explicitly closed
/// (see [func@GLib.spawn_close_pid]) @pid must not be closed while the
/// source is still active. Typically, you will want to call
/// [func@GLib.spawn_close_pid] in the callback function for the source.
/// </para>
/// <para>
/// On POSIX platforms, the following restrictions apply to this API
/// due to limitations in POSIX process interfaces:
/// </para>
/// <para>
/// * @pid must be a child of this process
/// * @pid must be positive
/// * the application must not call `waitpid` with a non-positive
///   first argument, for instance in another thread
/// * the application must not wait for @pid to exit by any other
///   mechanism, including `waitpid(pid, ...)` or a second child-watch
///   source for the same @pid
/// * the application must not ignore `SIGCHLD`
/// * Before 2.78, the application could not send a signal (`kill()`) to the
///   watched @pid in a race free manner. Since 2.78, you can do that while the
///   associated [struct@GLib.MainContext] is acquired.
/// * Before 2.78, even after destroying the [struct@GLib.Source], you could not
///   be sure that @pid wasn&apos;t already reaped. Hence, it was also not
///   safe to `kill()` or `waitpid()` on the process ID after the child watch
///   source was gone. Destroying the source before it fired made it
///   impossible to reliably reap the process.
/// </para>
/// <para>
/// If any of those conditions are not met, this and related APIs will
/// not work correctly. This can often be diagnosed via a GLib warning
/// stating that `ECHILD` was received by `waitpid`.
/// </para>
/// <para>
/// Calling `waitpid` for specific processes other than @pid remains a
/// valid thing to do.
/// </para>
/// </summary>

/// <param name="pid">
/// process to watch. On POSIX the positive pid of a child process. On
/// Windows a handle for a process (which doesn&apos;t have to be a child).
/// </param>
/// <return>
/// the newly-created child watch source
/// </return>

	public static MentorLake.GLib.GSourceHandle ChildWatchSourceNew(MentorLake.GLib.GPid pid)
	{
		return GLibGlobalFunctionsExterns.g_child_watch_source_new(pid);
	}

/// <summary>
/// <para>
/// A wrapper for the POSIX chmod() function. The chmod() function is
/// used to set the permissions of a file system object.
/// </para>
/// <para>
/// On Windows the file protection mechanism is not at all POSIX-like,
/// and the underlying chmod() function in the C library just sets or
/// clears the FAT-style READONLY attribute. It does not touch any
/// ACL. Software that needs to manage file permissions on Windows
/// exactly should use the Win32 API.
/// </para>
/// <para>
/// See your C library manual for more details about chmod().
/// </para>
/// </summary>

/// <param name="filename">
/// a pathname in the GLib file name encoding
///     (UTF-8 on Windows)
/// </param>
/// <param name="mode">
/// as in chmod()
/// </param>
/// <return>
/// 0 if the operation succeeded, -1 on error
/// </return>

	public static int Chmod(string filename, int mode)
	{
		return GLibGlobalFunctionsExterns.g_chmod(filename, mode);
	}

/// <summary>
/// <para>
/// If @err or `*err` is %NULL, does nothing. Otherwise,
/// calls g_error_free() on `*err` and sets `*err` to %NULL.
/// </para>
/// </summary>


	public static void ClearError()
	{
		GLibGlobalFunctionsExterns.g_clear_error(out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
	}

/// <summary>
/// <para>
/// Clears a numeric handler, such as a #GSource ID.
/// </para>
/// <para>
/// @tag_ptr must be a valid pointer to the variable holding the handler.
/// </para>
/// <para>
/// If the ID is zero then this function does nothing.
/// Otherwise, @clear_func is called with the ID as a parameter, and the tag is
/// set to zero.
/// </para>
/// <para>
/// A macro is also included that allows this function to be used without
/// pointer casts.
/// </para>
/// </summary>

/// <param name="tag_ptr">
/// a pointer to the handler ID
/// </param>
/// <param name="clear_func">
/// the function to call to clear the handler
/// </param>

	public static void ClearHandleId(uint tag_ptr, MentorLake.GLib.GClearHandleFunc clear_func)
	{
		GLibGlobalFunctionsExterns.g_clear_handle_id(tag_ptr, clear_func);
	}

/// <summary>
/// <para>
/// Clears a pointer to a #GList, freeing it and, optionally, freeing its elements using @destroy.
/// </para>
/// <para>
/// @list_ptr must be a valid pointer. If @list_ptr points to a null #GList, this does nothing.
/// </para>
/// </summary>

/// <param name="list_ptr">
/// a #GList return location
/// </param>
/// <param name="destroy">
/// the function to pass to g_list_free_full() or %NULL to not free elements
/// </param>

	public static void ClearList(IntPtr list_ptr, MentorLake.GLib.GDestroyNotify destroy)
	{
		GLibGlobalFunctionsExterns.g_clear_list(list_ptr, destroy);
	}

/// <summary>
/// <para>
/// Clears a reference to a variable.
/// </para>
/// <para>
/// @pp must not be %NULL.
/// </para>
/// <para>
/// If the reference is %NULL then this function does nothing.
/// Otherwise, the variable is destroyed using @destroy and the
/// pointer is set to %NULL.
/// </para>
/// <para>
/// A macro is also included that allows this function to be used without
/// pointer casts. This will mask any warnings about incompatible function types
/// or calling conventions, so you must ensure that your @destroy function is
/// compatible with being called as [callback@GLib.DestroyNotify] using the
/// standard calling convention for the platform that GLib was compiled for;
/// otherwise the program will experience undefined behaviour.
/// </para>
/// <para>
/// Examples of this kind of undefined behaviour include using many Windows Win32
/// APIs, as well as many if not all OpenGL and Vulkan calls on 32-bit Windows,
/// which typically use the `__stdcall` calling convention rather than the
/// `__cdecl` calling convention.
/// </para>
/// <para>
/// The affected functions can be used by wrapping them in a
/// [callback@GLib.DestroyNotify] that is declared with the standard calling
/// convention:
/// </para>
/// <para>
/// ```c
/// // Wrapper needed to avoid mismatched calling conventions on Windows
/// static void
/// destroy_sync (void *sync)
/// {
///   glDeleteSync (sync);
/// }
/// </para>
/// <para>
/// // …
/// </para>
/// <para>
/// g_clear_pointer (&amp;sync, destroy_sync);
/// ```
/// </para>
/// </summary>

/// <param name="pp">
/// a pointer to a
///   variable, struct member etc. holding a pointer
/// </param>
/// <param name="destroy">
/// a function to which a gpointer can be passed, to destroy `*pp`
/// </param>

	public static void ClearPointer(ref IntPtr pp, MentorLake.GLib.GDestroyNotify destroy)
	{
		GLibGlobalFunctionsExterns.g_clear_pointer(ref pp, destroy);
	}

/// <summary>
/// <para>
/// Clears a pointer to a #GSList, freeing it and, optionally, freeing its elements using @destroy.
/// </para>
/// <para>
/// @slist_ptr must be a valid pointer. If @slist_ptr points to a null #GSList, this does nothing.
/// </para>
/// </summary>

/// <param name="slist_ptr">
/// a #GSList return location
/// </param>
/// <param name="destroy">
/// the function to pass to g_slist_free_full() or %NULL to not free elements
/// </param>

	public static void ClearSlist(IntPtr slist_ptr, MentorLake.GLib.GDestroyNotify destroy)
	{
		GLibGlobalFunctionsExterns.g_clear_slist(slist_ptr, destroy);
	}

/// <summary>
/// <para>
/// This wraps the close() call. In case of error, %errno will be
/// preserved, but the error will also be stored as a #GError in @error.
/// In case of success, %errno is undefined.
/// </para>
/// <para>
/// Besides using #GError, there is another major reason to prefer this
/// function over the call provided by the system; on Unix, it will
/// attempt to correctly handle %EINTR, which has platform-specific
/// semantics.
/// </para>
/// <para>
/// It is a bug to call this function with an invalid file descriptor.
/// </para>
/// <para>
/// On POSIX platforms since GLib 2.76, this function is async-signal safe
/// if (and only if) @error is %NULL and @fd is a valid open file descriptor.
/// This makes it safe to call from a signal handler or a #GSpawnChildSetupFunc
/// under those conditions.
/// See &amp;lt;see href=&quot;man:signal(7&quot;&amp;gt;signal(7)&amp;lt;/see&amp;gt;) and
/// &amp;lt;see href=&quot;man:signal-safety(7&quot;&amp;gt;signal-safety(7)&amp;lt;/see&amp;gt;) for more details.
/// </para>
/// </summary>

/// <param name="fd">
/// A file descriptor
/// </param>
/// <return>
/// %TRUE on success, %FALSE if there was an error.
/// </return>

	public static bool Close(int fd)
	{
		var externCallResult = GLibGlobalFunctionsExterns.g_close(fd, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Close every file descriptor equal to or greater than @lowfd.
/// </para>
/// <para>
/// Typically @lowfd will be 3, to leave standard input, standard output
/// and standard error open.
/// </para>
/// <para>
/// This is the same as Linux `close_range (lowfd, ~0U, 0)`,
/// but portable to other OSs and to older versions of Linux.
/// Equivalently, it is the same as BSD `closefrom (lowfd)`, but portable,
/// and async-signal-safe on all OSs.
/// </para>
/// <para>
/// This function is async-signal safe, making it safe to call from a
/// signal handler or a [callback@GLib.SpawnChildSetupFunc], as long as @lowfd is
/// non-negative.
/// See &amp;lt;see href=&quot;man:signal(7&quot;&amp;gt;signal(7)&amp;lt;/see&amp;gt;) and
/// &amp;lt;see href=&quot;man:signal-safety(7&quot;&amp;gt;signal-safety(7)&amp;lt;/see&amp;gt;) for more details.
/// </para>
/// </summary>

/// <param name="lowfd">
/// Minimum fd to close, which must be non-negative
/// </param>
/// <return>
/// 0 on success, -1 with errno set on error
/// </return>

	public static int Closefrom(int lowfd)
	{
		return GLibGlobalFunctionsExterns.g_closefrom(lowfd);
	}

/// <summary>
/// <para>
/// Computes the checksum for a binary @data. This is a
/// convenience wrapper for g_checksum_new(), g_checksum_get_string()
/// and g_checksum_free().
/// </para>
/// <para>
/// The hexadecimal string returned will be in lower case.
/// </para>
/// </summary>

/// <param name="checksum_type">
/// a #GChecksumType
/// </param>
/// <param name="data">
/// binary blob to compute the digest of
/// </param>
/// <return>
/// the digest of the binary data as a
///   string in hexadecimal, or %NULL if g_checksum_new() fails for
///   @checksum_type. The returned string should be freed with g_free() when
///   done using it.
/// </return>

	public static string ComputeChecksumForBytes(MentorLake.GLib.GChecksumType checksum_type, MentorLake.GLib.GBytesHandle data)
	{
		return GLibGlobalFunctionsExterns.g_compute_checksum_for_bytes(checksum_type, data);
	}

/// <summary>
/// <para>
/// Computes the checksum for a binary @data of @length. This is a
/// convenience wrapper for g_checksum_new(), g_checksum_get_string()
/// and g_checksum_free().
/// </para>
/// <para>
/// The hexadecimal string returned will be in lower case.
/// </para>
/// </summary>

/// <param name="checksum_type">
/// a #GChecksumType
/// </param>
/// <param name="data">
/// binary blob to compute the digest of
/// </param>
/// <param name="length">
/// length of @data
/// </param>
/// <return>
/// the digest of the binary data as a
///   string in hexadecimal, or %NULL if g_checksum_new() fails for
///   @checksum_type. The returned string should be freed with g_free() when
///   done using it.
/// </return>

	public static string ComputeChecksumForData(MentorLake.GLib.GChecksumType checksum_type, byte[] data, UIntPtr length)
	{
		return GLibGlobalFunctionsExterns.g_compute_checksum_for_data(checksum_type, data, length);
	}

/// <summary>
/// <para>
/// Computes the checksum of a string.
/// </para>
/// <para>
/// The hexadecimal string returned will be in lower case.
/// </para>
/// </summary>

/// <param name="checksum_type">
/// a #GChecksumType
/// </param>
/// <param name="str">
/// the string to compute the checksum of
/// </param>
/// <param name="length">
/// the length of the string, or -1 if the string is null-terminated.
/// </param>
/// <return>
/// the checksum as a hexadecimal string,
///   or %NULL if g_checksum_new() fails for @checksum_type. The returned string
///   should be freed with g_free() when done using it.
/// </return>

	public static string ComputeChecksumForString(MentorLake.GLib.GChecksumType checksum_type, string str, UIntPtr length)
	{
		return GLibGlobalFunctionsExterns.g_compute_checksum_for_string(checksum_type, str, length);
	}

/// <summary>
/// <para>
/// Computes the HMAC for a binary @data. This is a
/// convenience wrapper for g_hmac_new(), g_hmac_get_string()
/// and g_hmac_unref().
/// </para>
/// <para>
/// The hexadecimal string returned will be in lower case.
/// </para>
/// </summary>

/// <param name="digest_type">
/// a #GChecksumType to use for the HMAC
/// </param>
/// <param name="key">
/// the key to use in the HMAC
/// </param>
/// <param name="data">
/// binary blob to compute the HMAC of
/// </param>
/// <return>
/// the HMAC of the binary data as a string in hexadecimal.
///   The returned string should be freed with g_free() when done using it.
/// </return>

	public static string ComputeHmacForBytes(MentorLake.GLib.GChecksumType digest_type, MentorLake.GLib.GBytesHandle key, MentorLake.GLib.GBytesHandle data)
	{
		return GLibGlobalFunctionsExterns.g_compute_hmac_for_bytes(digest_type, key, data);
	}

/// <summary>
/// <para>
/// Computes the HMAC for a binary @data of @length. This is a
/// convenience wrapper for g_hmac_new(), g_hmac_get_string()
/// and g_hmac_unref().
/// </para>
/// <para>
/// The hexadecimal string returned will be in lower case.
/// </para>
/// </summary>

/// <param name="digest_type">
/// a #GChecksumType to use for the HMAC
/// </param>
/// <param name="key">
/// the key to use in the HMAC
/// </param>
/// <param name="key_len">
/// the length of the key
/// </param>
/// <param name="data">
/// binary blob to compute the HMAC of
/// </param>
/// <param name="length">
/// length of @data
/// </param>
/// <return>
/// the HMAC of the binary data as a string in hexadecimal.
///   The returned string should be freed with g_free() when done using it.
/// </return>

	public static string ComputeHmacForData(MentorLake.GLib.GChecksumType digest_type, byte[] key, UIntPtr key_len, byte[] data, UIntPtr length)
	{
		return GLibGlobalFunctionsExterns.g_compute_hmac_for_data(digest_type, key, key_len, data, length);
	}

/// <summary>
/// <para>
/// Computes the HMAC for a string.
/// </para>
/// <para>
/// The hexadecimal string returned will be in lower case.
/// </para>
/// </summary>

/// <param name="digest_type">
/// a #GChecksumType to use for the HMAC
/// </param>
/// <param name="key">
/// the key to use in the HMAC
/// </param>
/// <param name="key_len">
/// the length of the key
/// </param>
/// <param name="str">
/// the string to compute the HMAC for
/// </param>
/// <param name="length">
/// the length of the string, or -1 if the string is nul-terminated
/// </param>
/// <return>
/// the HMAC as a hexadecimal string.
///     The returned string should be freed with g_free()
///     when done using it.
/// </return>

	public static string ComputeHmacForString(MentorLake.GLib.GChecksumType digest_type, byte[] key, UIntPtr key_len, string str, UIntPtr length)
	{
		return GLibGlobalFunctionsExterns.g_compute_hmac_for_string(digest_type, key, key_len, str, length);
	}

/// <summary>
/// <para>
/// Allocates and initializes a new #GCond.
/// </para>
/// </summary>

/// <return>
/// a newly allocated #GCond. Free with g_cond_free()
/// </return>

	public static MentorLake.GLib.GCondHandle CondNew()
	{
		return GLibGlobalFunctionsExterns.g_cond_new();
	}

/// <summary>
/// <para>
/// Converts a string from one character set to another.
/// </para>
/// <para>
/// Note that you should use g_iconv() for streaming conversions.
/// Despite the fact that @bytes_read can return information about partial
/// characters, the g_convert_... functions are not generally suitable
/// for streaming. If the underlying converter maintains internal state,
/// then this won&apos;t be preserved across successive calls to g_convert(),
/// g_convert_with_iconv() or g_convert_with_fallback(). (An example of
/// this is the GNU C converter for CP1255 which does not emit a base
/// character until it knows that the next character is not a mark that
/// could combine with the base character.)
/// </para>
/// <para>
/// Using extensions such as &quot;//TRANSLIT&quot; may not work (or may not work
/// well) on many platforms.  Consider using g_str_to_ascii() instead.
/// </para>
/// </summary>

/// <param name="str">
/// 
///                 the string to convert.
/// </param>
/// <param name="len">
/// the length of the string in bytes, or -1 if the string is
///                 nul-terminated (Note that some encodings may allow nul
///                 bytes to occur inside strings. In that case, using -1
///                 for the @len parameter is unsafe)
/// </param>
/// <param name="to_codeset">
/// name of character set into which to convert @str
/// </param>
/// <param name="from_codeset">
/// character set of @str.
/// </param>
/// <param name="bytes_read">
/// location to store the number of bytes in
///                 the input string that were successfully converted, or %NULL.
///                 Even if the conversion was successful, this may be
///                 less than @len if there were partial characters
///                 at the end of the input. If the error
///                 %G_CONVERT_ERROR_ILLEGAL_SEQUENCE occurs, the value
///                 stored will be the byte offset after the last valid
///                 input sequence.
/// </param>
/// <param name="bytes_written">
/// the number of bytes stored in
///                 the output buffer (not including the terminating nul).
/// </param>
/// <return>
/// 
///          If the conversion was successful, a newly allocated buffer
///          containing the converted string, which must be freed with g_free().
///          Otherwise %NULL and @error will be set.
/// </return>

	public static byte[] Convert(byte[] str, UIntPtr len, string to_codeset, string from_codeset, out UIntPtr bytes_read, out UIntPtr bytes_written)
	{
		var externCallResult = GLibGlobalFunctionsExterns.g_convert(str, len, to_codeset, from_codeset, out bytes_read, out bytes_written, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}



	public static MentorLake.GLib.GQuark ConvertErrorQuark()
	{
		return GLibGlobalFunctionsExterns.g_convert_error_quark();
	}

/// <summary>
/// <para>
/// Converts a string from one character set to another, possibly
/// including fallback sequences for characters not representable
/// in the output. Note that it is not guaranteed that the specification
/// for the fallback sequences in @fallback will be honored. Some
/// systems may do an approximate conversion from @from_codeset
/// to @to_codeset in their iconv() functions,
/// in which case GLib will simply return that approximate conversion.
/// </para>
/// <para>
/// Note that you should use g_iconv() for streaming conversions.
/// Despite the fact that @bytes_read can return information about partial
/// characters, the g_convert_... functions are not generally suitable
/// for streaming. If the underlying converter maintains internal state,
/// then this won&apos;t be preserved across successive calls to g_convert(),
/// g_convert_with_iconv() or g_convert_with_fallback(). (An example of
/// this is the GNU C converter for CP1255 which does not emit a base
/// character until it knows that the next character is not a mark that
/// could combine with the base character.)
/// </para>
/// </summary>

/// <param name="str">
/// 
///                the string to convert.
/// </param>
/// <param name="len">
/// the length of the string in bytes, or -1 if the string is
///                 nul-terminated (Note that some encodings may allow nul
///                 bytes to occur inside strings. In that case, using -1
///                 for the @len parameter is unsafe)
/// </param>
/// <param name="to_codeset">
/// name of character set into which to convert @str
/// </param>
/// <param name="from_codeset">
/// character set of @str.
/// </param>
/// <param name="fallback">
/// UTF-8 string to use in place of characters not
///                present in the target encoding. (The string must be
///                representable in the target encoding).
///                If %NULL, characters not in the target encoding will
///                be represented as Unicode escapes \uxxxx or \Uxxxxyyyy.
/// </param>
/// <param name="bytes_read">
/// location to store the number of bytes in
///                the input string that were successfully converted, or %NULL.
///                Even if the conversion was successful, this may be
///                less than @len if there were partial characters
///                at the end of the input.
/// </param>
/// <param name="bytes_written">
/// the number of bytes stored in
///                 the output buffer (not including the terminating nul).
/// </param>
/// <return>
/// 
///          If the conversion was successful, a newly allocated buffer
///          containing the converted string, which must be freed with g_free().
///          Otherwise %NULL and @error will be set.
/// </return>

	public static byte[] ConvertWithFallback(byte[] str, UIntPtr len, string to_codeset, string from_codeset, string fallback, out UIntPtr bytes_read, out UIntPtr bytes_written)
	{
		var externCallResult = GLibGlobalFunctionsExterns.g_convert_with_fallback(str, len, to_codeset, from_codeset, fallback, out bytes_read, out bytes_written, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Converts a string from one character set to another.
/// </para>
/// <para>
/// Note that you should use g_iconv() for streaming conversions.
/// Despite the fact that @bytes_read can return information about partial
/// characters, the g_convert_... functions are not generally suitable
/// for streaming. If the underlying converter maintains internal state,
/// then this won&apos;t be preserved across successive calls to g_convert(),
/// g_convert_with_iconv() or g_convert_with_fallback(). (An example of
/// this is the GNU C converter for CP1255 which does not emit a base
/// character until it knows that the next character is not a mark that
/// could combine with the base character.)
/// </para>
/// <para>
/// Characters which are valid in the input character set, but which have no
/// representation in the output character set will result in a
/// %G_CONVERT_ERROR_ILLEGAL_SEQUENCE error. This is in contrast to the iconv()
/// specification, which leaves this behaviour implementation defined. Note that
/// this is the same error code as is returned for an invalid byte sequence in
/// the input character set. To get defined behaviour for conversion of
/// unrepresentable characters, use g_convert_with_fallback().
/// </para>
/// </summary>

/// <param name="str">
/// 
///                 the string to convert.
/// </param>
/// <param name="len">
/// the length of the string in bytes, or -1 if the string is
///                 nul-terminated (Note that some encodings may allow nul
///                 bytes to occur inside strings. In that case, using -1
///                 for the @len parameter is unsafe)
/// </param>
/// <param name="converter">
/// conversion descriptor from g_iconv_open()
/// </param>
/// <param name="bytes_read">
/// location to store the number of bytes in
///                 the input string that were successfully converted, or %NULL.
///                 Even if the conversion was successful, this may be
///                 less than @len if there were partial characters
///                 at the end of the input. If the error
///                 %G_CONVERT_ERROR_ILLEGAL_SEQUENCE occurs, the value
///                 stored will be the byte offset after the last valid
///                 input sequence.
/// </param>
/// <param name="bytes_written">
/// the number of bytes stored in
///                 the output buffer (not including the terminating nul).
/// </param>
/// <return>
/// 
///               If the conversion was successful, a newly allocated buffer
///               containing the converted string, which must be freed with
///               g_free(). Otherwise %NULL and @error will be set.
/// </return>

	public static byte[] ConvertWithIconv(byte[] str, UIntPtr len, MentorLake.GLib.GIConv converter, out UIntPtr bytes_read, out UIntPtr bytes_written)
	{
		var externCallResult = GLibGlobalFunctionsExterns.g_convert_with_iconv(str, len, converter, out bytes_read, out bytes_written, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// A wrapper for the POSIX creat() function. The creat() function is
/// used to convert a pathname into a file descriptor, creating a file
/// if necessary.
/// </para>
/// <para>
/// On POSIX systems file descriptors are implemented by the operating
/// system. On Windows, it&apos;s the C library that implements creat() and
/// file descriptors. The actual Windows API for opening files is
/// different, see MSDN documentation for CreateFile(). The Win32 API
/// uses file handles, which are more randomish integers, not small
/// integers like file descriptors.
/// </para>
/// <para>
/// Because file descriptors are specific to the C library on Windows,
/// the file descriptor returned by this function makes sense only to
/// functions in the same C library. Thus if the GLib-using code uses a
/// different C library than GLib does, the file descriptor returned by
/// this function cannot be passed to C library functions like write()
/// or read().
/// </para>
/// <para>
/// See your C library manual for more details about creat().
/// </para>
/// </summary>

/// <param name="filename">
/// a pathname in the GLib file name encoding
///     (UTF-8 on Windows)
/// </param>
/// <param name="mode">
/// as in creat()
/// </param>
/// <return>
/// a new file descriptor, or -1 if an error occurred.
///     The return value can be used exactly like the return value
///     from creat().
/// </return>

	public static int Creat(string filename, int mode)
	{
		return GLibGlobalFunctionsExterns.g_creat(filename, mode);
	}

/// <summary>
/// <para>
/// Frees all the data elements of the datalist.
/// The data elements&apos; destroy functions are called
/// if they have been set.
/// </para>
/// </summary>

/// <param name="datalist">
/// a datalist.
/// </param>

	public static void DatalistClear(IntPtr datalist)
	{
		GLibGlobalFunctionsExterns.g_datalist_clear(datalist);
	}

/// <summary>
/// <para>
/// Calls the given function for each data element of the datalist. The
/// function is called with each data element&apos;s #GQuark id and data,
/// together with the given @user_data parameter. Note that this
/// function is NOT thread-safe. So unless @datalist can be protected
/// from any modifications during invocation of this function, it should
/// not be called.
/// </para>
/// <para>
/// @func can make changes to @datalist, but the iteration will not
/// reflect changes made during the g_datalist_foreach() call, other
/// than skipping over elements that are removed.
/// </para>
/// </summary>

/// <param name="datalist">
/// a datalist.
/// </param>
/// <param name="func">
/// the function to call for each data element.
/// </param>
/// <param name="user_data">
/// user data to pass to the function.
/// </param>

	public static void DatalistForeach(IntPtr datalist, MentorLake.GLib.GDataForeachFunc func, IntPtr user_data)
	{
		GLibGlobalFunctionsExterns.g_datalist_foreach(datalist, func, user_data);
	}

/// <summary>
/// <para>
/// Gets a data element, using its string identifier. This is slower than
/// g_datalist_id_get_data() because it compares strings.
/// </para>
/// </summary>

/// <param name="datalist">
/// a datalist.
/// </param>
/// <param name="key">
/// the string identifying a data element.
/// </param>
/// <return>
/// the data element, or %NULL if it
///          is not found.
/// </return>

	public static IntPtr DatalistGetData(IntPtr datalist, string key)
	{
		return GLibGlobalFunctionsExterns.g_datalist_get_data(datalist, key);
	}

/// <summary>
/// <para>
/// Gets flags values packed in together with the datalist.
/// See g_datalist_set_flags().
/// </para>
/// </summary>

/// <param name="datalist">
/// pointer to the location that holds a list
/// </param>
/// <return>
/// the flags of the datalist
/// </return>

	public static uint DatalistGetFlags(IntPtr datalist)
	{
		return GLibGlobalFunctionsExterns.g_datalist_get_flags(datalist);
	}

/// <summary>
/// <para>
/// This is a variant of g_datalist_id_get_data() which
/// returns a &apos;duplicate&apos; of the value. @dup_func defines the
/// meaning of &apos;duplicate&apos; in this context, it could e.g.
/// take a reference on a ref-counted object.
/// </para>
/// <para>
/// If the @key_id is not set in the datalist then @dup_func
/// will be called with a %NULL argument.
/// </para>
/// <para>
/// Note that @dup_func is called while the datalist is locked, so it
/// is not allowed to read or modify the datalist.
/// </para>
/// <para>
/// This function can be useful to avoid races when multiple
/// threads are using the same datalist and the same key.
/// </para>
/// </summary>

/// <param name="datalist">
/// location of a datalist
/// </param>
/// <param name="key_id">
/// the #GQuark identifying a data element
/// </param>
/// <param name="dup_func">
/// function to
///   duplicate the old value
/// </param>
/// <param name="user_data">
/// passed as user_data to @dup_func
/// </param>
/// <return>
/// the result of calling @dup_func on the value
///     associated with @key_id in @datalist, or %NULL if not set.
///     If @dup_func is %NULL, the value is returned unmodified.
/// </return>

	public static IntPtr DatalistIdDupData(IntPtr datalist, MentorLake.GLib.GQuark key_id, MentorLake.GLib.GDuplicateFunc dup_func, IntPtr user_data)
	{
		return GLibGlobalFunctionsExterns.g_datalist_id_dup_data(datalist, key_id, dup_func, user_data);
	}

/// <summary>
/// <para>
/// Retrieves the data element corresponding to @key_id.
/// </para>
/// </summary>

/// <param name="datalist">
/// a datalist.
/// </param>
/// <param name="key_id">
/// the #GQuark identifying a data element.
/// </param>
/// <return>
/// the data element, or %NULL if
///          it is not found.
/// </return>

	public static IntPtr DatalistIdGetData(IntPtr datalist, MentorLake.GLib.GQuark key_id)
	{
		return GLibGlobalFunctionsExterns.g_datalist_id_get_data(datalist, key_id);
	}

/// <summary>
/// <para>
/// Removes multiple keys from a datalist.
/// </para>
/// <para>
/// This is more efficient than calling g_datalist_id_remove_data()
/// multiple times in a row.
/// </para>
/// <para>
/// Before 2.80, @n_keys had to be not larger than 16.
/// Since 2.84, performance is improved for larger number of keys.
/// </para>
/// </summary>

/// <param name="datalist">
/// a datalist
/// </param>
/// <param name="keys">
/// keys to remove
/// </param>
/// <param name="n_keys">
/// length of @keys.
/// </param>

	public static void DatalistIdRemoveMultiple(IntPtr datalist, MentorLake.GLib.GQuark[] keys, UIntPtr n_keys)
	{
		GLibGlobalFunctionsExterns.g_datalist_id_remove_multiple(datalist, keys, n_keys);
	}

/// <summary>
/// <para>
/// Removes an element, without calling its destroy notification
/// function.
/// </para>
/// </summary>

/// <param name="datalist">
/// a datalist.
/// </param>
/// <param name="key_id">
/// the #GQuark identifying a data element.
/// </param>
/// <return>
/// the data previously stored at @key_id,
///          or %NULL if none.
/// </return>

	public static IntPtr DatalistIdRemoveNoNotify(IntPtr datalist, MentorLake.GLib.GQuark key_id)
	{
		return GLibGlobalFunctionsExterns.g_datalist_id_remove_no_notify(datalist, key_id);
	}

/// <summary>
/// <para>
/// Compares the member that is associated with @key_id in
/// @datalist to @oldval, and if they are the same, replace
/// @oldval with @newval.
/// </para>
/// <para>
/// This is like a typical atomic compare-and-exchange
/// operation, for a member of @datalist.
/// </para>
/// <para>
/// If the previous value was replaced then ownership of the
/// old value (@oldval) is passed to the caller, including
/// the registered destroy notify for it (passed out in @old_destroy).
/// Its up to the caller to free this as they wish, which may
/// or may not include using @old_destroy as sometimes replacement
/// should not destroy the object in the normal way.
/// </para>
/// </summary>

/// <param name="datalist">
/// location of a datalist
/// </param>
/// <param name="key_id">
/// the #GQuark identifying a data element
/// </param>
/// <param name="oldval">
/// the old value to compare against
/// </param>
/// <param name="newval">
/// the new value to replace it with
/// </param>
/// <param name="destroy">
/// destroy notify for the new value
/// </param>
/// <param name="old_destroy">
/// destroy notify for the existing value
/// </param>
/// <return>
/// %TRUE if the existing value for @key_id was replaced
///  by @newval, %FALSE otherwise.
/// </return>

	public static bool DatalistIdReplaceData(IntPtr datalist, MentorLake.GLib.GQuark key_id, IntPtr oldval, IntPtr newval, MentorLake.GLib.GDestroyNotify destroy, out MentorLake.GLib.GDestroyNotify old_destroy)
	{
		return GLibGlobalFunctionsExterns.g_datalist_id_replace_data(datalist, key_id, oldval, newval, destroy, out old_destroy);
	}

/// <summary>
/// <para>
/// Sets the data corresponding to the given #GQuark id, and the
/// function to be called when the element is removed from the datalist.
/// Any previous data with the same key is removed, and its destroy
/// function is called.
/// </para>
/// </summary>

/// <param name="datalist">
/// a datalist.
/// </param>
/// <param name="key_id">
/// the #GQuark to identify the data element.
/// </param>
/// <param name="data">
/// the data element or %NULL to remove any previous element
///        corresponding to @key_id.
/// </param>
/// <param name="destroy_func">
/// the function to call when the data element is
///                removed. This function will be called with the data
///                element and can be used to free any memory allocated
///                for it. If @data is %NULL, then @destroy_func must
///                also be %NULL.
/// </param>

	public static void DatalistIdSetDataFull(IntPtr datalist, MentorLake.GLib.GQuark key_id, IntPtr data, MentorLake.GLib.GDestroyNotify destroy_func)
	{
		GLibGlobalFunctionsExterns.g_datalist_id_set_data_full(datalist, key_id, data, destroy_func);
	}

/// <summary>
/// <para>
/// Resets the datalist to %NULL. It does not free any memory or call
/// any destroy functions.
/// </para>
/// </summary>

/// <param name="datalist">
/// a pointer to a pointer to a datalist.
/// </param>

	public static void DatalistInit(IntPtr datalist)
	{
		GLibGlobalFunctionsExterns.g_datalist_init(datalist);
	}

/// <summary>
/// <para>
/// Turns on flag values for a data list. This function is used
/// to keep a small number of boolean flags in an object with
/// a data list without using any additional space. It is
/// not generally useful except in circumstances where space
/// is very tight. (It is used in the base #GObject type, for
/// example.)
/// </para>
/// </summary>

/// <param name="datalist">
/// pointer to the location that holds a list
/// </param>
/// <param name="flags">
/// the flags to turn on. The values of the flags are
///   restricted by %G_DATALIST_FLAGS_MASK (currently
///   3; giving two possible boolean flags).
///   A value for @flags that doesn&apos;t fit within the mask is
///   an error.
/// </param>

	public static void DatalistSetFlags(IntPtr datalist, uint flags)
	{
		GLibGlobalFunctionsExterns.g_datalist_set_flags(datalist, flags);
	}

/// <summary>
/// <para>
/// Turns off flag values for a data list. See g_datalist_unset_flags()
/// </para>
/// </summary>

/// <param name="datalist">
/// pointer to the location that holds a list
/// </param>
/// <param name="flags">
/// the flags to turn off. The values of the flags are
///   restricted by %G_DATALIST_FLAGS_MASK (currently
///   3: giving two possible boolean flags).
///   A value for @flags that doesn&apos;t fit within the mask is
///   an error.
/// </param>

	public static void DatalistUnsetFlags(IntPtr datalist, uint flags)
	{
		GLibGlobalFunctionsExterns.g_datalist_unset_flags(datalist, flags);
	}

/// <summary>
/// <para>
/// Destroys the dataset, freeing all memory allocated, and calling any
/// destroy functions set for data elements.
/// </para>
/// </summary>

/// <param name="dataset_location">
/// the location identifying the dataset.
/// </param>

	public static void DatasetDestroy(IntPtr dataset_location)
	{
		GLibGlobalFunctionsExterns.g_dataset_destroy(dataset_location);
	}

/// <summary>
/// <para>
/// Calls the given function for each data element which is associated
/// with the given location. Note that this function is NOT thread-safe.
/// So unless @dataset_location can be protected from any modifications
/// during invocation of this function, it should not be called.
/// </para>
/// <para>
/// @func can make changes to the dataset, but the iteration will not
/// reflect changes made during the g_dataset_foreach() call, other
/// than skipping over elements that are removed.
/// </para>
/// </summary>

/// <param name="dataset_location">
/// the location identifying the dataset.
/// </param>
/// <param name="func">
/// the function to call for each data element.
/// </param>
/// <param name="user_data">
/// user data to pass to the function.
/// </param>

	public static void DatasetForeach(IntPtr dataset_location, MentorLake.GLib.GDataForeachFunc func, IntPtr user_data)
	{
		GLibGlobalFunctionsExterns.g_dataset_foreach(dataset_location, func, user_data);
	}

/// <summary>
/// <para>
/// Gets the data element corresponding to a #GQuark.
/// </para>
/// </summary>

/// <param name="dataset_location">
/// the location identifying the dataset.
/// </param>
/// <param name="key_id">
/// the #GQuark id to identify the data element.
/// </param>
/// <return>
/// the data element corresponding to
///          the #GQuark, or %NULL if it is not found.
/// </return>

	public static IntPtr DatasetIdGetData(IntPtr dataset_location, MentorLake.GLib.GQuark key_id)
	{
		return GLibGlobalFunctionsExterns.g_dataset_id_get_data(dataset_location, key_id);
	}

/// <summary>
/// <para>
/// Removes an element, without calling its destroy notification
/// function.
/// </para>
/// </summary>

/// <param name="dataset_location">
/// the location identifying the dataset.
/// </param>
/// <param name="key_id">
/// the #GQuark ID identifying the data element.
/// </param>
/// <return>
/// the data previously stored at @key_id,
///          or %NULL if none.
/// </return>

	public static IntPtr DatasetIdRemoveNoNotify(IntPtr dataset_location, MentorLake.GLib.GQuark key_id)
	{
		return GLibGlobalFunctionsExterns.g_dataset_id_remove_no_notify(dataset_location, key_id);
	}

/// <summary>
/// <para>
/// Sets the data element associated with the given #GQuark id, and also
/// the function to call when the data element is destroyed. Any
/// previous data with the same key is removed, and its destroy function
/// is called.
/// </para>
/// </summary>

/// <param name="dataset_location">
/// the location identifying the dataset.
/// </param>
/// <param name="key_id">
/// the #GQuark id to identify the data element.
/// </param>
/// <param name="data">
/// the data element.
/// </param>
/// <param name="destroy_func">
/// the function to call when the data element is
///                removed. This function will be called with the data
///                element and can be used to free any memory allocated
///                for it.
/// </param>

	public static void DatasetIdSetDataFull(IntPtr dataset_location, MentorLake.GLib.GQuark key_id, IntPtr data, MentorLake.GLib.GDestroyNotify destroy_func)
	{
		GLibGlobalFunctionsExterns.g_dataset_id_set_data_full(dataset_location, key_id, data, destroy_func);
	}

/// <summary>
/// <para>
/// Returns the number of days in a month, taking leap
/// years into account.
/// </para>
/// </summary>

/// <param name="month">
/// month
/// </param>
/// <param name="year">
/// year
/// </param>
/// <return>
/// number of days in @month during the @year
/// </return>

	public static byte DateGetDaysInMonth(MentorLake.GLib.GDateMonth month, MentorLake.GLib.GDateYear year)
	{
		return GLibGlobalFunctionsExterns.g_date_get_days_in_month(month, year);
	}

/// <summary>
/// <para>
/// Returns the number of weeks in the year, where weeks
/// are taken to start on Monday. Will be 52 or 53. The
/// date must be valid. (Years always have 52 7-day periods,
/// plus 1 or 2 extra days depending on whether it&apos;s a leap
/// year. This function is basically telling you how many
/// Mondays are in the year, i.e. there are 53 Mondays if
/// one of the extra days happens to be a Monday.)
/// </para>
/// </summary>

/// <param name="year">
/// a year
/// </param>
/// <return>
/// number of Mondays in the year
/// </return>

	public static byte DateGetMondayWeeksInYear(MentorLake.GLib.GDateYear year)
	{
		return GLibGlobalFunctionsExterns.g_date_get_monday_weeks_in_year(year);
	}

/// <summary>
/// <para>
/// Returns the number of weeks in the year, where weeks
/// are taken to start on Sunday. Will be 52 or 53. The
/// date must be valid. (Years always have 52 7-day periods,
/// plus 1 or 2 extra days depending on whether it&apos;s a leap
/// year. This function is basically telling you how many
/// Sundays are in the year, i.e. there are 53 Sundays if
/// one of the extra days happens to be a Sunday.)
/// </para>
/// </summary>

/// <param name="year">
/// year to count weeks in
/// </param>
/// <return>
/// the number of weeks in @year
/// </return>

	public static byte DateGetSundayWeeksInYear(MentorLake.GLib.GDateYear year)
	{
		return GLibGlobalFunctionsExterns.g_date_get_sunday_weeks_in_year(year);
	}

/// <summary>
/// <para>
/// Returns %TRUE if the year is a leap year.
/// </para>
/// <para>
/// For the purposes of this function, leap year is every year
/// divisible by 4 unless that year is divisible by 100. If it
/// is divisible by 100 it would be a leap year only if that year
/// is also divisible by 400.
/// </para>
/// </summary>

/// <param name="year">
/// year to check
/// </param>
/// <return>
/// %TRUE if the year is a leap year
/// </return>

	public static bool DateIsLeapYear(MentorLake.GLib.GDateYear year)
	{
		return GLibGlobalFunctionsExterns.g_date_is_leap_year(year);
	}

/// <summary>
/// <para>
/// Generates a printed representation of the date, in a
/// [locale][setlocale]-specific way.
/// Works just like the platform&apos;s C library strftime() function,
/// but only accepts date-related formats; time-related formats
/// give undefined results. Date must be valid. Unlike strftime()
/// (which uses the locale encoding), works on a UTF-8 format
/// string and stores a UTF-8 result.
/// </para>
/// <para>
/// This function does not provide any conversion specifiers in
/// addition to those implemented by the platform&apos;s C library.
/// For example, don&apos;t expect that using g_date_strftime() would
/// make the \%F provided by the C99 strftime() work on Windows
/// where the C library only complies to C89.
/// </para>
/// </summary>

/// <param name="s">
/// destination buffer
/// </param>
/// <param name="slen">
/// buffer size
/// </param>
/// <param name="format">
/// format string
/// </param>
/// <param name="date">
/// valid #GDate
/// </param>
/// <return>
/// number of characters written to the buffer, or `0` if the buffer was too small
/// </return>

	public static UIntPtr DateStrftime(string s, UIntPtr slen, string format, MentorLake.GLib.GDateHandle date)
	{
		return GLibGlobalFunctionsExterns.g_date_strftime(s, slen, format, date);
	}

/// <summary>
/// <para>
/// Returns %TRUE if the day of the month is valid (a day is valid if it&apos;s
/// between 1 and 31 inclusive).
/// </para>
/// </summary>

/// <param name="day">
/// day to check
/// </param>
/// <return>
/// %TRUE if the day is valid
/// </return>

	public static bool DateValidDay(MentorLake.GLib.GDateDay day)
	{
		return GLibGlobalFunctionsExterns.g_date_valid_day(day);
	}

/// <summary>
/// <para>
/// Returns %TRUE if the day-month-year triplet forms a valid, existing day
/// in the range of days #GDate understands (Year 1 or later, no more than
/// a few thousand years in the future).
/// </para>
/// </summary>

/// <param name="day">
/// day
/// </param>
/// <param name="month">
/// month
/// </param>
/// <param name="year">
/// year
/// </param>
/// <return>
/// %TRUE if the date is a valid one
/// </return>

	public static bool DateValidDmy(MentorLake.GLib.GDateDay day, MentorLake.GLib.GDateMonth month, MentorLake.GLib.GDateYear year)
	{
		return GLibGlobalFunctionsExterns.g_date_valid_dmy(day, month, year);
	}

/// <summary>
/// <para>
/// Returns %TRUE if the Julian day is valid. Anything greater than zero
/// is basically a valid Julian, though there is a 32-bit limit.
/// </para>
/// </summary>

/// <param name="julian_date">
/// Julian day to check
/// </param>
/// <return>
/// %TRUE if the Julian day is valid
/// </return>

	public static bool DateValidJulian(uint julian_date)
	{
		return GLibGlobalFunctionsExterns.g_date_valid_julian(julian_date);
	}

/// <summary>
/// <para>
/// Returns %TRUE if the month value is valid. The 12 #GDateMonth
/// enumeration values are the only valid months.
/// </para>
/// </summary>

/// <param name="month">
/// month
/// </param>
/// <return>
/// %TRUE if the month is valid
/// </return>

	public static bool DateValidMonth(MentorLake.GLib.GDateMonth month)
	{
		return GLibGlobalFunctionsExterns.g_date_valid_month(month);
	}

/// <summary>
/// <para>
/// Returns %TRUE if the weekday is valid. The seven #GDateWeekday enumeration
/// values are the only valid weekdays.
/// </para>
/// </summary>

/// <param name="weekday">
/// weekday
/// </param>
/// <return>
/// %TRUE if the weekday is valid
/// </return>

	public static bool DateValidWeekday(MentorLake.GLib.GDateWeekday weekday)
	{
		return GLibGlobalFunctionsExterns.g_date_valid_weekday(weekday);
	}

/// <summary>
/// <para>
/// Returns %TRUE if the year is valid. Any year greater than 0 is valid,
/// though there is a 16-bit limit to what #GDate will understand.
/// </para>
/// </summary>

/// <param name="year">
/// year
/// </param>
/// <return>
/// %TRUE if the year is valid
/// </return>

	public static bool DateValidYear(MentorLake.GLib.GDateYear year)
	{
		return GLibGlobalFunctionsExterns.g_date_valid_year(year);
	}

/// <summary>
/// <para>
/// This is a variant of g_dgettext() that allows specifying a locale
/// category instead of always using `LC_MESSAGES`. See g_dgettext() for
/// more information about how this functions differs from calling
/// dcgettext() directly.
/// </para>
/// </summary>

/// <param name="domain">
/// the translation domain to use, or %NULL to use
///   the domain set with textdomain()
/// </param>
/// <param name="msgid">
/// message to translate
/// </param>
/// <param name="category">
/// a locale category
/// </param>
/// <return>
/// the translated string for the given locale category
/// </return>

	public static string Dcgettext(string domain, string msgid, int category)
	{
		return GLibGlobalFunctionsExterns.g_dcgettext(domain, msgid, category);
	}

/// <summary>
/// <para>
/// This function is a wrapper of dgettext() which does not translate
/// the message if the default domain as set with textdomain() has no
/// translations for the current locale.
/// </para>
/// <para>
/// The advantage of using this function over dgettext() proper is that
/// libraries using this function (like GTK) will not use translations
/// if the application using the library does not have translations for
/// the current locale.  This results in a consistent English-only
/// interface instead of one having partial translations.  For this
/// feature to work, the call to textdomain() and setlocale() should
/// precede any g_dgettext() invocations.  For GTK, it means calling
/// textdomain() before gtk_init or its variants.
/// </para>
/// <para>
/// This function disables translations if and only if upon its first
/// call all the following conditions hold:
/// </para>
/// <para>
/// - @domain is not %NULL
/// </para>
/// <para>
/// - textdomain() has been called to set a default text domain
/// </para>
/// <para>
/// - there is no translations available for the default text domain
///   and the current locale
/// </para>
/// <para>
/// - current locale is not &quot;C&quot; or any English locales (those
///   starting with &quot;en_&quot;)
/// </para>
/// <para>
/// Note that this behavior may not be desired for example if an application
/// has its untranslated messages in a language other than English. In those
/// cases the application should call textdomain() after initializing GTK.
/// </para>
/// <para>
/// Applications should normally not use this function directly,
/// but use the _() macro for translations.
/// </para>
/// </summary>

/// <param name="domain">
/// the translation domain to use, or %NULL to use
///   the domain set with textdomain()
/// </param>
/// <param name="msgid">
/// message to translate
/// </param>
/// <return>
/// The translated string
/// </return>

	public static string Dgettext(string domain, string msgid)
	{
		return GLibGlobalFunctionsExterns.g_dgettext(domain, msgid);
	}

/// <summary>
/// <para>
/// Creates a subdirectory in the preferred directory for temporary
/// files (as returned by g_get_tmp_dir()).
/// </para>
/// <para>
/// @tmpl should be a string in the GLib file name encoding containing
/// a sequence of six &apos;X&apos; characters, as the parameter to g_mkstemp().
/// However, unlike these functions, the template should only be a
/// basename, no directory components are allowed. If template is
/// %NULL, a default template is used.
/// </para>
/// <para>
/// Note that in contrast to g_mkdtemp() (and mkdtemp()) @tmpl is not
/// modified, and might thus be a read-only literal string.
/// </para>
/// </summary>

/// <param name="tmpl">
/// Template for directory name,
///   as in g_mkdtemp(), basename only, or %NULL for a default template
/// </param>
/// <return>
/// The actual name used. This string
///   should be freed with g_free() when not needed any longer and is
///   is in the GLib file name encoding. In case of errors, %NULL is
///   returned and @error will be set.
/// </return>

	public static string DirMakeTmp(string tmpl)
	{
		var externCallResult = GLibGlobalFunctionsExterns.g_dir_make_tmp(tmpl, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Compares two #gpointer arguments and returns %TRUE if they are equal.
/// It can be passed to g_hash_table_new() as the @key_equal_func
/// parameter, when using opaque pointers compared by pointer value as
/// keys in a #GHashTable.
/// </para>
/// <para>
/// This equality function is also appropriate for keys that are integers
/// stored in pointers, such as `GINT_TO_POINTER (n)`.
/// </para>
/// </summary>

/// <param name="v1">
/// a key
/// </param>
/// <param name="v2">
/// a key to compare with @v1
/// </param>
/// <return>
/// %TRUE if the two keys match.
/// </return>

	public static bool DirectEqual(IntPtr v1, IntPtr v2)
	{
		return GLibGlobalFunctionsExterns.g_direct_equal(v1, v2);
	}

/// <summary>
/// <para>
/// Converts a gpointer to a hash value.
/// It can be passed to g_hash_table_new() as the @hash_func parameter,
/// when using opaque pointers compared by pointer value as keys in a
/// #GHashTable.
/// </para>
/// <para>
/// This hash function is also appropriate for keys that are integers
/// stored in pointers, such as `GINT_TO_POINTER (n)`.
/// </para>
/// </summary>

/// <param name="v">
/// a #gpointer key
/// </param>
/// <return>
/// a hash value corresponding to the key.
/// </return>

	public static uint DirectHash(IntPtr v)
	{
		return GLibGlobalFunctionsExterns.g_direct_hash(v);
	}

/// <summary>
/// <para>
/// This function is a wrapper of dngettext() which does not translate
/// the message if the default domain as set with textdomain() has no
/// translations for the current locale.
/// </para>
/// <para>
/// See g_dgettext() for details of how this differs from dngettext()
/// proper.
/// </para>
/// </summary>

/// <param name="domain">
/// the translation domain to use, or %NULL to use
///   the domain set with textdomain()
/// </param>
/// <param name="msgid">
/// message to translate
/// </param>
/// <param name="msgid_plural">
/// plural form of the message
/// </param>
/// <param name="n">
/// the quantity for which translation is needed
/// </param>
/// <return>
/// The translated string
/// </return>

	public static string Dngettext(string domain, string msgid, string msgid_plural, ulong n)
	{
		return GLibGlobalFunctionsExterns.g_dngettext(domain, msgid, msgid_plural, n);
	}

/// <summary>
/// <para>
/// Compares the two #gdouble values being pointed to and returns
/// %TRUE if they are equal.
/// It can be passed to g_hash_table_new() as the @key_equal_func
/// parameter, when using non-%NULL pointers to doubles as keys in a
/// #GHashTable.
/// </para>
/// </summary>

/// <param name="v1">
/// a pointer to a #gdouble key
/// </param>
/// <param name="v2">
/// a pointer to a #gdouble key to compare with @v1
/// </param>
/// <return>
/// %TRUE if the two keys match.
/// </return>

	public static bool DoubleEqual(IntPtr v1, IntPtr v2)
	{
		return GLibGlobalFunctionsExterns.g_double_equal(v1, v2);
	}

/// <summary>
/// <para>
/// Converts a pointer to a #gdouble to a hash value.
/// It can be passed to g_hash_table_new() as the @hash_func parameter,
/// It can be passed to g_hash_table_new() as the @hash_func parameter,
/// when using non-%NULL pointers to doubles as keys in a #GHashTable.
/// </para>
/// </summary>

/// <param name="v">
/// a pointer to a #gdouble key
/// </param>
/// <return>
/// a hash value corresponding to the key.
/// </return>

	public static uint DoubleHash(IntPtr v)
	{
		return GLibGlobalFunctionsExterns.g_double_hash(v);
	}

/// <summary>
/// <para>
/// This function is a variant of g_dgettext() which supports
/// a disambiguating message context. GNU gettext uses the
/// &apos;\004&apos; character to separate the message context and
/// message id in @msgctxtid.
/// If 0 is passed as @msgidoffset, this function will fall back to
/// trying to use the deprecated convention of using &quot;|&quot; as a separation
/// character.
/// </para>
/// <para>
/// This uses g_dgettext() internally. See that functions for differences
/// with dgettext() proper.
/// </para>
/// <para>
/// Applications should normally not use this function directly,
/// but use the C_() macro for translations with context.
/// </para>
/// </summary>

/// <param name="domain">
/// the translation domain to use, or %NULL to use
///   the domain set with textdomain()
/// </param>
/// <param name="msgctxtid">
/// a combined message context and message id, separated
///   by a \004 character
/// </param>
/// <param name="msgidoffset">
/// the offset of the message id in @msgctxid
/// </param>
/// <return>
/// The translated string
/// </return>

	public static string Dpgettext(string domain, string msgctxtid, UIntPtr msgidoffset)
	{
		return GLibGlobalFunctionsExterns.g_dpgettext(domain, msgctxtid, msgidoffset);
	}

/// <summary>
/// <para>
/// This function is a variant of g_dgettext() which supports
/// a disambiguating message context. GNU gettext uses the
/// &apos;\004&apos; character to separate the message context and
/// message id in @msgctxtid.
/// </para>
/// <para>
/// This uses g_dgettext() internally. See that functions for differences
/// with dgettext() proper.
/// </para>
/// <para>
/// This function differs from C_() in that it is not a macro and
/// thus you may use non-string-literals as context and msgid arguments.
/// </para>
/// </summary>

/// <param name="domain">
/// the translation domain to use, or %NULL to use
///   the domain set with textdomain()
/// </param>
/// <param name="context">
/// the message context
/// </param>
/// <param name="msgid">
/// the message
/// </param>
/// <return>
/// The translated string
/// </return>

	public static string Dpgettext2(string domain, string context, string msgid)
	{
		return GLibGlobalFunctionsExterns.g_dpgettext2(domain, context, msgid);
	}

/// <summary>
/// <para>
/// Returns the value of the environment variable @variable in the
/// provided list @envp.
/// </para>
/// </summary>

/// <param name="envp">
/// 
///     an environment list (eg, as returned from g_get_environ()), or %NULL
///     for an empty environment list
/// </param>
/// <param name="variable">
/// the environment variable to get
/// </param>
/// <return>
/// the value of the environment variable, or %NULL if
///     the environment variable is not set in @envp. The returned
///     string is owned by @envp, and will be freed if @variable is
///     set or unset again.
/// </return>

	public static string EnvironGetenv(string[] envp, string variable)
	{
		return GLibGlobalFunctionsExterns.g_environ_getenv(envp, variable);
	}

/// <summary>
/// <para>
/// Sets the environment variable @variable in the provided list
/// @envp to @value.
/// </para>
/// </summary>

/// <param name="envp">
/// 
///     an environment list that can be freed using g_strfreev() (e.g., as
///     returned from g_get_environ()), or %NULL for an empty
///     environment list
/// </param>
/// <param name="variable">
/// the environment variable to set, must not
///     contain &apos;=&apos;
/// </param>
/// <param name="value">
/// the value for to set the variable to
/// </param>
/// <param name="overwrite">
/// whether to change the variable if it already exists
/// </param>
/// <return>
/// 
///     the updated environment list. Free it using g_strfreev().
/// </return>

	public static string[] EnvironSetenv(string[] envp, string variable, string value, bool overwrite)
	{
		return GLibGlobalFunctionsExterns.g_environ_setenv(envp, variable, value, overwrite);
	}

/// <summary>
/// <para>
/// Removes the environment variable @variable from the provided
/// environment @envp.
/// </para>
/// </summary>

/// <param name="envp">
/// 
///     an environment list that can be freed using g_strfreev() (e.g., as
///     returned from g_get_environ()), or %NULL for an empty environment list
/// </param>
/// <param name="variable">
/// the environment variable to remove, must not
///     contain &apos;=&apos;
/// </param>
/// <return>
/// 
///     the updated environment list. Free it using g_strfreev().
/// </return>

	public static string[] EnvironUnsetenv(string[] envp, string variable)
	{
		return GLibGlobalFunctionsExterns.g_environ_unsetenv(envp, variable);
	}

/// <summary>
/// <para>
/// This function registers an extended #GError domain.
/// @error_type_name will be duplicated. Otherwise does the same as
/// g_error_domain_register_static().
/// </para>
/// </summary>

/// <param name="error_type_name">
/// string to create a #GQuark from
/// </param>
/// <param name="error_type_private_size">
/// size of the private error data in bytes
/// </param>
/// <param name="error_type_init">
/// function initializing fields of the private error data
/// </param>
/// <param name="error_type_copy">
/// function copying fields of the private error data
/// </param>
/// <param name="error_type_clear">
/// function freeing fields of the private error data
/// </param>
/// <return>
/// #GQuark representing the error domain
/// </return>

	public static MentorLake.GLib.GQuark ErrorDomainRegister(string error_type_name, UIntPtr error_type_private_size, MentorLake.GLib.GErrorInitFunc error_type_init, MentorLake.GLib.GErrorCopyFunc error_type_copy, MentorLake.GLib.GErrorClearFunc error_type_clear)
	{
		return GLibGlobalFunctionsExterns.g_error_domain_register(error_type_name, error_type_private_size, error_type_init, error_type_copy, error_type_clear);
	}

/// <summary>
/// <para>
/// This function registers an extended #GError domain.
/// </para>
/// <para>
/// @error_type_name should not be freed. @error_type_private_size must
/// be greater than 0.
/// </para>
/// <para>
/// @error_type_init receives an initialized #GError and should then initialize
/// the private data.
/// </para>
/// <para>
/// @error_type_copy is a function that receives both original and a copy
/// #GError and should copy the fields of the private error data. The standard
/// #GError fields are already handled.
/// </para>
/// <para>
/// @error_type_clear receives the pointer to the error, and it should free the
/// fields of the private error data. It should not free the struct itself though.
/// </para>
/// <para>
/// Normally, it is better to use G_DEFINE_EXTENDED_ERROR(), as it
/// already takes care of passing valid information to this function.
/// </para>
/// </summary>

/// <param name="error_type_name">
/// static string to create a #GQuark from
/// </param>
/// <param name="error_type_private_size">
/// size of the private error data in bytes
/// </param>
/// <param name="error_type_init">
/// function initializing fields of the private error data
/// </param>
/// <param name="error_type_copy">
/// function copying fields of the private error data
/// </param>
/// <param name="error_type_clear">
/// function freeing fields of the private error data
/// </param>
/// <return>
/// #GQuark representing the error domain
/// </return>

	public static MentorLake.GLib.GQuark ErrorDomainRegisterStatic(string error_type_name, UIntPtr error_type_private_size, MentorLake.GLib.GErrorInitFunc error_type_init, MentorLake.GLib.GErrorCopyFunc error_type_copy, MentorLake.GLib.GErrorClearFunc error_type_clear)
	{
		return GLibGlobalFunctionsExterns.g_error_domain_register_static(error_type_name, error_type_private_size, error_type_init, error_type_copy, error_type_clear);
	}

/// <summary>
/// <para>
/// Mark every file descriptor equal to or greater than @lowfd to be closed
/// at the next `execve()` or similar, as if via the `FD_CLOEXEC` flag.
/// </para>
/// <para>
/// Typically @lowfd will be 3, to leave standard input, standard output
/// and standard error open after exec.
/// </para>
/// <para>
/// This is the same as Linux `close_range (lowfd, ~0U, CLOSE_RANGE_CLOEXEC)`,
/// but portable to other OSs and to older versions of Linux.
/// </para>
/// <para>
/// This function is async-signal safe, making it safe to call from a
/// signal handler or a [callback@GLib.SpawnChildSetupFunc], as long as @lowfd is
/// non-negative.
/// See &amp;lt;see href=&quot;man:signal(7&quot;&amp;gt;signal(7)&amp;lt;/see&amp;gt;) and
/// &amp;lt;see href=&quot;man:signal-safety(7&quot;&amp;gt;signal-safety(7)&amp;lt;/see&amp;gt;) for more details.
/// </para>
/// </summary>

/// <param name="lowfd">
/// Minimum fd to act on, which must be non-negative
/// </param>
/// <return>
/// 0 on success, -1 with errno set on error
/// </return>

	public static int FdwalkSetCloexec(int lowfd)
	{
		return GLibGlobalFunctionsExterns.g_fdwalk_set_cloexec(lowfd);
	}

/// <summary>
/// <para>
/// Gets a #GFileError constant based on the passed-in @err_no.
/// </para>
/// <para>
/// For example, if you pass in `EEXIST` this function returns
/// %G_FILE_ERROR_EXIST. Unlike `errno` values, you can portably
/// assume that all #GFileError values will exist.
/// </para>
/// <para>
/// Normally a #GFileError value goes into a #GError returned
/// from a function that manipulates files. So you would use
/// g_file_error_from_errno() when constructing a #GError.
/// </para>
/// </summary>

/// <param name="err_no">
/// an &quot;errno&quot; value
/// </param>
/// <return>
/// #GFileError corresponding to the given @err_no
/// </return>

	public static MentorLake.GLib.GFileError FileErrorFromErrno(int err_no)
	{
		return GLibGlobalFunctionsExterns.g_file_error_from_errno(err_no);
	}



	public static MentorLake.GLib.GQuark FileErrorQuark()
	{
		return GLibGlobalFunctionsExterns.g_file_error_quark();
	}

/// <summary>
/// <para>
/// Reads an entire file into allocated memory, with good error
/// checking.
/// </para>
/// <para>
/// If the call was successful, it returns %TRUE and sets @contents to the file
/// contents and @length to the length of the file contents in bytes. The string
/// stored in @contents will be nul-terminated, so for text files you can pass
/// %NULL for the @length argument. If the call was not successful, it returns
/// %FALSE and sets @error. The error domain is %G_FILE_ERROR. Possible error
/// codes are those in the #GFileError enumeration. In the error case,
/// @contents is set to %NULL and @length is set to zero.
/// </para>
/// </summary>

/// <param name="filename">
/// name of a file to read contents from, in the GLib file name encoding
/// </param>
/// <param name="contents">
/// location to store an allocated string, use g_free() to free
///     the returned string
/// </param>
/// <param name="length">
/// location to store length in bytes of the contents, or %NULL
/// </param>
/// <return>
/// %TRUE on success, %FALSE if an error occurred
/// </return>

	public static bool FileGetContents(string filename, out byte[] contents, out UIntPtr length)
	{
		var externCallResult = GLibGlobalFunctionsExterns.g_file_get_contents(filename, out contents, out length, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Opens a file for writing in the preferred directory for temporary
/// files (as returned by g_get_tmp_dir()).
/// </para>
/// <para>
/// @tmpl should be a string in the GLib file name encoding containing
/// a sequence of six &apos;X&apos; characters, as the parameter to g_mkstemp().
/// However, unlike these functions, the template should only be a
/// basename, no directory components are allowed. If template is
/// %NULL, a default template is used.
/// </para>
/// <para>
/// Note that in contrast to g_mkstemp() (and mkstemp()) @tmpl is not
/// modified, and might thus be a read-only literal string.
/// </para>
/// <para>
/// Upon success, and if @name_used is non-%NULL, the actual name used
/// is returned in @name_used. This string should be freed with g_free()
/// when not needed any longer. The returned name is in the GLib file
/// name encoding.
/// </para>
/// </summary>

/// <param name="tmpl">
/// Template for file name, as in
///   g_mkstemp(), basename only, or %NULL for a default template
/// </param>
/// <param name="name_used">
/// location to store actual name used,
///   or %NULL
/// </param>
/// <return>
/// A file handle (as from open()) to the file opened for
///   reading and writing. The file is opened in binary mode on platforms
///   where there is a difference. The file handle should be closed with
///   close(). In case of errors, -1 is returned and @error will be set.
/// </return>

	public static int FileOpenTmp(string tmpl, out string name_used)
	{
		var externCallResult = GLibGlobalFunctionsExterns.g_file_open_tmp(tmpl, out name_used, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Reads the contents of the symbolic link @filename like the POSIX
/// `readlink()` function.
/// </para>
/// <para>
/// The returned string is in the encoding used for filenames. Use
/// g_filename_to_utf8() to convert it to UTF-8.
/// </para>
/// <para>
/// The returned string may also be a relative path. Use g_build_filename()
/// to convert it to an absolute path:
/// </para>
/// <code>
/// g_autoptr(GError) local_error = NULL;
/// g_autoptr(GError) local_error = NULL;
/// g_autofree gchar *link_target = g_file_read_link (&quot;/etc/localtime&quot;, &amp;local_error);
/// 
/// if (local_error != NULL)
///   g_error (&quot;Error reading link: %s&quot;, local_error-&amp;gt;message);
/// 
/// if (!g_path_is_absolute (link_target))
///   {
///     g_autofree gchar *absolute_link_target = g_build_filename (&quot;/etc&quot;, link_target, NULL);
///     g_free (link_target);
///     link_target = g_steal_pointer (&amp;absolute_link_target);
///   }
/// </code>
/// </summary>

/// <param name="filename">
/// the symbolic link
/// </param>
/// <return>
/// A newly-allocated string with
///   the contents of the symbolic link, or %NULL if an error occurred.
/// </return>

	public static string FileReadLink(string filename)
	{
		var externCallResult = GLibGlobalFunctionsExterns.g_file_read_link(filename, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Writes all of @contents to a file named @filename. This is a convenience
/// wrapper around calling g_file_set_contents_full() with `flags` set to
/// `G_FILE_SET_CONTENTS_CONSISTENT | G_FILE_SET_CONTENTS_ONLY_EXISTING` and
/// `mode` set to `0666`.
/// </para>
/// </summary>

/// <param name="filename">
/// name of a file to write @contents to, in the GLib file name
///   encoding
/// </param>
/// <param name="contents">
/// string to write to the file
/// </param>
/// <param name="length">
/// length of @contents, or -1 if @contents is a nul-terminated string
/// </param>
/// <return>
/// %TRUE on success, %FALSE if an error occurred
/// </return>

	public static bool FileSetContents(string filename, byte[] contents, UIntPtr length)
	{
		var externCallResult = GLibGlobalFunctionsExterns.g_file_set_contents(filename, contents, length, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Writes all of @contents to a file named @filename, with good error checking.
/// If a file called @filename already exists it will be overwritten.
/// </para>
/// <para>
/// @flags control the properties of the write operation: whether it’s atomic,
/// and what the tradeoff is between returning quickly or being resilient to
/// system crashes.
/// </para>
/// <para>
/// As this function performs file I/O, it is recommended to not call it anywhere
/// where blocking would cause problems, such as in the main loop of a graphical
/// application. In particular, if @flags has any value other than
/// %G_FILE_SET_CONTENTS_NONE then this function may call `fsync()`.
/// </para>
/// <para>
/// If %G_FILE_SET_CONTENTS_CONSISTENT is set in @flags, the operation is atomic
/// in the sense that it is first written to a temporary file which is then
/// renamed to the final name.
/// </para>
/// <para>
/// Notes:
/// </para>
/// <para>
/// - On UNIX, if @filename already exists hard links to @filename will break.
///   Also since the file is recreated, existing permissions, access control
///   lists, metadata etc. may be lost. If @filename is a symbolic link,
///   the link itself will be replaced, not the linked file.
/// </para>
/// <para>
/// - On UNIX, if @filename already exists and is non-empty, and if the system
///   supports it (via a journalling filesystem or equivalent), and if
///   %G_FILE_SET_CONTENTS_CONSISTENT is set in @flags, the `fsync()` call (or
///   equivalent) will be used to ensure atomic replacement: @filename
///   will contain either its old contents or @contents, even in the face of
///   system power loss, the disk being unsafely removed, etc.
/// </para>
/// <para>
/// - On UNIX, if @filename does not already exist or is empty, there is a
///   possibility that system power loss etc. after calling this function will
///   leave @filename empty or full of NUL bytes, depending on the underlying
///   filesystem, unless %G_FILE_SET_CONTENTS_DURABLE and
///   %G_FILE_SET_CONTENTS_CONSISTENT are set in @flags.
/// </para>
/// <para>
/// - On Windows renaming a file will not remove an existing file with the
///   new name, so on Windows there is a race condition between the existing
///   file being removed and the temporary file being renamed.
/// </para>
/// <para>
/// - On Windows there is no way to remove a file that is open to some
///   process, or mapped into memory. Thus, this function will fail if
///   @filename already exists and is open.
/// </para>
/// <para>
/// If the call was successful, it returns %TRUE. If the call was not successful,
/// it returns %FALSE and sets @error. The error domain is %G_FILE_ERROR.
/// Possible error codes are those in the #GFileError enumeration.
/// </para>
/// <para>
/// Note that the name for the temporary file is constructed by appending up
/// to 7 characters to @filename.
/// </para>
/// <para>
/// If the file didn’t exist before and is created, it will be given the
/// permissions from @mode. Otherwise, the permissions of the existing file may
/// be changed to @mode depending on @flags, or they may remain unchanged.
/// </para>
/// </summary>

/// <param name="filename">
/// name of a file to write @contents to, in the GLib file name
///   encoding
/// </param>
/// <param name="contents">
/// string to write to the file
/// </param>
/// <param name="length">
/// length of @contents, or -1 if @contents is a nul-terminated string
/// </param>
/// <param name="flags">
/// flags controlling the safety vs speed of the operation
/// </param>
/// <param name="mode">
/// file mode, as passed to `open()`; typically this will be `0666`
/// </param>
/// <return>
/// %TRUE on success, %FALSE if an error occurred
/// </return>

	public static bool FileSetContentsFull(string filename, byte[] contents, UIntPtr length, MentorLake.GLib.GFileSetContentsFlags flags, int mode)
	{
		var externCallResult = GLibGlobalFunctionsExterns.g_file_set_contents_full(filename, contents, length, flags, mode, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Returns %TRUE if any of the tests in the bitfield @test are
/// %TRUE. For example, `(G_FILE_TEST_EXISTS | G_FILE_TEST_IS_DIR)`
/// will return %TRUE if the file exists; the check whether it&apos;s a
/// directory doesn&apos;t matter since the existence test is %TRUE. With
/// the current set of available tests, there&apos;s no point passing in
/// more than one test at a time.
/// </para>
/// <para>
/// Apart from %G_FILE_TEST_IS_SYMLINK all tests follow symbolic links,
/// so for a symbolic link to a regular file g_file_test() will return
/// %TRUE for both %G_FILE_TEST_IS_SYMLINK and %G_FILE_TEST_IS_REGULAR.
/// </para>
/// <para>
/// Note, that for a dangling symbolic link g_file_test() will return
/// %TRUE for %G_FILE_TEST_IS_SYMLINK and %FALSE for all other flags.
/// </para>
/// <para>
/// You should never use g_file_test() to test whether it is safe
/// to perform an operation, because there is always the possibility
/// of the condition changing before you actually perform the operation,
/// see [TOCTOU](https://en.wikipedia.org/wiki/Time-of-check_to_time-of-use).
/// </para>
/// <para>
/// For example, you might think you could use %G_FILE_TEST_IS_SYMLINK
/// to know whether it is safe to write to a file without being
/// tricked into writing into a different location. It doesn&apos;t work!
/// </para>
/// <code>
///  // DON&apos;T DO THIS
///  // DON&apos;T DO THIS
///  if (!g_file_test (filename, G_FILE_TEST_IS_SYMLINK))
///    {
///      fd = g_open (filename, O_WRONLY);
///      // write to fd
///    }
/// 
///  // DO THIS INSTEAD
///  fd = g_open (filename, O_WRONLY | O_NOFOLLOW | O_CLOEXEC);
///  if (fd == -1)
///    {
///      // check error
///      if (errno == ELOOP)
///        // file is a symlink and can be ignored
///      else
///        // handle errors as before
///    }
///  else
///    {
///      // write to fd
///    }
/// </code>
/// <para>
/// Another thing to note is that %G_FILE_TEST_EXISTS and
/// %G_FILE_TEST_IS_EXECUTABLE are implemented using the access()
/// system call. This usually doesn&apos;t matter, but if your program
/// is setuid or setgid it means that these tests will give you
/// the answer for the real user ID and group ID, rather than the
/// effective user ID and group ID.
/// </para>
/// <para>
/// On Windows, there are no symlinks, so testing for
/// %G_FILE_TEST_IS_SYMLINK will always return %FALSE. Testing for
/// %G_FILE_TEST_IS_EXECUTABLE will just check that the file exists and
/// its name indicates that it is executable, checking for well-known
/// extensions and those listed in the `PATHEXT` environment variable.
/// </para>
/// </summary>

/// <param name="filename">
/// a filename to test in the
///     GLib file name encoding
/// </param>
/// <param name="test">
/// bitfield of #GFileTest flags
/// </param>
/// <return>
/// whether a test was %TRUE
/// </return>

	public static bool FileTest(string filename, MentorLake.GLib.GFileTest test)
	{
		return GLibGlobalFunctionsExterns.g_file_test(filename, test);
	}

/// <summary>
/// <para>
/// Returns the display basename for the particular filename, guaranteed
/// to be valid UTF-8. The display name might not be identical to the filename,
/// for instance there might be problems converting it to UTF-8, and some files
/// can be translated in the display.
/// </para>
/// <para>
/// If GLib cannot make sense of the encoding of @filename, as a last resort it
/// replaces unknown characters with U+FFFD, the Unicode replacement character.
/// You can search the result for the UTF-8 encoding of this character (which is
/// &quot;\357\277\275&quot; in octal notation) to find out if @filename was in an invalid
/// encoding.
/// </para>
/// <para>
/// You must pass the whole absolute pathname to this functions so that
/// translation of well known locations can be done.
/// </para>
/// <para>
/// This function is preferred over g_filename_display_name() if you know the
/// whole path, as it allows translation.
/// </para>
/// </summary>

/// <param name="filename">
/// an absolute pathname in the
///     GLib file name encoding
/// </param>
/// <return>
/// a newly allocated string containing
///   a rendition of the basename of the filename in valid UTF-8
/// </return>

	public static string FilenameDisplayBasename(string filename)
	{
		return GLibGlobalFunctionsExterns.g_filename_display_basename(filename);
	}

/// <summary>
/// <para>
/// Converts a filename into a valid UTF-8 string. The conversion is
/// not necessarily reversible, so you should keep the original around
/// and use the return value of this function only for display purposes.
/// Unlike g_filename_to_utf8(), the result is guaranteed to be non-%NULL
/// even if the filename actually isn&apos;t in the GLib file name encoding.
/// </para>
/// <para>
/// If GLib cannot make sense of the encoding of @filename, as a last resort it
/// replaces unknown characters with U+FFFD, the Unicode replacement character.
/// You can search the result for the UTF-8 encoding of this character (which is
/// &quot;\357\277\275&quot; in octal notation) to find out if @filename was in an invalid
/// encoding.
/// </para>
/// <para>
/// If you know the whole pathname of the file you should use
/// g_filename_display_basename(), since that allows location-based
/// translation of filenames.
/// </para>
/// </summary>

/// <param name="filename">
/// a pathname hopefully in the
///     GLib file name encoding
/// </param>
/// <return>
/// a newly allocated string containing
///   a rendition of the filename in valid UTF-8
/// </return>

	public static string FilenameDisplayName(string filename)
	{
		return GLibGlobalFunctionsExterns.g_filename_display_name(filename);
	}

/// <summary>
/// <para>
/// Converts an escaped ASCII-encoded URI to a local filename in the
/// encoding used for filenames.
/// </para>
/// <para>
/// Since GLib 2.78, the query string and fragment can be present in the URI,
/// but are not part of the resulting filename.
/// We take inspiration from https://url.spec.whatwg.org/#file-state,
/// but we don&apos;t support the entire standard.
/// </para>
/// </summary>

/// <param name="uri">
/// a uri describing a filename (escaped, encoded in ASCII).
/// </param>
/// <param name="hostname">
/// Location to store hostname for the URI.
///            If there is no hostname in the URI, %NULL will be
///            stored in this location.
/// </param>
/// <return>
/// a newly-allocated string holding
///               the resulting filename, or %NULL on an error.
/// </return>

	public static string FilenameFromUri(string uri, out string hostname)
	{
		var externCallResult = GLibGlobalFunctionsExterns.g_filename_from_uri(uri, out hostname, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Converts a string from UTF-8 to the encoding GLib uses for
/// filenames. Note that on Windows GLib uses UTF-8 for filenames;
/// on other platforms, this function indirectly depends on the
/// [current locale][setlocale].
/// </para>
/// <para>
/// The input string shall not contain nul characters even if the @len
/// argument is positive. A nul character found inside the string will result
/// in error %G_CONVERT_ERROR_ILLEGAL_SEQUENCE. If the filename encoding is
/// not UTF-8 and the conversion output contains a nul character, the error
/// %G_CONVERT_ERROR_EMBEDDED_NUL is set and the function returns %NULL.
/// </para>
/// </summary>

/// <param name="utf8string">
/// a UTF-8 encoded string.
/// </param>
/// <param name="len">
/// the length of the string, or -1 if the string is
///                 nul-terminated.
/// </param>
/// <param name="bytes_read">
/// location to store the number of bytes in
///                 the input string that were successfully converted, or %NULL.
///                 Even if the conversion was successful, this may be
///                 less than @len if there were partial characters
///                 at the end of the input. If the error
///                 %G_CONVERT_ERROR_ILLEGAL_SEQUENCE occurs, the value
///                 stored will be the byte offset after the last valid
///                 input sequence.
/// </param>
/// <param name="bytes_written">
/// the number of bytes stored in
///                 the output buffer (not including the terminating nul).
/// </param>
/// <return>
/// 
///               The converted string, or %NULL on an error.
/// </return>

	public static string FilenameFromUtf8(string utf8string, UIntPtr len, out UIntPtr bytes_read, out UIntPtr bytes_written)
	{
		var externCallResult = GLibGlobalFunctionsExterns.g_filename_from_utf8(utf8string, len, out bytes_read, out bytes_written, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Converts an absolute filename to an escaped ASCII-encoded URI, with the path
/// component following Section 3.3. of RFC 2396.
/// </para>
/// </summary>

/// <param name="filename">
/// an absolute filename specified in the GLib file
///     name encoding, which is the on-disk file name bytes on Unix, and UTF-8
///     on Windows
/// </param>
/// <param name="hostname">
/// A UTF-8 encoded hostname, or %NULL for none.
/// </param>
/// <return>
/// a newly-allocated string holding the resulting
///               URI, or %NULL on an error.
/// </return>

	public static string FilenameToUri(string filename, string hostname)
	{
		var externCallResult = GLibGlobalFunctionsExterns.g_filename_to_uri(filename, hostname, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Converts a string which is in the encoding used by GLib for
/// filenames into a UTF-8 string. Note that on Windows GLib uses UTF-8
/// for filenames; on other platforms, this function indirectly depends on
/// the [current locale][setlocale].
/// </para>
/// <para>
/// The input string shall not contain nul characters even if the @len
/// argument is positive. A nul character found inside the string will result
/// in error %G_CONVERT_ERROR_ILLEGAL_SEQUENCE.
/// If the source encoding is not UTF-8 and the conversion output contains a
/// nul character, the error %G_CONVERT_ERROR_EMBEDDED_NUL is set and the
/// function returns %NULL. Use g_convert() to produce output that
/// may contain embedded nul characters.
/// </para>
/// </summary>

/// <param name="opsysstring">
/// a string in the encoding for filenames
/// </param>
/// <param name="len">
/// the length of the string, or -1 if the string is
///                 nul-terminated (Note that some encodings may allow nul
///                 bytes to occur inside strings. In that case, using -1
///                 for the @len parameter is unsafe)
/// </param>
/// <param name="bytes_read">
/// location to store the number of bytes in the
///                 input string that were successfully converted, or %NULL.
///                 Even if the conversion was successful, this may be
///                 less than @len if there were partial characters
///                 at the end of the input. If the error
///                 %G_CONVERT_ERROR_ILLEGAL_SEQUENCE occurs, the value
///                 stored will be the byte offset after the last valid
///                 input sequence.
/// </param>
/// <param name="bytes_written">
/// the number of bytes stored in the output
///                 buffer (not including the terminating nul).
/// </param>
/// <return>
/// The converted string, or %NULL on an error.
/// </return>

	public static string FilenameToUtf8(string opsysstring, UIntPtr len, out UIntPtr bytes_read, out UIntPtr bytes_written)
	{
		var externCallResult = GLibGlobalFunctionsExterns.g_filename_to_utf8(opsysstring, len, out bytes_read, out bytes_written, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Locates the first executable named @program in the user&apos;s path, in the
/// same way that execvp() would locate it. Returns an allocated string
/// with the absolute path name, or %NULL if the program is not found in
/// the path. If @program is already an absolute path, returns a copy of
/// @program if @program exists and is executable, and %NULL otherwise.
/// </para>
/// <para>
/// On Windows, if @program does not have a file type suffix, tries
/// with the suffixes .exe, .cmd, .bat and .com, and the suffixes in
/// the `PATHEXT` environment variable.
/// </para>
/// <para>
/// On Windows, it looks for the file in the same way as CreateProcess()
/// would. This means first in the directory where the executing
/// program was loaded from, then in the current directory, then in the
/// Windows 32-bit system directory, then in the Windows directory, and
/// finally in the directories in the `PATH` environment variable. If
/// the program is found, the return value contains the full name
/// including the type suffix.
/// </para>
/// </summary>

/// <param name="program">
/// a program name in the GLib file name encoding
/// </param>
/// <return>
/// a newly-allocated
///   string with the absolute path, or %NULL
/// </return>

	public static string FindProgramInPath(string program)
	{
		return GLibGlobalFunctionsExterns.g_find_program_in_path(program);
	}

/// <summary>
/// <para>
/// A wrapper for the stdio `fopen()` function. The `fopen()` function
/// opens a file and associates a new stream with it.
/// </para>
/// <para>
/// Because file descriptors are specific to the C library on Windows,
/// and a file descriptor is part of the `FILE` struct, the `FILE*` returned
/// by this function makes sense only to functions in the same C library.
/// Thus if the GLib-using code uses a different C library than GLib does,
/// the FILE* returned by this function cannot be passed to C library
/// functions like `fprintf()` or `fread()`.
/// </para>
/// <para>
/// See your C library manual for more details about `fopen()`.
/// </para>
/// <para>
/// As `close()` and `fclose()` are part of the C library, this implies that it is
/// currently impossible to close a file if the application C library and the C library
/// used by GLib are different. Convenience functions like g_file_set_contents_full()
/// avoid this problem.
/// </para>
/// </summary>

/// <param name="filename">
/// a pathname in the GLib file name encoding
///     (UTF-8 on Windows)
/// </param>
/// <param name="mode">
/// a string describing the mode in which the file should be opened
/// </param>
/// <return>
/// A `FILE*` if the file was successfully opened, or %NULL if
///     an error occurred
/// </return>

	public static IntPtr Fopen(string filename, string mode)
	{
		return GLibGlobalFunctionsExterns.g_fopen(filename, mode);
	}

/// <summary>
/// <para>
/// Formats a size (for example the size of a file) into a human readable
/// string.  Sizes are rounded to the nearest size prefix (kB, MB, GB)
/// and are displayed rounded to the nearest tenth. E.g. the file size
/// 3292528 bytes will be converted into the string &quot;3.2 MB&quot;. The returned string
/// is UTF-8, and may use a non-breaking space to separate the number and units,
/// to ensure they aren’t separated when line wrapped.
/// </para>
/// <para>
/// The prefix units base is 1000 (i.e. 1 kB is 1000 bytes).
/// </para>
/// <para>
/// This string should be freed with g_free() when not needed any longer.
/// </para>
/// <para>
/// See g_format_size_full() for more options about how the size might be
/// formatted.
/// </para>
/// </summary>

/// <param name="size">
/// a size in bytes
/// </param>
/// <return>
/// a newly-allocated formatted string containing
///   a human readable file size
/// </return>

	public static string FormatSize(ulong size)
	{
		return GLibGlobalFunctionsExterns.g_format_size(size);
	}

/// <summary>
/// <para>
/// Formats a size (for example the size of a file) into a human
/// readable string. Sizes are rounded to the nearest size prefix
/// (KB, MB, GB) and are displayed rounded to the nearest tenth.
/// E.g. the file size 3292528 bytes will be converted into the
/// string &quot;3.1 MB&quot;.
/// </para>
/// <para>
/// The prefix units base is 1024 (i.e. 1 KB is 1024 bytes).
/// </para>
/// <para>
/// This string should be freed with g_free() when not needed any longer.
/// </para>
/// </summary>

/// <param name="size">
/// a size in bytes
/// </param>
/// <return>
/// a newly-allocated formatted string
///   containing a human readable file size
/// </return>

	public static string FormatSizeForDisplay(int size)
	{
		return GLibGlobalFunctionsExterns.g_format_size_for_display(size);
	}

/// <summary>
/// <para>
/// Formats a size.
/// </para>
/// <para>
/// This function is similar to g_format_size() but allows for flags
/// that modify the output. See #GFormatSizeFlags.
/// </para>
/// </summary>

/// <param name="size">
/// a size in bytes
/// </param>
/// <param name="flags">
/// #GFormatSizeFlags to modify the output
/// </param>
/// <return>
/// a newly-allocated formatted string
///   containing a human readable file size
/// </return>

	public static string FormatSizeFull(ulong size, MentorLake.GLib.GFormatSizeFlags flags)
	{
		return GLibGlobalFunctionsExterns.g_format_size_full(size, flags);
	}

/// <summary>
/// <para>
/// An implementation of the standard `fprintf()` function which supports
/// positional parameters, as specified in the Single Unix Specification.
/// </para>
/// <para>
/// `glib/gprintf.h` must be explicitly included in order to use this function.
/// </para>
/// </summary>

/// <param name="file">
/// the stream to write to
/// </param>
/// <param name="format">
/// a standard `printf()` format string, but notice
///   [string precision pitfalls](string-utils.html#string-precision-pitfalls)
/// </param>
/// <param name="@__arglist">
/// the arguments to insert in the output
/// </param>
/// <return>
/// the number of bytes printed
/// </return>

	public static int Fprintf(IntPtr file, string format, IntPtr @__arglist)
	{
		return GLibGlobalFunctionsExterns.g_fprintf(file, format, @__arglist);
	}

/// <summary>
/// <para>
/// Frees the memory pointed to by @mem.
/// </para>
/// <para>
/// If you know the allocated size of @mem, calling g_free_sized() may be faster,
/// depending on the libc implementation in use.
/// </para>
/// <para>
/// Starting from GLib 2.78, this may happen automatically in case a GCC
/// compatible compiler is used with some optimization level and the allocated
/// size is known at compile time (see [documentation of
/// `__builtin_object_size()`](https://gcc.gnu.org/onlinedocs/gcc/Object-Size-Checking.html)
/// to understand its caveats).
/// </para>
/// <para>
/// If @mem is %NULL it simply returns, so there is no need to check @mem
/// against %NULL before calling this function.
/// </para>
/// </summary>

/// <param name="mem">
/// the memory to free
/// </param>

	public static void Free(IntPtr mem)
	{
		GLibGlobalFunctionsExterns.g_free(mem);
	}

/// <summary>
/// <para>
/// Frees the memory pointed to by @mem, assuming it is has the given @size.
/// </para>
/// <para>
/// If @mem is %NULL this is a no-op (and @size is ignored).
/// </para>
/// <para>
/// It is an error if @size doesn’t match the size passed when @mem was
/// allocated. @size is passed to this function to allow optimizations in the
/// allocator. If you don’t know the allocation size, use g_free() instead.
/// </para>
/// <para>
/// In case a GCC compatible compiler is used, this function may be used
/// automatically via g_free() if the allocated size is known at compile time,
/// since GLib 2.78.
/// </para>
/// </summary>

/// <param name="mem">
/// the memory to free
/// </param>
/// <param name="size">
/// size of @mem, in bytes
/// </param>

	public static void FreeSized(IntPtr mem, UIntPtr size)
	{
		GLibGlobalFunctionsExterns.g_free_sized(mem, size);
	}

/// <summary>
/// <para>
/// A wrapper for the POSIX freopen() function. The freopen() function
/// opens a file and associates it with an existing stream.
/// </para>
/// <para>
/// See your C library manual for more details about freopen().
/// </para>
/// </summary>

/// <param name="filename">
/// a pathname in the GLib file name encoding
///     (UTF-8 on Windows)
/// </param>
/// <param name="mode">
/// a string describing the mode in which the file should be  opened
/// </param>
/// <param name="stream">
/// an existing stream which will be reused, or %NULL
/// </param>
/// <return>
/// A FILE* if the file was successfully opened, or %NULL if
///     an error occurred.
/// </return>

	public static IntPtr Freopen(string filename, string mode, IntPtr stream)
	{
		return GLibGlobalFunctionsExterns.g_freopen(filename, mode, stream);
	}

/// <summary>
/// <para>
/// A wrapper for the POSIX `fsync()` function. On Windows, `_commit()` will be
/// used. On macOS, `fcntl(F_FULLFSYNC)` will be used.
/// The `fsync()` function is used to synchronize a file&apos;s in-core
/// state with that of the disk.
/// </para>
/// <para>
/// This wrapper will handle retrying on `EINTR`.
/// </para>
/// <para>
/// See the C library manual for more details about fsync().
/// </para>
/// </summary>

/// <param name="fd">
/// a file descriptor
/// </param>
/// <return>
/// 0 on success, or -1 if an error occurred.
/// The return value can be used exactly like the return value from fsync().
/// </return>

	public static int Fsync(int fd)
	{
		return GLibGlobalFunctionsExterns.g_fsync(fd);
	}

/// <summary>
/// <para>
/// Gets a human-readable name for the application, as set by
/// g_set_application_name(). This name should be localized if
/// possible, and is intended for display to the user.  Contrast with
/// g_get_prgname(), which gets a non-localized name. If
/// g_set_application_name() has not been called, returns the result of
/// g_get_prgname() (which may be %NULL if g_set_prgname() has also not
/// been called).
/// </para>
/// </summary>

/// <return>
/// human-readable application
///   name. May return %NULL
/// </return>

	public static string GetApplicationName()
	{
		return GLibGlobalFunctionsExterns.g_get_application_name();
	}

/// <summary>
/// <para>
/// Obtains the character set for the [current locale][setlocale]; you
/// might use this character set as an argument to g_convert(), to convert
/// from the current locale&apos;s encoding to some other encoding. (Frequently
/// g_locale_to_utf8() and g_locale_from_utf8() are nice shortcuts, though.)
/// </para>
/// <para>
/// On Windows the character set returned by this function is the
/// so-called system default ANSI code-page. That is the character set
/// used by the &quot;narrow&quot; versions of C library and Win32 functions that
/// handle file names. It might be different from the character set
/// used by the C library&apos;s current locale.
/// </para>
/// <para>
/// On Linux, the character set is found by consulting nl_langinfo() if
/// available. If not, the environment variables `LC_ALL`, `LC_CTYPE`, `LANG`
/// and `CHARSET` are queried in order. nl_langinfo() returns the C locale if
/// no locale has been loaded by setlocale().
/// </para>
/// <para>
/// The return value is %TRUE if the locale&apos;s encoding is UTF-8, in that
/// case you can perhaps avoid calling g_convert().
/// </para>
/// <para>
/// The string returned in @charset is not allocated, and should not be
/// freed.
/// </para>
/// </summary>

/// <param name="charset">
/// return location for character set
///   name, or %NULL.
/// </param>
/// <return>
/// %TRUE if the returned charset is UTF-8
/// </return>

	public static bool GetCharset(out string charset)
	{
		return GLibGlobalFunctionsExterns.g_get_charset(out charset);
	}

/// <summary>
/// <para>
/// Gets the character set for the current locale.
/// </para>
/// </summary>

/// <return>
/// a newly allocated string containing the name
///     of the character set. This string must be freed with g_free().
/// </return>

	public static string GetCodeset()
	{
		return GLibGlobalFunctionsExterns.g_get_codeset();
	}

/// <summary>
/// <para>
/// Obtains the character set used by the console attached to the process,
/// which is suitable for printing output to the terminal.
/// </para>
/// <para>
/// Usually this matches the result returned by g_get_charset(), but in
/// environments where the locale&apos;s character set does not match the encoding
/// of the console this function tries to guess a more suitable value instead.
/// </para>
/// <para>
/// On Windows the character set returned by this function is the
/// output code page used by the console associated with the calling process.
/// If the codepage can&apos;t be determined (for example because there is no
/// console attached) UTF-8 is assumed.
/// </para>
/// <para>
/// The return value is %TRUE if the locale&apos;s encoding is UTF-8, in that
/// case you can perhaps avoid calling g_convert().
/// </para>
/// <para>
/// The string returned in @charset is not allocated, and should not be
/// freed.
/// </para>
/// </summary>

/// <param name="charset">
/// return location for character set
///   name, or %NULL.
/// </param>
/// <return>
/// %TRUE if the returned charset is UTF-8
/// </return>

	public static bool GetConsoleCharset(out string charset)
	{
		return GLibGlobalFunctionsExterns.g_get_console_charset(out charset);
	}

/// <summary>
/// <para>
/// Gets the current directory.
/// </para>
/// <para>
/// The returned string should be freed when no longer needed.
/// The encoding of the returned string is system defined.
/// On Windows, it is always UTF-8.
/// </para>
/// <para>
/// Since GLib 2.40, this function will return the value of the &quot;PWD&quot;
/// environment variable if it is set and it happens to be the same as
/// the current directory.  This can make a difference in the case that
/// the current directory is the target of a symbolic link.
/// </para>
/// </summary>

/// <return>
/// the current directory
/// </return>

	public static string GetCurrentDir()
	{
		return GLibGlobalFunctionsExterns.g_get_current_dir();
	}

/// <summary>
/// <para>
/// Equivalent to the UNIX gettimeofday() function, but portable.
/// </para>
/// <para>
/// You may find [func@GLib.get_real_time] to be more convenient.
/// </para>
/// </summary>

/// <param name="result">
/// #GTimeVal structure in which to store current time.
/// </param>

	public static void GetCurrentTime(MentorLake.GLib.GTimeValHandle result)
	{
		GLibGlobalFunctionsExterns.g_get_current_time(result);
	}

/// <summary>
/// <para>
/// Gets the list of environment variables for the current process.
/// </para>
/// <para>
/// The list is %NULL terminated and each item in the list is of the
/// form &apos;NAME=VALUE&apos;.
/// </para>
/// <para>
/// This is equivalent to direct access to the &apos;environ&apos; global variable,
/// except portable.
/// </para>
/// <para>
/// The return value is freshly allocated and it should be freed with
/// g_strfreev() when it is no longer needed.
/// </para>
/// </summary>

/// <return>
/// 
///     the list of environment variables
/// </return>

	public static string[] GetEnviron()
	{
		return GLibGlobalFunctionsExterns.g_get_environ();
	}

/// <summary>
/// <para>
/// Determines the preferred character sets used for filenames.
/// The first character set from the @charsets is the filename encoding, the
/// subsequent character sets are used when trying to generate a displayable
/// representation of a filename, see g_filename_display_name().
/// </para>
/// <para>
/// On Unix, the character sets are determined by consulting the
/// environment variables `G_FILENAME_ENCODING` and `G_BROKEN_FILENAMES`.
/// On Windows, the character set used in the GLib API is always UTF-8
/// and said environment variables have no effect.
/// </para>
/// <para>
/// `G_FILENAME_ENCODING` may be set to a comma-separated list of
/// character set names. The special token &quot;\@locale&quot; is taken
/// to  mean the character set for the [current locale][setlocale].
/// If `G_FILENAME_ENCODING` is not set, but `G_BROKEN_FILENAMES` is,
/// the character set of the current locale is taken as the filename
/// encoding. If neither environment variable  is set, UTF-8 is taken
/// as the filename encoding, but the character set of the current locale
/// is also put in the list of encodings.
/// </para>
/// <para>
/// The returned @charsets belong to GLib and must not be freed.
/// </para>
/// <para>
/// Note that on Unix, regardless of the locale character set or
/// `G_FILENAME_ENCODING` value, the actual file names present
/// on a system might be in any random encoding or just gibberish.
/// </para>
/// </summary>

/// <param name="filename_charsets">
/// 
///    return location for the %NULL-terminated list of encoding names
/// </param>
/// <return>
/// %TRUE if the filename encoding is UTF-8.
/// </return>

	public static bool GetFilenameCharsets(out string[] filename_charsets)
	{
		return GLibGlobalFunctionsExterns.g_get_filename_charsets(out filename_charsets);
	}

/// <summary>
/// <para>
/// Gets the current user&apos;s home directory.
/// </para>
/// <para>
/// As with most UNIX tools, this function will return the value of the
/// `HOME` environment variable if it is set to an existing absolute path
/// name, falling back to the `passwd` file in the case that it is unset.
/// </para>
/// <para>
/// If the path given in `HOME` is non-absolute, does not exist, or is
/// not a directory, the result is undefined.
/// </para>
/// <para>
/// Before version 2.36 this function would ignore the `HOME` environment
/// variable, taking the value from the `passwd` database instead. This was
/// changed to increase the compatibility of GLib with other programs (and
/// the XDG basedir specification) and to increase testability of programs
/// based on GLib (by making it easier to run them from test frameworks).
/// </para>
/// <para>
/// If your program has a strong requirement for either the new or the
/// old behaviour (and if you don&apos;t wish to increase your GLib
/// dependency to ensure that the new behaviour is in effect) then you
/// should either directly check the `HOME` environment variable yourself
/// or unset it before calling any functions in GLib.
/// </para>
/// </summary>

/// <return>
/// the current user&apos;s home directory
/// </return>

	public static string GetHomeDir()
	{
		return GLibGlobalFunctionsExterns.g_get_home_dir();
	}

/// <summary>
/// <para>
/// Return a name for the machine.
/// </para>
/// <para>
/// The returned name is not necessarily a fully-qualified domain name,
/// or even present in DNS or some other name service at all. It need
/// not even be unique on your local network or site, but usually it
/// is. Callers should not rely on the return value having any specific
/// properties like uniqueness for security purposes. Even if the name
/// of the machine is changed while an application is running, the
/// return value from this function does not change. The returned
/// string is owned by GLib and should not be modified or freed. If no
/// name can be determined, a default fixed string &quot;localhost&quot; is
/// returned.
/// </para>
/// <para>
/// The encoding of the returned string is UTF-8.
/// </para>
/// </summary>

/// <return>
/// the host name of the machine.
/// </return>

	public static string GetHostName()
	{
		return GLibGlobalFunctionsExterns.g_get_host_name();
	}

/// <summary>
/// <para>
/// Computes a list of applicable locale names, which can be used to
/// e.g. construct locale-dependent filenames or search paths. The returned
/// list is sorted from most desirable to least desirable and always contains
/// the default locale &quot;C&quot;.
/// </para>
/// <para>
/// For example, if LANGUAGE=de:en_US, then the returned list is
/// &quot;de&quot;, &quot;en_US&quot;, &quot;en&quot;, &quot;C&quot;.
/// </para>
/// <para>
/// This function consults the environment variables `LANGUAGE`, `LC_ALL`,
/// `LC_MESSAGES` and `LANG` to find the list of locales specified by the
/// user.
/// </para>
/// </summary>

/// <return>
/// a %NULL-terminated array of strings owned by GLib
///    that must not be modified or freed.
/// </return>

	public static string[] GetLanguageNames()
	{
		return GLibGlobalFunctionsExterns.g_get_language_names();
	}

/// <summary>
/// <para>
/// Computes a list of applicable locale names with a locale category name,
/// which can be used to construct the fallback locale-dependent filenames
/// or search paths. The returned list is sorted from most desirable to
/// least desirable and always contains the default locale &quot;C&quot;.
/// </para>
/// <para>
/// This function consults the environment variables `LANGUAGE`, `LC_ALL`,
/// @category_name, and `LANG` to find the list of locales specified by the
/// user.
/// </para>
/// <para>
/// g_get_language_names() returns g_get_language_names_with_category(&quot;LC_MESSAGES&quot;).
/// </para>
/// </summary>

/// <param name="category_name">
/// a locale category name
/// </param>
/// <return>
/// a %NULL-terminated array of strings owned by
///    the thread g_get_language_names_with_category was called from.
///    It must not be modified or freed. It must be copied if planned to be used in another thread.
/// </return>

	public static string[] GetLanguageNamesWithCategory(string category_name)
	{
		return GLibGlobalFunctionsExterns.g_get_language_names_with_category(category_name);
	}

/// <summary>
/// <para>
/// Returns a list of derived variants of @locale, which can be used to
/// e.g. construct locale-dependent filenames or search paths. The returned
/// list is sorted from most desirable to least desirable.
/// This function handles territory, charset and extra locale modifiers. See
/// &amp;lt;see href=&quot;man:setlocale&quot;&amp;gt;setlocale(3)&amp;lt;/see&amp;gt; for information about locales and their format.
/// </para>
/// <para>
/// @locale itself is guaranteed to be returned in the output.
/// </para>
/// <para>
/// For example, if @locale is `fr_BE`, then the returned list
/// is `fr_BE`, `fr`. If @locale is `en_GB.UTF-8@euro`, then the returned list
/// is `en_GB.UTF-8@euro`, `en_GB.UTF-8`, `en_GB@euro`, `en_GB`, `en.UTF-8@euro`,
/// `en.UTF-8`, `en@euro`, `en`.
/// </para>
/// <para>
/// If you need the list of variants for the current locale,
/// use g_get_language_names().
/// </para>
/// </summary>

/// <param name="locale">
/// a locale identifier
/// </param>
/// <return>
/// a newly
///   allocated array of newly allocated strings with the locale variants. Free with
///   g_strfreev().
/// </return>

	public static string[] GetLocaleVariants(string locale)
	{
		return GLibGlobalFunctionsExterns.g_get_locale_variants(locale);
	}

/// <summary>
/// <para>
/// Queries the system monotonic time.
/// </para>
/// <para>
/// The monotonic clock will always increase and doesn&apos;t suffer
/// discontinuities when the user (or NTP) changes the system time.  It
/// may or may not continue to tick during times where the machine is
/// suspended.
/// </para>
/// <para>
/// We try to use the clock that corresponds as closely as possible to
/// the passage of time as measured by system calls such as poll() but it
/// may not always be possible to do this.
/// </para>
/// </summary>

/// <return>
/// the monotonic time, in microseconds
/// </return>

	public static long GetMonotonicTime()
	{
		return GLibGlobalFunctionsExterns.g_get_monotonic_time();
	}

/// <summary>
/// <para>
/// Determine the approximate number of threads that the system will
/// schedule simultaneously for this process.  This is intended to be
/// used as a parameter to g_thread_pool_new() for CPU bound tasks and
/// similar cases.
/// </para>
/// </summary>

/// <return>
/// Number of schedulable threads, always greater than 0
/// </return>

	public static uint GetNumProcessors()
	{
		return GLibGlobalFunctionsExterns.g_get_num_processors();
	}

/// <summary>
/// <para>
/// Get information about the operating system.
/// </para>
/// <para>
/// On Linux this comes from the `/etc/os-release` file. On other systems, it may
/// come from a variety of sources. You can either use the standard key names
/// like %G_OS_INFO_KEY_NAME or pass any UTF-8 string key name. For example,
/// `/etc/os-release` provides a number of other less commonly used values that may
/// be useful. No key is guaranteed to be provided, so the caller should always
/// check if the result is %NULL.
/// </para>
/// </summary>

/// <param name="key_name">
/// a key for the OS info being requested, for example %G_OS_INFO_KEY_NAME.
/// </param>
/// <return>
/// The associated value for the requested key or %NULL if
///   this information is not provided.
/// </return>

	public static string GetOsInfo(string key_name)
	{
		return GLibGlobalFunctionsExterns.g_get_os_info(key_name);
	}

/// <summary>
/// <para>
/// Gets the name of the program. This name should not be localized,
/// in contrast to g_get_application_name().
/// </para>
/// <para>
/// If you are using #GApplication the program name is set in
/// g_application_run(). In case of GDK or GTK it is set in
/// gdk_init(), which is called by gtk_init() and the
/// #GtkApplication::startup handler. The program name is found by
/// taking the last component of @argv[0].
/// </para>
/// </summary>

/// <return>
/// the name of the program,
///   or %NULL if it has not been set yet. The returned string belongs
///   to GLib and must not be modified or freed.
/// </return>

	public static string GetPrgname()
	{
		return GLibGlobalFunctionsExterns.g_get_prgname();
	}

/// <summary>
/// <para>
/// Gets the real name of the user. This usually comes from the user&apos;s
/// entry in the `passwd` file. The encoding of the returned string is
/// system-defined. (On Windows, it is, however, always UTF-8.) If the
/// real user name cannot be determined, the string &quot;Unknown&quot; is
/// returned.
/// </para>
/// </summary>

/// <return>
/// the user&apos;s real name.
/// </return>

	public static string GetRealName()
	{
		return GLibGlobalFunctionsExterns.g_get_real_name();
	}

/// <summary>
/// <para>
/// Queries the system wall-clock time.
/// </para>
/// <para>
/// This call is functionally equivalent to [func@GLib.get_current_time] except
/// that the return value is often more convenient than dealing with a
/// #GTimeVal.
/// </para>
/// <para>
/// You should only use this call if you are actually interested in the real
/// wall-clock time. [func@GLib.get_monotonic_time] is probably more useful for
/// measuring intervals.
/// </para>
/// </summary>

/// <return>
/// the number of microseconds since January 1, 1970 UTC.
/// </return>

	public static long GetRealTime()
	{
		return GLibGlobalFunctionsExterns.g_get_real_time();
	}

/// <summary>
/// <para>
/// Returns an ordered list of base directories in which to access
/// system-wide configuration information.
/// </para>
/// <para>
/// On UNIX platforms this is determined using the mechanisms described
/// in the
/// [XDG Base Directory Specification](http://www.freedesktop.org/Standards/basedir-spec).
/// In this case the list of directories retrieved will be `XDG_CONFIG_DIRS`.
/// </para>
/// <para>
/// On Windows it follows XDG Base Directory Specification if `XDG_CONFIG_DIRS` is defined.
/// If `XDG_CONFIG_DIRS` is undefined, the directory that contains application
/// data for all users is used instead. A typical path is
/// `C:\Documents and Settings\All Users\Application Data`.
/// This folder is used for application data
/// that is not user specific. For example, an application can store
/// a spell-check dictionary, a database of clip art, or a log file in the
/// FOLDERID_ProgramData folder. This information will not roam and is available
/// to anyone using the computer.
/// </para>
/// <para>
/// The return value is cached and modifying it at runtime is not supported, as
/// it’s not thread-safe to modify environment variables at runtime.
/// </para>
/// </summary>

/// <return>
/// 
///     a %NULL-terminated array of strings owned by GLib that must not be
///     modified or freed.
/// </return>

	public static string[] GetSystemConfigDirs()
	{
		return GLibGlobalFunctionsExterns.g_get_system_config_dirs();
	}

/// <summary>
/// <para>
/// Returns an ordered list of base directories in which to access
/// system-wide application data.
/// </para>
/// <para>
/// On UNIX platforms this is determined using the mechanisms described
/// in the
/// [XDG Base Directory Specification](http://www.freedesktop.org/Standards/basedir-spec)
/// In this case the list of directories retrieved will be `XDG_DATA_DIRS`.
/// </para>
/// <para>
/// On Windows it follows XDG Base Directory Specification if `XDG_DATA_DIRS` is defined.
/// If `XDG_DATA_DIRS` is undefined,
/// the first elements in the list are the Application Data
/// and Documents folders for All Users. (These can be determined only
/// on Windows 2000 or later and are not present in the list on other
/// Windows versions.) See documentation for FOLDERID_ProgramData and
/// FOLDERID_PublicDocuments.
/// </para>
/// <para>
/// Then follows the &quot;share&quot; subfolder in the installation folder for
/// the package containing the DLL that calls this function, if it can
/// be determined.
/// </para>
/// <para>
/// Finally the list contains the &quot;share&quot; subfolder in the installation
/// folder for GLib, and in the installation folder for the package the
/// application&apos;s .exe file belongs to.
/// </para>
/// <para>
/// The installation folders above are determined by looking up the
/// folder where the module (DLL or EXE) in question is located. If the
/// folder&apos;s name is &quot;bin&quot;, its parent is used, otherwise the folder
/// itself.
/// </para>
/// <para>
/// Note that on Windows the returned list can vary depending on where
/// this function is called.
/// </para>
/// <para>
/// The return value is cached and modifying it at runtime is not supported, as
/// it’s not thread-safe to modify environment variables at runtime.
/// </para>
/// </summary>

/// <return>
/// 
///     a %NULL-terminated array of strings owned by GLib that must not be
///     modified or freed.
/// </return>

	public static string[] GetSystemDataDirs()
	{
		return GLibGlobalFunctionsExterns.g_get_system_data_dirs();
	}

/// <summary>
/// <para>
/// Gets the directory to use for temporary files.
/// </para>
/// <para>
/// On UNIX, this is taken from the `TMPDIR` environment variable.
/// If the variable is not set, `P_tmpdir` is
/// used, as defined by the system C library. Failing that, a
/// hard-coded default of &quot;/tmp&quot; is returned.
/// </para>
/// <para>
/// On Windows, the `TEMP` environment variable is used, with the
/// root directory of the Windows installation (eg: &quot;C:\&quot;) used
/// as a default.
/// </para>
/// <para>
/// The encoding of the returned string is system-defined. On Windows,
/// it is always UTF-8. The return value is never %NULL or the empty
/// string.
/// </para>
/// </summary>

/// <return>
/// the directory to use for temporary files.
/// </return>

	public static string GetTmpDir()
	{
		return GLibGlobalFunctionsExterns.g_get_tmp_dir();
	}

/// <summary>
/// <para>
/// Returns a base directory in which to store non-essential, cached
/// data specific to particular user.
/// </para>
/// <para>
/// On UNIX platforms this is determined using the mechanisms described
/// in the
/// [XDG Base Directory Specification](http://www.freedesktop.org/Standards/basedir-spec).
/// In this case the directory retrieved will be `XDG_CACHE_HOME`.
/// </para>
/// <para>
/// On Windows it follows XDG Base Directory Specification if `XDG_CACHE_HOME` is defined.
/// If `XDG_CACHE_HOME` is undefined, the directory that serves as a common
/// repository for temporary Internet files is used instead. A typical path is
/// `C:\Documents and Settings\username\Local Settings\Temporary Internet Files`.
/// See the [documentation for `FOLDERID_InternetCache`](https://docs.microsoft.com/en-us/windows/win32/shell/knownfolderid).
/// </para>
/// <para>
/// The return value is cached and modifying it at runtime is not supported, as
/// it’s not thread-safe to modify environment variables at runtime.
/// </para>
/// </summary>

/// <return>
/// a string owned by GLib that
///   must not be modified or freed.
/// </return>

	public static string GetUserCacheDir()
	{
		return GLibGlobalFunctionsExterns.g_get_user_cache_dir();
	}

/// <summary>
/// <para>
/// Returns a base directory in which to store user-specific application
/// configuration information such as user preferences and settings.
/// </para>
/// <para>
/// On UNIX platforms this is determined using the mechanisms described
/// in the
/// [XDG Base Directory Specification](http://www.freedesktop.org/Standards/basedir-spec).
/// In this case the directory retrieved will be `XDG_CONFIG_HOME`.
/// </para>
/// <para>
/// On Windows it follows XDG Base Directory Specification if `XDG_CONFIG_HOME` is defined.
/// If `XDG_CONFIG_HOME` is undefined, the folder to use for local (as opposed
/// to roaming) application data is used instead. See the
/// [documentation for `FOLDERID_LocalAppData`](https://docs.microsoft.com/en-us/windows/win32/shell/knownfolderid).
/// Note that in this case on Windows it will be  the same
/// as what g_get_user_data_dir() returns.
/// </para>
/// <para>
/// The return value is cached and modifying it at runtime is not supported, as
/// it’s not thread-safe to modify environment variables at runtime.
/// </para>
/// </summary>

/// <return>
/// a string owned by GLib that
///   must not be modified or freed.
/// </return>

	public static string GetUserConfigDir()
	{
		return GLibGlobalFunctionsExterns.g_get_user_config_dir();
	}

/// <summary>
/// <para>
/// Returns a base directory in which to access application data such
/// as icons that is customized for a particular user.
/// </para>
/// <para>
/// On UNIX platforms this is determined using the mechanisms described
/// in the
/// [XDG Base Directory Specification](http://www.freedesktop.org/Standards/basedir-spec).
/// In this case the directory retrieved will be `XDG_DATA_HOME`.
/// </para>
/// <para>
/// On Windows it follows XDG Base Directory Specification if `XDG_DATA_HOME`
/// is defined. If `XDG_DATA_HOME` is undefined, the folder to use for local (as
/// opposed to roaming) application data is used instead. See the
/// [documentation for `FOLDERID_LocalAppData`](https://docs.microsoft.com/en-us/windows/win32/shell/knownfolderid).
/// Note that in this case on Windows it will be the same
/// as what g_get_user_config_dir() returns.
/// </para>
/// <para>
/// The return value is cached and modifying it at runtime is not supported, as
/// it’s not thread-safe to modify environment variables at runtime.
/// </para>
/// </summary>

/// <return>
/// a string owned by GLib that must
///   not be modified or freed.
/// </return>

	public static string GetUserDataDir()
	{
		return GLibGlobalFunctionsExterns.g_get_user_data_dir();
	}

/// <summary>
/// <para>
/// Gets the user name of the current user. The encoding of the returned
/// string is system-defined. On UNIX, it might be the preferred file name
/// encoding, or something else, and there is no guarantee that it is even
/// consistent on a machine. On Windows, it is always UTF-8.
/// </para>
/// </summary>

/// <return>
/// the user name of the current user.
/// </return>

	public static string GetUserName()
	{
		return GLibGlobalFunctionsExterns.g_get_user_name();
	}

/// <summary>
/// <para>
/// Returns a directory that is unique to the current user on the local
/// system.
/// </para>
/// <para>
/// This is determined using the mechanisms described
/// in the
/// [XDG Base Directory Specification](http://www.freedesktop.org/Standards/basedir-spec).
/// This is the directory
/// specified in the `XDG_RUNTIME_DIR` environment variable.
/// In the case that this variable is not set, we return the value of
/// g_get_user_cache_dir(), after verifying that it exists.
/// </para>
/// <para>
/// The return value is cached and modifying it at runtime is not supported, as
/// it’s not thread-safe to modify environment variables at runtime.
/// </para>
/// </summary>

/// <return>
/// a string owned by GLib that must not be
///     modified or freed.
/// </return>

	public static string GetUserRuntimeDir()
	{
		return GLibGlobalFunctionsExterns.g_get_user_runtime_dir();
	}

/// <summary>
/// <para>
/// Returns the full path of a special directory using its logical id.
/// </para>
/// <para>
/// On UNIX this is done using the XDG special user directories.
/// For compatibility with existing practise, %G_USER_DIRECTORY_DESKTOP
/// falls back to `$HOME/Desktop` when XDG special user directories have
/// not been set up.
/// </para>
/// <para>
/// Depending on the platform, the user might be able to change the path
/// of the special directory without requiring the session to restart; GLib
/// will not reflect any change once the special directories are loaded.
/// </para>
/// </summary>

/// <param name="directory">
/// the logical id of special directory
/// </param>
/// <return>
/// the path to the specified special
///   directory, or %NULL if the logical id was not found. The returned string is
///   owned by GLib and should not be modified or freed.
/// </return>

	public static string GetUserSpecialDir(MentorLake.GLib.GUserDirectory directory)
	{
		return GLibGlobalFunctionsExterns.g_get_user_special_dir(directory);
	}

/// <summary>
/// <para>
/// Returns a base directory in which to store state files specific to
/// particular user.
/// </para>
/// <para>
/// On UNIX platforms this is determined using the mechanisms described
/// in the
/// [XDG Base Directory Specification](http://www.freedesktop.org/Standards/basedir-spec).
/// In this case the directory retrieved will be `XDG_STATE_HOME`.
/// </para>
/// <para>
/// On Windows it follows XDG Base Directory Specification if `XDG_STATE_HOME` is defined.
/// If `XDG_STATE_HOME` is undefined, the folder to use for local (as opposed
/// to roaming) application data is used instead. See the
/// [documentation for `FOLDERID_LocalAppData`](https://docs.microsoft.com/en-us/windows/win32/shell/knownfolderid).
/// Note that in this case on Windows it will be the same
/// as what g_get_user_data_dir() returns.
/// </para>
/// <para>
/// The return value is cached and modifying it at runtime is not supported, as
/// it’s not thread-safe to modify environment variables at runtime.
/// </para>
/// </summary>

/// <return>
/// a string owned by GLib that
///   must not be modified or freed.
/// </return>

	public static string GetUserStateDir()
	{
		return GLibGlobalFunctionsExterns.g_get_user_state_dir();
	}

/// <summary>
/// <para>
/// Returns the value of an environment variable.
/// </para>
/// <para>
/// On UNIX, the name and value are byte strings which might or might not
/// be in some consistent character set and encoding. On Windows, they are
/// in UTF-8.
/// On Windows, in case the environment variable&apos;s value contains
/// references to other environment variables, they are expanded.
/// </para>
/// </summary>

/// <param name="variable">
/// the environment variable to get
/// </param>
/// <return>
/// the value of the environment variable, or %NULL if
///     the environment variable is not found. The returned string
///     may be overwritten by the next call to g_getenv(), g_setenv()
///     or g_unsetenv().
/// </return>

	public static string Getenv(string variable)
	{
		return GLibGlobalFunctionsExterns.g_getenv(variable);
	}

/// <summary>
/// <para>
/// This is a convenience function for using a #GHashTable as a set.  It
/// is equivalent to calling g_hash_table_replace() with @key as both the
/// key and the value.
/// </para>
/// <para>
/// In particular, this means that if @key already exists in the hash table, then
/// the old copy of @key in the hash table is freed and @key replaces it in the
/// table.
/// </para>
/// <para>
/// When a hash table only ever contains keys that have themselves as the
/// corresponding value it is able to be stored more efficiently.  See
/// the discussion in the section description.
/// </para>
/// <para>
/// Starting from GLib 2.40, this function returns a boolean value to
/// indicate whether the newly added value was already in the hash table
/// or not.
/// </para>
/// </summary>

/// <param name="hash_table">
/// a #GHashTable
/// </param>
/// <param name="key">
/// a key to insert
/// </param>
/// <return>
/// %TRUE if the key did not exist yet
/// </return>

	public static bool HashTableAdd(MentorLake.GLib.GHashTableHandle hash_table, IntPtr key)
	{
		return GLibGlobalFunctionsExterns.g_hash_table_add(hash_table, key);
	}

/// <summary>
/// <para>
/// Checks if @key is in @hash_table.
/// </para>
/// </summary>

/// <param name="hash_table">
/// a #GHashTable
/// </param>
/// <param name="key">
/// a key to check
/// </param>
/// <return>
/// %TRUE if @key is in @hash_table, %FALSE otherwise.
/// </return>

	public static bool HashTableContains(MentorLake.GLib.GHashTableHandle hash_table, IntPtr key)
	{
		return GLibGlobalFunctionsExterns.g_hash_table_contains(hash_table, key);
	}

/// <summary>
/// <para>
/// Destroys all keys and values in the #GHashTable and decrements its
/// reference count by 1. If keys and/or values are dynamically allocated,
/// you should either free them first or create the #GHashTable with destroy
/// notifiers using g_hash_table_new_full(). In the latter case the destroy
/// functions you supplied will be called on all keys and values during the
/// destruction phase.
/// </para>
/// </summary>

/// <param name="hash_table">
/// a #GHashTable
/// </param>

	public static void HashTableDestroy(MentorLake.GLib.GHashTableHandle hash_table)
	{
		GLibGlobalFunctionsExterns.g_hash_table_destroy(hash_table);
	}

/// <summary>
/// <para>
/// Calls the given function for key/value pairs in the #GHashTable
/// until @predicate returns %TRUE. The function is passed the key
/// and value of each pair, and the given @user_data parameter. The
/// hash table may not be modified while iterating over it (you can&apos;t
/// add/remove items).
/// </para>
/// <para>
/// Note, that hash tables are really only optimized for forward
/// lookups, i.e. g_hash_table_lookup(). So code that frequently issues
/// g_hash_table_find() or g_hash_table_foreach() (e.g. in the order of
/// once per every entry in a hash table) should probably be reworked
/// to use additional or different data structures for reverse lookups
/// (keep in mind that an O(n) find/foreach operation issued for all n
/// values in a hash table ends up needing O(n*n) operations).
/// </para>
/// </summary>

/// <param name="hash_table">
/// a #GHashTable
/// </param>
/// <param name="predicate">
/// function to test the key/value pairs for a certain property
/// </param>
/// <param name="user_data">
/// user data to pass to the function
/// </param>
/// <return>
/// The value of the first key/value pair is returned,
///     for which @predicate evaluates to %TRUE. If no pair with the
///     requested property is found, %NULL is returned.
/// </return>

	public static IntPtr HashTableFind(MentorLake.GLib.GHashTableHandle hash_table, MentorLake.GLib.GHRFunc predicate, IntPtr user_data)
	{
		return GLibGlobalFunctionsExterns.g_hash_table_find(hash_table, predicate, user_data);
	}

/// <summary>
/// <para>
/// Calls the given function for each of the key/value pairs in the
/// #GHashTable.  The function is passed the key and value of each
/// pair, and the given @user_data parameter.  The hash table may not
/// be modified while iterating over it (you can&apos;t add/remove
/// items). To remove all items matching a predicate, use
/// g_hash_table_foreach_remove().
/// </para>
/// <para>
/// The order in which g_hash_table_foreach() iterates over the keys/values in
/// the hash table is not defined.
/// </para>
/// <para>
/// See g_hash_table_find() for performance caveats for linear
/// order searches in contrast to g_hash_table_lookup().
/// </para>
/// </summary>

/// <param name="hash_table">
/// a #GHashTable
/// </param>
/// <param name="func">
/// the function to call for each key/value pair
/// </param>
/// <param name="user_data">
/// user data to pass to the function
/// </param>

	public static void HashTableForeach(MentorLake.GLib.GHashTableHandle hash_table, MentorLake.GLib.GHFunc func, IntPtr user_data)
	{
		GLibGlobalFunctionsExterns.g_hash_table_foreach(hash_table, func, user_data);
	}

/// <summary>
/// <para>
/// Calls the given function for each key/value pair in the
/// #GHashTable. If the function returns %TRUE, then the key/value
/// pair is removed from the #GHashTable. If you supplied key or
/// value destroy functions when creating the #GHashTable, they are
/// used to free the memory allocated for the removed keys and values.
/// </para>
/// <para>
/// See #GHashTableIter for an alternative way to loop over the
/// key/value pairs in the hash table.
/// </para>
/// </summary>

/// <param name="hash_table">
/// a #GHashTable
/// </param>
/// <param name="func">
/// the function to call for each key/value pair
/// </param>
/// <param name="user_data">
/// user data to pass to the function
/// </param>
/// <return>
/// the number of key/value pairs removed
/// </return>

	public static uint HashTableForeachRemove(MentorLake.GLib.GHashTableHandle hash_table, MentorLake.GLib.GHRFunc func, IntPtr user_data)
	{
		return GLibGlobalFunctionsExterns.g_hash_table_foreach_remove(hash_table, func, user_data);
	}

/// <summary>
/// <para>
/// Calls the given function for each key/value pair in the
/// #GHashTable. If the function returns %TRUE, then the key/value
/// pair is removed from the #GHashTable, but no key or value
/// destroy functions are called.
/// </para>
/// <para>
/// See #GHashTableIter for an alternative way to loop over the
/// key/value pairs in the hash table.
/// </para>
/// </summary>

/// <param name="hash_table">
/// a #GHashTable
/// </param>
/// <param name="func">
/// the function to call for each key/value pair
/// </param>
/// <param name="user_data">
/// user data to pass to the function
/// </param>
/// <return>
/// the number of key/value pairs removed.
/// </return>

	public static uint HashTableForeachSteal(MentorLake.GLib.GHashTableHandle hash_table, MentorLake.GLib.GHRFunc func, IntPtr user_data)
	{
		return GLibGlobalFunctionsExterns.g_hash_table_foreach_steal(hash_table, func, user_data);
	}

/// <summary>
/// <para>
/// Retrieves every key inside @hash_table, as a #GPtrArray.
/// The returned data is valid until changes to the hash release those keys.
/// </para>
/// <para>
/// This iterates over every entry in the hash table to build its return value.
/// To iterate over the entries in a #GHashTable more efficiently, use a
/// #GHashTableIter.
/// </para>
/// <para>
/// You should always unref the returned array with g_ptr_array_unref().
/// </para>
/// </summary>

/// <param name="hash_table">
/// a #GHashTable
/// </param>
/// <return>
/// a #GPtrArray containing each key from
/// the table. Unref with with g_ptr_array_unref() when done.
/// </return>

	public static MentorLake.GLib.GPtrArrayHandle HashTableGetKeysAsPtrArray(MentorLake.GLib.GHashTableHandle hash_table)
	{
		return GLibGlobalFunctionsExterns.g_hash_table_get_keys_as_ptr_array(hash_table);
	}

/// <summary>
/// <para>
/// Retrieves every value inside @hash_table, as a #GPtrArray.
/// The returned data is valid until changes to the hash release those values.
/// </para>
/// <para>
/// This iterates over every entry in the hash table to build its return value.
/// To iterate over the entries in a #GHashTable more efficiently, use a
/// #GHashTableIter.
/// </para>
/// <para>
/// You should always unref the returned array with g_ptr_array_unref().
/// </para>
/// </summary>

/// <param name="hash_table">
/// a #GHashTable
/// </param>
/// <return>
/// a #GPtrArray containing each value from
/// the table. Unref with with g_ptr_array_unref() when done.
/// </return>

	public static MentorLake.GLib.GPtrArrayHandle HashTableGetValuesAsPtrArray(MentorLake.GLib.GHashTableHandle hash_table)
	{
		return GLibGlobalFunctionsExterns.g_hash_table_get_values_as_ptr_array(hash_table);
	}

/// <summary>
/// <para>
/// Inserts a new key and value into a #GHashTable.
/// </para>
/// <para>
/// If the key already exists in the #GHashTable its current
/// value is replaced with the new value. If you supplied a
/// @value_destroy_func when creating the #GHashTable, the old
/// value is freed using that function. If you supplied a
/// @key_destroy_func when creating the #GHashTable, the passed
/// key is freed using that function.
/// </para>
/// <para>
/// Starting from GLib 2.40, this function returns a boolean value to
/// indicate whether the newly added value was already in the hash table
/// or not.
/// </para>
/// </summary>

/// <param name="hash_table">
/// a #GHashTable
/// </param>
/// <param name="key">
/// a key to insert
/// </param>
/// <param name="value">
/// the value to associate with the key
/// </param>
/// <return>
/// %TRUE if the key did not exist yet
/// </return>

	public static bool HashTableInsert(MentorLake.GLib.GHashTableHandle hash_table, IntPtr key, IntPtr value)
	{
		return GLibGlobalFunctionsExterns.g_hash_table_insert(hash_table, key, value);
	}

/// <summary>
/// <para>
/// Looks up a key in a #GHashTable. Note that this function cannot
/// distinguish between a key that is not present and one which is present
/// and has the value %NULL. If you need this distinction, use
/// g_hash_table_lookup_extended().
/// </para>
/// </summary>

/// <param name="hash_table">
/// a #GHashTable
/// </param>
/// <param name="key">
/// the key to look up
/// </param>
/// <return>
/// the associated value, or %NULL if the key is not found
/// </return>

	public static IntPtr HashTableLookup(MentorLake.GLib.GHashTableHandle hash_table, IntPtr key)
	{
		return GLibGlobalFunctionsExterns.g_hash_table_lookup(hash_table, key);
	}

/// <summary>
/// <para>
/// Looks up a key in the #GHashTable, returning the original key and the
/// associated value and a #gboolean which is %TRUE if the key was found. This
/// is useful if you need to free the memory allocated for the original key,
/// for example before calling g_hash_table_remove().
/// </para>
/// <para>
/// You can actually pass %NULL for @lookup_key to test
/// whether the %NULL key exists, provided the hash and equal functions
/// of @hash_table are %NULL-safe.
/// </para>
/// </summary>

/// <param name="hash_table">
/// a #GHashTable
/// </param>
/// <param name="lookup_key">
/// the key to look up
/// </param>
/// <param name="orig_key">
/// return location for the original key
/// </param>
/// <param name="value">
/// return location for the value associated
/// with the key
/// </param>
/// <return>
/// %TRUE if the key was found in the #GHashTable
/// </return>

	public static bool HashTableLookupExtended(MentorLake.GLib.GHashTableHandle hash_table, IntPtr lookup_key, out IntPtr orig_key, out IntPtr value)
	{
		return GLibGlobalFunctionsExterns.g_hash_table_lookup_extended(hash_table, lookup_key, out orig_key, out value);
	}

/// <summary>
/// <para>
/// Creates a new #GHashTable like g_hash_table_new_full() with a reference
/// count of 1.
/// </para>
/// <para>
/// It inherits the hash function, the key equal function, the key destroy function,
/// as well as the value destroy function, from @other_hash_table.
/// </para>
/// <para>
/// The returned hash table will be empty; it will not contain the keys
/// or values from @other_hash_table.
/// </para>
/// </summary>

/// <param name="other_hash_table">
/// Another #GHashTable
/// </param>
/// <return>
/// a new #GHashTable
/// </return>

	public static MentorLake.GLib.GHashTableHandle HashTableNewSimilar(MentorLake.GLib.GHashTableHandle other_hash_table)
	{
		return GLibGlobalFunctionsExterns.g_hash_table_new_similar(other_hash_table);
	}

/// <summary>
/// <para>
/// Atomically increments the reference count of @hash_table by one.
/// This function is MT-safe and may be called from any thread.
/// </para>
/// </summary>

/// <param name="hash_table">
/// a valid #GHashTable
/// </param>
/// <return>
/// the passed in #GHashTable
/// </return>

	public static MentorLake.GLib.GHashTableHandle HashTableRef(MentorLake.GLib.GHashTableHandle hash_table)
	{
		return GLibGlobalFunctionsExterns.g_hash_table_ref(hash_table);
	}

/// <summary>
/// <para>
/// Removes a key and its associated value from a #GHashTable.
/// </para>
/// <para>
/// If the #GHashTable was created using g_hash_table_new_full(), the
/// key and value are freed using the supplied destroy functions, otherwise
/// you have to make sure that any dynamically allocated values are freed
/// yourself.
/// </para>
/// </summary>

/// <param name="hash_table">
/// a #GHashTable
/// </param>
/// <param name="key">
/// the key to remove
/// </param>
/// <return>
/// %TRUE if the key was found and removed from the #GHashTable
/// </return>

	public static bool HashTableRemove(MentorLake.GLib.GHashTableHandle hash_table, IntPtr key)
	{
		return GLibGlobalFunctionsExterns.g_hash_table_remove(hash_table, key);
	}

/// <summary>
/// <para>
/// Removes all keys and their associated values from a #GHashTable.
/// </para>
/// <para>
/// If the #GHashTable was created using g_hash_table_new_full(),
/// the keys and values are freed using the supplied destroy functions,
/// otherwise you have to make sure that any dynamically allocated
/// values are freed yourself.
/// </para>
/// </summary>

/// <param name="hash_table">
/// a #GHashTable
/// </param>

	public static void HashTableRemoveAll(MentorLake.GLib.GHashTableHandle hash_table)
	{
		GLibGlobalFunctionsExterns.g_hash_table_remove_all(hash_table);
	}

/// <summary>
/// <para>
/// Inserts a new key and value into a #GHashTable similar to
/// g_hash_table_insert(). The difference is that if the key
/// already exists in the #GHashTable, it gets replaced by the
/// new key. If you supplied a @value_destroy_func when creating
/// the #GHashTable, the old value is freed using that function.
/// If you supplied a @key_destroy_func when creating the
/// #GHashTable, the old key is freed using that function.
/// </para>
/// <para>
/// Starting from GLib 2.40, this function returns a boolean value to
/// indicate whether the newly added value was already in the hash table
/// or not.
/// </para>
/// </summary>

/// <param name="hash_table">
/// a #GHashTable
/// </param>
/// <param name="key">
/// a key to insert
/// </param>
/// <param name="value">
/// the value to associate with the key
/// </param>
/// <return>
/// %TRUE if the key did not exist yet
/// </return>

	public static bool HashTableReplace(MentorLake.GLib.GHashTableHandle hash_table, IntPtr key, IntPtr value)
	{
		return GLibGlobalFunctionsExterns.g_hash_table_replace(hash_table, key, value);
	}

/// <summary>
/// <para>
/// Returns the number of elements contained in the #GHashTable.
/// </para>
/// </summary>

/// <param name="hash_table">
/// a #GHashTable
/// </param>
/// <return>
/// the number of key/value pairs in the #GHashTable.
/// </return>

	public static uint HashTableSize(MentorLake.GLib.GHashTableHandle hash_table)
	{
		return GLibGlobalFunctionsExterns.g_hash_table_size(hash_table);
	}

/// <summary>
/// <para>
/// Removes a key and its associated value from a #GHashTable without
/// calling the key and value destroy functions.
/// </para>
/// </summary>

/// <param name="hash_table">
/// a #GHashTable
/// </param>
/// <param name="key">
/// the key to remove
/// </param>
/// <return>
/// %TRUE if the key was found and removed from the #GHashTable
/// </return>

	public static bool HashTableSteal(MentorLake.GLib.GHashTableHandle hash_table, IntPtr key)
	{
		return GLibGlobalFunctionsExterns.g_hash_table_steal(hash_table, key);
	}

/// <summary>
/// <para>
/// Removes all keys and their associated values from a #GHashTable
/// without calling the key and value destroy functions.
/// </para>
/// </summary>

/// <param name="hash_table">
/// a #GHashTable
/// </param>

	public static void HashTableStealAll(MentorLake.GLib.GHashTableHandle hash_table)
	{
		GLibGlobalFunctionsExterns.g_hash_table_steal_all(hash_table);
	}

/// <summary>
/// <para>
/// Removes all keys and their associated values from a #GHashTable
/// without calling the key destroy functions, returning the keys
/// as a #GPtrArray with the free func set to the @hash_table key
/// destroy function.
/// </para>
/// </summary>

/// <param name="hash_table">
/// a #GHashTable
/// </param>
/// <return>
/// a #GPtrArray containing each key of
/// the table. Unref with with g_ptr_array_unref() when done.
/// </return>

	public static MentorLake.GLib.GPtrArrayHandle HashTableStealAllKeys(MentorLake.GLib.GHashTableHandle hash_table)
	{
		return GLibGlobalFunctionsExterns.g_hash_table_steal_all_keys(hash_table);
	}

/// <summary>
/// <para>
/// Removes all keys and their associated values from a #GHashTable
/// without calling the value destroy functions, returning the values
/// as a #GPtrArray with the free func set to the @hash_table value
/// destroy function.
/// </para>
/// </summary>

/// <param name="hash_table">
/// a #GHashTable
/// </param>
/// <return>
/// a #GPtrArray containing each value of
/// the table. Unref with with g_ptr_array_unref() when done.
/// </return>

	public static MentorLake.GLib.GPtrArrayHandle HashTableStealAllValues(MentorLake.GLib.GHashTableHandle hash_table)
	{
		return GLibGlobalFunctionsExterns.g_hash_table_steal_all_values(hash_table);
	}

/// <summary>
/// <para>
/// Looks up a key in the #GHashTable, stealing the original key and the
/// associated value and returning %TRUE if the key was found. If the key was
/// not found, %FALSE is returned.
/// </para>
/// <para>
/// If found, the stolen key and value are removed from the hash table without
/// calling the key and value destroy functions, and ownership is transferred to
/// the caller of this method, as with g_hash_table_steal(). That is the case
/// regardless whether @stolen_key or @stolen_value output parameters are
/// requested.
/// </para>
/// <para>
/// You can pass %NULL for @lookup_key, provided the hash and equal functions
/// of @hash_table are %NULL-safe.
/// </para>
/// <para>
/// The dictionary implementation optimizes for having all values identical to
/// their keys, for example by using g_hash_table_add(). Before 2.82, when
/// stealing both the key and the value from such a dictionary, the value was
/// %NULL. Since 2.82, the returned value and key will be the same.
/// </para>
/// </summary>

/// <param name="hash_table">
/// a #GHashTable
/// </param>
/// <param name="lookup_key">
/// the key to look up
/// </param>
/// <param name="stolen_key">
/// return location for the
///    original key
/// </param>
/// <param name="stolen_value">
/// return location
///    for the value associated with the key
/// </param>
/// <return>
/// %TRUE if the key was found in the #GHashTable
/// </return>

	public static bool HashTableStealExtended(MentorLake.GLib.GHashTableHandle hash_table, IntPtr lookup_key, out IntPtr stolen_key, out IntPtr stolen_value)
	{
		return GLibGlobalFunctionsExterns.g_hash_table_steal_extended(hash_table, lookup_key, out stolen_key, out stolen_value);
	}

/// <summary>
/// <para>
/// Atomically decrements the reference count of @hash_table by one.
/// If the reference count drops to 0, all keys and values will be
/// destroyed, and all memory allocated by the hash table is released.
/// This function is MT-safe and may be called from any thread.
/// </para>
/// </summary>

/// <param name="hash_table">
/// a valid #GHashTable
/// </param>

	public static void HashTableUnref(MentorLake.GLib.GHashTableHandle hash_table)
	{
		GLibGlobalFunctionsExterns.g_hash_table_unref(hash_table);
	}

/// <summary>
/// <para>
/// Destroys a #GHook, given its ID.
/// </para>
/// </summary>

/// <param name="hook_list">
/// a #GHookList
/// </param>
/// <param name="hook_id">
/// a hook ID
/// </param>
/// <return>
/// %TRUE if the #GHook was found in the #GHookList and destroyed
/// </return>

	public static bool HookDestroy(MentorLake.GLib.GHookListHandle hook_list, ulong hook_id)
	{
		return GLibGlobalFunctionsExterns.g_hook_destroy(hook_list, hook_id);
	}

/// <summary>
/// <para>
/// Removes one #GHook from a #GHookList, marking it
/// inactive and calling g_hook_unref() on it.
/// </para>
/// </summary>

/// <param name="hook_list">
/// a #GHookList
/// </param>
/// <param name="hook">
/// the #GHook to remove
/// </param>

	public static void HookDestroyLink(MentorLake.GLib.GHookListHandle hook_list, MentorLake.GLib.GHookHandle hook)
	{
		GLibGlobalFunctionsExterns.g_hook_destroy_link(hook_list, hook);
	}

/// <summary>
/// <para>
/// Calls the #GHookList @finalize_hook function if it exists,
/// and frees the memory allocated for the #GHook.
/// </para>
/// </summary>

/// <param name="hook_list">
/// a #GHookList
/// </param>
/// <param name="hook">
/// the #GHook to free
/// </param>

	public static void HookFree(MentorLake.GLib.GHookListHandle hook_list, MentorLake.GLib.GHookHandle hook)
	{
		GLibGlobalFunctionsExterns.g_hook_free(hook_list, hook);
	}

/// <summary>
/// <para>
/// Inserts a #GHook into a #GHookList, before a given #GHook.
/// </para>
/// </summary>

/// <param name="hook_list">
/// a #GHookList
/// </param>
/// <param name="sibling">
/// the #GHook to insert the new #GHook before
/// </param>
/// <param name="hook">
/// the #GHook to insert
/// </param>

	public static void HookInsertBefore(MentorLake.GLib.GHookListHandle hook_list, MentorLake.GLib.GHookHandle sibling, MentorLake.GLib.GHookHandle hook)
	{
		GLibGlobalFunctionsExterns.g_hook_insert_before(hook_list, sibling, hook);
	}

/// <summary>
/// <para>
/// Inserts a #GHook into a #GHookList, sorted by the given function.
/// </para>
/// </summary>

/// <param name="hook_list">
/// a #GHookList
/// </param>
/// <param name="hook">
/// the #GHook to insert
/// </param>
/// <param name="func">
/// the comparison function used to sort the #GHook elements
/// </param>

	public static void HookInsertSorted(MentorLake.GLib.GHookListHandle hook_list, MentorLake.GLib.GHookHandle hook, MentorLake.GLib.GHookCompareFunc func)
	{
		GLibGlobalFunctionsExterns.g_hook_insert_sorted(hook_list, hook, func);
	}

/// <summary>
/// <para>
/// Prepends a #GHook on the start of a #GHookList.
/// </para>
/// </summary>

/// <param name="hook_list">
/// a #GHookList
/// </param>
/// <param name="hook">
/// the #GHook to add to the start of @hook_list
/// </param>

	public static void HookPrepend(MentorLake.GLib.GHookListHandle hook_list, MentorLake.GLib.GHookHandle hook)
	{
		GLibGlobalFunctionsExterns.g_hook_prepend(hook_list, hook);
	}

/// <summary>
/// <para>
/// Decrements the reference count of a #GHook.
/// If the reference count falls to 0, the #GHook is removed
/// from the #GHookList and g_hook_free() is called to free it.
/// </para>
/// </summary>

/// <param name="hook_list">
/// a #GHookList
/// </param>
/// <param name="hook">
/// the #GHook to unref
/// </param>

	public static void HookUnref(MentorLake.GLib.GHookListHandle hook_list, MentorLake.GLib.GHookHandle hook)
	{
		GLibGlobalFunctionsExterns.g_hook_unref(hook_list, hook);
	}

/// <summary>
/// <para>
/// Tests if @hostname contains segments with an ASCII-compatible
/// encoding of an Internationalized Domain Name. If this returns
/// %TRUE, you should decode the hostname with g_hostname_to_unicode()
/// before displaying it to the user.
/// </para>
/// <para>
/// Note that a hostname might contain a mix of encoded and unencoded
/// segments, and so it is possible for g_hostname_is_non_ascii() and
/// g_hostname_is_ascii_encoded() to both return %TRUE for a name.
/// </para>
/// </summary>

/// <param name="hostname">
/// a hostname
/// </param>
/// <return>
/// %TRUE if @hostname contains any ASCII-encoded
/// segments.
/// </return>

	public static bool HostnameIsAsciiEncoded(string hostname)
	{
		return GLibGlobalFunctionsExterns.g_hostname_is_ascii_encoded(hostname);
	}

/// <summary>
/// <para>
/// Tests if @hostname is the string form of an IPv4 or IPv6 address.
/// (Eg, &quot;192.168.0.1&quot;.)
/// </para>
/// <para>
/// Since 2.66, IPv6 addresses with a zone-id are accepted (RFC6874).
/// </para>
/// </summary>

/// <param name="hostname">
/// a hostname (or IP address in string form)
/// </param>
/// <return>
/// %TRUE if @hostname is an IP address
/// </return>

	public static bool HostnameIsIpAddress(string hostname)
	{
		return GLibGlobalFunctionsExterns.g_hostname_is_ip_address(hostname);
	}

/// <summary>
/// <para>
/// Tests if @hostname contains Unicode characters. If this returns
/// %TRUE, you need to encode the hostname with g_hostname_to_ascii()
/// before using it in non-IDN-aware contexts.
/// </para>
/// <para>
/// Note that a hostname might contain a mix of encoded and unencoded
/// segments, and so it is possible for g_hostname_is_non_ascii() and
/// g_hostname_is_ascii_encoded() to both return %TRUE for a name.
/// </para>
/// </summary>

/// <param name="hostname">
/// a hostname
/// </param>
/// <return>
/// %TRUE if @hostname contains any non-ASCII characters
/// </return>

	public static bool HostnameIsNonAscii(string hostname)
	{
		return GLibGlobalFunctionsExterns.g_hostname_is_non_ascii(hostname);
	}

/// <summary>
/// <para>
/// Converts @hostname to its canonical ASCII form; an ASCII-only
/// string containing no uppercase letters and not ending with a
/// trailing dot.
/// </para>
/// </summary>

/// <param name="hostname">
/// a valid UTF-8 or ASCII hostname
/// </param>
/// <return>
/// an ASCII hostname, which must be freed,
///    or %NULL if @hostname is in some way invalid.
/// </return>

	public static string HostnameToAscii(string hostname)
	{
		return GLibGlobalFunctionsExterns.g_hostname_to_ascii(hostname);
	}

/// <summary>
/// <para>
/// Converts @hostname to its canonical presentation form; a UTF-8
/// string in Unicode normalization form C, containing no uppercase
/// letters, no forbidden characters, and no ASCII-encoded segments,
/// and not ending with a trailing dot.
/// </para>
/// <para>
/// Of course if @hostname is not an internationalized hostname, then
/// the canonical presentation form will be entirely ASCII.
/// </para>
/// </summary>

/// <param name="hostname">
/// a valid UTF-8 or ASCII hostname
/// </param>
/// <return>
/// a UTF-8 hostname, which must be freed,
///    or %NULL if @hostname is in some way invalid.
/// </return>

	public static string HostnameToUnicode(string hostname)
	{
		return GLibGlobalFunctionsExterns.g_hostname_to_unicode(hostname);
	}

/// <summary>
/// <para>
/// Same as the standard UNIX routine iconv(), but
/// may be implemented via libiconv on UNIX flavors that lack
/// a native implementation.
/// </para>
/// <para>
/// GLib provides g_convert() and g_locale_to_utf8() which are likely
/// more convenient than the raw iconv wrappers.
/// </para>
/// <para>
/// Note that the behaviour of iconv() for characters which are valid in the
/// input character set, but which have no representation in the output character
/// set, is implementation defined. This function may return success (with a
/// positive number of non-reversible conversions as replacement characters were
/// used), or it may return -1 and set an error such as %EILSEQ, in such a
/// situation.
/// </para>
/// </summary>

/// <param name="converter">
/// conversion descriptor from g_iconv_open()
/// </param>
/// <param name="inbuf">
/// bytes to convert
/// </param>
/// <param name="inbytes_left">
/// inout parameter, bytes remaining to convert in @inbuf
/// </param>
/// <param name="outbuf">
/// converted output bytes
/// </param>
/// <param name="outbytes_left">
/// inout parameter, bytes available to fill in @outbuf
/// </param>
/// <return>
/// count of non-reversible conversions, or -1 on error
/// </return>

	public static UIntPtr Iconv(MentorLake.GLib.GIConv converter, string inbuf, ref UIntPtr inbytes_left, string outbuf, ref UIntPtr outbytes_left)
	{
		return GLibGlobalFunctionsExterns.g_iconv(converter, inbuf, ref inbytes_left, outbuf, ref outbytes_left);
	}

/// <summary>
/// <para>
/// Same as the standard UNIX routine iconv_open(), but
/// may be implemented via libiconv on UNIX flavors that lack
/// a native implementation.
/// </para>
/// <para>
/// GLib provides g_convert() and g_locale_to_utf8() which are likely
/// more convenient than the raw iconv wrappers.
/// </para>
/// </summary>

/// <param name="to_codeset">
/// destination codeset
/// </param>
/// <param name="from_codeset">
/// source codeset
/// </param>
/// <return>
/// a &quot;conversion descriptor&quot;, or (GIConv)-1 if
///  opening the converter failed.
/// </return>

	public static MentorLake.GLib.GIConv IconvOpen(string to_codeset, string from_codeset)
	{
		return GLibGlobalFunctionsExterns.g_iconv_open(to_codeset, from_codeset);
	}

/// <summary>
/// <para>
/// Adds a function to be called whenever there are no higher priority
/// events pending to the default main loop. The function is given the
/// default idle priority, [const@GLib.PRIORITY_DEFAULT_IDLE].  If the function
/// returns %FALSE it is automatically removed from the list of event
/// sources and will not be called again.
/// </para>
/// <para>
/// See [mainloop memory management](main-loop.html#memory-management-of-sources) for details
/// on how to handle the return value and memory management of @data.
/// </para>
/// <para>
/// This internally creates a main loop source using [func@GLib.idle_source_new]
/// and attaches it to the global [struct@GLib.MainContext] using
/// [method@GLib.Source.attach], so the callback will be invoked in whichever
/// thread is running that main context. You can do these steps manually if you
/// need greater control or to use a custom main context.
/// </para>
/// </summary>

/// <param name="function">
/// function to call
/// </param>
/// <param name="data">
/// data to pass to @function.
/// </param>
/// <return>
/// the ID (greater than 0) of the event source.
/// </return>

	public static uint IdleAdd(MentorLake.GLib.GSourceFunc function, IntPtr data)
	{
		return GLibGlobalFunctionsExterns.g_idle_add(function, data);
	}

/// <summary>
/// <para>
/// Adds a function to be called whenever there are no higher priority
/// events pending.
/// </para>
/// <para>
/// If the function returns [const@GLib.SOURCE_REMOVE] or %FALSE it is automatically
/// removed from the list of event sources and will not be called again.
/// </para>
/// <para>
/// See [mainloop memory management](main-loop.html#memory-management-of-sources) for details
/// on how to handle the return value and memory management of @data.
/// </para>
/// <para>
/// This internally creates a main loop source using [func@GLib.idle_source_new]
/// and attaches it to the global [struct@GLib.MainContext] using
/// [method@GLib.Source.attach], so the callback will be invoked in whichever
/// thread is running that main context. You can do these steps manually if you
/// need greater control or to use a custom main context.
/// </para>
/// </summary>

/// <param name="priority">
/// the priority of the idle source. Typically this will be in the
///   range between [const@GLib.PRIORITY_DEFAULT_IDLE] and
///   [const@GLib.PRIORITY_HIGH_IDLE].
/// </param>
/// <param name="function">
/// function to call
/// </param>
/// <param name="data">
/// data to pass to @function
/// </param>
/// <param name="notify">
/// function to call when the idle is removed, or %NULL
/// </param>
/// <return>
/// the ID (greater than 0) of the event source.
/// </return>

	public static uint IdleAddFull(int priority, MentorLake.GLib.GSourceFunc function, IntPtr data, MentorLake.GLib.GDestroyNotify notify)
	{
		return GLibGlobalFunctionsExterns.g_idle_add_full(priority, function, data, notify);
	}

/// <summary>
/// <para>
/// Adds a function to be called whenever there are no higher priority
/// events pending to the default main loop. The function is given the
/// default idle priority, [const@GLib.PRIORITY_DEFAULT_IDLE].
/// </para>
/// <para>
/// The function will only be called once and then the source will be
/// automatically removed from the main context.
/// </para>
/// <para>
/// This function otherwise behaves like [func@GLib.idle_add].
/// </para>
/// </summary>

/// <param name="function">
/// function to call
/// </param>
/// <param name="data">
/// data to pass to @function
/// </param>
/// <return>
/// the ID (greater than 0) of the event source
/// </return>

	public static uint IdleAddOnce(MentorLake.GLib.GSourceOnceFunc function, IntPtr data)
	{
		return GLibGlobalFunctionsExterns.g_idle_add_once(function, data);
	}

/// <summary>
/// <para>
/// Removes the idle function with the given data.
/// </para>
/// </summary>

/// <param name="data">
/// the data for the idle source&apos;s callback.
/// </param>
/// <return>
/// %TRUE if an idle source was found and removed.
/// </return>

	public static bool IdleRemoveByData(IntPtr data)
	{
		return GLibGlobalFunctionsExterns.g_idle_remove_by_data(data);
	}

/// <summary>
/// <para>
/// Creates a new idle source.
/// </para>
/// <para>
/// The source will not initially be associated with any
/// [struct@GLib.MainContext] and must be added to one with
/// [method@GLib.Source.attach] before it will be executed. Note that the
/// default priority for idle sources is [const@GLib.PRIORITY_DEFAULT_IDLE], as
/// compared to other sources which have a default priority of
/// [const@GLib.PRIORITY_DEFAULT].
/// </para>
/// </summary>

/// <return>
/// the newly-created idle source
/// </return>

	public static MentorLake.GLib.GSourceHandle IdleSourceNew()
	{
		return GLibGlobalFunctionsExterns.g_idle_source_new();
	}

/// <summary>
/// <para>
/// Compares the two #gint64 values being pointed to and returns
/// %TRUE if they are equal.
/// It can be passed to g_hash_table_new() as the @key_equal_func
/// parameter, when using non-%NULL pointers to 64-bit integers as keys in a
/// #GHashTable.
/// </para>
/// </summary>

/// <param name="v1">
/// a pointer to a #gint64 key
/// </param>
/// <param name="v2">
/// a pointer to a #gint64 key to compare with @v1
/// </param>
/// <return>
/// %TRUE if the two keys match.
/// </return>

	public static bool Int64Equal(IntPtr v1, IntPtr v2)
	{
		return GLibGlobalFunctionsExterns.g_int64_equal(v1, v2);
	}

/// <summary>
/// <para>
/// Converts a pointer to a #gint64 to a hash value.
/// </para>
/// <para>
/// It can be passed to g_hash_table_new() as the @hash_func parameter,
/// when using non-%NULL pointers to 64-bit integer values as keys in a
/// #GHashTable.
/// </para>
/// </summary>

/// <param name="v">
/// a pointer to a #gint64 key
/// </param>
/// <return>
/// a hash value corresponding to the key.
/// </return>

	public static uint Int64Hash(IntPtr v)
	{
		return GLibGlobalFunctionsExterns.g_int64_hash(v);
	}

/// <summary>
/// <para>
/// Compares the two #gint values being pointed to and returns
/// %TRUE if they are equal.
/// It can be passed to g_hash_table_new() as the @key_equal_func
/// parameter, when using non-%NULL pointers to integers as keys in a
/// #GHashTable.
/// </para>
/// <para>
/// Note that this function acts on pointers to #gint, not on #gint
/// directly: if your hash table&apos;s keys are of the form
/// `GINT_TO_POINTER (n)`, use g_direct_equal() instead.
/// </para>
/// </summary>

/// <param name="v1">
/// a pointer to a #gint key
/// </param>
/// <param name="v2">
/// a pointer to a #gint key to compare with @v1
/// </param>
/// <return>
/// %TRUE if the two keys match.
/// </return>

	public static bool IntEqual(IntPtr v1, IntPtr v2)
	{
		return GLibGlobalFunctionsExterns.g_int_equal(v1, v2);
	}

/// <summary>
/// <para>
/// Converts a pointer to a #gint to a hash value.
/// It can be passed to g_hash_table_new() as the @hash_func parameter,
/// when using non-%NULL pointers to integer values as keys in a #GHashTable.
/// </para>
/// <para>
/// Note that this function acts on pointers to #gint, not on #gint
/// directly: if your hash table&apos;s keys are of the form
/// `GINT_TO_POINTER (n)`, use g_direct_hash() instead.
/// </para>
/// </summary>

/// <param name="v">
/// a pointer to a #gint key
/// </param>
/// <return>
/// a hash value corresponding to the key.
/// </return>

	public static uint IntHash(IntPtr v)
	{
		return GLibGlobalFunctionsExterns.g_int_hash(v);
	}

/// <summary>
/// <para>
/// Returns a canonical representation for @string. Interned strings
/// can be compared for equality by comparing the pointers, instead of
/// using strcmp(). g_intern_static_string() does not copy the string,
/// therefore @string must not be freed or modified.
/// </para>
/// <para>
/// This function must not be used before library constructors have finished
/// running. In particular, this means it cannot be used to initialize global
/// variables in C++.
/// </para>
/// </summary>

/// <param name="@string">
/// a static string
/// </param>
/// <return>
/// a canonical representation for the string
/// </return>

	public static string InternStaticString(string @string)
	{
		return GLibGlobalFunctionsExterns.g_intern_static_string(@string);
	}

/// <summary>
/// <para>
/// Returns a canonical representation for @string. Interned strings
/// can be compared for equality by comparing the pointers, instead of
/// using strcmp().
/// </para>
/// <para>
/// This function must not be used before library constructors have finished
/// running. In particular, this means it cannot be used to initialize global
/// variables in C++.
/// </para>
/// </summary>

/// <param name="@string">
/// a string
/// </param>
/// <return>
/// a canonical representation for the string
/// </return>

	public static string InternString(string @string)
	{
		return GLibGlobalFunctionsExterns.g_intern_string(@string);
	}

/// <summary>
/// <para>
/// Adds the #GIOChannel into the default main loop context
/// with the default priority.
/// </para>
/// </summary>

/// <param name="channel">
/// a #GIOChannel
/// </param>
/// <param name="condition">
/// the condition to watch for
/// </param>
/// <param name="func">
/// the function to call when the condition is satisfied
/// </param>
/// <param name="user_data">
/// user data to pass to @func
/// </param>
/// <return>
/// the event source id
/// </return>

	public static uint IoAddWatch(MentorLake.GLib.GIOChannelHandle channel, MentorLake.GLib.GIOCondition condition, MentorLake.GLib.GIOFunc func, IntPtr user_data)
	{
		return GLibGlobalFunctionsExterns.g_io_add_watch(channel, condition, func, user_data);
	}

/// <summary>
/// <para>
/// Adds the #GIOChannel into the default main loop context
/// with the given priority.
/// </para>
/// <para>
/// This internally creates a main loop source using g_io_create_watch()
/// and attaches it to the main loop context with g_source_attach().
/// You can do these steps manually if you need greater control.
/// </para>
/// </summary>

/// <param name="channel">
/// a #GIOChannel
/// </param>
/// <param name="priority">
/// the priority of the #GIOChannel source
/// </param>
/// <param name="condition">
/// the condition to watch for
/// </param>
/// <param name="func">
/// the function to call when the condition is satisfied
/// </param>
/// <param name="user_data">
/// user data to pass to @func
/// </param>
/// <param name="notify">
/// the function to call when the source is removed
/// </param>
/// <return>
/// the event source id
/// </return>

	public static uint IoAddWatchFull(MentorLake.GLib.GIOChannelHandle channel, int priority, MentorLake.GLib.GIOCondition condition, MentorLake.GLib.GIOFunc func, IntPtr user_data, MentorLake.GLib.GDestroyNotify notify)
	{
		return GLibGlobalFunctionsExterns.g_io_add_watch_full(channel, priority, condition, func, user_data, notify);
	}

/// <summary>
/// <para>
/// Converts an `errno` error number to a #GIOChannelError.
/// </para>
/// </summary>

/// <param name="en">
/// an `errno` error number, e.g. `EINVAL`
/// </param>
/// <return>
/// a #GIOChannelError error number, e.g.
///      %G_IO_CHANNEL_ERROR_INVAL.
/// </return>

	public static MentorLake.GLib.GIOChannelError IoChannelErrorFromErrno(int en)
	{
		return GLibGlobalFunctionsExterns.g_io_channel_error_from_errno(en);
	}



	public static MentorLake.GLib.GQuark IoChannelErrorQuark()
	{
		return GLibGlobalFunctionsExterns.g_io_channel_error_quark();
	}

/// <summary>
/// <para>
/// Creates a #GSource that&apos;s dispatched when @condition is met for the
/// given @channel. For example, if condition is %G_IO_IN, the source will
/// be dispatched when there&apos;s data available for reading.
/// </para>
/// <para>
/// The callback function invoked by the #GSource should be added with
/// g_source_set_callback(), but it has type #GIOFunc (not #GSourceFunc).
/// </para>
/// <para>
/// g_io_add_watch() is a simpler interface to this same functionality, for
/// the case where you want to add the source to the default main loop context
/// at the default priority.
/// </para>
/// <para>
/// On Windows, polling a #GSource created to watch a channel for a socket
/// puts the socket in non-blocking mode. This is a side-effect of the
/// implementation and unavoidable.
/// </para>
/// </summary>

/// <param name="channel">
/// a #GIOChannel to watch
/// </param>
/// <param name="condition">
/// conditions to watch for
/// </param>
/// <return>
/// a new #GSource
/// </return>

	public static MentorLake.GLib.GSourceHandle IoCreateWatch(MentorLake.GLib.GIOChannelHandle channel, MentorLake.GLib.GIOCondition condition)
	{
		return GLibGlobalFunctionsExterns.g_io_create_watch(channel, condition);
	}



	public static MentorLake.GLib.GQuark KeyFileErrorQuark()
	{
		return GLibGlobalFunctionsExterns.g_key_file_error_quark();
	}



	public static void ListPopAllocator()
	{
		GLibGlobalFunctionsExterns.g_list_pop_allocator();
	}


/// <param name="allocator">
/// </param>

	public static void ListPushAllocator(MentorLake.GLib.GAllocatorHandle allocator)
	{
		GLibGlobalFunctionsExterns.g_list_push_allocator(allocator);
	}

/// <summary>
/// <para>
/// Gets the names of all variables set in the environment.
/// </para>
/// <para>
/// Programs that want to be portable to Windows should typically use
/// this function and g_getenv() instead of using the environ array
/// from the C library directly. On Windows, the strings in the environ
/// array are in system codepage encoding, while in most of the typical
/// use cases for environment variables in GLib-using programs you want
/// the UTF-8 encoding that this function and g_getenv() provide.
/// </para>
/// </summary>

/// <return>
/// 
///     a %NULL-terminated list of strings which must be freed with
///     g_strfreev().
/// </return>

	public static string[] Listenv()
	{
		return GLibGlobalFunctionsExterns.g_listenv();
	}

/// <summary>
/// <para>
/// Converts a string from UTF-8 to the encoding used for strings by
/// the C runtime (usually the same as that used by the operating
/// system) in the [current locale][setlocale]. On Windows this means
/// the system codepage.
/// </para>
/// <para>
/// The input string shall not contain nul characters even if the @len
/// argument is positive. A nul character found inside the string will result
/// in error %G_CONVERT_ERROR_ILLEGAL_SEQUENCE. Use g_convert() to convert
/// input that may contain embedded nul characters.
/// </para>
/// </summary>

/// <param name="utf8string">
/// a UTF-8 encoded string
/// </param>
/// <param name="len">
/// the length of the string, or -1 if the string is
///                 nul-terminated.
/// </param>
/// <param name="bytes_read">
/// location to store the number of bytes in the
///                 input string that were successfully converted, or %NULL.
///                 Even if the conversion was successful, this may be
///                 less than @len if there were partial characters
///                 at the end of the input. If the error
///                 %G_CONVERT_ERROR_ILLEGAL_SEQUENCE occurs, the value
///                 stored will be the byte offset after the last valid
///                 input sequence.
/// </param>
/// <param name="bytes_written">
/// the number of bytes stored in the output
///                 buffer (not including the terminating nul).
/// </param>
/// <return>
/// 
///          A newly-allocated buffer containing the converted string,
///          or %NULL on an error, and error will be set.
/// </return>

	public static byte[] LocaleFromUtf8(string utf8string, UIntPtr len, out UIntPtr bytes_read, out UIntPtr bytes_written)
	{
		var externCallResult = GLibGlobalFunctionsExterns.g_locale_from_utf8(utf8string, len, out bytes_read, out bytes_written, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Converts a string which is in the encoding used for strings by
/// the C runtime (usually the same as that used by the operating
/// system) in the [current locale][setlocale] into a UTF-8 string.
/// </para>
/// <para>
/// If the source encoding is not UTF-8 and the conversion output contains a
/// nul character, the error %G_CONVERT_ERROR_EMBEDDED_NUL is set and the
/// function returns %NULL.
/// If the source encoding is UTF-8, an embedded nul character is treated with
/// the %G_CONVERT_ERROR_ILLEGAL_SEQUENCE error for backward compatibility with
/// earlier versions of this library. Use g_convert() to produce output that
/// may contain embedded nul characters.
/// </para>
/// </summary>

/// <param name="opsysstring">
/// a string in the
///                 encoding of the current locale. On Windows
///                 this means the system codepage.
/// </param>
/// <param name="len">
/// the length of the string, or -1 if the string is
///                 nul-terminated (Note that some encodings may allow nul
///                 bytes to occur inside strings. In that case, using -1
///                 for the @len parameter is unsafe)
/// </param>
/// <param name="bytes_read">
/// location to store the number of bytes in the
///                 input string that were successfully converted, or %NULL.
///                 Even if the conversion was successful, this may be
///                 less than @len if there were partial characters
///                 at the end of the input. If the error
///                 %G_CONVERT_ERROR_ILLEGAL_SEQUENCE occurs, the value
///                 stored will be the byte offset after the last valid
///                 input sequence.
/// </param>
/// <param name="bytes_written">
/// the number of bytes stored in the output
///                 buffer (not including the terminating nul).
/// </param>
/// <return>
/// The converted string, or %NULL on an error.
/// </return>

	public static string LocaleToUtf8(byte[] opsysstring, UIntPtr len, out UIntPtr bytes_read, out UIntPtr bytes_written)
	{
		var externCallResult = GLibGlobalFunctionsExterns.g_locale_to_utf8(opsysstring, len, out bytes_read, out bytes_written, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Logs an error or debugging message.
/// </para>
/// <para>
/// If the log level has been set as fatal, [func@GLib.BREAKPOINT] is called
/// to terminate the program. See the documentation for [func@GLib.BREAKPOINT] for
/// details of the debugging options this provides.
/// </para>
/// <para>
/// If [func@GLib.log_default_handler] is used as the log handler function, a new-line
/// character will automatically be appended to @..., and need not be entered
/// manually.
/// </para>
/// <para>
/// If [structured logging is enabled](logging.html#using-structured-logging) this will
/// output via the structured log writer function (see [func@GLib.log_set_writer_func]).
/// </para>
/// </summary>

/// <param name="log_domain">
/// the log domain, usually `G_LOG_DOMAIN`, or `NULL`
///   for the default
/// </param>
/// <param name="log_level">
/// the log level, either from [type@GLib.LogLevelFlags]
///   or a user-defined level
/// </param>
/// <param name="format">
/// the message format. See the `printf()` documentation
/// </param>
/// <param name="@__arglist">
/// the parameters to insert into the format string
/// </param>

	public static void Log(string log_domain, MentorLake.GLib.GLogLevelFlags log_level, string format, IntPtr @__arglist)
	{
		GLibGlobalFunctionsExterns.g_log(log_domain, log_level, format, @__arglist);
	}

/// <summary>
/// <para>
/// The default log handler set up by GLib; [func@GLib.log_set_default_handler]
/// allows to install an alternate default log handler.
/// </para>
/// <para>
/// This is used if no log handler has been set for the particular log
/// domain and log level combination. It outputs the message to `stderr`
/// or `stdout` and if the log level is fatal it calls [func@GLib.BREAKPOINT]. It automatically
/// prints a new-line character after the message, so one does not need to be
/// manually included in @message.
/// </para>
/// <para>
/// The behavior of this log handler can be influenced by a number of
/// environment variables:
/// </para>
/// <para>
///   - `G_MESSAGES_PREFIXED`: A `:`-separated list of log levels for which
///     messages should be prefixed by the program name and PID of the
///     application.
///   - `G_MESSAGES_DEBUG`: A space-separated list of log domains for
///     which debug and informational messages are printed. By default
///     these messages are not printed. If you need to set the allowed
///     domains at runtime, use [func@GLib.log_writer_default_set_debug_domains].
///   - `DEBUG_INVOCATION`: If set to `1`, this is equivalent to
///     `G_MESSAGES_DEBUG=all`. `DEBUG_INVOCATION` is a standard environment
///     variable set by systemd to prompt debug output. (Since: 2.84)
/// </para>
/// <para>
/// `stderr` is used for levels [flags@GLib.LogLevelFlags.LEVEL_ERROR],
/// [flags@GLib.LogLevelFlags.LEVEL_CRITICAL], [flags@GLib.LogLevelFlags.LEVEL_WARNING] and
/// [flags@GLib.LogLevelFlags.LEVEL_MESSAGE]. `stdout` is used for
/// the rest, unless `stderr` was requested by
/// [func@GLib.log_writer_default_set_use_stderr].
/// </para>
/// <para>
/// This has no effect if structured logging is enabled; see
/// [Using Structured Logging](logging.html#using-structured-logging).
/// </para>
/// </summary>

/// <param name="log_domain">
/// the log domain of the message, or `NULL` for the
///   default `&quot;&quot;` application domain
/// </param>
/// <param name="log_level">
/// the level of the message
/// </param>
/// <param name="message">
/// the message
/// </param>
/// <param name="unused_data">
/// data passed from [func@GLib.log] which is unused
/// </param>

	public static void LogDefaultHandler(string log_domain, MentorLake.GLib.GLogLevelFlags log_level, string message, IntPtr unused_data)
	{
		GLibGlobalFunctionsExterns.g_log_default_handler(log_domain, log_level, message, unused_data);
	}

/// <summary>
/// <para>
/// Return whether debug output from the GLib logging system is enabled.
/// </para>
/// <para>
/// Note that this should not be used to conditionalise calls to [func@GLib.debug] or
/// other logging functions; it should only be used from [type@GLib.LogWriterFunc]
/// implementations.
/// </para>
/// <para>
/// Note also that the value of this does not depend on `G_MESSAGES_DEBUG`, nor
/// `DEBUG_INVOCATION`, nor [func@GLib.log_writer_default_set_debug_domains]; see
/// the docs for [func@GLib.log_set_debug_enabled].
/// </para>
/// </summary>

/// <return>
/// `TRUE` if debug output is enabled, `FALSE` otherwise
/// </return>

	public static bool LogGetDebugEnabled()
	{
		return GLibGlobalFunctionsExterns.g_log_get_debug_enabled();
	}

/// <summary>
/// <para>
/// Removes the log handler.
/// </para>
/// <para>
/// This has no effect if structured logging is enabled; see
/// [Using Structured Logging](logging.html#using-structured-logging).
/// </para>
/// </summary>

/// <param name="log_domain">
/// the log domain
/// </param>
/// <param name="handler_id">
/// the ID of the handler, which was returned
///   in [func@GLib.log_set_handler]
/// </param>

	public static void LogRemoveHandler(string log_domain, uint handler_id)
	{
		GLibGlobalFunctionsExterns.g_log_remove_handler(log_domain, handler_id);
	}

/// <summary>
/// <para>
/// Sets the message levels which are always fatal, in any log domain.
/// </para>
/// <para>
/// When a message with any of these levels is logged the program terminates.
/// You can only set the levels defined by GLib to be fatal.
/// [flags@GLib.LogLevelFlags.LEVEL_ERROR] is always fatal.
/// </para>
/// <para>
/// You can also make some message levels fatal at runtime by setting
/// the `G_DEBUG` environment variable (see
/// [Running GLib Applications](glib-running.html)).
/// </para>
/// <para>
/// Libraries should not call this function, as it affects all messages logged
/// by a process, including those from other libraries.
/// </para>
/// <para>
/// Structured log messages (using [func@GLib.log_structured] and
/// [func@GLib.log_structured_array]) are fatal only if the default log writer is used;
/// otherwise it is up to the writer function to determine which log messages
/// are fatal. See [Using Structured Logging](logging.html#using-structured-logging).
/// </para>
/// </summary>

/// <param name="fatal_mask">
/// the mask containing bits set for each level of error which is
///   to be fatal
/// </param>
/// <return>
/// the old fatal mask
/// </return>

	public static MentorLake.GLib.GLogLevelFlags LogSetAlwaysFatal(MentorLake.GLib.GLogLevelFlags fatal_mask)
	{
		return GLibGlobalFunctionsExterns.g_log_set_always_fatal(fatal_mask);
	}

/// <summary>
/// <para>
/// Enable or disable debug output from the GLib logging system for all domains.
/// </para>
/// <para>
/// This value interacts disjunctively with `G_MESSAGES_DEBUG`, `DEBUG_INVOCATION` and
/// [func@GLib.log_writer_default_set_debug_domains] — if any of them would allow
/// a debug message to be outputted, it will be.
/// </para>
/// <para>
/// Note that this should not be used from within library code to enable debug
/// output — it is intended for external use.
/// </para>
/// </summary>

/// <param name="enabled">
/// `TRUE` to enable debug output, `FALSE` otherwise
/// </param>

	public static void LogSetDebugEnabled(bool enabled)
	{
		GLibGlobalFunctionsExterns.g_log_set_debug_enabled(enabled);
	}

/// <summary>
/// <para>
/// Installs a default log handler which is used if no
/// log handler has been set for the particular log domain
/// and log level combination.
/// </para>
/// <para>
/// By default, GLib uses [func@GLib.log_default_handler] as default log handler.
/// </para>
/// <para>
/// This has no effect if structured logging is enabled; see
/// [Using Structured Logging](logging.html#using-structured-logging).
/// </para>
/// </summary>

/// <param name="log_func">
/// the log handler function
/// </param>
/// <param name="user_data">
/// data passed to the log handler
/// </param>
/// <return>
/// the previous default log handler
/// </return>

	public static MentorLake.GLib.GLogFunc LogSetDefaultHandler(MentorLake.GLib.GLogFunc log_func, IntPtr user_data)
	{
		return GLibGlobalFunctionsExterns.g_log_set_default_handler(log_func, user_data);
	}

/// <summary>
/// <para>
/// Sets the log levels which are fatal in the given domain.
/// </para>
/// <para>
/// [flags@GLib.LogLevelFlags.LEVEL_ERROR] is always fatal.
/// </para>
/// <para>
/// This has no effect on structured log messages (using [func@GLib.log_structured] or
/// [func@GLib.log_structured_array]). To change the fatal behaviour for specific log
/// messages, programs must install a custom log writer function using
/// [func@GLib.log_set_writer_func]. See
/// [Using Structured Logging](logging.html#using-structured-logging).
/// </para>
/// <para>
/// This function is mostly intended to be used with
/// [flags@GLib.LogLevelFlags.LEVEL_CRITICAL].  You should typically not set
/// [flags@GLib.LogLevelFlags.LEVEL_WARNING], [flags@GLib.LogLevelFlags.LEVEL_MESSAGE], [flags@GLib.LogLevelFlags.LEVEL_INFO] or
/// [flags@GLib.LogLevelFlags.LEVEL_DEBUG] as fatal except inside of test programs.
/// </para>
/// </summary>

/// <param name="log_domain">
/// the log domain
/// </param>
/// <param name="fatal_mask">
/// the new fatal mask
/// </param>
/// <return>
/// the old fatal mask for the log domain
/// </return>

	public static MentorLake.GLib.GLogLevelFlags LogSetFatalMask(string log_domain, MentorLake.GLib.GLogLevelFlags fatal_mask)
	{
		return GLibGlobalFunctionsExterns.g_log_set_fatal_mask(log_domain, fatal_mask);
	}

/// <summary>
/// <para>
/// Sets the log handler for a domain and a set of log levels.
/// </para>
/// <para>
/// To handle fatal and recursive messages the @log_levels parameter
/// must be combined with the [flags@GLib.LogLevelFlags.FLAG_FATAL] and [flags@GLib.LogLevelFlags.FLAG_RECURSION]
/// bit flags.
/// </para>
/// <para>
/// Note that since the [flags@GLib.LogLevelFlags.LEVEL_ERROR] log level is always fatal, if
/// you want to set a handler for this log level you must combine it with
/// [flags@GLib.LogLevelFlags.FLAG_FATAL].
/// </para>
/// <para>
/// This has no effect if structured logging is enabled; see
/// [Using Structured Logging](logging.html#using-structured-logging).
/// </para>
/// <para>
/// The `log_domain` parameter can be set to `NULL` or an empty string to use the default
/// application domain.
/// </para>
/// <para>
/// Here is an example for adding a log handler for all warning messages
/// in the default domain:
/// </para>
/// <para>
/// ```c
/// g_log_set_handler (NULL, G_LOG_LEVEL_WARNING | G_LOG_FLAG_FATAL
///                    | G_LOG_FLAG_RECURSION, my_log_handler, NULL);
/// ```
/// </para>
/// <para>
/// This example adds a log handler for all critical messages from GTK:
/// </para>
/// <para>
/// ```c
/// g_log_set_handler (&quot;Gtk&quot;, G_LOG_LEVEL_CRITICAL | G_LOG_FLAG_FATAL
///                    | G_LOG_FLAG_RECURSION, my_log_handler, NULL);
/// ```
/// </para>
/// <para>
/// This example adds a log handler for all messages from GLib:
/// </para>
/// <para>
/// ```c
/// g_log_set_handler (&quot;GLib&quot;, G_LOG_LEVEL_MASK | G_LOG_FLAG_FATAL
///                    | G_LOG_FLAG_RECURSION, my_log_handler, NULL);
/// ```
/// </para>
/// </summary>

/// <param name="log_domain">
/// the log domain
///    application domain
/// </param>
/// <param name="log_levels">
/// the log levels to apply the log handler for.
///    To handle fatal and recursive messages as well, combine
///    the log levels with the [flags@GLib.LogLevelFlags.FLAG_FATAL] and
///    [flags@GLib.LogLevelFlags.FLAG_RECURSION] bit flags.
/// </param>
/// <param name="log_func">
/// the log handler function
/// </param>
/// <param name="user_data">
/// data passed to the log handler
/// </param>
/// <return>
/// the id of the new handler
/// </return>

	public static uint LogSetHandler(string log_domain, MentorLake.GLib.GLogLevelFlags log_levels, MentorLake.GLib.GLogFunc log_func, IntPtr user_data)
	{
		return GLibGlobalFunctionsExterns.g_log_set_handler(log_domain, log_levels, log_func, user_data);
	}

/// <summary>
/// <para>
/// Like [func@GLib.log_set_handler], but takes a destroy notify for the @user_data.
/// </para>
/// <para>
/// This has no effect if structured logging is enabled; see
/// [Using Structured Logging](logging.html#using-structured-logging).
/// </para>
/// <para>
/// The `log_domain` parameter can be set to `NULL` or an empty string to use the default
/// application domain.
/// </para>
/// </summary>

/// <param name="log_domain">
/// the log domain
///   application domain
/// </param>
/// <param name="log_levels">
/// the log levels to apply the log handler for.
///   To handle fatal and recursive messages as well, combine
///   the log levels with the [flags@GLib.LogLevelFlags.FLAG_FATAL] and
///   [flags@GLib.LogLevelFlags.FLAG_RECURSION] bit flags.
/// </param>
/// <param name="log_func">
/// the log handler function
/// </param>
/// <param name="user_data">
/// data passed to the log handler
/// </param>
/// <param name="destroy">
/// destroy notify for @user_data, or `NULL`
/// </param>
/// <return>
/// the ID of the new handler
/// </return>

	public static uint LogSetHandlerFull(string log_domain, MentorLake.GLib.GLogLevelFlags log_levels, MentorLake.GLib.GLogFunc log_func, IntPtr user_data, MentorLake.GLib.GDestroyNotify destroy)
	{
		return GLibGlobalFunctionsExterns.g_log_set_handler_full(log_domain, log_levels, log_func, user_data, destroy);
	}

/// <summary>
/// <para>
/// Set a writer function which will be called to format and write out each log
/// message.
/// </para>
/// <para>
/// Each program should set a writer function, or the default writer
/// ([func@GLib.log_writer_default]) will be used.
/// </para>
/// <para>
/// Libraries **must not** call this function — only programs are allowed to
/// install a writer function, as there must be a single, central point where
/// log messages are formatted and outputted.
/// </para>
/// <para>
/// There can only be one writer function. It is an error to set more than one.
/// </para>
/// </summary>

/// <param name="func">
/// log writer function, which must not be `NULL`
/// </param>
/// <param name="user_data">
/// user data to pass to @func
/// </param>
/// <param name="user_data_free">
/// function to free @user_data once it’s
///    finished with, if non-`NULL`
/// </param>

	public static void LogSetWriterFunc(MentorLake.GLib.GLogWriterFunc func, IntPtr user_data, MentorLake.GLib.GDestroyNotify user_data_free)
	{
		GLibGlobalFunctionsExterns.g_log_set_writer_func(func, user_data, user_data_free);
	}

/// <summary>
/// <para>
/// Log a message with structured data.
/// </para>
/// <para>
/// The message will be passed through to the log writer set by the application
/// using [func@GLib.log_set_writer_func]. If the message is fatal (i.e. its log level
/// is [flags@GLib.LogLevelFlags.LEVEL_ERROR]), the program will be aborted by calling
/// [func@GLib.BREAKPOINT] at the end of this function. If the log writer returns
/// [enum@GLib.LogWriterOutput.UNHANDLED] (failure), no other fallback writers will be tried.
/// See the documentation for [type@GLib.LogWriterFunc] for information on chaining
/// writers.
/// </para>
/// <para>
/// The structured data is provided as key–value pairs, where keys are UTF-8
/// strings, and values are arbitrary pointers — typically pointing to UTF-8
/// strings, but that is not a requirement. To pass binary (non-nul-terminated)
/// structured data, use [func@GLib.log_structured_array]. The keys for structured data
/// should follow the [systemd journal
/// fields](https://www.freedesktop.org/software/systemd/man/systemd.journal-fields.html)
/// specification. It is suggested that custom keys are namespaced according to
/// the code which sets them. For example, custom keys from GLib all have a
/// `GLIB_` prefix.
/// </para>
/// <para>
/// Note that keys that expect UTF-8 strings (specifically `&quot;MESSAGE&quot;` and
/// `&quot;GLIB_DOMAIN&quot;`) must be passed as nul-terminated UTF-8 strings until GLib
/// version 2.74.1 because the default log handler did not consider the length of
/// the `GLogField`. Starting with GLib 2.74.1 this is fixed and
/// non-nul-terminated UTF-8 strings can be passed with their correct length,
/// with the exception of `&quot;GLIB_DOMAIN&quot;` which was only fixed with GLib 2.82.3.
/// </para>
/// <para>
/// The @log_domain will be converted into a `GLIB_DOMAIN` field. @log_level will
/// be converted into a
/// &amp;lt;see href=&quot;https://www.freedesktop.org/software/systemd/man/systemd.journal-fields.html#PRIORITY=&quot;&amp;gt;PRIORITY&amp;lt;/see&amp;gt;
/// field. The format string will have its placeholders substituted for the provided
/// values and be converted into a
/// &amp;lt;see href=&quot;https://www.freedesktop.org/software/systemd/man/systemd.journal-fields.html#MESSAGE=&quot;&amp;gt;MESSAGE&amp;lt;/see&amp;gt;
/// field.
/// </para>
/// <para>
/// Other fields you may commonly want to pass into this function:
/// </para>
/// <para>
///  * &amp;lt;see href=&quot;https://www.freedesktop.org/software/systemd/man/systemd.journal-fields.html#MESSAGE_ID=&quot;&amp;gt;MESSAGE_ID&amp;lt;/see&amp;gt;
///  * &amp;lt;see href=&quot;https://www.freedesktop.org/software/systemd/man/systemd.journal-fields.html#CODE_FILE=&quot;&amp;gt;CODE_FILE&amp;lt;/see&amp;gt;
///  * &amp;lt;see href=&quot;https://www.freedesktop.org/software/systemd/man/systemd.journal-fields.html#CODE_LINE=&quot;&amp;gt;CODE_LINE&amp;lt;/see&amp;gt;
///  * &amp;lt;see href=&quot;https://www.freedesktop.org/software/systemd/man/systemd.journal-fields.html#CODE_FUNC=&quot;&amp;gt;CODE_FUNC&amp;lt;/see&amp;gt;
///  * &amp;lt;see href=&quot;https://www.freedesktop.org/software/systemd/man/systemd.journal-fields.html#ERRNO=&quot;&amp;gt;ERRNO&amp;lt;/see&amp;gt;
/// </para>
/// <para>
/// Note that `CODE_FILE`, `CODE_LINE` and `CODE_FUNC` are automatically set by
/// the logging macros, [func@GLib.DEBUG_HERE], [func@GLib.message], [func@GLib.warning], [func@GLib.critical],
/// [func@GLib.error], etc, if the symbol `G_LOG_USE_STRUCTURED` is defined before including
/// `glib.h`.
/// </para>
/// <para>
/// For example:
/// </para>
/// <para>
/// ```c
/// g_log_structured (G_LOG_DOMAIN, G_LOG_LEVEL_DEBUG,
///                   &quot;MESSAGE_ID&quot;, &quot;06d4df59e6c24647bfe69d2c27ef0b4e&quot;,
///                   &quot;MY_APPLICATION_CUSTOM_FIELD&quot;, &quot;some debug string&quot;,
///                   &quot;MESSAGE&quot;, &quot;This is a debug message about pointer %p and integer %u.&quot;,
///                   some_pointer, some_integer);
/// ```
/// </para>
/// <para>
/// Note that each `MESSAGE_ID` must be [uniquely and randomly
/// generated](https://www.freedesktop.org/software/systemd/man/systemd.journal-fields.html#MESSAGE_ID=).
/// If adding a `MESSAGE_ID`, consider shipping a [message
/// catalog](https://www.freedesktop.org/wiki/Software/systemd/catalog/) with
/// your software.
/// </para>
/// <para>
/// To pass a user data pointer to the log writer function which is specific to
/// this logging call, you must use [func@GLib.log_structured_array] and pass the pointer
/// as a field with `GLogField.length` set to zero, otherwise it will be
/// interpreted as a string.
/// </para>
/// <para>
/// For example:
/// </para>
/// <para>
/// ```c
/// const GLogField fields[] = {
///   { &quot;MESSAGE&quot;, &quot;This is a debug message.&quot;, -1 },
///   { &quot;MESSAGE_ID&quot;, &quot;fcfb2e1e65c3494386b74878f1abf893&quot;, -1 },
///   { &quot;MY_APPLICATION_CUSTOM_FIELD&quot;, &quot;some debug string&quot;, -1 },
///   { &quot;MY_APPLICATION_STATE&quot;, state_object, 0 },
/// };
/// g_log_structured_array (G_LOG_LEVEL_DEBUG, fields, G_N_ELEMENTS (fields));
/// ```
/// </para>
/// <para>
/// Note also that, even if no other structured fields are specified, there
/// must always be a `MESSAGE` key before the format string. The `MESSAGE`-format
/// pair has to be the last of the key-value pairs, and `MESSAGE` is the only
/// field for which `printf()`-style formatting is supported.
/// </para>
/// <para>
/// The default writer function for `stdout` and `stderr` will automatically
/// append a new-line character after the message, so you should not add one
/// manually to the format string.
/// </para>
/// </summary>

/// <param name="log_domain">
/// log domain, usually `G_LOG_DOMAIN`
/// </param>
/// <param name="log_level">
/// log level, either from [type@GLib.LogLevelFlags], or a user-defined
///    level
/// </param>
/// <param name="@__arglist">
/// key-value pairs of structured data to add to the log entry, followed
///    by the key `MESSAGE`, followed by a `printf()`-style message format,
///    followed by parameters to insert in the format string
/// </param>

	public static void LogStructured(string log_domain, MentorLake.GLib.GLogLevelFlags log_level, IntPtr @__arglist)
	{
		GLibGlobalFunctionsExterns.g_log_structured(log_domain, log_level, @__arglist);
	}

/// <summary>
/// <para>
/// Log a message with structured data.
/// </para>
/// <para>
/// The message will be passed through to the log writer set by the application
/// using [func@GLib.log_set_writer_func]. If the
/// message is fatal (i.e. its log level is [flags@GLib.LogLevelFlags.LEVEL_ERROR]), the program will
/// be aborted at the end of this function.
/// </para>
/// <para>
/// See [func@GLib.log_structured] for more documentation.
/// </para>
/// <para>
/// This assumes that @log_level is already present in @fields (typically as the
/// `PRIORITY` field).
/// </para>
/// </summary>

/// <param name="log_level">
/// log level, either from [type@GLib.LogLevelFlags], or a user-defined
///    level
/// </param>
/// <param name="fields">
/// key–value pairs of structured data to add
///    to the log message
/// </param>
/// <param name="n_fields">
/// number of elements in the @fields array
/// </param>

	public static void LogStructuredArray(MentorLake.GLib.GLogLevelFlags log_level, MentorLake.GLib.GLogField[] fields, UIntPtr n_fields)
	{
		GLibGlobalFunctionsExterns.g_log_structured_array(log_level, fields, n_fields);
	}


/// <param name="log_domain">
/// </param>
/// <param name="log_level">
/// </param>
/// <param name="file">
/// </param>
/// <param name="line">
/// </param>
/// <param name="func">
/// </param>
/// <param name="message_format">
/// </param>
/// <param name="@__arglist">
/// </param>

	public static void LogStructuredStandard(string log_domain, MentorLake.GLib.GLogLevelFlags log_level, string file, string line, string func, string message_format, IntPtr @__arglist)
	{
		GLibGlobalFunctionsExterns.g_log_structured_standard(log_domain, log_level, file, line, func, message_format, @__arglist);
	}

/// <summary>
/// <para>
/// Log a message with structured data, accepting the data within a [type@GLib.Variant].
/// </para>
/// <para>
/// This version is especially useful for use in other languages, via introspection.
/// </para>
/// <para>
/// The only mandatory item in the @fields dictionary is the `&quot;MESSAGE&quot;` which must
/// contain the text shown to the user.
/// </para>
/// <para>
/// The values in the @fields dictionary are likely to be of type `G_VARIANT_TYPE_STRING`.
/// Array of bytes (`G_VARIANT_TYPE_BYTESTRING`) is also
/// supported. In this case the message is handled as binary and will be forwarded
/// to the log writer as such. The size of the array should not be higher than
/// `G_MAXSSIZE`. Otherwise it will be truncated to this size. For other types
/// [method@GLib.Variant.print] will be used to convert the value into a string.
/// </para>
/// <para>
/// For more details on its usage and about the parameters, see [func@GLib.log_structured].
/// </para>
/// </summary>

/// <param name="log_domain">
/// log domain, usually `G_LOG_DOMAIN`
/// </param>
/// <param name="log_level">
/// log level, either from [type@GLib.LogLevelFlags], or a user-defined
///    level
/// </param>
/// <param name="fields">
/// a dictionary ([type@GLib.Variant] of the type `G_VARIANT_TYPE_VARDICT`)
/// containing the key-value pairs of message data.
/// </param>

	public static void LogVariant(string log_domain, MentorLake.GLib.GLogLevelFlags log_level, MentorLake.GLib.GVariantHandle fields)
	{
		GLibGlobalFunctionsExterns.g_log_variant(log_domain, log_level, fields);
	}

/// <summary>
/// <para>
/// Format a structured log message and output it to the default log destination
/// for the platform.
/// </para>
/// <para>
/// On Linux, this is typically the systemd journal, falling
/// back to `stdout` or `stderr` if running from the terminal or if output is
/// being redirected to a file.
/// </para>
/// <para>
/// Support for other platform-specific logging mechanisms may be added in
/// future. Distributors of GLib may modify this function to impose their own
/// (documented) platform-specific log writing policies.
/// </para>
/// <para>
/// This is suitable for use as a [type@GLib.LogWriterFunc], and is the default writer used
/// if no other is set using [func@GLib.log_set_writer_func].
/// </para>
/// <para>
/// As with [func@GLib.log_default_handler], this function drops debug and informational
/// messages unless their log domain (or `all`) is listed in the space-separated
/// `G_MESSAGES_DEBUG` environment variable, or `DEBUG_INVOCATION=1` is set in
/// the environment, or set at runtime by [func@GLib.log_writer_default_set_debug_domains].
/// </para>
/// <para>
/// [func@GLib.log_writer_default] uses the mask set by [func@GLib.log_set_always_fatal] to
/// determine which messages are fatal. When using a custom writer function instead it is
/// up to the writer function to determine which log messages are fatal.
/// </para>
/// </summary>

/// <param name="log_level">
/// log level, either from [type@GLib.LogLevelFlags], or a user-defined
///    level
/// </param>
/// <param name="fields">
/// key–value pairs of structured data forming
///    the log message
/// </param>
/// <param name="n_fields">
/// number of elements in the @fields array
/// </param>
/// <param name="user_data">
/// user data passed to [func@GLib.log_set_writer_func]
/// </param>
/// <return>
/// [enum@GLib.LogWriterOutput.HANDLED] on success,
///   [enum@GLib.LogWriterOutput.UNHANDLED] otherwise
/// </return>

	public static MentorLake.GLib.GLogWriterOutput LogWriterDefault(MentorLake.GLib.GLogLevelFlags log_level, MentorLake.GLib.GLogField[] fields, UIntPtr n_fields, IntPtr user_data)
	{
		return GLibGlobalFunctionsExterns.g_log_writer_default(log_level, fields, n_fields, user_data);
	}

/// <summary>
/// <para>
/// Reset the list of domains to be logged, that might be initially set by the
/// `G_MESSAGES_DEBUG` or `DEBUG_INVOCATION` environment variables.
/// </para>
/// <para>
/// This function is thread-safe.
/// </para>
/// </summary>

/// <param name="domains">
/// `NULL`-terminated array with domains to be printed.
///   `NULL` or an array with no values means none. Array with a single value `&quot;all&quot;` means all.
/// </param>

	public static void LogWriterDefaultSetDebugDomains(string domains)
	{
		GLibGlobalFunctionsExterns.g_log_writer_default_set_debug_domains(domains);
	}

/// <summary>
/// <para>
/// Configure whether the built-in log functions will output all log messages to
/// `stderr`.
/// </para>
/// <para>
/// The built-in log functions are [func@GLib.log_default_handler] for the
/// old-style API, and both [func@GLib.log_writer_default] and
/// [func@GLib.log_writer_standard_streams] for the structured API.
/// </para>
/// <para>
/// By default, log messages of levels [flags@GLib.LogLevelFlags.LEVEL_INFO] and
/// [flags@GLib.LogLevelFlags.LEVEL_DEBUG] are sent to `stdout`, and other log messages are
/// sent to `stderr`. This is problematic for applications that intend
/// to reserve `stdout` for structured output such as JSON or XML.
/// </para>
/// <para>
/// This function sets global state. It is not thread-aware, and should be
/// called at the very start of a program, before creating any other threads
/// or creating objects that could create worker threads of their own.
/// </para>
/// </summary>

/// <param name="use_stderr">
/// If `TRUE`, use `stderr` for log messages that would
///  normally have appeared on `stdout`
/// </param>

	public static void LogWriterDefaultSetUseStderr(bool use_stderr)
	{
		GLibGlobalFunctionsExterns.g_log_writer_default_set_use_stderr(use_stderr);
	}

/// <summary>
/// <para>
/// Check whether [func@GLib.log_writer_default] and [func@GLib.log_default_handler] would
/// ignore a message with the given domain and level.
/// </para>
/// <para>
/// As with [func@GLib.log_default_handler], this function drops debug and informational
/// messages unless their log domain (or `all`) is listed in the space-separated
/// `G_MESSAGES_DEBUG` environment variable, or `DEBUG_INVOCATION=1` is set in
/// the environment, or by [func@GLib.log_writer_default_set_debug_domains].
/// </para>
/// <para>
/// This can be used when implementing log writers with the same filtering
/// behaviour as the default, but a different destination or output format:
/// </para>
/// <para>
/// ```c
/// if (g_log_writer_default_would_drop (log_level, log_domain))
///   return G_LOG_WRITER_HANDLED;
/// ]|
/// </para>
/// <para>
/// or to skip an expensive computation if it is only needed for a debugging
/// message, and `G_MESSAGES_DEBUG` and `DEBUG_INVOCATION` are not set:
/// </para>
/// <para>
/// ```c
/// if (!g_log_writer_default_would_drop (G_LOG_LEVEL_DEBUG, G_LOG_DOMAIN))
///   {
///     g_autofree gchar *result = expensive_computation (my_object);
/// </para>
/// <para>
///     g_debug (&quot;my_object result: %s&quot;, result);
///   }
/// ```
/// </para>
/// </summary>

/// <param name="log_level">
/// log level, either from [type@GLib.LogLevelFlags], or a user-defined
///    level
/// </param>
/// <param name="log_domain">
/// log domain
/// </param>
/// <return>
/// `TRUE` if the log message would be dropped by GLib’s
///   default log handlers
/// </return>

	public static bool LogWriterDefaultWouldDrop(MentorLake.GLib.GLogLevelFlags log_level, string log_domain)
	{
		return GLibGlobalFunctionsExterns.g_log_writer_default_would_drop(log_level, log_domain);
	}

/// <summary>
/// <para>
/// Format a structured log message as a string suitable for outputting to the
/// terminal (or elsewhere).
/// </para>
/// <para>
/// This will include the values of all fields it knows
/// how to interpret, which includes `MESSAGE` and `GLIB_DOMAIN` (see the
/// documentation for [func@GLib.log_structured]). It does not include values from
/// unknown fields.
/// </para>
/// <para>
/// The returned string does **not** have a trailing new-line character. It is
/// encoded in the character set of the current locale, which is not necessarily
/// UTF-8.
/// </para>
/// </summary>

/// <param name="log_level">
/// log level, either from [type@GLib.LogLevelFlags], or a user-defined
///    level
/// </param>
/// <param name="fields">
/// key–value pairs of structured data forming
///    the log message
/// </param>
/// <param name="n_fields">
/// number of elements in the @fields array
/// </param>
/// <param name="use_color">
/// `TRUE` to use
///   [ANSI color escape sequences](https://en.wikipedia.org/wiki/ANSI_escape_code)
///   when formatting the message, `FALSE` to not
/// </param>
/// <return>
/// string containing the formatted log message, in
///    the character set of the current locale
/// </return>

	public static string LogWriterFormatFields(MentorLake.GLib.GLogLevelFlags log_level, MentorLake.GLib.GLogField[] fields, UIntPtr n_fields, bool use_color)
	{
		return GLibGlobalFunctionsExterns.g_log_writer_format_fields(log_level, fields, n_fields, use_color);
	}

/// <summary>
/// <para>
/// Check whether the given @output_fd file descriptor is a connection to the
/// systemd journal, or something else (like a log file or `stdout` or
/// `stderr`).
/// </para>
/// <para>
/// Invalid file descriptors are accepted and return `FALSE`, which allows for
/// the following construct without needing any additional error handling:
/// ```c
/// is_journald = g_log_writer_is_journald (fileno (stderr));
/// ```
/// </para>
/// </summary>

/// <param name="output_fd">
/// output file descriptor to check
/// </param>
/// <return>
/// `TRUE` if @output_fd points to the journal, `FALSE` otherwise
/// </return>

	public static bool LogWriterIsJournald(int output_fd)
	{
		return GLibGlobalFunctionsExterns.g_log_writer_is_journald(output_fd);
	}

/// <summary>
/// <para>
/// Format a structured log message and send it to the systemd journal as a set
/// of key–value pairs.
/// </para>
/// <para>
/// All fields are sent to the journal, but if a field has
/// length zero (indicating program-specific data) then only its key will be
/// sent.
/// </para>
/// <para>
/// This is suitable for use as a [type@GLib.LogWriterFunc].
/// </para>
/// <para>
/// If GLib has been compiled without systemd support, this function is still
/// defined, but will always return [enum@GLib.LogWriterOutput.UNHANDLED].
/// </para>
/// </summary>

/// <param name="log_level">
/// log level, either from [type@GLib.LogLevelFlags], or a user-defined
///    level
/// </param>
/// <param name="fields">
/// key–value pairs of structured data forming
///    the log message
/// </param>
/// <param name="n_fields">
/// number of elements in the @fields array
/// </param>
/// <param name="user_data">
/// user data passed to [func@GLib.log_set_writer_func]
/// </param>
/// <return>
/// [enum@GLib.LogWriterOutput.HANDLED] on success, [enum@GLib.LogWriterOutput.UNHANDLED] otherwise
/// </return>

	public static MentorLake.GLib.GLogWriterOutput LogWriterJournald(MentorLake.GLib.GLogLevelFlags log_level, MentorLake.GLib.GLogField[] fields, UIntPtr n_fields, IntPtr user_data)
	{
		return GLibGlobalFunctionsExterns.g_log_writer_journald(log_level, fields, n_fields, user_data);
	}

/// <summary>
/// <para>
/// Format a structured log message and print it to either `stdout` or `stderr`,
/// depending on its log level.
/// </para>
/// <para>
/// [flags@GLib.LogLevelFlags.LEVEL_INFO] and [flags@GLib.LogLevelFlags.LEVEL_DEBUG] messages
/// are sent to `stdout`, or to `stderr` if requested by
/// [func@GLib.log_writer_default_set_use_stderr];
/// all other log levels are sent to `stderr`. Only fields
/// which are understood by this function are included in the formatted string
/// which is printed.
/// </para>
/// <para>
/// If the output stream supports
/// [ANSI color escape sequences](https://en.wikipedia.org/wiki/ANSI_escape_code),
/// they will be used in the output.
/// </para>
/// <para>
/// A trailing new-line character is added to the log message when it is printed.
/// </para>
/// <para>
/// This is suitable for use as a [type@GLib.LogWriterFunc].
/// </para>
/// </summary>

/// <param name="log_level">
/// log level, either from [type@GLib.LogLevelFlags], or a user-defined
///    level
/// </param>
/// <param name="fields">
/// key–value pairs of structured data forming
///    the log message
/// </param>
/// <param name="n_fields">
/// number of elements in the @fields array
/// </param>
/// <param name="user_data">
/// user data passed to [func@GLib.log_set_writer_func]
/// </param>
/// <return>
/// [enum@GLib.LogWriterOutput.HANDLED] on success,
///   [enum@GLib.LogWriterOutput.UNHANDLED] otherwise
/// </return>

	public static MentorLake.GLib.GLogWriterOutput LogWriterStandardStreams(MentorLake.GLib.GLogLevelFlags log_level, MentorLake.GLib.GLogField[] fields, UIntPtr n_fields, IntPtr user_data)
	{
		return GLibGlobalFunctionsExterns.g_log_writer_standard_streams(log_level, fields, n_fields, user_data);
	}

/// <summary>
/// <para>
/// Check whether the given @output_fd file descriptor supports
/// [ANSI color escape sequences](https://en.wikipedia.org/wiki/ANSI_escape_code).
/// </para>
/// <para>
/// If so, they can safely be used when formatting log messages.
/// </para>
/// </summary>

/// <param name="output_fd">
/// output file descriptor to check
/// </param>
/// <return>
/// `TRUE` if ANSI color escapes are supported, `FALSE` otherwise
/// </return>

	public static bool LogWriterSupportsColor(int output_fd)
	{
		return GLibGlobalFunctionsExterns.g_log_writer_supports_color(output_fd);
	}

/// <summary>
/// <para>
/// Format a structured log message and send it to the syslog daemon. Only fields
/// which are understood by this function are included in the formatted string
/// which is printed.
/// </para>
/// <para>
/// Log facility will be defined via the SYSLOG_FACILITY field and accepts the following
/// values: &quot;auth&quot;, &quot;daemon&quot;, and &quot;user&quot;. If SYSLOG_FACILITY is not specified, LOG_USER
/// facility will be used.
/// </para>
/// <para>
/// This is suitable for use as a [type@GLib.LogWriterFunc].
/// </para>
/// <para>
/// If syslog is not supported, this function is still defined, but will always
/// return [enum@GLib.LogWriterOutput.UNHANDLED].
/// </para>
/// </summary>

/// <param name="log_level">
/// log level, either from [type@GLib.LogLevelFlags], or a user-defined
///    level
/// </param>
/// <param name="fields">
/// key–value pairs of structured data forming
///    the log message
/// </param>
/// <param name="n_fields">
/// number of elements in the @fields array
/// </param>
/// <param name="user_data">
/// user data passed to [func@GLib.log_set_writer_func]
/// </param>
/// <return>
/// [enum@GLib.LogWriterOutput.HANDLED] on success, [enum@GLib.LogWriterOutput.UNHANDLED] otherwise
/// </return>

	public static MentorLake.GLib.GLogWriterOutput LogWriterSyslog(MentorLake.GLib.GLogLevelFlags log_level, MentorLake.GLib.GLogField[] fields, UIntPtr n_fields, IntPtr user_data)
	{
		return GLibGlobalFunctionsExterns.g_log_writer_syslog(log_level, fields, n_fields, user_data);
	}

/// <summary>
/// <para>
/// Logs an error or debugging message.
/// </para>
/// <para>
/// If the log level has been set as fatal, [func@GLib.BREAKPOINT] is called
/// to terminate the program. See the documentation for [func@GLib.BREAKPOINT] for
/// details of the debugging options this provides.
/// </para>
/// <para>
/// If [func@GLib.log_default_handler] is used as the log handler function, a new-line
/// character will automatically be appended to @..., and need not be entered
/// manually.
/// </para>
/// <para>
/// If [structured logging is enabled](logging.html#using-structured-logging) this will
/// output via the structured log writer function (see [func@GLib.log_set_writer_func]).
/// </para>
/// <para>
/// The `log_domain` parameter can be set to `NULL` or an empty string to use the default
/// application domain.
/// </para>
/// </summary>

/// <param name="log_domain">
/// the log domain
///   application domain
/// </param>
/// <param name="log_level">
/// the log level
/// </param>
/// <param name="format">
/// the message format. See the `printf()` documentation
/// </param>
/// <param name="args">
/// the parameters to insert into the format string
/// </param>

	public static void Logv(string log_domain, MentorLake.GLib.GLogLevelFlags log_level, string format, IntPtr args)
	{
		GLibGlobalFunctionsExterns.g_logv(log_domain, log_level, format, args);
	}

/// <summary>
/// <para>
/// A wrapper for the POSIX lstat() function. The lstat() function is
/// like stat() except that in the case of symbolic links, it returns
/// information about the symbolic link itself and not the file that it
/// refers to. If the system does not support symbolic links g_lstat()
/// is identical to g_stat().
/// </para>
/// <para>
/// See your C library manual for more details about lstat().
/// </para>
/// </summary>

/// <param name="filename">
/// a pathname in the GLib file name encoding
///     (UTF-8 on Windows)
/// </param>
/// <param name="buf">
/// a pointer to a stat struct, which will be filled with the file
///     information
/// </param>
/// <return>
/// 0 if the information was successfully retrieved,
///     -1 if an error occurred
/// </return>

	public static int Lstat(string filename, MentorLake.GLib.GStatBufHandle buf)
	{
		return GLibGlobalFunctionsExterns.g_lstat(filename, buf);
	}

/// <summary>
/// <para>
/// Returns the global-default main context. This is the main context
/// used for main loop functions when a main loop is not explicitly
/// specified, and corresponds to the &quot;main&quot; main loop. See also
/// [func@GLib.MainContext.get_thread_default].
/// </para>
/// </summary>

/// <return>
/// the global-default main context.
/// </return>

	public static MentorLake.GLib.GMainContextHandle MainContextDefault()
	{
		return GLibGlobalFunctionsExterns.g_main_context_default();
	}

/// <summary>
/// <para>
/// Gets the thread-default #GMainContext for this thread. Asynchronous
/// operations that want to be able to be run in contexts other than
/// the default one should call this method or
/// [func@GLib.MainContext.ref_thread_default] to get a
/// [struct@GLib.MainContext] to add their [struct@GLib.Source]s to. (Note that
/// even in single-threaded programs applications may sometimes want to
/// temporarily push a non-default context, so it is not safe to assume that
/// this will always return %NULL if you are running in the default thread.)
/// </para>
/// <para>
/// If you need to hold a reference on the context, use
/// [func@GLib.MainContext.ref_thread_default] instead.
/// </para>
/// </summary>

/// <return>
/// the thread-default #GMainContext, or
/// %NULL if the thread-default context is the global-default main context.
/// </return>

	public static MentorLake.GLib.GMainContextHandle MainContextGetThreadDefault()
	{
		return GLibGlobalFunctionsExterns.g_main_context_get_thread_default();
	}

/// <summary>
/// <para>
/// Gets the thread-default [struct@GLib.MainContext] for this thread, as with
/// [func@GLib.MainContext.get_thread_default], but also adds a reference to
/// it with [method@GLib.MainContext.ref]. In addition, unlike
/// [func@GLib.MainContext.get_thread_default], if the thread-default context
/// is the global-default context, this will return that
/// [struct@GLib.MainContext] (with a ref added to it) rather than returning
/// %NULL.
/// </para>
/// </summary>

/// <return>
/// the thread-default #GMainContext. Unref
///     with [method@GLib.MainContext.unref] when you are done with it.
/// </return>

	public static MentorLake.GLib.GMainContextHandle MainContextRefThreadDefault()
	{
		return GLibGlobalFunctionsExterns.g_main_context_ref_thread_default();
	}

/// <summary>
/// <para>
/// Returns the currently firing source for this thread.
/// </para>
/// </summary>

/// <return>
/// The currently firing source or %NULL.
/// </return>

	public static MentorLake.GLib.GSourceHandle MainCurrentSource()
	{
		return GLibGlobalFunctionsExterns.g_main_current_source();
	}

/// <summary>
/// <para>
/// Returns the depth of the stack of calls to
/// [method@GLib.MainContext.dispatch] on any #GMainContext in the current thread.
/// That is, when called from the toplevel, it gives 0. When
/// called from within a callback from [method@GLib.MainContext.iteration]
/// (or [method@GLib.MainLoop.run], etc.) it returns 1. When called from within
/// a callback to a recursive call to [method@GLib.MainContext.iteration],
/// it returns 2. And so forth.
/// </para>
/// <para>
/// This function is useful in a situation like the following:
/// Imagine an extremely simple &quot;garbage collected&quot; system.
/// </para>
/// <code>
/// static GList *free_list;
/// static GList *free_list;
/// 
/// gpointer
/// allocate_memory (gsize size)
/// {
///   gpointer result = g_malloc (size);
///   free_list = g_list_prepend (free_list, result);
///   return result;
/// }
/// 
/// void
/// free_allocated_memory (void)
/// {
///   GList *l;
///   for (l = free_list; l; l = l-&amp;gt;next);
///     g_free (l-&amp;gt;data);
///   g_list_free (free_list);
///   free_list = NULL;
///  }
/// 
/// [...]
/// 
/// while (TRUE);
///  {
///    g_main_context_iteration (NULL, TRUE);
///    free_allocated_memory();
///   }
/// </code>
/// <para>
/// This works from an application, however, if you want to do the same
/// thing from a library, it gets more difficult, since you no longer
/// control the main loop. You might think you can simply use an idle
/// function to make the call to free_allocated_memory(), but that
/// doesn&apos;t work, since the idle function could be called from a
/// recursive callback. This can be fixed by using [func@GLib.main_depth]
/// </para>
/// <code>
/// gpointer
/// gpointer
/// allocate_memory (gsize size)
/// {
///   FreeListBlock *block = g_new (FreeListBlock, 1);
///   block-&amp;gt;mem = g_malloc (size);
///   block-&amp;gt;depth = g_main_depth ();
///   free_list = g_list_prepend (free_list, block);
///   return block-&amp;gt;mem;
/// }
/// 
/// void
/// free_allocated_memory (void)
/// {
///   GList *l;
/// 
///   int depth = g_main_depth ();
///   for (l = free_list; l; );
///     {
///       GList *next = l-&amp;gt;next;
///       FreeListBlock *block = l-&amp;gt;data;
///       if (block-&amp;gt;depth &amp;gt; depth)
///         {
///           g_free (block-&amp;gt;mem);
///           g_free (block);
///           free_list = g_list_delete_link (free_list, l);
///         }
/// 
///       l = next;
///     }
///   }
/// </code>
/// <para>
/// There is a temptation to use [func@GLib.main_depth] to solve
/// problems with reentrancy. For instance, while waiting for data
/// to be received from the network in response to a menu item,
/// the menu item might be selected again. It might seem that
/// one could make the menu item&apos;s callback return immediately
/// and do nothing if [func@GLib.main_depth] returns a value greater than 1.
/// However, this should be avoided since the user then sees selecting
/// the menu item do nothing. Furthermore, you&apos;ll find yourself adding
/// these checks all over your code, since there are doubtless many,
/// many things that the user could do. Instead, you can use the
/// following techniques:
/// </para>
/// <para>
/// 1. Use gtk_widget_set_sensitive() or modal dialogs to prevent
///    the user from interacting with elements while the main
///    loop is recursing.
/// </para>
/// <para>
/// 2. Avoid main loop recursion in situations where you can&apos;t handle
///    arbitrary  callbacks. Instead, structure your code so that you
///    simply return to the main loop and then get called again when
///    there is more work to do.
/// </para>
/// </summary>

/// <return>
/// The main loop recursion level in the current thread
/// </return>

	public static int MainDepth()
	{
		return GLibGlobalFunctionsExterns.g_main_depth();
	}

/// <summary>
/// <para>
/// Allocates @n_bytes bytes of memory.
/// If @n_bytes is 0 it returns %NULL.
/// </para>
/// <para>
/// If the allocation fails (because the system is out of memory),
/// the program is terminated.
/// </para>
/// </summary>

/// <param name="n_bytes">
/// the number of bytes to allocate
/// </param>
/// <return>
/// a pointer to the allocated memory
/// </return>

	public static IntPtr Malloc(UIntPtr n_bytes)
	{
		return GLibGlobalFunctionsExterns.g_malloc(n_bytes);
	}

/// <summary>
/// <para>
/// Allocates @n_bytes bytes of memory, initialized to 0&apos;s.
/// If @n_bytes is 0 it returns %NULL.
/// </para>
/// <para>
/// If the allocation fails (because the system is out of memory),
/// the program is terminated.
/// </para>
/// </summary>

/// <param name="n_bytes">
/// the number of bytes to allocate
/// </param>
/// <return>
/// a pointer to the allocated memory
/// </return>

	public static IntPtr Malloc0(UIntPtr n_bytes)
	{
		return GLibGlobalFunctionsExterns.g_malloc0(n_bytes);
	}

/// <summary>
/// <para>
/// This function is similar to g_malloc0(), allocating (@n_blocks * @n_block_bytes) bytes,
/// but care is taken to detect possible overflow during multiplication.
/// </para>
/// <para>
/// If the allocation fails (because the system is out of memory),
/// the program is terminated.
/// </para>
/// </summary>

/// <param name="n_blocks">
/// the number of blocks to allocate
/// </param>
/// <param name="n_block_bytes">
/// the size of each block in bytes
/// </param>
/// <return>
/// a pointer to the allocated memory
/// </return>

	public static IntPtr Malloc0N(UIntPtr n_blocks, UIntPtr n_block_bytes)
	{
		return GLibGlobalFunctionsExterns.g_malloc0_n(n_blocks, n_block_bytes);
	}

/// <summary>
/// <para>
/// This function is similar to g_malloc(), allocating (@n_blocks * @n_block_bytes) bytes,
/// but care is taken to detect possible overflow during multiplication.
/// </para>
/// <para>
/// If the allocation fails (because the system is out of memory),
/// the program is terminated.
/// </para>
/// </summary>

/// <param name="n_blocks">
/// the number of blocks to allocate
/// </param>
/// <param name="n_block_bytes">
/// the size of each block in bytes
/// </param>
/// <return>
/// a pointer to the allocated memory
/// </return>

	public static IntPtr MallocN(UIntPtr n_blocks, UIntPtr n_block_bytes)
	{
		return GLibGlobalFunctionsExterns.g_malloc_n(n_blocks, n_block_bytes);
	}

/// <summary>
/// <para>
/// Collects the attributes of the element from the data passed to the
/// #GMarkupParser start_element function, dealing with common error
/// conditions and supporting boolean values.
/// </para>
/// <para>
/// This utility function is not required to write a parser but can save
/// a lot of typing.
/// </para>
/// <para>
/// The @element_name, @attribute_names, @attribute_values and @error
/// parameters passed to the start_element callback should be passed
/// unmodified to this function.
/// </para>
/// <para>
/// Following these arguments is a list of &quot;supported&quot; attributes to collect.
/// It is an error to specify multiple attributes with the same name. If any
/// attribute not in the list appears in the @attribute_names array then an
/// unknown attribute error will result.
/// </para>
/// <para>
/// The #GMarkupCollectType field allows specifying the type of collection
/// to perform and if a given attribute must appear or is optional.
/// </para>
/// <para>
/// The attribute name is simply the name of the attribute to collect.
/// </para>
/// <para>
/// The pointer should be of the appropriate type (see the descriptions
/// under #GMarkupCollectType) and may be %NULL in case a particular
/// attribute is to be allowed but ignored.
/// </para>
/// <para>
/// This function deals with issuing errors for missing attributes
/// (of type %G_MARKUP_ERROR_MISSING_ATTRIBUTE), unknown attributes
/// (of type %G_MARKUP_ERROR_UNKNOWN_ATTRIBUTE) and duplicate
/// attributes (of type %G_MARKUP_ERROR_INVALID_CONTENT) as well
/// as parse errors for boolean-valued attributes (again of type
/// %G_MARKUP_ERROR_INVALID_CONTENT). In all of these cases %FALSE
/// will be returned and @error will be set as appropriate.
/// </para>
/// </summary>

/// <param name="element_name">
/// the current tag name
/// </param>
/// <param name="attribute_names">
/// the attribute names
/// </param>
/// <param name="attribute_values">
/// the attribute values
/// </param>
/// <param name="error">
/// a pointer to a #GError or %NULL
/// </param>
/// <param name="first_type">
/// the #GMarkupCollectType of the first attribute
/// </param>
/// <param name="first_attr">
/// the name of the first attribute
/// </param>
/// <param name="@__arglist">
/// a pointer to the storage location of the first attribute
///     (or %NULL), followed by more types names and pointers, ending
///     with %G_MARKUP_COLLECT_INVALID
/// </param>
/// <return>
/// %TRUE if successful
/// </return>

	public static bool MarkupCollectAttributes(string element_name, string attribute_names, string attribute_values, IntPtr error, MentorLake.GLib.GMarkupCollectType first_type, string first_attr, IntPtr @__arglist)
	{
		return GLibGlobalFunctionsExterns.g_markup_collect_attributes(element_name, attribute_names, attribute_values, error, first_type, first_attr, @__arglist);
	}



	public static MentorLake.GLib.GQuark MarkupErrorQuark()
	{
		return GLibGlobalFunctionsExterns.g_markup_error_quark();
	}

/// <summary>
/// <para>
/// Escapes text so that the markup parser will parse it verbatim.
/// Less than, greater than, ampersand, etc. are replaced with the
/// corresponding entities. This function would typically be used
/// when writing out a file to be parsed with the markup parser.
/// </para>
/// <para>
/// Note that this function doesn&apos;t protect whitespace and line endings
/// from being processed according to the XML rules for normalization
/// of line endings and attribute values.
/// </para>
/// <para>
/// Note also that this function will produce character references in
/// the range of &amp;#x1; ... &amp;#x1f; for all control sequences
/// except for tabstop, newline and carriage return.  The character
/// references in this range are not valid XML 1.0, but they are
/// valid XML 1.1 and will be accepted by the GMarkup parser.
/// </para>
/// </summary>

/// <param name="text">
/// some valid UTF-8 text
/// </param>
/// <param name="length">
/// length of @text in bytes, or -1 if the text is nul-terminated
/// </param>
/// <return>
/// a newly allocated string with the escaped text
/// </return>

	public static string MarkupEscapeText(string text, UIntPtr length)
	{
		return GLibGlobalFunctionsExterns.g_markup_escape_text(text, length);
	}

/// <summary>
/// <para>
/// Formats arguments according to @format, escaping
/// all string and character arguments in the fashion
/// of g_markup_escape_text(). This is useful when you
/// want to insert literal strings into XML-style markup
/// output, without having to worry that the strings
/// might themselves contain markup.
/// </para>
/// <code>
/// const char *store = &quot;Fortnum &amp; Mason&quot;;
/// const char *store = &quot;Fortnum &amp; Mason&quot;;
/// const char *item = &quot;Tea&quot;;
/// char *output;
/// 
/// output = g_markup_printf_escaped (&quot;&amp;lt;purchase&amp;gt;&quot;
///                                   &quot;&amp;lt;store&amp;gt;%s&amp;lt;/store&amp;gt;&quot;
///                                   &quot;&amp;lt;item&amp;gt;%s&amp;lt;/item&amp;gt;&quot;
///                                   &quot;&amp;lt;/purchase&amp;gt;&quot;,
///                                   store, item);
/// </code>
/// </summary>

/// <param name="format">
/// printf() style format string
/// </param>
/// <param name="@__arglist">
/// the arguments to insert in the format string
/// </param>
/// <return>
/// newly allocated result from formatting
///    operation. Free with g_free().
/// </return>

	public static string MarkupPrintfEscaped(string format, IntPtr @__arglist)
	{
		return GLibGlobalFunctionsExterns.g_markup_printf_escaped(format, @__arglist);
	}

/// <summary>
/// <para>
/// Formats the data in @args according to @format, escaping
/// all string and character arguments in the fashion
/// of g_markup_escape_text(). See g_markup_printf_escaped().
/// </para>
/// </summary>

/// <param name="format">
/// printf() style format string
/// </param>
/// <param name="args">
/// variable argument list, similar to vprintf()
/// </param>
/// <return>
/// newly allocated result from formatting
///  operation. Free with g_free().
/// </return>

	public static string MarkupVprintfEscaped(string format, IntPtr args)
	{
		return GLibGlobalFunctionsExterns.g_markup_vprintf_escaped(format, args);
	}



	public static void MemChunkInfo()
	{
		GLibGlobalFunctionsExterns.g_mem_chunk_info();
	}

/// <summary>
/// <para>
/// Checks whether the allocator used by g_malloc() is the system&apos;s
/// malloc implementation. If it returns %TRUE memory allocated with
/// malloc() can be used interchangeably with memory allocated using g_malloc().
/// This function is useful for avoiding an extra copy of allocated memory returned
/// by a non-GLib-based API.
/// </para>
/// </summary>

/// <return>
/// if %TRUE, malloc() and g_malloc() can be mixed.
/// </return>

	public static bool MemIsSystemMalloc()
	{
		return GLibGlobalFunctionsExterns.g_mem_is_system_malloc();
	}

/// <summary>
/// <para>
/// GLib used to support some tools for memory profiling, but this
/// no longer works. There are many other useful tools for memory
/// profiling these days which can be used instead.
/// </para>
/// </summary>


	public static void MemProfile()
	{
		GLibGlobalFunctionsExterns.g_mem_profile();
	}

/// <summary>
/// <para>
/// This function used to let you override the memory allocation function.
/// However, its use was incompatible with the use of global constructors
/// in GLib and GIO, because those use the GLib allocators before main is
/// reached. Therefore this function is now deprecated and is just a stub.
/// </para>
/// </summary>

/// <param name="vtable">
/// table of memory allocation routines.
/// </param>

	public static void MemSetVtable(MentorLake.GLib.GMemVTableHandle vtable)
	{
		GLibGlobalFunctionsExterns.g_mem_set_vtable(vtable);
	}

/// <summary>
/// <para>
/// Allocates @byte_size bytes of memory, and copies @byte_size bytes into it
/// from @mem. If @mem is `NULL` it returns `NULL`.
/// </para>
/// </summary>

/// <param name="mem">
/// the memory to copy
/// </param>
/// <param name="byte_size">
/// the number of bytes to copy
/// </param>
/// <return>
/// a pointer to the newly-allocated copy of the memory
/// </return>

	public static IntPtr Memdup(IntPtr mem, uint byte_size)
	{
		return GLibGlobalFunctionsExterns.g_memdup(mem, byte_size);
	}

/// <summary>
/// <para>
/// Allocates @byte_size bytes of memory, and copies @byte_size bytes into it
/// from @mem. If @mem is `NULL` it returns `NULL`.
/// </para>
/// <para>
/// This replaces [func@GLib.memdup], which was prone to integer overflows when
/// converting the argument from a `gsize` to a `guint`.
/// </para>
/// </summary>

/// <param name="mem">
/// the memory to copy
/// </param>
/// <param name="byte_size">
/// the number of bytes to copy
/// </param>
/// <return>
/// a pointer to the newly-allocated copy of the memory
/// </return>

	public static IntPtr Memdup2(IntPtr mem, UIntPtr byte_size)
	{
		return GLibGlobalFunctionsExterns.g_memdup2(mem, byte_size);
	}

/// <summary>
/// <para>
/// A wrapper for the POSIX mkdir() function. The mkdir() function
/// attempts to create a directory with the given name and permissions.
/// The mode argument is ignored on Windows.
/// </para>
/// <para>
/// See your C library manual for more details about mkdir().
/// </para>
/// </summary>

/// <param name="filename">
/// a pathname in the GLib file name encoding
///     (UTF-8 on Windows)
/// </param>
/// <param name="mode">
/// permissions to use for the newly created directory
/// </param>
/// <return>
/// 0 if the directory was successfully created, -1 if an error
///    occurred
/// </return>

	public static int Mkdir(string filename, int mode)
	{
		return GLibGlobalFunctionsExterns.g_mkdir(filename, mode);
	}

/// <summary>
/// <para>
/// Create a directory if it doesn&apos;t already exist. Create intermediate
/// parent directories as needed, too.
/// </para>
/// </summary>

/// <param name="pathname">
/// a pathname in the GLib file name encoding
/// </param>
/// <param name="mode">
/// permissions to use for newly created directories
/// </param>
/// <return>
/// 0 if the directory already exists, or was successfully
/// created. Returns -1 if an error occurred, with errno set.
/// </return>

	public static int MkdirWithParents(string pathname, int mode)
	{
		return GLibGlobalFunctionsExterns.g_mkdir_with_parents(pathname, mode);
	}

/// <summary>
/// <para>
/// Creates a temporary directory. See the mkdtemp() documentation
/// on most UNIX-like systems.
/// </para>
/// <para>
/// The parameter is a string that should follow the rules for
/// mkdtemp() templates, i.e. contain the string &quot;XXXXXX&quot;.
/// g_mkdtemp() is slightly more flexible than mkdtemp() in that the
/// sequence does not have to occur at the very end of the template.
/// The X string will be modified to form the name of a directory that
/// didn&apos;t exist.
/// The string should be in the GLib file name encoding. Most importantly,
/// on Windows it should be in UTF-8.
/// </para>
/// <para>
/// If you are going to be creating a temporary directory inside the
/// directory returned by g_get_tmp_dir(), you might want to use
/// g_dir_make_tmp() instead.
/// </para>
/// </summary>

/// <param name="tmpl">
/// template directory name
/// </param>
/// <return>
/// A pointer to @tmpl, which has been
///   modified to hold the directory name.  In case of errors, %NULL is
///   returned and %errno will be set.
/// </return>

	public static string Mkdtemp(string tmpl)
	{
		return GLibGlobalFunctionsExterns.g_mkdtemp(tmpl);
	}

/// <summary>
/// <para>
/// Creates a temporary directory. See the mkdtemp() documentation
/// on most UNIX-like systems.
/// </para>
/// <para>
/// The parameter is a string that should follow the rules for
/// mkdtemp() templates, i.e. contain the string &quot;XXXXXX&quot;.
/// g_mkdtemp_full() is slightly more flexible than mkdtemp() in that the
/// sequence does not have to occur at the very end of the template
/// and you can pass a @mode. The X string will be modified to form
/// the name of a directory that didn&apos;t exist. The string should be
/// in the GLib file name encoding. Most importantly, on Windows it
/// should be in UTF-8.
/// </para>
/// <para>
/// If you are going to be creating a temporary directory inside the
/// directory returned by g_get_tmp_dir(), you might want to use
/// g_dir_make_tmp() instead.
/// </para>
/// </summary>

/// <param name="tmpl">
/// template directory name
/// </param>
/// <param name="mode">
/// permissions to create the temporary directory with
/// </param>
/// <return>
/// A pointer to @tmpl, which has been
///   modified to hold the directory name. In case of errors, %NULL is
///   returned, and %errno will be set.
/// </return>

	public static string MkdtempFull(string tmpl, int mode)
	{
		return GLibGlobalFunctionsExterns.g_mkdtemp_full(tmpl, mode);
	}

/// <summary>
/// <para>
/// Opens a temporary file. See the mkstemp() documentation
/// on most UNIX-like systems.
/// </para>
/// <para>
/// The parameter is a string that should follow the rules for
/// mkstemp() templates, i.e. contain the string &quot;XXXXXX&quot;.
/// g_mkstemp() is slightly more flexible than mkstemp() in that the
/// sequence does not have to occur at the very end of the template.
/// The X string will be modified to form the name of a file that
/// didn&apos;t exist. The string should be in the GLib file name encoding.
/// Most importantly, on Windows it should be in UTF-8.
/// </para>
/// </summary>

/// <param name="tmpl">
/// template filename
/// </param>
/// <return>
/// A file handle (as from open()) to the file
///   opened for reading and writing. The file is opened in binary
///   mode on platforms where there is a difference. The file handle
///   should be closed with close(). In case of errors, -1 is
///   returned and %errno will be set.
/// </return>

	public static int Mkstemp(string tmpl)
	{
		return GLibGlobalFunctionsExterns.g_mkstemp(tmpl);
	}

/// <summary>
/// <para>
/// Opens a temporary file. See the mkstemp() documentation
/// on most UNIX-like systems.
/// </para>
/// <para>
/// The parameter is a string that should follow the rules for
/// mkstemp() templates, i.e. contain the string &quot;XXXXXX&quot;.
/// g_mkstemp_full() is slightly more flexible than mkstemp()
/// in that the sequence does not have to occur at the very end of the
/// template and you can pass a @mode and additional @flags. The X
/// string will be modified to form the name of a file that didn&apos;t exist.
/// The string should be in the GLib file name encoding. Most importantly,
/// on Windows it should be in UTF-8.
/// </para>
/// </summary>

/// <param name="tmpl">
/// template filename
/// </param>
/// <param name="flags">
/// flags to pass to an open() call in addition to O_EXCL
///   and O_CREAT, which are passed automatically
/// </param>
/// <param name="mode">
/// permissions to create the temporary file with
/// </param>
/// <return>
/// A file handle (as from open()) to the file
///   opened for reading and writing. The file handle should be
///   closed with close(). In case of errors, -1 is returned
///   and %errno will be set.
/// </return>

	public static int MkstempFull(string tmpl, int flags, int mode)
	{
		return GLibGlobalFunctionsExterns.g_mkstemp_full(tmpl, flags, mode);
	}

/// <summary>
/// <para>
/// Allocates and initializes a new #GMutex.
/// </para>
/// </summary>

/// <return>
/// a newly allocated #GMutex. Use g_mutex_free() to free
/// </return>

	public static MentorLake.GLib.GMutexHandle MutexNew()
	{
		return GLibGlobalFunctionsExterns.g_mutex_new();
	}



	public static void NodePopAllocator()
	{
		GLibGlobalFunctionsExterns.g_node_pop_allocator();
	}


/// <param name="allocator">
/// </param>

	public static void NodePushAllocator(MentorLake.GLib.GAllocatorHandle allocator)
	{
		GLibGlobalFunctionsExterns.g_node_push_allocator(allocator);
	}

/// <summary>
/// <para>
/// Set the pointer at the specified location to %NULL.
/// </para>
/// </summary>

/// <param name="nullify_location">
/// the memory address of the pointer.
/// </param>

	public static void NullifyPointer(IntPtr nullify_location)
	{
		GLibGlobalFunctionsExterns.g_nullify_pointer(nullify_location);
	}



	public static MentorLake.GLib.GQuark NumberParserErrorQuark()
	{
		return GLibGlobalFunctionsExterns.g_number_parser_error_quark();
	}

/// <summary>
/// <para>
/// Prompts the user with
/// `[E]xit, [H]alt, show [S]tack trace or [P]roceed`.
/// This function is intended to be used for debugging use only.
/// The following example shows how it can be used together with
/// the g_log() functions.
/// </para>
/// <code>
/// #include &amp;lt;glib.h&amp;gt;
/// #include &amp;lt;glib.h&amp;gt;
/// 
/// static void
/// log_handler (const gchar   *log_domain,
///              GLogLevelFlags log_level,
///              const gchar   *message,
///              gpointer       user_data)
/// {
///   g_log_default_handler (log_domain, log_level, message, user_data);
/// 
///   g_on_error_query (MY_PROGRAM_NAME);
/// }
/// 
/// int
/// main (int argc, char *argv[])
/// {
///   g_log_set_handler (MY_LOG_DOMAIN,
///                      G_LOG_LEVEL_WARNING |
///                      G_LOG_LEVEL_ERROR |
///                      G_LOG_LEVEL_CRITICAL,
///                      log_handler,
///                      NULL);
///   ...
/// </code>
/// <para>
/// If &quot;[E]xit&quot; is selected, the application terminates with a call
/// to _exit(0).
/// </para>
/// <para>
/// If &quot;[S]tack&quot; trace is selected, g_on_error_stack_trace() is called.
/// This invokes gdb, which attaches to the current process and shows
/// a stack trace. The prompt is then shown again.
/// </para>
/// <para>
/// If &quot;[P]roceed&quot; is selected, the function returns.
/// </para>
/// <para>
/// This function may cause different actions on non-UNIX platforms.
/// </para>
/// <para>
/// On Windows consider using the `G_DEBUGGER` environment
/// variable (see [Running GLib Applications](glib-running.html)) and
/// calling g_on_error_stack_trace() instead.
/// </para>
/// </summary>

/// <param name="prg_name">
/// the program name, needed by gdb for the &quot;[S]tack trace&quot;
///     option. If @prg_name is %NULL, g_get_prgname() is called to get
///     the program name (which will work correctly if gdk_init() or
///     gtk_init() has been called)
/// </param>

	public static void OnErrorQuery(string prg_name)
	{
		GLibGlobalFunctionsExterns.g_on_error_query(prg_name);
	}

/// <summary>
/// <para>
/// Invokes gdb, which attaches to the current process and shows a
/// stack trace. Called by g_on_error_query() when the &quot;[S]tack trace&quot;
/// option is selected. You can get the current process&apos;s program name
/// with g_get_prgname(), assuming that you have called gtk_init() or
/// gdk_init().
/// </para>
/// <para>
/// This function may cause different actions on non-UNIX platforms.
/// </para>
/// <para>
/// When running on Windows, this function is *not* called by
/// g_on_error_query(). If called directly, it will raise an
/// exception, which will crash the program. If the `G_DEBUGGER` environment
/// variable is set, a debugger will be invoked to attach and
/// handle that exception (see [Running GLib Applications](glib-running.html)).
/// </para>
/// </summary>

/// <param name="prg_name">
/// the program name, needed by gdb for the
///   &quot;[S]tack trace&quot; option, or `NULL` to use a default string
/// </param>

	public static void OnErrorStackTrace(string prg_name)
	{
		GLibGlobalFunctionsExterns.g_on_error_stack_trace(prg_name);
	}

/// <summary>
/// <para>
/// Function to be called when starting a critical initialization
/// section. The argument @location must point to a static
/// 0-initialized variable that will be set to a value other than 0 at
/// the end of the initialization section. In combination with
/// g_once_init_leave() and the unique address @value_location, it can
/// be ensured that an initialization section will be executed only once
/// during a program&apos;s life time, and that concurrent threads are
/// blocked until initialization completed. To be used in constructs
/// like this:
/// </para>
/// <code>
///   static gsize initialization_value = 0;
///   static gsize initialization_value = 0;
/// 
///   if (g_once_init_enter (&amp;initialization_value))
///     {
///       gsize setup_value = 42; // initialization code here
/// 
///       g_once_init_leave (&amp;initialization_value, setup_value);
///     }
/// 
///   // use initialization_value here
/// </code>
/// <para>
/// While @location has a `volatile` qualifier, this is a historical artifact and
/// the pointer passed to it should not be `volatile`.
/// </para>
/// </summary>

/// <param name="location">
/// location of a static initializable variable
///    containing 0
/// </param>
/// <return>
/// %TRUE if the initialization section should be entered,
///     %FALSE and blocks otherwise
/// </return>

	public static bool OnceInitEnter(ref IntPtr location)
	{
		return GLibGlobalFunctionsExterns.g_once_init_enter(ref location);
	}


/// <param name="location">
/// </param>

	public static bool OnceInitEnterImpl(UIntPtr location)
	{
		return GLibGlobalFunctionsExterns.g_once_init_enter_impl(location);
	}

/// <summary>
/// <para>
/// This functions behaves in the same way as g_once_init_enter(), but can
/// can be used to initialize pointers (or #guintptr) instead of #gsize.
/// </para>
/// <code>
///   static MyStruct *interesting_struct = NULL;
///   static MyStruct *interesting_struct = NULL;
/// 
///   if (g_once_init_enter_pointer (&amp;interesting_struct))
///     {
///       MyStruct *setup_value = allocate_my_struct (); // initialization code here
/// 
///       g_once_init_leave_pointer (&amp;interesting_struct, g_steal_pointer (&amp;setup_value));
///     }
/// 
///   // use interesting_struct here
/// </code>
/// </summary>

/// <param name="location">
/// location of a static initializable variable
///    containing `NULL`
/// </param>
/// <return>
/// %TRUE if the initialization section should be entered,
///     %FALSE and blocks otherwise
/// </return>

	public static bool OnceInitEnterPointer(IntPtr location)
	{
		return GLibGlobalFunctionsExterns.g_once_init_enter_pointer(location);
	}

/// <summary>
/// <para>
/// Counterpart to g_once_init_enter(). Expects a location of a static
/// 0-initialized initialization variable, and an initialization value
/// other than 0. Sets the variable to the initialization value, and
/// releases concurrent threads blocking in g_once_init_enter() on this
/// initialization variable.
/// </para>
/// <para>
/// While @location has a `volatile` qualifier, this is a historical artifact and
/// the pointer passed to it should not be `volatile`.
/// </para>
/// </summary>

/// <param name="location">
/// location of a static initializable variable
///    containing 0
/// </param>
/// <param name="result">
/// new non-0 value for `*value_location`
/// </param>

	public static void OnceInitLeave(ref IntPtr location, UIntPtr result)
	{
		GLibGlobalFunctionsExterns.g_once_init_leave(ref location, result);
	}

/// <summary>
/// <para>
/// Counterpart to g_once_init_enter_pointer(). Expects a location of a static
/// `NULL`-initialized initialization variable, and an initialization value
/// other than `NULL`. Sets the variable to the initialization value, and
/// releases concurrent threads blocking in g_once_init_enter_pointer() on this
/// initialization variable.
/// </para>
/// <para>
/// This functions behaves in the same way as g_once_init_leave(), but
/// can be used to initialize pointers (or #guintptr) instead of #gsize.
/// </para>
/// </summary>

/// <param name="location">
/// location of a static initializable variable
///    containing `NULL`
/// </param>
/// <param name="result">
/// new non-`NULL` value for `*location`
/// </param>

	public static void OnceInitLeavePointer(IntPtr location, IntPtr result)
	{
		GLibGlobalFunctionsExterns.g_once_init_leave_pointer(location, result);
	}

/// <summary>
/// <para>
/// A wrapper for the POSIX open() function. The open() function is
/// used to convert a pathname into a file descriptor.
/// </para>
/// <para>
/// On POSIX systems file descriptors are implemented by the operating
/// system. On Windows, it&apos;s the C library that implements open() and
/// file descriptors. The actual Win32 API for opening files is quite
/// different, see MSDN documentation for CreateFile(). The Win32 API
/// uses file handles, which are more randomish integers, not small
/// integers like file descriptors.
/// </para>
/// <para>
/// Because file descriptors are specific to the C library on Windows,
/// the file descriptor returned by this function makes sense only to
/// functions in the same C library. Thus if the GLib-using code uses a
/// different C library than GLib does, the file descriptor returned by
/// this function cannot be passed to C library functions like write()
/// or read().
/// </para>
/// <para>
/// See your C library manual for more details about open().
/// </para>
/// </summary>

/// <param name="filename">
/// a pathname in the GLib file name encoding
///     (UTF-8 on Windows)
/// </param>
/// <param name="flags">
/// as in open()
/// </param>
/// <param name="mode">
/// as in open()
/// </param>
/// <return>
/// a new file descriptor, or -1 if an error occurred.
///     The return value can be used exactly like the return value
///     from open().
/// </return>

	public static int Open(string filename, int flags, int mode)
	{
		return GLibGlobalFunctionsExterns.g_open(filename, flags, mode);
	}



	public static MentorLake.GLib.GQuark OptionErrorQuark()
	{
		return GLibGlobalFunctionsExterns.g_option_error_quark();
	}

/// <summary>
/// <para>
/// Parses a string containing debugging options
/// into a %guint containing bit flags. This is used
/// within GDK and GTK to parse the debug options passed on the
/// command line or through environment variables.
/// </para>
/// <para>
/// If @string is equal to &quot;all&quot;, all flags are set. Any flags
/// specified along with &quot;all&quot; in @string are inverted; thus,
/// &quot;all,foo,bar&quot; or &quot;foo,bar,all&quot; sets all flags except those
/// corresponding to &quot;foo&quot; and &quot;bar&quot;.
/// </para>
/// <para>
/// If @string is equal to &quot;help&quot;, all the available keys in @keys
/// are printed out to standard error.
/// </para>
/// </summary>

/// <param name="@string">
/// a list of debug options separated by colons, spaces, or
/// commas, or %NULL.
/// </param>
/// <param name="keys">
/// pointer to an array of #GDebugKey which associate
///     strings with bit flags.
/// </param>
/// <param name="nkeys">
/// the number of #GDebugKeys in the array.
/// </param>
/// <return>
/// the combined set of bit flags.
/// </return>

	public static uint ParseDebugString(string @string, MentorLake.GLib.GDebugKey[] keys, uint nkeys)
	{
		return GLibGlobalFunctionsExterns.g_parse_debug_string(@string, keys, nkeys);
	}

/// <summary>
/// <para>
/// Compares two path buffers for equality and returns `TRUE`
/// if they are equal.
/// </para>
/// <para>
/// The path inside the paths buffers are not going to be normalized,
/// so `X/Y/Z/A/..`, `X/./Y/Z` and `X/Y/Z` are not going to be considered
/// equal.
/// </para>
/// <para>
/// This function can be passed to g_hash_table_new() as the
/// `key_equal_func` parameter.
/// </para>
/// </summary>

/// <param name="v1">
/// a path buffer to compare
/// </param>
/// <param name="v2">
/// a path buffer to compare
/// </param>
/// <return>
/// `TRUE` if the two path buffers are equal,
///   and `FALSE` otherwise
/// </return>

	public static bool PathBufEqual(IntPtr v1, IntPtr v2)
	{
		return GLibGlobalFunctionsExterns.g_path_buf_equal(v1, v2);
	}

/// <summary>
/// <para>
/// Gets the last component of the filename.
/// </para>
/// <para>
/// If @file_name ends with a directory separator it gets the component
/// before the last slash. If @file_name consists only of directory
/// separators (and on Windows, possibly a drive letter), a single
/// separator is returned. If @file_name is empty, it gets &quot;.&quot;.
/// </para>
/// </summary>

/// <param name="file_name">
/// the name of the file
/// </param>
/// <return>
/// a newly allocated string
///   containing the last component of the filename
/// </return>

	public static string PathGetBasename(string file_name)
	{
		return GLibGlobalFunctionsExterns.g_path_get_basename(file_name);
	}

/// <summary>
/// <para>
/// Gets the directory components of a file name. For example, the directory
/// component of `/usr/bin/test` is `/usr/bin`. The directory component of `/`
/// is `/`.
/// </para>
/// <para>
/// If the file name has no directory components &quot;.&quot; is returned.
/// The returned string should be freed when no longer needed.
/// </para>
/// </summary>

/// <param name="file_name">
/// the name of the file
/// </param>
/// <return>
/// the directory components of the file
/// </return>

	public static string PathGetDirname(string file_name)
	{
		return GLibGlobalFunctionsExterns.g_path_get_dirname(file_name);
	}

/// <summary>
/// <para>
/// Returns %TRUE if the given @file_name is an absolute file name.
/// Note that this is a somewhat vague concept on Windows.
/// </para>
/// <para>
/// On POSIX systems, an absolute file name is well-defined. It always
/// starts from the single root directory. For example &quot;/usr/local&quot;.
/// </para>
/// <para>
/// On Windows, the concepts of current drive and drive-specific
/// current directory introduce vagueness. This function interprets as
/// an absolute file name one that either begins with a directory
/// separator such as &quot;\Users\tml&quot; or begins with the root on a drive,
/// for example &quot;C:\Windows&quot;. The first case also includes UNC paths
/// such as &quot;\\\\myserver\docs\foo&quot;. In all cases, either slashes or
/// backslashes are accepted.
/// </para>
/// <para>
/// Note that a file name relative to the current drive root does not
/// truly specify a file uniquely over time and across processes, as
/// the current drive is a per-process value and can be changed.
/// </para>
/// <para>
/// File names relative the current directory on some specific drive,
/// such as &quot;D:foo/bar&quot;, are not interpreted as absolute by this
/// function, but they obviously are not relative to the normal current
/// directory as returned by getcwd() or g_get_current_dir()
/// either. Such paths should be avoided, or need to be handled using
/// Windows-specific code.
/// </para>
/// </summary>

/// <param name="file_name">
/// a file name
/// </param>
/// <return>
/// %TRUE if @file_name is absolute
/// </return>

	public static bool PathIsAbsolute(string file_name)
	{
		return GLibGlobalFunctionsExterns.g_path_is_absolute(file_name);
	}

/// <summary>
/// <para>
/// Returns a pointer into @file_name after the root component,
/// i.e. after the &quot;/&quot; in UNIX or &quot;C:\&quot; under Windows. If @file_name
/// is not an absolute path it returns %NULL.
/// </para>
/// </summary>

/// <param name="file_name">
/// a file name
/// </param>
/// <return>
/// a pointer into @file_name after the
///     root component
/// </return>

	public static string PathSkipRoot(string file_name)
	{
		return GLibGlobalFunctionsExterns.g_path_skip_root(file_name);
	}

/// <summary>
/// <para>
/// Matches a string against a compiled pattern.
/// </para>
/// <para>
/// Passing the correct
/// length of the string given is mandatory. The reversed string can be
/// omitted by passing `NULL`, this is more efficient if the reversed
/// version of the string to be matched is not at hand, as
/// `g_pattern_match()` will only construct it if the compiled pattern
/// requires reverse matches.
/// </para>
/// <para>
/// Note that, if the user code will (possibly) match a string against a
/// multitude of patterns containing wildcards, chances are high that
/// some patterns will require a reversed string. In this case, it’s
/// more efficient to provide the reversed string to avoid multiple
/// constructions thereof in the various calls to `g_pattern_match()`.
/// </para>
/// <para>
/// Note also that the reverse of a UTF-8 encoded string can in general
/// not be obtained by [func@GLib.strreverse]. This works only if the string
/// does not contain any multibyte characters. GLib offers the
/// [func@GLib.utf8_strreverse] function to reverse UTF-8 encoded strings.
/// </para>
/// </summary>

/// <param name="pspec">
/// a #GPatternSpec
/// </param>
/// <param name="string_length">
/// the length of @string (in bytes, i.e. `strlen()`,
///    not [func@GLib.utf8_strlen])
/// </param>
/// <param name="@string">
/// the UTF-8 encoded string to match
/// </param>
/// <param name="string_reversed">
/// the reverse of @string
/// </param>
/// <return>
/// %TRUE if @string matches @pspec
/// </return>

	public static bool PatternMatch(MentorLake.GLib.GPatternSpecHandle pspec, uint string_length, string @string, string string_reversed)
	{
		return GLibGlobalFunctionsExterns.g_pattern_match(pspec, string_length, @string, string_reversed);
	}

/// <summary>
/// <para>
/// Matches a string against a pattern given as a string.
/// </para>
/// <para>
/// If this
/// function is to be called in a loop, it’s more efficient to compile
/// the pattern once with [ctor@GLib.PatternSpec.new] and call
/// [method@GLib.PatternSpec.match_string] repeatedly.
/// </para>
/// </summary>

/// <param name="pattern">
/// the UTF-8 encoded pattern
/// </param>
/// <param name="@string">
/// the UTF-8 encoded string to match
/// </param>
/// <return>
/// %TRUE if @string matches @pspec
/// </return>

	public static bool PatternMatchSimple(string pattern, string @string)
	{
		return GLibGlobalFunctionsExterns.g_pattern_match_simple(pattern, @string);
	}

/// <summary>
/// <para>
/// Matches a string against a compiled pattern.
/// </para>
/// <para>
/// If the string is to be
/// matched against more than one pattern, consider using
/// [method@GLib.PatternSpec.match] instead while supplying the reversed string.
/// </para>
/// </summary>

/// <param name="pspec">
/// a #GPatternSpec
/// </param>
/// <param name="@string">
/// the UTF-8 encoded string to match
/// </param>
/// <return>
/// %TRUE if @string matches @pspec
/// </return>

	public static bool PatternMatchString(MentorLake.GLib.GPatternSpecHandle pspec, string @string)
	{
		return GLibGlobalFunctionsExterns.g_pattern_match_string(pspec, @string);
	}

/// <summary>
/// <para>
/// This is equivalent to g_bit_lock, but working on pointers (or other
/// pointer-sized values).
/// </para>
/// <para>
/// For portability reasons, you may only lock on the bottom 32 bits of
/// the pointer.
/// </para>
/// <para>
/// While @address has a `volatile` qualifier, this is a historical
/// artifact and the argument passed to it should not be `volatile`.
/// </para>
/// </summary>

/// <param name="address">
/// a pointer to a #gpointer-sized value
/// </param>
/// <param name="lock_bit">
/// a bit value between 0 and 31
/// </param>

	public static void PointerBitLock(IntPtr address, int lock_bit)
	{
		GLibGlobalFunctionsExterns.g_pointer_bit_lock(address, lock_bit);
	}

/// <summary>
/// <para>
/// This is equivalent to g_bit_lock, but working on pointers (or other
/// pointer-sized values).
/// </para>
/// <para>
/// For portability reasons, you may only lock on the bottom 32 bits of
/// the pointer.
/// </para>
/// </summary>

/// <param name="address">
/// a pointer to a #gpointer-sized value
/// </param>
/// <param name="lock_bit">
/// a bit value between 0 and 31
/// </param>
/// <param name="out_ptr">
/// returns the set pointer atomically.
///   This is the value after setting the lock, it thus always has the
///   lock bit set, while previously @address had the lockbit unset.
///   You may also use g_pointer_bit_lock_mask_ptr() to clear the lock bit.
/// </param>

	public static void PointerBitLockAndGet(IntPtr address, uint lock_bit, out uint out_ptr)
	{
		GLibGlobalFunctionsExterns.g_pointer_bit_lock_and_get(address, lock_bit, out out_ptr);
	}

/// <summary>
/// <para>
/// This mangles @ptr as g_pointer_bit_lock() and g_pointer_bit_unlock()
/// do.
/// </para>
/// </summary>

/// <param name="ptr">
/// the pointer to mask
/// </param>
/// <param name="lock_bit">
/// the bit to set/clear. If set to `G_MAXUINT`, the
///   lockbit is taken from @preserve_ptr or @ptr (depending on @preserve_mask).
/// </param>
/// <param name="set">
/// whether to set (lock) the bit or unset (unlock). This
///   has no effect, if @lock_bit is set to `G_MAXUINT`.
/// </param>
/// <param name="preserve_mask">
/// if non-zero, a bit-mask for @preserve_ptr. The
///   @preserve_mask bits from @preserve_ptr are set in the result.
///   Note that the @lock_bit bit will be always set according to @set,
///   regardless of @preserve_mask and @preserve_ptr (unless @lock_bit is
///   `G_MAXUINT`).
/// </param>
/// <param name="preserve_ptr">
/// if @preserve_mask is non-zero, the bits
///   from this pointer are set in the result.
/// </param>
/// <return>
/// the mangled pointer.
/// </return>

	public static IntPtr PointerBitLockMaskPtr(IntPtr ptr, uint lock_bit, bool set, uint preserve_mask, IntPtr preserve_ptr)
	{
		return GLibGlobalFunctionsExterns.g_pointer_bit_lock_mask_ptr(ptr, lock_bit, set, preserve_mask, preserve_ptr);
	}

/// <summary>
/// <para>
/// This is equivalent to g_bit_trylock(), but working on pointers (or
/// other pointer-sized values).
/// </para>
/// <para>
/// For portability reasons, you may only lock on the bottom 32 bits of
/// the pointer.
/// </para>
/// <para>
/// While @address has a `volatile` qualifier, this is a historical
/// artifact and the argument passed to it should not be `volatile`.
/// </para>
/// </summary>

/// <param name="address">
/// a pointer to a #gpointer-sized value
/// </param>
/// <param name="lock_bit">
/// a bit value between 0 and 31
/// </param>
/// <return>
/// %TRUE if the lock was acquired
/// </return>

	public static bool PointerBitTrylock(IntPtr address, int lock_bit)
	{
		return GLibGlobalFunctionsExterns.g_pointer_bit_trylock(address, lock_bit);
	}

/// <summary>
/// <para>
/// This is equivalent to g_bit_unlock, but working on pointers (or other
/// pointer-sized values).
/// </para>
/// <para>
/// For portability reasons, you may only lock on the bottom 32 bits of
/// the pointer.
/// </para>
/// <para>
/// While @address has a `volatile` qualifier, this is a historical
/// artifact and the argument passed to it should not be `volatile`.
/// </para>
/// </summary>

/// <param name="address">
/// a pointer to a #gpointer-sized value
/// </param>
/// <param name="lock_bit">
/// a bit value between 0 and 31
/// </param>

	public static void PointerBitUnlock(IntPtr address, int lock_bit)
	{
		GLibGlobalFunctionsExterns.g_pointer_bit_unlock(address, lock_bit);
	}

/// <summary>
/// <para>
/// This is equivalent to g_pointer_bit_unlock() and atomically setting
/// the pointer value.
/// </para>
/// <para>
/// Note that the lock bit will be cleared from the pointer. If the unlocked
/// pointer that was set is not identical to @ptr, an assertion fails. In other
/// words, @ptr must have @lock_bit unset. This also means, you usually can
/// only use this on the lowest bits.
/// </para>
/// </summary>

/// <param name="address">
/// a pointer to a #gpointer-sized value
/// </param>
/// <param name="lock_bit">
/// a bit value between 0 and 31
/// </param>
/// <param name="ptr">
/// the new pointer value to set
/// </param>
/// <param name="preserve_mask">
/// if non-zero, those bits of the current pointer in @address
///   are preserved.
///   Note that the @lock_bit bit will be always set according to @set,
///   regardless of @preserve_mask and the currently set value in @address.
/// </param>

	public static void PointerBitUnlockAndSet(IntPtr address, uint lock_bit, IntPtr ptr, uint preserve_mask)
	{
		GLibGlobalFunctionsExterns.g_pointer_bit_unlock_and_set(address, lock_bit, ptr, preserve_mask);
	}

/// <summary>
/// <para>
/// Polls @fds, as with the poll() system call, but portably. (On
/// systems that don&apos;t have poll(), it is emulated using select().)
/// This is used internally by #GMainContext, but it can be called
/// directly if you need to block until a file descriptor is ready, but
/// don&apos;t want to run the full main loop.
/// </para>
/// <para>
/// Each element of @fds is a #GPollFD describing a single file
/// descriptor to poll. The @fd field indicates the file descriptor,
/// and the @events field indicates the events to poll for. On return,
/// the @revents fields will be filled with the events that actually
/// occurred.
/// </para>
/// <para>
/// On POSIX systems, the file descriptors in @fds can be any sort of
/// file descriptor, but the situation is much more complicated on
/// Windows. If you need to use g_poll() in code that has to run on
/// Windows, the easiest solution is to construct all of your
/// #GPollFDs with g_io_channel_win32_make_pollfd().
/// </para>
/// </summary>

/// <param name="fds">
/// file descriptors to poll
/// </param>
/// <param name="nfds">
/// the number of file descriptors in @fds
/// </param>
/// <param name="timeout">
/// amount of time to wait, in milliseconds, or -1 to wait forever
/// </param>
/// <return>
/// the number of entries in @fds whose @revents fields
/// were filled in, or 0 if the operation timed out, or -1 on error or
/// if the call was interrupted.
/// </return>

	public static int Poll(MentorLake.GLib.GPollFDHandle fds, uint nfds, int timeout)
	{
		return GLibGlobalFunctionsExterns.g_poll(fds, nfds, timeout);
	}

/// <summary>
/// <para>
/// Formats a string according to @format and prefix it to an existing
/// error message. If @err is %NULL (ie: no error variable) then do
/// nothing.
/// </para>
/// <para>
/// If `*err` is %NULL (ie: an error variable is present but there is no
/// error condition) then also do nothing.
/// </para>
/// </summary>

/// <param name="err">
/// a return location for a #GError
/// </param>
/// <param name="format">
/// printf()-style format string
/// </param>
/// <param name="@__arglist">
/// arguments to @format
/// </param>

	public static void PrefixError(ref MentorLake.GLib.GErrorHandle err, string format, IntPtr @__arglist)
	{
		GLibGlobalFunctionsExterns.g_prefix_error(ref err, format, @__arglist);
	}

/// <summary>
/// <para>
/// Prefixes @prefix to an existing error message. If @err or `*err` is
/// %NULL (i.e.: no error variable) then do nothing.
/// </para>
/// </summary>

/// <param name="err">
/// a return location for a #GError, or %NULL
/// </param>
/// <param name="prefix">
/// string to prefix @err with
/// </param>

	public static void PrefixErrorLiteral(ref MentorLake.GLib.GErrorHandle err, string prefix)
	{
		GLibGlobalFunctionsExterns.g_prefix_error_literal(ref err, prefix);
	}

/// <summary>
/// <para>
/// Outputs a formatted message via the print handler.
/// </para>
/// <para>
/// The default print handler outputs the encoded message to `stdout`, without
/// appending a trailing new-line character. Typically, @format should end with
/// its own new-line character.
/// </para>
/// <para>
/// This function should not be used from within libraries for debugging
/// messages, since it may be redirected by applications to special
/// purpose message windows or even files. Instead, libraries should
/// use [func@GLib.log], [func@GLib.log_structured], or the convenience macros
/// [func@GLib.message], [func@GLib.warning] and [func@GLib.error].
/// </para>
/// </summary>

/// <param name="format">
/// the message format. See the `printf()` documentation
/// </param>
/// <param name="@__arglist">
/// the parameters to insert into the format string
/// </param>

	public static void Print(string format, IntPtr @__arglist)
	{
		GLibGlobalFunctionsExterns.g_print(format, @__arglist);
	}

/// <summary>
/// <para>
/// Outputs a formatted message via the error message handler.
/// </para>
/// <para>
/// The default handler outputs the encoded message to `stderr`, without appending
/// a trailing new-line character. Typically, @format should end with its own
/// new-line character.
/// </para>
/// <para>
/// This function should not be used from within libraries.
/// Instead [func@GLib.log] or [func@GLib.log_structured] should be used, or the convenience
/// macros [func@GLib.message], [func@GLib.warning] and [func@GLib.error].
/// </para>
/// </summary>

/// <param name="format">
/// the message format. See the `printf()` documentation
/// </param>
/// <param name="@__arglist">
/// the parameters to insert into the format string
/// </param>

	public static void Printerr(string format, IntPtr @__arglist)
	{
		GLibGlobalFunctionsExterns.g_printerr(format, @__arglist);
	}

/// <summary>
/// <para>
/// An implementation of the standard `printf()` function which supports
/// positional parameters, as specified in the Single Unix Specification.
/// </para>
/// <para>
/// As with the standard `printf()`, this does not automatically append a trailing
/// new-line character to the message, so typically @format should end with its
/// own new-line character.
/// </para>
/// <para>
/// `glib/gprintf.h` must be explicitly included in order to use this function.
/// </para>
/// </summary>

/// <param name="format">
/// a standard `printf()` format string, but notice
///   [string precision pitfalls](string-utils.html#string-precision-pitfalls)
/// </param>
/// <param name="@__arglist">
/// the arguments to insert in the output
/// </param>
/// <return>
/// the number of bytes printed
/// </return>

	public static int Printf(string format, IntPtr @__arglist)
	{
		return GLibGlobalFunctionsExterns.g_printf(format, @__arglist);
	}

/// <summary>
/// <para>
/// Calculates the maximum space needed to store the output
/// of the `sprintf()` function.
/// </para>
/// <para>
/// If @format or @args are invalid, `0` is returned. This could happen if, for
/// example, @format contains an `%lc` or `%ls` placeholder and @args contains a
/// wide character which cannot be represented in multibyte encoding. `0`
/// can also be returned legitimately if, for example, @format is `%s` and @args
/// is an empty string. The caller is responsible for differentiating these two
/// return cases if necessary. It is recommended to not use `%lc` or `%ls`
/// placeholders in any case, as their behaviour is locale-dependent.
/// </para>
/// </summary>

/// <param name="format">
/// the format string. See the `printf()` documentation
/// </param>
/// <param name="args">
/// the parameters to be inserted into the format string
/// </param>
/// <return>
/// the maximum space needed to store the formatted string, or `0` on error
/// </return>

	public static UIntPtr PrintfStringUpperBound(string format, IntPtr args)
	{
		return GLibGlobalFunctionsExterns.g_printf_string_upper_bound(format, args);
	}

/// <summary>
/// <para>
/// Creates a new #GPrivate.
/// </para>
/// </summary>

/// <param name="notify">
/// a #GDestroyNotify
/// </param>
/// <return>
/// a newly allocated #GPrivate (which can never be destroyed)
/// </return>

	public static MentorLake.GLib.GPrivateHandle PrivateNew(MentorLake.GLib.GDestroyNotify notify)
	{
		return GLibGlobalFunctionsExterns.g_private_new(notify);
	}

/// <summary>
/// <para>
/// If @dest is %NULL, free @src; otherwise, moves @src into `*dest`.
/// The error variable @dest points to must be %NULL.
/// </para>
/// <para>
/// @src must be non-%NULL.
/// </para>
/// <para>
/// Note that @src is no longer valid after this call. If you want
/// to keep using the same GError*, you need to set it to %NULL
/// after calling this function on it.
/// </para>
/// </summary>

/// <param name="dest">
/// error return location
/// </param>
/// <param name="src">
/// error to move into the return location
/// </param>

	public static void PropagateError(out MentorLake.GLib.GErrorHandle dest, MentorLake.GLib.GErrorHandle src)
	{
		GLibGlobalFunctionsExterns.g_propagate_error(out dest, src);
	}

/// <summary>
/// <para>
/// If @dest is %NULL, free @src; otherwise, moves @src into `*dest`.
/// `*dest` must be %NULL. After the move, add a prefix as with
/// g_prefix_error().
/// </para>
/// </summary>

/// <param name="dest">
/// error return location
/// </param>
/// <param name="src">
/// error to move into the return location
/// </param>
/// <param name="format">
/// printf()-style format string
/// </param>
/// <param name="@__arglist">
/// arguments to @format
/// </param>

	public static void PropagatePrefixedError(IntPtr dest, MentorLake.GLib.GErrorHandle src, string format, IntPtr @__arglist)
	{
		GLibGlobalFunctionsExterns.g_propagate_prefixed_error(dest, src, format, @__arglist);
	}

/// <summary>
/// <para>
/// Checks whether @needle exists in @haystack. If the element is found, %TRUE is
/// returned and the element’s index is returned in @index_ (if non-%NULL).
/// Otherwise, %FALSE is returned and @index_ is undefined. If @needle exists
/// multiple times in @haystack, the index of the first instance is returned.
/// </para>
/// <para>
/// This does pointer comparisons only. If you want to use more complex equality
/// checks, such as string comparisons, use g_ptr_array_find_with_equal_func().
/// </para>
/// </summary>

/// <param name="haystack">
/// pointer array to be searched
/// </param>
/// <param name="needle">
/// pointer to look for
/// </param>
/// <param name="index_">
/// return location for the index of
///    the element, if found
/// </param>
/// <return>
/// %TRUE if @needle is one of the elements of @haystack
/// </return>

	public static bool PtrArrayFind(MentorLake.GLib.GPtrArrayHandle haystack, IntPtr needle, out uint index_)
	{
		return GLibGlobalFunctionsExterns.g_ptr_array_find(haystack, needle, out index_);
	}

/// <summary>
/// <para>
/// Checks whether @needle exists in @haystack, using the given @equal_func.
/// If the element is found, %TRUE is returned and the element’s index is
/// returned in @index_ (if non-%NULL). Otherwise, %FALSE is returned and @index_
/// is undefined. If @needle exists multiple times in @haystack, the index of
/// the first instance is returned.
/// </para>
/// <para>
/// @equal_func is called with the element from the array as its first parameter,
/// and @needle as its second parameter. If @equal_func is %NULL, pointer
/// equality is used.
/// </para>
/// </summary>

/// <param name="haystack">
/// pointer array to be searched
/// </param>
/// <param name="needle">
/// pointer to look for
/// </param>
/// <param name="equal_func">
/// the function to call for each element, which should
///    return %TRUE when the desired element is found; or %NULL to use pointer
///    equality
/// </param>
/// <param name="index_">
/// return location for the index of
///    the element, if found
/// </param>
/// <return>
/// %TRUE if @needle is one of the elements of @haystack
/// </return>

	public static bool PtrArrayFindWithEqualFunc(MentorLake.GLib.GPtrArrayHandle haystack, IntPtr needle, MentorLake.GLib.GEqualFunc equal_func, out uint index_)
	{
		return GLibGlobalFunctionsExterns.g_ptr_array_find_with_equal_func(haystack, needle, equal_func, out index_);
	}

/// <summary>
/// <para>
/// Creates a new #GPtrArray, copying @len pointers from @data, and setting
/// the array’s reference count to 1.
/// </para>
/// <para>
/// This avoids having to manually add each element one by one.
/// </para>
/// <para>
/// If @copy_func is provided, then it is used to copy each element before
/// adding them to the new array. If it is %NULL then the pointers are copied
/// directly.
/// </para>
/// <para>
/// It also sets @element_free_func for freeing each element when the array is
/// destroyed either via g_ptr_array_unref(), when g_ptr_array_free() is called
/// with @free_segment set to %TRUE or when removing elements.
/// </para>
/// <para>
/// Do not use it if @len is greater than %G_MAXUINT. #GPtrArray
/// stores the length of its data in #guint, which may be shorter than
/// #gsize.
/// </para>
/// </summary>

/// <param name="data">
/// an array of pointers,
/// or %NULL for an empty array
/// </param>
/// <param name="len">
/// the number of pointers in @data
/// </param>
/// <param name="copy_func">
/// a copy function used to copy every element in the
///   array or %NULL.
/// </param>
/// <param name="copy_func_user_data">
/// user data passed to @copy_func, or %NULL
/// </param>
/// <param name="element_free_func">
/// a function to free elements on @array
///   destruction or %NULL
/// </param>
/// <return>
/// A new #GPtrArray
/// </return>

	public static MentorLake.GLib.GPtrArrayHandle PtrArrayNewFromArray(IntPtr[] data, UIntPtr len, MentorLake.GLib.GCopyFunc copy_func, IntPtr copy_func_user_data, MentorLake.GLib.GDestroyNotify element_free_func)
	{
		return GLibGlobalFunctionsExterns.g_ptr_array_new_from_array(data, len, copy_func, copy_func_user_data, element_free_func);
	}

/// <summary>
/// <para>
/// Creates a new #GPtrArray copying the pointers from @data after having
/// computed the length of it and with a reference count of 1.
/// This avoids having to manually add each element one by one.
/// If @copy_func is provided, then it is used to copy the data in the new
/// array.
/// It also set @element_free_func for freeing each element when the array is
/// destroyed either via g_ptr_array_unref(), when g_ptr_array_free() is called
/// with @free_segment set to %TRUE or when removing elements.
/// </para>
/// <para>
/// Do not use it if the @data has more than %G_MAXUINT elements. #GPtrArray
/// stores the length of its data in #guint, which may be shorter than
/// #gsize.
/// </para>
/// </summary>

/// <param name="data">
/// an array of
///   pointers, %NULL terminated; or %NULL for an empty array
/// </param>
/// <param name="copy_func">
/// a copy function used to copy every element in the
///   array or %NULL.
/// </param>
/// <param name="copy_func_user_data">
/// user data passed to @copy_func, or %NULL
/// </param>
/// <param name="element_free_func">
/// a function to free elements on @array
///   destruction or %NULL
/// </param>
/// <return>
/// A new #GPtrArray
/// </return>

	public static MentorLake.GLib.GPtrArrayHandle PtrArrayNewFromNullTerminatedArray(IntPtr[] data, MentorLake.GLib.GCopyFunc copy_func, IntPtr copy_func_user_data, MentorLake.GLib.GDestroyNotify element_free_func)
	{
		return GLibGlobalFunctionsExterns.g_ptr_array_new_from_null_terminated_array(data, copy_func, copy_func_user_data, element_free_func);
	}

/// <summary>
/// <para>
/// Creates a new #GPtrArray with @data as pointers, @len as length and a
/// reference count of 1.
/// </para>
/// <para>
/// This avoids having to copy such data manually.
/// After this call, @data belongs to the #GPtrArray and may no longer be
/// modified by the caller. The memory of @data has to be dynamically
/// allocated and will eventually be freed with g_free().
/// </para>
/// <para>
/// It also sets @element_free_func for freeing each element when the array is
/// destroyed either via g_ptr_array_unref(), when g_ptr_array_free() is called
/// with @free_segment set to %TRUE or when removing elements.
/// </para>
/// <para>
/// Do not use it if @len is greater than %G_MAXUINT. #GPtrArray
/// stores the length of its data in #guint, which may be shorter than
/// #gsize.
/// </para>
/// </summary>

/// <param name="data">
/// an array of pointers,
///    or %NULL for an empty array
/// </param>
/// <param name="len">
/// the number of pointers in @data
/// </param>
/// <param name="element_free_func">
/// A function to free elements on @array
///   destruction or %NULL
/// </param>
/// <return>
/// A new #GPtrArray
/// </return>

	public static MentorLake.GLib.GPtrArrayHandle PtrArrayNewTake(IntPtr[] data, UIntPtr len, MentorLake.GLib.GDestroyNotify element_free_func)
	{
		return GLibGlobalFunctionsExterns.g_ptr_array_new_take(data, len, element_free_func);
	}

/// <summary>
/// <para>
/// Creates a new #GPtrArray with @data as pointers, computing the length of it
/// and setting the reference count to 1.
/// </para>
/// <para>
/// This avoids having to copy such data manually.
/// After this call, @data belongs to the #GPtrArray and may no longer be
/// modified by the caller. The memory of @data has to be dynamically
/// allocated and will eventually be freed with g_free().
/// </para>
/// <para>
/// The length is calculated by iterating through @data until the first %NULL
/// element is found.
/// </para>
/// <para>
/// It also sets @element_free_func for freeing each element when the array is
/// destroyed either via g_ptr_array_unref(), when g_ptr_array_free() is called
/// with @free_segment set to %TRUE or when removing elements.
/// </para>
/// <para>
/// Do not use it if the @data length is greater than %G_MAXUINT. #GPtrArray
/// stores the length of its data in #guint, which may be shorter than
/// #gsize.
/// </para>
/// </summary>

/// <param name="data">
/// an array
///  of pointers, %NULL terminated, or %NULL for an empty array
/// </param>
/// <param name="element_free_func">
/// a function to free elements on @array
///   destruction or %NULL
/// </param>
/// <return>
/// A new #GPtrArray
/// </return>

	public static MentorLake.GLib.GPtrArrayHandle PtrArrayNewTakeNullTerminated(IntPtr[] data, MentorLake.GLib.GDestroyNotify element_free_func)
	{
		return GLibGlobalFunctionsExterns.g_ptr_array_new_take_null_terminated(data, element_free_func);
	}

/// <summary>
/// <para>
/// This is just like the standard C &amp;lt;see href=&quot;man:qsort(3&quot;&amp;gt;qsort()&amp;lt;/see&amp;gt;) function, but
/// the comparison routine accepts a user data argument
/// (like &amp;lt;see href=&quot;man:qsort_r(3&quot;&amp;gt;qsort_r()&amp;lt;/see&amp;gt;)).
/// </para>
/// <para>
/// Unlike `qsort()`, this is guaranteed to be a stable sort (since GLib 2.32).
/// </para>
/// </summary>

/// <param name="pbase">
/// start of array to sort
/// </param>
/// <param name="total_elems">
/// elements in the array
/// </param>
/// <param name="size">
/// size of each element
/// </param>
/// <param name="compare_func">
/// function to compare elements
/// </param>
/// <param name="user_data">
/// data to pass to @compare_func
/// </param>

	public static void QsortWithData(IntPtr pbase, int total_elems, UIntPtr size, MentorLake.GLib.GCompareDataFunc compare_func, IntPtr user_data)
	{
		GLibGlobalFunctionsExterns.g_qsort_with_data(pbase, total_elems, size, compare_func, user_data);
	}

/// <summary>
/// <para>
/// Gets the #GQuark identifying the given (static) string. If the
/// string does not currently have an associated #GQuark, a new #GQuark
/// is created, linked to the given string.
/// </para>
/// <para>
/// Note that this function is identical to g_quark_from_string() except
/// that if a new #GQuark is created the string itself is used rather
/// than a copy. This saves memory, but can only be used if the string
/// will continue to exist until the program terminates. It can be used
/// with statically allocated strings in the main program, but not with
/// statically allocated memory in dynamically loaded modules, if you
/// expect to ever unload the module again (e.g. do not use this
/// function in GTK theme engines).
/// </para>
/// <para>
/// This function must not be used before library constructors have finished
/// running. In particular, this means it cannot be used to initialize global
/// variables in C++.
/// </para>
/// </summary>

/// <param name="@string">
/// a string
/// </param>
/// <return>
/// the #GQuark identifying the string, or 0 if @string is %NULL
/// </return>

	public static MentorLake.GLib.GQuark QuarkFromStaticString(string @string)
	{
		return GLibGlobalFunctionsExterns.g_quark_from_static_string(@string);
	}

/// <summary>
/// <para>
/// Gets the #GQuark identifying the given string. If the string does
/// not currently have an associated #GQuark, a new #GQuark is created,
/// using a copy of the string.
/// </para>
/// <para>
/// This function must not be used before library constructors have finished
/// running. In particular, this means it cannot be used to initialize global
/// variables in C++.
/// </para>
/// </summary>

/// <param name="@string">
/// a string
/// </param>
/// <return>
/// the #GQuark identifying the string, or 0 if @string is %NULL
/// </return>

	public static MentorLake.GLib.GQuark QuarkFromString(string @string)
	{
		return GLibGlobalFunctionsExterns.g_quark_from_string(@string);
	}

/// <summary>
/// <para>
/// Gets the string associated with the given #GQuark.
/// </para>
/// </summary>

/// <param name="quark">
/// a #GQuark.
/// </param>
/// <return>
/// the string associated with the #GQuark
/// </return>

	public static string QuarkToString(MentorLake.GLib.GQuark quark)
	{
		return GLibGlobalFunctionsExterns.g_quark_to_string(quark);
	}

/// <summary>
/// <para>
/// Gets the #GQuark associated with the given string, or 0 if string is
/// %NULL or it has no associated #GQuark.
/// </para>
/// <para>
/// If you want the GQuark to be created if it doesn&apos;t already exist,
/// use g_quark_from_string() or g_quark_from_static_string().
/// </para>
/// <para>
/// This function must not be used before library constructors have finished
/// running.
/// </para>
/// </summary>

/// <param name="@string">
/// a string
/// </param>
/// <return>
/// the #GQuark associated with the string, or 0 if @string is
///     %NULL or there is no #GQuark associated with it
/// </return>

	public static MentorLake.GLib.GQuark QuarkTryString(string @string)
	{
		return GLibGlobalFunctionsExterns.g_quark_try_string(@string);
	}

/// <summary>
/// <para>
/// Returns a random #gdouble equally distributed over the range [0..1).
/// </para>
/// </summary>

/// <return>
/// a random number
/// </return>

	public static double RandomDouble()
	{
		return GLibGlobalFunctionsExterns.g_random_double();
	}

/// <summary>
/// <para>
/// Returns a random #gdouble equally distributed over the range
/// [@begin..@end).
/// </para>
/// </summary>

/// <param name="begin">
/// lower closed bound of the interval
/// </param>
/// <param name="end">
/// upper open bound of the interval
/// </param>
/// <return>
/// a random number
/// </return>

	public static double RandomDoubleRange(double begin, double end)
	{
		return GLibGlobalFunctionsExterns.g_random_double_range(begin, end);
	}

/// <summary>
/// <para>
/// Return a random #guint32 equally distributed over the range
/// [0..2^32-1].
/// </para>
/// </summary>

/// <return>
/// a random number
/// </return>

	public static uint RandomInt()
	{
		return GLibGlobalFunctionsExterns.g_random_int();
	}

/// <summary>
/// <para>
/// Returns a random #gint32 equally distributed over the range
/// [@begin..@end-1].
/// </para>
/// </summary>

/// <param name="begin">
/// lower closed bound of the interval
/// </param>
/// <param name="end">
/// upper open bound of the interval
/// </param>
/// <return>
/// a random number
/// </return>

	public static int RandomIntRange(int begin, int end)
	{
		return GLibGlobalFunctionsExterns.g_random_int_range(begin, end);
	}

/// <summary>
/// <para>
/// Sets the seed for the global random number generator, which is used
/// by the g_random_* functions, to @seed.
/// </para>
/// </summary>

/// <param name="seed">
/// a value to reinitialize the global random number generator
/// </param>

	public static void RandomSetSeed(uint seed)
	{
		GLibGlobalFunctionsExterns.g_random_set_seed(seed);
	}

/// <summary>
/// <para>
/// Acquires a reference on the data pointed by @mem_block.
/// </para>
/// </summary>

/// <param name="mem_block">
/// a pointer to reference counted data
/// </param>
/// <return>
/// a pointer to the data,
///   with its reference count increased
/// </return>

	public static IntPtr RcBoxAcquire(IntPtr mem_block)
	{
		return GLibGlobalFunctionsExterns.g_rc_box_acquire(mem_block);
	}

/// <summary>
/// <para>
/// Allocates @block_size bytes of memory, and adds reference
/// counting semantics to it.
/// </para>
/// <para>
/// The data will be freed when its reference count drops to
/// zero.
/// </para>
/// <para>
/// The allocated data is guaranteed to be suitably aligned for any
/// built-in type.
/// </para>
/// </summary>

/// <param name="block_size">
/// the size of the allocation, must be greater than 0
/// </param>
/// <return>
/// a pointer to the allocated memory
/// </return>

	public static IntPtr RcBoxAlloc(UIntPtr block_size)
	{
		return GLibGlobalFunctionsExterns.g_rc_box_alloc(block_size);
	}

/// <summary>
/// <para>
/// Allocates @block_size bytes of memory, and adds reference
/// counting semantics to it.
/// </para>
/// <para>
/// The contents of the returned data is set to zero.
/// </para>
/// <para>
/// The data will be freed when its reference count drops to
/// zero.
/// </para>
/// <para>
/// The allocated data is guaranteed to be suitably aligned for any
/// built-in type.
/// </para>
/// </summary>

/// <param name="block_size">
/// the size of the allocation, must be greater than 0
/// </param>
/// <return>
/// a pointer to the allocated memory
/// </return>

	public static IntPtr RcBoxAlloc0(UIntPtr block_size)
	{
		return GLibGlobalFunctionsExterns.g_rc_box_alloc0(block_size);
	}

/// <summary>
/// <para>
/// Allocates a new block of data with reference counting
/// semantics, and copies @block_size bytes of @mem_block
/// into it.
/// </para>
/// </summary>

/// <param name="block_size">
/// the number of bytes to copy, must be greater than 0
/// </param>
/// <param name="mem_block">
/// the memory to copy
/// </param>
/// <return>
/// a pointer to the allocated
///   memory
/// </return>

	public static IntPtr RcBoxDup(UIntPtr block_size, IntPtr mem_block)
	{
		return GLibGlobalFunctionsExterns.g_rc_box_dup(block_size, mem_block);
	}

/// <summary>
/// <para>
/// Retrieves the size of the reference counted data pointed by @mem_block.
/// </para>
/// </summary>

/// <param name="mem_block">
/// a pointer to reference counted data
/// </param>
/// <return>
/// the size of the data, in bytes
/// </return>

	public static UIntPtr RcBoxGetSize(IntPtr mem_block)
	{
		return GLibGlobalFunctionsExterns.g_rc_box_get_size(mem_block);
	}

/// <summary>
/// <para>
/// Releases a reference on the data pointed by @mem_block.
/// </para>
/// <para>
/// If the reference was the last one, it will free the
/// resources allocated for @mem_block.
/// </para>
/// </summary>

/// <param name="mem_block">
/// a pointer to reference counted data
/// </param>

	public static void RcBoxRelease(IntPtr mem_block)
	{
		GLibGlobalFunctionsExterns.g_rc_box_release(mem_block);
	}

/// <summary>
/// <para>
/// Releases a reference on the data pointed by @mem_block.
/// </para>
/// <para>
/// If the reference was the last one, it will call @clear_func
/// to clear the contents of @mem_block, and then will free the
/// resources allocated for @mem_block.
/// </para>
/// </summary>

/// <param name="mem_block">
/// a pointer to reference counted data
/// </param>
/// <param name="clear_func">
/// a function to call when clearing the data
/// </param>

	public static void RcBoxReleaseFull(IntPtr mem_block, MentorLake.GLib.GDestroyNotify clear_func)
	{
		GLibGlobalFunctionsExterns.g_rc_box_release_full(mem_block, clear_func);
	}

/// <summary>
/// <para>
/// Reallocates the memory pointed to by @mem, so that it now has space for
/// @n_bytes bytes of memory. It returns the new address of the memory, which may
/// have been moved. @mem may be %NULL, in which case it&apos;s considered to
/// have zero-length. @n_bytes may be 0, in which case %NULL will be returned
/// and @mem will be freed unless it is %NULL.
/// </para>
/// <para>
/// If the allocation fails (because the system is out of memory),
/// the program is terminated.
/// </para>
/// </summary>

/// <param name="mem">
/// the memory to reallocate
/// </param>
/// <param name="n_bytes">
/// new size of the memory in bytes
/// </param>
/// <return>
/// the new address of the allocated memory
/// </return>

	public static IntPtr Realloc(IntPtr mem, UIntPtr n_bytes)
	{
		return GLibGlobalFunctionsExterns.g_realloc(mem, n_bytes);
	}

/// <summary>
/// <para>
/// This function is similar to g_realloc(), allocating (@n_blocks * @n_block_bytes) bytes,
/// but care is taken to detect possible overflow during multiplication.
/// </para>
/// <para>
/// If the allocation fails (because the system is out of memory),
/// the program is terminated.
/// </para>
/// </summary>

/// <param name="mem">
/// the memory to reallocate
/// </param>
/// <param name="n_blocks">
/// the number of blocks to allocate
/// </param>
/// <param name="n_block_bytes">
/// the size of each block in bytes
/// </param>
/// <return>
/// the new address of the allocated memory
/// </return>

	public static IntPtr ReallocN(IntPtr mem, UIntPtr n_blocks, UIntPtr n_block_bytes)
	{
		return GLibGlobalFunctionsExterns.g_realloc_n(mem, n_blocks, n_block_bytes);
	}

/// <summary>
/// <para>
/// Compares the current value of @rc with @val.
/// </para>
/// </summary>

/// <param name="rc">
/// the address of a reference count variable
/// </param>
/// <param name="val">
/// the value to compare
/// </param>
/// <return>
/// %TRUE if the reference count is the same
///   as the given value
/// </return>

	public static bool RefCountCompare(int rc, int val)
	{
		return GLibGlobalFunctionsExterns.g_ref_count_compare(rc, val);
	}

/// <summary>
/// <para>
/// Decreases the reference count.
/// </para>
/// <para>
/// If %TRUE is returned, the reference count reached 0. After this point, @rc
/// is an undefined state and must be reinitialized with
/// g_ref_count_init() to be used again.
/// </para>
/// </summary>

/// <param name="rc">
/// the address of a reference count variable
/// </param>
/// <return>
/// %TRUE if the reference count reached 0, and %FALSE otherwise
/// </return>

	public static bool RefCountDec(int rc)
	{
		return GLibGlobalFunctionsExterns.g_ref_count_dec(rc);
	}

/// <summary>
/// <para>
/// Increases the reference count.
/// </para>
/// </summary>

/// <param name="rc">
/// the address of a reference count variable
/// </param>

	public static void RefCountInc(int rc)
	{
		GLibGlobalFunctionsExterns.g_ref_count_inc(rc);
	}

/// <summary>
/// <para>
/// Initializes a reference count variable to 1.
/// </para>
/// </summary>

/// <param name="rc">
/// the address of a reference count variable
/// </param>

	public static void RefCountInit(int rc)
	{
		GLibGlobalFunctionsExterns.g_ref_count_init(rc);
	}

/// <summary>
/// <para>
/// Acquires a reference on a string.
/// </para>
/// </summary>

/// <param name="str">
/// a reference counted string
/// </param>
/// <return>
/// the given string, with its reference count increased
/// </return>

	public static string RefStringAcquire(string str)
	{
		return GLibGlobalFunctionsExterns.g_ref_string_acquire(str);
	}

/// <summary>
/// <para>
/// Compares two ref-counted strings for byte-by-byte equality.
/// </para>
/// <para>
/// It can be passed to [func@GLib.HashTable.new] as the key equality function,
/// and behaves exactly the same as [func@GLib.str_equal] (or `strcmp()`), but
/// can return slightly faster as it can check the string lengths before checking
/// all the bytes.
/// </para>
/// </summary>

/// <param name="str1">
/// a reference counted string
/// </param>
/// <param name="str2">
/// a reference counted string
/// </param>
/// <return>
/// `TRUE` if the strings are equal, otherwise `FALSE`
/// </return>

	public static bool RefStringEqual(string str1, string str2)
	{
		return GLibGlobalFunctionsExterns.g_ref_string_equal(str1, str2);
	}

/// <summary>
/// <para>
/// Retrieves the length of @str.
/// </para>
/// </summary>

/// <param name="str">
/// a reference counted string
/// </param>
/// <return>
/// the length of the given string, in bytes
/// </return>

	public static UIntPtr RefStringLength(string str)
	{
		return GLibGlobalFunctionsExterns.g_ref_string_length(str);
	}

/// <summary>
/// <para>
/// Creates a new reference counted string and copies the contents of @str
/// into it.
/// </para>
/// </summary>

/// <param name="str">
/// a NUL-terminated string
/// </param>
/// <return>
/// the newly created reference counted string
/// </return>

	public static string RefStringNew(string str)
	{
		return GLibGlobalFunctionsExterns.g_ref_string_new(str);
	}

/// <summary>
/// <para>
/// Creates a new reference counted string and copies the content of @str
/// into it.
/// </para>
/// <para>
/// If you call this function multiple times with the same @str, or with
/// the same contents of @str, it will return a new reference, instead of
/// creating a new string.
/// </para>
/// </summary>

/// <param name="str">
/// a NUL-terminated string
/// </param>
/// <return>
/// the newly created reference
///   counted string, or a new reference to an existing string
/// </return>

	public static string RefStringNewIntern(string str)
	{
		return GLibGlobalFunctionsExterns.g_ref_string_new_intern(str);
	}

/// <summary>
/// <para>
/// Creates a new reference counted string and copies the contents of @str
/// into it, up to @len bytes.
/// </para>
/// <para>
/// Since this function does not stop at nul bytes, it is the caller&apos;s
/// responsibility to ensure that @str has at least @len addressable bytes.
/// </para>
/// </summary>

/// <param name="str">
/// a string
/// </param>
/// <param name="len">
/// length of @str to use, or -1 if @str is nul-terminated
/// </param>
/// <return>
/// the newly created reference counted string
/// </return>

	public static string RefStringNewLen(string str, UIntPtr len)
	{
		return GLibGlobalFunctionsExterns.g_ref_string_new_len(str, len);
	}

/// <summary>
/// <para>
/// Releases a reference on a string; if it was the last reference, the
/// resources allocated by the string are freed as well.
/// </para>
/// </summary>

/// <param name="str">
/// a reference counted string
/// </param>

	public static void RefStringRelease(string str)
	{
		GLibGlobalFunctionsExterns.g_ref_string_release(str);
	}

/// <summary>
/// <para>
/// Checks whether @replacement is a valid replacement string
/// (see g_regex_replace()), i.e. that all escape sequences in
/// it are valid.
/// </para>
/// <para>
/// If @has_references is not %NULL then @replacement is checked
/// for pattern references. For instance, replacement text &apos;foo\n&apos;
/// does not contain references and may be evaluated without information
/// about actual match, but &apos;\0\1&apos; (whole match followed by first
/// subpattern) requires valid #GMatchInfo object.
/// </para>
/// </summary>

/// <param name="replacement">
/// the replacement string
/// </param>
/// <param name="has_references">
/// location to store information about
///   references in @replacement or %NULL
/// </param>
/// <return>
/// whether @replacement is a valid replacement string
/// </return>

	public static bool RegexCheckReplacement(string replacement, out bool has_references)
	{
		var externCallResult = GLibGlobalFunctionsExterns.g_regex_check_replacement(replacement, out has_references, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}



	public static MentorLake.GLib.GQuark RegexErrorQuark()
	{
		return GLibGlobalFunctionsExterns.g_regex_error_quark();
	}

/// <summary>
/// <para>
/// Escapes the nul characters in @string to &quot;\x00&quot;.  It can be used
/// to compile a regex with embedded nul characters.
/// </para>
/// <para>
/// For completeness, @length can be -1 for a nul-terminated string.
/// In this case the output string will be of course equal to @string.
/// </para>
/// </summary>

/// <param name="@string">
/// the string to escape
/// </param>
/// <param name="length">
/// the length of @string
/// </param>
/// <return>
/// a newly-allocated escaped string
/// </return>

	public static string RegexEscapeNul(string @string, int length)
	{
		return GLibGlobalFunctionsExterns.g_regex_escape_nul(@string, length);
	}

/// <summary>
/// <para>
/// Escapes the special characters used for regular expressions
/// in @string, for instance &quot;a.b*c&quot; becomes &quot;a\.b\*c&quot;. This
/// function is useful to dynamically generate regular expressions.
/// </para>
/// <para>
/// @string can contain nul characters that are replaced with &quot;\0&quot;,
/// in this case remember to specify the correct length of @string
/// in @length.
/// </para>
/// </summary>

/// <param name="@string">
/// the string to escape
/// </param>
/// <param name="length">
/// the length of @string, in bytes, or -1 if @string is nul-terminated
/// </param>
/// <return>
/// a newly-allocated escaped string
/// </return>

	public static string RegexEscapeString(string @string, int length)
	{
		return GLibGlobalFunctionsExterns.g_regex_escape_string(@string, length);
	}

/// <summary>
/// <para>
/// Scans for a match in @string for @pattern.
/// </para>
/// <para>
/// This function is equivalent to g_regex_match() but it does not
/// require to compile the pattern with g_regex_new(), avoiding some
/// lines of code when you need just to do a match without extracting
/// substrings, capture counts, and so on.
/// </para>
/// <para>
/// If this function is to be called on the same @pattern more than
/// once, it&apos;s more efficient to compile the pattern once with
/// g_regex_new() and then use g_regex_match().
/// </para>
/// </summary>

/// <param name="pattern">
/// the regular expression
/// </param>
/// <param name="@string">
/// the string to scan for matches
/// </param>
/// <param name="compile_options">
/// compile options for the regular expression, or 0
/// </param>
/// <param name="match_options">
/// match options, or 0
/// </param>
/// <return>
/// %TRUE if the string matched, %FALSE otherwise
/// </return>

	public static bool RegexMatchSimple(string pattern, string @string, MentorLake.GLib.GRegexCompileFlags compile_options, MentorLake.GLib.GRegexMatchFlags match_options)
	{
		return GLibGlobalFunctionsExterns.g_regex_match_simple(pattern, @string, compile_options, match_options);
	}

/// <summary>
/// <para>
/// Breaks the string on the pattern, and returns an array of
/// the tokens. If the pattern contains capturing parentheses,
/// then the text for each of the substrings will also be returned.
/// If the pattern does not match anywhere in the string, then the
/// whole string is returned as the first token.
/// </para>
/// <para>
/// This function is equivalent to g_regex_split() but it does
/// not require to compile the pattern with g_regex_new(), avoiding
/// some lines of code when you need just to do a split without
/// extracting substrings, capture counts, and so on.
/// </para>
/// <para>
/// If this function is to be called on the same @pattern more than
/// once, it&apos;s more efficient to compile the pattern once with
/// g_regex_new() and then use g_regex_split().
/// </para>
/// <para>
/// As a special case, the result of splitting the empty string &quot;&quot;
/// is an empty vector, not a vector containing a single string.
/// The reason for this special case is that being able to represent
/// an empty vector is typically more useful than consistent handling
/// of empty elements. If you do need to represent empty elements,
/// you&apos;ll need to check for the empty string before calling this
/// function.
/// </para>
/// <para>
/// A pattern that can match empty strings splits @string into
/// separate characters wherever it matches the empty string between
/// characters. For example splitting &quot;ab c&quot; using as a separator
/// &quot;\s*&quot;, you will get &quot;a&quot;, &quot;b&quot; and &quot;c&quot;.
/// </para>
/// </summary>

/// <param name="pattern">
/// the regular expression
/// </param>
/// <param name="@string">
/// the string to scan for matches
/// </param>
/// <param name="compile_options">
/// compile options for the regular expression, or 0
/// </param>
/// <param name="match_options">
/// match options, or 0
/// </param>
/// <return>
/// a %NULL-terminated array of strings. Free
/// it using g_strfreev()
/// </return>

	public static string[] RegexSplitSimple(string pattern, string @string, MentorLake.GLib.GRegexCompileFlags compile_options, MentorLake.GLib.GRegexMatchFlags match_options)
	{
		return GLibGlobalFunctionsExterns.g_regex_split_simple(pattern, @string, compile_options, match_options);
	}

/// <summary>
/// <para>
/// Resets the cache used for g_get_user_special_dir(), so
/// that the latest on-disk version is used. Call this only
/// if you just changed the data on disk yourself.
/// </para>
/// <para>
/// Due to thread safety issues this may cause leaking of strings
/// that were previously returned from g_get_user_special_dir()
/// that can&apos;t be freed. We ensure to only leak the data for
/// the directories that actually changed value though.
/// </para>
/// </summary>


	public static void ReloadUserSpecialDirsCache()
	{
		GLibGlobalFunctionsExterns.g_reload_user_special_dirs_cache();
	}

/// <summary>
/// <para>
/// A wrapper for the POSIX remove() function. The remove() function
/// deletes a name from the filesystem.
/// </para>
/// <para>
/// See your C library manual for more details about how remove() works
/// on your system. On Unix, remove() removes also directories, as it
/// calls unlink() for files and rmdir() for directories. On Windows,
/// although remove() in the C library only works for files, this
/// function tries first remove() and then if that fails rmdir(), and
/// thus works for both files and directories. Note however, that on
/// Windows, it is in general not possible to remove a file that is
/// open to some process, or mapped into memory.
/// </para>
/// <para>
/// If this function fails on Windows you can&apos;t infer too much from the
/// errno value. rmdir() is tried regardless of what caused remove() to
/// fail. Any errno value set by remove() will be overwritten by that
/// set by rmdir().
/// </para>
/// </summary>

/// <param name="filename">
/// a pathname in the GLib file name encoding
///     (UTF-8 on Windows)
/// </param>
/// <return>
/// 0 if the file was successfully removed, -1 if an error
///    occurred
/// </return>

	public static int Remove(string filename)
	{
		return GLibGlobalFunctionsExterns.g_remove(filename);
	}

/// <summary>
/// <para>
/// A wrapper for the POSIX rename() function. The rename() function
/// renames a file, moving it between directories if required.
/// </para>
/// <para>
/// See your C library manual for more details about how rename() works
/// on your system. It is not possible in general on Windows to rename
/// a file that is open to some process.
/// </para>
/// </summary>

/// <param name="oldfilename">
/// a pathname in the GLib file name encoding
///     (UTF-8 on Windows)
/// </param>
/// <param name="newfilename">
/// a pathname in the GLib file name encoding
/// </param>
/// <return>
/// 0 if the renaming succeeded, -1 if an error occurred
/// </return>

	public static int Rename(string oldfilename, string newfilename)
	{
		return GLibGlobalFunctionsExterns.g_rename(oldfilename, newfilename);
	}

/// <summary>
/// <para>
/// Internal function used to print messages from the public [func@GLib.return_if_fail]
/// and [func@GLib.return_val_if_fail] macros.
/// </para>
/// </summary>

/// <param name="log_domain">
/// log domain
/// </param>
/// <param name="pretty_function">
/// function containing the assertion
/// </param>
/// <param name="expression">
/// expression which failed
/// </param>

	public static void ReturnIfFailWarning(string log_domain, string pretty_function, string expression)
	{
		GLibGlobalFunctionsExterns.g_return_if_fail_warning(log_domain, pretty_function, expression);
	}

/// <summary>
/// <para>
/// A wrapper for the POSIX rmdir() function. The rmdir() function
/// deletes a directory from the filesystem.
/// </para>
/// <para>
/// See your C library manual for more details about how rmdir() works
/// on your system.
/// </para>
/// </summary>

/// <param name="filename">
/// a pathname in the GLib file name encoding
///     (UTF-8 on Windows)
/// </param>
/// <return>
/// 0 if the directory was successfully removed, -1 if an error
///    occurred
/// </return>

	public static int Rmdir(string filename)
	{
		return GLibGlobalFunctionsExterns.g_rmdir(filename);
	}

/// <summary>
/// <para>
/// Calls @func for each item in the range (@begin, @end) passing
/// @user_data to the function. @func must not modify the sequence
/// itself.
/// </para>
/// </summary>

/// <param name="begin">
/// a #GSequenceIter
/// </param>
/// <param name="end">
/// a #GSequenceIter
/// </param>
/// <param name="func">
/// a #GFunc
/// </param>
/// <param name="user_data">
/// user data passed to @func
/// </param>

	public static void SequenceForeachRange(MentorLake.GLib.GSequenceIterHandle begin, MentorLake.GLib.GSequenceIterHandle end, MentorLake.GLib.GFunc func, IntPtr user_data)
	{
		GLibGlobalFunctionsExterns.g_sequence_foreach_range(begin, end, func, user_data);
	}

/// <summary>
/// <para>
/// Returns the data that @iter points to.
/// </para>
/// </summary>

/// <param name="iter">
/// a #GSequenceIter
/// </param>
/// <return>
/// the data that @iter points to
/// </return>

	public static IntPtr SequenceGet(MentorLake.GLib.GSequenceIterHandle iter)
	{
		return GLibGlobalFunctionsExterns.g_sequence_get(iter);
	}

/// <summary>
/// <para>
/// Inserts a new item just before the item pointed to by @iter.
/// </para>
/// </summary>

/// <param name="iter">
/// a #GSequenceIter
/// </param>
/// <param name="data">
/// the data for the new item
/// </param>
/// <return>
/// an iterator pointing to the new item
/// </return>

	public static MentorLake.GLib.GSequenceIterHandle SequenceInsertBefore(MentorLake.GLib.GSequenceIterHandle iter, IntPtr data)
	{
		return GLibGlobalFunctionsExterns.g_sequence_insert_before(iter, data);
	}

/// <summary>
/// <para>
/// Moves the item pointed to by @src to the position indicated by @dest.
/// After calling this function @dest will point to the position immediately
/// after @src. It is allowed for @src and @dest to point into different
/// sequences.
/// </para>
/// </summary>

/// <param name="src">
/// a #GSequenceIter pointing to the item to move
/// </param>
/// <param name="dest">
/// a #GSequenceIter pointing to the position to which
///     the item is moved
/// </param>

	public static void SequenceMove(MentorLake.GLib.GSequenceIterHandle src, MentorLake.GLib.GSequenceIterHandle dest)
	{
		GLibGlobalFunctionsExterns.g_sequence_move(src, dest);
	}

/// <summary>
/// <para>
/// Inserts the (@begin, @end) range at the destination pointed to by @dest.
/// The @begin and @end iters must point into the same sequence. It is
/// allowed for @dest to point to a different sequence than the one pointed
/// into by @begin and @end.
/// </para>
/// <para>
/// If @dest is %NULL, the range indicated by @begin and @end is
/// removed from the sequence. If @dest points to a place within
/// the (@begin, @end) range, the range does not move.
/// </para>
/// </summary>

/// <param name="dest">
/// a #GSequenceIter
/// </param>
/// <param name="begin">
/// a #GSequenceIter
/// </param>
/// <param name="end">
/// a #GSequenceIter
/// </param>

	public static void SequenceMoveRange(MentorLake.GLib.GSequenceIterHandle dest, MentorLake.GLib.GSequenceIterHandle begin, MentorLake.GLib.GSequenceIterHandle end)
	{
		GLibGlobalFunctionsExterns.g_sequence_move_range(dest, begin, end);
	}

/// <summary>
/// <para>
/// Finds an iterator somewhere in the range (@begin, @end). This
/// iterator will be close to the middle of the range, but is not
/// guaranteed to be exactly in the middle.
/// </para>
/// <para>
/// The @begin and @end iterators must both point to the same sequence
/// and @begin must come before or be equal to @end in the sequence.
/// </para>
/// </summary>

/// <param name="begin">
/// a #GSequenceIter
/// </param>
/// <param name="end">
/// a #GSequenceIter
/// </param>
/// <return>
/// a #GSequenceIter pointing somewhere in the
///    (@begin, @end) range
/// </return>

	public static MentorLake.GLib.GSequenceIterHandle SequenceRangeGetMidpoint(MentorLake.GLib.GSequenceIterHandle begin, MentorLake.GLib.GSequenceIterHandle end)
	{
		return GLibGlobalFunctionsExterns.g_sequence_range_get_midpoint(begin, end);
	}

/// <summary>
/// <para>
/// Removes the item pointed to by @iter. It is an error to pass the
/// end iterator to this function.
/// </para>
/// <para>
/// If the sequence has a data destroy function associated with it, this
/// function is called on the data for the removed item.
/// </para>
/// </summary>

/// <param name="iter">
/// a #GSequenceIter
/// </param>

	public static void SequenceRemove(MentorLake.GLib.GSequenceIterHandle iter)
	{
		GLibGlobalFunctionsExterns.g_sequence_remove(iter);
	}

/// <summary>
/// <para>
/// Removes all items in the (@begin, @end) range.
/// </para>
/// <para>
/// If the sequence has a data destroy function associated with it, this
/// function is called on the data for the removed items.
/// </para>
/// </summary>

/// <param name="begin">
/// a #GSequenceIter
/// </param>
/// <param name="end">
/// a #GSequenceIter
/// </param>

	public static void SequenceRemoveRange(MentorLake.GLib.GSequenceIterHandle begin, MentorLake.GLib.GSequenceIterHandle end)
	{
		GLibGlobalFunctionsExterns.g_sequence_remove_range(begin, end);
	}

/// <summary>
/// <para>
/// Changes the data for the item pointed to by @iter to be @data. If
/// the sequence has a data destroy function associated with it, that
/// function is called on the existing data that @iter pointed to.
/// </para>
/// </summary>

/// <param name="iter">
/// a #GSequenceIter
/// </param>
/// <param name="data">
/// new data for the item
/// </param>

	public static void SequenceSet(MentorLake.GLib.GSequenceIterHandle iter, IntPtr data)
	{
		GLibGlobalFunctionsExterns.g_sequence_set(iter, data);
	}

/// <summary>
/// <para>
/// Moves the data pointed to by @iter to a new position as indicated by
/// @cmp_func. This
/// function should be called for items in a sequence already sorted according
/// to @cmp_func whenever some aspect of an item changes so that @cmp_func
/// may return different values for that item.
/// </para>
/// <para>
/// @cmp_func is called with two items of the @seq, and @cmp_data.
/// It should return 0 if the items are equal, a negative value if
/// the first item comes before the second, and a positive value if
/// the second item comes before the first.
/// </para>
/// </summary>

/// <param name="iter">
/// A #GSequenceIter
/// </param>
/// <param name="cmp_func">
/// the function used to compare items in the sequence
/// </param>
/// <param name="cmp_data">
/// user data passed to @cmp_func.
/// </param>

	public static void SequenceSortChanged(MentorLake.GLib.GSequenceIterHandle iter, MentorLake.GLib.GCompareDataFunc cmp_func, IntPtr cmp_data)
	{
		GLibGlobalFunctionsExterns.g_sequence_sort_changed(iter, cmp_func, cmp_data);
	}

/// <summary>
/// <para>
/// Like g_sequence_sort_changed(), but uses
/// a #GSequenceIterCompareFunc instead of a #GCompareDataFunc as
/// the compare function.
/// </para>
/// <para>
/// @iter_cmp is called with two iterators pointing into the #GSequence that
/// @iter points into. It should
/// return 0 if the iterators are equal, a negative value if the first
/// iterator comes before the second, and a positive value if the second
/// iterator comes before the first.
/// </para>
/// </summary>

/// <param name="iter">
/// a #GSequenceIter
/// </param>
/// <param name="iter_cmp">
/// the function used to compare iterators in the sequence
/// </param>
/// <param name="cmp_data">
/// user data passed to @cmp_func
/// </param>

	public static void SequenceSortChangedIter(MentorLake.GLib.GSequenceIterHandle iter, MentorLake.GLib.GSequenceIterCompareFunc iter_cmp, IntPtr cmp_data)
	{
		GLibGlobalFunctionsExterns.g_sequence_sort_changed_iter(iter, iter_cmp, cmp_data);
	}

/// <summary>
/// <para>
/// Swaps the items pointed to by @a and @b. It is allowed for @a and @b
/// to point into difference sequences.
/// </para>
/// </summary>

/// <param name="a">
/// a #GSequenceIter
/// </param>
/// <param name="b">
/// a #GSequenceIter
/// </param>

	public static void SequenceSwap(MentorLake.GLib.GSequenceIterHandle a, MentorLake.GLib.GSequenceIterHandle b)
	{
		GLibGlobalFunctionsExterns.g_sequence_swap(a, b);
	}

/// <summary>
/// <para>
/// Sets a human-readable name for the application. This name should be
/// localized if possible, and is intended for display to the user.
/// Contrast with g_set_prgname(), which sets a non-localized name.
/// g_set_prgname() will be called automatically by gtk_init(),
/// but g_set_application_name() will not.
/// </para>
/// <para>
/// Note that for thread safety reasons, this function can only
/// be called once.
/// </para>
/// <para>
/// The application name will be used in contexts such as error messages,
/// or when displaying an application&apos;s name in the task list.
/// </para>
/// </summary>

/// <param name="application_name">
/// localized name of the application
/// </param>

	public static void SetApplicationName(string application_name)
	{
		GLibGlobalFunctionsExterns.g_set_application_name(application_name);
	}

/// <summary>
/// <para>
/// Does nothing if @err is %NULL; if @err is non-%NULL, then `*err`
/// must be %NULL. A new #GError is created and assigned to `*err`.
/// </para>
/// </summary>

/// <param name="err">
/// a return location for a #GError
/// </param>
/// <param name="domain">
/// error domain
/// </param>
/// <param name="code">
/// error code
/// </param>
/// <param name="format">
/// printf()-style format
/// </param>
/// <param name="@__arglist">
/// args for @format
/// </param>

	public static void SetError(out MentorLake.GLib.GErrorHandle err, MentorLake.GLib.GQuark domain, int code, string format, IntPtr @__arglist)
	{
		GLibGlobalFunctionsExterns.g_set_error(out err, domain, code, format, @__arglist);
	}

/// <summary>
/// <para>
/// Does nothing if @err is %NULL; if @err is non-%NULL, then `*err`
/// must be %NULL. A new #GError is created and assigned to `*err`.
/// Unlike g_set_error(), @message is not a printf()-style format string.
/// Use this function if @message contains text you don&apos;t have control over,
/// that could include printf() escape sequences.
/// </para>
/// </summary>

/// <param name="err">
/// a return location for a #GError
/// </param>
/// <param name="domain">
/// error domain
/// </param>
/// <param name="code">
/// error code
/// </param>
/// <param name="message">
/// error message
/// </param>

	public static void SetErrorLiteral(out MentorLake.GLib.GErrorHandle err, MentorLake.GLib.GQuark domain, int code, string message)
	{
		GLibGlobalFunctionsExterns.g_set_error_literal(out err, domain, code, message);
	}

/// <summary>
/// <para>
/// Sets the name of the program. This name should not be localized,
/// in contrast to g_set_application_name().
/// </para>
/// <para>
/// If you are using #GApplication the program name is set in
/// g_application_run(). In case of GDK or GTK it is set in
/// gdk_init(), which is called by gtk_init() and the
/// #GtkApplication::startup handler. The program name is found by
/// taking the last component of @argv[0].
/// </para>
/// <para>
/// Since GLib 2.72, this function can be called multiple times
/// and is fully thread safe. Prior to GLib 2.72, this function
/// could only be called once per process.
/// </para>
/// </summary>

/// <param name="prgname">
/// the name of the program.
/// </param>

	public static void SetPrgname(string prgname)
	{
		GLibGlobalFunctionsExterns.g_set_prgname(prgname);
	}

/// <summary>
/// <para>
/// Sets the print handler to @func, or resets it to the
/// default GLib handler if `NULL`.
/// </para>
/// <para>
/// Any messages passed to [func@GLib.print] will be output via
/// the new handler. The default handler outputs
/// the encoded message to `stdout`. By providing your own handler
/// you can redirect the output, to a GTK widget or a
/// log file for example.
/// </para>
/// <para>
/// Since 2.76 this functions always returns a valid
/// [type@GLib.PrintFunc], and never returns `NULL`. If no custom
/// print handler was set, it will return the GLib
/// default print handler and that can be re-used to
/// decorate its output and/or to write to `stderr`
/// in all platforms. Before GLib 2.76, this was `NULL`.
/// </para>
/// </summary>

/// <param name="func">
/// the new print handler or `NULL` to
///   reset to the default
/// </param>
/// <return>
/// the old print handler
/// </return>

	public static MentorLake.GLib.GPrintFunc SetPrintHandler(MentorLake.GLib.GPrintFunc func)
	{
		return GLibGlobalFunctionsExterns.g_set_print_handler(func);
	}

/// <summary>
/// <para>
/// Sets the handler for printing error messages to @func,
/// or resets it to the default GLib handler if `NULL`.
/// </para>
/// <para>
/// Any messages passed to [func@GLib.printerr] will be output via
/// the new handler. The default handler outputs the encoded
/// message to `stderr`. By providing your own handler you can
/// redirect the output, to a GTK widget or a log file for
/// example.
/// </para>
/// <para>
/// Since 2.76 this functions always returns a valid
/// [type@GLib.PrintFunc], and never returns `NULL`. If no custom error
/// print handler was set, it will return the GLib default
/// error print handler and that can be re-used to decorate
/// its output and/or to write to `stderr` in all platforms.
/// Before GLib 2.76, this was `NULL`.
/// </para>
/// </summary>

/// <param name="func">
/// he new error message handler or `NULL`
///   to reset to the default
/// </param>
/// <return>
/// the old error message handler
/// </return>

	public static MentorLake.GLib.GPrintFunc SetPrinterrHandler(MentorLake.GLib.GPrintFunc func)
	{
		return GLibGlobalFunctionsExterns.g_set_printerr_handler(func);
	}

/// <summary>
/// <para>
/// Sets an environment variable. On UNIX, both the variable&apos;s name and
/// value can be arbitrary byte strings, except that the variable&apos;s name
/// cannot contain &apos;=&apos;. On Windows, they should be in UTF-8.
/// </para>
/// <para>
/// Note that on some systems, when variables are overwritten, the memory
/// used for the previous variables and its value isn&apos;t reclaimed.
/// </para>
/// <para>
/// You should be mindful of the fact that environment variable handling
/// in UNIX is not thread-safe, and your program may crash if one thread
/// calls g_setenv() while another thread is calling getenv(). (And note
/// that many functions, such as gettext(), call getenv() internally.)
/// This function is only safe to use at the very start of your program,
/// before creating any other threads (or creating objects that create
/// worker threads of their own).
/// </para>
/// <para>
/// If you need to set up the environment for a child process, you can
/// use g_get_environ() to get an environment array, modify that with
/// g_environ_setenv() and g_environ_unsetenv(), and then pass that
/// array directly to execvpe(), g_spawn_async(), or the like.
/// </para>
/// </summary>

/// <param name="variable">
/// the environment variable to set, must not
///     contain &apos;=&apos;.
/// </param>
/// <param name="value">
/// the value for to set the variable to.
/// </param>
/// <param name="overwrite">
/// whether to change the variable if it already exists.
/// </param>
/// <return>
/// %FALSE if the environment variable couldn&apos;t be set.
/// </return>

	public static bool Setenv(string variable, string value, bool overwrite)
	{
		return GLibGlobalFunctionsExterns.g_setenv(variable, value, overwrite);
	}



	public static MentorLake.GLib.GQuark ShellErrorQuark()
	{
		return GLibGlobalFunctionsExterns.g_shell_error_quark();
	}

/// <summary>
/// <para>
/// Parses a command line into an argument vector, in much the same way
/// the shell would, but without many of the expansions the shell would
/// perform (variable expansion, globs, operators, filename expansion,
/// etc. are not supported).
/// </para>
/// <para>
/// The results are defined to be the same as those you would get from
/// a UNIX98 `/bin/sh`, as long as the input contains none of the
/// unsupported shell expansions. If the input does contain such expansions,
/// they are passed through literally.
/// </para>
/// <para>
/// Possible errors are those from the %G_SHELL_ERROR domain.
/// </para>
/// <para>
/// In particular, if @command_line is an empty string (or a string containing
/// only whitespace), %G_SHELL_ERROR_EMPTY_STRING will be returned. It’s
/// guaranteed that @argvp will be a non-empty array if this function returns
/// successfully.
/// </para>
/// <para>
/// Free the returned vector with g_strfreev().
/// </para>
/// </summary>

/// <param name="command_line">
/// command line to parse
/// </param>
/// <param name="argcp">
/// return location for number of args
/// </param>
/// <param name="argvp">
/// 
///   return location for array of args
/// </param>
/// <return>
/// %TRUE on success, %FALSE if error set
/// </return>

	public static bool ShellParseArgv(string command_line, out int argcp, out string[] argvp)
	{
		var externCallResult = GLibGlobalFunctionsExterns.g_shell_parse_argv(command_line, out argcp, out argvp, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Quotes a string so that the shell (/bin/sh) will interpret the
/// quoted string to mean @unquoted_string.
/// </para>
/// <para>
/// If you pass a filename to the shell, for example, you should first
/// quote it with this function.
/// </para>
/// <para>
/// The return value must be freed with g_free().
/// </para>
/// <para>
/// The quoting style used is undefined (single or double quotes may be
/// used).
/// </para>
/// </summary>

/// <param name="unquoted_string">
/// a literal string
/// </param>
/// <return>
/// quoted string
/// </return>

	public static string ShellQuote(string unquoted_string)
	{
		return GLibGlobalFunctionsExterns.g_shell_quote(unquoted_string);
	}

/// <summary>
/// <para>
/// Unquotes a string as the shell (/bin/sh) would.
/// </para>
/// <para>
/// This function only handles quotes; if a string contains file globs,
/// arithmetic operators, variables, backticks, redirections, or other
/// special-to-the-shell features, the result will be different from the
/// result a real shell would produce (the variables, backticks, etc.
/// will be passed through literally instead of being expanded).
/// </para>
/// <para>
/// This function is guaranteed to succeed if applied to the result of
/// g_shell_quote(). If it fails, it returns %NULL and sets the
/// error.
/// </para>
/// <para>
/// The @quoted_string need not actually contain quoted or escaped text;
/// g_shell_unquote() simply goes through the string and unquotes/unescapes
/// anything that the shell would. Both single and double quotes are
/// handled, as are escapes including escaped newlines.
/// </para>
/// <para>
/// The return value must be freed with g_free().
/// </para>
/// <para>
/// Possible errors are in the %G_SHELL_ERROR domain.
/// </para>
/// <para>
/// Shell quoting rules are a bit strange. Single quotes preserve the
/// literal string exactly. escape sequences are not allowed; not even
/// `\&apos;` - if you want a `&apos;` in the quoted text, you have to do something
/// like `&apos;foo&apos;\&apos;&apos;bar&apos;`. Double quotes allow `$`, ```, `&quot;`, `\`, and
/// newline to be escaped with backslash. Otherwise double quotes
/// preserve things literally.
/// </para>
/// </summary>

/// <param name="quoted_string">
/// shell-quoted string
/// </param>
/// <return>
/// an unquoted string
/// </return>

	public static string ShellUnquote(string quoted_string)
	{
		var externCallResult = GLibGlobalFunctionsExterns.g_shell_unquote(quoted_string, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Allocates a block of memory from the libc allocator.
/// </para>
/// <para>
/// The block address handed out can be expected to be aligned
/// to at least `1 * sizeof (void*)`.
/// </para>
/// <para>
/// Since GLib 2.76 this always uses the system malloc() implementation
/// internally.
/// </para>
/// </summary>

/// <param name="block_size">
/// the number of bytes to allocate
/// </param>
/// <return>
/// a pointer to the allocated memory block, which will
///   be %NULL if and only if @mem_size is 0
/// </return>

	public static IntPtr SliceAlloc(UIntPtr block_size)
	{
		return GLibGlobalFunctionsExterns.g_slice_alloc(block_size);
	}

/// <summary>
/// <para>
/// Allocates a block of memory via g_slice_alloc() and initializes
/// the returned memory to 0.
/// </para>
/// <para>
/// Since GLib 2.76 this always uses the system malloc() implementation
/// internally.
/// </para>
/// </summary>

/// <param name="block_size">
/// the number of bytes to allocate
/// </param>
/// <return>
/// a pointer to the allocated block, which will be %NULL
///    if and only if @mem_size is 0
/// </return>

	public static IntPtr SliceAlloc0(UIntPtr block_size)
	{
		return GLibGlobalFunctionsExterns.g_slice_alloc0(block_size);
	}

/// <summary>
/// <para>
/// Allocates a block of memory from the slice allocator
/// and copies @block_size bytes into it from @mem_block.
/// </para>
/// <para>
/// @mem_block must be non-%NULL if @block_size is non-zero.
/// </para>
/// <para>
/// Since GLib 2.76 this always uses the system malloc() implementation
/// internally.
/// </para>
/// </summary>

/// <param name="block_size">
/// the number of bytes to allocate
/// </param>
/// <param name="mem_block">
/// the memory to copy
/// </param>
/// <return>
/// a pointer to the allocated memory block,
///    which will be %NULL if and only if @mem_size is 0
/// </return>

	public static IntPtr SliceCopy(UIntPtr block_size, IntPtr mem_block)
	{
		return GLibGlobalFunctionsExterns.g_slice_copy(block_size, mem_block);
	}

/// <summary>
/// <para>
/// Frees a block of memory.
/// </para>
/// <para>
/// The memory must have been allocated via g_slice_alloc() or
/// g_slice_alloc0() and the @block_size has to match the size
/// specified upon allocation. Note that the exact release behaviour
/// can be changed with the [`G_DEBUG=gc-friendly`][G_DEBUG] environment
/// variable.
/// </para>
/// <para>
/// If @mem_block is %NULL, this function does nothing.
/// </para>
/// <para>
/// Since GLib 2.76 this always uses the system free_sized() implementation
/// internally.
/// </para>
/// </summary>

/// <param name="block_size">
/// the size of the block
/// </param>
/// <param name="mem_block">
/// a pointer to the block to free
/// </param>

	public static void SliceFree1(UIntPtr block_size, IntPtr mem_block)
	{
		GLibGlobalFunctionsExterns.g_slice_free1(block_size, mem_block);
	}

/// <summary>
/// <para>
/// Frees a linked list of memory blocks of structure type @type.
/// </para>
/// <para>
/// The memory blocks must be equal-sized, allocated via
/// g_slice_alloc() or g_slice_alloc0() and linked together by a
/// @next pointer (similar to #GSList). The offset of the @next
/// field in each block is passed as third argument.
/// Note that the exact release behaviour can be changed with the
/// [`G_DEBUG=gc-friendly`][G_DEBUG] environment variable.
/// </para>
/// <para>
/// If @mem_chain is %NULL, this function does nothing.
/// </para>
/// <para>
/// Since GLib 2.76 this always uses the system free_sized() implementation
/// internally.
/// </para>
/// </summary>

/// <param name="block_size">
/// the size of the blocks
/// </param>
/// <param name="mem_chain">
/// a pointer to the first block of the chain
/// </param>
/// <param name="next_offset">
/// the offset of the @next field in the blocks
/// </param>

	public static void SliceFreeChainWithOffset(UIntPtr block_size, IntPtr mem_chain, UIntPtr next_offset)
	{
		GLibGlobalFunctionsExterns.g_slice_free_chain_with_offset(block_size, mem_chain, next_offset);
	}


/// <param name="ckey">
/// </param>

	public static long SliceGetConfig(MentorLake.GLib.GSliceConfig ckey)
	{
		return GLibGlobalFunctionsExterns.g_slice_get_config(ckey);
	}


/// <param name="ckey">
/// </param>
/// <param name="address">
/// </param>
/// <param name="n_values">
/// </param>

	public static long SliceGetConfigState(MentorLake.GLib.GSliceConfig ckey, long address, uint n_values)
	{
		return GLibGlobalFunctionsExterns.g_slice_get_config_state(ckey, address, n_values);
	}


/// <param name="ckey">
/// </param>
/// <param name="value">
/// </param>

	public static void SliceSetConfig(MentorLake.GLib.GSliceConfig ckey, long value)
	{
		GLibGlobalFunctionsExterns.g_slice_set_config(ckey, value);
	}



	public static void SlistPopAllocator()
	{
		GLibGlobalFunctionsExterns.g_slist_pop_allocator();
	}


/// <param name="allocator">
/// </param>

	public static void SlistPushAllocator(MentorLake.GLib.GAllocatorHandle allocator)
	{
		GLibGlobalFunctionsExterns.g_slist_push_allocator(allocator);
	}

/// <summary>
/// <para>
/// A safer form of the standard sprintf() function. The output is guaranteed
/// to not exceed @n characters (including the terminating nul character), so
/// it is easy to ensure that a buffer overflow cannot occur.
/// </para>
/// <para>
/// See also [func@GLib.strdup_printf].
/// </para>
/// <para>
/// In versions of GLib prior to 1.2.3, this function may return -1 if the
/// output was truncated, and the truncated string may not be nul-terminated.
/// In versions prior to 1.3.12, this function returns the length of the output
/// string.
/// </para>
/// <para>
/// The return value of g_snprintf() conforms to the snprintf()
/// function as standardized in ISO C99. Note that this is different from
/// traditional `snprintf()`, which returns the length of the output string.
/// </para>
/// <para>
/// The format string may contain positional parameters, as specified in
/// the Single Unix Specification.
/// </para>
/// </summary>

/// <param name="@string">
/// the buffer to hold the output
/// </param>
/// <param name="n">
/// the maximum number of bytes to produce (including the
///   terminating nul character)
/// </param>
/// <param name="format">
/// a standard `printf()` format string, but notice
///   [string precision pitfalls](string-utils.html#string-precision-pitfalls)
/// </param>
/// <param name="@__arglist">
/// the arguments to insert in the output
/// </param>
/// <return>
/// the number of bytes which would be produced if the buffer
///   was large enough
/// </return>

	public static int Snprintf(string @string, ulong n, string format, IntPtr @__arglist)
	{
		return GLibGlobalFunctionsExterns.g_snprintf(@string, n, format, @__arglist);
	}

/// <summary>
/// <para>
/// This is just like the standard C &amp;lt;see href=&quot;man:qsort(3&quot;&amp;gt;qsort()&amp;lt;/see&amp;gt;) function, but
/// the comparison routine accepts a user data argument
/// (like &amp;lt;see href=&quot;man:qsort_r(3&quot;&amp;gt;qsort_r()&amp;lt;/see&amp;gt;)).
/// </para>
/// <para>
/// Unlike `qsort()`, this is guaranteed to be a stable sort.
/// </para>
/// </summary>

/// <param name="array">
/// start of array to sort
/// </param>
/// <param name="n_elements">
/// number of elements in the array
/// </param>
/// <param name="element_size">
/// size of each element
/// </param>
/// <param name="compare_func">
/// function to compare elements
/// </param>
/// <param name="user_data">
/// data to pass to @compare_func
/// </param>

	public static void SortArray(IntPtr[] array, UIntPtr n_elements, UIntPtr element_size, MentorLake.GLib.GCompareDataFunc compare_func, IntPtr user_data)
	{
		GLibGlobalFunctionsExterns.g_sort_array(array, n_elements, element_size, compare_func, user_data);
	}

/// <summary>
/// <para>
/// Removes the source with the given ID from the default main context. You must
/// use [method@GLib.Source.destroy] for sources added to a non-default main context.
/// </para>
/// <para>
/// The ID of a #GSource is given by [method@GLib.Source.get_id], or will be
/// returned by the functions [method@GLib.Source.attach], [func@GLib.idle_add],
/// [func@GLib.idle_add_full], [func@GLib.timeout_add],
/// [func@GLib.timeout_add_full], [func@GLib.child_watch_add],
/// [func@GLib.child_watch_add_full], [func@GLib.io_add_watch], and
/// [func@GLib.io_add_watch_full].
/// </para>
/// <para>
/// It is a programmer error to attempt to remove a non-existent source.
/// </para>
/// <para>
/// More specifically: source IDs can be reissued after a source has been
/// destroyed and therefore it is never valid to use this function with a
/// source ID which may have already been removed.  An example is when
/// scheduling an idle to run in another thread with [func@GLib.idle_add]: the
/// idle may already have run and been removed by the time this function
/// is called on its (now invalid) source ID.  This source ID may have
/// been reissued, leading to the operation being performed against the
/// wrong source.
/// </para>
/// </summary>

/// <param name="tag">
/// the ID of the source to remove.
/// </param>
/// <return>
/// %TRUE if the source was found and removed.
/// </return>

	public static bool SourceRemove(uint tag)
	{
		return GLibGlobalFunctionsExterns.g_source_remove(tag);
	}

/// <summary>
/// <para>
/// Removes a source from the default main loop context given the
/// source functions and user data. If multiple sources exist with the
/// same source functions and user data, only one will be destroyed.
/// </para>
/// </summary>

/// <param name="funcs">
/// The @source_funcs passed to [ctor@GLib.Source.new]
/// </param>
/// <param name="user_data">
/// the user data for the callback
/// </param>
/// <return>
/// %TRUE if a source was found and removed.
/// </return>

	public static bool SourceRemoveByFuncsUserData(MentorLake.GLib.GSourceFuncsHandle funcs, IntPtr user_data)
	{
		return GLibGlobalFunctionsExterns.g_source_remove_by_funcs_user_data(funcs, user_data);
	}

/// <summary>
/// <para>
/// Removes a source from the default main loop context given the user
/// data for the callback. If multiple sources exist with the same user
/// data, only one will be destroyed.
/// </para>
/// </summary>

/// <param name="user_data">
/// the user_data for the callback.
/// </param>
/// <return>
/// %TRUE if a source was found and removed.
/// </return>

	public static bool SourceRemoveByUserData(IntPtr user_data)
	{
		return GLibGlobalFunctionsExterns.g_source_remove_by_user_data(user_data);
	}

/// <summary>
/// <para>
/// Sets the name of a source using its ID.
/// </para>
/// <para>
/// This is a convenience utility to set source names from the return
/// value of [func@GLib.idle_add], [func@GLib.timeout_add], etc.
/// </para>
/// <para>
/// It is a programmer error to attempt to set the name of a non-existent
/// source.
/// </para>
/// <para>
/// More specifically: source IDs can be reissued after a source has been
/// destroyed and therefore it is never valid to use this function with a
/// source ID which may have already been removed.  An example is when
/// scheduling an idle to run in another thread with [func@GLib.idle_add]: the
/// idle may already have run and been removed by the time this function
/// is called on its (now invalid) source ID.  This source ID may have
/// been reissued, leading to the operation being performed against the
/// wrong source.
/// </para>
/// </summary>

/// <param name="tag">
/// a #GSource ID
/// </param>
/// <param name="name">
/// debug name for the source
/// </param>

	public static void SourceSetNameById(uint tag, string name)
	{
		GLibGlobalFunctionsExterns.g_source_set_name_by_id(tag, name);
	}

/// <summary>
/// <para>
/// Gets the smallest prime number from a built-in array of primes which
/// is larger than @num. This is used within GLib to calculate the optimum
/// size of a #GHashTable.
/// </para>
/// <para>
/// The built-in array of primes ranges from 11 to 13845163 such that
/// each prime is approximately 1.5-2 times the previous prime.
/// </para>
/// </summary>

/// <param name="num">
/// a #guint
/// </param>
/// <return>
/// the smallest prime number from a built-in array of primes
///     which is larger than @num
/// </return>

	public static uint SpacedPrimesClosest(uint num)
	{
		return GLibGlobalFunctionsExterns.g_spaced_primes_closest(num);
	}

/// <summary>
/// <para>
/// Executes a child program asynchronously.
/// </para>
/// <para>
/// See g_spawn_async_with_pipes() for a full description; this function
/// simply calls the g_spawn_async_with_pipes() without any pipes.
/// </para>
/// <para>
/// You should call g_spawn_close_pid() on the returned child process
/// reference when you don&apos;t need it any more.
/// </para>
/// <para>
/// If you are writing a GTK application, and the program you are spawning is a
/// graphical application too, then to ensure that the spawned program opens its
/// windows on the right screen, you may want to use #GdkAppLaunchContext,
/// #GAppLaunchContext, or set the %DISPLAY environment variable.
/// </para>
/// <para>
/// Note that the returned @child_pid on Windows is a handle to the child
/// process and not its identifier. Process handles and process identifiers
/// are different concepts on Windows.
/// </para>
/// </summary>

/// <param name="working_directory">
/// child&apos;s current working
///     directory, or %NULL to inherit parent&apos;s
/// </param>
/// <param name="argv">
/// 
///     child&apos;s argument vector
/// </param>
/// <param name="envp">
/// 
///     child&apos;s environment, or %NULL to inherit parent&apos;s
/// </param>
/// <param name="flags">
/// flags from #GSpawnFlags
/// </param>
/// <param name="child_setup">
/// function to run
///     in the child just before `exec()`
/// </param>
/// <param name="user_data">
/// user data for @child_setup
/// </param>
/// <param name="child_pid">
/// return location for child process reference, or %NULL
/// </param>
/// <return>
/// %TRUE on success, %FALSE if error is set
/// </return>

	public static bool SpawnAsync(string working_directory, string[] argv, string[] envp, MentorLake.GLib.GSpawnFlags flags, MentorLake.GLib.GSpawnChildSetupFunc child_setup, IntPtr user_data, out MentorLake.GLib.GPid child_pid)
	{
		var externCallResult = GLibGlobalFunctionsExterns.g_spawn_async(working_directory, argv, envp, flags, child_setup, user_data, out child_pid, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Executes a child program asynchronously.
/// </para>
/// <para>
/// Identical to g_spawn_async_with_pipes_and_fds() but with `n_fds` set to zero,
/// so no FD assignments are used.
/// </para>
/// </summary>

/// <param name="working_directory">
/// child&apos;s current working directory, or %NULL to inherit parent&apos;s, in the GLib file name encoding
/// </param>
/// <param name="argv">
/// child&apos;s argument vector, in the GLib file name encoding;
///   it must be non-empty and %NULL-terminated
/// </param>
/// <param name="envp">
/// child&apos;s environment, or %NULL to inherit parent&apos;s, in the GLib file name encoding
/// </param>
/// <param name="flags">
/// flags from #GSpawnFlags
/// </param>
/// <param name="child_setup">
/// function to run
///   in the child just before `exec()`
/// </param>
/// <param name="user_data">
/// user data for @child_setup
/// </param>
/// <param name="child_pid">
/// return location for child process ID, or %NULL
/// </param>
/// <param name="stdin_fd">
/// file descriptor to use for child&apos;s stdin, or `-1`
/// </param>
/// <param name="stdout_fd">
/// file descriptor to use for child&apos;s stdout, or `-1`
/// </param>
/// <param name="stderr_fd">
/// file descriptor to use for child&apos;s stderr, or `-1`
/// </param>
/// <return>
/// %TRUE on success, %FALSE if an error was set
/// </return>

	public static bool SpawnAsyncWithFds(string working_directory, string[] argv, string[] envp, MentorLake.GLib.GSpawnFlags flags, MentorLake.GLib.GSpawnChildSetupFunc child_setup, IntPtr user_data, out MentorLake.GLib.GPid child_pid, int stdin_fd, int stdout_fd, int stderr_fd)
	{
		var externCallResult = GLibGlobalFunctionsExterns.g_spawn_async_with_fds(working_directory, argv, envp, flags, child_setup, user_data, out child_pid, stdin_fd, stdout_fd, stderr_fd, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Identical to g_spawn_async_with_pipes_and_fds() but with `n_fds` set to zero,
/// so no FD assignments are used.
/// </para>
/// </summary>

/// <param name="working_directory">
/// child&apos;s current working
///     directory, or %NULL to inherit parent&apos;s, in the GLib file name encoding
/// </param>
/// <param name="argv">
/// child&apos;s argument
///     vector, in the GLib file name encoding; it must be non-empty and %NULL-terminated
/// </param>
/// <param name="envp">
/// 
///     child&apos;s environment, or %NULL to inherit parent&apos;s, in the GLib file
///     name encoding
/// </param>
/// <param name="flags">
/// flags from #GSpawnFlags
/// </param>
/// <param name="child_setup">
/// function to run
///     in the child just before `exec()`
/// </param>
/// <param name="user_data">
/// user data for @child_setup
/// </param>
/// <param name="child_pid">
/// return location for child process ID, or %NULL
/// </param>
/// <param name="standard_input">
/// return location for file descriptor to write to child&apos;s stdin, or %NULL
/// </param>
/// <param name="standard_output">
/// return location for file descriptor to read child&apos;s stdout, or %NULL
/// </param>
/// <param name="standard_error">
/// return location for file descriptor to read child&apos;s stderr, or %NULL
/// </param>
/// <return>
/// %TRUE on success, %FALSE if an error was set
/// </return>

	public static bool SpawnAsyncWithPipes(string working_directory, string[] argv, string[] envp, MentorLake.GLib.GSpawnFlags flags, MentorLake.GLib.GSpawnChildSetupFunc child_setup, IntPtr user_data, out MentorLake.GLib.GPid child_pid, out int standard_input, out int standard_output, out int standard_error)
	{
		var externCallResult = GLibGlobalFunctionsExterns.g_spawn_async_with_pipes(working_directory, argv, envp, flags, child_setup, user_data, out child_pid, out standard_input, out standard_output, out standard_error, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Executes a child program asynchronously (your program will not
/// block waiting for the child to exit).
/// </para>
/// <para>
/// The child program is specified by the only argument that must be
/// provided, @argv. @argv should be a %NULL-terminated array of strings,
/// to be passed as the argument vector for the child. The first string
/// in @argv is of course the name of the program to execute. By default,
/// the name of the program must be a full path. If @flags contains the
/// %G_SPAWN_SEARCH_PATH flag, the `PATH` environment variable is used to
/// search for the executable. If @flags contains the
/// %G_SPAWN_SEARCH_PATH_FROM_ENVP flag, the `PATH` variable from @envp
/// is used to search for the executable. If both the
/// %G_SPAWN_SEARCH_PATH and %G_SPAWN_SEARCH_PATH_FROM_ENVP flags are
/// set, the `PATH` variable from @envp takes precedence over the
/// environment variable.
/// </para>
/// <para>
/// If the program name is not a full path and %G_SPAWN_SEARCH_PATH flag
/// is not used, then the program will be run from the current directory
/// (or @working_directory, if specified); this might be unexpected or even
/// dangerous in some cases when the current directory is world-writable.
/// </para>
/// <para>
/// On Windows, note that all the string or string vector arguments to
/// this function and the other `g_spawn*()` functions are in UTF-8, the
/// GLib file name encoding. Unicode characters that are not part of
/// the system codepage passed in these arguments will be correctly
/// available in the spawned program only if it uses wide character API
/// to retrieve its command line. For C programs built with Microsoft&apos;s
/// tools it is enough to make the program have a `wmain()` instead of
/// `main()`. `wmain()` has a wide character argument vector as parameter.
/// </para>
/// <para>
/// At least currently, mingw doesn&apos;t support `wmain()`, so if you use
/// mingw to develop the spawned program, it should call
/// g_win32_get_command_line() to get arguments in UTF-8.
/// </para>
/// <para>
/// On Windows the low-level child process creation API `CreateProcess()`
/// doesn&apos;t use argument vectors, but a command line. The C runtime
/// library&apos;s `spawn*()` family of functions (which g_spawn_async_with_pipes()
/// eventually calls) paste the argument vector elements together into
/// a command line, and the C runtime startup code does a corresponding
/// reconstruction of an argument vector from the command line, to be
/// passed to `main()`. Complications arise when you have argument vector
/// elements that contain spaces or double quotes. The `spawn*()` functions
/// don&apos;t do any quoting or escaping, but on the other hand the startup
/// code does do unquoting and unescaping in order to enable receiving
/// arguments with embedded spaces or double quotes. To work around this
/// asymmetry, g_spawn_async_with_pipes() will do quoting and escaping on
/// argument vector elements that need it before calling the C runtime
/// `spawn()` function.
/// </para>
/// <para>
/// The returned @child_pid on Windows is a handle to the child
/// process, not its identifier. Process handles and process
/// identifiers are different concepts on Windows.
/// </para>
/// <para>
/// @envp is a %NULL-terminated array of strings, where each string
/// has the form `KEY=VALUE`. This will become the child&apos;s environment.
/// If @envp is %NULL, the child inherits its parent&apos;s environment.
/// </para>
/// <para>
/// @flags should be the bitwise OR of any flags you want to affect the
/// function&apos;s behaviour. The %G_SPAWN_DO_NOT_REAP_CHILD means that the
/// child will not automatically be reaped; you must use a child watch
/// (g_child_watch_add()) to be notified about the death of the child process,
/// otherwise it will stay around as a zombie process until this process exits.
/// Eventually you must call g_spawn_close_pid() on the @child_pid, in order to
/// free resources which may be associated with the child process. (On Unix,
/// using a child watch is equivalent to calling waitpid() or handling
/// the `SIGCHLD` signal manually. On Windows, calling g_spawn_close_pid()
/// is equivalent to calling `CloseHandle()` on the process handle returned
/// in @child_pid). See g_child_watch_add().
/// </para>
/// <para>
/// Open UNIX file descriptors marked as `FD_CLOEXEC` will be automatically
/// closed in the child process. %G_SPAWN_LEAVE_DESCRIPTORS_OPEN means that
/// other open file descriptors will be inherited by the child; otherwise all
/// descriptors except stdin/stdout/stderr will be closed before calling `exec()`
/// in the child. %G_SPAWN_SEARCH_PATH means that @argv[0] need not be an
/// absolute path, it will be looked for in the `PATH` environment
/// variable. %G_SPAWN_SEARCH_PATH_FROM_ENVP means need not be an
/// absolute path, it will be looked for in the `PATH` variable from
/// @envp. If both %G_SPAWN_SEARCH_PATH and %G_SPAWN_SEARCH_PATH_FROM_ENVP
/// are used, the value from @envp takes precedence over the environment.
/// </para>
/// <para>
/// %G_SPAWN_CHILD_INHERITS_STDIN means that the child will inherit the parent&apos;s
/// standard input (by default, the child&apos;s standard input is attached to
/// `/dev/null`). %G_SPAWN_STDIN_FROM_DEV_NULL explicitly imposes the default
/// behavior. Both flags cannot be enabled at the same time and, in both cases,
/// the @stdin_pipe_out argument is ignored.
/// </para>
/// <para>
/// %G_SPAWN_STDOUT_TO_DEV_NULL means that the child&apos;s standard output
/// will be discarded (by default, it goes to the same location as the parent&apos;s
/// standard output). %G_SPAWN_CHILD_INHERITS_STDOUT explicitly imposes the
/// default behavior. Both flags cannot be enabled at the same time and, in
/// both cases, the @stdout_pipe_out argument is ignored.
/// </para>
/// <para>
/// %G_SPAWN_STDERR_TO_DEV_NULL means that the child&apos;s standard error
/// will be discarded (by default, it goes to the same location as the parent&apos;s
/// standard error). %G_SPAWN_CHILD_INHERITS_STDERR explicitly imposes the
/// default behavior. Both flags cannot be enabled at the same time and, in
/// both cases, the @stderr_pipe_out argument is ignored.
/// </para>
/// <para>
/// It is valid to pass the same FD in multiple parameters (e.g. you can pass
/// a single FD for both @stdout_fd and @stderr_fd, and include it in
/// @source_fds too).
/// </para>
/// <para>
/// @source_fds and @target_fds allow zero or more FDs from this process to be
/// remapped to different FDs in the spawned process. If @n_fds is greater than
/// zero, @source_fds and @target_fds must both be non-%NULL and the same length.
/// Each FD in @source_fds is remapped to the FD number at the same index in
/// @target_fds. The source and target FD may be equal to simply propagate an FD
/// to the spawned process. FD remappings are processed after standard FDs, so
/// any target FDs which equal @stdin_fd, @stdout_fd or @stderr_fd will overwrite
/// them in the spawned process.
/// </para>
/// <para>
/// @source_fds is supported on Windows since 2.72.
/// </para>
/// <para>
/// %G_SPAWN_FILE_AND_ARGV_ZERO means that the first element of @argv is
/// the file to execute, while the remaining elements are the actual
/// argument vector to pass to the file. Normally g_spawn_async_with_pipes()
/// uses @argv[0] as the file to execute, and passes all of @argv to the child.
/// </para>
/// <para>
/// @child_setup and @user_data are a function and user data. On POSIX
/// platforms, the function is called in the child after GLib has
/// performed all the setup it plans to perform (including creating
/// pipes, closing file descriptors, etc.) but before calling `exec()`.
/// That is, @child_setup is called just before calling `exec()` in the
/// child. Obviously actions taken in this function will only affect
/// the child, not the parent.
/// </para>
/// <para>
/// On Windows, there is no separate `fork()` and `exec()` functionality.
/// Child processes are created and run with a single API call,
/// `CreateProcess()`. There is no sensible thing @child_setup
/// could be used for on Windows so it is ignored and not called.
/// </para>
/// <para>
/// If non-%NULL, @child_pid will on Unix be filled with the child&apos;s
/// process ID. You can use the process ID to send signals to the child,
/// or to use g_child_watch_add() (or `waitpid()`) if you specified the
/// %G_SPAWN_DO_NOT_REAP_CHILD flag. On Windows, @child_pid will be
/// filled with a handle to the child process only if you specified the
/// %G_SPAWN_DO_NOT_REAP_CHILD flag. You can then access the child
/// process using the Win32 API, for example wait for its termination
/// with the `WaitFor*()` functions, or examine its exit code with
/// `GetExitCodeProcess()`. You should close the handle with `CloseHandle()`
/// or g_spawn_close_pid() when you no longer need it.
/// </para>
/// <para>
/// If non-%NULL, the @stdin_pipe_out, @stdout_pipe_out, @stderr_pipe_out
/// locations will be filled with file descriptors for writing to the child&apos;s
/// standard input or reading from its standard output or standard error.
/// The caller of g_spawn_async_with_pipes() must close these file descriptors
/// when they are no longer in use. If these parameters are %NULL, the
/// corresponding pipe won&apos;t be created.
/// </para>
/// <para>
/// If @stdin_pipe_out is %NULL, the child&apos;s standard input is attached to
/// `/dev/null` unless %G_SPAWN_CHILD_INHERITS_STDIN is set.
/// </para>
/// <para>
/// If @stderr_pipe_out is NULL, the child&apos;s standard error goes to the same
/// location as the parent&apos;s standard error unless %G_SPAWN_STDERR_TO_DEV_NULL
/// is set.
/// </para>
/// <para>
/// If @stdout_pipe_out is NULL, the child&apos;s standard output goes to the same
/// location as the parent&apos;s standard output unless %G_SPAWN_STDOUT_TO_DEV_NULL
/// is set.
/// </para>
/// <para>
/// @error can be %NULL to ignore errors, or non-%NULL to report errors.
/// If an error is set, the function returns %FALSE. Errors are reported
/// even if they occur in the child (for example if the executable in
/// `@argv[0]` is not found). Typically the `message` field of returned
/// errors should be displayed to users. Possible errors are those from
/// the %G_SPAWN_ERROR domain.
/// </para>
/// <para>
/// If an error occurs, @child_pid, @stdin_pipe_out, @stdout_pipe_out,
/// and @stderr_pipe_out will not be filled with valid values.
/// </para>
/// <para>
/// If @child_pid is not %NULL and an error does not occur then the returned
/// process reference must be closed using g_spawn_close_pid().
/// </para>
/// <para>
/// On modern UNIX platforms, GLib can use an efficient process launching
/// codepath driven internally by `posix_spawn()`. This has the advantage of
/// avoiding the fork-time performance costs of cloning the parent process
/// address space, and avoiding associated memory overcommit checks that are
/// not relevant in the context of immediately executing a distinct process.
/// This optimized codepath will be used provided that the following conditions
/// are met:
/// </para>
/// <para>
/// 1. %G_SPAWN_DO_NOT_REAP_CHILD is set
/// 2. %G_SPAWN_LEAVE_DESCRIPTORS_OPEN is set
/// 3. %G_SPAWN_SEARCH_PATH_FROM_ENVP is not set
/// 4. @working_directory is %NULL
/// 5. @child_setup is %NULL
/// 6. The program is of a recognised binary format, or has a shebang.
///    Otherwise, GLib will have to execute the program through the
///    shell, which is not done using the optimized codepath.
/// </para>
/// <para>
/// If you are writing a GTK application, and the program you are spawning is a
/// graphical application too, then to ensure that the spawned program opens its
/// windows on the right screen, you may want to use #GdkAppLaunchContext,
/// #GAppLaunchContext, or set the `DISPLAY` environment variable.
/// </para>
/// </summary>

/// <param name="working_directory">
/// child&apos;s current working
///     directory, or %NULL to inherit parent&apos;s, in the GLib file name encoding
/// </param>
/// <param name="argv">
/// child&apos;s argument
///     vector, in the GLib file name encoding; it must be non-empty and %NULL-terminated
/// </param>
/// <param name="envp">
/// 
///     child&apos;s environment, or %NULL to inherit parent&apos;s, in the GLib file
///     name encoding
/// </param>
/// <param name="flags">
/// flags from #GSpawnFlags
/// </param>
/// <param name="child_setup">
/// function to run
///     in the child just before `exec()`
/// </param>
/// <param name="user_data">
/// user data for @child_setup
/// </param>
/// <param name="stdin_fd">
/// file descriptor to use for child&apos;s stdin, or `-1`
/// </param>
/// <param name="stdout_fd">
/// file descriptor to use for child&apos;s stdout, or `-1`
/// </param>
/// <param name="stderr_fd">
/// file descriptor to use for child&apos;s stderr, or `-1`
/// </param>
/// <param name="source_fds">
/// array of FDs from the parent
///    process to make available in the child process
/// </param>
/// <param name="target_fds">
/// array of FDs to remap
///    @source_fds to in the child process
/// </param>
/// <param name="n_fds">
/// number of FDs in @source_fds and @target_fds
/// </param>
/// <param name="child_pid_out">
/// return location for child process ID, or %NULL
/// </param>
/// <param name="stdin_pipe_out">
/// return location for file descriptor to write to child&apos;s stdin, or %NULL
/// </param>
/// <param name="stdout_pipe_out">
/// return location for file descriptor to read child&apos;s stdout, or %NULL
/// </param>
/// <param name="stderr_pipe_out">
/// return location for file descriptor to read child&apos;s stderr, or %NULL
/// </param>
/// <return>
/// %TRUE on success, %FALSE if an error was set
/// </return>

	public static bool SpawnAsyncWithPipesAndFds(string working_directory, string[] argv, string[] envp, MentorLake.GLib.GSpawnFlags flags, MentorLake.GLib.GSpawnChildSetupFunc child_setup, IntPtr user_data, int stdin_fd, int stdout_fd, int stderr_fd, int[] source_fds, int[] target_fds, UIntPtr n_fds, out MentorLake.GLib.GPid child_pid_out, out int stdin_pipe_out, out int stdout_pipe_out, out int stderr_pipe_out)
	{
		var externCallResult = GLibGlobalFunctionsExterns.g_spawn_async_with_pipes_and_fds(working_directory, argv, envp, flags, child_setup, user_data, stdin_fd, stdout_fd, stderr_fd, source_fds, target_fds, n_fds, out child_pid_out, out stdin_pipe_out, out stdout_pipe_out, out stderr_pipe_out, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// An old name for g_spawn_check_wait_status(), deprecated because its
/// name is misleading.
/// </para>
/// <para>
/// Despite the name of the function, @wait_status must be the wait status
/// as returned by g_spawn_sync(), g_subprocess_get_status(), `waitpid()`,
/// etc. On Unix platforms, it is incorrect for it to be the exit status
/// as passed to `exit()` or returned by g_subprocess_get_exit_status() or
/// `WEXITSTATUS()`.
/// </para>
/// </summary>

/// <param name="wait_status">
/// A status as returned from g_spawn_sync()
/// </param>
/// <return>
/// %TRUE if child exited successfully, %FALSE otherwise (and
///     @error will be set)
/// </return>

	public static bool SpawnCheckExitStatus(int wait_status)
	{
		var externCallResult = GLibGlobalFunctionsExterns.g_spawn_check_exit_status(wait_status, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Set @error if @wait_status indicates the child exited abnormally
/// (e.g. with a nonzero exit code, or via a fatal signal).
/// </para>
/// <para>
/// The g_spawn_sync() and g_child_watch_add() family of APIs return the
/// status of subprocesses encoded in a platform-specific way.
/// On Unix, this is guaranteed to be in the same format waitpid() returns,
/// and on Windows it is guaranteed to be the result of GetExitCodeProcess().
/// </para>
/// <para>
/// Prior to the introduction of this function in GLib 2.34, interpreting
/// @wait_status required use of platform-specific APIs, which is problematic
/// for software using GLib as a cross-platform layer.
/// </para>
/// <para>
/// Additionally, many programs simply want to determine whether or not
/// the child exited successfully, and either propagate a #GError or
/// print a message to standard error. In that common case, this function
/// can be used. Note that the error message in @error will contain
/// human-readable information about the wait status.
/// </para>
/// <para>
/// The @domain and @code of @error have special semantics in the case
/// where the process has an &quot;exit code&quot;, as opposed to being killed by
/// a signal. On Unix, this happens if WIFEXITED() would be true of
/// @wait_status. On Windows, it is always the case.
/// </para>
/// <para>
/// The special semantics are that the actual exit code will be the
/// code set in @error, and the domain will be %G_SPAWN_EXIT_ERROR.
/// This allows you to differentiate between different exit codes.
/// </para>
/// <para>
/// If the process was terminated by some means other than an exit
/// status (for example if it was killed by a signal), the domain will be
/// %G_SPAWN_ERROR and the code will be %G_SPAWN_ERROR_FAILED.
/// </para>
/// <para>
/// This function just offers convenience; you can of course also check
/// the available platform via a macro such as %G_OS_UNIX, and use
/// WIFEXITED() and WEXITSTATUS() on @wait_status directly. Do not attempt
/// to scan or parse the error message string; it may be translated and/or
/// change in future versions of GLib.
/// </para>
/// <para>
/// Prior to version 2.70, g_spawn_check_exit_status() provides the same
/// functionality, although under a misleading name.
/// </para>
/// </summary>

/// <param name="wait_status">
/// A platform-specific wait status as returned from g_spawn_sync()
/// </param>
/// <return>
/// %TRUE if child exited successfully, %FALSE otherwise (and
///   @error will be set)
/// </return>

	public static bool SpawnCheckWaitStatus(int wait_status)
	{
		var externCallResult = GLibGlobalFunctionsExterns.g_spawn_check_wait_status(wait_status, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// On some platforms, notably Windows, the #GPid type represents a resource
/// which must be closed to prevent resource leaking. g_spawn_close_pid()
/// is provided for this purpose. It should be used on all platforms, even
/// though it doesn&apos;t do anything under UNIX.
/// </para>
/// </summary>

/// <param name="pid">
/// The process reference to close
/// </param>

	public static void SpawnClosePid(MentorLake.GLib.GPid pid)
	{
		GLibGlobalFunctionsExterns.g_spawn_close_pid(pid);
	}

/// <summary>
/// <para>
/// A simple version of g_spawn_async() that parses a command line with
/// g_shell_parse_argv() and passes it to g_spawn_async().
/// </para>
/// <para>
/// Runs a command line in the background. Unlike g_spawn_async(), the
/// %G_SPAWN_SEARCH_PATH flag is enabled, other flags are not. Note
/// that %G_SPAWN_SEARCH_PATH can have security implications, so
/// consider using g_spawn_async() directly if appropriate. Possible
/// errors are those from g_shell_parse_argv() and g_spawn_async().
/// </para>
/// <para>
/// The same concerns on Windows apply as for g_spawn_command_line_sync().
/// </para>
/// </summary>

/// <param name="command_line">
/// a command line
/// </param>
/// <return>
/// %TRUE on success, %FALSE if error is set
/// </return>

	public static bool SpawnCommandLineAsync(string command_line)
	{
		var externCallResult = GLibGlobalFunctionsExterns.g_spawn_command_line_async(command_line, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// A simple version of g_spawn_sync() with little-used parameters
/// removed, taking a command line instead of an argument vector.
/// </para>
/// <para>
/// See g_spawn_sync() for full details.
/// </para>
/// <para>
/// The @command_line argument will be parsed by g_shell_parse_argv().
/// </para>
/// <para>
/// Unlike g_spawn_sync(), the %G_SPAWN_SEARCH_PATH flag is enabled.
/// Note that %G_SPAWN_SEARCH_PATH can have security implications, so
/// consider using g_spawn_sync() directly if appropriate.
/// </para>
/// <para>
/// Possible errors are those from g_spawn_sync() and those
/// from g_shell_parse_argv().
/// </para>
/// <para>
/// If @wait_status is non-%NULL, the platform-specific status of
/// the child is stored there; see the documentation of
/// g_spawn_check_wait_status() for how to use and interpret this.
/// On Unix platforms, note that it is usually not equal
/// to the integer passed to `exit()` or returned from `main()`.
/// </para>
/// <para>
/// On Windows, please note the implications of g_shell_parse_argv()
/// parsing @command_line. Parsing is done according to Unix shell rules, not
/// Windows command interpreter rules.
/// Space is a separator, and backslashes are
/// special. Thus you cannot simply pass a @command_line containing
/// canonical Windows paths, like &quot;c:\\program files\\app\\app.exe&quot;, as
/// the backslashes will be eaten, and the space will act as a
/// separator. You need to enclose such paths with single quotes, like
/// &quot;&apos;c:\\program files\\app\\app.exe&apos; &apos;e:\\folder\\argument.txt&apos;&quot;.
/// </para>
/// </summary>

/// <param name="command_line">
/// a command line
/// </param>
/// <param name="standard_output">
/// return location for child output
/// </param>
/// <param name="standard_error">
/// return location for child errors
/// </param>
/// <param name="wait_status">
/// return location for child wait status, as returned by waitpid()
/// </param>
/// <return>
/// %TRUE on success, %FALSE if an error was set
/// </return>

	public static bool SpawnCommandLineSync(string command_line, out byte[] standard_output, out byte[] standard_error, out int wait_status)
	{
		var externCallResult = GLibGlobalFunctionsExterns.g_spawn_command_line_sync(command_line, out standard_output, out standard_error, out wait_status, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}



	public static MentorLake.GLib.GQuark SpawnErrorQuark()
	{
		return GLibGlobalFunctionsExterns.g_spawn_error_quark();
	}



	public static MentorLake.GLib.GQuark SpawnExitErrorQuark()
	{
		return GLibGlobalFunctionsExterns.g_spawn_exit_error_quark();
	}

/// <summary>
/// <para>
/// Executes a child synchronously (waits for the child to exit before returning).
/// </para>
/// <para>
/// All output from the child is stored in @standard_output and @standard_error,
/// if those parameters are non-%NULL. Note that you must set the
/// %G_SPAWN_STDOUT_TO_DEV_NULL and %G_SPAWN_STDERR_TO_DEV_NULL flags when
/// passing %NULL for @standard_output and @standard_error.
/// </para>
/// <para>
/// If @wait_status is non-%NULL, the platform-specific status of
/// the child is stored there; see the documentation of
/// g_spawn_check_wait_status() for how to use and interpret this.
/// On Unix platforms, note that it is usually not equal
/// to the integer passed to `exit()` or returned from `main()`.
/// </para>
/// <para>
/// Note that it is invalid to pass %G_SPAWN_DO_NOT_REAP_CHILD in
/// @flags, and on POSIX platforms, the same restrictions as for
/// g_child_watch_source_new() apply.
/// </para>
/// <para>
/// If an error occurs, no data is returned in @standard_output,
/// @standard_error, or @wait_status.
/// </para>
/// <para>
/// This function calls g_spawn_async_with_pipes() internally; see that
/// function for full details on the other parameters and details on
/// how these functions work on Windows.
/// </para>
/// </summary>

/// <param name="working_directory">
/// child&apos;s current working
///     directory, or %NULL to inherit parent&apos;s
/// </param>
/// <param name="argv">
/// 
///     child&apos;s argument vector, which must be non-empty and %NULL-terminated
/// </param>
/// <param name="envp">
/// 
///     child&apos;s environment, or %NULL to inherit parent&apos;s
/// </param>
/// <param name="flags">
/// flags from #GSpawnFlags
/// </param>
/// <param name="child_setup">
/// function to run
///     in the child just before `exec()`
/// </param>
/// <param name="user_data">
/// user data for @child_setup
/// </param>
/// <param name="standard_output">
/// return location for child output, or %NULL
/// </param>
/// <param name="standard_error">
/// return location for child error messages, or %NULL
/// </param>
/// <param name="wait_status">
/// return location for child wait status, as returned by waitpid(), or %NULL
/// </param>
/// <return>
/// %TRUE on success, %FALSE if an error was set
/// </return>

	public static bool SpawnSync(string working_directory, string[] argv, string[] envp, MentorLake.GLib.GSpawnFlags flags, MentorLake.GLib.GSpawnChildSetupFunc child_setup, IntPtr user_data, out byte[] standard_output, out byte[] standard_error, out int wait_status)
	{
		var externCallResult = GLibGlobalFunctionsExterns.g_spawn_sync(working_directory, argv, envp, flags, child_setup, user_data, out standard_output, out standard_error, out wait_status, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// An implementation of the standard `sprintf()` function which supports
/// positional parameters, as specified in the Single Unix Specification.
/// </para>
/// <para>
/// Note that it is usually better to use [func@GLib.snprintf], to avoid the
/// risk of buffer overflow.
/// </para>
/// <para>
/// `glib/gprintf.h` must be explicitly included in order to use this function.
/// </para>
/// <para>
/// See also [func@GLib.strdup_printf].
/// </para>
/// </summary>

/// <param name="@string">
/// A pointer to a memory buffer to contain the resulting string. It
///   is up to the caller to ensure that the allocated buffer is large
///   enough to hold the formatted result.
/// </param>
/// <param name="format">
/// a standard `printf()` format string, but notice
///   [string precision pitfalls](string-utils.html#string-precision-pitfalls)
/// </param>
/// <param name="@__arglist">
/// the arguments to insert in the output
/// </param>
/// <return>
/// the number of bytes printed
/// </return>

	public static int Sprintf(string @string, string format, IntPtr @__arglist)
	{
		return GLibGlobalFunctionsExterns.g_sprintf(@string, format, @__arglist);
	}

/// <summary>
/// <para>
/// A wrapper for the POSIX stat() function. The stat() function
/// returns information about a file. On Windows the stat() function in
/// the C library checks only the FAT-style READONLY attribute and does
/// not look at the ACL at all. Thus on Windows the protection bits in
/// the @st_mode field are a fabrication of little use.
/// </para>
/// <para>
/// On Windows the Microsoft C libraries have several variants of the
/// stat struct and stat() function with names like _stat(), _stat32(),
/// _stat32i64() and _stat64i32(). The one used here is for 32-bit code
/// the one with 32-bit size and time fields, specifically called _stat32().
/// </para>
/// <para>
/// In Microsoft&apos;s compiler, by default struct stat means one with
/// 64-bit time fields while in MinGW struct stat is the legacy one
/// with 32-bit fields. To hopefully clear up this messs, the gstdio.h
/// header defines a type #GStatBuf which is the appropriate struct type
/// depending on the platform and/or compiler being used. On POSIX it
/// is just struct stat, but note that even on POSIX platforms, stat()
/// might be a macro.
/// </para>
/// <para>
/// See your C library manual for more details about stat().
/// </para>
/// </summary>

/// <param name="filename">
/// a pathname in the GLib file name encoding
///     (UTF-8 on Windows)
/// </param>
/// <param name="buf">
/// a pointer to a stat struct, which will be filled with the file
///     information
/// </param>
/// <return>
/// 0 if the information was successfully retrieved,
///     -1 if an error occurred
/// </return>

	public static int Stat(string filename, MentorLake.GLib.GStatBufHandle buf)
	{
		return GLibGlobalFunctionsExterns.g_stat(filename, buf);
	}

/// <summary>
/// <para>
/// Copies a nul-terminated string into the destination buffer, including
/// the trailing nul byte, and returns a pointer to the trailing nul byte
/// in `dest`.  The return value is useful for concatenating multiple
/// strings without having to repeatedly scan for the end.
/// </para>
/// </summary>

/// <param name="dest">
/// destination buffer
/// </param>
/// <param name="src">
/// source string
/// </param>
/// <return>
/// a pointer to the trailing nul byte in `dest`
/// </return>

	public static string Stpcpy(string dest, string src)
	{
		return GLibGlobalFunctionsExterns.g_stpcpy(dest, src);
	}

/// <summary>
/// <para>
/// Compares two strings for byte-by-byte equality and returns %TRUE
/// if they are equal. It can be passed to g_hash_table_new() as the
/// @key_equal_func parameter, when using non-%NULL strings as keys in a
/// #GHashTable.
/// </para>
/// <para>
/// This function is typically used for hash table comparisons, but can be used
/// for general purpose comparisons of non-%NULL strings. For a %NULL-safe string
/// comparison function, see g_strcmp0().
/// </para>
/// </summary>

/// <param name="v1">
/// a key
/// </param>
/// <param name="v2">
/// a key to compare with @v1
/// </param>
/// <return>
/// %TRUE if the two keys match
/// </return>

	public static bool StrEqual(IntPtr v1, IntPtr v2)
	{
		return GLibGlobalFunctionsExterns.g_str_equal(v1, v2);
	}

/// <summary>
/// <para>
/// Looks whether the string @str begins with @prefix.
/// </para>
/// </summary>

/// <param name="str">
/// a string to look in
/// </param>
/// <param name="prefix">
/// the prefix to look for
/// </param>
/// <return>
/// true if @str begins with @prefix, false otherwise
/// </return>

	public static bool StrHasPrefix(string str, string prefix)
	{
		return GLibGlobalFunctionsExterns.g_str_has_prefix(str, prefix);
	}

/// <summary>
/// <para>
/// Looks whether a string ends with @suffix.
/// </para>
/// </summary>

/// <param name="str">
/// a string to look in
/// </param>
/// <param name="suffix">
/// the suffix to look for
/// </param>
/// <return>
/// true if @str ends with @suffix, false otherwise
/// </return>

	public static bool StrHasSuffix(string str, string suffix)
	{
		return GLibGlobalFunctionsExterns.g_str_has_suffix(str, suffix);
	}

/// <summary>
/// <para>
/// Converts a string to a hash value.
/// </para>
/// <para>
/// This function implements the widely used &quot;djb&quot; hash apparently
/// posted by Daniel Bernstein to comp.lang.c some time ago.  The 32
/// bit unsigned hash value starts at 5381 and for each byte &apos;c&apos; in
/// the string, is updated: `hash = hash * 33 + c`. This function
/// uses the signed value of each byte.
/// </para>
/// <para>
/// It can be passed to g_hash_table_new() as the @hash_func parameter,
/// when using non-%NULL strings as keys in a #GHashTable.
/// </para>
/// <para>
/// Note that this function may not be a perfect fit for all use cases.
/// For example, it produces some hash collisions with strings as short
/// as 2.
/// </para>
/// </summary>

/// <param name="v">
/// a string key
/// </param>
/// <return>
/// a hash value corresponding to the key
/// </return>

	public static uint StrHash(IntPtr v)
	{
		return GLibGlobalFunctionsExterns.g_str_hash(v);
	}

/// <summary>
/// <para>
/// Determines if a string is pure ASCII. A string is pure ASCII if it
/// contains no bytes with the high bit set.
/// </para>
/// </summary>

/// <param name="str">
/// a string
/// </param>
/// <return>
/// true if @str is ASCII
/// </return>

	public static bool StrIsAscii(string str)
	{
		return GLibGlobalFunctionsExterns.g_str_is_ascii(str);
	}

/// <summary>
/// <para>
/// Checks if a search conducted for @search_term should match
/// @potential_hit.
/// </para>
/// <para>
/// This function calls [func@GLib.str_tokenize_and_fold] on both
/// @search_term and @potential_hit. ASCII alternates are never taken
/// for @search_term but will be taken for @potential_hit according to
/// the value of @accept_alternates.
/// </para>
/// <para>
/// A hit occurs when each folded token in @search_term is a prefix of a
/// folded token from @potential_hit.
/// </para>
/// <para>
/// Depending on how you&apos;re performing the search, it will typically be
/// faster to call `g_str_tokenize_and_fold()` on each string in
/// your corpus and build an index on the returned folded tokens, then
/// call `g_str_tokenize_and_fold()` on the search term and
/// perform lookups into that index.
/// </para>
/// <para>
/// As some examples, searching for ‘fred’ would match the potential hit
/// ‘Smith, Fred’ and also ‘Frédéric’.  Searching for ‘Fréd’ would match
/// ‘Frédéric’ but not ‘Frederic’ (due to the one-directional nature of
/// accent matching).  Searching ‘fo’ would match ‘Foo’ and ‘Bar Foo
/// Baz’, but not ‘SFO’ (because no word has ‘fo’ as a prefix).
/// </para>
/// </summary>

/// <param name="search_term">
/// the search term from the user
/// </param>
/// <param name="potential_hit">
/// the text that may be a hit
/// </param>
/// <param name="accept_alternates">
/// if true, ASCII alternates are accepted
/// </param>
/// <return>
/// true if @potential_hit is a hit
/// </return>

	public static bool StrMatchString(string search_term, string potential_hit, bool accept_alternates)
	{
		return GLibGlobalFunctionsExterns.g_str_match_string(search_term, potential_hit, accept_alternates);
	}

/// <summary>
/// <para>
/// Transliterate @str to plain ASCII.
/// </para>
/// <para>
/// For best results, @str should be in composed normalised form.
/// </para>
/// <para>
/// This function performs a reasonably good set of character
/// replacements.  The particular set of replacements that is done may
/// change by version or even by runtime environment.
/// </para>
/// <para>
/// If the source language of @str is known, it can used to improve the
/// accuracy of the translation by passing it as @from_locale.  It should
/// be a valid POSIX locale string (of the form
/// `language[_territory][.codeset][@modifier]`).
/// </para>
/// <para>
/// If @from_locale is %NULL then the current locale is used.
/// </para>
/// <para>
/// If you want to do translation for no specific locale, and you want it
/// to be done independently of the currently locale, specify `&quot;C&quot;` for
/// @from_locale.
/// </para>
/// </summary>

/// <param name="str">
/// a string, in UTF-8
/// </param>
/// <param name="from_locale">
/// the source locale, if known
/// </param>
/// <return>
/// a string in plain ASCII
/// </return>

	public static string StrToAscii(string str, string from_locale)
	{
		return GLibGlobalFunctionsExterns.g_str_to_ascii(str, from_locale);
	}

/// <summary>
/// <para>
/// Tokenizes @string and performs folding on each token.
/// </para>
/// <para>
/// A token is a non-empty sequence of alphanumeric characters in the
/// source string, separated by non-alphanumeric characters.  An
/// &quot;alphanumeric&quot; character for this purpose is one that matches
/// [func@GLib.unichar_isalnum] or [func@GLib.unichar_ismark].
/// </para>
/// <para>
/// Each token is then (Unicode) normalised and case-folded.  If
/// @ascii_alternates is non-`NULL` and some of the returned tokens
/// contain non-ASCII characters, ASCII alternatives will be generated.
/// </para>
/// <para>
/// The number of ASCII alternatives that are generated and the method
/// for doing so is unspecified, but @translit_locale (if specified) may
/// improve the transliteration if the language of the source string is
/// known.
/// </para>
/// </summary>

/// <param name="@string">
/// a string to tokenize
/// </param>
/// <param name="translit_locale">
/// the language code (like &apos;de&apos; or
///   &apos;en_GB&apos;) from which @string originates
/// </param>
/// <param name="ascii_alternates">
/// 
///   a return location for ASCII alternates
/// </param>
/// <return>
/// the folded tokens
/// </return>

	public static string[] StrTokenizeAndFold(string @string, string translit_locale, out string[] ascii_alternates)
	{
		return GLibGlobalFunctionsExterns.g_str_tokenize_and_fold(@string, translit_locale, out ascii_alternates);
	}

/// <summary>
/// <para>
/// For each character in @string, if the character is not in @valid_chars,
/// replaces the character with @substitutor.
/// </para>
/// <para>
/// Modifies @string in place, and return @string itself, not a copy. The
/// return value is to allow nesting such as:
/// ```C
/// g_ascii_strup (g_strcanon (str, &quot;abc&quot;, &apos;?&apos;))
/// ```
/// </para>
/// <para>
/// In order to modify a copy, you may use [func@GLib.strdup]:
/// ```C
/// reformatted = g_strcanon (g_strdup (const_str), &quot;abc&quot;, &apos;?&apos;);
/// …
/// g_free (reformatted);
/// ```
/// </para>
/// </summary>

/// <param name="@string">
/// a nul-terminated array of bytes
/// </param>
/// <param name="valid_chars">
/// bytes permitted in @string
/// </param>
/// <param name="substitutor">
/// replacement character for disallowed bytes
/// </param>
/// <return>
/// the modified @string
/// </return>

	public static string Strcanon(string @string, string valid_chars, char substitutor)
	{
		return GLibGlobalFunctionsExterns.g_strcanon(@string, valid_chars, substitutor);
	}

/// <summary>
/// <para>
/// A case-insensitive string comparison, corresponding to the standard
/// `strcasecmp()` function on platforms which support it.
/// </para>
/// </summary>

/// <param name="s1">
/// string to compare with @s2
/// </param>
/// <param name="s2">
/// string to compare with @s1
/// </param>
/// <return>
/// 0 if the strings match, a negative value if @s1 &amp;lt; @s2,
///   or a positive value if @s1 &amp;gt; @s2
/// </return>

	public static int Strcasecmp(string s1, string s2)
	{
		return GLibGlobalFunctionsExterns.g_strcasecmp(s1, s2);
	}

/// <summary>
/// <para>
/// Removes trailing whitespace from a string.
/// </para>
/// <para>
/// This function doesn&apos;t allocate or reallocate any memory;
/// it modifies @string in place. Therefore, it cannot be used
/// on statically allocated strings.
/// </para>
/// <para>
/// The pointer to @string is returned to allow the nesting of functions.
/// </para>
/// <para>
/// Also see [func@GLib.strchug] and [func@GLib.strstrip].
/// </para>
/// </summary>

/// <param name="@string">
/// a string to remove the trailing whitespace from
/// </param>
/// <return>
/// the modified @string
/// </return>

	public static string Strchomp(string @string)
	{
		return GLibGlobalFunctionsExterns.g_strchomp(@string);
	}

/// <summary>
/// <para>
/// Removes leading whitespace from a string, by moving the rest
/// of the characters forward.
/// </para>
/// <para>
/// This function doesn&apos;t allocate or reallocate any memory;
/// it modifies @string in place. Therefore, it cannot be used on
/// statically allocated strings.
/// </para>
/// <para>
/// The pointer to @string is returned to allow the nesting of functions.
/// </para>
/// <para>
/// Also see [func@GLib.strchomp] and [func@GLib.strstrip].
/// </para>
/// </summary>

/// <param name="@string">
/// a string to remove the leading whitespace from
/// </param>
/// <return>
/// the modified @string
/// </return>

	public static string Strchug(string @string)
	{
		return GLibGlobalFunctionsExterns.g_strchug(@string);
	}

/// <summary>
/// <para>
/// Compares @str1 and @str2 like `strcmp()`.
/// </para>
/// <para>
/// Handles `NULL` gracefully by sorting it before non-`NULL` strings.
/// Comparing two `NULL` pointers returns 0.
/// </para>
/// </summary>

/// <param name="str1">
/// a string
/// </param>
/// <param name="str2">
/// another string
/// </param>
/// <return>
/// an integer less than, equal to, or greater than zero,
///   if @str1 is &amp;lt;, == or &amp;gt; than @str2
/// </return>

	public static int Strcmp0(string str1, string str2)
	{
		return GLibGlobalFunctionsExterns.g_strcmp0(str1, str2);
	}

/// <summary>
/// <para>
/// Makes a copy of a string replacing C string-style escape
/// sequences with their one byte equivalent:
/// </para>
/// <para>
/// - `\b` → [U+0008 Backspace](https://en.wikipedia.org/wiki/Backspace)
/// - `\f` → [U+000C Form Feed](https://en.wikipedia.org/wiki/Form_feed)
/// - `\n` → [U+000A Line Feed](https://en.wikipedia.org/wiki/Newline)
/// - `\r` → [U+000D Carriage Return](https://en.wikipedia.org/wiki/Carriage_return)
/// - `\t` → [U+0009 Horizontal Tabulation](https://en.wikipedia.org/wiki/Tab_character)
/// - `\v` → [U+000B Vertical Tabulation](https://en.wikipedia.org/wiki/Vertical_Tab)
/// - `\` followed by one to three octal digits → the numeric value (mod 255)
/// - `\` followed by any other character → the character as is.
///   For example, `\\` will turn into a backslash (`\`) and `\&quot;` into a double quote (`&quot;`).
/// </para>
/// <para>
/// [func@GLib.strescape] does the reverse conversion.
/// </para>
/// </summary>

/// <param name="source">
/// a string to compress
/// </param>
/// <return>
/// a newly-allocated copy of @source with all escaped
///   character compressed
/// </return>

	public static string Strcompress(string source)
	{
		return GLibGlobalFunctionsExterns.g_strcompress(source);
	}

/// <summary>
/// <para>
/// Concatenates all of the given strings into one long string.
/// </para>
/// <para>
/// The variable argument list must end with `NULL`. If you forget the `NULL`,
/// `g_strconcat()` will start appending random memory junk to your string.
/// </para>
/// <para>
/// Note that this function is usually not the right function to use to
/// assemble a translated message from pieces, since proper translation
/// often requires the pieces to be reordered.
/// </para>
/// </summary>

/// <param name="string1">
/// the first string to add, which must not be `NULL`
/// </param>
/// <param name="@__arglist">
/// a `NULL`-terminated list of strings to append to the string
/// </param>
/// <return>
/// a newly-allocated string containing all the string arguments
/// </return>

	public static string Strconcat(string string1, IntPtr @__arglist)
	{
		return GLibGlobalFunctionsExterns.g_strconcat(string1, @__arglist);
	}

/// <summary>
/// <para>
/// Converts any delimiter characters in @string to @new_delimiter.
/// </para>
/// <para>
/// Any characters in @string which are found in @delimiters are
/// changed to the @new_delimiter character. Modifies @string in place,
/// and returns @string itself, not a copy.
/// </para>
/// <para>
/// The return value is to allow nesting such as:
/// ```C
/// g_ascii_strup (g_strdelimit (str, &quot;abc&quot;, &apos;?&apos;))
/// ```
/// </para>
/// <para>
/// In order to modify a copy, you may use [func@GLib.strdup]:
/// ```C
/// reformatted = g_strdelimit (g_strdup (const_str), &quot;abc&quot;, &apos;?&apos;);
/// …
/// g_free (reformatted);
/// ```
/// </para>
/// </summary>

/// <param name="@string">
/// the string to convert
/// </param>
/// <param name="delimiters">
/// a string containing the current delimiters, or
///   `NULL` to use the standard delimiters defined in [const@GLib.STR_DELIMITERS]
/// </param>
/// <param name="new_delimiter">
/// the new delimiter character
/// </param>
/// <return>
/// the modified @string
/// </return>

	public static string Strdelimit(string @string, string delimiters, char new_delimiter)
	{
		return GLibGlobalFunctionsExterns.g_strdelimit(@string, delimiters, new_delimiter);
	}

/// <summary>
/// <para>
/// Converts a string to lower case.
/// </para>
/// </summary>

/// <param name="@string">
/// the string to convert
/// </param>
/// <return>
/// the string
/// </return>

	public static string Strdown(string @string)
	{
		return GLibGlobalFunctionsExterns.g_strdown(@string);
	}

/// <summary>
/// <para>
/// Duplicates a string. If @str is `NULL` it returns `NULL`.
/// </para>
/// </summary>

/// <param name="str">
/// the string to duplicate
/// </param>
/// <return>
/// a newly-allocated copy of @str
/// </return>

	public static string Strdup(string str)
	{
		return GLibGlobalFunctionsExterns.g_strdup(str);
	}

/// <summary>
/// <para>
/// Similar to the standard C `sprintf()` function but safer, since it
/// calculates the maximum space required and allocates memory to hold
/// the result.
/// </para>
/// <para>
/// The returned string is guaranteed to be non-NULL, unless @format
/// contains `%lc` or `%ls` conversions, which can fail if no multibyte
/// representation is available for the given character.
/// </para>
/// </summary>

/// <param name="format">
/// a standard `printf()` format string, but notice
///   [string precision pitfalls](string-utils.html#string-precision-pitfalls)
/// </param>
/// <param name="@__arglist">
/// the parameters to insert into the format string
/// </param>
/// <return>
/// a newly-allocated string holding the
///   result
/// </return>

	public static string StrdupPrintf(string format, IntPtr @__arglist)
	{
		return GLibGlobalFunctionsExterns.g_strdup_printf(format, @__arglist);
	}

/// <summary>
/// <para>
/// Similar to the standard C `vsprintf()` function but safer, since it
/// calculates the maximum space required and allocates memory to hold
/// the result.
/// </para>
/// <para>
/// The returned string is guaranteed to be non-NULL, unless @format
/// contains `%lc` or `%ls` conversions, which can fail if no multibyte
/// representation is available for the given character.
/// </para>
/// <para>
/// See also [func@GLib.vasprintf], which offers the same functionality, but
/// additionally returns the length of the allocated string.
/// </para>
/// </summary>

/// <param name="format">
/// a standard `printf()` format string, but notice
///   [string precision pitfalls](string-utils.html#string-precision-pitfalls)
/// </param>
/// <param name="args">
/// the list of parameters to insert into the format string
/// </param>
/// <return>
/// a newly-allocated string holding the
///   result
/// </return>

	public static string StrdupVprintf(string format, IntPtr args)
	{
		return GLibGlobalFunctionsExterns.g_strdup_vprintf(format, args);
	}

/// <summary>
/// <para>
/// Copies an array of strings. The copy is a deep copy; each string is also
/// copied.
/// </para>
/// <para>
/// If called on a `NULL` value, `g_strdupv()` simply returns `NULL`.
/// </para>
/// </summary>

/// <param name="str_array">
/// an array of strings to copy
/// </param>
/// <return>
/// a
///   newly-allocated array of strings. Use [func@GLib.strfreev] to free it.
/// </return>

	public static string[] Strdupv(string[] str_array)
	{
		return GLibGlobalFunctionsExterns.g_strdupv(str_array);
	}

/// <summary>
/// <para>
/// Returns a string corresponding to the given error code, e.g. &quot;no
/// such process&quot;.
/// </para>
/// <para>
/// Unlike `strerror()`, this always returns a string in
/// UTF-8 encoding, and the pointer is guaranteed to remain valid for
/// the lifetime of the process. If the error code is unknown, it returns a
/// string like “Unknown error &amp;lt;code\&amp;gt;”.
/// </para>
/// <para>
/// Note that the string may be translated according to the current locale.
/// </para>
/// <para>
/// The value of `errno` will not be changed by this function. However, it may
/// be changed by intermediate function calls, so you should save its value
/// as soon as the call returns:
/// ```C
/// int saved_errno;
/// </para>
/// <para>
/// ret = read (blah);
/// saved_errno = errno;
/// </para>
/// <para>
/// g_strerror (saved_errno);
/// ```
/// </para>
/// </summary>

/// <param name="errnum">
/// the system error number. See the standard C `errno` documentation
/// </param>
/// <return>
/// the string describing the error code
/// </return>

	public static string Strerror(int errnum)
	{
		return GLibGlobalFunctionsExterns.g_strerror(errnum);
	}

/// <summary>
/// <para>
/// It replaces the following special characters in the string @source
/// with their corresponding C escape sequence:
/// </para>
/// <para>
///  Symbol | Escape
/// ---|---
///  [U+0008 Backspace](https://en.wikipedia.org/wiki/Backspace) | `\b`
///  [U+000C Form Feed](https://en.wikipedia.org/wiki/Form_feed) | `\f`
///  [U+000A Line Feed](https://en.wikipedia.org/wiki/Newline) | `\n`
///  [U+000D Carriage Return](https://en.wikipedia.org/wiki/Carriage_return) | `\r`
///  [U+0009 Horizontal Tabulation](https://en.wikipedia.org/wiki/Tab_character) | `\t`
///  [U+000B Vertical Tabulation](https://en.wikipedia.org/wiki/Vertical_Tab) | `\v`
/// </para>
/// <para>
/// It also inserts a backslash (`\`) before any backslash or a double quote (`&quot;`).
/// Additionally all characters in the range 0x01-0x1F (everything
/// below SPACE) and in the range 0x7F-0xFF (all non-ASCII chars) are
/// replaced with a backslash followed by their octal representation.
/// Characters supplied in @exceptions are not escaped.
/// </para>
/// <para>
/// [func@GLib.strcompress] does the reverse conversion.
/// </para>
/// </summary>

/// <param name="source">
/// a string to escape
/// </param>
/// <param name="exceptions">
/// a string of characters not to escape in @source
/// </param>
/// <return>
/// a newly-allocated copy of @source with special characters escaped
/// </return>

	public static string Strescape(string source, string exceptions)
	{
		return GLibGlobalFunctionsExterns.g_strescape(source, exceptions);
	}

/// <summary>
/// <para>
/// Frees an array of strings, as well as each string it contains.
/// </para>
/// <para>
/// If @str_array is `NULL`, this function simply returns.
/// </para>
/// </summary>

/// <param name="str_array">
/// an
///   array of strings to free
/// </param>

	public static void Strfreev(string[] str_array)
	{
		GLibGlobalFunctionsExterns.g_strfreev(str_array);
	}

/// <summary>
/// <para>
/// An auxiliary function for gettext() support (see Q_()).
/// </para>
/// </summary>

/// <param name="msgid">
/// a string
/// </param>
/// <param name="msgval">
/// another string
/// </param>
/// <return>
/// @msgval, unless @msgval is identical to @msgid
///     and contains a &apos;|&apos; character, in which case a pointer to
///     the substring of msgid after the first &apos;|&apos; character is returned.
/// </return>

	public static string StripContext(string msgid, string msgval)
	{
		return GLibGlobalFunctionsExterns.g_strip_context(msgid, msgval);
	}

/// <summary>
/// <para>
/// Joins a number of strings together to form one long string, with the
/// optional @separator inserted between each of them.
/// </para>
/// </summary>

/// <param name="separator">
/// a string to insert between each of the strings
/// </param>
/// <param name="@__arglist">
/// a `NULL`-terminated list of strings to join
/// </param>
/// <return>
/// a newly-allocated string containing all of the strings joined
///   together, with @separator between them
/// </return>

	public static string Strjoin(string separator, IntPtr @__arglist)
	{
		return GLibGlobalFunctionsExterns.g_strjoin(separator, @__arglist);
	}

/// <summary>
/// <para>
/// Joins an array of strings together to form one long string, with the
/// optional @separator inserted between each of them.
/// </para>
/// <para>
/// If @str_array has no items, the return value will be an
/// empty string. If @str_array contains a single item, @separator will not
/// appear in the resulting string.
/// </para>
/// </summary>

/// <param name="separator">
/// a string to insert between each of the strings
/// </param>
/// <param name="str_array">
/// an array of strings to join
/// </param>
/// <return>
/// a newly-allocated string containing all of the strings joined
///   together, with @separator between them
/// </return>

	public static string Strjoinv(string separator, string[] str_array)
	{
		return GLibGlobalFunctionsExterns.g_strjoinv(separator, str_array);
	}

/// <summary>
/// <para>
/// Portability wrapper that calls `strlcat()` on systems which have it,
/// and emulates it otherwise. Appends nul-terminated @src string to @dest,
/// guaranteeing nul-termination for @dest. The total size of @dest won&apos;t
/// exceed @dest_size.
/// </para>
/// <para>
/// At most @dest_size - 1 characters will be copied. Unlike `strncat()`,
/// @dest_size is the full size of dest, not the space left over. This
/// function does not allocate memory. It always nul-terminates (unless
/// @dest_size == 0 or there were no nul characters in the @dest_size
/// characters of dest to start with).
/// </para>
/// <para>
/// Caveat: this is supposedly a more secure alternative to `strcat()` or
/// `strncat()`, but for real security [func@GLib.strconcat] is harder to mess up.
/// </para>
/// </summary>

/// <param name="dest">
/// destination buffer, already containing one nul-terminated string
/// </param>
/// <param name="src">
/// source buffer
/// </param>
/// <param name="dest_size">
/// length of @dest buffer in bytes (not length of existing string
///   inside @dest)
/// </param>
/// <return>
/// size of attempted result, which is `MIN (dest_size, strlen
///   (original dest)) + strlen (src)`, so if @retval &amp;gt;= @dest_size,
///   truncation occurred
/// </return>

	public static UIntPtr Strlcat(string dest, string src, UIntPtr dest_size)
	{
		return GLibGlobalFunctionsExterns.g_strlcat(dest, src, dest_size);
	}

/// <summary>
/// <para>
/// Portability wrapper that calls `strlcpy()` on systems which have it,
/// and emulates `strlcpy()` otherwise. Copies @src to @dest; @dest is
/// guaranteed to be nul-terminated; @src must be nul-terminated;
/// @dest_size is the buffer size, not the number of bytes to copy.
/// </para>
/// <para>
/// At most @dest_size - 1 characters will be copied. Always nul-terminates
/// (unless @dest_size is 0). This function does not allocate memory. Unlike
/// `strncpy()`, this function doesn&apos;t pad @dest (so it&apos;s often faster). It
/// returns the size of the attempted result, `strlen (src)`, so if
/// @retval &amp;gt;= @dest_size, truncation occurred.
/// </para>
/// <para>
/// Caveat: `strlcpy()` is supposedly more secure than `strcpy()` or `strncpy()`,
/// but if you really want to avoid screwups, [func@GLib.strdup] is an even better
/// idea.
/// </para>
/// </summary>

/// <param name="dest">
/// destination buffer
/// </param>
/// <param name="src">
/// source buffer
/// </param>
/// <param name="dest_size">
/// length of @dest in bytes
/// </param>
/// <return>
/// length of @src
/// </return>

	public static UIntPtr Strlcpy(string dest, string src, UIntPtr dest_size)
	{
		return GLibGlobalFunctionsExterns.g_strlcpy(dest, src, dest_size);
	}

/// <summary>
/// <para>
/// A case-insensitive string comparison, corresponding to the standard
/// `strncasecmp()` function on platforms which support it. It is similar
/// to [func@GLib.strcasecmp] except it only compares the first @n characters of
/// the strings.
/// </para>
/// </summary>

/// <param name="s1">
/// string to compare with @s2
/// </param>
/// <param name="s2">
/// string to compare with @s1
/// </param>
/// <param name="n">
/// the maximum number of characters to compare
/// </param>
/// <return>
/// 0 if the strings match, a negative value if @s1 &amp;lt; @s2,
///   or a positive value if @s1 &amp;gt; @s2
/// </return>

	public static int Strncasecmp(string s1, string s2, uint n)
	{
		return GLibGlobalFunctionsExterns.g_strncasecmp(s1, s2, n);
	}

/// <summary>
/// <para>
/// Duplicates the first @n bytes of a string, returning a newly-allocated
/// buffer @n + 1 bytes long which will always be nul-terminated. If @str
/// is less than @n bytes long the buffer is padded with nuls. If @str is
/// `NULL` it returns `NULL`.
/// </para>
/// <para>
/// To copy a number of characters from a UTF-8 encoded string,
/// use [func@GLib.utf8_strncpy] instead.
/// </para>
/// </summary>

/// <param name="str">
/// the string to duplicate
/// </param>
/// <param name="n">
/// the maximum number of bytes to copy from @str
/// </param>
/// <return>
/// a newly-allocated buffer containing the first
///    @n bytes of @str
/// </return>

	public static string Strndup(string str, UIntPtr n)
	{
		return GLibGlobalFunctionsExterns.g_strndup(str, n);
	}

/// <summary>
/// <para>
/// Creates a new string @length bytes long filled with @fill_char.
/// </para>
/// </summary>

/// <param name="length">
/// the length of the new string
/// </param>
/// <param name="fill_char">
/// the byte to fill the string with
/// </param>
/// <return>
/// a newly-allocated string filled with @fill_char
/// </return>

	public static string Strnfill(UIntPtr length, char fill_char)
	{
		return GLibGlobalFunctionsExterns.g_strnfill(length, fill_char);
	}

/// <summary>
/// <para>
/// Reverses all of the bytes in a string. For example,
/// `g_strreverse (&quot;abcdef&quot;)` will result in &quot;fedcba&quot;.
/// </para>
/// <para>
/// Note that `g_strreverse()` doesn&apos;t work on UTF-8 strings
/// containing multibyte characters. For that purpose, use
/// [func@GLib.utf8_strreverse].
/// </para>
/// </summary>

/// <param name="@string">
/// the string to reverse
/// </param>
/// <return>
/// the @string, reversed in place
/// </return>

	public static string Strreverse(string @string)
	{
		return GLibGlobalFunctionsExterns.g_strreverse(@string);
	}

/// <summary>
/// <para>
/// Searches the string @haystack for the last occurrence
/// of the string @needle.
/// </para>
/// <para>
/// The fact that this function returns `gchar *` rather than `const gchar *` is
/// a historical artifact.
/// </para>
/// </summary>

/// <param name="haystack">
/// a string to search in
/// </param>
/// <param name="needle">
/// the string to search for
/// </param>
/// <return>
/// a pointer to the found occurrence, or
///    `NULL` if not found
/// </return>

	public static string Strrstr(string haystack, string needle)
	{
		return GLibGlobalFunctionsExterns.g_strrstr(haystack, needle);
	}

/// <summary>
/// <para>
/// Searches the string @haystack for the last occurrence
/// of the string @needle, limiting the length of the search
/// to @haystack_len.
/// </para>
/// <para>
/// The fact that this function returns `gchar *` rather than `const gchar *` is
/// a historical artifact.
/// </para>
/// </summary>

/// <param name="haystack">
/// a string to search in
/// </param>
/// <param name="haystack_len">
/// the maximum length of @haystack in bytes. A length of `-1`
///   can be used to mean &quot;search the entire string&quot;, like [func@GLib.strrstr]
/// </param>
/// <param name="needle">
/// the string to search for
/// </param>
/// <return>
/// a pointer to the found occurrence, or
///    `NULL` if not found
/// </return>

	public static string StrrstrLen(string haystack, UIntPtr haystack_len, string needle)
	{
		return GLibGlobalFunctionsExterns.g_strrstr_len(haystack, haystack_len, needle);
	}

/// <summary>
/// <para>
/// Returns a string describing the given signal, e.g. &quot;Segmentation fault&quot;.
/// If the signal is unknown, it returns “unknown signal (&amp;lt;signum\&amp;gt;)”.
/// </para>
/// <para>
/// You should use this function in preference to `strsignal()`, because it
/// returns a string in UTF-8 encoding, and since not all platforms support
/// the `strsignal()` function.
/// </para>
/// </summary>

/// <param name="signum">
/// the signal number. See the `signal` documentation
/// </param>
/// <return>
/// the string describing the signal
/// </return>

	public static string Strsignal(int signum)
	{
		return GLibGlobalFunctionsExterns.g_strsignal(signum);
	}

/// <summary>
/// <para>
/// Splits a string into a maximum of @max_tokens pieces, using the given
/// @delimiter. If @max_tokens is reached, the remainder of @string is
/// appended to the last token.
/// </para>
/// <para>
/// As an example, the result of `g_strsplit (&quot;:a:bc::d:&quot;, &quot;:&quot;, -1)` is an array
/// containing the six strings &quot;&quot;, &quot;a&quot;, &quot;bc&quot;, &quot;&quot;, &quot;d&quot; and &quot;&quot;.
/// </para>
/// <para>
/// As a special case, the result of splitting the empty string &quot;&quot; is an empty
/// array, not an array containing a single string. The reason for this
/// special case is that being able to represent an empty array is typically
/// more useful than consistent handling of empty elements. If you do need
/// to represent empty elements, you&apos;ll need to check for the empty string
/// before calling `g_strsplit()`.
/// </para>
/// </summary>

/// <param name="@string">
/// a string to split
/// </param>
/// <param name="delimiter">
/// a string which specifies the places at which to split
///   the string. The delimiter is not included in any of the resulting
///   strings, unless @max_tokens is reached.
/// </param>
/// <param name="max_tokens">
/// the maximum number of pieces to split @string into
///   If this is less than 1, the string is split completely
/// </param>
/// <return>
/// a newly-allocated array of strings, freed with
///   [func@GLib.strfreev]
/// </return>

	public static string[] Strsplit(string @string, string delimiter, int max_tokens)
	{
		return GLibGlobalFunctionsExterns.g_strsplit(@string, delimiter, max_tokens);
	}

/// <summary>
/// <para>
/// Splits @string into a number of tokens not containing any of the characters
/// in @delimiters. A token is the (possibly empty) longest string that does not
/// contain any of the characters in @delimiters. If @max_tokens is reached, the
/// remainder is appended to the last token.
/// </para>
/// <para>
/// For example, the result of g_strsplit_set (&quot;abc:def/ghi&quot;, &quot;:/&quot;, -1) is an
/// array containing the three strings &quot;abc&quot;, &quot;def&quot;, and &quot;ghi&quot;.
/// </para>
/// <para>
/// The result of g_strsplit_set (&quot;:def/ghi:&quot;, &quot;:/&quot;, -1) is an array containing
/// the four strings &quot;&quot;, &quot;def&quot;, &quot;ghi&quot;, and &quot;&quot;.
/// </para>
/// <para>
/// As a special case, the result of splitting the empty string &quot;&quot; is an empty
/// array, not an array containing a single string. The reason for this
/// special case is that being able to represent an empty array is typically
/// more useful than consistent handling of empty elements. If you do need
/// to represent empty elements, you&apos;ll need to check for the empty string
/// before calling `g_strsplit_set()`.
/// </para>
/// <para>
/// Note that this function works on bytes not characters, so it can&apos;t be used
/// to delimit UTF-8 strings for anything but ASCII characters.
/// </para>
/// </summary>

/// <param name="@string">
/// a string to split
/// </param>
/// <param name="delimiters">
/// a string containing characters that are used to split the
///   string. Can be empty, which will result in no string splitting
/// </param>
/// <param name="max_tokens">
/// the maximum number of tokens to split @string into.
///   If this is less than 1, the string is split completely
/// </param>
/// <return>
/// a newly-allocated array of strings. Use
///   [func@GLib.strfreev] to free it.
/// </return>

	public static string[] StrsplitSet(string @string, string delimiters, int max_tokens)
	{
		return GLibGlobalFunctionsExterns.g_strsplit_set(@string, delimiters, max_tokens);
	}

/// <summary>
/// <para>
/// Searches the string @haystack for the first occurrence
/// of the string @needle, limiting the length of the search
/// to @haystack_len or a nul terminator byte (whichever is reached first).
/// </para>
/// <para>
/// A length of `-1` can be used to mean “search the entire string”, like
/// `strstr()`.
/// </para>
/// <para>
/// The fact that this function returns `gchar *` rather than `const gchar *` is
/// a historical artifact.
/// </para>
/// </summary>

/// <param name="haystack">
/// a string to search in
/// </param>
/// <param name="haystack_len">
/// the maximum length of @haystack in bytes, or `-1` to
///   search it entirely
/// </param>
/// <param name="needle">
/// the string to search for
/// </param>
/// <return>
/// a pointer to the found occurrence, or
///    `NULL` if not found
/// </return>

	public static string StrstrLen(string haystack, UIntPtr haystack_len, string needle)
	{
		return GLibGlobalFunctionsExterns.g_strstr_len(haystack, haystack_len, needle);
	}

/// <summary>
/// <para>
/// Converts a string to a floating point value.
/// </para>
/// <para>
/// It calls the standard `strtod()` function to handle the conversion, but
/// if the string is not completely converted it attempts the conversion
/// again with [func@GLib.ascii_strtod], and returns the best match.
/// </para>
/// <para>
/// This function should seldom be used. The normal situation when reading
/// numbers not for human consumption is to use [func@GLib.ascii_strtod]. Only when
/// you know that you must expect both locale formatted and C formatted numbers
/// should you use this. Make sure that you don&apos;t pass strings such as comma
/// separated lists of values, since the commas may be interpreted as a decimal
/// point in some locales, causing unexpected results.
/// </para>
/// </summary>

/// <param name="nptr">
/// the string to convert to a numeric value
/// </param>
/// <param name="endptr">
/// if non-`NULL`, it returns the
///   character after the last character used in the conversion
/// </param>
/// <return>
/// the converted value
/// </return>

	public static double Strtod(string nptr, out string endptr)
	{
		return GLibGlobalFunctionsExterns.g_strtod(nptr, out endptr);
	}

/// <summary>
/// <para>
/// Converts a string to upper case.
/// </para>
/// </summary>

/// <param name="@string">
/// the string to convert
/// </param>
/// <return>
/// the string
/// </return>

	public static string Strup(string @string)
	{
		return GLibGlobalFunctionsExterns.g_strup(@string);
	}

/// <summary>
/// <para>
/// Checks if an array of strings contains the string @str according to
/// [func@GLib.str_equal]. @strv must not be `NULL`.
/// </para>
/// </summary>

/// <param name="strv">
/// an array of strings to search in
/// </param>
/// <param name="str">
/// the string to search for
/// </param>
/// <return>
/// true if @str is an element of @strv
/// </return>

	public static bool StrvContains(string[] strv, string str)
	{
		return GLibGlobalFunctionsExterns.g_strv_contains(strv, str);
	}

/// <summary>
/// <para>
/// Checks if two arrays of strings contain exactly the same elements in
/// exactly the same order.
/// </para>
/// <para>
/// Elements are compared using [func@GLib.str_equal]. To match independently
/// of order, sort the arrays first (using [func@GLib.qsort_with_data]
/// or similar).
/// </para>
/// <para>
/// Two empty arrays are considered equal. Neither @strv1 nor @strv2 may be
/// `NULL`.
/// </para>
/// </summary>

/// <param name="strv1">
/// an array of strings to compare to @strv2
/// </param>
/// <param name="strv2">
/// an array of strings to compare to @strv1
/// </param>
/// <return>
/// true if @strv1 and @strv2 are equal
/// </return>

	public static bool StrvEqual(string[] strv1, string[] strv2)
	{
		return GLibGlobalFunctionsExterns.g_strv_equal(strv1, strv2);
	}



	public static MentorLake.GObject.GType StrvGetType()
	{
		return GLibGlobalFunctionsExterns.g_strv_get_type();
	}

/// <summary>
/// <para>
/// Returns the length of an array of strings. @str_array must not be `NULL`.
/// </para>
/// </summary>

/// <param name="str_array">
/// an array of strings
/// </param>
/// <return>
/// length of @str_array
/// </return>

	public static uint StrvLength(string[] str_array)
	{
		return GLibGlobalFunctionsExterns.g_strv_length(str_array);
	}

/// <summary>
/// <para>
/// Creates a new test case.
/// </para>
/// <para>
/// This function is similar to [func@GLib.test_create_case].
/// However the test is assumed to use no fixture, and test suites are
/// automatically created on the fly and added to the root fixture,
/// based on the /-separated portions of @testpath. The @test_data
/// argument will be passed as first argument to @test_func.
/// </para>
/// <para>
/// If @testpath includes the component &quot;subprocess&quot; anywhere in it,
/// the test will be skipped by default, and only run if explicitly
/// required via the `-p` command-line option or [func@GLib.test_trap_subprocess].
/// </para>
/// <para>
/// No component of @testpath may start with a dot (`.`) if the
/// [const@GLib.TEST_OPTION_ISOLATE_DIRS] option is being used;
/// and it is recommended to do so even if it isn’t.
/// </para>
/// </summary>

/// <param name="testpath">
/// a /-separated name for the test
/// </param>
/// <param name="test_data">
/// data for the @test_func
/// </param>
/// <param name="test_func">
/// the test function to invoke for this test
/// </param>

	public static void TestAddDataFunc(string testpath, IntPtr test_data, MentorLake.GLib.GTestDataFunc test_func)
	{
		GLibGlobalFunctionsExterns.g_test_add_data_func(testpath, test_data, test_func);
	}

/// <summary>
/// <para>
/// Creates a new test case.
/// </para>
/// <para>
/// In constract to [func@GLib.test_add_data_func], this function
/// is freeing @test_data after the test run is complete.
/// </para>
/// </summary>

/// <param name="testpath">
/// a /-separated name for the test
/// </param>
/// <param name="test_data">
/// data for @test_func
/// </param>
/// <param name="test_func">
/// the test function to invoke for this test
/// </param>
/// <param name="data_free_func">
/// #GDestroyNotify for @test_data
/// </param>

	public static void TestAddDataFuncFull(string testpath, IntPtr test_data, MentorLake.GLib.GTestDataFunc test_func, MentorLake.GLib.GDestroyNotify data_free_func)
	{
		GLibGlobalFunctionsExterns.g_test_add_data_func_full(testpath, test_data, test_func, data_free_func);
	}

/// <summary>
/// <para>
/// Creates a new test case.
/// </para>
/// <para>
/// This function is similar to [func@GLib.test_create_case].
/// However the test is assumed to use no fixture, and test suites are
/// automatically created on the fly and added to the root fixture,
/// based on the /-separated portions of @testpath.
/// </para>
/// <para>
/// If @testpath includes the component &quot;subprocess&quot; anywhere in it,
/// the test will be skipped by default, and only run if explicitly
/// required via the `-p` command-line option or [func@GLib.test_trap_subprocess].
/// </para>
/// <para>
/// No component of @testpath may start with a dot (`.`) if the
/// [const@GLib.TEST_OPTION_ISOLATE_DIRS] option is being used; and
/// it is recommended to do so even if it isn’t.
/// </para>
/// </summary>

/// <param name="testpath">
/// a /-separated name for the test
/// </param>
/// <param name="test_func">
/// the test function to invoke for this test
/// </param>

	public static void TestAddFunc(string testpath, MentorLake.GLib.GTestFunc test_func)
	{
		GLibGlobalFunctionsExterns.g_test_add_func(testpath, test_func);
	}


/// <param name="testpath">
/// </param>
/// <param name="data_size">
/// </param>
/// <param name="test_data">
/// </param>
/// <param name="data_setup">
/// </param>
/// <param name="data_test">
/// </param>
/// <param name="data_teardown">
/// </param>

	public static void TestAddVtable(string testpath, UIntPtr data_size, IntPtr test_data, MentorLake.GLib.GTestFixtureFunc data_setup, MentorLake.GLib.GTestFixtureFunc data_test, MentorLake.GLib.GTestFixtureFunc data_teardown)
	{
		GLibGlobalFunctionsExterns.g_test_add_vtable(testpath, data_size, test_data, data_setup, data_test, data_teardown);
	}


/// <param name="domain">
/// </param>
/// <param name="file">
/// </param>
/// <param name="line">
/// </param>
/// <param name="func">
/// </param>

	public static void TestAssertExpectedMessagesInternal(string domain, string file, int line, string func)
	{
		GLibGlobalFunctionsExterns.g_test_assert_expected_messages_internal(domain, file, line, func);
	}

/// <summary>
/// <para>
/// Adds a message to test reports that associates a bug URI with a test case.
/// </para>
/// <para>
/// Bug URIs are constructed from a base URI set with [func@GLib.test_bug_base]
/// and @bug_uri_snippet. If [func@GLib.test_bug_base] has not been called, it is
/// assumed to be the empty string, so a full URI can be provided to
/// [func@GLib.test_bug] instead.
/// </para>
/// <para>
/// See also [func@GLib.test_summary].
/// </para>
/// <para>
/// Since GLib 2.70, the base URI is not prepended to @bug_uri_snippet
/// if it is already a valid URI.
/// </para>
/// </summary>

/// <param name="bug_uri_snippet">
/// Bug specific bug tracker URI or URI portion.
/// </param>

	public static void TestBug(string bug_uri_snippet)
	{
		GLibGlobalFunctionsExterns.g_test_bug(bug_uri_snippet);
	}

/// <summary>
/// <para>
/// Specifies the base URI for bug reports.
/// </para>
/// <para>
/// The base URI is used to construct bug report messages for
/// [func@GLib.test_message] when [func@GLib.test_bug] is called.
/// Calling this function outside of a test case sets the
/// default base URI for all test cases. Calling it from within
/// a test case changes the base URI for the scope of the test
/// case only.
/// Bug URIs are constructed by appending a bug specific URI
/// portion to @uri_pattern, or by replacing the special string
/// `%s` within @uri_pattern if that is present.
/// </para>
/// <para>
/// If [func@GLib.test_bug_base] is not called, bug URIs are formed
/// solely from the value provided by [func@GLib.test_bug].
/// </para>
/// </summary>

/// <param name="uri_pattern">
/// the base pattern for bug URIs
/// </param>

	public static void TestBugBase(string uri_pattern)
	{
		GLibGlobalFunctionsExterns.g_test_bug_base(uri_pattern);
	}

/// <summary>
/// <para>
/// Creates the pathname to a data file that is required for a test.
/// </para>
/// <para>
/// This function is conceptually similar to [func@GLib.build_filename]
/// except that the first argument has been replaced with a
/// [enum@GLib.TestFileType] argument.
/// </para>
/// <para>
/// The data file should either have been distributed with the module
/// containing the test ([enum@GLib.TestFileType.dist] or built as part of the
/// buildcsystem of that module ([enum@GLib.TestFileType.built]).
/// </para>
/// <para>
/// In order for this function to work in srcdir != builddir situations,
/// the `G_TEST_SRCDIR` and `G_TEST_BUILDDIR` environment variables need
/// to have been defined. As of 2.38, this is done by the glib.mk that is
/// included in GLib. Please ensure that your copy is up to date before
/// using this function.
/// </para>
/// <para>
/// In case neither variable is set, this function will fall back to
/// using the dirname portion of `argv[0]`, possibly removing &quot;.libs&quot;.
/// This allows for casual running of tests directly from the commandline
/// in the srcdir == builddir case and should also support running of
/// installed tests, assuming the data files have been installed in the
/// same relative path as the test binary.
/// </para>
/// </summary>

/// <param name="file_type">
/// the type of file (built vs. distributed)
/// </param>
/// <param name="first_path">
/// the first segment of the pathname
/// </param>
/// <param name="@__arglist">
/// `NULL`-terminated additional path segments
/// </param>
/// <return>
/// the path of the file, to be freed using [func@GLib.free]
/// </return>

	public static string TestBuildFilename(MentorLake.GLib.GTestFileType file_type, string first_path, IntPtr @__arglist)
	{
		return GLibGlobalFunctionsExterns.g_test_build_filename(file_type, first_path, @__arglist);
	}

/// <summary>
/// <para>
/// Creates a new [struct@GLib.TestCase].
/// </para>
/// <para>
/// This API is fairly low level, and calling [func@GLib.test_add] or
/// [func@GLib.test_add_func] is preferable.
/// </para>
/// <para>
/// When this test is executed, a fixture structure of size @data_size
/// will be automatically allocated and filled with zeros. Then @data_setup
/// is called to initialize the fixture. After fixture setup, the actual test
/// function @data_test is called. Once the test run completes, the
/// fixture structure is torn down by calling @data_teardown and after
/// that the memory is automatically released by the test framework.
/// </para>
/// <para>
/// Splitting up a test run into fixture setup, test function and
/// fixture teardown is most useful if the same fixture type is used for
/// multiple tests. In this cases, [func@GLib.test_create_case] will be
/// called with the same type of fixture (the @data_size argument), but
/// varying @test_name and @data_test arguments.
/// </para>
/// </summary>

/// <param name="test_name">
/// the name for the test case
/// </param>
/// <param name="data_size">
/// the size of the fixture data structure
/// </param>
/// <param name="test_data">
/// test data argument for the test functions
/// </param>
/// <param name="data_setup">
/// the function to set up the fixture data
/// </param>
/// <param name="data_test">
/// the actual test function
/// </param>
/// <param name="data_teardown">
/// the function to teardown the fixture data
/// </param>
/// <return>
/// a newly allocated test case
/// </return>

	public static MentorLake.GLib.GTestCaseHandle TestCreateCase(string test_name, UIntPtr data_size, IntPtr test_data, MentorLake.GLib.GTestFixtureFunc data_setup, MentorLake.GLib.GTestFixtureFunc data_test, MentorLake.GLib.GTestFixtureFunc data_teardown)
	{
		return GLibGlobalFunctionsExterns.g_test_create_case(test_name, data_size, test_data, data_setup, data_test, data_teardown);
	}

/// <summary>
/// <para>
/// Creates a new test suite with the name @suite_name.
/// </para>
/// </summary>

/// <param name="suite_name">
/// a name for the suite
/// </param>
/// <return>
/// a newly allocated test suite
/// </return>

	public static MentorLake.GLib.GTestSuiteHandle TestCreateSuite(string suite_name)
	{
		return GLibGlobalFunctionsExterns.g_test_create_suite(suite_name);
	}

/// <summary>
/// <para>
/// Attempts to disable system crash reporting infrastructure.
/// </para>
/// <para>
/// This function should be called before exercising code paths that are
/// expected or intended to crash, to avoid wasting resources in system-wide
/// crash collection infrastructure such as systemd-coredump or abrt.
/// </para>
/// </summary>


	public static void TestDisableCrashReporting()
	{
		GLibGlobalFunctionsExterns.g_test_disable_crash_reporting();
	}

/// <summary>
/// <para>
/// Indicates that a message with the given @log_domain and @log_level,
/// with text matching @pattern, is expected to be logged.
/// </para>
/// <para>
/// When this message is logged, it will not be printed, and the test case will
/// not abort.
/// </para>
/// <para>
/// This API may only be used with the old logging API ([func@GLib.log] without
/// `G_LOG_USE_STRUCTURED` defined). It will not work with the structured logging
/// API. See [Testing for Messages](logging.html#testing-for-messages).
/// </para>
/// <para>
/// Use [func@GLib.test_assert_expected_messages] to assert that all
/// previously-expected messages have been seen and suppressed.
/// </para>
/// <para>
/// You can call this multiple times in a row, if multiple messages are
/// expected as a result of a single call. (The messages must appear in
/// the same order as the calls to [func@GLib.test_expect_message].)
/// </para>
/// <para>
/// For example:
/// </para>
/// <para>
/// ```c
/// // g_main_context_push_thread_default() should fail if the
/// // context is already owned by another thread.
/// g_test_expect_message (G_LOG_DOMAIN,
///                        G_LOG_LEVEL_CRITICAL,
///                        &quot;assertion*acquired_context*failed&quot;);
/// g_main_context_push_thread_default (bad_context);
/// g_test_assert_expected_messages ();
/// ```
/// </para>
/// <para>
/// Note that you cannot use this to test [func@GLib.error] messages, since
/// [func@GLib.error] intentionally never returns even if the program doesn’t
/// abort; use [func@GLib.test_trap_subprocess] in this case.
/// </para>
/// <para>
/// If messages at [flags@GLib.LogLevelFlags.LEVEL_DEBUG] are emitted, but not explicitly
/// expected via [func@GLib.test_expect_message] then they will be ignored.
/// </para>
/// </summary>

/// <param name="log_domain">
/// the log domain of the message
/// </param>
/// <param name="log_level">
/// the log level of the message
/// </param>
/// <param name="pattern">
/// a glob-style pattern (see [type@GLib.PatternSpec])
/// </param>

	public static void TestExpectMessage(string log_domain, MentorLake.GLib.GLogLevelFlags log_level, string pattern)
	{
		GLibGlobalFunctionsExterns.g_test_expect_message(log_domain, log_level, pattern);
	}

/// <summary>
/// <para>
/// Indicates that a test failed.
/// </para>
/// <para>
/// This function can be called multiple times from the same test.
/// You can use this function if your test failed in a recoverable way.
/// </para>
/// <para>
/// Do not use this function if the failure of a test could cause
/// other tests to malfunction.
/// </para>
/// <para>
/// Calling this function will not stop the test from running, you
/// need to return from the test function yourself. So you can
/// produce additional diagnostic messages or even continue running
/// the test.
/// </para>
/// <para>
/// If not called from inside a test, this function does nothing.
/// </para>
/// <para>
/// Note that unlike [func@GLib.test_skip] and [func@GLib.test_incomplete],
/// this function does not log a message alongside the test failure.
/// If details of the test failure are available, either log them with
/// [func@GLib.test_message] before [func@GLib.test_fail], or use
/// [func@GLib.test_fail_printf] instead.
/// </para>
/// </summary>


	public static void TestFail()
	{
		GLibGlobalFunctionsExterns.g_test_fail();
	}

/// <summary>
/// <para>
/// Indicates that a test failed and records a message.
/// </para>
/// <para>
/// Also see [func@GLib.test_fail].
/// </para>
/// <para>
/// The message is formatted as if by [func@GLib.strdup_printf].
/// </para>
/// </summary>

/// <param name="format">
/// the format string
/// </param>
/// <param name="@__arglist">
/// printf-like arguments to @format
/// </param>

	public static void TestFailPrintf(string format, IntPtr @__arglist)
	{
		GLibGlobalFunctionsExterns.g_test_fail_printf(format, @__arglist);
	}

/// <summary>
/// <para>
/// Returns whether a test has already failed.
/// </para>
/// <para>
/// This will be the case when [func@GLib.test_fail],
/// [func@GLib.test_incomplete] or [func@GLib.test_skip] have
/// been called, but also if an assertion has failed.
/// </para>
/// <para>
/// This can be useful to return early from a test if
/// continuing after a failed assertion might be harmful.
/// </para>
/// <para>
/// The return value of this function is only meaningful
/// if it is called from inside a test function.
/// </para>
/// </summary>

/// <return>
/// true if the test has failed
/// </return>

	public static bool TestFailed()
	{
		return GLibGlobalFunctionsExterns.g_test_failed();
	}

/// <summary>
/// <para>
/// Gets the pathname of the directory containing test files of the type
/// specified by @file_type.
/// </para>
/// <para>
/// This is approximately the same as calling `g_test_build_filename(&quot;.&quot;)`,
/// but you don&apos;t need to free the return value.
/// </para>
/// </summary>

/// <param name="file_type">
/// the type of file (built vs. distributed)
/// </param>
/// <return>
/// the path of the directory, owned by GLib
/// </return>

	public static string TestGetDir(MentorLake.GLib.GTestFileType file_type)
	{
		return GLibGlobalFunctionsExterns.g_test_get_dir(file_type);
	}

/// <summary>
/// <para>
/// Gets the pathname to a data file that is required for a test.
/// </para>
/// <para>
/// This is the same as [func@GLib.test_build_filename] with two differences.
/// The first difference is that you must only use this function from within
/// a testcase function. The second difference is that you need not free
/// the return value — it will be automatically freed when the testcase
/// finishes running.
/// </para>
/// <para>
/// It is safe to use this function from a thread inside of a testcase
/// but you must ensure that all such uses occur before the main testcase
/// function returns (ie: it is best to ensure that all threads have been
/// joined).
/// </para>
/// </summary>

/// <param name="file_type">
/// the type of file (built vs. distributed)
/// </param>
/// <param name="first_path">
/// the first segment of the pathname
/// </param>
/// <param name="@__arglist">
/// `NULL`-terminated additional path segments
/// </param>
/// <return>
/// the path, automatically freed at the end of the testcase
/// </return>

	public static string TestGetFilename(MentorLake.GLib.GTestFileType file_type, string first_path, IntPtr @__arglist)
	{
		return GLibGlobalFunctionsExterns.g_test_get_filename(file_type, first_path, @__arglist);
	}

/// <summary>
/// <para>
/// Gets the test path for the test currently being run.
/// </para>
/// <para>
/// In essence, it will be the same string passed as the first argument
/// to e.g. [func@GLib.test_add] when the test was added.
/// </para>
/// <para>
/// This function returns a valid string only within a test function.
/// </para>
/// <para>
/// Note that this is a test path, not a file system path.
/// </para>
/// </summary>

/// <return>
/// the test path for the test currently being run
/// </return>

	public static string TestGetPath()
	{
		return GLibGlobalFunctionsExterns.g_test_get_path();
	}

/// <summary>
/// <para>
/// Gets the toplevel test suite for the test path API.
/// </para>
/// </summary>

/// <return>
/// the toplevel test suite
/// </return>

	public static MentorLake.GLib.GTestSuiteHandle TestGetRoot()
	{
		return GLibGlobalFunctionsExterns.g_test_get_root();
	}

/// <summary>
/// <para>
/// Indicates that a test failed because of some incomplete
/// functionality.
/// </para>
/// <para>
/// This function can be called multiple times from the same test.
/// </para>
/// <para>
/// Calling this function will not stop the test from running, you
/// need to return from the test function yourself. So you can
/// produce additional diagnostic messages or even continue running
/// the test.
/// </para>
/// <para>
/// If not called from inside a test, this function does nothing.
/// </para>
/// </summary>

/// <param name="msg">
/// explanation
/// </param>

	public static void TestIncomplete(string msg)
	{
		GLibGlobalFunctionsExterns.g_test_incomplete(msg);
	}

/// <summary>
/// <para>
/// Indicates that a test failed because of some incomplete
/// functionality.
/// </para>
/// <para>
/// Equivalent to [func@GLib.test_incomplete], but the explanation
/// is formatted as if by [func@GLib.strdup_printf].
/// </para>
/// </summary>

/// <param name="format">
/// the format string
/// </param>
/// <param name="@__arglist">
/// printf-like arguments to @format
/// </param>

	public static void TestIncompletePrintf(string format, IntPtr @__arglist)
	{
		GLibGlobalFunctionsExterns.g_test_incomplete_printf(format, @__arglist);
	}

/// <summary>
/// <para>
/// Initializes the GLib testing framework.
/// </para>
/// <para>
/// This includes seeding the test random number generator,
/// setting the program name, and parsing test-related commandline args.
/// </para>
/// <para>
/// This should be called before calling any other `g_test_*()` functions.
/// </para>
/// <para>
/// The following arguments are understood:
/// </para>
/// <para>
/// - `-l`: List test cases available in a test executable.
/// - `--seed=SEED`: Provide a random seed to reproduce test
///   runs using random numbers.
/// - `--verbose`: Run tests verbosely.
/// - `-q`, `--quiet`: Run tests quietly.
/// - `-p PATH`: Execute all tests matching the given path.
/// - `-s PATH`: Skip all tests matching the given path.
///   This can also be used to force a test to run that would otherwise
///   be skipped (ie, a test whose name contains &quot;/subprocess&quot;).
/// - `-m {perf|slow|thorough|quick|undefined|no-undefined}`: Execute tests according
///   to these test modes:
/// </para>
/// <para>
///   `perf`: Performance tests, may take long and report results (off by default).
/// </para>
/// <para>
///   `slow`, `thorough`: Slow and thorough tests, may take quite long and maximize
///   coverage (off by default).
/// </para>
/// <para>
///   `quick`: Quick tests, should run really quickly and give good coverage (the default).
/// </para>
/// <para>
///   `undefined`: Tests for undefined behaviour, may provoke programming errors
///   under [func@GLib.test_trap_subprocess] or [func@GLib.test_expect_message]
///   to check that appropriate assertions or warnings are given (the default).
/// </para>
/// <para>
///   `no-undefined`: Avoid tests for undefined behaviour.
/// </para>
/// <para>
/// - `--debug-log`: Debug test logging output.
/// </para>
/// <para>
/// Any parsed arguments are removed from @argv, and @argc is adjust accordingly.
/// </para>
/// <para>
/// The following options are supported:
/// </para>
/// <para>
/// - `G_TEST_OPTION_NO_PRGNAME`: Causes g_test_init() to not call
///   [func@GLib.set_prgname]. Since. 2.84
/// - `G_TEST_OPTION_ISOLATE_DIRS`: Creates a unique temporary directory for each
///   unit test and sets XDG directories to point there for the duration of the unit
///   test. See [const@GLib.TEST_OPTION_ISOLATE_DIRS].
/// - `G_TEST_OPTION_NONFATAL_ASSERTIONS`: This has the same effect as
///   [func@GLib.test_set_nonfatal_assertions]. Since 2.84
/// </para>
/// <para>
/// Since 2.58, if tests are compiled with `G_DISABLE_ASSERT` defined, `g_test_init()`
/// will print an error and exit. This is to prevent no-op tests from being executed,
/// as [func@GLib.assert] is commonly (erroneously) used in unit tests, and is a no-op
/// when compiled with `G_DISABLE_ASSERT`. Ensure your tests are compiled without
/// `G_DISABLE_ASSERT` defined.
/// </para>
/// </summary>

/// <param name="argc">
/// address of the @argc parameter of `main()`
/// </param>
/// <param name="argv">
/// address of the @argv parameter of `main()`
/// </param>
/// <param name="@__arglist">
/// `NULL`-terminated list of special options
/// </param>

	public static void TestInit(int argc, string argv, IntPtr @__arglist)
	{
		GLibGlobalFunctionsExterns.g_test_init(argc, argv, @__arglist);
	}

/// <summary>
/// <para>
/// Installs a non-error fatal log handler which can be
/// used to decide whether log messages which are counted
/// as fatal abort the program.
/// </para>
/// <para>
/// The use case here is that you are running a test case
/// that depends on particular libraries or circumstances
/// and cannot prevent certain known critical or warning
/// messages. So you install a handler that compares the
/// domain and message to precisely not abort in such a case.
/// </para>
/// <para>
/// Note that the handler is reset at the beginning of
/// any test case, so you have to set it inside each test
/// function which needs the special behavior.
/// </para>
/// <para>
/// This handler has no effect on g_error messages.
/// </para>
/// <para>
/// This handler also has no effect on structured log messages (using
/// [func@GLib.log_structured] or [func@GLib.log_structured_array]). To change the fatal
/// behaviour for specific log messages, programs must install a custom log
/// writer function using [func@GLib.log_set_writer_func].See
/// [Using Structured Logging](logging.html#using-structured-logging).
/// </para>
/// </summary>

/// <param name="log_func">
/// the log handler function.
/// </param>
/// <param name="user_data">
/// data passed to the log handler.
/// </param>

	public static void TestLogSetFatalHandler(MentorLake.GLib.GTestLogFatalFunc log_func, IntPtr user_data)
	{
		GLibGlobalFunctionsExterns.g_test_log_set_fatal_handler(log_func, user_data);
	}


/// <param name="log_type">
/// </param>

	public static string TestLogTypeName(MentorLake.GLib.GTestLogType log_type)
	{
		return GLibGlobalFunctionsExterns.g_test_log_type_name(log_type);
	}

/// <summary>
/// <para>
/// Reports the result of a performance or measurement test.
/// </para>
/// <para>
/// The test should generally strive to maximize the reported
/// quantities (larger values are better than smaller ones),
/// this and @maximized_quantity can determine sorting
/// order for test result reports.
/// </para>
/// </summary>

/// <param name="maximized_quantity">
/// the reported value
/// </param>
/// <param name="format">
/// the format string of the report message
/// </param>
/// <param name="@__arglist">
/// printf-like arguments to @format
/// </param>

	public static void TestMaximizedResult(double maximized_quantity, string format, IntPtr @__arglist)
	{
		GLibGlobalFunctionsExterns.g_test_maximized_result(maximized_quantity, format, @__arglist);
	}

/// <summary>
/// <para>
/// Adds a message to the test report.
/// </para>
/// </summary>

/// <param name="format">
/// the format string
/// </param>
/// <param name="@__arglist">
/// printf-like arguments to @format
/// </param>

	public static void TestMessage(string format, IntPtr @__arglist)
	{
		GLibGlobalFunctionsExterns.g_test_message(format, @__arglist);
	}

/// <summary>
/// <para>
/// Reports the result of a performance or measurement test.
/// </para>
/// <para>
/// The test should generally strive to minimize the reported
/// quantities (smaller values are better than larger ones),
/// this and @minimized_quantity can determine sorting
/// order for test result reports.
/// </para>
/// </summary>

/// <param name="minimized_quantity">
/// the reported value
/// </param>
/// <param name="format">
/// the format string of the report message
/// </param>
/// <param name="@__arglist">
/// printf-like arguments to @format
/// </param>

	public static void TestMinimizedResult(double minimized_quantity, string format, IntPtr @__arglist)
	{
		GLibGlobalFunctionsExterns.g_test_minimized_result(minimized_quantity, format, @__arglist);
	}

/// <summary>
/// <para>
/// Enqueues a callback @destroy_func to be executed during the next test case
/// teardown phase.
/// </para>
/// <para>
/// This is most useful to auto destroy allocated test resources at the end
/// of a test run. Resources are released in reverse queue order, that means
/// enqueueing callback `A` before callback `B` will cause `B()` to be called
/// before `A()` during teardown.
/// </para>
/// </summary>

/// <param name="destroy_func">
/// destroy callback for teardown phase
/// </param>
/// <param name="destroy_data">
/// destroy callback data
/// </param>

	public static void TestQueueDestroy(MentorLake.GLib.GDestroyNotify destroy_func, IntPtr destroy_data)
	{
		GLibGlobalFunctionsExterns.g_test_queue_destroy(destroy_func, destroy_data);
	}

/// <summary>
/// <para>
/// Enqueues a pointer to be released with [func@GLib.free]
/// during the next teardown phase.
/// </para>
/// <para>
/// This is equivalent to calling [func@GLib.test_queue_destroy]
/// with a destroy callback of [func@GLib.free].
/// </para>
/// </summary>

/// <param name="gfree_pointer">
/// the pointer to be stored
/// </param>

	public static void TestQueueFree(IntPtr gfree_pointer)
	{
		GLibGlobalFunctionsExterns.g_test_queue_free(gfree_pointer);
	}

/// <summary>
/// <para>
/// Gets a reproducible random floating point number.
/// </para>
/// <para>
/// See [func@GLib.test_rand_int] for details on test case random numbers.
/// </para>
/// </summary>

/// <return>
/// a random number from the seeded random number generator
/// </return>

	public static double TestRandDouble()
	{
		return GLibGlobalFunctionsExterns.g_test_rand_double();
	}

/// <summary>
/// <para>
/// Gets a reproducible random floating point number out of a specified range.
/// </para>
/// <para>
/// See [func@GLib.test_rand_int] for details on test case random numbers.
/// </para>
/// </summary>

/// <param name="range_start">
/// the minimum value returned by this function
/// </param>
/// <param name="range_end">
/// the minimum value not returned by this function
/// </param>
/// <return>
/// a number with @range_start &amp;lt;= number &amp;lt; @range_end
/// </return>

	public static double TestRandDoubleRange(double range_start, double range_end)
	{
		return GLibGlobalFunctionsExterns.g_test_rand_double_range(range_start, range_end);
	}

/// <summary>
/// <para>
/// Gets a reproducible random integer number.
/// </para>
/// <para>
/// The random numbers generated by the g_test_rand_*() family of functions
/// change with every new test program start, unless the --seed option is
/// given when starting test programs.
/// </para>
/// <para>
/// For individual test cases however, the random number generator is
/// reseeded, to avoid dependencies between tests and to make --seed
/// effective for all test cases.
/// </para>
/// </summary>

/// <return>
/// a random number from the seeded random number generator
/// </return>

	public static int TestRandInt()
	{
		return GLibGlobalFunctionsExterns.g_test_rand_int();
	}

/// <summary>
/// <para>
/// Gets a reproducible random integer number out of a specified range.
/// </para>
/// <para>
/// See [func@GLib.test_rand_int] for details on test case random numbers.
/// </para>
/// </summary>

/// <param name="begin">
/// the minimum value returned by this function
/// </param>
/// <param name="end">
/// the smallest value not to be returned by this function
/// </param>
/// <return>
/// a number with @begin &amp;lt;= number &amp;lt; @end
/// </return>

	public static int TestRandIntRange(int begin, int end)
	{
		return GLibGlobalFunctionsExterns.g_test_rand_int_range(begin, end);
	}

/// <summary>
/// <para>
/// Runs all tests under the toplevel suite.
/// </para>
/// <para>
/// The toplevel suite can be retrieved with [func@GLib.test_get_root].
/// </para>
/// <para>
/// Similar to [func@GLib.test_run_suite], the test cases to be run are
/// filtered according to test path arguments (`-p testpath` and `-s testpath`)
/// as parsed by [func@GLib.test_init]. [func@GLib.test_run_suite] or
/// [func@GLib.test_run] may only be called once in a program.
/// </para>
/// <para>
/// In general, the tests and sub-suites within each suite are run in
/// the order in which they are defined. However, note that prior to
/// GLib 2.36, there was a bug in the `g_test_add_*`
/// functions which caused them to create multiple suites with the same
/// name, meaning that if you created tests &quot;/foo/simple&quot;,
/// &quot;/bar/simple&quot;, and &quot;/foo/using-bar&quot; in that order, they would get
/// run in that order (since [func@GLib.test_run] would run the first &quot;/foo&quot;
/// suite, then the &quot;/bar&quot; suite, then the second &quot;/foo&quot; suite). As of
/// 2.36, this bug is fixed, and adding the tests in that order would
/// result in a running order of &quot;/foo/simple&quot;, &quot;/foo/using-bar&quot;,
/// &quot;/bar/simple&quot;. If this new ordering is sub-optimal (because it puts
/// more-complicated tests before simpler ones, making it harder to
/// figure out exactly what has failed), you can fix it by changing the
/// test paths to group tests by suite in a way that will result in the
/// desired running order. Eg, &quot;/simple/foo&quot;, &quot;/simple/bar&quot;,
/// &quot;/complex/foo-using-bar&quot;.
/// </para>
/// <para>
/// However, you should never make the actual result of a test depend
/// on the order that tests are run in. If you need to ensure that some
/// particular code runs before or after a given test case, use
/// [func@GLib.test_add], which lets you specify setup and teardown functions.
/// </para>
/// <para>
/// If all tests are skipped or marked as incomplete (expected failures),
/// this function will return 0 if producing TAP output, or 77 (treated
/// as &quot;skip test&quot; by Automake) otherwise.
/// </para>
/// </summary>

/// <return>
/// 0 on success, 1 on failure (assuming it returns at all),
///   0 or 77 if all tests were skipped or marked as incomplete
/// </return>

	public static int TestRun()
	{
		return GLibGlobalFunctionsExterns.g_test_run();
	}

/// <summary>
/// <para>
/// Executes the tests within @suite and all nested test suites.
/// </para>
/// <para>
/// The test suites to be executed are filtered according to
/// test path arguments (`-p testpath` and `-s testpath`) as parsed by
/// [func@GLib.test_init]. See the [func@GLib.test_run] documentation
/// for more information on the order that tests are run in.
/// </para>
/// <para>
/// [func@GLib.test_run_suite] or [func@GLib.test_run] may only be
/// called once in a program.
/// </para>
/// </summary>

/// <param name="suite">
/// a test suite
/// </param>
/// <return>
/// 0 on success
/// </return>

	public static int TestRunSuite(MentorLake.GLib.GTestSuiteHandle suite)
	{
		return GLibGlobalFunctionsExterns.g_test_run_suite(suite);
	}

/// <summary>
/// <para>
/// Changes the behaviour of the various assertion macros.
/// </para>
/// <para>
/// The `g_assert_*()` macros, `g_test_assert_expected_messages()`
/// and the various `g_test_trap_assert_*()` macros are changed
/// to not abort to program.
/// </para>
/// <para>
/// Instead, they will call [func@GLib.test_fail] and continue.
/// (This also changes the behavior of [func@GLib.test_fail] so that
/// it will not cause the test program to abort after completing
/// the failed test.)
/// </para>
/// <para>
/// Note that the [func@GLib.assert_not_reached] and [func@GLib.assert]
/// macros are not affected by this.
/// </para>
/// <para>
/// This function can only be called after [func@GLib.test_init].
/// </para>
/// </summary>


	public static void TestSetNonfatalAssertions()
	{
		GLibGlobalFunctionsExterns.g_test_set_nonfatal_assertions();
	}

/// <summary>
/// <para>
/// Indicates that a test was skipped.
/// </para>
/// <para>
/// Calling this function will not stop the test from running, you
/// need to return from the test function yourself. So you can
/// produce additional diagnostic messages or even continue running
/// the test.
/// </para>
/// <para>
/// If not called from inside a test, this function does nothing.
/// </para>
/// </summary>

/// <param name="msg">
/// explanation
/// </param>

	public static void TestSkip(string msg)
	{
		GLibGlobalFunctionsExterns.g_test_skip(msg);
	}

/// <summary>
/// <para>
/// Indicates that a test was skipped.
/// </para>
/// <para>
/// Equivalent to [func@GLib.test_skip], but the explanation
/// is formatted as if by [func@GLib.strdup_printf].
/// </para>
/// </summary>

/// <param name="format">
/// the format string
/// </param>
/// <param name="@__arglist">
/// printf-like arguments to @format
/// </param>

	public static void TestSkipPrintf(string format, IntPtr @__arglist)
	{
		GLibGlobalFunctionsExterns.g_test_skip_printf(format, @__arglist);
	}

/// <summary>
/// <para>
/// Returns true if the test program is running under [func@GLib.test_trap_subprocess].
/// </para>
/// </summary>

/// <return>
/// true if the test program is running under [func@GLib.test_trap_subprocess]
/// </return>

	public static bool TestSubprocess()
	{
		return GLibGlobalFunctionsExterns.g_test_subprocess();
	}

/// <summary>
/// <para>
/// Sets the summary for a test.
/// </para>
/// <para>
/// This may be included in test report output, and is useful documentation for
/// anyone reading the source code or modifying a test in future. It must be a
/// single line, and it should summarise what the test checks, and how.
/// </para>
/// <para>
/// This should be called at the top of a test function.
/// </para>
/// <para>
/// For example:
/// </para>
/// <para>
/// ```c
/// static void
/// test_array_sort (void)
/// {
///   g_test_summary (&quot;Test my_array_sort() sorts the array correctly and stably, &quot;
///                   &quot;including testing zero length and one-element arrays.&quot;);
/// </para>
/// <para>
///   // ...
/// }
/// ```
/// </para>
/// <para>
/// See also [func@GLib.test_bug].
/// </para>
/// </summary>

/// <param name="summary">
/// summary of the test purpose
/// </param>

	public static void TestSummary(string summary)
	{
		GLibGlobalFunctionsExterns.g_test_summary(summary);
	}

/// <summary>
/// <para>
/// Gets the number of seconds since the last start of the timer with
/// [func@GLib.test_timer_start].
/// </para>
/// </summary>

/// <return>
/// the time since the last start of the timer in seconds
/// </return>

	public static double TestTimerElapsed()
	{
		return GLibGlobalFunctionsExterns.g_test_timer_elapsed();
	}

/// <summary>
/// <para>
/// Reports the last result of [func@GLib.test_timer_elapsed].
/// </para>
/// </summary>

/// <return>
/// the last result of [func@GLib.test_timer_elapsed]
/// </return>

	public static double TestTimerLast()
	{
		return GLibGlobalFunctionsExterns.g_test_timer_last();
	}

/// <summary>
/// <para>
/// Starts a timing test.
/// </para>
/// <para>
/// Call [func@GLib.test_timer_elapsed] when the task is supposed
/// to be done. Call this function again to restart the timer.
/// </para>
/// </summary>


	public static void TestTimerStart()
	{
		GLibGlobalFunctionsExterns.g_test_timer_start();
	}


/// <param name="domain">
/// </param>
/// <param name="file">
/// </param>
/// <param name="line">
/// </param>
/// <param name="func">
/// </param>
/// <param name="assertion_flags">
/// </param>
/// <param name="pattern">
/// </param>

	public static void TestTrapAssertions(string domain, string file, int line, string func, ulong assertion_flags, string pattern)
	{
		GLibGlobalFunctionsExterns.g_test_trap_assertions(domain, file, line, func, assertion_flags, pattern);
	}

/// <summary>
/// <para>
/// Forks the current test program to execute a test case that might
/// not return or that might abort.
/// </para>
/// <para>
/// If @usec_timeout is non-0, the forked test case is aborted and
/// considered failing if its run time exceeds it.
/// </para>
/// <para>
/// The forking behavior can be configured with [flags@GLib.TestTrapFlags]
/// flags.
/// </para>
/// <para>
/// In the following example, the test code forks, the forked child
/// process produces some sample output and exits successfully.
/// The forking parent process then asserts successful child program
/// termination and validates child program outputs.
/// </para>
/// <para>
/// ```c
///   static void
///   test_fork_patterns (void)
///   {
///     if (g_test_trap_fork (0, G_TEST_TRAP_SILENCE_STDOUT | G_TEST_TRAP_SILENCE_STDERR))
///       {
///         g_print (&quot;some stdout text: somagic17
/// &quot;);
///         g_printerr (&quot;some stderr text: semagic43
/// &quot;);
///         exit (0); // successful test run
///       }
///     g_test_trap_assert_passed ();
///     g_test_trap_assert_stdout (&quot;*somagic17*&quot;);
///     g_test_trap_assert_stderr (&quot;*semagic43*&quot;);
///   }
/// ```
/// </para>
/// </summary>

/// <param name="usec_timeout">
/// timeout for the forked test in microseconds
/// </param>
/// <param name="test_trap_flags">
/// flags to modify forking behaviour
/// </param>
/// <return>
/// true for the forked child and false for the executing parent process.
/// </return>

	public static bool TestTrapFork(ulong usec_timeout, MentorLake.GLib.GTestTrapFlags test_trap_flags)
	{
		return GLibGlobalFunctionsExterns.g_test_trap_fork(usec_timeout, test_trap_flags);
	}

/// <summary>
/// <para>
/// Checks the result of the last [func@GLib.test_trap_subprocess] call.
/// </para>
/// </summary>

/// <return>
/// true if the last test subprocess terminated successfully
/// </return>

	public static bool TestTrapHasPassed()
	{
		return GLibGlobalFunctionsExterns.g_test_trap_has_passed();
	}

/// <summary>
/// <para>
/// Checks the result of the last [func@GLib.test_trap_subprocess] call.
/// </para>
/// </summary>

/// <return>
/// true if the last test subprocess got killed due to a timeout
/// </return>

	public static bool TestTrapReachedTimeout()
	{
		return GLibGlobalFunctionsExterns.g_test_trap_reached_timeout();
	}

/// <summary>
/// <para>
/// Respawns the test program to run only @test_path in a subprocess.
/// </para>
/// <para>
/// This is equivalent to calling [func@GLib.test_trap_subprocess_with_envp]
/// with `envp` set to `NULL`. See the documentation for that function
/// for full details.
/// </para>
/// </summary>

/// <param name="test_path">
/// test to run in a subprocess
/// </param>
/// <param name="usec_timeout">
/// timeout for the subprocess test in microseconds.
/// </param>
/// <param name="test_flags">
/// flags to modify subprocess behaviour
/// </param>

	public static void TestTrapSubprocess(string test_path, ulong usec_timeout, MentorLake.GLib.GTestSubprocessFlags test_flags)
	{
		GLibGlobalFunctionsExterns.g_test_trap_subprocess(test_path, usec_timeout, test_flags);
	}

/// <summary>
/// <para>
/// Respawns the test program to run only @test_path in a subprocess with
/// a given environment.
/// </para>
/// <para>
/// This can be used for a test case that might not return, or that
/// might abort.
/// </para>
/// <para>
/// If @test_path is `NULL` then the same test is re-run in a subprocess.
/// You can use [func@GLib.test_subprocess] to determine whether the test
/// is in a subprocess or not.
/// </para>
/// <para>
/// @test_path can also be the name of the parent test, followed by
/// &quot;`/subprocess/`&quot; and then a name for the specific subtest (or just
/// ending with &quot;`/subprocess`&quot; if the test only has one child test);
/// tests with names of this form will automatically be skipped in the
/// parent process.
/// </para>
/// <para>
/// If @envp is `NULL`, the parent process’ environment will be inherited.
/// </para>
/// <para>
/// If @usec_timeout is non-0, the test subprocess is aborted and
/// considered failing if its run time exceeds it.
/// </para>
/// <para>
/// The subprocess behavior can be configured with [flags@GLib.TestSubprocessFlags]
/// flags.
/// </para>
/// <para>
/// You can use methods such as [func@GLib.test_trap_assert_passed],
/// [func@GLib.test_trap_assert_failed], and [func@GLib.test_trap_assert_stderr] to
/// check the results of the subprocess. (But note that
/// [func@GLib.test_trap_assert_stdout] and [func@GLib.test_trap_assert_stderr]
/// cannot be used if @test_flags specifies that the child should
/// inherit the parent stdout/stderr.)
/// </para>
/// <para>
/// If your `main ()` needs to behave differently in the subprocess, you can
/// call [func@GLib.test_subprocess] (after calling [func@GLib.test_init])
/// to see whether you are in a subprocess.
/// </para>
/// <para>
/// Internally, this function tracks the child process using
/// [func@GLib.child_watch_source_new], so your process must not ignore
/// `SIGCHLD`, and must not attempt to watch or wait for the child process
/// via another mechanism.
/// </para>
/// <para>
/// The following example tests that calling `my_object_new(1000000)` will
/// abort with an error message.
/// </para>
/// <para>
/// ```c
///   static void
///   test_create_large_object (void)
///   {
///     if (g_test_subprocess ())
///       {
///         my_object_new (1000000);
///         return;
///       }
/// </para>
/// <para>
///     // Reruns this same test in a subprocess
///     g_test_trap_subprocess (NULL, 0, G_TEST_SUBPROCESS_DEFAULT);
///     g_test_trap_assert_failed ();
///     g_test_trap_assert_stderr (&quot;*ERROR*too large*&quot;);
///   }
/// </para>
/// <para>
///   static void
///   test_different_username (void)
///   {
///     if (g_test_subprocess ())
///       {
///         // Code under test goes here
///         g_message (&quot;Username is now simulated as %s&quot;, g_getenv (&quot;USER&quot;));
///         return;
///       }
/// </para>
/// <para>
///     // Reruns this same test in a subprocess
///     g_autoptr(GStrv) envp = g_get_environ ();
///     envp = g_environ_setenv (g_steal_pointer (&amp;envp), &quot;USER&quot;, &quot;charlie&quot;, TRUE);
///     g_test_trap_subprocess_with_envp (NULL, envp, 0, G_TEST_SUBPROCESS_DEFAULT);
///     g_test_trap_assert_passed ();
///     g_test_trap_assert_stdout (&quot;Username is now simulated as charlie&quot;);
///   }
/// </para>
/// <para>
///   int
///   main (int argc, char **argv)
///   {
///     g_test_init (&amp;argc, &amp;argv, NULL);
/// </para>
/// <para>
///     g_test_add_func (&quot;/myobject/create-large-object&quot;,
///                      test_create_large_object);
///     g_test_add_func (&quot;/myobject/different-username&quot;,
///                      test_different_username);
///     return g_test_run ();
///   }
/// ```
/// </para>
/// </summary>

/// <param name="test_path">
/// test to run in a subprocess
/// </param>
/// <param name="envp">
/// environment
///   to run the test in
/// </param>
/// <param name="usec_timeout">
/// timeout for the subprocess test in microseconds
/// </param>
/// <param name="test_flags">
/// flags to modify subprocess behaviour
/// </param>

	public static void TestTrapSubprocessWithEnvp(string test_path, string[] envp, ulong usec_timeout, MentorLake.GLib.GTestSubprocessFlags test_flags)
	{
		GLibGlobalFunctionsExterns.g_test_trap_subprocess_with_envp(test_path, envp, usec_timeout, test_flags);
	}

/// <summary>
/// <para>
/// This function creates a new thread.
/// </para>
/// <para>
/// The new thread executes the function @func with the argument @data.
/// If the thread was created successfully, it is returned.
/// </para>
/// <para>
/// @error can be %NULL to ignore errors, or non-%NULL to report errors.
/// The error is set, if and only if the function returns %NULL.
/// </para>
/// <para>
/// This function returns a reference to the created thread only if
/// @joinable is %TRUE.  In that case, you must free this reference by
/// calling g_thread_unref() or g_thread_join().  If @joinable is %FALSE
/// then you should probably not touch the return value.
/// </para>
/// </summary>

/// <param name="func">
/// a function to execute in the new thread
/// </param>
/// <param name="data">
/// an argument to supply to the new thread
/// </param>
/// <param name="joinable">
/// should this thread be joinable?
/// </param>
/// <return>
/// the new #GThread on success
/// </return>

	public static MentorLake.GLib.GThreadHandle ThreadCreate(MentorLake.GLib.GThreadFunc func, IntPtr data, bool joinable)
	{
		var externCallResult = GLibGlobalFunctionsExterns.g_thread_create(func, data, joinable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// This function creates a new thread.
/// </para>
/// </summary>

/// <param name="func">
/// a function to execute in the new thread.
/// </param>
/// <param name="data">
/// an argument to supply to the new thread.
/// </param>
/// <param name="stack_size">
/// a stack size for the new thread.
/// </param>
/// <param name="joinable">
/// should this thread be joinable?
/// </param>
/// <param name="bound">
/// ignored
/// </param>
/// <param name="priority">
/// ignored
/// </param>
/// <return>
/// the new #GThread on success.
/// </return>

	public static MentorLake.GLib.GThreadHandle ThreadCreateFull(MentorLake.GLib.GThreadFunc func, IntPtr data, ulong stack_size, bool joinable, bool bound, MentorLake.GLib.GThreadPriority priority)
	{
		var externCallResult = GLibGlobalFunctionsExterns.g_thread_create_full(func, data, stack_size, joinable, bound, priority, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}



	public static MentorLake.GLib.GQuark ThreadErrorQuark()
	{
		return GLibGlobalFunctionsExterns.g_thread_error_quark();
	}

/// <summary>
/// <para>
/// Terminates the current thread.
/// </para>
/// <para>
/// If another thread is waiting for us using g_thread_join() then the
/// waiting thread will be woken up and get @retval as the return value
/// of g_thread_join().
/// </para>
/// <para>
/// Calling g_thread_exit() with a parameter @retval is equivalent to
/// returning @retval from the function @func, as given to g_thread_new().
/// </para>
/// <para>
/// You must only call g_thread_exit() from a thread that you created
/// yourself with g_thread_new() or related APIs. You must not call
/// this function from a thread created with another threading library
/// or or from within a #GThreadPool.
/// </para>
/// </summary>

/// <param name="retval">
/// the return value of this thread
/// </param>

	public static void ThreadExit(IntPtr retval)
	{
		GLibGlobalFunctionsExterns.g_thread_exit(retval);
	}

/// <summary>
/// <para>
/// Call @thread_func on all #GThreads that have been
/// created with g_thread_create().
/// </para>
/// <para>
/// Note that threads may decide to exit while @thread_func is
/// running, so without intimate knowledge about the lifetime of
/// foreign threads, @thread_func shouldn&apos;t access the GThread*
/// pointer passed in as first argument. However, @thread_func will
/// not be called for threads which are known to have exited already.
/// </para>
/// <para>
/// Due to thread lifetime checks, this function has an execution complexity
/// which is quadratic in the number of existing threads.
/// </para>
/// </summary>

/// <param name="thread_func">
/// function to call for all #GThread structures
/// </param>
/// <param name="user_data">
/// second argument to @thread_func
/// </param>

	public static void ThreadForeach(MentorLake.GLib.GFunc thread_func, IntPtr user_data)
	{
		GLibGlobalFunctionsExterns.g_thread_foreach(thread_func, user_data);
	}

/// <summary>
/// <para>
/// Indicates if g_thread_init() has been called.
/// </para>
/// </summary>

/// <return>
/// %TRUE if threads have been initialized.
/// </return>

	public static bool ThreadGetInitialized()
	{
		return GLibGlobalFunctionsExterns.g_thread_get_initialized();
	}

/// <summary>
/// <para>
/// If you use GLib from more than one thread, you must initialize the
/// thread system by calling g_thread_init().
/// </para>
/// <para>
/// Since version 2.24, calling g_thread_init() multiple times is allowed,
/// but nothing happens except for the first call.
/// </para>
/// <para>
/// Since version 2.32, GLib does not support custom thread implementations
/// anymore and the @vtable parameter is ignored and you should pass %NULL.
/// </para>
/// <para>
/// ::: note
///     g_thread_init() must not be called directly or indirectly in a
///     callback from GLib. Also no mutexes may be currently locked
///     while calling g_thread_init().
/// </para>
/// <para>
/// ::: note
///     To use g_thread_init() in your program, you have to link with
///     the libraries that the command `pkg-config --libs gthread-2.0`
///     outputs. This is not the case for all the other thread-related
///     functions of GLib. Those can be used without having to link
///     with the thread libraries.
/// </para>
/// </summary>

/// <param name="vtable">
/// a function table of type #GThreadFunctions, that provides
///     the entry points to the thread system to be used. Since 2.32,
///     this parameter is ignored and should always be %NULL
/// </param>

	public static void ThreadInit(IntPtr vtable)
	{
		GLibGlobalFunctionsExterns.g_thread_init(vtable);
	}


/// <param name="vtable">
/// </param>

	public static void ThreadInitWithErrorcheckMutexes(IntPtr vtable)
	{
		GLibGlobalFunctionsExterns.g_thread_init_with_errorcheck_mutexes(vtable);
	}

/// <summary>
/// <para>
/// This function will return the maximum @interval that a
/// thread will wait in the thread pool for new tasks before
/// being stopped.
/// </para>
/// <para>
/// If this function returns 0, threads waiting in the thread
/// pool for new work are not stopped.
/// </para>
/// </summary>

/// <return>
/// the maximum @interval (milliseconds) to wait
///     for new tasks in the thread pool before stopping the
///     thread
/// </return>

	public static uint ThreadPoolGetMaxIdleTime()
	{
		return GLibGlobalFunctionsExterns.g_thread_pool_get_max_idle_time();
	}

/// <summary>
/// <para>
/// Returns the maximal allowed number of unused threads.
/// </para>
/// </summary>

/// <return>
/// the maximal number of unused threads
/// </return>

	public static int ThreadPoolGetMaxUnusedThreads()
	{
		return GLibGlobalFunctionsExterns.g_thread_pool_get_max_unused_threads();
	}

/// <summary>
/// <para>
/// Returns the number of currently unused threads.
/// </para>
/// </summary>

/// <return>
/// the number of currently unused threads
/// </return>

	public static uint ThreadPoolGetNumUnusedThreads()
	{
		return GLibGlobalFunctionsExterns.g_thread_pool_get_num_unused_threads();
	}

/// <summary>
/// <para>
/// This function will set the maximum @interval that a thread
/// waiting in the pool for new tasks can be idle for before
/// being stopped. This function is similar to calling
/// g_thread_pool_stop_unused_threads() on a regular timeout,
/// except this is done on a per thread basis.
/// </para>
/// <para>
/// By setting @interval to 0, idle threads will not be stopped.
/// </para>
/// <para>
/// The default value is 15000 (15 seconds).
/// </para>
/// </summary>

/// <param name="interval">
/// the maximum @interval (in milliseconds)
///     a thread can be idle
/// </param>

	public static void ThreadPoolSetMaxIdleTime(uint interval)
	{
		GLibGlobalFunctionsExterns.g_thread_pool_set_max_idle_time(interval);
	}

/// <summary>
/// <para>
/// Sets the maximal number of unused threads to @max_threads.
/// If @max_threads is -1, no limit is imposed on the number
/// of unused threads.
/// </para>
/// <para>
/// The default value is 8 since GLib 2.84. Previously the default value was 2.
/// </para>
/// </summary>

/// <param name="max_threads">
/// maximal number of unused threads
/// </param>

	public static void ThreadPoolSetMaxUnusedThreads(int max_threads)
	{
		GLibGlobalFunctionsExterns.g_thread_pool_set_max_unused_threads(max_threads);
	}

/// <summary>
/// <para>
/// Stops all currently unused threads. This does not change the
/// maximal number of unused threads. This function can be used to
/// regularly stop all unused threads e.g. from g_timeout_add().
/// </para>
/// </summary>


	public static void ThreadPoolStopUnusedThreads()
	{
		GLibGlobalFunctionsExterns.g_thread_pool_stop_unused_threads();
	}

/// <summary>
/// <para>
/// This function returns the #GThread corresponding to the
/// current thread. Note that this function does not increase
/// the reference count of the returned struct.
/// </para>
/// <para>
/// This function will return a #GThread even for threads that
/// were not created by GLib (i.e. those created by other threading
/// APIs). This may be useful for thread identification purposes
/// (i.e. comparisons) but you must not use GLib functions (such
/// as g_thread_join()) on these threads.
/// </para>
/// </summary>

/// <return>
/// the #GThread representing the current thread
/// </return>

	public static MentorLake.GLib.GThreadHandle ThreadSelf()
	{
		return GLibGlobalFunctionsExterns.g_thread_self();
	}

/// <summary>
/// <para>
/// Causes the calling thread to voluntarily relinquish the CPU, so
/// that other threads can run.
/// </para>
/// <para>
/// This function is often used as a method to make busy wait less evil.
/// </para>
/// </summary>


	public static void ThreadYield()
	{
		GLibGlobalFunctionsExterns.g_thread_yield();
	}

/// <summary>
/// <para>
/// Converts a string containing an ISO 8601 encoded date and time
/// to a #GTimeVal and puts it into @time_.
/// </para>
/// <para>
/// @iso_date must include year, month, day, hours, minutes, and
/// seconds. It can optionally include fractions of a second and a time
/// zone indicator. (In the absence of any time zone indication, the
/// timestamp is assumed to be in local time.)
/// </para>
/// <para>
/// Any leading or trailing space in @iso_date is ignored.
/// </para>
/// <para>
/// This function was deprecated, along with #GTimeVal itself, in GLib 2.62.
/// Equivalent functionality is available using code like:
/// <code>
/// GDateTime *dt = g_date_time_new_from_iso8601 (iso8601_string, NULL);
/// GDateTime *dt = g_date_time_new_from_iso8601 (iso8601_string, NULL);
/// gint64 time_val = g_date_time_to_unix (dt);
/// g_date_time_unref (dt);
/// </code>
/// </para>
/// </summary>

/// <param name="iso_date">
/// an ISO 8601 encoded date string
/// </param>
/// <param name="time_">
/// a #GTimeVal
/// </param>
/// <return>
/// %TRUE if the conversion was successful.
/// </return>

	public static bool TimeValFromIso8601(string iso_date, out MentorLake.GLib.GTimeVal time_)
	{
		return GLibGlobalFunctionsExterns.g_time_val_from_iso8601(iso_date, out time_);
	}

/// <summary>
/// <para>
/// Sets a function to be called at regular intervals, with the default
/// priority, [const@GLib.PRIORITY_DEFAULT].
/// </para>
/// <para>
/// The given @function is called repeatedly until it returns
/// [const@GLib.SOURCE_REMOVE] or %FALSE, at which point the timeout is
/// automatically destroyed and the function will not be called again. The first
/// call to the function will be at the end of the first @interval.
/// </para>
/// <para>
/// Note that timeout functions may be delayed, due to the processing of other
/// event sources. Thus they should not be relied on for precise timing.
/// After each call to the timeout function, the time of the next
/// timeout is recalculated based on the current time and the given interval
/// (it does not try to &apos;catch up&apos; time lost in delays).
/// </para>
/// <para>
/// See [mainloop memory management](main-loop.html#memory-management-of-sources) for details
/// on how to handle the return value and memory management of @data.
/// </para>
/// <para>
/// If you want to have a timer in the &quot;seconds&quot; range and do not care
/// about the exact time of the first call of the timer, use the
/// [func@GLib.timeout_add_seconds] function; this function allows for more
/// optimizations and more efficient system power usage.
/// </para>
/// <para>
/// This internally creates a main loop source using
/// [func@GLib.timeout_source_new] and attaches it to the global
/// [struct@GLib.MainContext] using [method@GLib.Source.attach], so the callback
/// will be invoked in whichever thread is running that main context. You can do
/// these steps manually if you need greater control or to use a custom main
/// context.
/// </para>
/// <para>
/// It is safe to call this function from any thread.
/// </para>
/// <para>
/// The interval given is in terms of monotonic time, not wall clock
/// time. See [func@GLib.get_monotonic_time].
/// </para>
/// </summary>

/// <param name="interval">
/// the time between calls to the function, in milliseconds
///    (1/1000ths of a second)
/// </param>
/// <param name="function">
/// function to call
/// </param>
/// <param name="data">
/// data to pass to @function
/// </param>
/// <return>
/// the ID (greater than 0) of the event source.
/// </return>

	public static uint TimeoutAdd(uint interval, MentorLake.GLib.GSourceFunc function, IntPtr data)
	{
		return GLibGlobalFunctionsExterns.g_timeout_add(interval, function, data);
	}

/// <summary>
/// <para>
/// Sets a function to be called at regular intervals, with the given
/// priority.  The function is called repeatedly until it returns
/// %FALSE, at which point the timeout is automatically destroyed and
/// the function will not be called again.  The @notify function is
/// called when the timeout is destroyed.  The first call to the
/// function will be at the end of the first @interval.
/// </para>
/// <para>
/// Note that timeout functions may be delayed, due to the processing of other
/// event sources. Thus they should not be relied on for precise timing.
/// After each call to the timeout function, the time of the next
/// timeout is recalculated based on the current time and the given interval
/// (it does not try to &apos;catch up&apos; time lost in delays).
/// </para>
/// <para>
/// See [mainloop memory management](main-loop.html#memory-management-of-sources) for details
/// on how to handle the return value and memory management of @data.
/// </para>
/// <para>
/// This internally creates a main loop source using
/// [func@GLib.timeout_source_new] and attaches it to the global
/// [struct@GLib.MainContext] using [method@GLib.Source.attach], so the callback
/// will be invoked in whichever thread is running that main context. You can do
/// these steps manually if you need greater control or to use a custom main
/// context.
/// </para>
/// <para>
/// The interval given is in terms of monotonic time, not wall clock time.
/// See [func@GLib.get_monotonic_time].
/// </para>
/// </summary>

/// <param name="priority">
/// the priority of the timeout source. Typically this will be in
///   the range between [const@GLib.PRIORITY_DEFAULT] and
///   [const@GLib.PRIORITY_HIGH].
/// </param>
/// <param name="interval">
/// the time between calls to the function, in milliseconds
///   (1/1000ths of a second)
/// </param>
/// <param name="function">
/// function to call
/// </param>
/// <param name="data">
/// data to pass to @function
/// </param>
/// <param name="notify">
/// function to call when the timeout is removed, or %NULL
/// </param>
/// <return>
/// the ID (greater than 0) of the event source.
/// </return>

	public static uint TimeoutAddFull(int priority, uint interval, MentorLake.GLib.GSourceFunc function, IntPtr data, MentorLake.GLib.GDestroyNotify notify)
	{
		return GLibGlobalFunctionsExterns.g_timeout_add_full(priority, interval, function, data, notify);
	}

/// <summary>
/// <para>
/// Sets a function to be called after @interval milliseconds have elapsed,
/// with the default priority, [const@GLib.PRIORITY_DEFAULT].
/// </para>
/// <para>
/// The given @function is called once and then the source will be automatically
/// removed from the main context.
/// </para>
/// <para>
/// This function otherwise behaves like [func@GLib.timeout_add].
/// </para>
/// </summary>

/// <param name="interval">
/// the time after which the function will be called, in
///   milliseconds (1/1000ths of a second)
/// </param>
/// <param name="function">
/// function to call
/// </param>
/// <param name="data">
/// data to pass to @function
/// </param>
/// <return>
/// the ID (greater than 0) of the event source
/// </return>

	public static uint TimeoutAddOnce(uint interval, MentorLake.GLib.GSourceOnceFunc function, IntPtr data)
	{
		return GLibGlobalFunctionsExterns.g_timeout_add_once(interval, function, data);
	}

/// <summary>
/// <para>
/// Sets a function to be called at regular intervals with the default
/// priority, [const@GLib.PRIORITY_DEFAULT].
/// </para>
/// <para>
/// The function is called repeatedly until it returns [const@GLib.SOURCE_REMOVE]
/// or %FALSE, at which point the timeout is automatically destroyed
/// and the function will not be called again.
/// </para>
/// <para>
/// This internally creates a main loop source using
/// [func@GLib.timeout_source_new_seconds] and attaches it to the main loop context
/// using [method@GLib.Source.attach]. You can do these steps manually if you need
/// greater control. Also see [func@GLib.timeout_add_seconds_full].
/// </para>
/// <para>
/// It is safe to call this function from any thread.
/// </para>
/// <para>
/// Note that the first call of the timer may not be precise for timeouts
/// of one second. If you need finer precision and have such a timeout,
/// you may want to use [func@GLib.timeout_add] instead.
/// </para>
/// <para>
/// See [mainloop memory management](main-loop.html#memory-management-of-sources) for details
/// on how to handle the return value and memory management of @data.
/// </para>
/// <para>
/// The interval given is in terms of monotonic time, not wall clock
/// time. See [func@GLib.get_monotonic_time].
/// </para>
/// </summary>

/// <param name="interval">
/// the time between calls to the function, in seconds
/// </param>
/// <param name="function">
/// function to call
/// </param>
/// <param name="data">
/// data to pass to @function
/// </param>
/// <return>
/// the ID (greater than 0) of the event source.
/// </return>

	public static uint TimeoutAddSeconds(uint interval, MentorLake.GLib.GSourceFunc function, IntPtr data)
	{
		return GLibGlobalFunctionsExterns.g_timeout_add_seconds(interval, function, data);
	}

/// <summary>
/// <para>
/// Sets a function to be called at regular intervals, with @priority.
/// </para>
/// <para>
/// The function is called repeatedly until it returns [const@GLib.SOURCE_REMOVE]
/// or %FALSE, at which point the timeout is automatically destroyed and
/// the function will not be called again.
/// </para>
/// <para>
/// Unlike [func@GLib.timeout_add], this function operates at whole second
/// granularity. The initial starting point of the timer is determined by the
/// implementation and the implementation is expected to group multiple timers
/// together so that they fire all at the same time. To allow this grouping, the
/// @interval to the first timer is rounded and can deviate up to one second
/// from the specified interval. Subsequent timer iterations will generally run
/// at the specified interval.
/// </para>
/// <para>
/// Note that timeout functions may be delayed, due to the processing of other
/// event sources. Thus they should not be relied on for precise timing.
/// After each call to the timeout function, the time of the next
/// timeout is recalculated based on the current time and the given @interval
/// </para>
/// <para>
/// See [mainloop memory management](main-loop.html#memory-management-of-sources) for details
/// on how to handle the return value and memory management of @data.
/// </para>
/// <para>
/// If you want timing more precise than whole seconds, use
/// [func@GLib.timeout_add] instead.
/// </para>
/// <para>
/// The grouping of timers to fire at the same time results in a more power
/// and CPU efficient behavior so if your timer is in multiples of seconds
/// and you don&apos;t require the first timer exactly one second from now, the
/// use of [func@GLib.timeout_add_seconds] is preferred over
/// [func@GLib.timeout_add].
/// </para>
/// <para>
/// This internally creates a main loop source using
/// [func@GLib.timeout_source_new_seconds] and attaches it to the main loop
/// context using [method@GLib.Source.attach]. You can do these steps manually
/// if you need greater control.
/// </para>
/// <para>
/// It is safe to call this function from any thread.
/// </para>
/// <para>
/// The interval given is in terms of monotonic time, not wall clock
/// time. See [func@GLib.get_monotonic_time].
/// </para>
/// </summary>

/// <param name="priority">
/// the priority of the timeout source. Typically this will be in
///   the range between [const@GLib.PRIORITY_DEFAULT] and
///   [const@GLib.PRIORITY_HIGH].
/// </param>
/// <param name="interval">
/// the time between calls to the function, in seconds
/// </param>
/// <param name="function">
/// function to call
/// </param>
/// <param name="data">
/// data to pass to @function
/// </param>
/// <param name="notify">
/// function to call when the timeout is removed, or %NULL
/// </param>
/// <return>
/// the ID (greater than 0) of the event source.
/// </return>

	public static uint TimeoutAddSecondsFull(int priority, uint interval, MentorLake.GLib.GSourceFunc function, IntPtr data, MentorLake.GLib.GDestroyNotify notify)
	{
		return GLibGlobalFunctionsExterns.g_timeout_add_seconds_full(priority, interval, function, data, notify);
	}

/// <summary>
/// <para>
/// This function behaves like [func@GLib.timeout_add_once] but with a range in
/// seconds.
/// </para>
/// </summary>

/// <param name="interval">
/// the time after which the function will be called, in seconds
/// </param>
/// <param name="function">
/// function to call
/// </param>
/// <param name="data">
/// data to pass to @function
/// </param>
/// <return>
/// the ID (greater than 0) of the event source
/// </return>

	public static uint TimeoutAddSecondsOnce(uint interval, MentorLake.GLib.GSourceOnceFunc function, IntPtr data)
	{
		return GLibGlobalFunctionsExterns.g_timeout_add_seconds_once(interval, function, data);
	}

/// <summary>
/// <para>
/// Creates a new timeout source.
/// </para>
/// <para>
/// The source will not initially be associated with any [struct@GLib.MainContext]
/// and must be added to one with [method@GLib.Source.attach] before it will be
/// executed.
/// </para>
/// <para>
/// The interval given is in terms of monotonic time, not wall clock
/// time.  See [func@GLib.get_monotonic_time].
/// </para>
/// </summary>

/// <param name="interval">
/// the timeout interval in milliseconds.
/// </param>
/// <return>
/// the newly-created timeout source
/// </return>

	public static MentorLake.GLib.GSourceHandle TimeoutSourceNew(uint interval)
	{
		return GLibGlobalFunctionsExterns.g_timeout_source_new(interval);
	}

/// <summary>
/// <para>
/// Creates a new timeout source.
/// </para>
/// <para>
/// The source will not initially be associated with any
/// [struct@GLib.MainContext] and must be added to one with
/// [method@GLib.Source.attach] before it will be executed.
/// </para>
/// <para>
/// The scheduling granularity/accuracy of this timeout source will be
/// in seconds.
/// </para>
/// <para>
/// The interval given is in terms of monotonic time, not wall clock time.
/// See [func@GLib.get_monotonic_time].
/// </para>
/// </summary>

/// <param name="interval">
/// the timeout interval in seconds
/// </param>
/// <return>
/// the newly-created timeout source
/// </return>

	public static MentorLake.GLib.GSourceHandle TimeoutSourceNewSeconds(uint interval)
	{
		return GLibGlobalFunctionsExterns.g_timeout_source_new_seconds(interval);
	}

/// <summary>
/// <para>
/// Returns the height of a #GTrashStack.
/// </para>
/// <para>
/// Note that execution of this function is of O(N) complexity
/// where N denotes the number of items on the stack.
/// </para>
/// </summary>

/// <param name="stack_p">
/// a #GTrashStack
/// </param>
/// <return>
/// the height of the stack
/// </return>

	public static uint TrashStackHeight(IntPtr stack_p)
	{
		return GLibGlobalFunctionsExterns.g_trash_stack_height(stack_p);
	}

/// <summary>
/// <para>
/// Returns the element at the top of a #GTrashStack
/// which may be %NULL.
/// </para>
/// </summary>

/// <param name="stack_p">
/// a #GTrashStack
/// </param>
/// <return>
/// the element at the top of the stack
/// </return>

	public static IntPtr TrashStackPeek(IntPtr stack_p)
	{
		return GLibGlobalFunctionsExterns.g_trash_stack_peek(stack_p);
	}

/// <summary>
/// <para>
/// Pops a piece of memory off a #GTrashStack.
/// </para>
/// </summary>

/// <param name="stack_p">
/// a #GTrashStack
/// </param>
/// <return>
/// the element at the top of the stack
/// </return>

	public static IntPtr TrashStackPop(IntPtr stack_p)
	{
		return GLibGlobalFunctionsExterns.g_trash_stack_pop(stack_p);
	}

/// <summary>
/// <para>
/// Pushes a piece of memory onto a #GTrashStack.
/// </para>
/// </summary>

/// <param name="stack_p">
/// a #GTrashStack
/// </param>
/// <param name="data_p">
/// the piece of memory to push on the stack
/// </param>

	public static void TrashStackPush(IntPtr stack_p, IntPtr data_p)
	{
		GLibGlobalFunctionsExterns.g_trash_stack_push(stack_p, data_p);
	}

/// <summary>
/// <para>
/// Attempts to allocate @n_bytes, and returns %NULL on failure.
/// Contrast with g_malloc(), which aborts the program on failure.
/// </para>
/// </summary>

/// <param name="n_bytes">
/// number of bytes to allocate.
/// </param>
/// <return>
/// the allocated memory, or %NULL.
/// </return>

	public static IntPtr TryMalloc(UIntPtr n_bytes)
	{
		return GLibGlobalFunctionsExterns.g_try_malloc(n_bytes);
	}

/// <summary>
/// <para>
/// Attempts to allocate @n_bytes, initialized to 0&apos;s, and returns %NULL on
/// failure. Contrast with g_malloc0(), which aborts the program on failure.
/// </para>
/// </summary>

/// <param name="n_bytes">
/// number of bytes to allocate
/// </param>
/// <return>
/// the allocated memory, or %NULL
/// </return>

	public static IntPtr TryMalloc0(UIntPtr n_bytes)
	{
		return GLibGlobalFunctionsExterns.g_try_malloc0(n_bytes);
	}

/// <summary>
/// <para>
/// This function is similar to g_try_malloc0(), allocating (@n_blocks * @n_block_bytes) bytes,
/// but care is taken to detect possible overflow during multiplication.
/// </para>
/// </summary>

/// <param name="n_blocks">
/// the number of blocks to allocate
/// </param>
/// <param name="n_block_bytes">
/// the size of each block in bytes
/// </param>
/// <return>
/// the allocated memory, or %NULL
/// </return>

	public static IntPtr TryMalloc0N(UIntPtr n_blocks, UIntPtr n_block_bytes)
	{
		return GLibGlobalFunctionsExterns.g_try_malloc0_n(n_blocks, n_block_bytes);
	}

/// <summary>
/// <para>
/// This function is similar to g_try_malloc(), allocating (@n_blocks * @n_block_bytes) bytes,
/// but care is taken to detect possible overflow during multiplication.
/// </para>
/// </summary>

/// <param name="n_blocks">
/// the number of blocks to allocate
/// </param>
/// <param name="n_block_bytes">
/// the size of each block in bytes
/// </param>
/// <return>
/// the allocated memory, or %NULL.
/// </return>

	public static IntPtr TryMallocN(UIntPtr n_blocks, UIntPtr n_block_bytes)
	{
		return GLibGlobalFunctionsExterns.g_try_malloc_n(n_blocks, n_block_bytes);
	}

/// <summary>
/// <para>
/// Attempts to realloc @mem to a new size, @n_bytes, and returns %NULL
/// on failure. Contrast with g_realloc(), which aborts the program
/// on failure.
/// </para>
/// <para>
/// If @mem is %NULL, behaves the same as g_try_malloc().
/// </para>
/// </summary>

/// <param name="mem">
/// previously-allocated memory, or %NULL.
/// </param>
/// <param name="n_bytes">
/// number of bytes to allocate.
/// </param>
/// <return>
/// the allocated memory, or %NULL.
/// </return>

	public static IntPtr TryRealloc(IntPtr mem, UIntPtr n_bytes)
	{
		return GLibGlobalFunctionsExterns.g_try_realloc(mem, n_bytes);
	}

/// <summary>
/// <para>
/// This function is similar to g_try_realloc(), allocating (@n_blocks * @n_block_bytes) bytes,
/// but care is taken to detect possible overflow during multiplication.
/// </para>
/// </summary>

/// <param name="mem">
/// previously-allocated memory, or %NULL.
/// </param>
/// <param name="n_blocks">
/// the number of blocks to allocate
/// </param>
/// <param name="n_block_bytes">
/// the size of each block in bytes
/// </param>
/// <return>
/// the allocated memory, or %NULL.
/// </return>

	public static IntPtr TryReallocN(IntPtr mem, UIntPtr n_blocks, UIntPtr n_block_bytes)
	{
		return GLibGlobalFunctionsExterns.g_try_realloc_n(mem, n_blocks, n_block_bytes);
	}

/// <summary>
/// <para>
/// Convert a string from UCS-4 to UTF-16.
/// </para>
/// <para>
/// A nul character (U+0000) will be added to the result after the converted text.
/// </para>
/// </summary>

/// <param name="str">
/// a UCS-4 encoded string
/// </param>
/// <param name="len">
/// the maximum length (number of characters) of @str to use.
///   If @len is negative, then the string is nul-terminated.
/// </param>
/// <param name="items_read">
/// location to store number of
///   bytes read, or `NULL`. If an error occurs then the index of the invalid
///   input is stored here.
/// </param>
/// <param name="items_written">
/// location to store number
///   of `gunichar2` written, or `NULL`. The value stored here does not include
///   the trailing nul.
/// </param>
/// <return>
/// a pointer to a newly allocated UTF-16 string.
///   This value must be freed with [func@GLib.free].
/// </return>

	public static char Ucs4ToUtf16(char[] str, long len, out long items_read, out long items_written)
	{
		var externCallResult = GLibGlobalFunctionsExterns.g_ucs4_to_utf16(str, len, out items_read, out items_written, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Convert a string from a 32-bit fixed width representation as UCS-4.
/// to UTF-8.
/// </para>
/// <para>
/// The result will be terminated with a nul byte.
/// </para>
/// </summary>

/// <param name="str">
/// a UCS-4 encoded string
/// </param>
/// <param name="len">
/// the maximum length (number of characters) of @str to use.
///   If @len is negative, then the string is nul-terminated.
/// </param>
/// <param name="items_read">
/// location to store number of
///   characters read, or `NULL`.
/// </param>
/// <param name="items_written">
/// location to store number
///   of bytes written or `NULL`. The value here stored does not include the
///   trailing nul byte.
/// </param>
/// <return>
/// a pointer to a newly allocated UTF-8 string.
///   This value must be freed with [func@GLib.free]. If an error occurs,
///   @items_read will be set to the position of the first invalid input
///   character.
/// </return>

	public static string Ucs4ToUtf8(char[] str, long len, out long items_read, out long items_written)
	{
		var externCallResult = GLibGlobalFunctionsExterns.g_ucs4_to_utf8(str, len, out items_read, out items_written, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Determines the break type of @c. @c should be a Unicode character
/// (to derive a character from UTF-8 encoded text, use
/// g_utf8_get_char()). The break type is used to find word and line
/// breaks (&quot;text boundaries&quot;), Pango implements the Unicode boundary
/// resolution algorithms and normally you would use a function such
/// as pango_break() instead of caring about break types yourself.
/// </para>
/// </summary>

/// <param name="c">
/// a Unicode character
/// </param>
/// <return>
/// the break type of @c
/// </return>

	public static MentorLake.GLib.GUnicodeBreakType UnicharBreakType(char c)
	{
		return GLibGlobalFunctionsExterns.g_unichar_break_type(c);
	}

/// <summary>
/// <para>
/// Determines the canonical combining class of a Unicode character.
/// </para>
/// </summary>

/// <param name="uc">
/// a Unicode character
/// </param>
/// <return>
/// the combining class of the character
/// </return>

	public static int UnicharCombiningClass(char uc)
	{
		return GLibGlobalFunctionsExterns.g_unichar_combining_class(uc);
	}

/// <summary>
/// <para>
/// Performs a single composition step of the
/// Unicode canonical composition algorithm.
/// </para>
/// <para>
/// This function includes algorithmic Hangul Jamo composition,
/// but it is not exactly the inverse of g_unichar_decompose().
/// No composition can have either of @a or @b equal to zero.
/// To be precise, this function composes if and only if
/// there exists a Primary Composite P which is canonically
/// equivalent to the sequence &amp;lt;@a,@b&amp;gt;.  See the Unicode
/// Standard for the definition of Primary Composite.
/// </para>
/// <para>
/// If @a and @b do not compose a new character, @ch is set to zero.
/// </para>
/// <para>
/// See
/// [UAX#15](http://unicode.org/reports/tr15/)
/// for details.
/// </para>
/// </summary>

/// <param name="a">
/// a Unicode character
/// </param>
/// <param name="b">
/// a Unicode character
/// </param>
/// <param name="ch">
/// return location for the composed character
/// </param>
/// <return>
/// %TRUE if the characters could be composed
/// </return>

	public static bool UnicharCompose(char a, char b, out char ch)
	{
		return GLibGlobalFunctionsExterns.g_unichar_compose(a, b, out ch);
	}

/// <summary>
/// <para>
/// Performs a single decomposition step of the
/// Unicode canonical decomposition algorithm.
/// </para>
/// <para>
/// This function does not include compatibility
/// decompositions. It does, however, include algorithmic
/// Hangul Jamo decomposition, as well as &apos;singleton&apos;
/// decompositions which replace a character by a single
/// other character. In the case of singletons `*b` will
/// be set to zero.
/// </para>
/// <para>
/// If @ch is not decomposable, `*a` is set to @ch and `*b`
/// is set to zero.
/// </para>
/// <para>
/// Note that the way Unicode decomposition pairs are
/// defined, it is guaranteed that @b would not decompose
/// further, but @a may itself decompose.  To get the full
/// canonical decomposition for @ch, one would need to
/// recursively call this function on @a.  Or use
/// g_unichar_fully_decompose().
/// </para>
/// <para>
/// See
/// [UAX#15](http://unicode.org/reports/tr15/)
/// for details.
/// </para>
/// </summary>

/// <param name="ch">
/// a Unicode character
/// </param>
/// <param name="a">
/// return location for the first component of @ch
/// </param>
/// <param name="b">
/// return location for the second component of @ch
/// </param>
/// <return>
/// %TRUE if the character could be decomposed
/// </return>

	public static bool UnicharDecompose(char ch, out char a, out char b)
	{
		return GLibGlobalFunctionsExterns.g_unichar_decompose(ch, out a, out b);
	}

/// <summary>
/// <para>
/// Determines the numeric value of a character as a decimal
/// digit.
/// </para>
/// </summary>

/// <param name="c">
/// a Unicode character
/// </param>
/// <return>
/// If @c is a decimal digit (according to
/// g_unichar_isdigit()), its numeric value. Otherwise, -1.
/// </return>

	public static int UnicharDigitValue(char c)
	{
		return GLibGlobalFunctionsExterns.g_unichar_digit_value(c);
	}

/// <summary>
/// <para>
/// Computes the canonical or compatibility decomposition of a
/// Unicode character.  For compatibility decomposition,
/// pass %TRUE for @compat; for canonical decomposition
/// pass %FALSE for @compat.
/// </para>
/// <para>
/// The decomposed sequence is placed in @result.  Only up to
/// @result_len characters are written into @result.  The length
/// of the full decomposition (irrespective of @result_len) is
/// returned by the function.  For canonical decomposition,
/// currently all decompositions are of length at most 4, but
/// this may change in the future (very unlikely though).
/// At any rate, Unicode does guarantee that a buffer of length
/// 18 is always enough for both compatibility and canonical
/// decompositions, so that is the size recommended. This is provided
/// as %G_UNICHAR_MAX_DECOMPOSITION_LENGTH.
/// </para>
/// <para>
/// See
/// [UAX#15](http://unicode.org/reports/tr15/)
/// for details.
/// </para>
/// </summary>

/// <param name="ch">
/// a Unicode character.
/// </param>
/// <param name="compat">
/// whether perform canonical or compatibility decomposition
/// </param>
/// <param name="result">
/// location to store decomposed result, or %NULL
/// </param>
/// <param name="result_len">
/// length of @result
/// </param>
/// <return>
/// the length of the full decomposition.
/// </return>

	public static UIntPtr UnicharFullyDecompose(char ch, bool compat, out char result, UIntPtr result_len)
	{
		return GLibGlobalFunctionsExterns.g_unichar_fully_decompose(ch, compat, out result, result_len);
	}

/// <summary>
/// <para>
/// In Unicode, some characters are &quot;mirrored&quot;. This means that their
/// images are mirrored horizontally in text that is laid out from right
/// to left. For instance, &quot;(&quot; would become its mirror image, &quot;)&quot;, in
/// right-to-left text.
/// </para>
/// <para>
/// If @ch has the Unicode mirrored property and there is another unicode
/// character that typically has a glyph that is the mirror image of @ch&apos;s
/// glyph and @mirrored_ch is set, it puts that character in the address
/// pointed to by @mirrored_ch.  Otherwise the original character is put.
/// </para>
/// </summary>

/// <param name="ch">
/// a Unicode character
/// </param>
/// <param name="mirrored_ch">
/// location to store the mirrored character
/// </param>
/// <return>
/// %TRUE if @ch has a mirrored character, %FALSE otherwise
/// </return>

	public static bool UnicharGetMirrorChar(char ch, out char mirrored_ch)
	{
		return GLibGlobalFunctionsExterns.g_unichar_get_mirror_char(ch, out mirrored_ch);
	}

/// <summary>
/// <para>
/// Looks up the #GUnicodeScript for a particular character (as defined
/// by Unicode Standard Annex \#24). No check is made for @ch being a
/// valid Unicode character; if you pass in invalid character, the
/// result is undefined.
/// </para>
/// <para>
/// This function is equivalent to pango_script_for_unichar() and the
/// two are interchangeable.
/// </para>
/// </summary>

/// <param name="ch">
/// a Unicode character
/// </param>
/// <return>
/// the #GUnicodeScript for the character.
/// </return>

	public static MentorLake.GLib.GUnicodeScript UnicharGetScript(char ch)
	{
		return GLibGlobalFunctionsExterns.g_unichar_get_script(ch);
	}

/// <summary>
/// <para>
/// Determines whether a character is alphanumeric.
/// Given some UTF-8 text, obtain a character value
/// with g_utf8_get_char().
/// </para>
/// </summary>

/// <param name="c">
/// a Unicode character
/// </param>
/// <return>
/// %TRUE if @c is an alphanumeric character
/// </return>

	public static bool UnicharIsalnum(char c)
	{
		return GLibGlobalFunctionsExterns.g_unichar_isalnum(c);
	}

/// <summary>
/// <para>
/// Determines whether a character is alphabetic (i.e. a letter).
/// Given some UTF-8 text, obtain a character value with
/// g_utf8_get_char().
/// </para>
/// </summary>

/// <param name="c">
/// a Unicode character
/// </param>
/// <return>
/// %TRUE if @c is an alphabetic character
/// </return>

	public static bool UnicharIsalpha(char c)
	{
		return GLibGlobalFunctionsExterns.g_unichar_isalpha(c);
	}

/// <summary>
/// <para>
/// Determines whether a character is a control character.
/// Given some UTF-8 text, obtain a character value with
/// g_utf8_get_char().
/// </para>
/// </summary>

/// <param name="c">
/// a Unicode character
/// </param>
/// <return>
/// %TRUE if @c is a control character
/// </return>

	public static bool UnicharIscntrl(char c)
	{
		return GLibGlobalFunctionsExterns.g_unichar_iscntrl(c);
	}

/// <summary>
/// <para>
/// Determines if a given character is assigned in the Unicode
/// standard.
/// </para>
/// </summary>

/// <param name="c">
/// a Unicode character
/// </param>
/// <return>
/// %TRUE if the character has an assigned value
/// </return>

	public static bool UnicharIsdefined(char c)
	{
		return GLibGlobalFunctionsExterns.g_unichar_isdefined(c);
	}

/// <summary>
/// <para>
/// Determines whether a character is numeric (i.e. a digit).  This
/// covers ASCII 0-9 and also digits in other languages/scripts.  Given
/// some UTF-8 text, obtain a character value with g_utf8_get_char().
/// </para>
/// </summary>

/// <param name="c">
/// a Unicode character
/// </param>
/// <return>
/// %TRUE if @c is a digit
/// </return>

	public static bool UnicharIsdigit(char c)
	{
		return GLibGlobalFunctionsExterns.g_unichar_isdigit(c);
	}

/// <summary>
/// <para>
/// Determines whether a character is printable and not a space
/// (returns %FALSE for control characters, format characters, and
/// spaces). g_unichar_isprint() is similar, but returns %TRUE for
/// spaces. Given some UTF-8 text, obtain a character value with
/// g_utf8_get_char().
/// </para>
/// </summary>

/// <param name="c">
/// a Unicode character
/// </param>
/// <return>
/// %TRUE if @c is printable unless it&apos;s a space
/// </return>

	public static bool UnicharIsgraph(char c)
	{
		return GLibGlobalFunctionsExterns.g_unichar_isgraph(c);
	}

/// <summary>
/// <para>
/// Determines whether a character is a lowercase letter.
/// Given some UTF-8 text, obtain a character value with
/// g_utf8_get_char().
/// </para>
/// </summary>

/// <param name="c">
/// a Unicode character
/// </param>
/// <return>
/// %TRUE if @c is a lowercase letter
/// </return>

	public static bool UnicharIslower(char c)
	{
		return GLibGlobalFunctionsExterns.g_unichar_islower(c);
	}

/// <summary>
/// <para>
/// Determines whether a character is a mark (non-spacing mark,
/// combining mark, or enclosing mark in Unicode speak).
/// Given some UTF-8 text, obtain a character value
/// with g_utf8_get_char().
/// </para>
/// <para>
/// Note: in most cases where isalpha characters are allowed,
/// ismark characters should be allowed to as they are essential
/// for writing most European languages as well as many non-Latin
/// scripts.
/// </para>
/// </summary>

/// <param name="c">
/// a Unicode character
/// </param>
/// <return>
/// %TRUE if @c is a mark character
/// </return>

	public static bool UnicharIsmark(char c)
	{
		return GLibGlobalFunctionsExterns.g_unichar_ismark(c);
	}

/// <summary>
/// <para>
/// Determines whether a character is printable.
/// Unlike g_unichar_isgraph(), returns %TRUE for spaces.
/// Given some UTF-8 text, obtain a character value with
/// g_utf8_get_char().
/// </para>
/// </summary>

/// <param name="c">
/// a Unicode character
/// </param>
/// <return>
/// %TRUE if @c is printable
/// </return>

	public static bool UnicharIsprint(char c)
	{
		return GLibGlobalFunctionsExterns.g_unichar_isprint(c);
	}

/// <summary>
/// <para>
/// Determines whether a character is punctuation or a symbol.
/// Given some UTF-8 text, obtain a character value with
/// g_utf8_get_char().
/// </para>
/// </summary>

/// <param name="c">
/// a Unicode character
/// </param>
/// <return>
/// %TRUE if @c is a punctuation or symbol character
/// </return>

	public static bool UnicharIspunct(char c)
	{
		return GLibGlobalFunctionsExterns.g_unichar_ispunct(c);
	}

/// <summary>
/// <para>
/// Determines whether a character is a space, tab, or line separator
/// (newline, carriage return, etc.).  Given some UTF-8 text, obtain a
/// character value with g_utf8_get_char().
/// </para>
/// <para>
/// (Note: don&apos;t use this to do word breaking; you have to use
/// Pango or equivalent to get word breaking right, the algorithm
/// is fairly complex.)
/// </para>
/// </summary>

/// <param name="c">
/// a Unicode character
/// </param>
/// <return>
/// %TRUE if @c is a space character
/// </return>

	public static bool UnicharIsspace(char c)
	{
		return GLibGlobalFunctionsExterns.g_unichar_isspace(c);
	}

/// <summary>
/// <para>
/// Determines if a character is titlecase. Some characters in
/// Unicode which are composites, such as the DZ digraph
/// have three case variants instead of just two. The titlecase
/// form is used at the beginning of a word where only the
/// first letter is capitalized. The titlecase form of the DZ
/// digraph is U+01F2 LATIN CAPITAL LETTTER D WITH SMALL LETTER Z.
/// </para>
/// </summary>

/// <param name="c">
/// a Unicode character
/// </param>
/// <return>
/// %TRUE if the character is titlecase
/// </return>

	public static bool UnicharIstitle(char c)
	{
		return GLibGlobalFunctionsExterns.g_unichar_istitle(c);
	}

/// <summary>
/// <para>
/// Determines if a character is uppercase.
/// </para>
/// </summary>

/// <param name="c">
/// a Unicode character
/// </param>
/// <return>
/// %TRUE if @c is an uppercase character
/// </return>

	public static bool UnicharIsupper(char c)
	{
		return GLibGlobalFunctionsExterns.g_unichar_isupper(c);
	}

/// <summary>
/// <para>
/// Determines if a character is typically rendered in a double-width
/// cell.
/// </para>
/// </summary>

/// <param name="c">
/// a Unicode character
/// </param>
/// <return>
/// %TRUE if the character is wide
/// </return>

	public static bool UnicharIswide(char c)
	{
		return GLibGlobalFunctionsExterns.g_unichar_iswide(c);
	}

/// <summary>
/// <para>
/// Determines if a character is typically rendered in a double-width
/// cell under legacy East Asian locales.  If a character is wide according to
/// g_unichar_iswide(), then it is also reported wide with this function, but
/// the converse is not necessarily true. See the
/// [Unicode Standard Annex #11](http://www.unicode.org/reports/tr11/)
/// for details.
/// </para>
/// <para>
/// If a character passes the g_unichar_iswide() test then it will also pass
/// this test, but not the other way around.  Note that some characters may
/// pass both this test and g_unichar_iszerowidth().
/// </para>
/// </summary>

/// <param name="c">
/// a Unicode character
/// </param>
/// <return>
/// %TRUE if the character is wide in legacy East Asian locales
/// </return>

	public static bool UnicharIswideCjk(char c)
	{
		return GLibGlobalFunctionsExterns.g_unichar_iswide_cjk(c);
	}

/// <summary>
/// <para>
/// Determines if a character is a hexadecimal digit.
/// </para>
/// </summary>

/// <param name="c">
/// a Unicode character.
/// </param>
/// <return>
/// %TRUE if the character is a hexadecimal digit
/// </return>

	public static bool UnicharIsxdigit(char c)
	{
		return GLibGlobalFunctionsExterns.g_unichar_isxdigit(c);
	}

/// <summary>
/// <para>
/// Determines if a given character typically takes zero width when rendered.
/// The return value is %TRUE for all non-spacing and enclosing marks
/// (e.g., combining accents), format characters, zero-width
/// space, but not U+00AD SOFT HYPHEN.
/// </para>
/// <para>
/// A typical use of this function is with one of g_unichar_iswide() or
/// g_unichar_iswide_cjk() to determine the number of cells a string occupies
/// when displayed on a grid display (terminals).  However, note that not all
/// terminals support zero-width rendering of zero-width marks.
/// </para>
/// </summary>

/// <param name="c">
/// a Unicode character
/// </param>
/// <return>
/// %TRUE if the character has zero width
/// </return>

	public static bool UnicharIszerowidth(char c)
	{
		return GLibGlobalFunctionsExterns.g_unichar_iszerowidth(c);
	}

/// <summary>
/// <para>
/// Converts a single character to UTF-8.
/// </para>
/// </summary>

/// <param name="c">
/// a Unicode character code
/// </param>
/// <param name="outbuf">
/// output buffer, must have at
///   least 6 bytes of space. If `NULL`, the length will be computed and
///   returned and nothing will be written to @outbuf.
/// </param>
/// <return>
/// number of bytes written
/// </return>

	public static int UnicharToUtf8(char c, out string outbuf)
	{
		return GLibGlobalFunctionsExterns.g_unichar_to_utf8(c, out outbuf);
	}

/// <summary>
/// <para>
/// Converts a character to lower case.
/// </para>
/// </summary>

/// <param name="c">
/// a Unicode character.
/// </param>
/// <return>
/// the result of converting @c to lower case.
///               If @c is not an upperlower or titlecase character,
///               or has no lowercase equivalent @c is returned unchanged.
/// </return>

	public static char UnicharTolower(char c)
	{
		return GLibGlobalFunctionsExterns.g_unichar_tolower(c);
	}

/// <summary>
/// <para>
/// Converts a character to the titlecase.
/// </para>
/// </summary>

/// <param name="c">
/// a Unicode character
/// </param>
/// <return>
/// the result of converting @c to titlecase.
///               If @c is not an uppercase or lowercase character,
///               @c is returned unchanged.
/// </return>

	public static char UnicharTotitle(char c)
	{
		return GLibGlobalFunctionsExterns.g_unichar_totitle(c);
	}

/// <summary>
/// <para>
/// Converts a character to uppercase.
/// </para>
/// </summary>

/// <param name="c">
/// a Unicode character
/// </param>
/// <return>
/// the result of converting @c to uppercase.
///               If @c is not a lowercase or titlecase character,
///               or has no upper case equivalent @c is returned unchanged.
/// </return>

	public static char UnicharToupper(char c)
	{
		return GLibGlobalFunctionsExterns.g_unichar_toupper(c);
	}

/// <summary>
/// <para>
/// Classifies a Unicode character by type.
/// </para>
/// </summary>

/// <param name="c">
/// a Unicode character
/// </param>
/// <return>
/// the type of the character.
/// </return>

	public static MentorLake.GLib.GUnicodeType UnicharType(char c)
	{
		return GLibGlobalFunctionsExterns.g_unichar_type(c);
	}

/// <summary>
/// <para>
/// Checks whether @ch is a valid Unicode character.
/// </para>
/// <para>
/// Some possible integer values of @ch will not be valid. U+0000 is considered a
/// valid character, though it’s normally a string terminator.
/// </para>
/// </summary>

/// <param name="ch">
/// a Unicode character
/// </param>
/// <return>
/// `TRUE` if @ch is a valid Unicode character
/// </return>

	public static bool UnicharValidate(char ch)
	{
		return GLibGlobalFunctionsExterns.g_unichar_validate(ch);
	}

/// <summary>
/// <para>
/// Determines the numeric value of a character as a hexadecimal
/// digit.
/// </para>
/// </summary>

/// <param name="c">
/// a Unicode character
/// </param>
/// <return>
/// If @c is a hex digit (according to
/// g_unichar_isxdigit()), its numeric value. Otherwise, -1.
/// </return>

	public static int UnicharXdigitValue(char c)
	{
		return GLibGlobalFunctionsExterns.g_unichar_xdigit_value(c);
	}

/// <summary>
/// <para>
/// Computes the canonical decomposition of a Unicode character.
/// </para>
/// </summary>

/// <param name="ch">
/// a Unicode character.
/// </param>
/// <param name="result_len">
/// location to store the length of the return value.
/// </param>
/// <return>
/// a newly allocated string of Unicode characters.
///   @result_len is set to the resulting length of the string.
/// </return>

	public static char UnicodeCanonicalDecomposition(char ch, UIntPtr result_len)
	{
		return GLibGlobalFunctionsExterns.g_unicode_canonical_decomposition(ch, result_len);
	}

/// <summary>
/// <para>
/// Computes the canonical ordering of a string in-place.
/// This rearranges decomposed characters in the string
/// according to their combining classes.  See the Unicode
/// manual for more information.
/// </para>
/// </summary>

/// <param name="@string">
/// a UCS-4 encoded string.
/// </param>
/// <param name="len">
/// the maximum length of @string to use.
/// </param>

	public static void UnicodeCanonicalOrdering(char[] @string, UIntPtr len)
	{
		GLibGlobalFunctionsExterns.g_unicode_canonical_ordering(@string, len);
	}

/// <summary>
/// <para>
/// Looks up the Unicode script for @iso15924.  ISO 15924 assigns four-letter
/// codes to scripts.  For example, the code for Arabic is &apos;Arab&apos;.
/// This function accepts four letter codes encoded as a @guint32 in a
/// big-endian fashion.  That is, the code expected for Arabic is
/// 0x41726162 (0x41 is ASCII code for &apos;A&apos;, 0x72 is ASCII code for &apos;r&apos;, etc).
/// </para>
/// <para>
/// See
/// [Codes for the representation of names of scripts](http://unicode.org/iso15924/codelists.html)
/// for details.
/// </para>
/// </summary>

/// <param name="iso15924">
/// a Unicode script
/// </param>
/// <return>
/// the Unicode script for @iso15924, or
///   of %G_UNICODE_SCRIPT_INVALID_CODE if @iso15924 is zero and
///   %G_UNICODE_SCRIPT_UNKNOWN if @iso15924 is unknown.
/// </return>

	public static MentorLake.GLib.GUnicodeScript UnicodeScriptFromIso15924(uint iso15924)
	{
		return GLibGlobalFunctionsExterns.g_unicode_script_from_iso15924(iso15924);
	}

/// <summary>
/// <para>
/// Looks up the ISO 15924 code for @script.  ISO 15924 assigns four-letter
/// codes to scripts.  For example, the code for Arabic is &apos;Arab&apos;.  The
/// four letter codes are encoded as a @guint32 by this function in a
/// big-endian fashion.  That is, the code returned for Arabic is
/// 0x41726162 (0x41 is ASCII code for &apos;A&apos;, 0x72 is ASCII code for &apos;r&apos;, etc).
/// </para>
/// <para>
/// See
/// [Codes for the representation of names of scripts](http://unicode.org/iso15924/codelists.html)
/// for details.
/// </para>
/// </summary>

/// <param name="script">
/// a Unicode script
/// </param>
/// <return>
/// the ISO 15924 code for @script, encoded as an integer,
///   of zero if @script is %G_UNICODE_SCRIPT_INVALID_CODE or
///   ISO 15924 code &apos;Zzzz&apos; (script code for UNKNOWN) if @script is not understood.
/// </return>

	public static uint UnicodeScriptToIso15924(MentorLake.GLib.GUnicodeScript script)
	{
		return GLibGlobalFunctionsExterns.g_unicode_script_to_iso15924(script);
	}



	public static MentorLake.GLib.GQuark UnixErrorQuark()
	{
		return GLibGlobalFunctionsExterns.g_unix_error_quark();
	}

/// <summary>
/// <para>
/// Sets a function to be called when the IO condition, as specified by
/// @condition becomes true for @fd.
/// </para>
/// <para>
/// @function will be called when the specified IO condition becomes
/// %TRUE.  The function is expected to clear whatever event caused the
/// IO condition to become true and return %TRUE in order to be notified
/// when it happens again.  If @function returns %FALSE then the watch
/// will be cancelled.
/// </para>
/// <para>
/// The return value of this function can be passed to g_source_remove()
/// to cancel the watch at any time that it exists.
/// </para>
/// <para>
/// The source will never close the fd -- you must do it yourself.
/// </para>
/// </summary>

/// <param name="fd">
/// a file descriptor
/// </param>
/// <param name="condition">
/// IO conditions to watch for on @fd
/// </param>
/// <param name="function">
/// a #GUnixFDSourceFunc
/// </param>
/// <param name="user_data">
/// data to pass to @function
/// </param>
/// <return>
/// the ID (greater than 0) of the event source
/// </return>

	public static uint UnixFdAdd(int fd, MentorLake.GLib.GIOCondition condition, MentorLake.GLib.GUnixFDSourceFunc function, IntPtr user_data)
	{
		return GLibGlobalFunctionsExterns.g_unix_fd_add(fd, condition, function, user_data);
	}

/// <summary>
/// <para>
/// Sets a function to be called when the IO condition, as specified by
/// @condition becomes true for @fd.
/// </para>
/// <para>
/// This is the same as g_unix_fd_add(), except that it allows you to
/// specify a non-default priority and a provide a #GDestroyNotify for
/// @user_data.
/// </para>
/// </summary>

/// <param name="priority">
/// the priority of the source
/// </param>
/// <param name="fd">
/// a file descriptor
/// </param>
/// <param name="condition">
/// IO conditions to watch for on @fd
/// </param>
/// <param name="function">
/// a #GUnixFDSourceFunc
/// </param>
/// <param name="user_data">
/// data to pass to @function
/// </param>
/// <param name="notify">
/// function to call when the idle is removed, or %NULL
/// </param>
/// <return>
/// the ID (greater than 0) of the event source
/// </return>

	public static uint UnixFdAddFull(int priority, int fd, MentorLake.GLib.GIOCondition condition, MentorLake.GLib.GUnixFDSourceFunc function, IntPtr user_data, MentorLake.GLib.GDestroyNotify notify)
	{
		return GLibGlobalFunctionsExterns.g_unix_fd_add_full(priority, fd, condition, function, user_data, notify);
	}

/// <summary>
/// <para>
/// Creates a #GSource to watch for a particular I/O condition on a file
/// descriptor.
/// </para>
/// <para>
/// The source will never close the @fd — you must do it yourself.
/// </para>
/// <para>
/// Any callback attached to the returned #GSource must have type
/// #GUnixFDSourceFunc.
/// </para>
/// </summary>

/// <param name="fd">
/// a file descriptor
/// </param>
/// <param name="condition">
/// I/O conditions to watch for on @fd
/// </param>
/// <return>
/// the newly created #GSource
/// </return>

	public static MentorLake.GLib.GSourceHandle UnixFdSourceNew(int fd, MentorLake.GLib.GIOCondition condition)
	{
		return GLibGlobalFunctionsExterns.g_unix_fd_source_new(fd, condition);
	}

/// <summary>
/// <para>
/// Get the `passwd` file entry for the given @user_name using `getpwnam_r()`.
/// This can fail if the given @user_name doesn’t exist.
/// </para>
/// <para>
/// The returned `struct passwd` has been allocated using g_malloc() and should
/// be freed using g_free(). The strings referenced by the returned struct are
/// included in the same allocation, so are valid until the `struct passwd` is
/// freed.
/// </para>
/// <para>
/// This function is safe to call from multiple threads concurrently.
/// </para>
/// <para>
/// You will need to include `pwd.h` to get the definition of `struct passwd`.
/// </para>
/// </summary>

/// <param name="user_name">
/// the username to get the passwd file entry for
/// </param>
/// <return>
/// passwd entry, or %NULL on error; free the returned
///    value with g_free()
/// </return>

	public static IntPtr UnixGetPasswdEntry(string user_name)
	{
		var externCallResult = GLibGlobalFunctionsExterns.g_unix_get_passwd_entry(user_name, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Similar to the UNIX pipe() call, but on modern systems like Linux
/// uses the pipe2() system call, which atomically creates a pipe with
/// the configured flags.
/// </para>
/// <para>
/// As of GLib 2.78, the supported flags are `O_CLOEXEC`/`FD_CLOEXEC` (see below)
/// and `O_NONBLOCK`. Prior to GLib 2.78, only `FD_CLOEXEC` was supported — if
/// you wanted to configure `O_NONBLOCK` then that had to be done separately with
/// `fcntl()`.
/// </para>
/// <para>
/// Since GLib 2.80, the constants %G_UNIX_PIPE_END_READ and
/// %G_UNIX_PIPE_END_WRITE can be used as mnemonic indexes in @fds.
/// </para>
/// <para>
/// It is a programmer error to call this function with unsupported flags, and a
/// critical warning will be raised.
/// </para>
/// <para>
/// As of GLib 2.78, it is preferred to pass `O_CLOEXEC` in, rather than
/// `FD_CLOEXEC`, as that matches the underlying `pipe()` API more closely. Prior
/// to 2.78, only `FD_CLOEXEC` was supported. Support for `FD_CLOEXEC` may be
/// deprecated and removed in future.
/// </para>
/// </summary>

/// <param name="fds">
/// Array of two integers
/// </param>
/// <param name="flags">
/// Bitfield of file descriptor flags, as for fcntl()
/// </param>
/// <return>
/// %TRUE on success, %FALSE if not (and errno will be set).
/// </return>

	public static bool UnixOpenPipe(int[] fds, int flags)
	{
		var externCallResult = GLibGlobalFunctionsExterns.g_unix_open_pipe(fds, flags, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Control the non-blocking state of the given file descriptor,
/// according to @nonblock. On most systems this uses %O_NONBLOCK, but
/// on some older ones may use %O_NDELAY.
/// </para>
/// </summary>

/// <param name="fd">
/// A file descriptor
/// </param>
/// <param name="nonblock">
/// If %TRUE, set the descriptor to be non-blocking
/// </param>
/// <return>
/// %TRUE if successful
/// </return>

	public static bool UnixSetFdNonblocking(int fd, bool nonblock)
	{
		var externCallResult = GLibGlobalFunctionsExterns.g_unix_set_fd_nonblocking(fd, nonblock, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// A convenience function for g_unix_signal_source_new(), which
/// attaches to the default #GMainContext.  You can remove the watch
/// using g_source_remove().
/// </para>
/// </summary>

/// <param name="signum">
/// Signal number
/// </param>
/// <param name="handler">
/// Callback
/// </param>
/// <param name="user_data">
/// Data for @handler
/// </param>
/// <return>
/// An ID (greater than 0) for the event source
/// </return>

	public static uint UnixSignalAdd(int signum, MentorLake.GLib.GSourceFunc handler, IntPtr user_data)
	{
		return GLibGlobalFunctionsExterns.g_unix_signal_add(signum, handler, user_data);
	}

/// <summary>
/// <para>
/// A convenience function for g_unix_signal_source_new(), which
/// attaches to the default #GMainContext.  You can remove the watch
/// using g_source_remove().
/// </para>
/// </summary>

/// <param name="priority">
/// the priority of the signal source. Typically this will be in
///            the range between %G_PRIORITY_DEFAULT and %G_PRIORITY_HIGH.
/// </param>
/// <param name="signum">
/// Signal number
/// </param>
/// <param name="handler">
/// Callback
/// </param>
/// <param name="user_data">
/// Data for @handler
/// </param>
/// <param name="notify">
/// #GDestroyNotify for @handler
/// </param>
/// <return>
/// An ID (greater than 0) for the event source
/// </return>

	public static uint UnixSignalAddFull(int priority, int signum, MentorLake.GLib.GSourceFunc handler, IntPtr user_data, MentorLake.GLib.GDestroyNotify notify)
	{
		return GLibGlobalFunctionsExterns.g_unix_signal_add_full(priority, signum, handler, user_data, notify);
	}

/// <summary>
/// <para>
/// Create a #GSource that will be dispatched upon delivery of the UNIX
/// signal @signum.  In GLib versions before 2.36, only `SIGHUP`, `SIGINT`,
/// `SIGTERM` can be monitored.  In GLib 2.36, `SIGUSR1` and `SIGUSR2`
/// were added. In GLib 2.54, `SIGWINCH` was added.
/// </para>
/// <para>
/// Note that unlike the UNIX default, all sources which have created a
/// watch will be dispatched, regardless of which underlying thread
/// invoked g_unix_signal_source_new().
/// </para>
/// <para>
/// For example, an effective use of this function is to handle `SIGTERM`
/// cleanly; flushing any outstanding files, and then calling
/// g_main_loop_quit().  It is not safe to do any of this from a regular
/// UNIX signal handler; such a handler may be invoked while malloc() or
/// another library function is running, causing reentrancy issues if the
/// handler attempts to use those functions.  None of the GLib/GObject
/// API is safe against this kind of reentrancy.
/// </para>
/// <para>
/// The interaction of this source when combined with native UNIX
/// functions like sigprocmask() is not defined.
/// </para>
/// <para>
/// The source will not initially be associated with any #GMainContext
/// and must be added to one with g_source_attach() before it will be
/// executed.
/// </para>
/// </summary>

/// <param name="signum">
/// A signal number
/// </param>
/// <return>
/// A newly created #GSource
/// </return>

	public static MentorLake.GLib.GSourceHandle UnixSignalSourceNew(int signum)
	{
		return GLibGlobalFunctionsExterns.g_unix_signal_source_new(signum);
	}

/// <summary>
/// <para>
/// A wrapper for the POSIX unlink() function. The unlink() function
/// deletes a name from the filesystem. If this was the last link to the
/// file and no processes have it opened, the diskspace occupied by the
/// file is freed.
/// </para>
/// <para>
/// See your C library manual for more details about unlink(). Note
/// that on Windows, it is in general not possible to delete files that
/// are open to some process, or mapped into memory.
/// </para>
/// </summary>

/// <param name="filename">
/// a pathname in the GLib file name encoding
///     (UTF-8 on Windows)
/// </param>
/// <return>
/// 0 if the name was successfully deleted, -1 if an error
///    occurred
/// </return>

	public static int Unlink(string filename)
	{
		return GLibGlobalFunctionsExterns.g_unlink(filename);
	}

/// <summary>
/// <para>
/// Removes an environment variable from the environment.
/// </para>
/// <para>
/// Note that on some systems, when variables are overwritten, the
/// memory used for the previous variables and its value isn&apos;t reclaimed.
/// </para>
/// <para>
/// You should be mindful of the fact that environment variable handling
/// in UNIX is not thread-safe, and your program may crash if one thread
/// calls g_unsetenv() while another thread is calling getenv(). (And note
/// that many functions, such as gettext(), call getenv() internally.) This
/// function is only safe to use at the very start of your program, before
/// creating any other threads (or creating objects that create worker
/// threads of their own).
/// </para>
/// <para>
/// If you need to set up the environment for a child process, you can
/// use g_get_environ() to get an environment array, modify that with
/// g_environ_setenv() and g_environ_unsetenv(), and then pass that
/// array directly to execvpe(), g_spawn_async(), or the like.
/// </para>
/// </summary>

/// <param name="variable">
/// the environment variable to remove, must
///     not contain &apos;=&apos;
/// </param>

	public static void Unsetenv(string variable)
	{
		GLibGlobalFunctionsExterns.g_unsetenv(variable);
	}

/// <summary>
/// <para>
/// Creates a new #GUri from the given components according to @flags.
/// </para>
/// <para>
/// See also g_uri_build_with_user(), which allows specifying the
/// components of the &quot;userinfo&quot; separately.
/// </para>
/// </summary>

/// <param name="flags">
/// flags describing how to build the #GUri
/// </param>
/// <param name="scheme">
/// the URI scheme
/// </param>
/// <param name="userinfo">
/// the userinfo component, or %NULL
/// </param>
/// <param name="host">
/// the host component, or %NULL
/// </param>
/// <param name="port">
/// the port, or `-1`
/// </param>
/// <param name="path">
/// the path component
/// </param>
/// <param name="query">
/// the query component, or %NULL
/// </param>
/// <param name="fragment">
/// the fragment, or %NULL
/// </param>
/// <return>
/// a new #GUri
/// </return>

	public static MentorLake.GLib.GUriHandle UriBuild(MentorLake.GLib.GUriFlags flags, string scheme, string userinfo, string host, int port, string path, string query, string fragment)
	{
		return GLibGlobalFunctionsExterns.g_uri_build(flags, scheme, userinfo, host, port, path, query, fragment);
	}

/// <summary>
/// <para>
/// Creates a new #GUri from the given components according to @flags
/// (%G_URI_FLAGS_HAS_PASSWORD is added unconditionally). The @flags must be
/// coherent with the passed values, in particular use `%`-encoded values with
/// %G_URI_FLAGS_ENCODED.
/// </para>
/// <para>
/// In contrast to g_uri_build(), this allows specifying the components
/// of the ‘userinfo’ field separately. Note that @user must be non-%NULL
/// if either @password or @auth_params is non-%NULL.
/// </para>
/// </summary>

/// <param name="flags">
/// flags describing how to build the #GUri
/// </param>
/// <param name="scheme">
/// the URI scheme
/// </param>
/// <param name="user">
/// the user component of the userinfo, or %NULL
/// </param>
/// <param name="password">
/// the password component of the userinfo, or %NULL
/// </param>
/// <param name="auth_params">
/// the auth params of the userinfo, or %NULL
/// </param>
/// <param name="host">
/// the host component, or %NULL
/// </param>
/// <param name="port">
/// the port, or `-1`
/// </param>
/// <param name="path">
/// the path component
/// </param>
/// <param name="query">
/// the query component, or %NULL
/// </param>
/// <param name="fragment">
/// the fragment, or %NULL
/// </param>
/// <return>
/// a new #GUri
/// </return>

	public static MentorLake.GLib.GUriHandle UriBuildWithUser(MentorLake.GLib.GUriFlags flags, string scheme, string user, string password, string auth_params, string host, int port, string path, string query, string fragment)
	{
		return GLibGlobalFunctionsExterns.g_uri_build_with_user(flags, scheme, user, password, auth_params, host, port, path, query, fragment);
	}



	public static MentorLake.GLib.GQuark UriErrorQuark()
	{
		return GLibGlobalFunctionsExterns.g_uri_error_quark();
	}

/// <summary>
/// <para>
/// Escapes arbitrary data for use in a URI.
/// </para>
/// <para>
/// Normally all characters that are not ‘unreserved’ (i.e. ASCII
/// alphanumerical characters plus dash, dot, underscore and tilde) are
/// escaped. But if you specify characters in @reserved_chars_allowed
/// they are not escaped. This is useful for the ‘reserved’ characters
/// in the URI specification, since those are allowed unescaped in some
/// portions of a URI.
/// </para>
/// <para>
/// Though technically incorrect, this will also allow escaping nul
/// bytes as `%``00`.
/// </para>
/// </summary>

/// <param name="unescaped">
/// the unescaped input data.
/// </param>
/// <param name="length">
/// the length of @unescaped
/// </param>
/// <param name="reserved_chars_allowed">
/// a string of reserved
///   characters that are allowed to be used, or %NULL.
/// </param>
/// <return>
/// an escaped version of @unescaped.
///     The returned string should be freed when no longer needed.
/// </return>

	public static string UriEscapeBytes(byte[] unescaped, UIntPtr length, string reserved_chars_allowed)
	{
		return GLibGlobalFunctionsExterns.g_uri_escape_bytes(unescaped, length, reserved_chars_allowed);
	}

/// <summary>
/// <para>
/// Escapes a string for use in a URI.
/// </para>
/// <para>
/// Normally all characters that are not &quot;unreserved&quot; (i.e. ASCII
/// alphanumerical characters plus dash, dot, underscore and tilde) are
/// escaped. But if you specify characters in @reserved_chars_allowed
/// they are not escaped. This is useful for the &quot;reserved&quot; characters
/// in the URI specification, since those are allowed unescaped in some
/// portions of a URI.
/// </para>
/// </summary>

/// <param name="unescaped">
/// the unescaped input string.
/// </param>
/// <param name="reserved_chars_allowed">
/// a string of reserved
///   characters that are allowed to be used, or %NULL.
/// </param>
/// <param name="allow_utf8">
/// %TRUE if the result can include UTF-8 characters.
/// </param>
/// <return>
/// an escaped version of @unescaped. The
/// returned string should be freed when no longer needed.
/// </return>

	public static string UriEscapeString(string unescaped, string reserved_chars_allowed, bool allow_utf8)
	{
		return GLibGlobalFunctionsExterns.g_uri_escape_string(unescaped, reserved_chars_allowed, allow_utf8);
	}

/// <summary>
/// <para>
/// Parses @uri_string according to @flags, to determine whether it is a valid
/// [absolute URI](#relative-and-absolute-uris), i.e. it does not need to be resolved
/// relative to another URI using g_uri_parse_relative().
/// </para>
/// <para>
/// If it’s not a valid URI, an error is returned explaining how it’s invalid.
/// </para>
/// <para>
/// See g_uri_split(), and the definition of #GUriFlags, for more
/// information on the effect of @flags.
/// </para>
/// </summary>

/// <param name="uri_string">
/// a string containing an absolute URI
/// </param>
/// <param name="flags">
/// flags for parsing @uri_string
/// </param>
/// <return>
/// %TRUE if @uri_string is a valid absolute URI, %FALSE on error.
/// </return>

	public static bool UriIsValid(string uri_string, MentorLake.GLib.GUriFlags flags)
	{
		var externCallResult = GLibGlobalFunctionsExterns.g_uri_is_valid(uri_string, flags, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Joins the given components together according to @flags to create
/// an absolute URI string. @path may not be %NULL (though it may be the empty
/// string).
/// </para>
/// <para>
/// When @host is present, @path must either be empty or begin with a slash (`/`)
/// character. When @host is not present, @path cannot begin with two slash
/// characters (`//`). See
/// [RFC 3986, section 3](https://tools.ietf.org/html/rfc3986#section-3).
/// </para>
/// <para>
/// See also g_uri_join_with_user(), which allows specifying the
/// components of the ‘userinfo’ separately.
/// </para>
/// <para>
/// %G_URI_FLAGS_HAS_PASSWORD and %G_URI_FLAGS_HAS_AUTH_PARAMS are ignored if set
/// in @flags.
/// </para>
/// </summary>

/// <param name="flags">
/// flags describing how to build the URI string
/// </param>
/// <param name="scheme">
/// the URI scheme, or %NULL
/// </param>
/// <param name="userinfo">
/// the userinfo component, or %NULL
/// </param>
/// <param name="host">
/// the host component, or %NULL
/// </param>
/// <param name="port">
/// the port, or `-1`
/// </param>
/// <param name="path">
/// the path component
/// </param>
/// <param name="query">
/// the query component, or %NULL
/// </param>
/// <param name="fragment">
/// the fragment, or %NULL
/// </param>
/// <return>
/// an absolute URI string
/// </return>

	public static string UriJoin(MentorLake.GLib.GUriFlags flags, string scheme, string userinfo, string host, int port, string path, string query, string fragment)
	{
		return GLibGlobalFunctionsExterns.g_uri_join(flags, scheme, userinfo, host, port, path, query, fragment);
	}

/// <summary>
/// <para>
/// Joins the given components together according to @flags to create
/// an absolute URI string. @path may not be %NULL (though it may be the empty
/// string).
/// </para>
/// <para>
/// In contrast to g_uri_join(), this allows specifying the components
/// of the ‘userinfo’ separately. It otherwise behaves the same.
/// </para>
/// <para>
/// %G_URI_FLAGS_HAS_PASSWORD and %G_URI_FLAGS_HAS_AUTH_PARAMS are ignored if set
/// in @flags.
/// </para>
/// </summary>

/// <param name="flags">
/// flags describing how to build the URI string
/// </param>
/// <param name="scheme">
/// the URI scheme, or %NULL
/// </param>
/// <param name="user">
/// the user component of the userinfo, or %NULL
/// </param>
/// <param name="password">
/// the password component of the userinfo, or
///   %NULL
/// </param>
/// <param name="auth_params">
/// the auth params of the userinfo, or
///   %NULL
/// </param>
/// <param name="host">
/// the host component, or %NULL
/// </param>
/// <param name="port">
/// the port, or `-1`
/// </param>
/// <param name="path">
/// the path component
/// </param>
/// <param name="query">
/// the query component, or %NULL
/// </param>
/// <param name="fragment">
/// the fragment, or %NULL
/// </param>
/// <return>
/// an absolute URI string
/// </return>

	public static string UriJoinWithUser(MentorLake.GLib.GUriFlags flags, string scheme, string user, string password, string auth_params, string host, int port, string path, string query, string fragment)
	{
		return GLibGlobalFunctionsExterns.g_uri_join_with_user(flags, scheme, user, password, auth_params, host, port, path, query, fragment);
	}

/// <summary>
/// <para>
/// Splits an URI list conforming to the text/uri-list
/// mime type defined in RFC 2483 into individual URIs,
/// discarding any comments. The URIs are not validated.
/// </para>
/// </summary>

/// <param name="uri_list">
/// an URI list
/// </param>
/// <return>
/// a newly allocated %NULL-terminated list
///   of strings holding the individual URIs. The array should be freed
///   with g_strfreev().
/// </return>

	public static string[] UriListExtractUris(string uri_list)
	{
		return GLibGlobalFunctionsExterns.g_uri_list_extract_uris(uri_list);
	}

/// <summary>
/// <para>
/// Parses @uri_string according to @flags. If the result is not a
/// valid [absolute URI](#relative-and-absolute-uris), it will be discarded, and an
/// error returned.
/// </para>
/// </summary>

/// <param name="uri_string">
/// a string representing an absolute URI
/// </param>
/// <param name="flags">
/// flags describing how to parse @uri_string
/// </param>
/// <return>
/// a new #GUri, or NULL on error.
/// </return>

	public static MentorLake.GLib.GUriHandle UriParse(string uri_string, MentorLake.GLib.GUriFlags flags)
	{
		var externCallResult = GLibGlobalFunctionsExterns.g_uri_parse(uri_string, flags, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Many URI schemes include one or more attribute/value pairs as part of the URI
/// value. This method can be used to parse them into a hash table. When an
/// attribute has multiple occurrences, the last value is the final returned
/// value. If you need to handle repeated attributes differently, use
/// #GUriParamsIter.
/// </para>
/// <para>
/// The @params string is assumed to still be `%`-encoded, but the returned
/// values will be fully decoded. (Thus it is possible that the returned values
/// may contain `=` or @separators, if the value was encoded in the input.)
/// Invalid `%`-encoding is treated as with the %G_URI_FLAGS_PARSE_RELAXED
/// rules for g_uri_parse(). (However, if @params is the path or query string
/// from a #GUri that was parsed without %G_URI_FLAGS_PARSE_RELAXED and
/// %G_URI_FLAGS_ENCODED, then you already know that it does not contain any
/// invalid encoding.)
/// </para>
/// <para>
/// %G_URI_PARAMS_WWW_FORM is handled as documented for g_uri_params_iter_init().
/// </para>
/// <para>
/// If %G_URI_PARAMS_CASE_INSENSITIVE is passed to @flags, attributes will be
/// compared case-insensitively, so a params string `attr=123&amp;Attr=456` will only
/// return a single attribute–value pair, `Attr=456`. Case will be preserved in
/// the returned attributes.
/// </para>
/// <para>
/// If @params cannot be parsed (for example, it contains two @separators
/// characters in a row), then @error is set and %NULL is returned.
/// </para>
/// </summary>

/// <param name="@params">
/// a `%`-encoded string containing `attribute=value`
///   parameters
/// </param>
/// <param name="length">
/// the length of @params, or `-1` if it is nul-terminated
/// </param>
/// <param name="separators">
/// the separator byte character set between parameters. (usually
///   `&amp;`, but sometimes `;` or both `&amp;;`). Note that this function works on
///   bytes not characters, so it can&apos;t be used to delimit UTF-8 strings for
///   anything but ASCII characters. You may pass an empty set, in which case
///   no splitting will occur.
/// </param>
/// <param name="flags">
/// flags to modify the way the parameters are handled.
/// </param>
/// <return>
/// 
///     A hash table of attribute/value pairs, with both names and values
///     fully-decoded; or %NULL on error.
/// </return>

	public static MentorLake.GLib.GHashTableHandle UriParseParams(string @params, UIntPtr length, string separators, MentorLake.GLib.GUriParamsFlags flags)
	{
		var externCallResult = GLibGlobalFunctionsExterns.g_uri_parse_params(@params, length, separators, flags, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Gets the scheme portion of a URI string.
/// [RFC 3986](https://tools.ietf.org/html/rfc3986#section-3) decodes the scheme
/// as:
/// <code>
/// URI = scheme &quot;:&quot; hier-part [ &quot;?&quot; query ] [ &quot;#&quot; fragment ]
/// URI = scheme &quot;:&quot; hier-part [ &quot;?&quot; query ] [ &quot;#&quot; fragment ]
/// </code>
/// </para>
/// </summary>

/// <param name="uri">
/// a valid URI.
/// </param>
/// <return>
/// The ‘scheme’ component of the URI, or
///     %NULL on error. The returned string should be freed when no longer needed.
/// </return>

	public static string UriParseScheme(string uri)
	{
		return GLibGlobalFunctionsExterns.g_uri_parse_scheme(uri);
	}

/// <summary>
/// <para>
/// Gets the scheme portion of a URI string.
/// [RFC 3986](https://tools.ietf.org/html/rfc3986#section-3) decodes the scheme
/// as:
/// <code>
/// URI = scheme &quot;:&quot; hier-part [ &quot;?&quot; query ] [ &quot;#&quot; fragment ]
/// URI = scheme &quot;:&quot; hier-part [ &quot;?&quot; query ] [ &quot;#&quot; fragment ]
/// </code>
/// </para>
/// <para>
/// Unlike g_uri_parse_scheme(), the returned scheme is normalized to
/// all-lowercase and does not need to be freed.
/// </para>
/// </summary>

/// <param name="uri">
/// a valid URI.
/// </param>
/// <return>
/// The ‘scheme’ component of the URI, or
///     %NULL on error. The returned string is normalized to all-lowercase, and
///     interned via g_intern_string(), so it does not need to be freed.
/// </return>

	public static string UriPeekScheme(string uri)
	{
		return GLibGlobalFunctionsExterns.g_uri_peek_scheme(uri);
	}

/// <summary>
/// <para>
/// Parses @uri_ref according to @flags and, if it is a
/// [relative URI](#relative-and-absolute-uris), resolves it relative to
/// @base_uri_string. If the result is not a valid absolute URI, it will be
/// discarded, and an error returned.
/// </para>
/// <para>
/// (If @base_uri_string is %NULL, this just returns @uri_ref, or
/// %NULL if @uri_ref is invalid or not absolute.)
/// </para>
/// </summary>

/// <param name="base_uri_string">
/// a string representing a base URI
/// </param>
/// <param name="uri_ref">
/// a string representing a relative or absolute URI
/// </param>
/// <param name="flags">
/// flags describing how to parse @uri_ref
/// </param>
/// <return>
/// the resolved URI string,
/// or NULL on error.
/// </return>

	public static string UriResolveRelative(string base_uri_string, string uri_ref, MentorLake.GLib.GUriFlags flags)
	{
		var externCallResult = GLibGlobalFunctionsExterns.g_uri_resolve_relative(base_uri_string, uri_ref, flags, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Parses @uri_ref (which can be an
/// [absolute or relative URI](#relative-and-absolute-uris)) according to @flags, and
/// returns the pieces. Any component that doesn&apos;t appear in @uri_ref will be
/// returned as %NULL (but note that all URIs always have a path component,
/// though it may be the empty string).
/// </para>
/// <para>
/// If @flags contains %G_URI_FLAGS_ENCODED, then `%`-encoded characters in
/// @uri_ref will remain encoded in the output strings. (If not,
/// then all such characters will be decoded.) Note that decoding will
/// only work if the URI components are ASCII or UTF-8, so you will
/// need to use %G_URI_FLAGS_ENCODED if they are not.
/// </para>
/// <para>
/// Note that the %G_URI_FLAGS_HAS_PASSWORD and
/// %G_URI_FLAGS_HAS_AUTH_PARAMS @flags are ignored by g_uri_split(),
/// since it always returns only the full userinfo; use
/// g_uri_split_with_user() if you want it split up.
/// </para>
/// </summary>

/// <param name="uri_ref">
/// a string containing a relative or absolute URI
/// </param>
/// <param name="flags">
/// flags for parsing @uri_ref
/// </param>
/// <param name="scheme">
/// on return, contains
///    the scheme (converted to lowercase), or %NULL
/// </param>
/// <param name="userinfo">
/// on return, contains
///    the userinfo, or %NULL
/// </param>
/// <param name="host">
/// on return, contains the
///    host, or %NULL
/// </param>
/// <param name="port">
/// on return, contains the
///    port, or `-1`
/// </param>
/// <param name="path">
/// on return, contains the
///    path
/// </param>
/// <param name="query">
/// on return, contains the
///    query, or %NULL
/// </param>
/// <param name="fragment">
/// on return, contains
///    the fragment, or %NULL
/// </param>
/// <return>
/// %TRUE if @uri_ref parsed successfully, %FALSE
///   on error.
/// </return>

	public static bool UriSplit(string uri_ref, MentorLake.GLib.GUriFlags flags, out string scheme, out string userinfo, out string host, out int port, out string path, out string query, out string fragment)
	{
		var externCallResult = GLibGlobalFunctionsExterns.g_uri_split(uri_ref, flags, out scheme, out userinfo, out host, out port, out path, out query, out fragment, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Parses @uri_string (which must be an [absolute URI](#relative-and-absolute-uris))
/// according to @flags, and returns the pieces relevant to connecting to a host.
/// See the documentation for g_uri_split() for more details; this is
/// mostly a wrapper around that function with simpler arguments.
/// However, it will return an error if @uri_string is a relative URI,
/// or does not contain a hostname component.
/// </para>
/// </summary>

/// <param name="uri_string">
/// a string containing an absolute URI
/// </param>
/// <param name="flags">
/// flags for parsing @uri_string
/// </param>
/// <param name="scheme">
/// on return, contains
///    the scheme (converted to lowercase), or %NULL
/// </param>
/// <param name="host">
/// on return, contains the
///    host, or %NULL
/// </param>
/// <param name="port">
/// on return, contains the
///    port, or `-1`
/// </param>
/// <return>
/// %TRUE if @uri_string parsed successfully,
///   %FALSE on error.
/// </return>

	public static bool UriSplitNetwork(string uri_string, MentorLake.GLib.GUriFlags flags, out string scheme, out string host, out int port)
	{
		var externCallResult = GLibGlobalFunctionsExterns.g_uri_split_network(uri_string, flags, out scheme, out host, out port, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Parses @uri_ref (which can be an
/// [absolute or relative URI](#relative-and-absolute-uris)) according to @flags, and
/// returns the pieces. Any component that doesn&apos;t appear in @uri_ref will be
/// returned as %NULL (but note that all URIs always have a path component,
/// though it may be the empty string).
/// </para>
/// <para>
/// See g_uri_split(), and the definition of #GUriFlags, for more
/// information on the effect of @flags. Note that @password will only
/// be parsed out if @flags contains %G_URI_FLAGS_HAS_PASSWORD, and
/// @auth_params will only be parsed out if @flags contains
/// %G_URI_FLAGS_HAS_AUTH_PARAMS.
/// </para>
/// </summary>

/// <param name="uri_ref">
/// a string containing a relative or absolute URI
/// </param>
/// <param name="flags">
/// flags for parsing @uri_ref
/// </param>
/// <param name="scheme">
/// on return, contains
///    the scheme (converted to lowercase), or %NULL
/// </param>
/// <param name="user">
/// on return, contains
///    the user, or %NULL
/// </param>
/// <param name="password">
/// on return, contains
///    the password, or %NULL
/// </param>
/// <param name="auth_params">
/// on return, contains
///    the auth_params, or %NULL
/// </param>
/// <param name="host">
/// on return, contains the
///    host, or %NULL
/// </param>
/// <param name="port">
/// on return, contains the
///    port, or `-1`
/// </param>
/// <param name="path">
/// on return, contains the
///    path
/// </param>
/// <param name="query">
/// on return, contains the
///    query, or %NULL
/// </param>
/// <param name="fragment">
/// on return, contains
///    the fragment, or %NULL
/// </param>
/// <return>
/// %TRUE if @uri_ref parsed successfully, %FALSE
///   on error.
/// </return>

	public static bool UriSplitWithUser(string uri_ref, MentorLake.GLib.GUriFlags flags, out string scheme, out string user, out string password, out string auth_params, out string host, out int port, out string path, out string query, out string fragment)
	{
		var externCallResult = GLibGlobalFunctionsExterns.g_uri_split_with_user(uri_ref, flags, out scheme, out user, out password, out auth_params, out host, out port, out path, out query, out fragment, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Unescapes a segment of an escaped string as binary data.
/// </para>
/// <para>
/// Note that in contrast to g_uri_unescape_string(), this does allow
/// nul bytes to appear in the output.
/// </para>
/// <para>
/// If any of the characters in @illegal_characters appears as an escaped
/// character in @escaped_string, then that is an error and %NULL will be
/// returned. This is useful if you want to avoid for instance having a slash
/// being expanded in an escaped path element, which might confuse pathname
/// handling.
/// </para>
/// </summary>

/// <param name="escaped_string">
/// A URI-escaped string
/// </param>
/// <param name="length">
/// the length (in bytes) of @escaped_string to escape, or `-1` if it
///   is nul-terminated.
/// </param>
/// <param name="illegal_characters">
/// a string of illegal characters
///   not to be allowed, or %NULL.
/// </param>
/// <return>
/// an unescaped version of @escaped_string
///     or %NULL on error (if decoding failed, using %G_URI_ERROR_FAILED error
///     code). The returned #GBytes should be unreffed when no longer needed.
/// </return>

	public static MentorLake.GLib.GBytesHandle UriUnescapeBytes(string escaped_string, UIntPtr length, string illegal_characters)
	{
		var externCallResult = GLibGlobalFunctionsExterns.g_uri_unescape_bytes(escaped_string, length, illegal_characters, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Unescapes a segment of an escaped string.
/// </para>
/// <para>
/// If any of the characters in @illegal_characters or the NUL
/// character appears as an escaped character in @escaped_string, then
/// that is an error and %NULL will be returned. This is useful if you
/// want to avoid for instance having a slash being expanded in an
/// escaped path element, which might confuse pathname handling.
/// </para>
/// <para>
/// Note: `NUL` byte is not accepted in the output, in contrast to
/// g_uri_unescape_bytes().
/// </para>
/// </summary>

/// <param name="escaped_string">
/// A string, may be %NULL
/// </param>
/// <param name="escaped_string_end">
/// Pointer to end of @escaped_string,
///   may be %NULL
/// </param>
/// <param name="illegal_characters">
/// An optional string of illegal
///   characters not to be allowed, may be %NULL
/// </param>
/// <return>
/// an unescaped version of @escaped_string,
/// or %NULL on error. The returned string should be freed when no longer
/// needed.  As a special case if %NULL is given for @escaped_string, this
/// function will return %NULL.
/// </return>

	public static string UriUnescapeSegment(string escaped_string, string escaped_string_end, string illegal_characters)
	{
		return GLibGlobalFunctionsExterns.g_uri_unescape_segment(escaped_string, escaped_string_end, illegal_characters);
	}

/// <summary>
/// <para>
/// Unescapes a whole escaped string.
/// </para>
/// <para>
/// If any of the characters in @illegal_characters or the NUL
/// character appears as an escaped character in @escaped_string, then
/// that is an error and %NULL will be returned. This is useful if you
/// want to avoid for instance having a slash being expanded in an
/// escaped path element, which might confuse pathname handling.
/// </para>
/// </summary>

/// <param name="escaped_string">
/// an escaped string to be unescaped.
/// </param>
/// <param name="illegal_characters">
/// a string of illegal characters
///   not to be allowed, or %NULL.
/// </param>
/// <return>
/// an unescaped version of @escaped_string.
/// The returned string should be freed when no longer needed.
/// </return>

	public static string UriUnescapeString(string escaped_string, string illegal_characters)
	{
		return GLibGlobalFunctionsExterns.g_uri_unescape_string(escaped_string, illegal_characters);
	}

/// <summary>
/// <para>
/// Pauses the current thread for the given number of microseconds.
/// </para>
/// <para>
/// There are 1 million microseconds per second (represented by the
/// %G_USEC_PER_SEC macro). g_usleep() may have limited precision,
/// depending on hardware and operating system; don&apos;t rely on the exact
/// length of the sleep.
/// </para>
/// </summary>

/// <param name="microseconds">
/// number of microseconds to pause
/// </param>

	public static void Usleep(ulong microseconds)
	{
		GLibGlobalFunctionsExterns.g_usleep(microseconds);
	}

/// <summary>
/// <para>
/// Convert a string from UTF-16 to UCS-4.
/// </para>
/// <para>
/// The result will be nul-terminated.
/// </para>
/// </summary>

/// <param name="str">
/// a UTF-16 encoded string
/// </param>
/// <param name="len">
/// the maximum length (number of #gunichar2) of @str to use.
///   If @len is negative, then the string is nul-terminated.
/// </param>
/// <param name="items_read">
/// location to store number of words read, or
///   `NULL`. If `NULL`, then [error@GLib.ConvertError.PARTIAL_INPUT] will be
///   returned in case @str contains a trailing partial character. If
///   an error occurs then the index of the invalid input is stored here.
/// </param>
/// <param name="items_written">
/// location to store number
///   of characters written, or `NULL`. The value stored here does not include
///   the trailing nul character.
/// </param>
/// <return>
/// a pointer to a newly allocated UCS-4 string.
///   This value must be freed with [func@GLib.free].
/// </return>

	public static char Utf16ToUcs4(ushort[] str, long len, out long items_read, out long items_written)
	{
		var externCallResult = GLibGlobalFunctionsExterns.g_utf16_to_ucs4(str, len, out items_read, out items_written, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Convert a string from UTF-16 to UTF-8.
/// </para>
/// <para>
/// The result will be terminated with a nul byte.
/// </para>
/// <para>
/// Note that the input is expected to be already in native endianness,
/// an initial byte-order-mark character is not handled specially.
/// [func@GLib.convert] can be used to convert a byte buffer of UTF-16 data of
/// ambiguous endianness.
/// </para>
/// <para>
/// Further note that this function does not validate the result
/// string; it may (for example) include embedded nul characters. The only
/// validation done by this function is to ensure that the input can
/// be correctly interpreted as UTF-16, i.e. it doesn’t contain
/// unpaired surrogates or partial character sequences.
/// </para>
/// </summary>

/// <param name="str">
/// a UTF-16 encoded string
/// </param>
/// <param name="len">
/// the maximum length (number of #gunichar2) of @str to use.
///   If @len is negative, then the string is nul-terminated.
/// </param>
/// <param name="items_read">
/// location to store number of words read, or
///   `NULL`. If `NULL`, then [error@GLib.ConvertError.PARTIAL_INPUT] will
///   be returned in case @str contains a trailing partial character. If
///   an error occurs then the index of the invalid input is stored here.
///   It’s guaranteed to be non-negative.
/// </param>
/// <param name="items_written">
/// location to store number
///   of bytes written, or `NULL`. The value stored here does not include the
///   trailing nul byte. It’s guaranteed to be non-negative.
/// </param>
/// <return>
/// a pointer to a newly allocated UTF-8 string.
///   This value must be freed with [func@GLib.free].
/// </return>

	public static string Utf16ToUtf8(ushort[] str, long len, out long items_read, out long items_written)
	{
		var externCallResult = GLibGlobalFunctionsExterns.g_utf16_to_utf8(str, len, out items_read, out items_written, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Converts a string into a form that is independent of case. The
/// result will not correspond to any particular case, but can be
/// compared for equality or ordered with the results of calling
/// g_utf8_casefold() on other strings.
/// </para>
/// <para>
/// Note that calling g_utf8_casefold() followed by g_utf8_collate() is
/// only an approximation to the correct linguistic case insensitive
/// ordering, though it is a fairly good one. Getting this exactly
/// right would require a more sophisticated collation function that
/// takes case sensitivity into account. GLib does not currently
/// provide such a function.
/// </para>
/// </summary>

/// <param name="str">
/// a UTF-8 encoded string
/// </param>
/// <param name="len">
/// length of @str, in bytes, or -1 if @str is nul-terminated.
/// </param>
/// <return>
/// a newly allocated string, that is a
///   case independent form of @str.
/// </return>

	public static string Utf8Casefold(string str, UIntPtr len)
	{
		return GLibGlobalFunctionsExterns.g_utf8_casefold(str, len);
	}

/// <summary>
/// <para>
/// Compares two strings for ordering using the linguistically
/// correct rules for the [current locale][setlocale].
/// When sorting a large number of strings, it will be significantly
/// faster to obtain collation keys with g_utf8_collate_key() and
/// compare the keys with strcmp() when sorting instead of sorting
/// the original strings.
/// </para>
/// <para>
/// If the two strings are not comparable due to being in different collation
/// sequences, the result is undefined. This can happen if the strings are in
/// different language scripts, for example.
/// </para>
/// </summary>

/// <param name="str1">
/// a UTF-8 encoded string
/// </param>
/// <param name="str2">
/// a UTF-8 encoded string
/// </param>
/// <return>
/// &amp;lt; 0 if @str1 compares before @str2,
///   0 if they compare equal, &amp;gt; 0 if @str1 compares after @str2.
/// </return>

	public static int Utf8Collate(string str1, string str2)
	{
		return GLibGlobalFunctionsExterns.g_utf8_collate(str1, str2);
	}

/// <summary>
/// <para>
/// Converts a string into a collation key that can be compared
/// with other collation keys produced by the same function using
/// strcmp().
/// </para>
/// <para>
/// The results of comparing the collation keys of two strings
/// with strcmp() will always be the same as comparing the two
/// original keys with g_utf8_collate().
/// </para>
/// <para>
/// Note that this function depends on the [current locale][setlocale].
/// </para>
/// <para>
/// Note that the returned string is not guaranteed to be in any
/// encoding, especially UTF-8. The returned value is meant to be
/// used only for comparisons.
/// </para>
/// </summary>

/// <param name="str">
/// a UTF-8 encoded string.
/// </param>
/// <param name="len">
/// length of @str, in bytes, or -1 if @str is nul-terminated.
/// </param>
/// <return>
/// a newly allocated string.
///   The contents of the string are only meant to be used when sorting.
///   This string should be freed with g_free() when you are done with it.
/// </return>

	public static string Utf8CollateKey(string str, UIntPtr len)
	{
		return GLibGlobalFunctionsExterns.g_utf8_collate_key(str, len);
	}

/// <summary>
/// <para>
/// Converts a string into a collation key that can be compared
/// with other collation keys produced by the same function using strcmp().
/// </para>
/// <para>
/// In order to sort filenames correctly, this function treats the dot &apos;.&apos;
/// as a special case. Most dictionary orderings seem to consider it
/// insignificant, thus producing the ordering &quot;event.c&quot; &quot;eventgenerator.c&quot;
/// &quot;event.h&quot; instead of &quot;event.c&quot; &quot;event.h&quot; &quot;eventgenerator.c&quot;. Also, we
/// would like to treat numbers intelligently so that &quot;file1&quot; &quot;file10&quot; &quot;file5&quot;
/// is sorted as &quot;file1&quot; &quot;file5&quot; &quot;file10&quot;.
/// </para>
/// <para>
/// Note that this function depends on the [current locale][setlocale].
/// </para>
/// <para>
/// Note that the returned string is not guaranteed to be in any
/// encoding, especially UTF-8. The returned value is meant to be
/// used only for comparisons.
/// </para>
/// </summary>

/// <param name="str">
/// a UTF-8 encoded string.
/// </param>
/// <param name="len">
/// length of @str, in bytes, or -1 if @str is nul-terminated.
/// </param>
/// <return>
/// a newly allocated string.
///   The contents of the string are only meant to be used when sorting.
///   This string should be freed with g_free() when you are done with it.
/// </return>

	public static string Utf8CollateKeyForFilename(string str, UIntPtr len)
	{
		return GLibGlobalFunctionsExterns.g_utf8_collate_key_for_filename(str, len);
	}

/// <summary>
/// <para>
/// Finds the start of the next UTF-8 character in the string after @p.
/// </para>
/// <para>
/// @p does not have to be at the beginning of a UTF-8 character. No check
/// is made to see if the character found is actually valid other than
/// it starts with an appropriate byte.
/// </para>
/// <para>
/// If @end is `NULL`, the return value will never be `NULL`: if the end of the
/// string is reached, a pointer to the terminating nul byte is returned. If
/// @end is non-`NULL`, the return value will be `NULL` if the end of the string
/// is reached.
/// </para>
/// </summary>

/// <param name="p">
/// a pointer to a position within a UTF-8 encoded string
/// </param>
/// <param name="end">
/// a pointer to the byte following the end of the string,
///     or `NULL` to indicate that the string is nul-terminated
/// </param>
/// <return>
/// a pointer to the found character or `NULL` if @end is
///    set and is reached
/// </return>

	public static string Utf8FindNextChar(string p, string end)
	{
		return GLibGlobalFunctionsExterns.g_utf8_find_next_char(p, end);
	}

/// <summary>
/// <para>
/// Given a position @p with a UTF-8 encoded string @str, find the start
/// of the previous UTF-8 character starting before @p. Returns `NULL` if no
/// UTF-8 characters are present in @str before @p.
/// </para>
/// <para>
/// @p does not have to be at the beginning of a UTF-8 character. No check
/// is made to see if the character found is actually valid other than
/// it starts with an appropriate byte.
/// </para>
/// </summary>

/// <param name="str">
/// pointer to the beginning of a UTF-8 encoded string
/// </param>
/// <param name="p">
/// pointer to some position within @str
/// </param>
/// <return>
/// a pointer to the found character
/// </return>

	public static string Utf8FindPrevChar(string str, string p)
	{
		return GLibGlobalFunctionsExterns.g_utf8_find_prev_char(str, p);
	}

/// <summary>
/// <para>
/// Converts a sequence of bytes encoded as UTF-8 to a Unicode character.
/// </para>
/// <para>
/// If @p does not point to a valid UTF-8 encoded character, results
/// are undefined. If you are not sure that the bytes are complete
/// valid Unicode characters, you should use [func@GLib.utf8_get_char_validated]
/// instead.
/// </para>
/// </summary>

/// <param name="p">
/// a pointer to Unicode character encoded as UTF-8
/// </param>
/// <return>
/// the resulting character
/// </return>

	public static char Utf8GetChar(string p)
	{
		return GLibGlobalFunctionsExterns.g_utf8_get_char(p);
	}

/// <summary>
/// <para>
/// Convert a sequence of bytes encoded as UTF-8 to a Unicode character.
/// </para>
/// <para>
/// This function checks for incomplete characters, for invalid characters
/// such as characters that are out of the range of Unicode, and for
/// overlong encodings of valid characters.
/// </para>
/// <para>
/// Note that [func@GLib.utf8_get_char_validated] returns `(gunichar)-2` if
/// @max_len is positive and any of the bytes in the first UTF-8 character
/// sequence are nul.
/// </para>
/// </summary>

/// <param name="p">
/// a pointer to Unicode character encoded as UTF-8
/// </param>
/// <param name="max_len">
/// the maximum number of bytes to read, or `-1` if @p is nul-terminated
/// </param>
/// <return>
/// the resulting character. If @p points to a partial
///   sequence at the end of a string that could begin a valid
///   character (or if @max_len is zero), returns `(gunichar)-2`;
///   otherwise, if @p does not point to a valid UTF-8 encoded
///   Unicode character, returns `(gunichar)-1`.
/// </return>

	public static char Utf8GetCharValidated(string p, UIntPtr max_len)
	{
		return GLibGlobalFunctionsExterns.g_utf8_get_char_validated(p, max_len);
	}

/// <summary>
/// <para>
/// If the provided string is valid UTF-8, return a copy of it. If not,
/// return a copy in which bytes that could not be interpreted as valid Unicode
/// are replaced with the Unicode replacement character (U+FFFD).
/// </para>
/// <para>
/// For example, this is an appropriate function to use if you have received
/// a string that was incorrectly declared to be UTF-8, and you need a valid
/// UTF-8 version of it that can be logged or displayed to the user, with the
/// assumption that it is close enough to ASCII or UTF-8 to be mostly
/// readable as-is.
/// </para>
/// </summary>

/// <param name="str">
/// string to coerce into UTF-8
/// </param>
/// <param name="len">
/// the maximum length of @str to use, in bytes. If @len is negative,
///   then the string is nul-terminated.
/// </param>
/// <return>
/// a valid UTF-8 string whose content resembles @str
/// </return>

	public static string Utf8MakeValid(string str, UIntPtr len)
	{
		return GLibGlobalFunctionsExterns.g_utf8_make_valid(str, len);
	}

/// <summary>
/// <para>
/// Converts a string into canonical form, standardizing
/// such issues as whether a character with an accent
/// is represented as a base character and combining
/// accent or as a single precomposed character. The
/// string has to be valid UTF-8, otherwise %NULL is
/// returned. You should generally call g_utf8_normalize()
/// before comparing two Unicode strings.
/// </para>
/// <para>
/// The normalization mode %G_NORMALIZE_DEFAULT only
/// standardizes differences that do not affect the
/// text content, such as the above-mentioned accent
/// representation. %G_NORMALIZE_ALL also standardizes
/// the &quot;compatibility&quot; characters in Unicode, such
/// as SUPERSCRIPT THREE to the standard forms
/// (in this case DIGIT THREE). Formatting information
/// may be lost but for most text operations such
/// characters should be considered the same.
/// </para>
/// <para>
/// %G_NORMALIZE_DEFAULT_COMPOSE and %G_NORMALIZE_ALL_COMPOSE
/// are like %G_NORMALIZE_DEFAULT and %G_NORMALIZE_ALL,
/// but returned a result with composed forms rather
/// than a maximally decomposed form. This is often
/// useful if you intend to convert the string to
/// a legacy encoding or pass it to a system with
/// less capable Unicode handling.
/// </para>
/// </summary>

/// <param name="str">
/// a UTF-8 encoded string.
/// </param>
/// <param name="len">
/// length of @str, in bytes, or -1 if @str is nul-terminated.
/// </param>
/// <param name="mode">
/// the type of normalization to perform.
/// </param>
/// <return>
/// a newly allocated string, that
///   is the normalized form of @str, or %NULL if @str
///   is not valid UTF-8.
/// </return>

	public static string Utf8Normalize(string str, UIntPtr len, MentorLake.GLib.GNormalizeMode mode)
	{
		return GLibGlobalFunctionsExterns.g_utf8_normalize(str, len, mode);
	}

/// <summary>
/// <para>
/// Converts from an integer character offset to a pointer to a position
/// within the string.
/// </para>
/// <para>
/// Since 2.10, this function allows to pass a negative @offset to
/// step backwards. It is usually worth stepping backwards from the end
/// instead of forwards if @offset is in the last fourth of the string,
/// since moving forward is about 3 times faster than moving backward.
/// </para>
/// <para>
/// Note that this function doesn’t abort when reaching the end of @str.
/// Therefore you should be sure that @offset is within string boundaries
/// before calling that function. Call [func@GLib.utf8_strlen] when unsure.
/// This limitation exists as this function is called frequently during
/// text rendering and therefore has to be as fast as possible.
/// </para>
/// </summary>

/// <param name="str">
/// a UTF-8 encoded string
/// </param>
/// <param name="offset">
/// a character offset within @str
/// </param>
/// <return>
/// the resulting pointer
/// </return>

	public static string Utf8OffsetToPointer(string str, long offset)
	{
		return GLibGlobalFunctionsExterns.g_utf8_offset_to_pointer(str, offset);
	}

/// <summary>
/// <para>
/// Converts from a pointer to position within a string to an integer
/// character offset.
/// </para>
/// <para>
/// Since 2.10, this function allows @pos to be before @str, and returns
/// a negative offset in this case.
/// </para>
/// </summary>

/// <param name="str">
/// a UTF-8 encoded string
/// </param>
/// <param name="pos">
/// a pointer to a position within @str
/// </param>
/// <return>
/// the resulting character offset
/// </return>

	public static long Utf8PointerToOffset(string str, string pos)
	{
		return GLibGlobalFunctionsExterns.g_utf8_pointer_to_offset(str, pos);
	}

/// <summary>
/// <para>
/// Finds the previous UTF-8 character in the string before @p.
/// </para>
/// <para>
/// @p does not have to be at the beginning of a UTF-8 character. No check
/// is made to see if the character found is actually valid other than
/// it starts with an appropriate byte. If @p might be the first
/// character of the string, you must use [func@GLib.utf8_find_prev_char]
/// instead.
/// </para>
/// </summary>

/// <param name="p">
/// a pointer to a position within a UTF-8 encoded string
/// </param>
/// <return>
/// a pointer to the found character
/// </return>

	public static string Utf8PrevChar(string p)
	{
		return GLibGlobalFunctionsExterns.g_utf8_prev_char(p);
	}

/// <summary>
/// <para>
/// Finds the leftmost occurrence of the given Unicode character
/// in a UTF-8 encoded string, while limiting the search to @len bytes.
/// </para>
/// <para>
/// If @len is `-1`, allow unbounded search.
/// </para>
/// </summary>

/// <param name="p">
/// a nul-terminated UTF-8 encoded string
/// </param>
/// <param name="len">
/// the maximum length of @p
/// </param>
/// <param name="c">
/// a Unicode character
/// </param>
/// <return>
/// `NULL` if the string does not contain
///   the character, otherwise, a pointer to the start of the leftmost occurrence
///   of the character in the string.
/// </return>

	public static string Utf8Strchr(string p, UIntPtr len, char c)
	{
		return GLibGlobalFunctionsExterns.g_utf8_strchr(p, len, c);
	}

/// <summary>
/// <para>
/// Converts all Unicode characters in the string that have a case
/// to lowercase. The exact manner that this is done depends
/// on the current locale, and may result in the number of
/// characters in the string changing.
/// </para>
/// </summary>

/// <param name="str">
/// a UTF-8 encoded string
/// </param>
/// <param name="len">
/// length of @str, in bytes, or -1 if @str is nul-terminated.
/// </param>
/// <return>
/// a newly allocated string, with all characters
///    converted to lowercase.
/// </return>

	public static string Utf8Strdown(string str, UIntPtr len)
	{
		return GLibGlobalFunctionsExterns.g_utf8_strdown(str, len);
	}

/// <summary>
/// <para>
/// Computes the length of the string in characters, not including
/// the terminating nul character. If the @max’th byte falls in the
/// middle of a character, the last (partial) character is not counted.
/// </para>
/// </summary>

/// <param name="p">
/// pointer to the start of a UTF-8 encoded string
/// </param>
/// <param name="max">
/// the maximum number of bytes to examine. If @max
///   is less than 0, then the string is assumed to be
///   nul-terminated. If @max is 0, @p will not be examined and
///   may be `NULL`. If @max is greater than 0, up to @max
///   bytes are examined
/// </param>
/// <return>
/// the length of the string in characters
/// </return>

	public static long Utf8Strlen(string p, UIntPtr max)
	{
		return GLibGlobalFunctionsExterns.g_utf8_strlen(p, max);
	}

/// <summary>
/// <para>
/// Like the standard C &amp;lt;see href=&quot;man:strncpy&quot;&amp;gt;strncpy()&amp;lt;/see&amp;gt; function, but copies a given
/// number of characters instead of a given number of bytes.
/// </para>
/// <para>
/// The @src string must be valid UTF-8 encoded text. (Use
/// [func@GLib.utf8_validate] on all text before trying to use UTF-8 utility
/// functions with it.)
/// </para>
/// <para>
/// Note you must ensure @dest is at least 4 * @n + 1 to fit the
/// largest possible UTF-8 characters
/// </para>
/// </summary>

/// <param name="dest">
/// buffer to fill with characters from @src
/// </param>
/// <param name="src">
/// UTF-8 encoded string
/// </param>
/// <param name="n">
/// character count
/// </param>
/// <return>
/// @dest
/// </return>

	public static string Utf8Strncpy(string dest, string src, UIntPtr n)
	{
		return GLibGlobalFunctionsExterns.g_utf8_strncpy(dest, src, n);
	}

/// <summary>
/// <para>
/// Find the rightmost occurrence of the given Unicode character
/// in a UTF-8 encoded string, while limiting the search to @len bytes.
/// </para>
/// <para>
/// If @len is `-1`, allow unbounded search.
/// </para>
/// </summary>

/// <param name="p">
/// a nul-terminated UTF-8 encoded string
/// </param>
/// <param name="len">
/// the maximum length of @p
/// </param>
/// <param name="c">
/// a Unicode character
/// </param>
/// <return>
/// `NULL` if the string does not contain
///   the character, otherwise, a pointer to the start of the rightmost
///   occurrence of the character in the string.
/// </return>

	public static string Utf8Strrchr(string p, UIntPtr len, char c)
	{
		return GLibGlobalFunctionsExterns.g_utf8_strrchr(p, len, c);
	}

/// <summary>
/// <para>
/// Reverses a UTF-8 string.
/// </para>
/// <para>
/// @str must be valid UTF-8 encoded text. (Use [func@GLib.utf8_validate] on all
/// text before trying to use UTF-8 utility functions with it.)
/// </para>
/// <para>
/// This function is intended for programmatic uses of reversed strings.
/// It pays no attention to decomposed characters, combining marks, byte
/// order marks, directional indicators (LRM, LRO, etc) and similar
/// characters which might need special handling when reversing a string
/// for display purposes.
/// </para>
/// <para>
/// Note that unlike [func@GLib.strreverse], this function returns
/// newly-allocated memory, which should be freed with [func@GLib.free] when
/// no longer needed.
/// </para>
/// </summary>

/// <param name="str">
/// a UTF-8 encoded string
/// </param>
/// <param name="len">
/// the maximum length of @str to use, in bytes. If @len is negative,
///   then the string is nul-terminated.
/// </param>
/// <return>
/// a newly-allocated string which is the reverse of @str
/// </return>

	public static string Utf8Strreverse(string str, UIntPtr len)
	{
		return GLibGlobalFunctionsExterns.g_utf8_strreverse(str, len);
	}

/// <summary>
/// <para>
/// Converts all Unicode characters in the string that have a case
/// to uppercase. The exact manner that this is done depends
/// on the current locale, and may result in the number of
/// characters in the string increasing. (For instance, the
/// German ess-zet will be changed to SS.)
/// </para>
/// </summary>

/// <param name="str">
/// a UTF-8 encoded string
/// </param>
/// <param name="len">
/// length of @str, in bytes, or -1 if @str is nul-terminated.
/// </param>
/// <return>
/// a newly allocated string, with all characters
///    converted to uppercase.
/// </return>

	public static string Utf8Strup(string str, UIntPtr len)
	{
		return GLibGlobalFunctionsExterns.g_utf8_strup(str, len);
	}

/// <summary>
/// <para>
/// Copies a substring out of a UTF-8 encoded string.
/// The substring will contain @end_pos - @start_pos characters.
/// </para>
/// <para>
/// Since GLib 2.72, `-1` can be passed to @end_pos to indicate the
/// end of the string.
/// </para>
/// </summary>

/// <param name="str">
/// a UTF-8 encoded string
/// </param>
/// <param name="start_pos">
/// a character offset within @str
/// </param>
/// <param name="end_pos">
/// another character offset within @str,
///   or `-1` to indicate the end of the string
/// </param>
/// <return>
/// a newly allocated copy of the requested
///   substring. Free with [func@GLib.free] when no longer needed.
/// </return>

	public static string Utf8Substring(string str, long start_pos, long end_pos)
	{
		return GLibGlobalFunctionsExterns.g_utf8_substring(str, start_pos, end_pos);
	}

/// <summary>
/// <para>
/// Convert a string from UTF-8 to a 32-bit fixed width representation as UCS-4.
/// </para>
/// <para>
/// A trailing nul character (U+0000) will be added to the string after the
/// converted text.
/// </para>
/// </summary>

/// <param name="str">
/// a UTF-8 encoded string
/// </param>
/// <param name="len">
/// the maximum length of @str to use, in bytes. If @len is negative,
///   then the string is nul-terminated.
/// </param>
/// <param name="items_read">
/// location to store number of
///  bytes read, or `NULL`.
///   If `NULL`, then %G_CONVERT_ERROR_PARTIAL_INPUT will be
///   returned in case @str contains a trailing partial
///   character. If an error occurs then the index of the
///   invalid input is stored here.
/// </param>
/// <param name="items_written">
/// location to store number
///   of characters written or `NULL`. The value here stored does not include
///   the trailing nul character.
/// </param>
/// <return>
/// a pointer to a newly allocated UCS-4 string.
///   This value must be freed with [func@GLib.free].
/// </return>

	public static char Utf8ToUcs4(string str, long len, out long items_read, out long items_written)
	{
		var externCallResult = GLibGlobalFunctionsExterns.g_utf8_to_ucs4(str, len, out items_read, out items_written, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Convert a string from UTF-8 to a 32-bit fixed width
/// representation as UCS-4, assuming valid UTF-8 input.
/// </para>
/// <para>
/// This function is roughly twice as fast as [func@GLib.utf8_to_ucs4]
/// but does no error checking on the input. A trailing nul character (U+0000)
/// will be added to the string after the converted text.
/// </para>
/// </summary>

/// <param name="str">
/// a UTF-8 encoded string
/// </param>
/// <param name="len">
/// the maximum length of @str to use, in bytes. If @len is negative,
///   then the string is nul-terminated.
/// </param>
/// <param name="items_written">
/// location to store the
///   number of characters in the result, or `NULL`.
/// </param>
/// <return>
/// a pointer to a newly allocated UCS-4 string.
///   This value must be freed with [func@GLib.free].
/// </return>

	public static char Utf8ToUcs4Fast(string str, long len, out long items_written)
	{
		return GLibGlobalFunctionsExterns.g_utf8_to_ucs4_fast(str, len, out items_written);
	}

/// <summary>
/// <para>
/// Convert a string from UTF-8 to UTF-16.
/// </para>
/// <para>
/// A nul character (U+0000) will be added to the result after the converted text.
/// </para>
/// </summary>

/// <param name="str">
/// a UTF-8 encoded string
/// </param>
/// <param name="len">
/// the maximum length (number of bytes) of @str to use.
///   If @len is negative, then the string is nul-terminated.
/// </param>
/// <param name="items_read">
/// location to store number of bytes read, or
///   `NULL`. If `NULL`, then [error@GLib.ConvertError.PARTIAL_INPUT] will
///   be returned in case @str contains a trailing partial character. If
///   an error occurs then the index of the invalid input is stored here.
/// </param>
/// <param name="items_written">
/// location to store number
///   of `gunichar2` written, or `NULL`. The value stored here does not include
///   the trailing nul.
/// </param>
/// <return>
/// a pointer to a newly allocated UTF-16 string.
///   This value must be freed with [func@GLib.free].
/// </return>

	public static char Utf8ToUtf16(string str, long len, out long items_read, out long items_written)
	{
		var externCallResult = GLibGlobalFunctionsExterns.g_utf8_to_utf16(str, len, out items_read, out items_written, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Cuts off the middle of the string, preserving half of @truncate_length
/// characters at the beginning and half at the end.
/// </para>
/// <para>
/// If @string is already short enough, this returns a copy of @string.
/// If @truncate_length is `0`, an empty string is returned.
/// </para>
/// </summary>

/// <param name="@string">
/// a nul-terminated UTF-8 encoded string
/// </param>
/// <param name="truncate_length">
/// the new size of @string, in characters, including the ellipsis character
/// </param>
/// <return>
/// a newly-allocated copy of @string ellipsized in the middle
/// </return>

	public static string Utf8TruncateMiddle(string @string, UIntPtr truncate_length)
	{
		return GLibGlobalFunctionsExterns.g_utf8_truncate_middle(@string, truncate_length);
	}

/// <summary>
/// <para>
/// Validates UTF-8 encoded text.
/// </para>
/// <para>
/// @str is the text to validate; if @str is nul-terminated, then @max_len can be
/// `-1`, otherwise @max_len should be the number of bytes to validate.
/// </para>
/// <para>
/// If @end is non-`NULL`, then the end of the valid range will be stored there.
/// This is the first byte of the first invalid character if some bytes were
/// invalid, or the end of the text being validated otherwise — either the
/// trailing nul byte, or the first byte beyond @max_len (if it’s positive).
/// </para>
/// <para>
/// Note that `g_utf8_validate()` returns `FALSE` if @max_len is  positive and
/// any of the @max_len bytes are nul.
/// </para>
/// <para>
/// Returns `TRUE` if all of @str was valid. Many GLib and GTK
/// routines require valid UTF-8 as input; so data read from a file
/// or the network should be checked with `g_utf8_validate()` before
/// doing anything else with it.
/// </para>
/// </summary>

/// <param name="str">
/// a pointer to character data
/// </param>
/// <param name="max_len">
/// max bytes to validate, or `-1` to go until nul
/// </param>
/// <param name="end">
/// return location for end of valid data
/// </param>
/// <return>
/// `TRUE` if the text was valid UTF-8
/// </return>

	public static bool Utf8Validate(byte[] str, UIntPtr max_len, out string end)
	{
		return GLibGlobalFunctionsExterns.g_utf8_validate(str, max_len, out end);
	}

/// <summary>
/// <para>
/// Validates UTF-8 encoded text.
/// </para>
/// <para>
/// As with [func@GLib.utf8_validate], but @max_len must be set, and hence this
/// function will always return `FALSE` if any of the bytes of @str are nul.
/// </para>
/// </summary>

/// <param name="str">
/// a pointer to character data
/// </param>
/// <param name="max_len">
/// max bytes to validate
/// </param>
/// <param name="end">
/// return location for end of valid data
/// </param>
/// <return>
/// `TRUE` if the text was valid UTF-8
/// </return>

	public static bool Utf8ValidateLen(byte[] str, UIntPtr max_len, out string end)
	{
		return GLibGlobalFunctionsExterns.g_utf8_validate_len(str, max_len, out end);
	}

/// <summary>
/// <para>
/// A wrapper for the POSIX utime() function. The utime() function
/// sets the access and modification timestamps of a file.
/// </para>
/// <para>
/// See your C library manual for more details about how utime() works
/// on your system.
/// </para>
/// </summary>

/// <param name="filename">
/// a pathname in the GLib file name encoding
///     (UTF-8 on Windows)
/// </param>
/// <param name="utb">
/// a pointer to a struct utimbuf.
/// </param>
/// <return>
/// 0 if the operation was successful, -1 if an error occurred
/// </return>

	public static int Utime(string filename, IntPtr utb)
	{
		return GLibGlobalFunctionsExterns.g_utime(filename, utb);
	}

/// <summary>
/// <para>
/// Parses the string @str and verify if it is a UUID.
/// </para>
/// <para>
/// The function accepts the following syntax:
/// </para>
/// <para>
/// - simple forms (e.g. `f81d4fae-7dec-11d0-a765-00a0c91e6bf6`)
/// </para>
/// <para>
/// Note that hyphens are required within the UUID string itself,
/// as per the aforementioned RFC.
/// </para>
/// </summary>

/// <param name="str">
/// a string representing a UUID
/// </param>
/// <return>
/// %TRUE if @str is a valid UUID, %FALSE otherwise.
/// </return>

	public static bool UuidStringIsValid(string str)
	{
		return GLibGlobalFunctionsExterns.g_uuid_string_is_valid(str);
	}

/// <summary>
/// <para>
/// Generates a random UUID (RFC 4122 version 4) as a string. It has the same
/// randomness guarantees as #GRand, so must not be used for cryptographic
/// purposes such as key generation, nonces, salts or one-time pads.
/// </para>
/// </summary>

/// <return>
/// A string that should be freed with g_free().
/// </return>

	public static string UuidStringRandom()
	{
		return GLibGlobalFunctionsExterns.g_uuid_string_random();
	}



	public static MentorLake.GObject.GType VariantGetGtype()
	{
		return GLibGlobalFunctionsExterns.g_variant_get_gtype();
	}

/// <summary>
/// <para>
/// Determines if a given string is a valid D-Bus object path.  You
/// should ensure that a string is a valid D-Bus object path before
/// passing it to g_variant_new_object_path().
/// </para>
/// <para>
/// A valid object path starts with `/` followed by zero or more
/// sequences of characters separated by `/` characters.  Each sequence
/// must contain only the characters `[A-Z][a-z][0-9]_`.  No sequence
/// (including the one following the final `/` character) may be empty.
/// </para>
/// </summary>

/// <param name="@string">
/// a normal C nul-terminated string
/// </param>
/// <return>
/// %TRUE if @string is a D-Bus object path
/// </return>

	public static bool VariantIsObjectPath(string @string)
	{
		return GLibGlobalFunctionsExterns.g_variant_is_object_path(@string);
	}

/// <summary>
/// <para>
/// Determines if a given string is a valid D-Bus type signature.  You
/// should ensure that a string is a valid D-Bus type signature before
/// passing it to g_variant_new_signature().
/// </para>
/// <para>
/// D-Bus type signatures consist of zero or more definite #GVariantType
/// strings in sequence.
/// </para>
/// </summary>

/// <param name="@string">
/// a normal C nul-terminated string
/// </param>
/// <return>
/// %TRUE if @string is a D-Bus type signature
/// </return>

	public static bool VariantIsSignature(string @string)
	{
		return GLibGlobalFunctionsExterns.g_variant_is_signature(@string);
	}

/// <summary>
/// <para>
/// Parses a #GVariant from a text representation.
/// </para>
/// <para>
/// A single #GVariant is parsed from the content of @text.
/// </para>
/// <para>
/// The format is described [here](gvariant-text-format.html).
/// </para>
/// <para>
/// The memory at @limit will never be accessed and the parser behaves as
/// if the character at @limit is the nul terminator.  This has the
/// effect of bounding @text.
/// </para>
/// <para>
/// If @endptr is non-%NULL then @text is permitted to contain data
/// following the value that this function parses and @endptr will be
/// updated to point to the first character past the end of the text
/// parsed by this function.  If @endptr is %NULL and there is extra data
/// then an error is returned.
/// </para>
/// <para>
/// If @type is non-%NULL then the value will be parsed to have that
/// type.  This may result in additional parse errors (in the case that
/// the parsed value doesn&apos;t fit the type) but may also result in fewer
/// errors (in the case that the type would have been ambiguous, such as
/// with empty arrays).
/// </para>
/// <para>
/// In the event that the parsing is successful, the resulting #GVariant
/// is returned. It is never floating, and must be freed with
/// [method@GLib.Variant.unref].
/// </para>
/// <para>
/// In case of any error, %NULL will be returned.  If @error is non-%NULL
/// then it will be set to reflect the error that occurred.
/// </para>
/// <para>
/// Officially, the language understood by the parser is “any string
/// produced by [method@GLib.Variant.print]”. This explicitly includes
/// `g_variant_print()`’s annotated types like `int64 -1000`.
/// </para>
/// <para>
/// There may be implementation specific restrictions on deeply nested values,
/// which would result in a %G_VARIANT_PARSE_ERROR_RECURSION error. #GVariant is
/// guaranteed to handle nesting up to at least 64 levels.
/// </para>
/// </summary>

/// <param name="type">
/// a #GVariantType, or %NULL
/// </param>
/// <param name="text">
/// a string containing a GVariant in text form
/// </param>
/// <param name="limit">
/// a pointer to the end of @text, or %NULL
/// </param>
/// <param name="endptr">
/// a location to store the end pointer, or %NULL
/// </param>
/// <return>
/// a non-floating reference to a #GVariant, or %NULL
/// </return>

	public static MentorLake.GLib.GVariantHandle VariantParse(MentorLake.GLib.GVariantTypeHandle type, string text, string limit, string endptr)
	{
		var externCallResult = GLibGlobalFunctionsExterns.g_variant_parse(type, text, limit, endptr, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Pretty-prints a message showing the context of a #GVariant parse
/// error within the string for which parsing was attempted.
/// </para>
/// <para>
/// The resulting string is suitable for output to the console or other
/// monospace media where newlines are treated in the usual way.
/// </para>
/// <para>
/// The message will typically look something like one of the following:
/// </para>
/// <code>
/// unterminated string constant:
/// unterminated string constant:
///   (1, 2, 3, &apos;abc
///             ^^^^
/// </code>
/// <para>
/// or
/// </para>
/// <code>
/// unable to find a common type:
/// unable to find a common type:
///   [1, 2, 3, &apos;str&apos;]
///    ^        ^^^^^
/// </code>
/// <para>
/// The format of the message may change in a future version.
/// </para>
/// <para>
/// @error must have come from a failed attempt to g_variant_parse() and
/// @source_str must be exactly the same string that caused the error.
/// If @source_str was not nul-terminated when you passed it to
/// g_variant_parse() then you must add nul termination before using this
/// function.
/// </para>
/// </summary>

/// <param name="error">
/// a #GError from the #GVariantParseError domain
/// </param>
/// <param name="source_str">
/// the string that was given to the parser
/// </param>
/// <return>
/// the printed message
/// </return>

	public static string VariantParseErrorPrintContext(MentorLake.GLib.GErrorHandle error, string source_str)
	{
		return GLibGlobalFunctionsExterns.g_variant_parse_error_print_context(error, source_str);
	}



	public static MentorLake.GLib.GQuark VariantParseErrorQuark()
	{
		return GLibGlobalFunctionsExterns.g_variant_parse_error_quark();
	}

/// <summary>
/// <para>
/// Same as g_variant_error_quark().
/// </para>
/// </summary>


	public static MentorLake.GLib.GQuark VariantParserGetErrorQuark()
	{
		return GLibGlobalFunctionsExterns.g_variant_parser_get_error_quark();
	}


/// <param name="type_string">
/// </param>

	public static MentorLake.GLib.GVariantTypeHandle VariantTypeChecked(string type_string)
	{
		return GLibGlobalFunctionsExterns.g_variant_type_checked_(type_string);
	}


/// <param name="type_string">
/// </param>

	public static UIntPtr VariantTypeStringGetDepth(string type_string)
	{
		return GLibGlobalFunctionsExterns.g_variant_type_string_get_depth_(type_string);
	}

/// <summary>
/// <para>
/// Checks if @type_string is a valid
/// [GVariant type string](./struct.VariantType.html#gvariant-type-strings).
/// </para>
/// <para>
/// This call is equivalent to calling [func@GLib.VariantType.string_scan] and
/// confirming that the following character is a nul terminator.
/// </para>
/// </summary>

/// <param name="type_string">
/// a pointer to any string
/// </param>
/// <return>
/// true if @type_string is exactly one valid type string
/// Since 2.24
/// </return>

	public static bool VariantTypeStringIsValid(string type_string)
	{
		return GLibGlobalFunctionsExterns.g_variant_type_string_is_valid(type_string);
	}

/// <summary>
/// <para>
/// Scan for a single complete and valid GVariant type string in @string.
/// </para>
/// <para>
/// The memory pointed to by @limit (or bytes beyond it) is never
/// accessed.
/// </para>
/// <para>
/// If a valid type string is found, @endptr is updated to point to the
/// first character past the end of the string that was found and %TRUE
/// is returned.
/// </para>
/// <para>
/// If there is no valid type string starting at @string, or if the type
/// string does not end before @limit then %FALSE is returned.
/// </para>
/// <para>
/// For the simple case of checking if a string is a valid type string,
/// see [func@GLib.VariantType.string_is_valid].
/// </para>
/// </summary>

/// <param name="@string">
/// a pointer to any string
/// </param>
/// <param name="limit">
/// the end of @string
/// </param>
/// <param name="endptr">
/// location to store the end pointer
/// </param>
/// <return>
/// true if a valid type string was found
/// </return>

	public static bool VariantTypeStringScan(string @string, string limit, out string endptr)
	{
		return GLibGlobalFunctionsExterns.g_variant_type_string_scan(@string, limit, out endptr);
	}

/// <summary>
/// <para>
/// An implementation of the GNU `vasprintf()` function which supports
/// positional parameters, as specified in the Single Unix Specification.
/// This function is similar to [func@GLib.vsprintf], except that it allocates a
/// string to hold the output, instead of putting the output in a buffer
/// you allocate in advance.
/// </para>
/// <para>
/// The returned value in @string is guaranteed to be non-`NULL`, unless
/// @format contains `%lc` or `%ls` conversions, which can fail if no
/// multibyte representation is available for the given character.
/// </para>
/// <para>
/// `glib/gprintf.h` must be explicitly included in order to use this function.
/// </para>
/// </summary>

/// <param name="@string">
/// the return location for the
///   newly-allocated string, which will be `NULL` if (and only if)
///   this function fails
/// </param>
/// <param name="format">
/// a standard `printf()` format string, but notice
///   [string precision pitfalls](string-utils.html#string-precision-pitfalls)
/// </param>
/// <param name="args">
/// the list of arguments to insert in the output
/// </param>
/// <return>
/// the number of bytes printed, or -1 on failure
/// </return>

	public static int Vasprintf(out string @string, string format, IntPtr args)
	{
		return GLibGlobalFunctionsExterns.g_vasprintf(out @string, format, args);
	}

/// <summary>
/// <para>
/// An implementation of the standard `fprintf()` function which supports
/// positional parameters, as specified in the Single Unix Specification.
/// </para>
/// <para>
/// `glib/gprintf.h` must be explicitly included in order to use this function.
/// </para>
/// </summary>

/// <param name="file">
/// the stream to write to
/// </param>
/// <param name="format">
/// a standard `printf()` format string, but notice
///   [string precision pitfalls](string-utils.html#string-precision-pitfalls)
/// </param>
/// <param name="args">
/// the list of arguments to insert in the output
/// </param>
/// <return>
/// the number of bytes printed
/// </return>

	public static int Vfprintf(IntPtr file, string format, IntPtr args)
	{
		return GLibGlobalFunctionsExterns.g_vfprintf(file, format, args);
	}

/// <summary>
/// <para>
/// An implementation of the standard `vprintf()` function which supports
/// positional parameters, as specified in the Single Unix Specification.
/// </para>
/// <para>
/// `glib/gprintf.h` must be explicitly included in order to use this function.
/// </para>
/// </summary>

/// <param name="format">
/// a standard `printf()` format string, but notice
///   [string precision pitfalls](string-utils.html#string-precision-pitfalls)
/// </param>
/// <param name="args">
/// the list of arguments to insert in the output
/// </param>
/// <return>
/// the number of bytes printed
/// </return>

	public static int Vprintf(string format, IntPtr args)
	{
		return GLibGlobalFunctionsExterns.g_vprintf(format, args);
	}

/// <summary>
/// <para>
/// A safer form of the standard `vsprintf()` function. The output is guaranteed
/// to not exceed @n characters (including the terminating nul character), so
/// it is easy to ensure that a buffer overflow cannot occur.
/// </para>
/// <para>
/// See also [func@GLib.strdup_vprintf].
/// </para>
/// <para>
/// In versions of GLib prior to 1.2.3, this function may return -1 if the
/// output was truncated, and the truncated string may not be nul-terminated.
/// In versions prior to 1.3.12, this function returns the length of the output
/// string.
/// </para>
/// <para>
/// The return value of `g_vsnprintf()` conforms to the `vsnprintf()` function
/// as standardized in ISO C99. Note that this is different from traditional
/// `vsnprintf()`, which returns the length of the output string.
/// </para>
/// <para>
/// The format string may contain positional parameters, as specified in
/// the Single Unix Specification.
/// </para>
/// </summary>

/// <param name="@string">
/// the buffer to hold the output
/// </param>
/// <param name="n">
/// the maximum number of bytes to produce (including the
///   terminating nul character)
/// </param>
/// <param name="format">
/// a standard `printf()` format string, but notice
///   [string precision pitfalls](string-utils.html#string-precision-pitfalls)
/// </param>
/// <param name="args">
/// the list of arguments to insert in the output
/// </param>
/// <return>
/// the number of bytes which would be produced if the buffer
///  was large enough
/// </return>

	public static int Vsnprintf(string @string, ulong n, string format, IntPtr args)
	{
		return GLibGlobalFunctionsExterns.g_vsnprintf(@string, n, format, args);
	}

/// <summary>
/// <para>
/// An implementation of the standard `vsprintf()` function which supports
/// positional parameters, as specified in the Single Unix Specification.
/// </para>
/// <para>
/// `glib/gprintf.h` must be explicitly included in order to use this function.
/// </para>
/// </summary>

/// <param name="@string">
/// the buffer to hold the output
/// </param>
/// <param name="format">
/// a standard `printf()` format string, but notice
///   [string precision pitfalls](string-utils.html#string-precision-pitfalls)
/// </param>
/// <param name="args">
/// the list of arguments to insert in the output
/// </param>
/// <return>
/// the number of bytes printed
/// </return>

	public static int Vsprintf(string @string, string format, IntPtr args)
	{
		return GLibGlobalFunctionsExterns.g_vsprintf(@string, format, args);
	}

/// <summary>
/// <para>
/// Internal function used to print messages from the public [func@GLib.warn_if_reached]
/// and [func@GLib.warn_if_fail] macros.
/// </para>
/// </summary>

/// <param name="domain">
/// log domain
/// </param>
/// <param name="file">
/// file containing the warning
/// </param>
/// <param name="line">
/// line number of the warning
/// </param>
/// <param name="func">
/// function containing the warning
/// </param>
/// <param name="warnexpr">
/// expression which failed
/// </param>

	public static void WarnMessage(string domain, string file, int line, string func, string warnexpr)
	{
		GLibGlobalFunctionsExterns.g_warn_message(domain, file, line, func, warnexpr);
	}

}

internal class GLibGlobalFunctionsExterns
{
	[DllImport(GLibLibrary.Name)]
	internal static extern int g_access(string filename, int mode);

	[DllImport(GLibLibrary.Name)]
	internal static extern IntPtr g_aligned_alloc(UIntPtr n_blocks, UIntPtr n_block_bytes, UIntPtr alignment);

	[DllImport(GLibLibrary.Name)]
	internal static extern IntPtr g_aligned_alloc0(UIntPtr n_blocks, UIntPtr n_block_bytes, UIntPtr alignment);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_aligned_free(IntPtr mem);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_aligned_free_sized(IntPtr mem, UIntPtr alignment, UIntPtr size);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GArrayHandle>))]
	internal static extern MentorLake.GLib.GArrayHandle g_array_new_take(IntPtr[] data, UIntPtr len, bool clear, UIntPtr element_size);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GArrayHandle>))]
	internal static extern MentorLake.GLib.GArrayHandle g_array_new_take_zero_terminated(IntPtr[] data, bool clear, UIntPtr element_size);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_ascii_digit_value(char c);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_ascii_dtostr(string buffer, int buf_len, double d);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_ascii_formatd(string buffer, int buf_len, string format, double d);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_ascii_strcasecmp(string s1, string s2);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_ascii_strdown(string str, UIntPtr len);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_ascii_string_to_signed(string str, uint @base, long min, long max, out long out_num, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_ascii_string_to_unsigned(string str, uint @base, ulong min, ulong max, out ulong out_num, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_ascii_strncasecmp(string s1, string s2, UIntPtr n);

	[DllImport(GLibLibrary.Name)]
	internal static extern double g_ascii_strtod(string nptr, out string endptr);

	[DllImport(GLibLibrary.Name)]
	internal static extern long g_ascii_strtoll(string nptr, out string endptr, uint @base);

	[DllImport(GLibLibrary.Name)]
	internal static extern ulong g_ascii_strtoull(string nptr, out string endptr, uint @base);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_ascii_strup(string str, UIntPtr len);

	[DllImport(GLibLibrary.Name)]
	internal static extern char g_ascii_tolower(char c);

	[DllImport(GLibLibrary.Name)]
	internal static extern char g_ascii_toupper(char c);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_ascii_xdigit_value(char c);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_assert_warning(string log_domain, string file, int line, string pretty_function, string expression);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_assertion_message(string domain, string file, int line, string func, string message);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_assertion_message_cmpint(string domain, string file, int line, string func, string expr, ulong arg1, string cmp, ulong arg2, char numtype);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_assertion_message_cmpnum(string domain, string file, int line, string func, string expr, long arg1, string cmp, long arg2, char numtype);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_assertion_message_cmpstr(string domain, string file, int line, string func, string expr, string arg1, string cmp, string arg2);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_assertion_message_cmpstrv(string domain, string file, int line, string func, string expr, string arg1, string arg2, UIntPtr first_wrong_idx);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_assertion_message_error(string domain, string file, int line, string func, string expr, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GErrorHandle>))] MentorLake.GLib.GErrorHandle error, MentorLake.GLib.GQuark error_domain, int error_code);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_assertion_message_expr(string domain, string file, int line, string func, string expr);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GAsyncQueueHandle>))]
	internal static extern MentorLake.GLib.GAsyncQueueHandle g_async_queue_new();

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GAsyncQueueHandle>))]
	internal static extern MentorLake.GLib.GAsyncQueueHandle g_async_queue_new_full(MentorLake.GLib.GDestroyNotify item_free_func);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_atexit(MentorLake.GLib.GVoidFunc func);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_atomic_int_add(int atomic, int val);

	[DllImport(GLibLibrary.Name)]
	internal static extern uint g_atomic_int_and(uint atomic, uint val);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_atomic_int_compare_and_exchange(int atomic, int oldval, int newval);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_atomic_int_compare_and_exchange_full(int atomic, int oldval, int newval, out int preval);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_atomic_int_dec_and_test(int atomic);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_atomic_int_exchange(int atomic, int newval);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_atomic_int_exchange_and_add(int atomic, int val);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_atomic_int_get(int atomic);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_atomic_int_inc(int atomic);

	[DllImport(GLibLibrary.Name)]
	internal static extern uint g_atomic_int_or(uint atomic, uint val);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_atomic_int_set(int atomic, int newval);

	[DllImport(GLibLibrary.Name)]
	internal static extern uint g_atomic_int_xor(uint atomic, uint val);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_atomic_pointer_add(IntPtr atomic, UIntPtr val);

	[DllImport(GLibLibrary.Name)]
	internal static extern uint g_atomic_pointer_and(IntPtr atomic, UIntPtr val);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_atomic_pointer_compare_and_exchange(IntPtr atomic, IntPtr oldval, IntPtr newval);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_atomic_pointer_compare_and_exchange_full(IntPtr atomic, IntPtr oldval, IntPtr newval, out IntPtr preval);

	[DllImport(GLibLibrary.Name)]
	internal static extern IntPtr g_atomic_pointer_exchange(IntPtr atomic, IntPtr newval);

	[DllImport(GLibLibrary.Name)]
	internal static extern IntPtr g_atomic_pointer_get(IntPtr atomic);

	[DllImport(GLibLibrary.Name)]
	internal static extern uint g_atomic_pointer_or(IntPtr atomic, UIntPtr val);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_atomic_pointer_set(IntPtr atomic, IntPtr newval);

	[DllImport(GLibLibrary.Name)]
	internal static extern uint g_atomic_pointer_xor(IntPtr atomic, UIntPtr val);

	[DllImport(GLibLibrary.Name)]
	internal static extern IntPtr g_atomic_rc_box_acquire(IntPtr mem_block);

	[DllImport(GLibLibrary.Name)]
	internal static extern IntPtr g_atomic_rc_box_alloc(UIntPtr block_size);

	[DllImport(GLibLibrary.Name)]
	internal static extern IntPtr g_atomic_rc_box_alloc0(UIntPtr block_size);

	[DllImport(GLibLibrary.Name)]
	internal static extern IntPtr g_atomic_rc_box_dup(UIntPtr block_size, IntPtr mem_block);

	[DllImport(GLibLibrary.Name)]
	internal static extern UIntPtr g_atomic_rc_box_get_size(IntPtr mem_block);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_atomic_rc_box_release(IntPtr mem_block);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_atomic_rc_box_release_full(IntPtr mem_block, MentorLake.GLib.GDestroyNotify clear_func);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_atomic_ref_count_compare(int arc, int val);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_atomic_ref_count_dec(int arc);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_atomic_ref_count_inc(int arc);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_atomic_ref_count_init(int arc);

	[DllImport(GLibLibrary.Name)]
	internal static extern byte[] g_base64_decode(string text, out UIntPtr out_len);

	[DllImport(GLibLibrary.Name)]
	internal static extern byte g_base64_decode_inplace(ref byte[] text, ref UIntPtr out_len);

	[DllImport(GLibLibrary.Name)]
	internal static extern UIntPtr g_base64_decode_step(byte[] @in, UIntPtr len, [MarshalAs(UnmanagedType.LPArray)] out byte[] @out, ref int state, ref uint save);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_base64_encode(byte[] data, UIntPtr len);

	[DllImport(GLibLibrary.Name)]
	internal static extern UIntPtr g_base64_encode_close(bool break_lines, [MarshalAs(UnmanagedType.LPArray)] out byte[] @out, ref int state, ref int save);

	[DllImport(GLibLibrary.Name)]
	internal static extern UIntPtr g_base64_encode_step(byte[] @in, UIntPtr len, bool break_lines, [MarshalAs(UnmanagedType.LPArray)] out byte[] @out, ref int state, ref int save);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_basename(string file_name);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_bit_lock(int address, int lock_bit);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_bit_nth_lsf(ulong mask, int nth_bit);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_bit_nth_msf(ulong mask, int nth_bit);

	[DllImport(GLibLibrary.Name)]
	internal static extern uint g_bit_storage(ulong number);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_bit_trylock(int address, int lock_bit);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_bit_unlock(int address, int lock_bit);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_blow_chunks();

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GQuark g_bookmark_file_error_quark();

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_build_filename(string first_element, IntPtr @__arglist);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_build_filename_valist(string first_element, IntPtr args);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_build_filenamev(string[] args);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_build_path(string separator, string first_element, IntPtr @__arglist);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_build_pathv(string separator, string[] args);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GByteArrayHandle>))]
	internal static extern MentorLake.GLib.GByteArrayHandle g_byte_array_append([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GByteArrayHandle>))] MentorLake.GLib.GByteArrayHandle array, byte data, uint len);

	[DllImport(GLibLibrary.Name)]
	internal static extern byte g_byte_array_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GByteArrayHandle>))] MentorLake.GLib.GByteArrayHandle array, bool free_segment);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBytesHandle>))]
	internal static extern MentorLake.GLib.GBytesHandle g_byte_array_free_to_bytes([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GByteArrayHandle>))] MentorLake.GLib.GByteArrayHandle array);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GByteArrayHandle>))]
	internal static extern MentorLake.GLib.GByteArrayHandle g_byte_array_new();

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GByteArrayHandle>))]
	internal static extern MentorLake.GLib.GByteArrayHandle g_byte_array_new_take(byte[] data, UIntPtr len);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GByteArrayHandle>))]
	internal static extern MentorLake.GLib.GByteArrayHandle g_byte_array_prepend([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GByteArrayHandle>))] MentorLake.GLib.GByteArrayHandle array, byte data, uint len);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GByteArrayHandle>))]
	internal static extern MentorLake.GLib.GByteArrayHandle g_byte_array_ref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GByteArrayHandle>))] MentorLake.GLib.GByteArrayHandle array);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GByteArrayHandle>))]
	internal static extern MentorLake.GLib.GByteArrayHandle g_byte_array_remove_index([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GByteArrayHandle>))] MentorLake.GLib.GByteArrayHandle array, uint index_);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GByteArrayHandle>))]
	internal static extern MentorLake.GLib.GByteArrayHandle g_byte_array_remove_index_fast([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GByteArrayHandle>))] MentorLake.GLib.GByteArrayHandle array, uint index_);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GByteArrayHandle>))]
	internal static extern MentorLake.GLib.GByteArrayHandle g_byte_array_remove_range([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GByteArrayHandle>))] MentorLake.GLib.GByteArrayHandle array, uint index_, uint length);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GByteArrayHandle>))]
	internal static extern MentorLake.GLib.GByteArrayHandle g_byte_array_set_size([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GByteArrayHandle>))] MentorLake.GLib.GByteArrayHandle array, uint length);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GByteArrayHandle>))]
	internal static extern MentorLake.GLib.GByteArrayHandle g_byte_array_sized_new(uint reserved_size);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_byte_array_sort([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GByteArrayHandle>))] MentorLake.GLib.GByteArrayHandle array, MentorLake.GLib.GCompareFunc compare_func);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_byte_array_sort_with_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GByteArrayHandle>))] MentorLake.GLib.GByteArrayHandle array, MentorLake.GLib.GCompareDataFunc compare_func, IntPtr user_data);

	[DllImport(GLibLibrary.Name)]
	internal static extern byte g_byte_array_steal([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GByteArrayHandle>))] MentorLake.GLib.GByteArrayHandle array, out UIntPtr len);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_byte_array_unref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GByteArrayHandle>))] MentorLake.GLib.GByteArrayHandle array);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_canonicalize_filename(string filename, string relative_to);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_chdir(string path);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string glib_check_version(uint required_major, uint required_minor, uint required_micro);

	[DllImport(GLibLibrary.Name)]
	internal static extern UIntPtr g_checksum_type_get_length(MentorLake.GLib.GChecksumType checksum_type);

	[DllImport(GLibLibrary.Name)]
	internal static extern uint g_child_watch_add(MentorLake.GLib.GPid pid, MentorLake.GLib.GChildWatchFunc function, IntPtr data);

	[DllImport(GLibLibrary.Name)]
	internal static extern uint g_child_watch_add_full(int priority, MentorLake.GLib.GPid pid, MentorLake.GLib.GChildWatchFunc function, IntPtr data, MentorLake.GLib.GDestroyNotify notify);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSourceHandle>))]
	internal static extern MentorLake.GLib.GSourceHandle g_child_watch_source_new(MentorLake.GLib.GPid pid);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_chmod(string filename, int mode);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_clear_error(out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_clear_handle_id(uint tag_ptr, MentorLake.GLib.GClearHandleFunc clear_func);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_clear_list(IntPtr list_ptr, MentorLake.GLib.GDestroyNotify destroy);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_clear_pointer(ref IntPtr pp, MentorLake.GLib.GDestroyNotify destroy);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_clear_slist(IntPtr slist_ptr, MentorLake.GLib.GDestroyNotify destroy);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_close(int fd, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_closefrom(int lowfd);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_compute_checksum_for_bytes(MentorLake.GLib.GChecksumType checksum_type, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBytesHandle>))] MentorLake.GLib.GBytesHandle data);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_compute_checksum_for_data(MentorLake.GLib.GChecksumType checksum_type, byte[] data, UIntPtr length);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_compute_checksum_for_string(MentorLake.GLib.GChecksumType checksum_type, string str, UIntPtr length);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_compute_hmac_for_bytes(MentorLake.GLib.GChecksumType digest_type, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBytesHandle>))] MentorLake.GLib.GBytesHandle key, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBytesHandle>))] MentorLake.GLib.GBytesHandle data);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_compute_hmac_for_data(MentorLake.GLib.GChecksumType digest_type, byte[] key, UIntPtr key_len, byte[] data, UIntPtr length);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_compute_hmac_for_string(MentorLake.GLib.GChecksumType digest_type, byte[] key, UIntPtr key_len, string str, UIntPtr length);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GCondHandle>))]
	internal static extern MentorLake.GLib.GCondHandle g_cond_new();

	[DllImport(GLibLibrary.Name)]
	internal static extern byte[] g_convert(byte[] str, UIntPtr len, string to_codeset, string from_codeset, out UIntPtr bytes_read, out UIntPtr bytes_written, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GQuark g_convert_error_quark();

	[DllImport(GLibLibrary.Name)]
	internal static extern byte[] g_convert_with_fallback(byte[] str, UIntPtr len, string to_codeset, string from_codeset, string fallback, out UIntPtr bytes_read, out UIntPtr bytes_written, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	internal static extern byte[] g_convert_with_iconv(byte[] str, UIntPtr len, MentorLake.GLib.GIConv converter, out UIntPtr bytes_read, out UIntPtr bytes_written, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_creat(string filename, int mode);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_datalist_clear(IntPtr datalist);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_datalist_foreach(IntPtr datalist, MentorLake.GLib.GDataForeachFunc func, IntPtr user_data);

	[DllImport(GLibLibrary.Name)]
	internal static extern IntPtr g_datalist_get_data(IntPtr datalist, string key);

	[DllImport(GLibLibrary.Name)]
	internal static extern uint g_datalist_get_flags(IntPtr datalist);

	[DllImport(GLibLibrary.Name)]
	internal static extern IntPtr g_datalist_id_dup_data(IntPtr datalist, MentorLake.GLib.GQuark key_id, MentorLake.GLib.GDuplicateFunc dup_func, IntPtr user_data);

	[DllImport(GLibLibrary.Name)]
	internal static extern IntPtr g_datalist_id_get_data(IntPtr datalist, MentorLake.GLib.GQuark key_id);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_datalist_id_remove_multiple(IntPtr datalist, MentorLake.GLib.GQuark[] keys, UIntPtr n_keys);

	[DllImport(GLibLibrary.Name)]
	internal static extern IntPtr g_datalist_id_remove_no_notify(IntPtr datalist, MentorLake.GLib.GQuark key_id);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_datalist_id_replace_data(IntPtr datalist, MentorLake.GLib.GQuark key_id, IntPtr oldval, IntPtr newval, MentorLake.GLib.GDestroyNotify destroy, out MentorLake.GLib.GDestroyNotify old_destroy);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_datalist_id_set_data_full(IntPtr datalist, MentorLake.GLib.GQuark key_id, IntPtr data, MentorLake.GLib.GDestroyNotify destroy_func);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_datalist_init(IntPtr datalist);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_datalist_set_flags(IntPtr datalist, uint flags);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_datalist_unset_flags(IntPtr datalist, uint flags);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_dataset_destroy(IntPtr dataset_location);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_dataset_foreach(IntPtr dataset_location, MentorLake.GLib.GDataForeachFunc func, IntPtr user_data);

	[DllImport(GLibLibrary.Name)]
	internal static extern IntPtr g_dataset_id_get_data(IntPtr dataset_location, MentorLake.GLib.GQuark key_id);

	[DllImport(GLibLibrary.Name)]
	internal static extern IntPtr g_dataset_id_remove_no_notify(IntPtr dataset_location, MentorLake.GLib.GQuark key_id);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_dataset_id_set_data_full(IntPtr dataset_location, MentorLake.GLib.GQuark key_id, IntPtr data, MentorLake.GLib.GDestroyNotify destroy_func);

	[DllImport(GLibLibrary.Name)]
	internal static extern byte g_date_get_days_in_month(MentorLake.GLib.GDateMonth month, MentorLake.GLib.GDateYear year);

	[DllImport(GLibLibrary.Name)]
	internal static extern byte g_date_get_monday_weeks_in_year(MentorLake.GLib.GDateYear year);

	[DllImport(GLibLibrary.Name)]
	internal static extern byte g_date_get_sunday_weeks_in_year(MentorLake.GLib.GDateYear year);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_date_is_leap_year(MentorLake.GLib.GDateYear year);

	[DllImport(GLibLibrary.Name)]
	internal static extern UIntPtr g_date_strftime(string s, UIntPtr slen, string format, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateHandle>))] MentorLake.GLib.GDateHandle date);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_date_valid_day(MentorLake.GLib.GDateDay day);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_date_valid_dmy(MentorLake.GLib.GDateDay day, MentorLake.GLib.GDateMonth month, MentorLake.GLib.GDateYear year);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_date_valid_julian(uint julian_date);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_date_valid_month(MentorLake.GLib.GDateMonth month);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_date_valid_weekday(MentorLake.GLib.GDateWeekday weekday);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_date_valid_year(MentorLake.GLib.GDateYear year);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_dcgettext(string domain, string msgid, int category);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_dgettext(string domain, string msgid);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_dir_make_tmp(string tmpl, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_direct_equal(IntPtr v1, IntPtr v2);

	[DllImport(GLibLibrary.Name)]
	internal static extern uint g_direct_hash(IntPtr v);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_dngettext(string domain, string msgid, string msgid_plural, ulong n);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_double_equal(IntPtr v1, IntPtr v2);

	[DllImport(GLibLibrary.Name)]
	internal static extern uint g_double_hash(IntPtr v);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_dpgettext(string domain, string msgctxtid, UIntPtr msgidoffset);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_dpgettext2(string domain, string context, string msgid);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_environ_getenv(string[] envp, string variable);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ReadNullTerminatedArrayMarshaller<NoNativeFreeStringMarshaller, string>))]
	internal static extern string[] g_environ_setenv(string[] envp, string variable, string value, bool overwrite);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ReadNullTerminatedArrayMarshaller<NoNativeFreeStringMarshaller, string>))]
	internal static extern string[] g_environ_unsetenv(string[] envp, string variable);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GQuark g_error_domain_register(string error_type_name, UIntPtr error_type_private_size, MentorLake.GLib.GErrorInitFunc error_type_init, MentorLake.GLib.GErrorCopyFunc error_type_copy, MentorLake.GLib.GErrorClearFunc error_type_clear);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GQuark g_error_domain_register_static(string error_type_name, UIntPtr error_type_private_size, MentorLake.GLib.GErrorInitFunc error_type_init, MentorLake.GLib.GErrorCopyFunc error_type_copy, MentorLake.GLib.GErrorClearFunc error_type_clear);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_fdwalk_set_cloexec(int lowfd);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GFileError g_file_error_from_errno(int err_no);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GQuark g_file_error_quark();

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_file_get_contents(string filename, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] out byte[] contents, out UIntPtr length, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_file_open_tmp(string tmpl, out string name_used, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_file_read_link(string filename, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_file_set_contents(string filename, byte[] contents, UIntPtr length, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_file_set_contents_full(string filename, byte[] contents, UIntPtr length, MentorLake.GLib.GFileSetContentsFlags flags, int mode, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_file_test(string filename, MentorLake.GLib.GFileTest test);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_filename_display_basename(string filename);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_filename_display_name(string filename);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_filename_from_uri(string uri, out string hostname, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_filename_from_utf8(string utf8string, UIntPtr len, out UIntPtr bytes_read, out UIntPtr bytes_written, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_filename_to_uri(string filename, string hostname, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_filename_to_utf8(string opsysstring, UIntPtr len, out UIntPtr bytes_read, out UIntPtr bytes_written, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_find_program_in_path(string program);

	[DllImport(GLibLibrary.Name)]
	internal static extern IntPtr g_fopen(string filename, string mode);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_format_size(ulong size);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_format_size_for_display(int size);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_format_size_full(ulong size, MentorLake.GLib.GFormatSizeFlags flags);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_fprintf(IntPtr file, string format, IntPtr @__arglist);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_free(IntPtr mem);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_free_sized(IntPtr mem, UIntPtr size);

	[DllImport(GLibLibrary.Name)]
	internal static extern IntPtr g_freopen(string filename, string mode, IntPtr stream);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_fsync(int fd);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_get_application_name();

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_get_charset(out string charset);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_get_codeset();

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_get_console_charset(out string charset);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_get_current_dir();

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_get_current_time([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GTimeValHandle>))] MentorLake.GLib.GTimeValHandle result);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ReadNullTerminatedArrayMarshaller<NoNativeFreeStringMarshaller, string>))]
	internal static extern string[] g_get_environ();

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_get_filename_charsets([MarshalAs(UnmanagedType.LPArray)] out string[] filename_charsets);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_get_home_dir();

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_get_host_name();

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ReadNullTerminatedArrayMarshaller<NoNativeFreeStringMarshaller, string>))]
	internal static extern string[] g_get_language_names();

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ReadNullTerminatedArrayMarshaller<NoNativeFreeStringMarshaller, string>))]
	internal static extern string[] g_get_language_names_with_category(string category_name);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ReadNullTerminatedArrayMarshaller<NoNativeFreeStringMarshaller, string>))]
	internal static extern string[] g_get_locale_variants(string locale);

	[DllImport(GLibLibrary.Name)]
	internal static extern long g_get_monotonic_time();

	[DllImport(GLibLibrary.Name)]
	internal static extern uint g_get_num_processors();

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_get_os_info(string key_name);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_get_prgname();

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_get_real_name();

	[DllImport(GLibLibrary.Name)]
	internal static extern long g_get_real_time();

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ReadNullTerminatedArrayMarshaller<NoNativeFreeStringMarshaller, string>))]
	internal static extern string[] g_get_system_config_dirs();

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ReadNullTerminatedArrayMarshaller<NoNativeFreeStringMarshaller, string>))]
	internal static extern string[] g_get_system_data_dirs();

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_get_tmp_dir();

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_get_user_cache_dir();

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_get_user_config_dir();

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_get_user_data_dir();

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_get_user_name();

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_get_user_runtime_dir();

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_get_user_special_dir(MentorLake.GLib.GUserDirectory directory);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_get_user_state_dir();

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_getenv(string variable);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_hash_table_add([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHashTableHandle>))] MentorLake.GLib.GHashTableHandle hash_table, IntPtr key);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_hash_table_contains([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHashTableHandle>))] MentorLake.GLib.GHashTableHandle hash_table, IntPtr key);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_hash_table_destroy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHashTableHandle>))] MentorLake.GLib.GHashTableHandle hash_table);

	[DllImport(GLibLibrary.Name)]
	internal static extern IntPtr g_hash_table_find([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHashTableHandle>))] MentorLake.GLib.GHashTableHandle hash_table, MentorLake.GLib.GHRFunc predicate, IntPtr user_data);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_hash_table_foreach([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHashTableHandle>))] MentorLake.GLib.GHashTableHandle hash_table, MentorLake.GLib.GHFunc func, IntPtr user_data);

	[DllImport(GLibLibrary.Name)]
	internal static extern uint g_hash_table_foreach_remove([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHashTableHandle>))] MentorLake.GLib.GHashTableHandle hash_table, MentorLake.GLib.GHRFunc func, IntPtr user_data);

	[DllImport(GLibLibrary.Name)]
	internal static extern uint g_hash_table_foreach_steal([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHashTableHandle>))] MentorLake.GLib.GHashTableHandle hash_table, MentorLake.GLib.GHRFunc func, IntPtr user_data);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GPtrArrayHandle>))]
	internal static extern MentorLake.GLib.GPtrArrayHandle g_hash_table_get_keys_as_ptr_array([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHashTableHandle>))] MentorLake.GLib.GHashTableHandle hash_table);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GPtrArrayHandle>))]
	internal static extern MentorLake.GLib.GPtrArrayHandle g_hash_table_get_values_as_ptr_array([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHashTableHandle>))] MentorLake.GLib.GHashTableHandle hash_table);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_hash_table_insert([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHashTableHandle>))] MentorLake.GLib.GHashTableHandle hash_table, IntPtr key, IntPtr value);

	[DllImport(GLibLibrary.Name)]
	internal static extern IntPtr g_hash_table_lookup([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHashTableHandle>))] MentorLake.GLib.GHashTableHandle hash_table, IntPtr key);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_hash_table_lookup_extended([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHashTableHandle>))] MentorLake.GLib.GHashTableHandle hash_table, IntPtr lookup_key, out IntPtr orig_key, out IntPtr value);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHashTableHandle>))]
	internal static extern MentorLake.GLib.GHashTableHandle g_hash_table_new_similar([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHashTableHandle>))] MentorLake.GLib.GHashTableHandle other_hash_table);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHashTableHandle>))]
	internal static extern MentorLake.GLib.GHashTableHandle g_hash_table_ref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHashTableHandle>))] MentorLake.GLib.GHashTableHandle hash_table);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_hash_table_remove([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHashTableHandle>))] MentorLake.GLib.GHashTableHandle hash_table, IntPtr key);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_hash_table_remove_all([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHashTableHandle>))] MentorLake.GLib.GHashTableHandle hash_table);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_hash_table_replace([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHashTableHandle>))] MentorLake.GLib.GHashTableHandle hash_table, IntPtr key, IntPtr value);

	[DllImport(GLibLibrary.Name)]
	internal static extern uint g_hash_table_size([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHashTableHandle>))] MentorLake.GLib.GHashTableHandle hash_table);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_hash_table_steal([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHashTableHandle>))] MentorLake.GLib.GHashTableHandle hash_table, IntPtr key);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_hash_table_steal_all([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHashTableHandle>))] MentorLake.GLib.GHashTableHandle hash_table);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GPtrArrayHandle>))]
	internal static extern MentorLake.GLib.GPtrArrayHandle g_hash_table_steal_all_keys([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHashTableHandle>))] MentorLake.GLib.GHashTableHandle hash_table);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GPtrArrayHandle>))]
	internal static extern MentorLake.GLib.GPtrArrayHandle g_hash_table_steal_all_values([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHashTableHandle>))] MentorLake.GLib.GHashTableHandle hash_table);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_hash_table_steal_extended([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHashTableHandle>))] MentorLake.GLib.GHashTableHandle hash_table, IntPtr lookup_key, out IntPtr stolen_key, out IntPtr stolen_value);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_hash_table_unref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHashTableHandle>))] MentorLake.GLib.GHashTableHandle hash_table);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_hook_destroy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHookListHandle>))] MentorLake.GLib.GHookListHandle hook_list, ulong hook_id);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_hook_destroy_link([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHookListHandle>))] MentorLake.GLib.GHookListHandle hook_list, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHookHandle>))] MentorLake.GLib.GHookHandle hook);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_hook_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHookListHandle>))] MentorLake.GLib.GHookListHandle hook_list, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHookHandle>))] MentorLake.GLib.GHookHandle hook);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_hook_insert_before([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHookListHandle>))] MentorLake.GLib.GHookListHandle hook_list, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHookHandle>))] MentorLake.GLib.GHookHandle sibling, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHookHandle>))] MentorLake.GLib.GHookHandle hook);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_hook_insert_sorted([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHookListHandle>))] MentorLake.GLib.GHookListHandle hook_list, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHookHandle>))] MentorLake.GLib.GHookHandle hook, MentorLake.GLib.GHookCompareFunc func);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_hook_prepend([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHookListHandle>))] MentorLake.GLib.GHookListHandle hook_list, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHookHandle>))] MentorLake.GLib.GHookHandle hook);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_hook_unref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHookListHandle>))] MentorLake.GLib.GHookListHandle hook_list, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHookHandle>))] MentorLake.GLib.GHookHandle hook);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_hostname_is_ascii_encoded(string hostname);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_hostname_is_ip_address(string hostname);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_hostname_is_non_ascii(string hostname);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_hostname_to_ascii(string hostname);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_hostname_to_unicode(string hostname);

	[DllImport(GLibLibrary.Name)]
	internal static extern UIntPtr g_iconv(MentorLake.GLib.GIConv converter, string inbuf, ref UIntPtr inbytes_left, string outbuf, ref UIntPtr outbytes_left);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GIConv g_iconv_open(string to_codeset, string from_codeset);

	[DllImport(GLibLibrary.Name)]
	internal static extern uint g_idle_add(MentorLake.GLib.GSourceFunc function, IntPtr data);

	[DllImport(GLibLibrary.Name)]
	internal static extern uint g_idle_add_full(int priority, MentorLake.GLib.GSourceFunc function, IntPtr data, MentorLake.GLib.GDestroyNotify notify);

	[DllImport(GLibLibrary.Name)]
	internal static extern uint g_idle_add_once(MentorLake.GLib.GSourceOnceFunc function, IntPtr data);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_idle_remove_by_data(IntPtr data);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSourceHandle>))]
	internal static extern MentorLake.GLib.GSourceHandle g_idle_source_new();

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_int64_equal(IntPtr v1, IntPtr v2);

	[DllImport(GLibLibrary.Name)]
	internal static extern uint g_int64_hash(IntPtr v);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_int_equal(IntPtr v1, IntPtr v2);

	[DllImport(GLibLibrary.Name)]
	internal static extern uint g_int_hash(IntPtr v);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_intern_static_string(string @string);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_intern_string(string @string);

	[DllImport(GLibLibrary.Name)]
	internal static extern uint g_io_add_watch([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GIOChannelHandle>))] MentorLake.GLib.GIOChannelHandle channel, MentorLake.GLib.GIOCondition condition, MentorLake.GLib.GIOFunc func, IntPtr user_data);

	[DllImport(GLibLibrary.Name)]
	internal static extern uint g_io_add_watch_full([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GIOChannelHandle>))] MentorLake.GLib.GIOChannelHandle channel, int priority, MentorLake.GLib.GIOCondition condition, MentorLake.GLib.GIOFunc func, IntPtr user_data, MentorLake.GLib.GDestroyNotify notify);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GIOChannelError g_io_channel_error_from_errno(int en);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GQuark g_io_channel_error_quark();

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSourceHandle>))]
	internal static extern MentorLake.GLib.GSourceHandle g_io_create_watch([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GIOChannelHandle>))] MentorLake.GLib.GIOChannelHandle channel, MentorLake.GLib.GIOCondition condition);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GQuark g_key_file_error_quark();

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_list_pop_allocator();

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_list_push_allocator([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GAllocatorHandle>))] MentorLake.GLib.GAllocatorHandle allocator);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ReadNullTerminatedArrayMarshaller<NoNativeFreeStringMarshaller, string>))]
	internal static extern string[] g_listenv();

	[DllImport(GLibLibrary.Name)]
	internal static extern byte[] g_locale_from_utf8(string utf8string, UIntPtr len, out UIntPtr bytes_read, out UIntPtr bytes_written, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_locale_to_utf8(byte[] opsysstring, UIntPtr len, out UIntPtr bytes_read, out UIntPtr bytes_written, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_log(string log_domain, MentorLake.GLib.GLogLevelFlags log_level, string format, IntPtr @__arglist);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_log_default_handler(string log_domain, MentorLake.GLib.GLogLevelFlags log_level, string message, IntPtr unused_data);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_log_get_debug_enabled();

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_log_remove_handler(string log_domain, uint handler_id);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GLogLevelFlags g_log_set_always_fatal(MentorLake.GLib.GLogLevelFlags fatal_mask);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_log_set_debug_enabled(bool enabled);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GLogFunc g_log_set_default_handler(MentorLake.GLib.GLogFunc log_func, IntPtr user_data);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GLogLevelFlags g_log_set_fatal_mask(string log_domain, MentorLake.GLib.GLogLevelFlags fatal_mask);

	[DllImport(GLibLibrary.Name)]
	internal static extern uint g_log_set_handler(string log_domain, MentorLake.GLib.GLogLevelFlags log_levels, MentorLake.GLib.GLogFunc log_func, IntPtr user_data);

	[DllImport(GLibLibrary.Name)]
	internal static extern uint g_log_set_handler_full(string log_domain, MentorLake.GLib.GLogLevelFlags log_levels, MentorLake.GLib.GLogFunc log_func, IntPtr user_data, MentorLake.GLib.GDestroyNotify destroy);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_log_set_writer_func(MentorLake.GLib.GLogWriterFunc func, IntPtr user_data, MentorLake.GLib.GDestroyNotify user_data_free);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_log_structured(string log_domain, MentorLake.GLib.GLogLevelFlags log_level, IntPtr @__arglist);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_log_structured_array(MentorLake.GLib.GLogLevelFlags log_level, MentorLake.GLib.GLogField[] fields, UIntPtr n_fields);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_log_structured_standard(string log_domain, MentorLake.GLib.GLogLevelFlags log_level, string file, string line, string func, string message_format, IntPtr @__arglist);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_log_variant(string log_domain, MentorLake.GLib.GLogLevelFlags log_level, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle fields);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GLogWriterOutput g_log_writer_default(MentorLake.GLib.GLogLevelFlags log_level, MentorLake.GLib.GLogField[] fields, UIntPtr n_fields, IntPtr user_data);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_log_writer_default_set_debug_domains(string domains);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_log_writer_default_set_use_stderr(bool use_stderr);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_log_writer_default_would_drop(MentorLake.GLib.GLogLevelFlags log_level, string log_domain);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_log_writer_format_fields(MentorLake.GLib.GLogLevelFlags log_level, MentorLake.GLib.GLogField[] fields, UIntPtr n_fields, bool use_color);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_log_writer_is_journald(int output_fd);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GLogWriterOutput g_log_writer_journald(MentorLake.GLib.GLogLevelFlags log_level, MentorLake.GLib.GLogField[] fields, UIntPtr n_fields, IntPtr user_data);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GLogWriterOutput g_log_writer_standard_streams(MentorLake.GLib.GLogLevelFlags log_level, MentorLake.GLib.GLogField[] fields, UIntPtr n_fields, IntPtr user_data);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_log_writer_supports_color(int output_fd);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GLogWriterOutput g_log_writer_syslog(MentorLake.GLib.GLogLevelFlags log_level, MentorLake.GLib.GLogField[] fields, UIntPtr n_fields, IntPtr user_data);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_logv(string log_domain, MentorLake.GLib.GLogLevelFlags log_level, string format, IntPtr args);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_lstat(string filename, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStatBufHandle>))] MentorLake.GLib.GStatBufHandle buf);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMainContextHandle>))]
	internal static extern MentorLake.GLib.GMainContextHandle g_main_context_default();

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMainContextHandle>))]
	internal static extern MentorLake.GLib.GMainContextHandle g_main_context_get_thread_default();

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMainContextHandle>))]
	internal static extern MentorLake.GLib.GMainContextHandle g_main_context_ref_thread_default();

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSourceHandle>))]
	internal static extern MentorLake.GLib.GSourceHandle g_main_current_source();

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_main_depth();

	[DllImport(GLibLibrary.Name)]
	internal static extern IntPtr g_malloc(UIntPtr n_bytes);

	[DllImport(GLibLibrary.Name)]
	internal static extern IntPtr g_malloc0(UIntPtr n_bytes);

	[DllImport(GLibLibrary.Name)]
	internal static extern IntPtr g_malloc0_n(UIntPtr n_blocks, UIntPtr n_block_bytes);

	[DllImport(GLibLibrary.Name)]
	internal static extern IntPtr g_malloc_n(UIntPtr n_blocks, UIntPtr n_block_bytes);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_markup_collect_attributes(string element_name, string attribute_names, string attribute_values, IntPtr error, MentorLake.GLib.GMarkupCollectType first_type, string first_attr, IntPtr @__arglist);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GQuark g_markup_error_quark();

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_markup_escape_text(string text, UIntPtr length);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_markup_printf_escaped(string format, IntPtr @__arglist);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_markup_vprintf_escaped(string format, IntPtr args);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_mem_chunk_info();

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_mem_is_system_malloc();

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_mem_profile();

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_mem_set_vtable([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMemVTableHandle>))] MentorLake.GLib.GMemVTableHandle vtable);

	[DllImport(GLibLibrary.Name)]
	internal static extern IntPtr g_memdup(IntPtr mem, uint byte_size);

	[DllImport(GLibLibrary.Name)]
	internal static extern IntPtr g_memdup2(IntPtr mem, UIntPtr byte_size);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_mkdir(string filename, int mode);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_mkdir_with_parents(string pathname, int mode);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_mkdtemp(string tmpl);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_mkdtemp_full(string tmpl, int mode);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_mkstemp(string tmpl);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_mkstemp_full(string tmpl, int flags, int mode);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMutexHandle>))]
	internal static extern MentorLake.GLib.GMutexHandle g_mutex_new();

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_node_pop_allocator();

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_node_push_allocator([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GAllocatorHandle>))] MentorLake.GLib.GAllocatorHandle allocator);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_nullify_pointer(IntPtr nullify_location);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GQuark g_number_parser_error_quark();

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_on_error_query(string prg_name);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_on_error_stack_trace(string prg_name);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_once_init_enter(ref IntPtr location);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_once_init_enter_impl(UIntPtr location);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_once_init_enter_pointer(IntPtr location);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_once_init_leave(ref IntPtr location, UIntPtr result);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_once_init_leave_pointer(IntPtr location, IntPtr result);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_open(string filename, int flags, int mode);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GQuark g_option_error_quark();

	[DllImport(GLibLibrary.Name)]
	internal static extern uint g_parse_debug_string(string @string, MentorLake.GLib.GDebugKey[] keys, uint nkeys);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_path_buf_equal(IntPtr v1, IntPtr v2);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_path_get_basename(string file_name);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_path_get_dirname(string file_name);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_path_is_absolute(string file_name);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_path_skip_root(string file_name);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_pattern_match([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GPatternSpecHandle>))] MentorLake.GLib.GPatternSpecHandle pspec, uint string_length, string @string, string string_reversed);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_pattern_match_simple(string pattern, string @string);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_pattern_match_string([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GPatternSpecHandle>))] MentorLake.GLib.GPatternSpecHandle pspec, string @string);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_pointer_bit_lock(IntPtr address, int lock_bit);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_pointer_bit_lock_and_get(IntPtr address, uint lock_bit, out uint out_ptr);

	[DllImport(GLibLibrary.Name)]
	internal static extern IntPtr g_pointer_bit_lock_mask_ptr(IntPtr ptr, uint lock_bit, bool set, uint preserve_mask, IntPtr preserve_ptr);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_pointer_bit_trylock(IntPtr address, int lock_bit);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_pointer_bit_unlock(IntPtr address, int lock_bit);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_pointer_bit_unlock_and_set(IntPtr address, uint lock_bit, IntPtr ptr, uint preserve_mask);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_poll([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GPollFDHandle>))] MentorLake.GLib.GPollFDHandle fds, uint nfds, int timeout);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_prefix_error([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GErrorHandle>))] ref MentorLake.GLib.GErrorHandle err, string format, IntPtr @__arglist);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_prefix_error_literal([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GErrorHandle>))] ref MentorLake.GLib.GErrorHandle err, string prefix);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_print(string format, IntPtr @__arglist);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_printerr(string format, IntPtr @__arglist);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_printf(string format, IntPtr @__arglist);

	[DllImport(GLibLibrary.Name)]
	internal static extern UIntPtr g_printf_string_upper_bound(string format, IntPtr args);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GPrivateHandle>))]
	internal static extern MentorLake.GLib.GPrivateHandle g_private_new(MentorLake.GLib.GDestroyNotify notify);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_propagate_error([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GErrorHandle>))] out MentorLake.GLib.GErrorHandle dest, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GErrorHandle>))] MentorLake.GLib.GErrorHandle src);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_propagate_prefixed_error(IntPtr dest, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GErrorHandle>))] MentorLake.GLib.GErrorHandle src, string format, IntPtr @__arglist);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_ptr_array_find([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GPtrArrayHandle>))] MentorLake.GLib.GPtrArrayHandle haystack, IntPtr needle, out uint index_);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_ptr_array_find_with_equal_func([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GPtrArrayHandle>))] MentorLake.GLib.GPtrArrayHandle haystack, IntPtr needle, MentorLake.GLib.GEqualFunc equal_func, out uint index_);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GPtrArrayHandle>))]
	internal static extern MentorLake.GLib.GPtrArrayHandle g_ptr_array_new_from_array(IntPtr[] data, UIntPtr len, MentorLake.GLib.GCopyFunc copy_func, IntPtr copy_func_user_data, MentorLake.GLib.GDestroyNotify element_free_func);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GPtrArrayHandle>))]
	internal static extern MentorLake.GLib.GPtrArrayHandle g_ptr_array_new_from_null_terminated_array(IntPtr[] data, MentorLake.GLib.GCopyFunc copy_func, IntPtr copy_func_user_data, MentorLake.GLib.GDestroyNotify element_free_func);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GPtrArrayHandle>))]
	internal static extern MentorLake.GLib.GPtrArrayHandle g_ptr_array_new_take(IntPtr[] data, UIntPtr len, MentorLake.GLib.GDestroyNotify element_free_func);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GPtrArrayHandle>))]
	internal static extern MentorLake.GLib.GPtrArrayHandle g_ptr_array_new_take_null_terminated(IntPtr[] data, MentorLake.GLib.GDestroyNotify element_free_func);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_qsort_with_data(IntPtr pbase, int total_elems, UIntPtr size, MentorLake.GLib.GCompareDataFunc compare_func, IntPtr user_data);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GQuark g_quark_from_static_string(string @string);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GQuark g_quark_from_string(string @string);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_quark_to_string(MentorLake.GLib.GQuark quark);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GQuark g_quark_try_string(string @string);

	[DllImport(GLibLibrary.Name)]
	internal static extern double g_random_double();

	[DllImport(GLibLibrary.Name)]
	internal static extern double g_random_double_range(double begin, double end);

	[DllImport(GLibLibrary.Name)]
	internal static extern uint g_random_int();

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_random_int_range(int begin, int end);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_random_set_seed(uint seed);

	[DllImport(GLibLibrary.Name)]
	internal static extern IntPtr g_rc_box_acquire(IntPtr mem_block);

	[DllImport(GLibLibrary.Name)]
	internal static extern IntPtr g_rc_box_alloc(UIntPtr block_size);

	[DllImport(GLibLibrary.Name)]
	internal static extern IntPtr g_rc_box_alloc0(UIntPtr block_size);

	[DllImport(GLibLibrary.Name)]
	internal static extern IntPtr g_rc_box_dup(UIntPtr block_size, IntPtr mem_block);

	[DllImport(GLibLibrary.Name)]
	internal static extern UIntPtr g_rc_box_get_size(IntPtr mem_block);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_rc_box_release(IntPtr mem_block);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_rc_box_release_full(IntPtr mem_block, MentorLake.GLib.GDestroyNotify clear_func);

	[DllImport(GLibLibrary.Name)]
	internal static extern IntPtr g_realloc(IntPtr mem, UIntPtr n_bytes);

	[DllImport(GLibLibrary.Name)]
	internal static extern IntPtr g_realloc_n(IntPtr mem, UIntPtr n_blocks, UIntPtr n_block_bytes);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_ref_count_compare(int rc, int val);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_ref_count_dec(int rc);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_ref_count_inc(int rc);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_ref_count_init(int rc);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_ref_string_acquire(string str);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_ref_string_equal(string str1, string str2);

	[DllImport(GLibLibrary.Name)]
	internal static extern UIntPtr g_ref_string_length(string str);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_ref_string_new(string str);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_ref_string_new_intern(string str);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_ref_string_new_len(string str, UIntPtr len);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_ref_string_release(string str);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_regex_check_replacement(string replacement, out bool has_references, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GQuark g_regex_error_quark();

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_regex_escape_nul(string @string, int length);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_regex_escape_string(string @string, int length);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_regex_match_simple(string pattern, string @string, MentorLake.GLib.GRegexCompileFlags compile_options, MentorLake.GLib.GRegexMatchFlags match_options);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ReadNullTerminatedArrayMarshaller<NoNativeFreeStringMarshaller, string>))]
	internal static extern string[] g_regex_split_simple(string pattern, string @string, MentorLake.GLib.GRegexCompileFlags compile_options, MentorLake.GLib.GRegexMatchFlags match_options);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_reload_user_special_dirs_cache();

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_remove(string filename);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_rename(string oldfilename, string newfilename);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_return_if_fail_warning(string log_domain, string pretty_function, string expression);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_rmdir(string filename);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_sequence_foreach_range([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceIterHandle>))] MentorLake.GLib.GSequenceIterHandle begin, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceIterHandle>))] MentorLake.GLib.GSequenceIterHandle end, MentorLake.GLib.GFunc func, IntPtr user_data);

	[DllImport(GLibLibrary.Name)]
	internal static extern IntPtr g_sequence_get([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceIterHandle>))] MentorLake.GLib.GSequenceIterHandle iter);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceIterHandle>))]
	internal static extern MentorLake.GLib.GSequenceIterHandle g_sequence_insert_before([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceIterHandle>))] MentorLake.GLib.GSequenceIterHandle iter, IntPtr data);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_sequence_move([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceIterHandle>))] MentorLake.GLib.GSequenceIterHandle src, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceIterHandle>))] MentorLake.GLib.GSequenceIterHandle dest);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_sequence_move_range([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceIterHandle>))] MentorLake.GLib.GSequenceIterHandle dest, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceIterHandle>))] MentorLake.GLib.GSequenceIterHandle begin, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceIterHandle>))] MentorLake.GLib.GSequenceIterHandle end);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceIterHandle>))]
	internal static extern MentorLake.GLib.GSequenceIterHandle g_sequence_range_get_midpoint([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceIterHandle>))] MentorLake.GLib.GSequenceIterHandle begin, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceIterHandle>))] MentorLake.GLib.GSequenceIterHandle end);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_sequence_remove([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceIterHandle>))] MentorLake.GLib.GSequenceIterHandle iter);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_sequence_remove_range([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceIterHandle>))] MentorLake.GLib.GSequenceIterHandle begin, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceIterHandle>))] MentorLake.GLib.GSequenceIterHandle end);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_sequence_set([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceIterHandle>))] MentorLake.GLib.GSequenceIterHandle iter, IntPtr data);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_sequence_sort_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceIterHandle>))] MentorLake.GLib.GSequenceIterHandle iter, MentorLake.GLib.GCompareDataFunc cmp_func, IntPtr cmp_data);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_sequence_sort_changed_iter([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceIterHandle>))] MentorLake.GLib.GSequenceIterHandle iter, MentorLake.GLib.GSequenceIterCompareFunc iter_cmp, IntPtr cmp_data);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_sequence_swap([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceIterHandle>))] MentorLake.GLib.GSequenceIterHandle a, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceIterHandle>))] MentorLake.GLib.GSequenceIterHandle b);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_set_application_name(string application_name);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_set_error([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GErrorHandle>))] out MentorLake.GLib.GErrorHandle err, MentorLake.GLib.GQuark domain, int code, string format, IntPtr @__arglist);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_set_error_literal([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GErrorHandle>))] out MentorLake.GLib.GErrorHandle err, MentorLake.GLib.GQuark domain, int code, string message);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_set_prgname(string prgname);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GPrintFunc g_set_print_handler(MentorLake.GLib.GPrintFunc func);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GPrintFunc g_set_printerr_handler(MentorLake.GLib.GPrintFunc func);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_setenv(string variable, string value, bool overwrite);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GQuark g_shell_error_quark();

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_shell_parse_argv(string command_line, out int argcp, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] out string[] argvp, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_shell_quote(string unquoted_string);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_shell_unquote(string quoted_string, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	internal static extern IntPtr g_slice_alloc(UIntPtr block_size);

	[DllImport(GLibLibrary.Name)]
	internal static extern IntPtr g_slice_alloc0(UIntPtr block_size);

	[DllImport(GLibLibrary.Name)]
	internal static extern IntPtr g_slice_copy(UIntPtr block_size, IntPtr mem_block);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_slice_free1(UIntPtr block_size, IntPtr mem_block);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_slice_free_chain_with_offset(UIntPtr block_size, IntPtr mem_chain, UIntPtr next_offset);

	[DllImport(GLibLibrary.Name)]
	internal static extern long g_slice_get_config(MentorLake.GLib.GSliceConfig ckey);

	[DllImport(GLibLibrary.Name)]
	internal static extern long g_slice_get_config_state(MentorLake.GLib.GSliceConfig ckey, long address, uint n_values);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_slice_set_config(MentorLake.GLib.GSliceConfig ckey, long value);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_slist_pop_allocator();

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_slist_push_allocator([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GAllocatorHandle>))] MentorLake.GLib.GAllocatorHandle allocator);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_snprintf(string @string, ulong n, string format, IntPtr @__arglist);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_sort_array(IntPtr[] array, UIntPtr n_elements, UIntPtr element_size, MentorLake.GLib.GCompareDataFunc compare_func, IntPtr user_data);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_source_remove(uint tag);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_source_remove_by_funcs_user_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSourceFuncsHandle>))] MentorLake.GLib.GSourceFuncsHandle funcs, IntPtr user_data);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_source_remove_by_user_data(IntPtr user_data);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_source_set_name_by_id(uint tag, string name);

	[DllImport(GLibLibrary.Name)]
	internal static extern uint g_spaced_primes_closest(uint num);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_spawn_async(string working_directory, string[] argv, string[] envp, MentorLake.GLib.GSpawnFlags flags, MentorLake.GLib.GSpawnChildSetupFunc child_setup, IntPtr user_data, out MentorLake.GLib.GPid child_pid, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_spawn_async_with_fds(string working_directory, string[] argv, string[] envp, MentorLake.GLib.GSpawnFlags flags, MentorLake.GLib.GSpawnChildSetupFunc child_setup, IntPtr user_data, out MentorLake.GLib.GPid child_pid, int stdin_fd, int stdout_fd, int stderr_fd, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_spawn_async_with_pipes(string working_directory, string[] argv, string[] envp, MentorLake.GLib.GSpawnFlags flags, MentorLake.GLib.GSpawnChildSetupFunc child_setup, IntPtr user_data, out MentorLake.GLib.GPid child_pid, out int standard_input, out int standard_output, out int standard_error, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_spawn_async_with_pipes_and_fds(string working_directory, string[] argv, string[] envp, MentorLake.GLib.GSpawnFlags flags, MentorLake.GLib.GSpawnChildSetupFunc child_setup, IntPtr user_data, int stdin_fd, int stdout_fd, int stderr_fd, int[] source_fds, int[] target_fds, UIntPtr n_fds, out MentorLake.GLib.GPid child_pid_out, out int stdin_pipe_out, out int stdout_pipe_out, out int stderr_pipe_out, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_spawn_check_exit_status(int wait_status, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_spawn_check_wait_status(int wait_status, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_spawn_close_pid(MentorLake.GLib.GPid pid);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_spawn_command_line_async(string command_line, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_spawn_command_line_sync(string command_line, [MarshalAs(UnmanagedType.LPArray)] out byte[] standard_output, [MarshalAs(UnmanagedType.LPArray)] out byte[] standard_error, out int wait_status, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GQuark g_spawn_error_quark();

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GQuark g_spawn_exit_error_quark();

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_spawn_sync(string working_directory, string[] argv, string[] envp, MentorLake.GLib.GSpawnFlags flags, MentorLake.GLib.GSpawnChildSetupFunc child_setup, IntPtr user_data, [MarshalAs(UnmanagedType.LPArray)] out byte[] standard_output, [MarshalAs(UnmanagedType.LPArray)] out byte[] standard_error, out int wait_status, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_sprintf(string @string, string format, IntPtr @__arglist);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_stat(string filename, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStatBufHandle>))] MentorLake.GLib.GStatBufHandle buf);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_stpcpy(string dest, string src);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_str_equal(IntPtr v1, IntPtr v2);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_str_has_prefix(string str, string prefix);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_str_has_suffix(string str, string suffix);

	[DllImport(GLibLibrary.Name)]
	internal static extern uint g_str_hash(IntPtr v);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_str_is_ascii(string str);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_str_match_string(string search_term, string potential_hit, bool accept_alternates);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_str_to_ascii(string str, string from_locale);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ReadNullTerminatedArrayMarshaller<NoNativeFreeStringMarshaller, string>))]
	internal static extern string[] g_str_tokenize_and_fold(string @string, string translit_locale, [MarshalAs(UnmanagedType.LPArray)] out string[] ascii_alternates);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_strcanon(string @string, string valid_chars, char substitutor);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_strcasecmp(string s1, string s2);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_strchomp(string @string);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_strchug(string @string);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_strcmp0(string str1, string str2);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_strcompress(string source);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_strconcat(string string1, IntPtr @__arglist);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_strdelimit(string @string, string delimiters, char new_delimiter);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_strdown(string @string);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_strdup(string str);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_strdup_printf(string format, IntPtr @__arglist);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_strdup_vprintf(string format, IntPtr args);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ReadNullTerminatedArrayMarshaller<NoNativeFreeStringMarshaller, string>))]
	internal static extern string[] g_strdupv(string[] str_array);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_strerror(int errnum);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_strescape(string source, string exceptions);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_strfreev(string[] str_array);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_strip_context(string msgid, string msgval);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_strjoin(string separator, IntPtr @__arglist);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_strjoinv(string separator, string[] str_array);

	[DllImport(GLibLibrary.Name)]
	internal static extern UIntPtr g_strlcat(string dest, string src, UIntPtr dest_size);

	[DllImport(GLibLibrary.Name)]
	internal static extern UIntPtr g_strlcpy(string dest, string src, UIntPtr dest_size);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_strncasecmp(string s1, string s2, uint n);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_strndup(string str, UIntPtr n);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_strnfill(UIntPtr length, char fill_char);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_strreverse(string @string);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_strrstr(string haystack, string needle);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_strrstr_len(string haystack, UIntPtr haystack_len, string needle);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_strsignal(int signum);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ReadNullTerminatedArrayMarshaller<NoNativeFreeStringMarshaller, string>))]
	internal static extern string[] g_strsplit(string @string, string delimiter, int max_tokens);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ReadNullTerminatedArrayMarshaller<NoNativeFreeStringMarshaller, string>))]
	internal static extern string[] g_strsplit_set(string @string, string delimiters, int max_tokens);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_strstr_len(string haystack, UIntPtr haystack_len, string needle);

	[DllImport(GLibLibrary.Name)]
	internal static extern double g_strtod(string nptr, out string endptr);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_strup(string @string);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_strv_contains(string[] strv, string str);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_strv_equal(string[] strv1, string[] strv2);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GObject.GType g_strv_get_type();

	[DllImport(GLibLibrary.Name)]
	internal static extern uint g_strv_length(string[] str_array);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_test_add_data_func(string testpath, IntPtr test_data, MentorLake.GLib.GTestDataFunc test_func);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_test_add_data_func_full(string testpath, IntPtr test_data, MentorLake.GLib.GTestDataFunc test_func, MentorLake.GLib.GDestroyNotify data_free_func);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_test_add_func(string testpath, MentorLake.GLib.GTestFunc test_func);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_test_add_vtable(string testpath, UIntPtr data_size, IntPtr test_data, MentorLake.GLib.GTestFixtureFunc data_setup, MentorLake.GLib.GTestFixtureFunc data_test, MentorLake.GLib.GTestFixtureFunc data_teardown);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_test_assert_expected_messages_internal(string domain, string file, int line, string func);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_test_bug(string bug_uri_snippet);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_test_bug_base(string uri_pattern);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_test_build_filename(MentorLake.GLib.GTestFileType file_type, string first_path, IntPtr @__arglist);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GTestCaseHandle>))]
	internal static extern MentorLake.GLib.GTestCaseHandle g_test_create_case(string test_name, UIntPtr data_size, IntPtr test_data, MentorLake.GLib.GTestFixtureFunc data_setup, MentorLake.GLib.GTestFixtureFunc data_test, MentorLake.GLib.GTestFixtureFunc data_teardown);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GTestSuiteHandle>))]
	internal static extern MentorLake.GLib.GTestSuiteHandle g_test_create_suite(string suite_name);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_test_disable_crash_reporting();

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_test_expect_message(string log_domain, MentorLake.GLib.GLogLevelFlags log_level, string pattern);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_test_fail();

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_test_fail_printf(string format, IntPtr @__arglist);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_test_failed();

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_test_get_dir(MentorLake.GLib.GTestFileType file_type);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_test_get_filename(MentorLake.GLib.GTestFileType file_type, string first_path, IntPtr @__arglist);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_test_get_path();

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GTestSuiteHandle>))]
	internal static extern MentorLake.GLib.GTestSuiteHandle g_test_get_root();

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_test_incomplete(string msg);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_test_incomplete_printf(string format, IntPtr @__arglist);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_test_init(int argc, string argv, IntPtr @__arglist);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_test_log_set_fatal_handler(MentorLake.GLib.GTestLogFatalFunc log_func, IntPtr user_data);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_test_log_type_name(MentorLake.GLib.GTestLogType log_type);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_test_maximized_result(double maximized_quantity, string format, IntPtr @__arglist);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_test_message(string format, IntPtr @__arglist);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_test_minimized_result(double minimized_quantity, string format, IntPtr @__arglist);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_test_queue_destroy(MentorLake.GLib.GDestroyNotify destroy_func, IntPtr destroy_data);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_test_queue_free(IntPtr gfree_pointer);

	[DllImport(GLibLibrary.Name)]
	internal static extern double g_test_rand_double();

	[DllImport(GLibLibrary.Name)]
	internal static extern double g_test_rand_double_range(double range_start, double range_end);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_test_rand_int();

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_test_rand_int_range(int begin, int end);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_test_run();

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_test_run_suite([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GTestSuiteHandle>))] MentorLake.GLib.GTestSuiteHandle suite);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_test_set_nonfatal_assertions();

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_test_skip(string msg);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_test_skip_printf(string format, IntPtr @__arglist);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_test_subprocess();

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_test_summary(string summary);

	[DllImport(GLibLibrary.Name)]
	internal static extern double g_test_timer_elapsed();

	[DllImport(GLibLibrary.Name)]
	internal static extern double g_test_timer_last();

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_test_timer_start();

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_test_trap_assertions(string domain, string file, int line, string func, ulong assertion_flags, string pattern);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_test_trap_fork(ulong usec_timeout, MentorLake.GLib.GTestTrapFlags test_trap_flags);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_test_trap_has_passed();

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_test_trap_reached_timeout();

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_test_trap_subprocess(string test_path, ulong usec_timeout, MentorLake.GLib.GTestSubprocessFlags test_flags);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_test_trap_subprocess_with_envp(string test_path, string[] envp, ulong usec_timeout, MentorLake.GLib.GTestSubprocessFlags test_flags);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GThreadHandle>))]
	internal static extern MentorLake.GLib.GThreadHandle g_thread_create(MentorLake.GLib.GThreadFunc func, IntPtr data, bool joinable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GThreadHandle>))]
	internal static extern MentorLake.GLib.GThreadHandle g_thread_create_full(MentorLake.GLib.GThreadFunc func, IntPtr data, ulong stack_size, bool joinable, bool bound, MentorLake.GLib.GThreadPriority priority, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GQuark g_thread_error_quark();

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_thread_exit(IntPtr retval);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_thread_foreach(MentorLake.GLib.GFunc thread_func, IntPtr user_data);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_thread_get_initialized();

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_thread_init(IntPtr vtable);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_thread_init_with_errorcheck_mutexes(IntPtr vtable);

	[DllImport(GLibLibrary.Name)]
	internal static extern uint g_thread_pool_get_max_idle_time();

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_thread_pool_get_max_unused_threads();

	[DllImport(GLibLibrary.Name)]
	internal static extern uint g_thread_pool_get_num_unused_threads();

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_thread_pool_set_max_idle_time(uint interval);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_thread_pool_set_max_unused_threads(int max_threads);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_thread_pool_stop_unused_threads();

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GThreadHandle>))]
	internal static extern MentorLake.GLib.GThreadHandle g_thread_self();

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_thread_yield();

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_time_val_from_iso8601(string iso_date, out MentorLake.GLib.GTimeVal time_);

	[DllImport(GLibLibrary.Name)]
	internal static extern uint g_timeout_add(uint interval, MentorLake.GLib.GSourceFunc function, IntPtr data);

	[DllImport(GLibLibrary.Name)]
	internal static extern uint g_timeout_add_full(int priority, uint interval, MentorLake.GLib.GSourceFunc function, IntPtr data, MentorLake.GLib.GDestroyNotify notify);

	[DllImport(GLibLibrary.Name)]
	internal static extern uint g_timeout_add_once(uint interval, MentorLake.GLib.GSourceOnceFunc function, IntPtr data);

	[DllImport(GLibLibrary.Name)]
	internal static extern uint g_timeout_add_seconds(uint interval, MentorLake.GLib.GSourceFunc function, IntPtr data);

	[DllImport(GLibLibrary.Name)]
	internal static extern uint g_timeout_add_seconds_full(int priority, uint interval, MentorLake.GLib.GSourceFunc function, IntPtr data, MentorLake.GLib.GDestroyNotify notify);

	[DllImport(GLibLibrary.Name)]
	internal static extern uint g_timeout_add_seconds_once(uint interval, MentorLake.GLib.GSourceOnceFunc function, IntPtr data);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSourceHandle>))]
	internal static extern MentorLake.GLib.GSourceHandle g_timeout_source_new(uint interval);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSourceHandle>))]
	internal static extern MentorLake.GLib.GSourceHandle g_timeout_source_new_seconds(uint interval);

	[DllImport(GLibLibrary.Name)]
	internal static extern uint g_trash_stack_height(IntPtr stack_p);

	[DllImport(GLibLibrary.Name)]
	internal static extern IntPtr g_trash_stack_peek(IntPtr stack_p);

	[DllImport(GLibLibrary.Name)]
	internal static extern IntPtr g_trash_stack_pop(IntPtr stack_p);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_trash_stack_push(IntPtr stack_p, IntPtr data_p);

	[DllImport(GLibLibrary.Name)]
	internal static extern IntPtr g_try_malloc(UIntPtr n_bytes);

	[DllImport(GLibLibrary.Name)]
	internal static extern IntPtr g_try_malloc0(UIntPtr n_bytes);

	[DllImport(GLibLibrary.Name)]
	internal static extern IntPtr g_try_malloc0_n(UIntPtr n_blocks, UIntPtr n_block_bytes);

	[DllImport(GLibLibrary.Name)]
	internal static extern IntPtr g_try_malloc_n(UIntPtr n_blocks, UIntPtr n_block_bytes);

	[DllImport(GLibLibrary.Name)]
	internal static extern IntPtr g_try_realloc(IntPtr mem, UIntPtr n_bytes);

	[DllImport(GLibLibrary.Name)]
	internal static extern IntPtr g_try_realloc_n(IntPtr mem, UIntPtr n_blocks, UIntPtr n_block_bytes);

	[DllImport(GLibLibrary.Name)]
	internal static extern char g_ucs4_to_utf16(char[] str, long len, out long items_read, out long items_written, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_ucs4_to_utf8(char[] str, long len, out long items_read, out long items_written, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GUnicodeBreakType g_unichar_break_type(char c);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_unichar_combining_class(char uc);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_unichar_compose(char a, char b, out char ch);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_unichar_decompose(char ch, out char a, out char b);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_unichar_digit_value(char c);

	[DllImport(GLibLibrary.Name)]
	internal static extern UIntPtr g_unichar_fully_decompose(char ch, bool compat, out char result, UIntPtr result_len);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_unichar_get_mirror_char(char ch, out char mirrored_ch);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GUnicodeScript g_unichar_get_script(char ch);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_unichar_isalnum(char c);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_unichar_isalpha(char c);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_unichar_iscntrl(char c);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_unichar_isdefined(char c);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_unichar_isdigit(char c);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_unichar_isgraph(char c);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_unichar_islower(char c);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_unichar_ismark(char c);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_unichar_isprint(char c);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_unichar_ispunct(char c);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_unichar_isspace(char c);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_unichar_istitle(char c);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_unichar_isupper(char c);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_unichar_iswide(char c);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_unichar_iswide_cjk(char c);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_unichar_isxdigit(char c);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_unichar_iszerowidth(char c);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_unichar_to_utf8(char c, out string outbuf);

	[DllImport(GLibLibrary.Name)]
	internal static extern char g_unichar_tolower(char c);

	[DllImport(GLibLibrary.Name)]
	internal static extern char g_unichar_totitle(char c);

	[DllImport(GLibLibrary.Name)]
	internal static extern char g_unichar_toupper(char c);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GUnicodeType g_unichar_type(char c);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_unichar_validate(char ch);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_unichar_xdigit_value(char c);

	[DllImport(GLibLibrary.Name)]
	internal static extern char g_unicode_canonical_decomposition(char ch, UIntPtr result_len);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_unicode_canonical_ordering(char[] @string, UIntPtr len);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GUnicodeScript g_unicode_script_from_iso15924(uint iso15924);

	[DllImport(GLibLibrary.Name)]
	internal static extern uint g_unicode_script_to_iso15924(MentorLake.GLib.GUnicodeScript script);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GQuark g_unix_error_quark();

	[DllImport(GLibLibrary.Name)]
	internal static extern uint g_unix_fd_add(int fd, MentorLake.GLib.GIOCondition condition, MentorLake.GLib.GUnixFDSourceFunc function, IntPtr user_data);

	[DllImport(GLibLibrary.Name)]
	internal static extern uint g_unix_fd_add_full(int priority, int fd, MentorLake.GLib.GIOCondition condition, MentorLake.GLib.GUnixFDSourceFunc function, IntPtr user_data, MentorLake.GLib.GDestroyNotify notify);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSourceHandle>))]
	internal static extern MentorLake.GLib.GSourceHandle g_unix_fd_source_new(int fd, MentorLake.GLib.GIOCondition condition);

	[DllImport(GLibLibrary.Name)]
	internal static extern IntPtr g_unix_get_passwd_entry(string user_name, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_unix_open_pipe(int[] fds, int flags, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_unix_set_fd_nonblocking(int fd, bool nonblock, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	internal static extern uint g_unix_signal_add(int signum, MentorLake.GLib.GSourceFunc handler, IntPtr user_data);

	[DllImport(GLibLibrary.Name)]
	internal static extern uint g_unix_signal_add_full(int priority, int signum, MentorLake.GLib.GSourceFunc handler, IntPtr user_data, MentorLake.GLib.GDestroyNotify notify);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSourceHandle>))]
	internal static extern MentorLake.GLib.GSourceHandle g_unix_signal_source_new(int signum);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_unlink(string filename);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_unsetenv(string variable);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GUriHandle>))]
	internal static extern MentorLake.GLib.GUriHandle g_uri_build(MentorLake.GLib.GUriFlags flags, string scheme, string userinfo, string host, int port, string path, string query, string fragment);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GUriHandle>))]
	internal static extern MentorLake.GLib.GUriHandle g_uri_build_with_user(MentorLake.GLib.GUriFlags flags, string scheme, string user, string password, string auth_params, string host, int port, string path, string query, string fragment);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GQuark g_uri_error_quark();

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_uri_escape_bytes(byte[] unescaped, UIntPtr length, string reserved_chars_allowed);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_uri_escape_string(string unescaped, string reserved_chars_allowed, bool allow_utf8);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_uri_is_valid(string uri_string, MentorLake.GLib.GUriFlags flags, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_uri_join(MentorLake.GLib.GUriFlags flags, string scheme, string userinfo, string host, int port, string path, string query, string fragment);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_uri_join_with_user(MentorLake.GLib.GUriFlags flags, string scheme, string user, string password, string auth_params, string host, int port, string path, string query, string fragment);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ReadNullTerminatedArrayMarshaller<NoNativeFreeStringMarshaller, string>))]
	internal static extern string[] g_uri_list_extract_uris(string uri_list);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GUriHandle>))]
	internal static extern MentorLake.GLib.GUriHandle g_uri_parse(string uri_string, MentorLake.GLib.GUriFlags flags, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHashTableHandle>))]
	internal static extern MentorLake.GLib.GHashTableHandle g_uri_parse_params(string @params, UIntPtr length, string separators, MentorLake.GLib.GUriParamsFlags flags, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_uri_parse_scheme(string uri);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_uri_peek_scheme(string uri);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_uri_resolve_relative(string base_uri_string, string uri_ref, MentorLake.GLib.GUriFlags flags, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_uri_split(string uri_ref, MentorLake.GLib.GUriFlags flags, out string scheme, out string userinfo, out string host, out int port, out string path, out string query, out string fragment, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_uri_split_network(string uri_string, MentorLake.GLib.GUriFlags flags, out string scheme, out string host, out int port, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_uri_split_with_user(string uri_ref, MentorLake.GLib.GUriFlags flags, out string scheme, out string user, out string password, out string auth_params, out string host, out int port, out string path, out string query, out string fragment, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBytesHandle>))]
	internal static extern MentorLake.GLib.GBytesHandle g_uri_unescape_bytes(string escaped_string, UIntPtr length, string illegal_characters, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_uri_unescape_segment(string escaped_string, string escaped_string_end, string illegal_characters);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_uri_unescape_string(string escaped_string, string illegal_characters);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_usleep(ulong microseconds);

	[DllImport(GLibLibrary.Name)]
	internal static extern char g_utf16_to_ucs4(ushort[] str, long len, out long items_read, out long items_written, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_utf16_to_utf8(ushort[] str, long len, out long items_read, out long items_written, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_utf8_casefold(string str, UIntPtr len);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_utf8_collate(string str1, string str2);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_utf8_collate_key(string str, UIntPtr len);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_utf8_collate_key_for_filename(string str, UIntPtr len);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_utf8_find_next_char(string p, string end);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_utf8_find_prev_char(string str, string p);

	[DllImport(GLibLibrary.Name)]
	internal static extern char g_utf8_get_char(string p);

	[DllImport(GLibLibrary.Name)]
	internal static extern char g_utf8_get_char_validated(string p, UIntPtr max_len);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_utf8_make_valid(string str, UIntPtr len);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_utf8_normalize(string str, UIntPtr len, MentorLake.GLib.GNormalizeMode mode);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_utf8_offset_to_pointer(string str, long offset);

	[DllImport(GLibLibrary.Name)]
	internal static extern long g_utf8_pointer_to_offset(string str, string pos);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_utf8_prev_char(string p);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_utf8_strchr(string p, UIntPtr len, char c);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_utf8_strdown(string str, UIntPtr len);

	[DllImport(GLibLibrary.Name)]
	internal static extern long g_utf8_strlen(string p, UIntPtr max);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_utf8_strncpy(string dest, string src, UIntPtr n);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_utf8_strrchr(string p, UIntPtr len, char c);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_utf8_strreverse(string str, UIntPtr len);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_utf8_strup(string str, UIntPtr len);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_utf8_substring(string str, long start_pos, long end_pos);

	[DllImport(GLibLibrary.Name)]
	internal static extern char g_utf8_to_ucs4(string str, long len, out long items_read, out long items_written, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	internal static extern char g_utf8_to_ucs4_fast(string str, long len, out long items_written);

	[DllImport(GLibLibrary.Name)]
	internal static extern char g_utf8_to_utf16(string str, long len, out long items_read, out long items_written, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_utf8_truncate_middle(string @string, UIntPtr truncate_length);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_utf8_validate(byte[] str, UIntPtr max_len, out string end);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_utf8_validate_len(byte[] str, UIntPtr max_len, out string end);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_utime(string filename, IntPtr utb);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_uuid_string_is_valid(string str);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_uuid_string_random();

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GObject.GType g_variant_get_gtype();

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_variant_is_object_path(string @string);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_variant_is_signature(string @string);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))]
	internal static extern MentorLake.GLib.GVariantHandle g_variant_parse([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantTypeHandle>))] MentorLake.GLib.GVariantTypeHandle type, string text, string limit, string endptr, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_variant_parse_error_print_context([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GErrorHandle>))] MentorLake.GLib.GErrorHandle error, string source_str);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GQuark g_variant_parse_error_quark();

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GQuark g_variant_parser_get_error_quark();

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantTypeHandle>))]
	internal static extern MentorLake.GLib.GVariantTypeHandle g_variant_type_checked_(string type_string);

	[DllImport(GLibLibrary.Name)]
	internal static extern UIntPtr g_variant_type_string_get_depth_(string type_string);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_variant_type_string_is_valid(string type_string);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_variant_type_string_scan(string @string, string limit, out string endptr);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_vasprintf(out string @string, string format, IntPtr args);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_vfprintf(IntPtr file, string format, IntPtr args);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_vprintf(string format, IntPtr args);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_vsnprintf(string @string, ulong n, string format, IntPtr args);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_vsprintf(string @string, string format, IntPtr args);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_warn_message(string domain, string file, int line, string func, string warnexpr);

}
