namespace MentorLake.Vulkan;

public class VkExternalMemoryHandleTypeFlagsHandle : BaseSafeHandle
{
}


public static class VkExternalMemoryHandleTypeFlagsExtensions
{

	public static VkExternalMemoryHandleTypeFlags Dereference(this VkExternalMemoryHandleTypeFlagsHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkExternalMemoryHandleTypeFlags>(x.DangerousGetHandle());
}
internal class VkExternalMemoryHandleTypeFlagsExterns
{
}

public struct VkExternalMemoryHandleTypeFlags
{
}
