namespace MentorLake.Pango;

public class PangoItemHandle : BaseSafeHandle
{
	public static MentorLake.Pango.PangoItemHandle New()
	{
		return PangoItemExterns.pango_item_new();
	}

}


public static class PangoItemExtensions
{
	public static void ApplyAttrs(this MentorLake.Pango.PangoItemHandle item, MentorLake.Pango.PangoAttrIteratorHandle iter)
	{
		if (item.IsInvalid) throw new Exception("Invalid handle (PangoItem)");
		PangoItemExterns.pango_item_apply_attrs(item, iter);
	}

	public static MentorLake.Pango.PangoItemHandle Copy(this MentorLake.Pango.PangoItemHandle item)
	{
		if (item.IsInvalid) throw new Exception("Invalid handle (PangoItem)");
		return PangoItemExterns.pango_item_copy(item);
	}

	public static void Free(this MentorLake.Pango.PangoItemHandle item)
	{
		if (item.IsInvalid) throw new Exception("Invalid handle (PangoItem)");
		PangoItemExterns.pango_item_free(item);
	}

	public static int GetCharOffset(this MentorLake.Pango.PangoItemHandle item)
	{
		if (item.IsInvalid) throw new Exception("Invalid handle (PangoItem)");
		return PangoItemExterns.pango_item_get_char_offset(item);
	}

	public static MentorLake.Pango.PangoItemHandle Split(this MentorLake.Pango.PangoItemHandle orig, int split_index, int split_offset)
	{
		if (orig.IsInvalid) throw new Exception("Invalid handle (PangoItem)");
		return PangoItemExterns.pango_item_split(orig, split_index, split_offset);
	}


	public static PangoItem Dereference(this PangoItemHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<PangoItem>(x.DangerousGetHandle());
}
internal class PangoItemExterns
{
	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoItemHandle>))]
	internal static extern MentorLake.Pango.PangoItemHandle pango_item_new();

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_item_apply_attrs([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoItemHandle>))] MentorLake.Pango.PangoItemHandle item, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoAttrIteratorHandle>))] MentorLake.Pango.PangoAttrIteratorHandle iter);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoItemHandle>))]
	internal static extern MentorLake.Pango.PangoItemHandle pango_item_copy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoItemHandle>))] MentorLake.Pango.PangoItemHandle item);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_item_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoItemHandle>))] MentorLake.Pango.PangoItemHandle item);

	[DllImport(PangoLibrary.Name)]
	internal static extern int pango_item_get_char_offset([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoItemHandle>))] MentorLake.Pango.PangoItemHandle item);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoItemHandle>))]
	internal static extern MentorLake.Pango.PangoItemHandle pango_item_split([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoItemHandle>))] MentorLake.Pango.PangoItemHandle orig, int split_index, int split_offset);

}

public struct PangoItem
{
	public int offset;
	public int length;
	public int num_chars;
	public PangoAnalysis analysis;
}
