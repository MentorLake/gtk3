namespace MentorLake.Vulkan;

public class VkExternalMemoryHandleTypeFlagBitsHandle : BaseSafeHandle
{
}


public static class VkExternalMemoryHandleTypeFlagBitsExtensions
{

	public static VkExternalMemoryHandleTypeFlagBits Dereference(this VkExternalMemoryHandleTypeFlagBitsHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkExternalMemoryHandleTypeFlagBits>(x.DangerousGetHandle());
}
internal class VkExternalMemoryHandleTypeFlagBitsExterns
{
}

public struct VkExternalMemoryHandleTypeFlagBits
{
}
