namespace MentorLake.Vulkan;


public class VkSemaphoreTypeHandle : BaseSafeHandle
{
}


public static class VkSemaphoreTypeExtensions
{

	public static VkSemaphoreType Dereference(this VkSemaphoreTypeHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkSemaphoreType>(x.DangerousGetHandle());
}
internal class VkSemaphoreTypeExterns
{
}


public struct VkSemaphoreType
{
}
