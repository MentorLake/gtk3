namespace MentorLake.Vulkan;


public class VkCopyMicromapModeEXTHandle : BaseSafeHandle
{
}


public static class VkCopyMicromapModeEXTExtensions
{

	public static VkCopyMicromapModeEXT Dereference(this VkCopyMicromapModeEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkCopyMicromapModeEXT>(x.DangerousGetHandle());
}
internal class VkCopyMicromapModeEXTExterns
{
}


public struct VkCopyMicromapModeEXT
{
}
