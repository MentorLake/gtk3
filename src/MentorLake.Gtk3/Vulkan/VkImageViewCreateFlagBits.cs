namespace MentorLake.Vulkan;


public class VkImageViewCreateFlagBitsHandle : BaseSafeHandle
{
}


public static class VkImageViewCreateFlagBitsExtensions
{

	public static VkImageViewCreateFlagBits Dereference(this VkImageViewCreateFlagBitsHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkImageViewCreateFlagBits>(x.DangerousGetHandle());
}
internal class VkImageViewCreateFlagBitsExterns
{
}


public struct VkImageViewCreateFlagBits
{
}
