namespace MentorLake.Vulkan;

public class VkTextureLODGatherFormatPropertiesAMDHandle : BaseSafeHandle
{
}


public static class VkTextureLODGatherFormatPropertiesAMDExtensions
{

	public static VkTextureLODGatherFormatPropertiesAMD Dereference(this VkTextureLODGatherFormatPropertiesAMDHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkTextureLODGatherFormatPropertiesAMD>(x.DangerousGetHandle());
}
internal class VkTextureLODGatherFormatPropertiesAMDExterns
{
}

public struct VkTextureLODGatherFormatPropertiesAMD
{
}
