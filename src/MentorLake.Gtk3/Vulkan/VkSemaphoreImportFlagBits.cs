namespace MentorLake.Vulkan;


public class VkSemaphoreImportFlagBitsHandle : BaseSafeHandle
{
}


public static class VkSemaphoreImportFlagBitsExtensions
{

	public static VkSemaphoreImportFlagBits Dereference(this VkSemaphoreImportFlagBitsHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkSemaphoreImportFlagBits>(x.DangerousGetHandle());
}
internal class VkSemaphoreImportFlagBitsExterns
{
}


public struct VkSemaphoreImportFlagBits
{
}
