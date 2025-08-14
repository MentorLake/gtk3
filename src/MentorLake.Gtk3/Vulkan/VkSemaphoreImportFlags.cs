namespace MentorLake.Vulkan;


public class VkSemaphoreImportFlagsHandle : BaseSafeHandle
{
}


public static class VkSemaphoreImportFlagsExtensions
{

	public static VkSemaphoreImportFlags Dereference(this VkSemaphoreImportFlagsHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkSemaphoreImportFlags>(x.DangerousGetHandle());
}
internal class VkSemaphoreImportFlagsExterns
{
}


public struct VkSemaphoreImportFlags
{
}
