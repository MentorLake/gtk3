namespace MentorLake.Vulkan;


public class VkMemoryOpaqueCaptureAddressAllocateInfoKHRHandle : BaseSafeHandle
{
}


public static class VkMemoryOpaqueCaptureAddressAllocateInfoKHRExtensions
{

	public static VkMemoryOpaqueCaptureAddressAllocateInfoKHR Dereference(this VkMemoryOpaqueCaptureAddressAllocateInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkMemoryOpaqueCaptureAddressAllocateInfoKHR>(x.DangerousGetHandle());
}
internal class VkMemoryOpaqueCaptureAddressAllocateInfoKHRExterns
{
}


public struct VkMemoryOpaqueCaptureAddressAllocateInfoKHR
{
}
