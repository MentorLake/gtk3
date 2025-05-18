namespace MentorLake.Pango;

public class PangoAttributeHandle : BaseSafeHandle
{
}


public static class PangoAttributeExtensions
{
	public static MentorLake.Pango.PangoAttrColorHandle AsColor(this MentorLake.Pango.PangoAttributeHandle attr)
	{
		if (attr.IsInvalid) throw new Exception("Invalid handle (PangoAttribute)");
		return PangoAttributeExterns.pango_attribute_as_color(attr);
	}

	public static MentorLake.Pango.PangoAttrFloatHandle AsFloat(this MentorLake.Pango.PangoAttributeHandle attr)
	{
		if (attr.IsInvalid) throw new Exception("Invalid handle (PangoAttribute)");
		return PangoAttributeExterns.pango_attribute_as_float(attr);
	}

	public static MentorLake.Pango.PangoAttrFontDescHandle AsFontDesc(this MentorLake.Pango.PangoAttributeHandle attr)
	{
		if (attr.IsInvalid) throw new Exception("Invalid handle (PangoAttribute)");
		return PangoAttributeExterns.pango_attribute_as_font_desc(attr);
	}

	public static MentorLake.Pango.PangoAttrFontFeaturesHandle AsFontFeatures(this MentorLake.Pango.PangoAttributeHandle attr)
	{
		if (attr.IsInvalid) throw new Exception("Invalid handle (PangoAttribute)");
		return PangoAttributeExterns.pango_attribute_as_font_features(attr);
	}

	public static MentorLake.Pango.PangoAttrIntHandle AsInt(this MentorLake.Pango.PangoAttributeHandle attr)
	{
		if (attr.IsInvalid) throw new Exception("Invalid handle (PangoAttribute)");
		return PangoAttributeExterns.pango_attribute_as_int(attr);
	}

	public static MentorLake.Pango.PangoAttrLanguageHandle AsLanguage(this MentorLake.Pango.PangoAttributeHandle attr)
	{
		if (attr.IsInvalid) throw new Exception("Invalid handle (PangoAttribute)");
		return PangoAttributeExterns.pango_attribute_as_language(attr);
	}

	public static MentorLake.Pango.PangoAttrShapeHandle AsShape(this MentorLake.Pango.PangoAttributeHandle attr)
	{
		if (attr.IsInvalid) throw new Exception("Invalid handle (PangoAttribute)");
		return PangoAttributeExterns.pango_attribute_as_shape(attr);
	}

	public static MentorLake.Pango.PangoAttrSizeHandle AsSize(this MentorLake.Pango.PangoAttributeHandle attr)
	{
		if (attr.IsInvalid) throw new Exception("Invalid handle (PangoAttribute)");
		return PangoAttributeExterns.pango_attribute_as_size(attr);
	}

	public static MentorLake.Pango.PangoAttrStringHandle AsString(this MentorLake.Pango.PangoAttributeHandle attr)
	{
		if (attr.IsInvalid) throw new Exception("Invalid handle (PangoAttribute)");
		return PangoAttributeExterns.pango_attribute_as_string(attr);
	}

	public static MentorLake.Pango.PangoAttributeHandle Copy(this MentorLake.Pango.PangoAttributeHandle attr)
	{
		if (attr.IsInvalid) throw new Exception("Invalid handle (PangoAttribute)");
		return PangoAttributeExterns.pango_attribute_copy(attr);
	}

	public static void Destroy(this MentorLake.Pango.PangoAttributeHandle attr)
	{
		if (attr.IsInvalid) throw new Exception("Invalid handle (PangoAttribute)");
		PangoAttributeExterns.pango_attribute_destroy(attr);
	}

	public static bool Equal(this MentorLake.Pango.PangoAttributeHandle attr1, MentorLake.Pango.PangoAttributeHandle attr2)
	{
		if (attr1.IsInvalid) throw new Exception("Invalid handle (PangoAttribute)");
		return PangoAttributeExterns.pango_attribute_equal(attr1, attr2);
	}

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

public struct PangoAttribute
{
	public IntPtr klass;
	public uint start_index;
	public uint end_index;
}
