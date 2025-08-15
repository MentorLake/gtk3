namespace MentorLake.GLib;

/// <summary>
/// <para>
/// `GVariant` is a variant datatype; it can contain one or more values
/// along with information about the type of the values.
/// </para>
/// <para>
/// A `GVariant` may contain simple types, like an integer, or a boolean value;
/// or complex types, like an array of two strings, or a dictionary of key
/// value pairs. A `GVariant` is also immutable: once it’s been created neither
/// its type nor its content can be modified further.
/// </para>
/// <para>
/// `GVariant` is useful whenever data needs to be serialized, for example when
/// sending method parameters in D-Bus, or when saving settings using
/// &amp;lt;see href=&quot;../gio/class.Settings.html&quot;&amp;gt;GSettings&amp;lt;/see&amp;gt;.
/// </para>
/// <para>
/// When creating a new `GVariant`, you pass the data you want to store in it
/// along with a string representing the type of data you wish to pass to it.
/// </para>
/// <para>
/// For instance, if you want to create a `GVariant` holding an integer value you
/// can use:
/// </para>
/// <para>
/// ```c
/// GVariant *v = g_variant_new (&quot;u&quot;, 40);
/// ```
/// </para>
/// <para>
/// The string `u` in the first argument tells `GVariant` that the data passed to
/// the constructor (`40`) is going to be an unsigned integer.
/// </para>
/// <para>
/// More advanced examples of `GVariant` in use can be found in documentation for
/// [`GVariant` format strings](gvariant-format-strings.html#pointers).
/// </para>
/// <para>
/// The range of possible values is determined by the type.
/// </para>
/// <para>
/// The type system used by `GVariant` is [type@GLib.VariantType].
/// </para>
/// <para>
/// `GVariant` instances always have a type and a value (which are given
/// at construction time).  The type and value of a `GVariant` instance
/// can never change other than by the `GVariant` itself being
/// destroyed.  A `GVariant` cannot contain a pointer.
/// </para>
/// <para>
/// `GVariant` is reference counted using [method@GLib.Variant.ref] and
/// [method@GLib.Variant.unref].  `GVariant` also has floating reference counts —
/// see [method@GLib.Variant.ref_sink].
/// </para>
/// <para>
/// `GVariant` is completely threadsafe.  A `GVariant` instance can be
/// concurrently accessed in any way from any number of threads without
/// problems.
/// </para>
/// <para>
/// `GVariant` is heavily optimised for dealing with data in serialized
/// form.  It works particularly well with data located in memory-mapped
/// files.  It can perform nearly all deserialization operations in a
/// small constant time, usually touching only a single memory page.
/// Serialized `GVariant` data can also be sent over the network.
/// </para>
/// <para>
/// `GVariant` is largely compatible with D-Bus.  Almost all types of
/// `GVariant` instances can be sent over D-Bus.  See [type@GLib.VariantType] for
/// exceptions.  (However, `GVariant`’s serialization format is not the same
/// as the serialization format of a D-Bus message body: use
/// [GDBusMessage](../gio/class.DBusMessage.html), in the GIO library, for those.)
/// </para>
/// <para>
/// For space-efficiency, the `GVariant` serialization format does not
/// automatically include the variant’s length, type or endianness,
/// which must either be implied from context (such as knowledge that a
/// particular file format always contains a little-endian
/// `G_VARIANT_TYPE_VARIANT` which occupies the whole length of the file)
/// or supplied out-of-band (for instance, a length, type and/or endianness
/// indicator could be placed at the beginning of a file, network message
/// or network stream).
/// </para>
/// <para>
/// A `GVariant`’s size is limited mainly by any lower level operating
/// system constraints, such as the number of bits in `gsize`.  For
/// example, it is reasonable to have a 2GB file mapped into memory
/// with [struct@GLib.MappedFile], and call [ctor@GLib.Variant.new_from_data] on
/// it.
/// </para>
/// <para>
/// For convenience to C programmers, `GVariant` features powerful
/// varargs-based value construction and destruction.  This feature is
/// designed to be embedded in other libraries.
/// </para>
/// <para>
/// There is a Python-inspired text language for describing `GVariant`
/// values.  `GVariant` includes a printer for this language and a parser
/// with type inferencing.
/// </para>
/// <para>
/// ## Memory Use
/// </para>
/// <para>
/// `GVariant` tries to be quite efficient with respect to memory use.
/// This section gives a rough idea of how much memory is used by the
/// current implementation.  The information here is subject to change
/// in the future.
/// </para>
/// <para>
/// The memory allocated by `GVariant` can be grouped into 4 broad
/// purposes: memory for serialized data, memory for the type
/// information cache, buffer management memory and memory for the
/// `GVariant` structure itself.
/// </para>
/// <para>
/// ## Serialized Data Memory
/// </para>
/// <para>
/// This is the memory that is used for storing `GVariant` data in
/// serialized form.  This is what would be sent over the network or
/// what would end up on disk, not counting any indicator of the
/// endianness, or of the length or type of the top-level variant.
/// </para>
/// <para>
/// The amount of memory required to store a boolean is 1 byte. 16,
/// 32 and 64 bit integers and double precision floating point numbers
/// use their ‘natural’ size.  Strings (including object path and
/// signature strings) are stored with a nul terminator, and as such
/// use the length of the string plus 1 byte.
/// </para>
/// <para>
/// ‘Maybe’ types use no space at all to represent the null value and
/// use the same amount of space (sometimes plus one byte) as the
/// equivalent non-maybe-typed value to represent the non-null case.
/// </para>
/// <para>
/// Arrays use the amount of space required to store each of their
/// members, concatenated.  Additionally, if the items stored in an
/// array are not of a fixed-size (ie: strings, other arrays, etc)
/// then an additional framing offset is stored for each item.  The
/// size of this offset is either 1, 2 or 4 bytes depending on the
/// overall size of the container.  Additionally, extra padding bytes
/// are added as required for alignment of child values.
/// </para>
/// <para>
/// Tuples (including dictionary entries) use the amount of space
/// required to store each of their members, concatenated, plus one
/// framing offset (as per arrays) for each non-fixed-sized item in
/// the tuple, except for the last one.  Additionally, extra padding
/// bytes are added as required for alignment of child values.
/// </para>
/// <para>
/// Variants use the same amount of space as the item inside of the
/// variant, plus 1 byte, plus the length of the type string for the
/// item inside the variant.
/// </para>
/// <para>
/// As an example, consider a dictionary mapping strings to variants.
/// In the case that the dictionary is empty, 0 bytes are required for
/// the serialization.
/// </para>
/// <para>
/// If we add an item ‘width’ that maps to the int32 value of 500 then
/// we will use 4 bytes to store the int32 (so 6 for the variant
/// containing it) and 6 bytes for the string.  The variant must be
/// aligned to 8 after the 6 bytes of the string, so that’s 2 extra
/// bytes.  6 (string) + 2 (padding) + 6 (variant) is 14 bytes used
/// for the dictionary entry.  An additional 1 byte is added to the
/// array as a framing offset making a total of 15 bytes.
/// </para>
/// <para>
/// If we add another entry, ‘title’ that maps to a nullable string
/// that happens to have a value of null, then we use 0 bytes for the
/// null value (and 3 bytes for the variant to contain it along with
/// its type string) plus 6 bytes for the string.  Again, we need 2
/// padding bytes.  That makes a total of 6 + 2 + 3 = 11 bytes.
/// </para>
/// <para>
/// We now require extra padding between the two items in the array.
/// After the 14 bytes of the first item, that’s 2 bytes required.
/// We now require 2 framing offsets for an extra two
/// bytes. 14 + 2 + 11 + 2 = 29 bytes to encode the entire two-item
/// dictionary.
/// </para>
/// <para>
/// ## Type Information Cache
/// </para>
/// <para>
/// For each `GVariant` type that currently exists in the program a type
/// information structure is kept in the type information cache.  The
/// type information structure is required for rapid deserialization.
/// </para>
/// <para>
/// Continuing with the above example, if a `GVariant` exists with the
/// type `a{sv}` then a type information struct will exist for
/// `a{sv}`, `{sv}`, `s`, and `v`.  Multiple uses of the same type
/// will share the same type information.  Additionally, all
/// single-digit types are stored in read-only static memory and do
/// not contribute to the writable memory footprint of a program using
/// `GVariant`.
/// </para>
/// <para>
/// Aside from the type information structures stored in read-only
/// memory, there are two forms of type information.  One is used for
/// container types where there is a single element type: arrays and
/// maybe types.  The other is used for container types where there
/// are multiple element types: tuples and dictionary entries.
/// </para>
/// <para>
/// Array type info structures are `6 * sizeof (void *)`, plus the
/// memory required to store the type string itself.  This means that
/// on 32-bit systems, the cache entry for `a{sv}` would require 30
/// bytes of memory (plus allocation overhead).
/// </para>
/// <para>
/// Tuple type info structures are `6 * sizeof (void *)`, plus `4 *
/// sizeof (void *)` for each item in the tuple, plus the memory
/// required to store the type string itself.  A 2-item tuple, for
/// example, would have a type information structure that consumed
/// writable memory in the size of `14 * sizeof (void *)` (plus type
/// string)  This means that on 32-bit systems, the cache entry for
/// `{sv}` would require 61 bytes of memory (plus allocation overhead).
/// </para>
/// <para>
/// This means that in total, for our `a{sv}` example, 91 bytes of
/// type information would be allocated.
/// </para>
/// <para>
/// The type information cache, additionally, uses a [struct@GLib.HashTable] to
/// store and look up the cached items and stores a pointer to this
/// hash table in static storage.  The hash table is freed when there
/// are zero items in the type cache.
/// </para>
/// <para>
/// Although these sizes may seem large it is important to remember
/// that a program will probably only have a very small number of
/// different types of values in it and that only one type information
/// structure is required for many different values of the same type.
/// </para>
/// <para>
/// ## Buffer Management Memory
/// </para>
/// <para>
/// `GVariant` uses an internal buffer management structure to deal
/// with the various different possible sources of serialized data
/// that it uses.  The buffer is responsible for ensuring that the
/// correct call is made when the data is no longer in use by
/// `GVariant`.  This may involve a [func@GLib.free] or
/// even [method@GLib.MappedFile.unref].
/// </para>
/// <para>
/// One buffer management structure is used for each chunk of
/// serialized data.  The size of the buffer management structure
/// is `4 * (void *)`.  On 32-bit systems, that’s 16 bytes.
/// </para>
/// <para>
/// ## GVariant structure
/// </para>
/// <para>
/// The size of a `GVariant` structure is `6 * (void *)`.  On 32-bit
/// systems, that’s 24 bytes.
/// </para>
/// <para>
/// `GVariant` structures only exist if they are explicitly created
/// with API calls.  For example, if a `GVariant` is constructed out of
/// serialized data for the example given above (with the dictionary)
/// then although there are 9 individual values that comprise the
/// entire dictionary (two keys, two values, two variants containing
/// the values, two dictionary entries, plus the dictionary itself),
/// only 1 `GVariant` instance exists — the one referring to the
/// dictionary.
/// </para>
/// <para>
/// If calls are made to start accessing the other values then
/// `GVariant` instances will exist for those values only for as long
/// as they are in use (ie: until you call [method@GLib.Variant.unref]).  The
/// type information is shared.  The serialized data and the buffer
/// management structure for that serialized data is shared by the
/// child.
/// </para>
/// <para>
/// ## Summary
/// </para>
/// <para>
/// To put the entire example together, for our dictionary mapping
/// strings to variants (with two entries, as given above), we are
/// using 91 bytes of memory for type information, 29 bytes of memory
/// for the serialized data, 16 bytes for buffer management and 24
/// bytes for the `GVariant` instance, or a total of 160 bytes, plus
/// allocation overhead.  If we were to use [method@GLib.Variant.get_child_value]
/// to access the two dictionary entries, we would use an additional 48
/// bytes.  If we were to have other dictionaries of the same type, we
/// would use more memory for the serialized data and buffer
/// management for those dictionaries, but the type information would
/// be shared.
/// </para>
/// </summary>

public class GVariantHandle : BaseSafeHandle
{
/// <summary>
/// <para>
/// Creates a new #GVariant instance.
/// </para>
/// <para>
/// Think of this function as an analogue to g_strdup_printf().
/// </para>
/// <para>
/// The type of the created instance and the arguments that are expected
/// by this function are determined by @format_string. See the section on
/// [GVariant format strings](gvariant-format-strings.html). Please note that
/// the syntax of the format string is very likely to be extended in the
/// future.
/// </para>
/// <para>
/// The first character of the format string must not be &apos;*&apos; &apos;?&apos; &apos;@&apos; or
/// &apos;r&apos;; in essence, a new #GVariant must always be constructed by this
/// function (and not merely passed through it unmodified).
/// </para>
/// <para>
/// Note that the arguments must be of the correct width for their types
/// specified in @format_string. This can be achieved by casting them. See
/// the [GVariant varargs documentation](gvariant-format-strings.html#varargs).
/// </para>
/// <code>
/// MyFlags some_flags = FLAG_ONE | FLAG_TWO;
/// MyFlags some_flags = FLAG_ONE | FLAG_TWO;
/// const gchar *some_strings[] = { &quot;a&quot;, &quot;b&quot;, &quot;c&quot;, NULL };
/// GVariant *new_variant;
/// 
/// new_variant = g_variant_new (&quot;(t^as)&quot;,
///                              // This cast is required.
///                              (guint64) some_flags,
///                              some_strings);
/// </code>
/// </summary>

/// <param name="format_string">
/// a #GVariant format string
/// </param>
/// <param name="@__arglist">
/// arguments, as per @format_string
/// </param>
/// <return>
/// a new floating #GVariant instance
/// </return>

	public static MentorLake.GLib.GVariantHandle New(string format_string, IntPtr @__arglist)
	{
		return GVariantExterns.g_variant_new(format_string, @__arglist);
	}

/// <summary>
/// <para>
/// Creates a new #GVariant array from @children.
/// </para>
/// <para>
/// @child_type must be non-%NULL if @n_children is zero.  Otherwise, the
/// child type is determined by inspecting the first element of the
/// @children array.  If @child_type is non-%NULL then it must be a
/// definite type.
/// </para>
/// <para>
/// The items of the array are taken from the @children array.  No entry
/// in the @children array may be %NULL.
/// </para>
/// <para>
/// All items in the array must have the same type, which must be the
/// same as @child_type, if given.
/// </para>
/// <para>
/// If the @children are floating references (see g_variant_ref_sink()), the
/// new instance takes ownership of them as if via g_variant_ref_sink().
/// </para>
/// </summary>

/// <param name="child_type">
/// the element type of the new array
/// </param>
/// <param name="children">
/// an array of
///            #GVariant pointers, the children
/// </param>
/// <param name="n_children">
/// the length of @children
/// </param>
/// <return>
/// a floating reference to a new #GVariant array
/// </return>

	public static MentorLake.GLib.GVariantHandle NewArray(MentorLake.GLib.GVariantTypeHandle child_type, MentorLake.GLib.GVariantHandle[] children, UIntPtr n_children)
	{
		return GVariantExterns.g_variant_new_array(child_type, children, n_children);
	}

/// <summary>
/// <para>
/// Creates a new boolean #GVariant instance -- either %TRUE or %FALSE.
/// </para>
/// </summary>

/// <param name="value">
/// a #gboolean value
/// </param>
/// <return>
/// a floating reference to a new boolean #GVariant instance
/// </return>

	public static MentorLake.GLib.GVariantHandle NewBoolean(bool value)
	{
		return GVariantExterns.g_variant_new_boolean(value);
	}

/// <summary>
/// <para>
/// Creates a new byte #GVariant instance.
/// </para>
/// </summary>

/// <param name="value">
/// a #guint8 value
/// </param>
/// <return>
/// a floating reference to a new byte #GVariant instance
/// </return>

	public static MentorLake.GLib.GVariantHandle NewByte(byte value)
	{
		return GVariantExterns.g_variant_new_byte(value);
	}

/// <summary>
/// <para>
/// Creates an array-of-bytes #GVariant with the contents of @string.
/// This function is just like g_variant_new_string() except that the
/// string need not be valid UTF-8.
/// </para>
/// <para>
/// The nul terminator character at the end of the string is stored in
/// the array.
/// </para>
/// </summary>

/// <param name="@string">
/// a normal
///          nul-terminated string in no particular encoding
/// </param>
/// <return>
/// a floating reference to a new bytestring #GVariant instance
/// </return>

	public static MentorLake.GLib.GVariantHandle NewBytestring(byte[] @string)
	{
		return GVariantExterns.g_variant_new_bytestring(@string);
	}

/// <summary>
/// <para>
/// Constructs an array of bytestring #GVariant from the given array of
/// strings.
/// </para>
/// <para>
/// If @length is -1 then @strv is %NULL-terminated.
/// </para>
/// </summary>

/// <param name="strv">
/// an array of strings
/// </param>
/// <param name="length">
/// the length of @strv, or -1
/// </param>
/// <return>
/// a new floating #GVariant instance
/// </return>

	public static MentorLake.GLib.GVariantHandle NewBytestringArray(string[] strv, UIntPtr length)
	{
		return GVariantExterns.g_variant_new_bytestring_array(strv, length);
	}

/// <summary>
/// <para>
/// Creates a new dictionary entry #GVariant. @key and @value must be
/// non-%NULL. @key must be a value of a basic type (ie: not a container).
/// </para>
/// <para>
/// If the @key or @value are floating references (see g_variant_ref_sink()),
/// the new instance takes ownership of them as if via g_variant_ref_sink().
/// </para>
/// </summary>

/// <param name="key">
/// a basic #GVariant, the key
/// </param>
/// <param name="value">
/// a #GVariant, the value
/// </param>
/// <return>
/// a floating reference to a new dictionary entry #GVariant
/// </return>

	public static MentorLake.GLib.GVariantHandle NewDictEntry(MentorLake.GLib.GVariantHandle key, MentorLake.GLib.GVariantHandle value)
	{
		return GVariantExterns.g_variant_new_dict_entry(key, value);
	}

/// <summary>
/// <para>
/// Creates a new double #GVariant instance.
/// </para>
/// </summary>

/// <param name="value">
/// a #gdouble floating point value
/// </param>
/// <return>
/// a floating reference to a new double #GVariant instance
/// </return>

	public static MentorLake.GLib.GVariantHandle NewDouble(double value)
	{
		return GVariantExterns.g_variant_new_double(value);
	}

/// <summary>
/// <para>
/// Constructs a new array #GVariant instance, where the elements are
/// of @element_type type.
/// </para>
/// <para>
/// @elements must be an array with fixed-sized elements.  Numeric types are
/// fixed-size as are tuples containing only other fixed-sized types.
/// </para>
/// <para>
/// @element_size must be the size of a single element in the array.
/// For example, if calling this function for an array of 32-bit integers,
/// you might say sizeof(gint32). This value isn&apos;t used except for the purpose
/// of a double-check that the form of the serialized data matches the caller&apos;s
/// expectation.
/// </para>
/// <para>
/// @n_elements must be the length of the @elements array.
/// </para>
/// </summary>

/// <param name="element_type">
/// the #GVariantType of each element
/// </param>
/// <param name="elements">
/// a pointer to the fixed array of contiguous elements
/// </param>
/// <param name="n_elements">
/// the number of elements
/// </param>
/// <param name="element_size">
/// the size of each element
/// </param>
/// <return>
/// a floating reference to a new array #GVariant instance
/// </return>

	public static MentorLake.GLib.GVariantHandle NewFixedArray(MentorLake.GLib.GVariantTypeHandle element_type, IntPtr elements, UIntPtr n_elements, UIntPtr element_size)
	{
		return GVariantExterns.g_variant_new_fixed_array(element_type, elements, n_elements, element_size);
	}

/// <summary>
/// <para>
/// Constructs a new serialized-mode #GVariant instance.  This is the
/// inner interface for creation of new serialized values that gets
/// called from various functions in gvariant.c.
/// </para>
/// <para>
/// A reference is taken on @bytes.
/// </para>
/// <para>
/// The data in @bytes must be aligned appropriately for the @type being loaded.
/// Otherwise this function will internally create a copy of the memory (since
/// GLib 2.60) or (in older versions) fail and exit the process.
/// </para>
/// </summary>

/// <param name="type">
/// a #GVariantType
/// </param>
/// <param name="bytes">
/// a #GBytes
/// </param>
/// <param name="trusted">
/// if the contents of @bytes are trusted
/// </param>
/// <return>
/// a new #GVariant with a floating reference
/// </return>

	public static MentorLake.GLib.GVariantHandle NewFromBytes(MentorLake.GLib.GVariantTypeHandle type, MentorLake.GLib.GBytesHandle bytes, bool trusted)
	{
		return GVariantExterns.g_variant_new_from_bytes(type, bytes, trusted);
	}

/// <summary>
/// <para>
/// Creates a new #GVariant instance from serialized data.
/// </para>
/// <para>
/// @type is the type of #GVariant instance that will be constructed.
/// The interpretation of @data depends on knowing the type.
/// </para>
/// <para>
/// @data is not modified by this function and must remain valid with an
/// unchanging value until such a time as @notify is called with
/// @user_data.  If the contents of @data change before that time then
/// the result is undefined.
/// </para>
/// <para>
/// If @data is trusted to be serialized data in normal form then
/// @trusted should be %TRUE.  This applies to serialized data created
/// within this process or read from a trusted location on the disk (such
/// as a file installed in /usr/lib alongside your application).  You
/// should set trusted to %FALSE if @data is read from the network, a
/// file in the user&apos;s home directory, etc.
/// </para>
/// <para>
/// If @data was not stored in this machine&apos;s native endianness, any multi-byte
/// numeric values in the returned variant will also be in non-native
/// endianness. g_variant_byteswap() can be used to recover the original values.
/// </para>
/// <para>
/// @notify will be called with @user_data when @data is no longer
/// needed.  The exact time of this call is unspecified and might even be
/// before this function returns.
/// </para>
/// <para>
/// Note: @data must be backed by memory that is aligned appropriately for the
/// @type being loaded. Otherwise this function will internally create a copy of
/// the memory (since GLib 2.60) or (in older versions) fail and exit the
/// process.
/// </para>
/// </summary>

/// <param name="type">
/// a definite #GVariantType
/// </param>
/// <param name="data">
/// the serialized data
/// </param>
/// <param name="size">
/// the size of @data
/// </param>
/// <param name="trusted">
/// %TRUE if @data is definitely in normal form
/// </param>
/// <param name="notify">
/// function to call when @data is no longer needed
/// </param>
/// <param name="user_data">
/// data for @notify
/// </param>
/// <return>
/// a new floating #GVariant of type @type
/// </return>

	public static MentorLake.GLib.GVariantHandle NewFromData(MentorLake.GLib.GVariantTypeHandle type, byte[] data, UIntPtr size, bool trusted, MentorLake.GLib.GDestroyNotify notify, IntPtr user_data)
	{
		return GVariantExterns.g_variant_new_from_data(type, data, size, trusted, notify, user_data);
	}

/// <summary>
/// <para>
/// Creates a new handle #GVariant instance.
/// </para>
/// <para>
/// By convention, handles are indexes into an array of file descriptors
/// that are sent alongside a D-Bus message.  If you&apos;re not interacting
/// with D-Bus, you probably don&apos;t need them.
/// </para>
/// </summary>

/// <param name="value">
/// a #gint32 value
/// </param>
/// <return>
/// a floating reference to a new handle #GVariant instance
/// </return>

	public static MentorLake.GLib.GVariantHandle NewHandle(int value)
	{
		return GVariantExterns.g_variant_new_handle(value);
	}

/// <summary>
/// <para>
/// Creates a new int16 #GVariant instance.
/// </para>
/// </summary>

/// <param name="value">
/// a #gint16 value
/// </param>
/// <return>
/// a floating reference to a new int16 #GVariant instance
/// </return>

	public static MentorLake.GLib.GVariantHandle NewInt16(short value)
	{
		return GVariantExterns.g_variant_new_int16(value);
	}

/// <summary>
/// <para>
/// Creates a new int32 #GVariant instance.
/// </para>
/// </summary>

/// <param name="value">
/// a #gint32 value
/// </param>
/// <return>
/// a floating reference to a new int32 #GVariant instance
/// </return>

	public static MentorLake.GLib.GVariantHandle NewInt32(int value)
	{
		return GVariantExterns.g_variant_new_int32(value);
	}

/// <summary>
/// <para>
/// Creates a new int64 #GVariant instance.
/// </para>
/// </summary>

/// <param name="value">
/// a #gint64 value
/// </param>
/// <return>
/// a floating reference to a new int64 #GVariant instance
/// </return>

	public static MentorLake.GLib.GVariantHandle NewInt64(long value)
	{
		return GVariantExterns.g_variant_new_int64(value);
	}

/// <summary>
/// <para>
/// Depending on if @child is %NULL, either wraps @child inside of a
/// maybe container or creates a Nothing instance for the given @type.
/// </para>
/// <para>
/// At least one of @child_type and @child must be non-%NULL.
/// If @child_type is non-%NULL then it must be a definite type.
/// If they are both non-%NULL then @child_type must be the type
/// of @child.
/// </para>
/// <para>
/// If @child is a floating reference (see g_variant_ref_sink()), the new
/// instance takes ownership of @child.
/// </para>
/// </summary>

/// <param name="child_type">
/// the #GVariantType of the child, or %NULL
/// </param>
/// <param name="child">
/// the child value, or %NULL
/// </param>
/// <return>
/// a floating reference to a new #GVariant maybe instance
/// </return>

	public static MentorLake.GLib.GVariantHandle NewMaybe(MentorLake.GLib.GVariantTypeHandle child_type, MentorLake.GLib.GVariantHandle child)
	{
		return GVariantExterns.g_variant_new_maybe(child_type, child);
	}

/// <summary>
/// <para>
/// Creates a D-Bus object path #GVariant with the contents of @object_path.
/// @object_path must be a valid D-Bus object path.  Use
/// g_variant_is_object_path() if you&apos;re not sure.
/// </para>
/// </summary>

/// <param name="object_path">
/// a normal C nul-terminated string
/// </param>
/// <return>
/// a floating reference to a new object path #GVariant instance
/// </return>

	public static MentorLake.GLib.GVariantHandle NewObjectPath(string object_path)
	{
		return GVariantExterns.g_variant_new_object_path(object_path);
	}

/// <summary>
/// <para>
/// Constructs an array of object paths #GVariant from the given array of
/// strings.
/// </para>
/// <para>
/// Each string must be a valid #GVariant object path; see
/// g_variant_is_object_path().
/// </para>
/// <para>
/// If @length is -1 then @strv is %NULL-terminated.
/// </para>
/// </summary>

/// <param name="strv">
/// an array of strings
/// </param>
/// <param name="length">
/// the length of @strv, or -1
/// </param>
/// <return>
/// a new floating #GVariant instance
/// </return>

	public static MentorLake.GLib.GVariantHandle NewObjv(string[] strv, UIntPtr length)
	{
		return GVariantExterns.g_variant_new_objv(strv, length);
	}

/// <summary>
/// <para>
/// Parses @format and returns the result.
/// </para>
/// <para>
/// @format must be a text format #GVariant with one extension: at any
/// point that a value may appear in the text, a &apos;%&apos; character followed
/// by a GVariant format string (as per g_variant_new()) may appear.  In
/// that case, the same arguments are collected from the argument list as
/// g_variant_new() would have collected.
/// </para>
/// <para>
/// Note that the arguments must be of the correct width for their types
/// specified in @format. This can be achieved by casting them. See
/// the [GVariant varargs documentation](gvariant-format-strings.html#varargs).
/// </para>
/// <para>
/// Consider this simple example:
/// <code>
///  g_variant_new_parsed (&quot;[(&apos;one&apos;, 1), (&apos;two&apos;, %i), (%s, 3)]&quot;, 2, &quot;three&quot;);
///  g_variant_new_parsed (&quot;[(&apos;one&apos;, 1), (&apos;two&apos;, %i), (%s, 3)]&quot;, 2, &quot;three&quot;);
/// </code>
/// In the example, the variable argument parameters are collected and
/// filled in as if they were part of the original string to produce the
/// result of
/// <code>
/// [(&apos;one&apos;, 1), (&apos;two&apos;, 2), (&apos;three&apos;, 3)]
/// [(&apos;one&apos;, 1), (&apos;two&apos;, 2), (&apos;three&apos;, 3)]
/// </code>
/// This function is intended only to be used with @format as a string
/// literal.  Any parse error is fatal to the calling process.  If you
/// want to parse data from untrusted sources, use g_variant_parse().
/// </para>
/// <para>
/// You may not use this function to return, unmodified, a single
/// #GVariant pointer from the argument list.  ie: @format may not solely
/// be anything along the lines of &quot;%*&quot;, &quot;%?&quot;, &quot;\%r&quot;, or anything starting
/// with &quot;%@&quot;.
/// </para>
/// </summary>

/// <param name="format">
/// a text format #GVariant
/// </param>
/// <param name="@__arglist">
/// arguments as per @format
/// </param>
/// <return>
/// a new floating #GVariant instance
/// </return>

	public static MentorLake.GLib.GVariantHandle NewParsed(string format, IntPtr @__arglist)
	{
		return GVariantExterns.g_variant_new_parsed(format, @__arglist);
	}

/// <summary>
/// <para>
/// Parses @format and returns the result.
/// </para>
/// <para>
/// This is the version of g_variant_new_parsed() intended to be used
/// from libraries.
/// </para>
/// <para>
/// The return value will be floating if it was a newly created GVariant
/// instance.  In the case that @format simply specified the collection
/// of a #GVariant pointer (eg: @format was &quot;%*&quot;) then the collected
/// #GVariant pointer will be returned unmodified, without adding any
/// additional references.
/// </para>
/// <para>
/// Note that the arguments in @app must be of the correct width for their types
/// specified in @format when collected into the #va_list. See
/// the [GVariant varargs documentation](gvariant-format-strings.html#varargs).
/// </para>
/// <para>
/// In order to behave correctly in all cases it is necessary for the
/// calling function to g_variant_ref_sink() the return result before
/// returning control to the user that originally provided the pointer.
/// At this point, the caller will have their own full reference to the
/// result.  This can also be done by adding the result to a container,
/// or by passing it to another g_variant_new() call.
/// </para>
/// </summary>

/// <param name="format">
/// a text format #GVariant
/// </param>
/// <param name="app">
/// a pointer to a #va_list
/// </param>
/// <return>
/// a new, usually floating, #GVariant
/// </return>

	public static MentorLake.GLib.GVariantHandle NewParsedVa(string format, IntPtr app)
	{
		return GVariantExterns.g_variant_new_parsed_va(format, app);
	}

/// <summary>
/// <para>
/// Creates a string-type GVariant using printf formatting.
/// </para>
/// <para>
/// This is similar to calling g_strdup_printf() and then
/// g_variant_new_string() but it saves a temporary variable and an
/// unnecessary copy.
/// </para>
/// </summary>

/// <param name="format_string">
/// a printf-style format string
/// </param>
/// <param name="@__arglist">
/// arguments for @format_string
/// </param>
/// <return>
/// a floating reference to a new string
///   #GVariant instance
/// </return>

	public static MentorLake.GLib.GVariantHandle NewPrintf(string format_string, IntPtr @__arglist)
	{
		return GVariantExterns.g_variant_new_printf(format_string, @__arglist);
	}

/// <summary>
/// <para>
/// Creates a D-Bus type signature #GVariant with the contents of
/// @string.  @string must be a valid D-Bus type signature.  Use
/// g_variant_is_signature() if you&apos;re not sure.
/// </para>
/// </summary>

/// <param name="signature">
/// a normal C nul-terminated string
/// </param>
/// <return>
/// a floating reference to a new signature #GVariant instance
/// </return>

	public static MentorLake.GLib.GVariantHandle NewSignature(string signature)
	{
		return GVariantExterns.g_variant_new_signature(signature);
	}

/// <summary>
/// <para>
/// Creates a string #GVariant with the contents of @string.
/// </para>
/// <para>
/// @string must be valid UTF-8, and must not be %NULL. To encode
/// potentially-%NULL strings, use g_variant_new() with `ms` as the
/// [format string](gvariant-format-strings.html#maybe-types).
/// </para>
/// </summary>

/// <param name="@string">
/// a normal UTF-8 nul-terminated string
/// </param>
/// <return>
/// a floating reference to a new string #GVariant instance
/// </return>

	public static MentorLake.GLib.GVariantHandle NewString(string @string)
	{
		return GVariantExterns.g_variant_new_string(@string);
	}

/// <summary>
/// <para>
/// Constructs an array of strings #GVariant from the given array of
/// strings.
/// </para>
/// <para>
/// If @length is -1 then @strv is %NULL-terminated.
/// </para>
/// </summary>

/// <param name="strv">
/// an array of strings
/// </param>
/// <param name="length">
/// the length of @strv, or -1
/// </param>
/// <return>
/// a new floating #GVariant instance
/// </return>

	public static MentorLake.GLib.GVariantHandle NewStrv(string[] strv, UIntPtr length)
	{
		return GVariantExterns.g_variant_new_strv(strv, length);
	}

/// <summary>
/// <para>
/// Creates a string #GVariant with the contents of @string.
/// </para>
/// <para>
/// @string must be valid UTF-8, and must not be %NULL. To encode
/// potentially-%NULL strings, use this with g_variant_new_maybe().
/// </para>
/// <para>
/// After this call, @string belongs to the #GVariant and may no longer be
/// modified by the caller. The memory of @data has to be dynamically
/// allocated and will eventually be freed with g_free().
/// </para>
/// <para>
/// You must not modify or access @string in any other way after passing
/// it to this function.  It is even possible that @string is immediately
/// freed.
/// </para>
/// </summary>

/// <param name="@string">
/// a normal UTF-8 nul-terminated string
/// </param>
/// <return>
/// a floating reference to a new string
///   #GVariant instance
/// </return>

	public static MentorLake.GLib.GVariantHandle NewTakeString(string @string)
	{
		return GVariantExterns.g_variant_new_take_string(@string);
	}

/// <summary>
/// <para>
/// Creates a new tuple #GVariant out of the items in @children.  The
/// type is determined from the types of @children.  No entry in the
/// @children array may be %NULL.
/// </para>
/// <para>
/// If @n_children is 0 then the unit tuple is constructed.
/// </para>
/// <para>
/// If the @children are floating references (see g_variant_ref_sink()), the
/// new instance takes ownership of them as if via g_variant_ref_sink().
/// </para>
/// </summary>

/// <param name="children">
/// the items to make the tuple out of
/// </param>
/// <param name="n_children">
/// the length of @children
/// </param>
/// <return>
/// a floating reference to a new #GVariant tuple
/// </return>

	public static MentorLake.GLib.GVariantHandle NewTuple(MentorLake.GLib.GVariantHandle[] children, UIntPtr n_children)
	{
		return GVariantExterns.g_variant_new_tuple(children, n_children);
	}

/// <summary>
/// <para>
/// Creates a new uint16 #GVariant instance.
/// </para>
/// </summary>

/// <param name="value">
/// a #guint16 value
/// </param>
/// <return>
/// a floating reference to a new uint16 #GVariant instance
/// </return>

	public static MentorLake.GLib.GVariantHandle NewUint16(ushort value)
	{
		return GVariantExterns.g_variant_new_uint16(value);
	}

/// <summary>
/// <para>
/// Creates a new uint32 #GVariant instance.
/// </para>
/// </summary>

/// <param name="value">
/// a #guint32 value
/// </param>
/// <return>
/// a floating reference to a new uint32 #GVariant instance
/// </return>

	public static MentorLake.GLib.GVariantHandle NewUint32(uint value)
	{
		return GVariantExterns.g_variant_new_uint32(value);
	}

/// <summary>
/// <para>
/// Creates a new uint64 #GVariant instance.
/// </para>
/// </summary>

/// <param name="value">
/// a #guint64 value
/// </param>
/// <return>
/// a floating reference to a new uint64 #GVariant instance
/// </return>

	public static MentorLake.GLib.GVariantHandle NewUint64(ulong value)
	{
		return GVariantExterns.g_variant_new_uint64(value);
	}

/// <summary>
/// <para>
/// This function is intended to be used by libraries based on
/// #GVariant that want to provide g_variant_new()-like functionality
/// to their users.
/// </para>
/// <para>
/// The API is more general than g_variant_new() to allow a wider range
/// of possible uses.
/// </para>
/// <para>
/// @format_string must still point to a valid format string, but it only
/// needs to be nul-terminated if @endptr is %NULL.  If @endptr is
/// non-%NULL then it is updated to point to the first character past the
/// end of the format string.
/// </para>
/// <para>
/// @app is a pointer to a #va_list.  The arguments, according to
/// @format_string, are collected from this #va_list and the list is left
/// pointing to the argument following the last.
/// </para>
/// <para>
/// Note that the arguments in @app must be of the correct width for their
/// types specified in @format_string when collected into the #va_list.
/// See the [GVariant varargs documentation](gvariant-format-strings.html#varargs).
/// </para>
/// <para>
/// These two generalisations allow mixing of multiple calls to
/// g_variant_new_va() and g_variant_get_va() within a single actual
/// varargs call by the user.
/// </para>
/// <para>
/// The return value will be floating if it was a newly created GVariant
/// instance (for example, if the format string was &quot;(ii)&quot;).  In the case
/// that the format_string was &apos;*&apos;, &apos;?&apos;, &apos;r&apos;, or a format starting with
/// &apos;@&apos; then the collected #GVariant pointer will be returned unmodified,
/// without adding any additional references.
/// </para>
/// <para>
/// In order to behave correctly in all cases it is necessary for the
/// calling function to g_variant_ref_sink() the return result before
/// returning control to the user that originally provided the pointer.
/// At this point, the caller will have their own full reference to the
/// result.  This can also be done by adding the result to a container,
/// or by passing it to another g_variant_new() call.
/// </para>
/// </summary>

/// <param name="format_string">
/// a string that is prefixed with a format string
/// </param>
/// <param name="endptr">
/// location to store the end pointer,
///          or %NULL
/// </param>
/// <param name="app">
/// a pointer to a #va_list
/// </param>
/// <return>
/// a new, usually floating, #GVariant
/// </return>

	public static MentorLake.GLib.GVariantHandle NewVa(string format_string, string endptr, IntPtr app)
	{
		return GVariantExterns.g_variant_new_va(format_string, endptr, app);
	}

/// <summary>
/// <para>
/// Boxes @value.  The result is a #GVariant instance representing a
/// variant containing the original value.
/// </para>
/// <para>
/// If @child is a floating reference (see g_variant_ref_sink()), the new
/// instance takes ownership of @child.
/// </para>
/// </summary>

/// <param name="value">
/// a #GVariant instance
/// </param>
/// <return>
/// a floating reference to a new variant #GVariant instance
/// </return>

	public static MentorLake.GLib.GVariantHandle NewVariant(MentorLake.GLib.GVariantHandle value)
	{
		return GVariantExterns.g_variant_new_variant(value);
	}

}


public static class GVariantExtensions
{
/// <summary>
/// <para>
/// Performs a byteswapping operation on the contents of @value.  The
/// result is that all multi-byte numeric data contained in @value is
/// byteswapped.  That includes 16, 32, and 64bit signed and unsigned
/// integers as well as file handles and double precision floating point
/// values.
/// </para>
/// <para>
/// This function is an identity mapping on any value that does not
/// contain multi-byte numeric data.  That include strings, booleans,
/// bytes and containers containing only these things (recursively).
/// </para>
/// <para>
/// While this function can safely handle untrusted, non-normal data, it is
/// recommended to check whether the input is in normal form beforehand, using
/// g_variant_is_normal_form(), and to reject non-normal inputs if your
/// application can be strict about what inputs it rejects.
/// </para>
/// <para>
/// The returned value is always in normal form and is marked as trusted.
/// A full, not floating, reference is returned.
/// </para>
/// </summary>

/// <param name="value">
/// a #GVariant
/// </param>
/// <return>
/// the byteswapped form of @value
/// </return>

	public static MentorLake.GLib.GVariantHandle Byteswap(this MentorLake.GLib.GVariantHandle value)
	{
		if (value.IsInvalid) throw new Exception("Invalid handle (GVariant)");
		return GVariantExterns.g_variant_byteswap(value);
	}

/// <summary>
/// <para>
/// Checks if calling g_variant_get() with @format_string on @value would
/// be valid from a type-compatibility standpoint.  @format_string is
/// assumed to be a valid format string (from a syntactic standpoint).
/// </para>
/// <para>
/// If @copy_only is %TRUE then this function additionally checks that it
/// would be safe to call g_variant_unref() on @value immediately after
/// the call to g_variant_get() without invalidating the result.  This is
/// only possible if deep copies are made (ie: there are no pointers to
/// the data inside of the soon-to-be-freed #GVariant instance).  If this
/// check fails then a g_critical() is printed and %FALSE is returned.
/// </para>
/// <para>
/// This function is meant to be used by functions that wish to provide
/// varargs accessors to #GVariant values of uncertain values (eg:
/// g_variant_lookup() or g_menu_model_get_item_attribute()).
/// </para>
/// </summary>

/// <param name="value">
/// a #GVariant
/// </param>
/// <param name="format_string">
/// a valid #GVariant format string
/// </param>
/// <param name="copy_only">
/// %TRUE to ensure the format string makes deep copies
/// </param>
/// <return>
/// %TRUE if @format_string is safe to use
/// </return>

	public static bool CheckFormatString(this MentorLake.GLib.GVariantHandle value, string format_string, bool copy_only)
	{
		if (value.IsInvalid) throw new Exception("Invalid handle (GVariant)");
		return GVariantExterns.g_variant_check_format_string(value, format_string, copy_only);
	}

/// <summary>
/// <para>
/// Classifies @value according to its top-level type.
/// </para>
/// </summary>

/// <param name="value">
/// a #GVariant
/// </param>
/// <return>
/// the #GVariantClass of @value
/// </return>

	public static MentorLake.GLib.GVariantClass Classify(this MentorLake.GLib.GVariantHandle value)
	{
		if (value.IsInvalid) throw new Exception("Invalid handle (GVariant)");
		return GVariantExterns.g_variant_classify(value);
	}

/// <summary>
/// <para>
/// Compares @one and @two.
/// </para>
/// <para>
/// The types of @one and @two are #gconstpointer only to allow use of
/// this function with #GTree, #GPtrArray, etc.  They must each be a
/// #GVariant.
/// </para>
/// <para>
/// Comparison is only defined for basic types (ie: booleans, numbers,
/// strings).  For booleans, %FALSE is less than %TRUE.  Numbers are
/// ordered in the usual way.  Strings are in ASCII lexographical order.
/// </para>
/// <para>
/// It is a programmer error to attempt to compare container values or
/// two values that have types that are not exactly equal.  For example,
/// you cannot compare a 32-bit signed integer with a 32-bit unsigned
/// integer.  Also note that this function is not particularly
/// well-behaved when it comes to comparison of doubles; in particular,
/// the handling of incomparable values (ie: NaN) is undefined.
/// </para>
/// <para>
/// If you only require an equality comparison, g_variant_equal() is more
/// general.
/// </para>
/// </summary>

/// <param name="one">
/// a basic-typed #GVariant instance
/// </param>
/// <param name="two">
/// a #GVariant instance of the same type
/// </param>
/// <return>
/// negative value if a &amp;lt; b;
///          zero if a = b;
///          positive value if a &amp;gt; b.
/// </return>

	public static int Compare(this MentorLake.GLib.GVariantHandle one, MentorLake.GLib.GVariantHandle two)
	{
		if (one.IsInvalid) throw new Exception("Invalid handle (GVariant)");
		return GVariantExterns.g_variant_compare(one, two);
	}

/// <summary>
/// <para>
/// Similar to g_variant_get_bytestring() except that instead of
/// returning a constant string, the string is duplicated.
/// </para>
/// <para>
/// The return value must be freed using g_free().
/// </para>
/// </summary>

/// <param name="value">
/// an array-of-bytes #GVariant instance
/// </param>
/// <param name="length">
/// a pointer to a #gsize, to store
///          the length (not including the nul terminator)
/// </param>
/// <return>
/// 
///          a newly allocated string
/// </return>

	public static byte[] DupBytestring(this MentorLake.GLib.GVariantHandle value, out UIntPtr length)
	{
		if (value.IsInvalid) throw new Exception("Invalid handle (GVariant)");
		return GVariantExterns.g_variant_dup_bytestring(value, out length);
	}

/// <summary>
/// <para>
/// Gets the contents of an array of array of bytes #GVariant.  This call
/// makes a deep copy; the return result should be released with
/// g_strfreev().
/// </para>
/// <para>
/// If @length is non-%NULL then the number of elements in the result is
/// stored there.  In any case, the resulting array will be
/// %NULL-terminated.
/// </para>
/// <para>
/// For an empty array, @length will be set to 0 and a pointer to a
/// %NULL pointer will be returned.
/// </para>
/// </summary>

/// <param name="value">
/// an array of array of bytes #GVariant (&apos;aay&apos;)
/// </param>
/// <param name="length">
/// the length of the result, or %NULL
/// </param>
/// <return>
/// an array of strings
/// </return>

	public static string[] DupBytestringArray(this MentorLake.GLib.GVariantHandle value, out UIntPtr length)
	{
		if (value.IsInvalid) throw new Exception("Invalid handle (GVariant)");
		return GVariantExterns.g_variant_dup_bytestring_array(value, out length);
	}

/// <summary>
/// <para>
/// Gets the contents of an array of object paths #GVariant.  This call
/// makes a deep copy; the return result should be released with
/// g_strfreev().
/// </para>
/// <para>
/// If @length is non-%NULL then the number of elements in the result
/// is stored there.  In any case, the resulting array will be
/// %NULL-terminated.
/// </para>
/// <para>
/// For an empty array, @length will be set to 0 and a pointer to a
/// %NULL pointer will be returned.
/// </para>
/// </summary>

/// <param name="value">
/// an array of object paths #GVariant
/// </param>
/// <param name="length">
/// the length of the result, or %NULL
/// </param>
/// <return>
/// an array of strings
/// </return>

	public static string[] DupObjv(this MentorLake.GLib.GVariantHandle value, out UIntPtr length)
	{
		if (value.IsInvalid) throw new Exception("Invalid handle (GVariant)");
		return GVariantExterns.g_variant_dup_objv(value, out length);
	}

/// <summary>
/// <para>
/// Similar to g_variant_get_string() except that instead of returning
/// a constant string, the string is duplicated.
/// </para>
/// <para>
/// The string will always be UTF-8 encoded.
/// </para>
/// <para>
/// The return value must be freed using g_free().
/// </para>
/// </summary>

/// <param name="value">
/// a string #GVariant instance
/// </param>
/// <param name="length">
/// a pointer to a #gsize, to store the length
/// </param>
/// <return>
/// a newly allocated string, UTF-8 encoded
/// </return>

	public static string DupString(this MentorLake.GLib.GVariantHandle value, out UIntPtr length)
	{
		if (value.IsInvalid) throw new Exception("Invalid handle (GVariant)");
		return GVariantExterns.g_variant_dup_string(value, out length);
	}

/// <summary>
/// <para>
/// Gets the contents of an array of strings #GVariant.  This call
/// makes a deep copy; the return result should be released with
/// g_strfreev().
/// </para>
/// <para>
/// If @length is non-%NULL then the number of elements in the result
/// is stored there.  In any case, the resulting array will be
/// %NULL-terminated.
/// </para>
/// <para>
/// For an empty array, @length will be set to 0 and a pointer to a
/// %NULL pointer will be returned.
/// </para>
/// </summary>

/// <param name="value">
/// an array of strings #GVariant
/// </param>
/// <param name="length">
/// the length of the result, or %NULL
/// </param>
/// <return>
/// an array of strings
/// </return>

	public static string[] DupStrv(this MentorLake.GLib.GVariantHandle value, out UIntPtr length)
	{
		if (value.IsInvalid) throw new Exception("Invalid handle (GVariant)");
		return GVariantExterns.g_variant_dup_strv(value, out length);
	}

/// <summary>
/// <para>
/// Checks if @one and @two have the same type and value.
/// </para>
/// <para>
/// The types of @one and @two are #gconstpointer only to allow use of
/// this function with #GHashTable.  They must each be a #GVariant.
/// </para>
/// </summary>

/// <param name="one">
/// a #GVariant instance
/// </param>
/// <param name="two">
/// a #GVariant instance
/// </param>
/// <return>
/// %TRUE if @one and @two are equal
/// </return>

	public static bool Equal(this MentorLake.GLib.GVariantHandle one, MentorLake.GLib.GVariantHandle two)
	{
		if (one.IsInvalid) throw new Exception("Invalid handle (GVariant)");
		return GVariantExterns.g_variant_equal(one, two);
	}

/// <summary>
/// <para>
/// Deconstructs a #GVariant instance.
/// </para>
/// <para>
/// Think of this function as an analogue to scanf().
/// </para>
/// <para>
/// The arguments that are expected by this function are entirely
/// determined by @format_string.  @format_string also restricts the
/// permissible types of @value.  It is an error to give a value with
/// an incompatible type.  See the section on
/// [GVariant format strings](gvariant-format-strings.html).
/// Please note that the syntax of the format string is very likely to be
/// extended in the future.
/// </para>
/// <para>
/// @format_string determines the C types that are used for unpacking
/// the values and also determines if the values are copied or borrowed,
/// see the section on
/// [`GVariant` format strings](gvariant-format-strings.html#pointers).
/// </para>
/// </summary>

/// <param name="value">
/// a #GVariant instance
/// </param>
/// <param name="format_string">
/// a #GVariant format string
/// </param>
/// <param name="@__arglist">
/// arguments, as per @format_string
/// </param>

	public static void Get(this MentorLake.GLib.GVariantHandle value, string format_string, IntPtr @__arglist)
	{
		if (value.IsInvalid) throw new Exception("Invalid handle (GVariant)");
		GVariantExterns.g_variant_get(value, format_string, @__arglist);
	}

/// <summary>
/// <para>
/// Returns the boolean value of @value.
/// </para>
/// <para>
/// It is an error to call this function with a @value of any type
/// other than %G_VARIANT_TYPE_BOOLEAN.
/// </para>
/// </summary>

/// <param name="value">
/// a boolean #GVariant instance
/// </param>
/// <return>
/// %TRUE or %FALSE
/// </return>

	public static bool GetBoolean(this MentorLake.GLib.GVariantHandle value)
	{
		if (value.IsInvalid) throw new Exception("Invalid handle (GVariant)");
		return GVariantExterns.g_variant_get_boolean(value);
	}

/// <summary>
/// <para>
/// Returns the byte value of @value.
/// </para>
/// <para>
/// It is an error to call this function with a @value of any type
/// other than %G_VARIANT_TYPE_BYTE.
/// </para>
/// </summary>

/// <param name="value">
/// a byte #GVariant instance
/// </param>
/// <return>
/// a #guint8
/// </return>

	public static byte GetByte(this MentorLake.GLib.GVariantHandle value)
	{
		if (value.IsInvalid) throw new Exception("Invalid handle (GVariant)");
		return GVariantExterns.g_variant_get_byte(value);
	}

/// <summary>
/// <para>
/// Returns the string value of a #GVariant instance with an
/// array-of-bytes type.  The string has no particular encoding.
/// </para>
/// <para>
/// If the array does not end with a nul terminator character, the empty
/// string is returned.  For this reason, you can always trust that a
/// non-%NULL nul-terminated string will be returned by this function.
/// </para>
/// <para>
/// If the array contains a nul terminator character somewhere other than
/// the last byte then the returned string is the string, up to the first
/// such nul character.
/// </para>
/// <para>
/// g_variant_get_fixed_array() should be used instead if the array contains
/// arbitrary data that could not be nul-terminated or could contain nul bytes.
/// </para>
/// <para>
/// It is an error to call this function with a @value that is not an
/// array of bytes.
/// </para>
/// <para>
/// The return value remains valid as long as @value exists.
/// </para>
/// </summary>

/// <param name="value">
/// an array-of-bytes #GVariant instance
/// </param>
/// <return>
/// 
///          the constant string
/// </return>

	public static byte[] GetBytestring(this MentorLake.GLib.GVariantHandle value)
	{
		if (value.IsInvalid) throw new Exception("Invalid handle (GVariant)");
		return GVariantExterns.g_variant_get_bytestring(value);
	}

/// <summary>
/// <para>
/// Gets the contents of an array of array of bytes #GVariant.  This call
/// makes a shallow copy; the return result should be released with
/// g_free(), but the individual strings must not be modified.
/// </para>
/// <para>
/// If @length is non-%NULL then the number of elements in the result is
/// stored there.  In any case, the resulting array will be
/// %NULL-terminated.
/// </para>
/// <para>
/// For an empty array, @length will be set to 0 and a pointer to a
/// %NULL pointer will be returned.
/// </para>
/// </summary>

/// <param name="value">
/// an array of array of bytes #GVariant (&apos;aay&apos;)
/// </param>
/// <param name="length">
/// the length of the result, or %NULL
/// </param>
/// <return>
/// an array of constant strings
/// </return>

	public static string[] GetBytestringArray(this MentorLake.GLib.GVariantHandle value, out UIntPtr length)
	{
		if (value.IsInvalid) throw new Exception("Invalid handle (GVariant)");
		return GVariantExterns.g_variant_get_bytestring_array(value, out length);
	}

/// <summary>
/// <para>
/// Reads a child item out of a container #GVariant instance and
/// deconstructs it according to @format_string.  This call is
/// essentially a combination of g_variant_get_child_value() and
/// g_variant_get().
/// </para>
/// <para>
/// @format_string determines the C types that are used for unpacking
/// the values and also determines if the values are copied or borrowed,
/// see the section on
/// [`GVariant` format strings](gvariant-format-strings.html#pointers).
/// </para>
/// </summary>

/// <param name="value">
/// a container #GVariant
/// </param>
/// <param name="index_">
/// the index of the child to deconstruct
/// </param>
/// <param name="format_string">
/// a #GVariant format string
/// </param>
/// <param name="@__arglist">
/// arguments, as per @format_string
/// </param>

	public static void GetChild(this MentorLake.GLib.GVariantHandle value, UIntPtr index_, string format_string, IntPtr @__arglist)
	{
		if (value.IsInvalid) throw new Exception("Invalid handle (GVariant)");
		GVariantExterns.g_variant_get_child(value, index_, format_string, @__arglist);
	}

/// <summary>
/// <para>
/// Reads a child item out of a container #GVariant instance.  This
/// includes variants, maybes, arrays, tuples and dictionary
/// entries.  It is an error to call this function on any other type of
/// #GVariant.
/// </para>
/// <para>
/// It is an error if @index_ is greater than the number of child items
/// in the container.  See g_variant_n_children().
/// </para>
/// <para>
/// The returned value is never floating.  You should free it with
/// g_variant_unref() when you&apos;re done with it.
/// </para>
/// <para>
/// Note that values borrowed from the returned child are not guaranteed to
/// still be valid after the child is freed even if you still hold a reference
/// to @value, if @value has not been serialized at the time this function is
/// called. To avoid this, you can serialize @value by calling
/// g_variant_get_data() and optionally ignoring the return value.
/// </para>
/// <para>
/// There may be implementation specific restrictions on deeply nested values,
/// which would result in the unit tuple being returned as the child value,
/// instead of further nested children. #GVariant is guaranteed to handle
/// nesting up to at least 64 levels.
/// </para>
/// <para>
/// This function is O(1).
/// </para>
/// </summary>

/// <param name="value">
/// a container #GVariant
/// </param>
/// <param name="index_">
/// the index of the child to fetch
/// </param>
/// <return>
/// the child at the specified index
/// </return>

	public static MentorLake.GLib.GVariantHandle GetChildValue(this MentorLake.GLib.GVariantHandle value, UIntPtr index_)
	{
		if (value.IsInvalid) throw new Exception("Invalid handle (GVariant)");
		return GVariantExterns.g_variant_get_child_value(value, index_);
	}

/// <summary>
/// <para>
/// Returns a pointer to the serialized form of a #GVariant instance.
/// The returned data may not be in fully-normalised form if read from an
/// untrusted source.  The returned data must not be freed; it remains
/// valid for as long as @value exists.
/// </para>
/// <para>
/// If @value is a fixed-sized value that was deserialized from a
/// corrupted serialized container then %NULL may be returned.  In this
/// case, the proper thing to do is typically to use the appropriate
/// number of nul bytes in place of @value.  If @value is not fixed-sized
/// then %NULL is never returned.
/// </para>
/// <para>
/// In the case that @value is already in serialized form, this function
/// is O(1).  If the value is not already in serialized form,
/// serialization occurs implicitly and is approximately O(n) in the size
/// of the result.
/// </para>
/// <para>
/// To deserialize the data returned by this function, in addition to the
/// serialized data, you must know the type of the #GVariant, and (if the
/// machine might be different) the endianness of the machine that stored
/// it. As a result, file formats or network messages that incorporate
/// serialized #GVariants must include this information either
/// implicitly (for instance &quot;the file always contains a
/// %G_VARIANT_TYPE_VARIANT and it is always in little-endian order&quot;) or
/// explicitly (by storing the type and/or endianness in addition to the
/// serialized data).
/// </para>
/// </summary>

/// <param name="value">
/// a #GVariant instance
/// </param>
/// <return>
/// the serialized form of @value, or %NULL
/// </return>

	public static IntPtr GetData(this MentorLake.GLib.GVariantHandle value)
	{
		if (value.IsInvalid) throw new Exception("Invalid handle (GVariant)");
		return GVariantExterns.g_variant_get_data(value);
	}

/// <summary>
/// <para>
/// Returns a pointer to the serialized form of a #GVariant instance.
/// The semantics of this function are exactly the same as
/// g_variant_get_data(), except that the returned #GBytes holds
/// a reference to the variant data.
/// </para>
/// </summary>

/// <param name="value">
/// a #GVariant
/// </param>
/// <return>
/// A new #GBytes representing the variant data
/// </return>

	public static MentorLake.GLib.GBytesHandle GetDataAsBytes(this MentorLake.GLib.GVariantHandle value)
	{
		if (value.IsInvalid) throw new Exception("Invalid handle (GVariant)");
		return GVariantExterns.g_variant_get_data_as_bytes(value);
	}

/// <summary>
/// <para>
/// Returns the double precision floating point value of @value.
/// </para>
/// <para>
/// It is an error to call this function with a @value of any type
/// other than %G_VARIANT_TYPE_DOUBLE.
/// </para>
/// </summary>

/// <param name="value">
/// a double #GVariant instance
/// </param>
/// <return>
/// a #gdouble
/// </return>

	public static double GetDouble(this MentorLake.GLib.GVariantHandle value)
	{
		if (value.IsInvalid) throw new Exception("Invalid handle (GVariant)");
		return GVariantExterns.g_variant_get_double(value);
	}

/// <summary>
/// <para>
/// Provides access to the serialized data for an array of fixed-sized
/// items.
/// </para>
/// <para>
/// @value must be an array with fixed-sized elements.  Numeric types are
/// fixed-size, as are tuples containing only other fixed-sized types.
/// </para>
/// <para>
/// @element_size must be the size of a single element in the array,
/// as given by the section on
/// [serialized data memory](struct.Variant.html#serialized-data-memory).
/// </para>
/// <para>
/// In particular, arrays of these fixed-sized types can be interpreted
/// as an array of the given C type, with @element_size set to the size
/// the appropriate type:
/// - %G_VARIANT_TYPE_INT16 (etc.): #gint16 (etc.)
/// - %G_VARIANT_TYPE_BOOLEAN: #guchar (not #gboolean!)
/// - %G_VARIANT_TYPE_BYTE: #guint8
/// - %G_VARIANT_TYPE_HANDLE: #guint32
/// - %G_VARIANT_TYPE_DOUBLE: #gdouble
/// </para>
/// <para>
/// For example, if calling this function for an array of 32-bit integers,
/// you might say `sizeof(gint32)`. This value isn&apos;t used except for the purpose
/// of a double-check that the form of the serialized data matches the caller&apos;s
/// expectation.
/// </para>
/// <para>
/// @n_elements, which must be non-%NULL, is set equal to the number of
/// items in the array.
/// </para>
/// </summary>

/// <param name="value">
/// a #GVariant array with fixed-sized elements
/// </param>
/// <param name="n_elements">
/// a pointer to the location to store the number of items
/// </param>
/// <param name="element_size">
/// the size of each element
/// </param>
/// <return>
/// a pointer to
///     the fixed array
/// </return>

	public static IntPtr[] GetFixedArray(this MentorLake.GLib.GVariantHandle value, out UIntPtr n_elements, UIntPtr element_size)
	{
		if (value.IsInvalid) throw new Exception("Invalid handle (GVariant)");
		return GVariantExterns.g_variant_get_fixed_array(value, out n_elements, element_size);
	}

/// <summary>
/// <para>
/// Returns the 32-bit signed integer value of @value.
/// </para>
/// <para>
/// It is an error to call this function with a @value of any type other
/// than %G_VARIANT_TYPE_HANDLE.
/// </para>
/// <para>
/// By convention, handles are indexes into an array of file descriptors
/// that are sent alongside a D-Bus message.  If you&apos;re not interacting
/// with D-Bus, you probably don&apos;t need them.
/// </para>
/// </summary>

/// <param name="value">
/// a handle #GVariant instance
/// </param>
/// <return>
/// a #gint32
/// </return>

	public static int GetHandle(this MentorLake.GLib.GVariantHandle value)
	{
		if (value.IsInvalid) throw new Exception("Invalid handle (GVariant)");
		return GVariantExterns.g_variant_get_handle(value);
	}

/// <summary>
/// <para>
/// Returns the 16-bit signed integer value of @value.
/// </para>
/// <para>
/// It is an error to call this function with a @value of any type
/// other than %G_VARIANT_TYPE_INT16.
/// </para>
/// </summary>

/// <param name="value">
/// an int16 #GVariant instance
/// </param>
/// <return>
/// a #gint16
/// </return>

	public static short GetInt16(this MentorLake.GLib.GVariantHandle value)
	{
		if (value.IsInvalid) throw new Exception("Invalid handle (GVariant)");
		return GVariantExterns.g_variant_get_int16(value);
	}

/// <summary>
/// <para>
/// Returns the 32-bit signed integer value of @value.
/// </para>
/// <para>
/// It is an error to call this function with a @value of any type
/// other than %G_VARIANT_TYPE_INT32.
/// </para>
/// </summary>

/// <param name="value">
/// an int32 #GVariant instance
/// </param>
/// <return>
/// a #gint32
/// </return>

	public static int GetInt32(this MentorLake.GLib.GVariantHandle value)
	{
		if (value.IsInvalid) throw new Exception("Invalid handle (GVariant)");
		return GVariantExterns.g_variant_get_int32(value);
	}

/// <summary>
/// <para>
/// Returns the 64-bit signed integer value of @value.
/// </para>
/// <para>
/// It is an error to call this function with a @value of any type
/// other than %G_VARIANT_TYPE_INT64.
/// </para>
/// </summary>

/// <param name="value">
/// an int64 #GVariant instance
/// </param>
/// <return>
/// a #gint64
/// </return>

	public static long GetInt64(this MentorLake.GLib.GVariantHandle value)
	{
		if (value.IsInvalid) throw new Exception("Invalid handle (GVariant)");
		return GVariantExterns.g_variant_get_int64(value);
	}

/// <summary>
/// <para>
/// Given a maybe-typed #GVariant instance, extract its value.  If the
/// value is Nothing, then this function returns %NULL.
/// </para>
/// </summary>

/// <param name="value">
/// a maybe-typed value
/// </param>
/// <return>
/// the contents of @value, or %NULL
/// </return>

	public static MentorLake.GLib.GVariantHandle GetMaybe(this MentorLake.GLib.GVariantHandle value)
	{
		if (value.IsInvalid) throw new Exception("Invalid handle (GVariant)");
		return GVariantExterns.g_variant_get_maybe(value);
	}

/// <summary>
/// <para>
/// Gets a #GVariant instance that has the same value as @value and is
/// trusted to be in normal form.
/// </para>
/// <para>
/// If @value is already trusted to be in normal form then a new
/// reference to @value is returned.
/// </para>
/// <para>
/// If @value is not already trusted, then it is scanned to check if it
/// is in normal form.  If it is found to be in normal form then it is
/// marked as trusted and a new reference to it is returned.
/// </para>
/// <para>
/// If @value is found not to be in normal form then a new trusted
/// #GVariant is created with the same value as @value. The non-normal parts of
/// @value will be replaced with default values which are guaranteed to be in
/// normal form.
/// </para>
/// <para>
/// It makes sense to call this function if you&apos;ve received #GVariant
/// data from untrusted sources and you want to ensure your serialized
/// output is definitely in normal form.
/// </para>
/// <para>
/// If @value is already in normal form, a new reference will be returned
/// (which will be floating if @value is floating). If it is not in normal form,
/// the newly created #GVariant will be returned with a single non-floating
/// reference. Typically, g_variant_take_ref() should be called on the return
/// value from this function to guarantee ownership of a single non-floating
/// reference to it.
/// </para>
/// </summary>

/// <param name="value">
/// a #GVariant
/// </param>
/// <return>
/// a trusted #GVariant
/// </return>

	public static MentorLake.GLib.GVariantHandle GetNormalForm(this MentorLake.GLib.GVariantHandle value)
	{
		if (value.IsInvalid) throw new Exception("Invalid handle (GVariant)");
		return GVariantExterns.g_variant_get_normal_form(value);
	}

/// <summary>
/// <para>
/// Gets the contents of an array of object paths #GVariant.  This call
/// makes a shallow copy; the return result should be released with
/// g_free(), but the individual strings must not be modified.
/// </para>
/// <para>
/// If @length is non-%NULL then the number of elements in the result
/// is stored there.  In any case, the resulting array will be
/// %NULL-terminated.
/// </para>
/// <para>
/// For an empty array, @length will be set to 0 and a pointer to a
/// %NULL pointer will be returned.
/// </para>
/// </summary>

/// <param name="value">
/// an array of object paths #GVariant
/// </param>
/// <param name="length">
/// the length of the result, or %NULL
/// </param>
/// <return>
/// an array of constant strings
/// </return>

	public static string[] GetObjv(this MentorLake.GLib.GVariantHandle value, out UIntPtr length)
	{
		if (value.IsInvalid) throw new Exception("Invalid handle (GVariant)");
		return GVariantExterns.g_variant_get_objv(value, out length);
	}

/// <summary>
/// <para>
/// Determines the number of bytes that would be required to store @value
/// with g_variant_store().
/// </para>
/// <para>
/// If @value has a fixed-sized type then this function always returned
/// that fixed size.
/// </para>
/// <para>
/// In the case that @value is already in serialized form or the size has
/// already been calculated (ie: this function has been called before)
/// then this function is O(1).  Otherwise, the size is calculated, an
/// operation which is approximately O(n) in the number of values
/// involved.
/// </para>
/// </summary>

/// <param name="value">
/// a #GVariant instance
/// </param>
/// <return>
/// the serialized size of @value
/// </return>

	public static UIntPtr GetSize(this MentorLake.GLib.GVariantHandle value)
	{
		if (value.IsInvalid) throw new Exception("Invalid handle (GVariant)");
		return GVariantExterns.g_variant_get_size(value);
	}

/// <summary>
/// <para>
/// Returns the string value of a #GVariant instance with a string
/// type.  This includes the types %G_VARIANT_TYPE_STRING,
/// %G_VARIANT_TYPE_OBJECT_PATH and %G_VARIANT_TYPE_SIGNATURE.
/// </para>
/// <para>
/// The string will always be UTF-8 encoded, will never be %NULL, and will never
/// contain nul bytes.
/// </para>
/// <para>
/// If @length is non-%NULL then the length of the string (in bytes) is
/// returned there.  For trusted values, this information is already
/// known.  Untrusted values will be validated and, if valid, a strlen() will be
/// performed. If invalid, a default value will be returned — for
/// %G_VARIANT_TYPE_OBJECT_PATH, this is `&quot;/&quot;`, and for other types it is the
/// empty string.
/// </para>
/// <para>
/// It is an error to call this function with a @value of any type
/// other than those three.
/// </para>
/// <para>
/// The return value remains valid as long as @value exists.
/// </para>
/// </summary>

/// <param name="value">
/// a string #GVariant instance
/// </param>
/// <param name="length">
/// a pointer to a #gsize,
///          to store the length
/// </param>
/// <return>
/// the constant string, UTF-8 encoded
/// </return>

	public static string GetString(this MentorLake.GLib.GVariantHandle value, out UIntPtr length)
	{
		if (value.IsInvalid) throw new Exception("Invalid handle (GVariant)");
		return GVariantExterns.g_variant_get_string(value, out length);
	}

/// <summary>
/// <para>
/// Gets the contents of an array of strings #GVariant.  This call
/// makes a shallow copy; the return result should be released with
/// g_free(), but the individual strings must not be modified.
/// </para>
/// <para>
/// If @length is non-%NULL then the number of elements in the result
/// is stored there.  In any case, the resulting array will be
/// %NULL-terminated.
/// </para>
/// <para>
/// For an empty array, @length will be set to 0 and a pointer to a
/// %NULL pointer will be returned.
/// </para>
/// </summary>

/// <param name="value">
/// an array of strings #GVariant
/// </param>
/// <param name="length">
/// the length of the result, or %NULL
/// </param>
/// <return>
/// an array of constant strings
/// </return>

	public static string[] GetStrv(this MentorLake.GLib.GVariantHandle value, out UIntPtr length)
	{
		if (value.IsInvalid) throw new Exception("Invalid handle (GVariant)");
		return GVariantExterns.g_variant_get_strv(value, out length);
	}

/// <summary>
/// <para>
/// Determines the type of @value.
/// </para>
/// <para>
/// The return value is valid for the lifetime of @value and must not
/// be freed.
/// </para>
/// </summary>

/// <param name="value">
/// a #GVariant
/// </param>
/// <return>
/// a #GVariantType
/// </return>

	public static MentorLake.GLib.GVariantTypeHandle GetType(this MentorLake.GLib.GVariantHandle value)
	{
		if (value.IsInvalid) throw new Exception("Invalid handle (GVariant)");
		return GVariantExterns.g_variant_get_type(value);
	}

/// <summary>
/// <para>
/// Returns the type string of @value.  Unlike the result of calling
/// g_variant_type_peek_string(), this string is nul-terminated.  This
/// string belongs to #GVariant and must not be freed.
/// </para>
/// </summary>

/// <param name="value">
/// a #GVariant
/// </param>
/// <return>
/// the type string for the type of @value
/// </return>

	public static string GetTypeString(this MentorLake.GLib.GVariantHandle value)
	{
		if (value.IsInvalid) throw new Exception("Invalid handle (GVariant)");
		return GVariantExterns.g_variant_get_type_string(value);
	}

/// <summary>
/// <para>
/// Returns the 16-bit unsigned integer value of @value.
/// </para>
/// <para>
/// It is an error to call this function with a @value of any type
/// other than %G_VARIANT_TYPE_UINT16.
/// </para>
/// </summary>

/// <param name="value">
/// a uint16 #GVariant instance
/// </param>
/// <return>
/// a #guint16
/// </return>

	public static ushort GetUint16(this MentorLake.GLib.GVariantHandle value)
	{
		if (value.IsInvalid) throw new Exception("Invalid handle (GVariant)");
		return GVariantExterns.g_variant_get_uint16(value);
	}

/// <summary>
/// <para>
/// Returns the 32-bit unsigned integer value of @value.
/// </para>
/// <para>
/// It is an error to call this function with a @value of any type
/// other than %G_VARIANT_TYPE_UINT32.
/// </para>
/// </summary>

/// <param name="value">
/// a uint32 #GVariant instance
/// </param>
/// <return>
/// a #guint32
/// </return>

	public static uint GetUint32(this MentorLake.GLib.GVariantHandle value)
	{
		if (value.IsInvalid) throw new Exception("Invalid handle (GVariant)");
		return GVariantExterns.g_variant_get_uint32(value);
	}

/// <summary>
/// <para>
/// Returns the 64-bit unsigned integer value of @value.
/// </para>
/// <para>
/// It is an error to call this function with a @value of any type
/// other than %G_VARIANT_TYPE_UINT64.
/// </para>
/// </summary>

/// <param name="value">
/// a uint64 #GVariant instance
/// </param>
/// <return>
/// a #guint64
/// </return>

	public static ulong GetUint64(this MentorLake.GLib.GVariantHandle value)
	{
		if (value.IsInvalid) throw new Exception("Invalid handle (GVariant)");
		return GVariantExterns.g_variant_get_uint64(value);
	}

/// <summary>
/// <para>
/// This function is intended to be used by libraries based on #GVariant
/// that want to provide g_variant_get()-like functionality to their
/// users.
/// </para>
/// <para>
/// The API is more general than g_variant_get() to allow a wider range
/// of possible uses.
/// </para>
/// <para>
/// @format_string must still point to a valid format string, but it only
/// need to be nul-terminated if @endptr is %NULL.  If @endptr is
/// non-%NULL then it is updated to point to the first character past the
/// end of the format string.
/// </para>
/// <para>
/// @app is a pointer to a #va_list.  The arguments, according to
/// @format_string, are collected from this #va_list and the list is left
/// pointing to the argument following the last.
/// </para>
/// <para>
/// These two generalisations allow mixing of multiple calls to
/// g_variant_new_va() and g_variant_get_va() within a single actual
/// varargs call by the user.
/// </para>
/// <para>
/// @format_string determines the C types that are used for unpacking
/// the values and also determines if the values are copied or borrowed,
/// see the section on
/// [`GVariant` format strings](gvariant-format-strings.html#pointers).
/// </para>
/// </summary>

/// <param name="value">
/// a #GVariant
/// </param>
/// <param name="format_string">
/// a string that is prefixed with a format string
/// </param>
/// <param name="endptr">
/// location to store the end pointer,
///          or %NULL
/// </param>
/// <param name="app">
/// a pointer to a #va_list
/// </param>

	public static void GetVa(this MentorLake.GLib.GVariantHandle value, string format_string, string endptr, IntPtr app)
	{
		if (value.IsInvalid) throw new Exception("Invalid handle (GVariant)");
		GVariantExterns.g_variant_get_va(value, format_string, endptr, app);
	}

/// <summary>
/// <para>
/// Unboxes @value.  The result is the #GVariant instance that was
/// contained in @value.
/// </para>
/// </summary>

/// <param name="value">
/// a variant #GVariant instance
/// </param>
/// <return>
/// the item contained in the variant
/// </return>

	public static MentorLake.GLib.GVariantHandle GetVariant(this MentorLake.GLib.GVariantHandle value)
	{
		if (value.IsInvalid) throw new Exception("Invalid handle (GVariant)");
		return GVariantExterns.g_variant_get_variant(value);
	}

/// <summary>
/// <para>
/// Generates a hash value for a #GVariant instance.
/// </para>
/// <para>
/// The output of this function is guaranteed to be the same for a given
/// value only per-process.  It may change between different processor
/// architectures or even different versions of GLib.  Do not use this
/// function as a basis for building protocols or file formats.
/// </para>
/// <para>
/// The type of @value is #gconstpointer only to allow use of this
/// function with #GHashTable.  @value must be a #GVariant.
/// </para>
/// </summary>

/// <param name="value">
/// a basic #GVariant value as a #gconstpointer
/// </param>
/// <return>
/// a hash value corresponding to @value
/// </return>

	public static uint Hash(this MentorLake.GLib.GVariantHandle value)
	{
		if (value.IsInvalid) throw new Exception("Invalid handle (GVariant)");
		return GVariantExterns.g_variant_hash(value);
	}

/// <summary>
/// <para>
/// Checks if @value is a container.
/// </para>
/// </summary>

/// <param name="value">
/// a #GVariant instance
/// </param>
/// <return>
/// %TRUE if @value is a container
/// </return>

	public static bool IsContainer(this MentorLake.GLib.GVariantHandle value)
	{
		if (value.IsInvalid) throw new Exception("Invalid handle (GVariant)");
		return GVariantExterns.g_variant_is_container(value);
	}

/// <summary>
/// <para>
/// Checks whether @value has a floating reference count.
/// </para>
/// <para>
/// This function should only ever be used to assert that a given variant
/// is or is not floating, or for debug purposes. To acquire a reference
/// to a variant that might be floating, always use g_variant_ref_sink()
/// or g_variant_take_ref().
/// </para>
/// <para>
/// See g_variant_ref_sink() for more information about floating reference
/// counts.
/// </para>
/// </summary>

/// <param name="value">
/// a #GVariant
/// </param>
/// <return>
/// whether @value is floating
/// </return>

	public static bool IsFloating(this MentorLake.GLib.GVariantHandle value)
	{
		if (value.IsInvalid) throw new Exception("Invalid handle (GVariant)");
		return GVariantExterns.g_variant_is_floating(value);
	}

/// <summary>
/// <para>
/// Checks if @value is in normal form.
/// </para>
/// <para>
/// The main reason to do this is to detect if a given chunk of
/// serialized data is in normal form: load the data into a #GVariant
/// using g_variant_new_from_data() and then use this function to
/// check.
/// </para>
/// <para>
/// If @value is found to be in normal form then it will be marked as
/// being trusted.  If the value was already marked as being trusted then
/// this function will immediately return %TRUE.
/// </para>
/// <para>
/// There may be implementation specific restrictions on deeply nested values.
/// GVariant is guaranteed to handle nesting up to at least 64 levels.
/// </para>
/// </summary>

/// <param name="value">
/// a #GVariant instance
/// </param>
/// <return>
/// %TRUE if @value is in normal form
/// </return>

	public static bool IsNormalForm(this MentorLake.GLib.GVariantHandle value)
	{
		if (value.IsInvalid) throw new Exception("Invalid handle (GVariant)");
		return GVariantExterns.g_variant_is_normal_form(value);
	}

/// <summary>
/// <para>
/// Checks if a value has a type matching the provided type.
/// </para>
/// </summary>

/// <param name="value">
/// a #GVariant instance
/// </param>
/// <param name="type">
/// a #GVariantType
/// </param>
/// <return>
/// %TRUE if the type of @value matches @type
/// </return>

	public static bool IsOfType(this MentorLake.GLib.GVariantHandle value, MentorLake.GLib.GVariantTypeHandle type)
	{
		if (value.IsInvalid) throw new Exception("Invalid handle (GVariant)");
		return GVariantExterns.g_variant_is_of_type(value, type);
	}

/// <summary>
/// <para>
/// Creates a heap-allocated #GVariantIter for iterating over the items
/// in @value.
/// </para>
/// <para>
/// Use g_variant_iter_free() to free the return value when you no longer
/// need it.
/// </para>
/// <para>
/// A reference is taken to @value and will be released only when
/// g_variant_iter_free() is called.
/// </para>
/// </summary>

/// <param name="value">
/// a container #GVariant
/// </param>
/// <return>
/// a new heap-allocated #GVariantIter
/// </return>

	public static MentorLake.GLib.GVariantIterHandle IterNew(this MentorLake.GLib.GVariantHandle value)
	{
		if (value.IsInvalid) throw new Exception("Invalid handle (GVariant)");
		return GVariantExterns.g_variant_iter_new(value);
	}

/// <summary>
/// <para>
/// Looks up a value in a dictionary #GVariant.
/// </para>
/// <para>
/// This function is a wrapper around g_variant_lookup_value() and
/// g_variant_get().  In the case that %NULL would have been returned,
/// this function returns %FALSE.  Otherwise, it unpacks the returned
/// value and returns %TRUE.
/// </para>
/// <para>
/// @format_string determines the C types that are used for unpacking
/// the values and also determines if the values are copied or borrowed,
/// see the section on
/// [`GVariant` format strings](gvariant-format-strings.html#pointers).
/// </para>
/// <para>
/// This function is currently implemented with a linear scan.  If you
/// plan to do many lookups then #GVariantDict may be more efficient.
/// </para>
/// </summary>

/// <param name="dictionary">
/// a dictionary #GVariant
/// </param>
/// <param name="key">
/// the key to look up in the dictionary
/// </param>
/// <param name="format_string">
/// a GVariant format string
/// </param>
/// <param name="@__arglist">
/// the arguments to unpack the value into
/// </param>
/// <return>
/// %TRUE if a value was unpacked
/// </return>

	public static bool Lookup(this MentorLake.GLib.GVariantHandle dictionary, string key, string format_string, IntPtr @__arglist)
	{
		if (dictionary.IsInvalid) throw new Exception("Invalid handle (GVariant)");
		return GVariantExterns.g_variant_lookup(dictionary, key, format_string, @__arglist);
	}

/// <summary>
/// <para>
/// Looks up a value in a dictionary #GVariant.
/// </para>
/// <para>
/// This function works with dictionaries of the type a{s*} (and equally
/// well with type a{o*}, but we only further discuss the string case
/// for sake of clarity).
/// </para>
/// <para>
/// In the event that @dictionary has the type a{sv}, the @expected_type
/// string specifies what type of value is expected to be inside of the
/// variant. If the value inside the variant has a different type then
/// %NULL is returned. In the event that @dictionary has a value type other
/// than v then @expected_type must directly match the value type and it is
/// used to unpack the value directly or an error occurs.
/// </para>
/// <para>
/// In either case, if @key is not found in @dictionary, %NULL is returned.
/// </para>
/// <para>
/// If the key is found and the value has the correct type, it is
/// returned.  If @expected_type was specified then any non-%NULL return
/// value will have this type.
/// </para>
/// <para>
/// This function is currently implemented with a linear scan.  If you
/// plan to do many lookups then #GVariantDict may be more efficient.
/// </para>
/// </summary>

/// <param name="dictionary">
/// a dictionary #GVariant
/// </param>
/// <param name="key">
/// the key to look up in the dictionary
/// </param>
/// <param name="expected_type">
/// a #GVariantType, or %NULL
/// </param>
/// <return>
/// the value of the dictionary key, or %NULL
/// </return>

	public static MentorLake.GLib.GVariantHandle LookupValue(this MentorLake.GLib.GVariantHandle dictionary, string key, MentorLake.GLib.GVariantTypeHandle expected_type)
	{
		if (dictionary.IsInvalid) throw new Exception("Invalid handle (GVariant)");
		return GVariantExterns.g_variant_lookup_value(dictionary, key, expected_type);
	}

/// <summary>
/// <para>
/// Determines the number of children in a container #GVariant instance.
/// This includes variants, maybes, arrays, tuples and dictionary
/// entries.  It is an error to call this function on any other type of
/// #GVariant.
/// </para>
/// <para>
/// For variants, the return value is always 1.  For values with maybe
/// types, it is always zero or one.  For arrays, it is the length of the
/// array.  For tuples it is the number of tuple items (which depends
/// only on the type).  For dictionary entries, it is always 2
/// </para>
/// <para>
/// This function is O(1).
/// </para>
/// </summary>

/// <param name="value">
/// a container #GVariant
/// </param>
/// <return>
/// the number of children in the container
/// </return>

	public static UIntPtr NChildren(this MentorLake.GLib.GVariantHandle value)
	{
		if (value.IsInvalid) throw new Exception("Invalid handle (GVariant)");
		return GVariantExterns.g_variant_n_children(value);
	}

/// <summary>
/// <para>
/// Pretty-prints @value in the format understood by g_variant_parse().
/// </para>
/// <para>
/// The format is described [here](gvariant-text-format.html).
/// </para>
/// <para>
/// If @type_annotate is %TRUE, then type information is included in
/// the output.
/// </para>
/// </summary>

/// <param name="value">
/// a #GVariant
/// </param>
/// <param name="type_annotate">
/// %TRUE if type information should be included in
///                 the output
/// </param>
/// <return>
/// a newly-allocated string holding the result.
/// </return>

	public static string Print(this MentorLake.GLib.GVariantHandle value, bool type_annotate)
	{
		if (value.IsInvalid) throw new Exception("Invalid handle (GVariant)");
		return GVariantExterns.g_variant_print(value, type_annotate);
	}

/// <summary>
/// <para>
/// Behaves as g_variant_print(), but operates on a #GString.
/// </para>
/// <para>
/// If @string is non-%NULL then it is appended to and returned.  Else,
/// a new empty #GString is allocated and it is returned.
/// </para>
/// </summary>

/// <param name="value">
/// a #GVariant
/// </param>
/// <param name="@string">
/// a #GString, or %NULL
/// </param>
/// <param name="type_annotate">
/// %TRUE if type information should be included in
///                 the output
/// </param>
/// <return>
/// a #GString containing the string
/// </return>

	public static MentorLake.GLib.GStringHandle PrintString(this MentorLake.GLib.GVariantHandle value, MentorLake.GLib.GStringHandle @string, bool type_annotate)
	{
		if (value.IsInvalid) throw new Exception("Invalid handle (GVariant)");
		return GVariantExterns.g_variant_print_string(value, @string, type_annotate);
	}

/// <summary>
/// <para>
/// Increases the reference count of @value.
/// </para>
/// </summary>

/// <param name="value">
/// a #GVariant
/// </param>
/// <return>
/// the same @value
/// </return>

	public static MentorLake.GLib.GVariantHandle Ref(this MentorLake.GLib.GVariantHandle value)
	{
		if (value.IsInvalid) throw new Exception("Invalid handle (GVariant)");
		return GVariantExterns.g_variant_ref(value);
	}

/// <summary>
/// <para>
/// #GVariant uses a floating reference count system.  All functions with
/// names starting with `g_variant_new_` return floating
/// references.
/// </para>
/// <para>
/// Calling g_variant_ref_sink() on a #GVariant with a floating reference
/// will convert the floating reference into a full reference.  Calling
/// g_variant_ref_sink() on a non-floating #GVariant results in an
/// additional normal reference being added.
/// </para>
/// <para>
/// In other words, if the @value is floating, then this call &quot;assumes
/// ownership&quot; of the floating reference, converting it to a normal
/// reference.  If the @value is not floating, then this call adds a
/// new normal reference increasing the reference count by one.
/// </para>
/// <para>
/// All calls that result in a #GVariant instance being inserted into a
/// container will call g_variant_ref_sink() on the instance.  This means
/// that if the value was just created (and has only its floating
/// reference) then the container will assume sole ownership of the value
/// at that point and the caller will not need to unreference it.  This
/// makes certain common styles of programming much easier while still
/// maintaining normal refcounting semantics in situations where values
/// are not floating.
/// </para>
/// </summary>

/// <param name="value">
/// a #GVariant
/// </param>
/// <return>
/// the same @value
/// </return>

	public static MentorLake.GLib.GVariantHandle RefSink(this MentorLake.GLib.GVariantHandle value)
	{
		if (value.IsInvalid) throw new Exception("Invalid handle (GVariant)");
		return GVariantExterns.g_variant_ref_sink(value);
	}

/// <summary>
/// <para>
/// Stores the serialized form of @value at @data.  @data should be
/// large enough.  See g_variant_get_size().
/// </para>
/// <para>
/// The stored data is in machine native byte order but may not be in
/// fully-normalised form if read from an untrusted source.  See
/// g_variant_get_normal_form() for a solution.
/// </para>
/// <para>
/// As with g_variant_get_data(), to be able to deserialize the
/// serialized variant successfully, its type and (if the destination
/// machine might be different) its endianness must also be available.
/// </para>
/// <para>
/// This function is approximately O(n) in the size of @data.
/// </para>
/// </summary>

/// <param name="value">
/// the #GVariant to store
/// </param>
/// <param name="data">
/// the location to store the serialized data at
/// </param>

	public static void Store(this MentorLake.GLib.GVariantHandle value, IntPtr data)
	{
		if (value.IsInvalid) throw new Exception("Invalid handle (GVariant)");
		GVariantExterns.g_variant_store(value, data);
	}

/// <summary>
/// <para>
/// If @value is floating, sink it.  Otherwise, do nothing.
/// </para>
/// <para>
/// Typically you want to use g_variant_ref_sink() in order to
/// automatically do the correct thing with respect to floating or
/// non-floating references, but there is one specific scenario where
/// this function is helpful.
/// </para>
/// <para>
/// The situation where this function is helpful is when creating an API
/// that allows the user to provide a callback function that returns a
/// #GVariant.  We certainly want to allow the user the flexibility to
/// return a non-floating reference from this callback (for the case
/// where the value that is being returned already exists).
/// </para>
/// <para>
/// At the same time, the style of the #GVariant API makes it likely that
/// for newly-created #GVariant instances, the user can be saved some
/// typing if they are allowed to return a #GVariant with a floating
/// reference.
/// </para>
/// <para>
/// Using this function on the return value of the user&apos;s callback allows
/// the user to do whichever is more convenient for them.  The caller
/// will always receives exactly one full reference to the value: either
/// the one that was returned in the first place, or a floating reference
/// that has been converted to a full reference.
/// </para>
/// <para>
/// This function has an odd interaction when combined with
/// g_variant_ref_sink() running at the same time in another thread on
/// the same #GVariant instance.  If g_variant_ref_sink() runs first then
/// the result will be that the floating reference is converted to a hard
/// reference.  If g_variant_take_ref() runs first then the result will
/// be that the floating reference is converted to a hard reference and
/// an additional reference on top of that one is added.  It is best to
/// avoid this situation.
/// </para>
/// </summary>

/// <param name="value">
/// a #GVariant
/// </param>
/// <return>
/// the same @value
/// </return>

	public static MentorLake.GLib.GVariantHandle TakeRef(this MentorLake.GLib.GVariantHandle value)
	{
		if (value.IsInvalid) throw new Exception("Invalid handle (GVariant)");
		return GVariantExterns.g_variant_take_ref(value);
	}

/// <summary>
/// <para>
/// Decreases the reference count of @value.  When its reference count
/// drops to 0, the memory used by the variant is freed.
/// </para>
/// </summary>

/// <param name="value">
/// a #GVariant
/// </param>

	public static void Unref(this MentorLake.GLib.GVariantHandle value)
	{
		if (value.IsInvalid) throw new Exception("Invalid handle (GVariant)");
		GVariantExterns.g_variant_unref(value);
	}


	public static GVariant Dereference(this GVariantHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GVariant>(x.DangerousGetHandle());
}
internal class GVariantExterns
{
	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))]
	internal static extern MentorLake.GLib.GVariantHandle g_variant_new(string format_string, IntPtr @__arglist);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))]
	internal static extern MentorLake.GLib.GVariantHandle g_variant_new_array([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantTypeHandle>))] MentorLake.GLib.GVariantTypeHandle child_type, [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.Struct, SizeParamIndex = 2, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle[] children, UIntPtr n_children);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))]
	internal static extern MentorLake.GLib.GVariantHandle g_variant_new_boolean(bool value);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))]
	internal static extern MentorLake.GLib.GVariantHandle g_variant_new_byte(byte value);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))]
	internal static extern MentorLake.GLib.GVariantHandle g_variant_new_bytestring(byte[] @string);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))]
	internal static extern MentorLake.GLib.GVariantHandle g_variant_new_bytestring_array(string[] strv, UIntPtr length);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))]
	internal static extern MentorLake.GLib.GVariantHandle g_variant_new_dict_entry([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle key, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle value);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))]
	internal static extern MentorLake.GLib.GVariantHandle g_variant_new_double(double value);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))]
	internal static extern MentorLake.GLib.GVariantHandle g_variant_new_fixed_array([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantTypeHandle>))] MentorLake.GLib.GVariantTypeHandle element_type, IntPtr elements, UIntPtr n_elements, UIntPtr element_size);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))]
	internal static extern MentorLake.GLib.GVariantHandle g_variant_new_from_bytes([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantTypeHandle>))] MentorLake.GLib.GVariantTypeHandle type, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBytesHandle>))] MentorLake.GLib.GBytesHandle bytes, bool trusted);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))]
	internal static extern MentorLake.GLib.GVariantHandle g_variant_new_from_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantTypeHandle>))] MentorLake.GLib.GVariantTypeHandle type, byte[] data, UIntPtr size, bool trusted, MentorLake.GLib.GDestroyNotify notify, IntPtr user_data);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))]
	internal static extern MentorLake.GLib.GVariantHandle g_variant_new_handle(int value);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))]
	internal static extern MentorLake.GLib.GVariantHandle g_variant_new_int16(short value);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))]
	internal static extern MentorLake.GLib.GVariantHandle g_variant_new_int32(int value);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))]
	internal static extern MentorLake.GLib.GVariantHandle g_variant_new_int64(long value);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))]
	internal static extern MentorLake.GLib.GVariantHandle g_variant_new_maybe([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantTypeHandle>))] MentorLake.GLib.GVariantTypeHandle child_type, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle child);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))]
	internal static extern MentorLake.GLib.GVariantHandle g_variant_new_object_path(string object_path);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))]
	internal static extern MentorLake.GLib.GVariantHandle g_variant_new_objv(string[] strv, UIntPtr length);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))]
	internal static extern MentorLake.GLib.GVariantHandle g_variant_new_parsed(string format, IntPtr @__arglist);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))]
	internal static extern MentorLake.GLib.GVariantHandle g_variant_new_parsed_va(string format, IntPtr app);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))]
	internal static extern MentorLake.GLib.GVariantHandle g_variant_new_printf(string format_string, IntPtr @__arglist);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))]
	internal static extern MentorLake.GLib.GVariantHandle g_variant_new_signature(string signature);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))]
	internal static extern MentorLake.GLib.GVariantHandle g_variant_new_string(string @string);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))]
	internal static extern MentorLake.GLib.GVariantHandle g_variant_new_strv(string[] strv, UIntPtr length);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))]
	internal static extern MentorLake.GLib.GVariantHandle g_variant_new_take_string(string @string);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))]
	internal static extern MentorLake.GLib.GVariantHandle g_variant_new_tuple([MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.Struct, SizeParamIndex = 1, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle[] children, UIntPtr n_children);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))]
	internal static extern MentorLake.GLib.GVariantHandle g_variant_new_uint16(ushort value);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))]
	internal static extern MentorLake.GLib.GVariantHandle g_variant_new_uint32(uint value);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))]
	internal static extern MentorLake.GLib.GVariantHandle g_variant_new_uint64(ulong value);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))]
	internal static extern MentorLake.GLib.GVariantHandle g_variant_new_va(string format_string, string endptr, IntPtr app);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))]
	internal static extern MentorLake.GLib.GVariantHandle g_variant_new_variant([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle value);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))]
	internal static extern MentorLake.GLib.GVariantHandle g_variant_byteswap([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle value);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_variant_check_format_string([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle value, string format_string, bool copy_only);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GVariantClass g_variant_classify([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle value);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_variant_compare([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle one, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle two);

	[DllImport(GLibLibrary.Name)]
	internal static extern byte[] g_variant_dup_bytestring([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle value, out UIntPtr length);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ReadNullTerminatedArrayMarshaller<NoNativeFreeStringMarshaller, string>))]
	internal static extern string[] g_variant_dup_bytestring_array([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle value, out UIntPtr length);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ReadNullTerminatedArrayMarshaller<NoNativeFreeStringMarshaller, string>))]
	internal static extern string[] g_variant_dup_objv([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle value, out UIntPtr length);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_variant_dup_string([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle value, out UIntPtr length);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ReadNullTerminatedArrayMarshaller<NoNativeFreeStringMarshaller, string>))]
	internal static extern string[] g_variant_dup_strv([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle value, out UIntPtr length);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_variant_equal([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle one, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle two);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_variant_get([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle value, string format_string, IntPtr @__arglist);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_variant_get_boolean([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle value);

	[DllImport(GLibLibrary.Name)]
	internal static extern byte g_variant_get_byte([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle value);

	[DllImport(GLibLibrary.Name)]
	internal static extern byte[] g_variant_get_bytestring([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle value);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ReadNullTerminatedArrayMarshaller<NoNativeFreeStringMarshaller, string>))]
	internal static extern string[] g_variant_get_bytestring_array([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle value, out UIntPtr length);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_variant_get_child([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle value, UIntPtr index_, string format_string, IntPtr @__arglist);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))]
	internal static extern MentorLake.GLib.GVariantHandle g_variant_get_child_value([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle value, UIntPtr index_);

	[DllImport(GLibLibrary.Name)]
	internal static extern IntPtr g_variant_get_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle value);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBytesHandle>))]
	internal static extern MentorLake.GLib.GBytesHandle g_variant_get_data_as_bytes([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle value);

	[DllImport(GLibLibrary.Name)]
	internal static extern double g_variant_get_double([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle value);

	[DllImport(GLibLibrary.Name)]
	internal static extern IntPtr[] g_variant_get_fixed_array([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle value, out UIntPtr n_elements, UIntPtr element_size);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_variant_get_handle([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle value);

	[DllImport(GLibLibrary.Name)]
	internal static extern short g_variant_get_int16([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle value);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_variant_get_int32([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle value);

	[DllImport(GLibLibrary.Name)]
	internal static extern long g_variant_get_int64([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle value);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))]
	internal static extern MentorLake.GLib.GVariantHandle g_variant_get_maybe([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle value);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))]
	internal static extern MentorLake.GLib.GVariantHandle g_variant_get_normal_form([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle value);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ReadNullTerminatedArrayMarshaller<NoNativeFreeStringMarshaller, string>))]
	internal static extern string[] g_variant_get_objv([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle value, out UIntPtr length);

	[DllImport(GLibLibrary.Name)]
	internal static extern UIntPtr g_variant_get_size([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle value);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_variant_get_string([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle value, out UIntPtr length);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ReadNullTerminatedArrayMarshaller<NoNativeFreeStringMarshaller, string>))]
	internal static extern string[] g_variant_get_strv([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle value, out UIntPtr length);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantTypeHandle>))]
	internal static extern MentorLake.GLib.GVariantTypeHandle g_variant_get_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle value);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_variant_get_type_string([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle value);

	[DllImport(GLibLibrary.Name)]
	internal static extern ushort g_variant_get_uint16([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle value);

	[DllImport(GLibLibrary.Name)]
	internal static extern uint g_variant_get_uint32([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle value);

	[DllImport(GLibLibrary.Name)]
	internal static extern ulong g_variant_get_uint64([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle value);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_variant_get_va([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle value, string format_string, string endptr, IntPtr app);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))]
	internal static extern MentorLake.GLib.GVariantHandle g_variant_get_variant([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle value);

	[DllImport(GLibLibrary.Name)]
	internal static extern uint g_variant_hash([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle value);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_variant_is_container([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle value);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_variant_is_floating([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle value);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_variant_is_normal_form([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle value);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_variant_is_of_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle value, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantTypeHandle>))] MentorLake.GLib.GVariantTypeHandle type);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantIterHandle>))]
	internal static extern MentorLake.GLib.GVariantIterHandle g_variant_iter_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle value);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_variant_lookup([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle dictionary, string key, string format_string, IntPtr @__arglist);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))]
	internal static extern MentorLake.GLib.GVariantHandle g_variant_lookup_value([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle dictionary, string key, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantTypeHandle>))] MentorLake.GLib.GVariantTypeHandle expected_type);

	[DllImport(GLibLibrary.Name)]
	internal static extern UIntPtr g_variant_n_children([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle value);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_variant_print([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle value, bool type_annotate);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStringHandle>))]
	internal static extern MentorLake.GLib.GStringHandle g_variant_print_string([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle value, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStringHandle>))] MentorLake.GLib.GStringHandle @string, bool type_annotate);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))]
	internal static extern MentorLake.GLib.GVariantHandle g_variant_ref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle value);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))]
	internal static extern MentorLake.GLib.GVariantHandle g_variant_ref_sink([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle value);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_variant_store([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle value, IntPtr data);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))]
	internal static extern MentorLake.GLib.GVariantHandle g_variant_take_ref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle value);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_variant_unref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle value);

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

}

/// <summary>
/// <para>
/// `GVariant` is a variant datatype; it can contain one or more values
/// along with information about the type of the values.
/// </para>
/// <para>
/// A `GVariant` may contain simple types, like an integer, or a boolean value;
/// or complex types, like an array of two strings, or a dictionary of key
/// value pairs. A `GVariant` is also immutable: once it’s been created neither
/// its type nor its content can be modified further.
/// </para>
/// <para>
/// `GVariant` is useful whenever data needs to be serialized, for example when
/// sending method parameters in D-Bus, or when saving settings using
/// &amp;lt;see href=&quot;../gio/class.Settings.html&quot;&amp;gt;GSettings&amp;lt;/see&amp;gt;.
/// </para>
/// <para>
/// When creating a new `GVariant`, you pass the data you want to store in it
/// along with a string representing the type of data you wish to pass to it.
/// </para>
/// <para>
/// For instance, if you want to create a `GVariant` holding an integer value you
/// can use:
/// </para>
/// <para>
/// ```c
/// GVariant *v = g_variant_new (&quot;u&quot;, 40);
/// ```
/// </para>
/// <para>
/// The string `u` in the first argument tells `GVariant` that the data passed to
/// the constructor (`40`) is going to be an unsigned integer.
/// </para>
/// <para>
/// More advanced examples of `GVariant` in use can be found in documentation for
/// [`GVariant` format strings](gvariant-format-strings.html#pointers).
/// </para>
/// <para>
/// The range of possible values is determined by the type.
/// </para>
/// <para>
/// The type system used by `GVariant` is [type@GLib.VariantType].
/// </para>
/// <para>
/// `GVariant` instances always have a type and a value (which are given
/// at construction time).  The type and value of a `GVariant` instance
/// can never change other than by the `GVariant` itself being
/// destroyed.  A `GVariant` cannot contain a pointer.
/// </para>
/// <para>
/// `GVariant` is reference counted using [method@GLib.Variant.ref] and
/// [method@GLib.Variant.unref].  `GVariant` also has floating reference counts —
/// see [method@GLib.Variant.ref_sink].
/// </para>
/// <para>
/// `GVariant` is completely threadsafe.  A `GVariant` instance can be
/// concurrently accessed in any way from any number of threads without
/// problems.
/// </para>
/// <para>
/// `GVariant` is heavily optimised for dealing with data in serialized
/// form.  It works particularly well with data located in memory-mapped
/// files.  It can perform nearly all deserialization operations in a
/// small constant time, usually touching only a single memory page.
/// Serialized `GVariant` data can also be sent over the network.
/// </para>
/// <para>
/// `GVariant` is largely compatible with D-Bus.  Almost all types of
/// `GVariant` instances can be sent over D-Bus.  See [type@GLib.VariantType] for
/// exceptions.  (However, `GVariant`’s serialization format is not the same
/// as the serialization format of a D-Bus message body: use
/// [GDBusMessage](../gio/class.DBusMessage.html), in the GIO library, for those.)
/// </para>
/// <para>
/// For space-efficiency, the `GVariant` serialization format does not
/// automatically include the variant’s length, type or endianness,
/// which must either be implied from context (such as knowledge that a
/// particular file format always contains a little-endian
/// `G_VARIANT_TYPE_VARIANT` which occupies the whole length of the file)
/// or supplied out-of-band (for instance, a length, type and/or endianness
/// indicator could be placed at the beginning of a file, network message
/// or network stream).
/// </para>
/// <para>
/// A `GVariant`’s size is limited mainly by any lower level operating
/// system constraints, such as the number of bits in `gsize`.  For
/// example, it is reasonable to have a 2GB file mapped into memory
/// with [struct@GLib.MappedFile], and call [ctor@GLib.Variant.new_from_data] on
/// it.
/// </para>
/// <para>
/// For convenience to C programmers, `GVariant` features powerful
/// varargs-based value construction and destruction.  This feature is
/// designed to be embedded in other libraries.
/// </para>
/// <para>
/// There is a Python-inspired text language for describing `GVariant`
/// values.  `GVariant` includes a printer for this language and a parser
/// with type inferencing.
/// </para>
/// <para>
/// ## Memory Use
/// </para>
/// <para>
/// `GVariant` tries to be quite efficient with respect to memory use.
/// This section gives a rough idea of how much memory is used by the
/// current implementation.  The information here is subject to change
/// in the future.
/// </para>
/// <para>
/// The memory allocated by `GVariant` can be grouped into 4 broad
/// purposes: memory for serialized data, memory for the type
/// information cache, buffer management memory and memory for the
/// `GVariant` structure itself.
/// </para>
/// <para>
/// ## Serialized Data Memory
/// </para>
/// <para>
/// This is the memory that is used for storing `GVariant` data in
/// serialized form.  This is what would be sent over the network or
/// what would end up on disk, not counting any indicator of the
/// endianness, or of the length or type of the top-level variant.
/// </para>
/// <para>
/// The amount of memory required to store a boolean is 1 byte. 16,
/// 32 and 64 bit integers and double precision floating point numbers
/// use their ‘natural’ size.  Strings (including object path and
/// signature strings) are stored with a nul terminator, and as such
/// use the length of the string plus 1 byte.
/// </para>
/// <para>
/// ‘Maybe’ types use no space at all to represent the null value and
/// use the same amount of space (sometimes plus one byte) as the
/// equivalent non-maybe-typed value to represent the non-null case.
/// </para>
/// <para>
/// Arrays use the amount of space required to store each of their
/// members, concatenated.  Additionally, if the items stored in an
/// array are not of a fixed-size (ie: strings, other arrays, etc)
/// then an additional framing offset is stored for each item.  The
/// size of this offset is either 1, 2 or 4 bytes depending on the
/// overall size of the container.  Additionally, extra padding bytes
/// are added as required for alignment of child values.
/// </para>
/// <para>
/// Tuples (including dictionary entries) use the amount of space
/// required to store each of their members, concatenated, plus one
/// framing offset (as per arrays) for each non-fixed-sized item in
/// the tuple, except for the last one.  Additionally, extra padding
/// bytes are added as required for alignment of child values.
/// </para>
/// <para>
/// Variants use the same amount of space as the item inside of the
/// variant, plus 1 byte, plus the length of the type string for the
/// item inside the variant.
/// </para>
/// <para>
/// As an example, consider a dictionary mapping strings to variants.
/// In the case that the dictionary is empty, 0 bytes are required for
/// the serialization.
/// </para>
/// <para>
/// If we add an item ‘width’ that maps to the int32 value of 500 then
/// we will use 4 bytes to store the int32 (so 6 for the variant
/// containing it) and 6 bytes for the string.  The variant must be
/// aligned to 8 after the 6 bytes of the string, so that’s 2 extra
/// bytes.  6 (string) + 2 (padding) + 6 (variant) is 14 bytes used
/// for the dictionary entry.  An additional 1 byte is added to the
/// array as a framing offset making a total of 15 bytes.
/// </para>
/// <para>
/// If we add another entry, ‘title’ that maps to a nullable string
/// that happens to have a value of null, then we use 0 bytes for the
/// null value (and 3 bytes for the variant to contain it along with
/// its type string) plus 6 bytes for the string.  Again, we need 2
/// padding bytes.  That makes a total of 6 + 2 + 3 = 11 bytes.
/// </para>
/// <para>
/// We now require extra padding between the two items in the array.
/// After the 14 bytes of the first item, that’s 2 bytes required.
/// We now require 2 framing offsets for an extra two
/// bytes. 14 + 2 + 11 + 2 = 29 bytes to encode the entire two-item
/// dictionary.
/// </para>
/// <para>
/// ## Type Information Cache
/// </para>
/// <para>
/// For each `GVariant` type that currently exists in the program a type
/// information structure is kept in the type information cache.  The
/// type information structure is required for rapid deserialization.
/// </para>
/// <para>
/// Continuing with the above example, if a `GVariant` exists with the
/// type `a{sv}` then a type information struct will exist for
/// `a{sv}`, `{sv}`, `s`, and `v`.  Multiple uses of the same type
/// will share the same type information.  Additionally, all
/// single-digit types are stored in read-only static memory and do
/// not contribute to the writable memory footprint of a program using
/// `GVariant`.
/// </para>
/// <para>
/// Aside from the type information structures stored in read-only
/// memory, there are two forms of type information.  One is used for
/// container types where there is a single element type: arrays and
/// maybe types.  The other is used for container types where there
/// are multiple element types: tuples and dictionary entries.
/// </para>
/// <para>
/// Array type info structures are `6 * sizeof (void *)`, plus the
/// memory required to store the type string itself.  This means that
/// on 32-bit systems, the cache entry for `a{sv}` would require 30
/// bytes of memory (plus allocation overhead).
/// </para>
/// <para>
/// Tuple type info structures are `6 * sizeof (void *)`, plus `4 *
/// sizeof (void *)` for each item in the tuple, plus the memory
/// required to store the type string itself.  A 2-item tuple, for
/// example, would have a type information structure that consumed
/// writable memory in the size of `14 * sizeof (void *)` (plus type
/// string)  This means that on 32-bit systems, the cache entry for
/// `{sv}` would require 61 bytes of memory (plus allocation overhead).
/// </para>
/// <para>
/// This means that in total, for our `a{sv}` example, 91 bytes of
/// type information would be allocated.
/// </para>
/// <para>
/// The type information cache, additionally, uses a [struct@GLib.HashTable] to
/// store and look up the cached items and stores a pointer to this
/// hash table in static storage.  The hash table is freed when there
/// are zero items in the type cache.
/// </para>
/// <para>
/// Although these sizes may seem large it is important to remember
/// that a program will probably only have a very small number of
/// different types of values in it and that only one type information
/// structure is required for many different values of the same type.
/// </para>
/// <para>
/// ## Buffer Management Memory
/// </para>
/// <para>
/// `GVariant` uses an internal buffer management structure to deal
/// with the various different possible sources of serialized data
/// that it uses.  The buffer is responsible for ensuring that the
/// correct call is made when the data is no longer in use by
/// `GVariant`.  This may involve a [func@GLib.free] or
/// even [method@GLib.MappedFile.unref].
/// </para>
/// <para>
/// One buffer management structure is used for each chunk of
/// serialized data.  The size of the buffer management structure
/// is `4 * (void *)`.  On 32-bit systems, that’s 16 bytes.
/// </para>
/// <para>
/// ## GVariant structure
/// </para>
/// <para>
/// The size of a `GVariant` structure is `6 * (void *)`.  On 32-bit
/// systems, that’s 24 bytes.
/// </para>
/// <para>
/// `GVariant` structures only exist if they are explicitly created
/// with API calls.  For example, if a `GVariant` is constructed out of
/// serialized data for the example given above (with the dictionary)
/// then although there are 9 individual values that comprise the
/// entire dictionary (two keys, two values, two variants containing
/// the values, two dictionary entries, plus the dictionary itself),
/// only 1 `GVariant` instance exists — the one referring to the
/// dictionary.
/// </para>
/// <para>
/// If calls are made to start accessing the other values then
/// `GVariant` instances will exist for those values only for as long
/// as they are in use (ie: until you call [method@GLib.Variant.unref]).  The
/// type information is shared.  The serialized data and the buffer
/// management structure for that serialized data is shared by the
/// child.
/// </para>
/// <para>
/// ## Summary
/// </para>
/// <para>
/// To put the entire example together, for our dictionary mapping
/// strings to variants (with two entries, as given above), we are
/// using 91 bytes of memory for type information, 29 bytes of memory
/// for the serialized data, 16 bytes for buffer management and 24
/// bytes for the `GVariant` instance, or a total of 160 bytes, plus
/// allocation overhead.  If we were to use [method@GLib.Variant.get_child_value]
/// to access the two dictionary entries, we would use an additional 48
/// bytes.  If we were to have other dictionaries of the same type, we
/// would use more memory for the serialized data and buffer
/// management for those dictionaries, but the type information would
/// be shared.
/// </para>
/// </summary>

public struct GVariant
{
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

	public static bool IsObjectPath(string @string)
	{
		return GVariantExterns.g_variant_is_object_path(@string);
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

	public static bool IsSignature(string @string)
	{
		return GVariantExterns.g_variant_is_signature(@string);
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

	public static MentorLake.GLib.GVariantHandle Parse(MentorLake.GLib.GVariantTypeHandle type, string text, string limit, string endptr)
	{
		var externCallResult = GVariantExterns.g_variant_parse(type, text, limit, endptr, out var error);
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

	public static string ParseErrorPrintContext(MentorLake.GLib.GErrorHandle error, string source_str)
	{
		return GVariantExterns.g_variant_parse_error_print_context(error, source_str);
	}



	public static MentorLake.GLib.GQuark ParseErrorQuark()
	{
		return GVariantExterns.g_variant_parse_error_quark();
	}

/// <summary>
/// <para>
/// Same as g_variant_error_quark().
/// </para>
/// </summary>


	public static MentorLake.GLib.GQuark ParserGetErrorQuark()
	{
		return GVariantExterns.g_variant_parser_get_error_quark();
	}

}
