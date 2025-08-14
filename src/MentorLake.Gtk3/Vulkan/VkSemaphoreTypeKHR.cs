namespace MentorLake.Vulkan;


public class VkSemaphoreTypeKHRHandle : BaseSafeHandle
{
}


public static class VkSemaphoreTypeKHRExtensions
{

	public static VkSemaphoreTypeKHR Dereference(this VkSemaphoreTypeKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkSemaphoreTypeKHR>(x.DangerousGetHandle());
}
internal class VkSemaphoreTypeKHRExterns
{
}


public struct VkSemaphoreTypeKHR
{
}
