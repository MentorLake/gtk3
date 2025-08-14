namespace MentorLake.Vulkan;


public class VkSemaphoreTypeCreateInfoHandle : BaseSafeHandle
{
}


public static class VkSemaphoreTypeCreateInfoExtensions
{

	public static VkSemaphoreTypeCreateInfo Dereference(this VkSemaphoreTypeCreateInfoHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkSemaphoreTypeCreateInfo>(x.DangerousGetHandle());
}
internal class VkSemaphoreTypeCreateInfoExterns
{
}


public struct VkSemaphoreTypeCreateInfo
{
}
