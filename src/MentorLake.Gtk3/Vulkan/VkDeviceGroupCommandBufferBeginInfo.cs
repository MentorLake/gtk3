namespace MentorLake.Vulkan;

public class VkDeviceGroupCommandBufferBeginInfoHandle : BaseSafeHandle
{
}


public static class VkDeviceGroupCommandBufferBeginInfoExtensions
{

	public static VkDeviceGroupCommandBufferBeginInfo Dereference(this VkDeviceGroupCommandBufferBeginInfoHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDeviceGroupCommandBufferBeginInfo>(x.DangerousGetHandle());
}
internal class VkDeviceGroupCommandBufferBeginInfoExterns
{
}

public struct VkDeviceGroupCommandBufferBeginInfo
{
}
