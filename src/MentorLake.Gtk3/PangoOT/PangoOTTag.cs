namespace MentorLake.PangoOT;

/// <summary>
/// <para>
/// The `PangoOTTag` typedef is used to represent TrueType and OpenType
/// four letter tags inside Pango. Use PANGO_OT_TAG_MAKE()
/// or PANGO_OT_TAG_MAKE_FROM_STRING() macros to create PangoOTTags manually.
/// </para>
/// </summary>

public struct PangoOTTag
{
	public uint Value;
}

public class PangoOTTagHandle : BaseSafeHandle
{
}

public static class PangoOTTagHandleExtensions
{
	public static PangoOTTag Dereference(this PangoOTTagHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<PangoOTTag>(x.DangerousGetHandle());
	public static uint DereferenceValue(this PangoOTTagHandle x) => x.Dereference().Value;
}
