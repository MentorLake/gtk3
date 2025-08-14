namespace MentorLake.Vulkan;


public class VkShadingRatePaletteEntryNVHandle : BaseSafeHandle
{
}


public static class VkShadingRatePaletteEntryNVExtensions
{

	public static VkShadingRatePaletteEntryNV Dereference(this VkShadingRatePaletteEntryNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkShadingRatePaletteEntryNV>(x.DangerousGetHandle());
}
internal class VkShadingRatePaletteEntryNVExterns
{
}


public struct VkShadingRatePaletteEntryNV
{
}
