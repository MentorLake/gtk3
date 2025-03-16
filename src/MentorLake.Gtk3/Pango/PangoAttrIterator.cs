namespace MentorLake.Pango;

public class PangoAttrIteratorHandle : BaseSafeHandle
{
}


public static class PangoAttrIteratorExtensions
{
	public static MentorLake.Pango.PangoAttrIteratorHandle Copy(this MentorLake.Pango.PangoAttrIteratorHandle iterator)
	{
		return PangoAttrIteratorExterns.pango_attr_iterator_copy(iterator);
	}

	public static void Destroy(this MentorLake.Pango.PangoAttrIteratorHandle iterator)
	{
		PangoAttrIteratorExterns.pango_attr_iterator_destroy(iterator);
	}

	public static MentorLake.Pango.PangoAttributeHandle Get(this MentorLake.Pango.PangoAttrIteratorHandle iterator, MentorLake.Pango.PangoAttrType type)
	{
		return PangoAttrIteratorExterns.pango_attr_iterator_get(iterator, type);
	}

	public static MentorLake.GLib.GSListHandle GetAttrs(this MentorLake.Pango.PangoAttrIteratorHandle iterator)
	{
		return PangoAttrIteratorExterns.pango_attr_iterator_get_attrs(iterator);
	}

	public static void GetFont(this MentorLake.Pango.PangoAttrIteratorHandle iterator, MentorLake.Pango.PangoFontDescriptionHandle desc, out MentorLake.Pango.PangoLanguageHandle language, out MentorLake.GLib.GSListHandle extra_attrs)
	{
		PangoAttrIteratorExterns.pango_attr_iterator_get_font(iterator, desc, out language, out extra_attrs);
	}

	public static bool Next(this MentorLake.Pango.PangoAttrIteratorHandle iterator)
	{
		return PangoAttrIteratorExterns.pango_attr_iterator_next(iterator);
	}

	public static void Range(this MentorLake.Pango.PangoAttrIteratorHandle iterator, out int start, out int end)
	{
		PangoAttrIteratorExterns.pango_attr_iterator_range(iterator, out start, out end);
	}


	public static PangoAttrIterator Dereference(this PangoAttrIteratorHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<PangoAttrIterator>(x.DangerousGetHandle());
}
internal class PangoAttrIteratorExterns
{
	[DllImport(PangoLibrary.Name)]
	internal static extern MentorLake.Pango.PangoAttrIteratorHandle pango_attr_iterator_copy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttrIteratorHandle>))] MentorLake.Pango.PangoAttrIteratorHandle iterator);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_attr_iterator_destroy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttrIteratorHandle>))] MentorLake.Pango.PangoAttrIteratorHandle iterator);

	[DllImport(PangoLibrary.Name)]
	internal static extern MentorLake.Pango.PangoAttributeHandle pango_attr_iterator_get([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttrIteratorHandle>))] MentorLake.Pango.PangoAttrIteratorHandle iterator, MentorLake.Pango.PangoAttrType type);

	[DllImport(PangoLibrary.Name)]
	internal static extern MentorLake.GLib.GSListHandle pango_attr_iterator_get_attrs([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttrIteratorHandle>))] MentorLake.Pango.PangoAttrIteratorHandle iterator);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_attr_iterator_get_font([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttrIteratorHandle>))] MentorLake.Pango.PangoAttrIteratorHandle iterator, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontDescriptionHandle>))] MentorLake.Pango.PangoFontDescriptionHandle desc, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLanguageHandle>))] out MentorLake.Pango.PangoLanguageHandle language, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))] out MentorLake.GLib.GSListHandle extra_attrs);

	[DllImport(PangoLibrary.Name)]
	internal static extern bool pango_attr_iterator_next([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttrIteratorHandle>))] MentorLake.Pango.PangoAttrIteratorHandle iterator);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_attr_iterator_range([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttrIteratorHandle>))] MentorLake.Pango.PangoAttrIteratorHandle iterator, out int start, out int end);

}

public struct PangoAttrIterator
{
}
