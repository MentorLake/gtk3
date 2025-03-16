namespace MentorLake.Vulkan;

public class VkExternalFenceHandleTypeFlagBitsHandle : BaseSafeHandle
{
}


public static class VkExternalFenceHandleTypeFlagBitsExtensions
{

	public static VkExternalFenceHandleTypeFlagBits Dereference(this VkExternalFenceHandleTypeFlagBitsHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkExternalFenceHandleTypeFlagBits>(x.DangerousGetHandle());
}
internal class VkExternalFenceHandleTypeFlagBitsExterns
{
}

public struct VkExternalFenceHandleTypeFlagBits
{
}
