namespace MentorLake.Vulkan;

public class VkDeviceHandle : BaseSafeHandle
{
}


public static class VkDeviceExtensions
{

	public static VkDevice Dereference(this VkDeviceHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDevice>(x.DangerousGetHandle());
}
internal class VkDeviceExterns
{
}

public struct VkDevice
{
}
