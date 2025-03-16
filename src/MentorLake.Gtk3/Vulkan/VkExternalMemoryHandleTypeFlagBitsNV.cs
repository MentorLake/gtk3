namespace MentorLake.Vulkan;

public class VkExternalMemoryHandleTypeFlagBitsNVHandle : BaseSafeHandle
{
}


public static class VkExternalMemoryHandleTypeFlagBitsNVExtensions
{

	public static VkExternalMemoryHandleTypeFlagBitsNV Dereference(this VkExternalMemoryHandleTypeFlagBitsNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkExternalMemoryHandleTypeFlagBitsNV>(x.DangerousGetHandle());
}
internal class VkExternalMemoryHandleTypeFlagBitsNVExterns
{
}

public struct VkExternalMemoryHandleTypeFlagBitsNV
{
}
