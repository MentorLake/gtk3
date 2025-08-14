namespace MentorLake.Vulkan;


public class VkOpacityMicromapFormatEXTHandle : BaseSafeHandle
{
}


public static class VkOpacityMicromapFormatEXTExtensions
{

	public static VkOpacityMicromapFormatEXT Dereference(this VkOpacityMicromapFormatEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkOpacityMicromapFormatEXT>(x.DangerousGetHandle());
}
internal class VkOpacityMicromapFormatEXTExterns
{
}


public struct VkOpacityMicromapFormatEXT
{
}
