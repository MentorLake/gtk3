namespace MentorLake.Vulkan;


public class VkExternalMemoryHandleTypeFlagsNVHandle : BaseSafeHandle
{
}


public static class VkExternalMemoryHandleTypeFlagsNVExtensions
{

	public static VkExternalMemoryHandleTypeFlagsNV Dereference(this VkExternalMemoryHandleTypeFlagsNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkExternalMemoryHandleTypeFlagsNV>(x.DangerousGetHandle());
}
internal class VkExternalMemoryHandleTypeFlagsNVExterns
{
}


public struct VkExternalMemoryHandleTypeFlagsNV
{
}
