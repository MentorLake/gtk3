namespace MentorLake.Vulkan;

public class VkMemoryOpaqueCaptureAddressAllocateInfoHandle : BaseSafeHandle
{
}


public static class VkMemoryOpaqueCaptureAddressAllocateInfoExtensions
{

	public static VkMemoryOpaqueCaptureAddressAllocateInfo Dereference(this VkMemoryOpaqueCaptureAddressAllocateInfoHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkMemoryOpaqueCaptureAddressAllocateInfo>(x.DangerousGetHandle());
}
internal class VkMemoryOpaqueCaptureAddressAllocateInfoExterns
{
}

public struct VkMemoryOpaqueCaptureAddressAllocateInfo
{
}
