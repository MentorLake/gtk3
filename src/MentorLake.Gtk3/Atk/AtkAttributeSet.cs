namespace MentorLake.Atk;

/// <summary>
/// <para>
/// This is a singly-linked list (a #GSList) of #AtkAttribute. It is
/// used by atk_text_get_run_attributes(),
/// atk_text_get_default_attributes(),
/// atk_editable_text_set_run_attributes(),
/// atk_document_get_attributes() and atk_object_get_attributes()
/// </para>
/// </summary>

public struct AtkAttributeSet
{
	public MentorLake.GLib.GSList Value;
}

/// <summary>
/// <para>
/// This is a singly-linked list (a #GSList) of #AtkAttribute. It is
/// used by atk_text_get_run_attributes(),
/// atk_text_get_default_attributes(),
/// atk_editable_text_set_run_attributes(),
/// atk_document_get_attributes() and atk_object_get_attributes()
/// </para>
/// </summary>

public class AtkAttributeSetHandle : BaseSafeHandle
{
}

public static class AtkAttributeSetHandleExtensions
{
	public static AtkAttributeSet Dereference(this AtkAttributeSetHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<AtkAttributeSet>(x.DangerousGetHandle());
	public static MentorLake.GLib.GSList DereferenceValue(this AtkAttributeSetHandle x) => x.Dereference().Value;
}
