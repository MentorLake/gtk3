namespace MentorLake.Vulkan;

public class VkFormatHandle : BaseSafeHandle
{
}


public static class VkFormatExtensions
{

	public static VkFormat Dereference(this VkFormatHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkFormat>(x.DangerousGetHandle());
}
internal class VkFormatExterns
{
}

public struct VkFormat
{
}
