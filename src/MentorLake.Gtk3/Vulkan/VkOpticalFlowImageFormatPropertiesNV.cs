namespace MentorLake.Vulkan;


public class VkOpticalFlowImageFormatPropertiesNVHandle : BaseSafeHandle
{
}


public static class VkOpticalFlowImageFormatPropertiesNVExtensions
{

	public static VkOpticalFlowImageFormatPropertiesNV Dereference(this VkOpticalFlowImageFormatPropertiesNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkOpticalFlowImageFormatPropertiesNV>(x.DangerousGetHandle());
}
internal class VkOpticalFlowImageFormatPropertiesNVExterns
{
}


public struct VkOpticalFlowImageFormatPropertiesNV
{
}
