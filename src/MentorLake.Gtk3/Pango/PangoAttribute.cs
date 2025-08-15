namespace MentorLake.Pango;

/// <summary>
/// <para>
/// The `PangoAttribute` structure represents the common portions of all
/// attributes.
/// </para>
/// <para>
/// Particular types of attributes include this structure as their initial
/// portion. The common portion of the attribute holds the range to which
/// the value in the type-specific part of the attribute applies and should
/// be initialized using [method@Pango.Attribute.init]. By default, an attribute
/// will have an all-inclusive range of [0,%G_MAXUINT].
/// </para>
/// </summary>

public class PangoAttributeHandle : BaseSafeHandle
{
}


public static class PangoAttributeExtensions
{
/// <summary>
/// <para>
/// Returns the attribute cast to `PangoAttrColor`.
/// </para>
/// <para>
/// This is mainly useful for language bindings.
/// </para>
/// </summary>

/// <param name="attr">
/// A `PangoAttribute` such as foreground
/// </param>
/// <return>
/// The attribute as `PangoAttrColor`,
///   or %NULL if it&apos;s not a color attribute
/// </return>

	public static MentorLake.Pango.PangoAttrColorHandle AsColor(this MentorLake.Pango.PangoAttributeHandle attr)
	{
		if (attr.IsInvalid) throw new Exception("Invalid handle (PangoAttribute)");
		return PangoAttributeExterns.pango_attribute_as_color(attr);
	}

/// <summary>
/// <para>
/// Returns the attribute cast to `PangoAttrFloat`.
/// </para>
/// <para>
/// This is mainly useful for language bindings.
/// </para>
/// </summary>

/// <param name="attr">
/// A `PangoAttribute` such as scale
/// </param>
/// <return>
/// The attribute as `PangoAttrFloat`,
///   or %NULL if it&apos;s not a floating point attribute
/// </return>

	public static MentorLake.Pango.PangoAttrFloatHandle AsFloat(this MentorLake.Pango.PangoAttributeHandle attr)
	{
		if (attr.IsInvalid) throw new Exception("Invalid handle (PangoAttribute)");
		return PangoAttributeExterns.pango_attribute_as_float(attr);
	}

/// <summary>
/// <para>
/// Returns the attribute cast to `PangoAttrFontDesc`.
/// </para>
/// <para>
/// This is mainly useful for language bindings.
/// </para>
/// </summary>

/// <param name="attr">
/// A `PangoAttribute` representing a font description
/// </param>
/// <return>
/// The attribute as `PangoAttrFontDesc`,
///   or %NULL if it&apos;s not a font description attribute
/// </return>

	public static MentorLake.Pango.PangoAttrFontDescHandle AsFontDesc(this MentorLake.Pango.PangoAttributeHandle attr)
	{
		if (attr.IsInvalid) throw new Exception("Invalid handle (PangoAttribute)");
		return PangoAttributeExterns.pango_attribute_as_font_desc(attr);
	}

/// <summary>
/// <para>
/// Returns the attribute cast to `PangoAttrFontFeatures`.
/// </para>
/// <para>
/// This is mainly useful for language bindings.
/// </para>
/// </summary>

/// <param name="attr">
/// A `PangoAttribute` representing font features
/// </param>
/// <return>
/// The attribute as `PangoAttrFontFeatures`,
///   or %NULL if it&apos;s not a font features attribute
/// </return>

	public static MentorLake.Pango.PangoAttrFontFeaturesHandle AsFontFeatures(this MentorLake.Pango.PangoAttributeHandle attr)
	{
		if (attr.IsInvalid) throw new Exception("Invalid handle (PangoAttribute)");
		return PangoAttributeExterns.pango_attribute_as_font_features(attr);
	}

/// <summary>
/// <para>
/// Returns the attribute cast to `PangoAttrInt`.
/// </para>
/// <para>
/// This is mainly useful for language bindings.
/// </para>
/// </summary>

/// <param name="attr">
/// A `PangoAttribute` such as weight
/// </param>
/// <return>
/// The attribute as `PangoAttrInt`,
///   or %NULL if it&apos;s not an integer attribute
/// </return>

	public static MentorLake.Pango.PangoAttrIntHandle AsInt(this MentorLake.Pango.PangoAttributeHandle attr)
	{
		if (attr.IsInvalid) throw new Exception("Invalid handle (PangoAttribute)");
		return PangoAttributeExterns.pango_attribute_as_int(attr);
	}

/// <summary>
/// <para>
/// Returns the attribute cast to `PangoAttrLanguage`.
/// </para>
/// <para>
/// This is mainly useful for language bindings.
/// </para>
/// </summary>

/// <param name="attr">
/// A `PangoAttribute` representing a language
/// </param>
/// <return>
/// The attribute as `PangoAttrLanguage`,
///   or %NULL if it&apos;s not a language attribute
/// </return>

	public static MentorLake.Pango.PangoAttrLanguageHandle AsLanguage(this MentorLake.Pango.PangoAttributeHandle attr)
	{
		if (attr.IsInvalid) throw new Exception("Invalid handle (PangoAttribute)");
		return PangoAttributeExterns.pango_attribute_as_language(attr);
	}

/// <summary>
/// <para>
/// Returns the attribute cast to `PangoAttrShape`.
/// </para>
/// <para>
/// This is mainly useful for language bindings.
/// </para>
/// </summary>

/// <param name="attr">
/// A `PangoAttribute` representing a shape
/// </param>
/// <return>
/// The attribute as `PangoAttrShape`,
///   or %NULL if it&apos;s not a shape attribute
/// </return>

	public static MentorLake.Pango.PangoAttrShapeHandle AsShape(this MentorLake.Pango.PangoAttributeHandle attr)
	{
		if (attr.IsInvalid) throw new Exception("Invalid handle (PangoAttribute)");
		return PangoAttributeExterns.pango_attribute_as_shape(attr);
	}

/// <summary>
/// <para>
/// Returns the attribute cast to `PangoAttrSize`.
/// </para>
/// <para>
/// This is mainly useful for language bindings.
/// </para>
/// </summary>

/// <param name="attr">
/// A `PangoAttribute` representing a size
/// </param>
/// <return>
/// The attribute as `PangoAttrSize`,
///   or NULL if it&apos;s not a size attribute
/// </return>

	public static MentorLake.Pango.PangoAttrSizeHandle AsSize(this MentorLake.Pango.PangoAttributeHandle attr)
	{
		if (attr.IsInvalid) throw new Exception("Invalid handle (PangoAttribute)");
		return PangoAttributeExterns.pango_attribute_as_size(attr);
	}

/// <summary>
/// <para>
/// Returns the attribute cast to `PangoAttrString`.
/// </para>
/// <para>
/// This is mainly useful for language bindings.
/// </para>
/// </summary>

/// <param name="attr">
/// A `PangoAttribute` such as family
/// </param>
/// <return>
/// The attribute as `PangoAttrString`,
///   or %NULL if it&apos;s not a string attribute
/// </return>

	public static MentorLake.Pango.PangoAttrStringHandle AsString(this MentorLake.Pango.PangoAttributeHandle attr)
	{
		if (attr.IsInvalid) throw new Exception("Invalid handle (PangoAttribute)");
		return PangoAttributeExterns.pango_attribute_as_string(attr);
	}

/// <summary>
/// <para>
/// Make a copy of an attribute.
/// </para>
/// </summary>

/// <param name="attr">
/// a `PangoAttribute`
/// </param>
/// <return>
/// the newly allocated
///   `PangoAttribute`, which should be freed with
///   [method@Pango.Attribute.destroy].
/// </return>

	public static MentorLake.Pango.PangoAttributeHandle Copy(this MentorLake.Pango.PangoAttributeHandle attr)
	{
		if (attr.IsInvalid) throw new Exception("Invalid handle (PangoAttribute)");
		return PangoAttributeExterns.pango_attribute_copy(attr);
	}

/// <summary>
/// <para>
/// Destroy a `PangoAttribute` and free all associated memory.
/// </para>
/// </summary>

/// <param name="attr">
/// a `PangoAttribute`.
/// </param>

	public static void Destroy(this MentorLake.Pango.PangoAttributeHandle attr)
	{
		if (attr.IsInvalid) throw new Exception("Invalid handle (PangoAttribute)");
		PangoAttributeExterns.pango_attribute_destroy(attr);
	}

/// <summary>
/// <para>
/// Compare two attributes for equality.
/// </para>
/// <para>
/// This compares only the actual value of the two
/// attributes and not the ranges that the attributes
/// apply to.
/// </para>
/// </summary>

/// <param name="attr1">
/// a `PangoAttribute`
/// </param>
/// <param name="attr2">
/// another `PangoAttribute`
/// </param>
/// <return>
/// %TRUE if the two attributes have the same value
/// </return>

	public static bool Equal(this MentorLake.Pango.PangoAttributeHandle attr1, MentorLake.Pango.PangoAttributeHandle attr2)
	{
		if (attr1.IsInvalid) throw new Exception("Invalid handle (PangoAttribute)");
		return PangoAttributeExterns.pango_attribute_equal(attr1, attr2);
	}

/// <summary>
/// <para>
/// Initializes @attr&apos;s klass to @klass, it&apos;s start_index to
/// %PANGO_ATTR_INDEX_FROM_TEXT_BEGINNING and end_index to
/// %PANGO_ATTR_INDEX_TO_TEXT_END such that the attribute applies
/// to the entire text by default.
/// </para>
/// </summary>

/// <param name="attr">
/// a `PangoAttribute`
/// </param>
/// <param name="klass">
/// a `PangoAttrClass`
/// </param>

	public static void Init(this MentorLake.Pango.PangoAttributeHandle attr, MentorLake.Pango.PangoAttrClassHandle klass)
	{
		if (attr.IsInvalid) throw new Exception("Invalid handle (PangoAttribute)");
		PangoAttributeExterns.pango_attribute_init(attr, klass);
	}


	public static PangoAttribute Dereference(this PangoAttributeHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<PangoAttribute>(x.DangerousGetHandle());
}
internal class PangoAttributeExterns
{
	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttrColorHandle>))]
	internal static extern MentorLake.Pango.PangoAttrColorHandle pango_attribute_as_color([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttributeHandle>))] MentorLake.Pango.PangoAttributeHandle attr);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttrFloatHandle>))]
	internal static extern MentorLake.Pango.PangoAttrFloatHandle pango_attribute_as_float([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttributeHandle>))] MentorLake.Pango.PangoAttributeHandle attr);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttrFontDescHandle>))]
	internal static extern MentorLake.Pango.PangoAttrFontDescHandle pango_attribute_as_font_desc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttributeHandle>))] MentorLake.Pango.PangoAttributeHandle attr);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttrFontFeaturesHandle>))]
	internal static extern MentorLake.Pango.PangoAttrFontFeaturesHandle pango_attribute_as_font_features([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttributeHandle>))] MentorLake.Pango.PangoAttributeHandle attr);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttrIntHandle>))]
	internal static extern MentorLake.Pango.PangoAttrIntHandle pango_attribute_as_int([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttributeHandle>))] MentorLake.Pango.PangoAttributeHandle attr);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttrLanguageHandle>))]
	internal static extern MentorLake.Pango.PangoAttrLanguageHandle pango_attribute_as_language([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttributeHandle>))] MentorLake.Pango.PangoAttributeHandle attr);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttrShapeHandle>))]
	internal static extern MentorLake.Pango.PangoAttrShapeHandle pango_attribute_as_shape([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttributeHandle>))] MentorLake.Pango.PangoAttributeHandle attr);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttrSizeHandle>))]
	internal static extern MentorLake.Pango.PangoAttrSizeHandle pango_attribute_as_size([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttributeHandle>))] MentorLake.Pango.PangoAttributeHandle attr);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttrStringHandle>))]
	internal static extern MentorLake.Pango.PangoAttrStringHandle pango_attribute_as_string([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttributeHandle>))] MentorLake.Pango.PangoAttributeHandle attr);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttributeHandle>))]
	internal static extern MentorLake.Pango.PangoAttributeHandle pango_attribute_copy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttributeHandle>))] MentorLake.Pango.PangoAttributeHandle attr);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_attribute_destroy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttributeHandle>))] MentorLake.Pango.PangoAttributeHandle attr);

	[DllImport(PangoLibrary.Name)]
	internal static extern bool pango_attribute_equal([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttributeHandle>))] MentorLake.Pango.PangoAttributeHandle attr1, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttributeHandle>))] MentorLake.Pango.PangoAttributeHandle attr2);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_attribute_init([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttributeHandle>))] MentorLake.Pango.PangoAttributeHandle attr, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttrClassHandle>))] MentorLake.Pango.PangoAttrClassHandle klass);

}

/// <summary>
/// <para>
/// The `PangoAttribute` structure represents the common portions of all
/// attributes.
/// </para>
/// <para>
/// Particular types of attributes include this structure as their initial
/// portion. The common portion of the attribute holds the range to which
/// the value in the type-specific part of the attribute applies and should
/// be initialized using [method@Pango.Attribute.init]. By default, an attribute
/// will have an all-inclusive range of [0,%G_MAXUINT].
/// </para>
/// </summary>

public struct PangoAttribute
{
	/// <summary>
/// <para>
/// the class structure holding information about the type of the attribute
/// </para>
/// </summary>

public IntPtr klass;
	/// <summary>
/// <para>
/// the start index of the range (in bytes).
/// </para>
/// </summary>

public uint start_index;
	/// <summary>
/// <para>
/// end index of the range (in bytes). The character at this index
///   is not included in the range.
/// </para>
/// </summary>

public uint end_index;
}
