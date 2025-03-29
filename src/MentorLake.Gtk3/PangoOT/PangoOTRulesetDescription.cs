namespace MentorLake.PangoOT;

public class PangoOTRulesetDescriptionHandle : BaseSafeHandle
{
}


public static class PangoOTRulesetDescriptionExtensions
{
	public static MentorLake.PangoOT.PangoOTRulesetDescriptionHandle Copy(this MentorLake.PangoOT.PangoOTRulesetDescriptionHandle desc)
	{
		if (desc.IsInvalid || desc.IsClosed) throw new Exception("Invalid or closed handle (PangoOTRulesetDescription)");
		return PangoOTRulesetDescriptionExterns.pango_ot_ruleset_description_copy(desc);
	}

	public static bool Equal(this MentorLake.PangoOT.PangoOTRulesetDescriptionHandle desc1, MentorLake.PangoOT.PangoOTRulesetDescriptionHandle desc2)
	{
		if (desc1.IsInvalid || desc1.IsClosed) throw new Exception("Invalid or closed handle (PangoOTRulesetDescription)");
		return PangoOTRulesetDescriptionExterns.pango_ot_ruleset_description_equal(desc1, desc2);
	}

	public static void Free(this MentorLake.PangoOT.PangoOTRulesetDescriptionHandle desc)
	{
		if (desc.IsInvalid || desc.IsClosed) throw new Exception("Invalid or closed handle (PangoOTRulesetDescription)");
		PangoOTRulesetDescriptionExterns.pango_ot_ruleset_description_free(desc);
	}

	public static uint Hash(this MentorLake.PangoOT.PangoOTRulesetDescriptionHandle desc)
	{
		if (desc.IsInvalid || desc.IsClosed) throw new Exception("Invalid or closed handle (PangoOTRulesetDescription)");
		return PangoOTRulesetDescriptionExterns.pango_ot_ruleset_description_hash(desc);
	}


	public static PangoOTRulesetDescription Dereference(this PangoOTRulesetDescriptionHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<PangoOTRulesetDescription>(x.DangerousGetHandle());
}
internal class PangoOTRulesetDescriptionExterns
{
	[DllImport(PangoOTLibrary.Name)]
	internal static extern MentorLake.PangoOT.PangoOTRulesetDescriptionHandle pango_ot_ruleset_description_copy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.PangoOT.PangoOTRulesetDescriptionHandle>))] MentorLake.PangoOT.PangoOTRulesetDescriptionHandle desc);

	[DllImport(PangoOTLibrary.Name)]
	internal static extern bool pango_ot_ruleset_description_equal([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.PangoOT.PangoOTRulesetDescriptionHandle>))] MentorLake.PangoOT.PangoOTRulesetDescriptionHandle desc1, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.PangoOT.PangoOTRulesetDescriptionHandle>))] MentorLake.PangoOT.PangoOTRulesetDescriptionHandle desc2);

	[DllImport(PangoOTLibrary.Name)]
	internal static extern void pango_ot_ruleset_description_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.PangoOT.PangoOTRulesetDescriptionHandle>))] MentorLake.PangoOT.PangoOTRulesetDescriptionHandle desc);

	[DllImport(PangoOTLibrary.Name)]
	internal static extern uint pango_ot_ruleset_description_hash([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.PangoOT.PangoOTRulesetDescriptionHandle>))] MentorLake.PangoOT.PangoOTRulesetDescriptionHandle desc);

}

public struct PangoOTRulesetDescription
{
	public PangoScript script;
	public IntPtr language;
	public IntPtr static_gsub_features;
	public uint n_static_gsub_features;
	public IntPtr static_gpos_features;
	public uint n_static_gpos_features;
	public IntPtr other_features;
	public uint n_other_features;
}
