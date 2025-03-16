namespace MentorLake.Vulkan;

public class VkExternalFenceHandleTypeFlagsHandle : BaseSafeHandle
{
}


public static class VkExternalFenceHandleTypeFlagsExtensions
{

	public static VkExternalFenceHandleTypeFlags Dereference(this VkExternalFenceHandleTypeFlagsHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkExternalFenceHandleTypeFlags>(x.DangerousGetHandle());
}
internal class VkExternalFenceHandleTypeFlagsExterns
{
}

public struct VkExternalFenceHandleTypeFlags
{
}
