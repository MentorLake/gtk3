namespace MentorLake.Vulkan;

public class VkExternalMemoryBufferCreateInfoHandle : BaseSafeHandle
{
}


public static class VkExternalMemoryBufferCreateInfoExtensions
{

	public static VkExternalMemoryBufferCreateInfo Dereference(this VkExternalMemoryBufferCreateInfoHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkExternalMemoryBufferCreateInfo>(x.DangerousGetHandle());
}
internal class VkExternalMemoryBufferCreateInfoExterns
{
}

public struct VkExternalMemoryBufferCreateInfo
{
}
