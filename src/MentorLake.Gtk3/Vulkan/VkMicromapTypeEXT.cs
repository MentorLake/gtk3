namespace MentorLake.Vulkan;


public class VkMicromapTypeEXTHandle : BaseSafeHandle
{
}


public static class VkMicromapTypeEXTExtensions
{

	public static VkMicromapTypeEXT Dereference(this VkMicromapTypeEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkMicromapTypeEXT>(x.DangerousGetHandle());
}
internal class VkMicromapTypeEXTExterns
{
}


public struct VkMicromapTypeEXT
{
}
