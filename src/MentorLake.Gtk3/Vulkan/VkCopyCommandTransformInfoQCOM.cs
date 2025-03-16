namespace MentorLake.Vulkan;

public class VkCopyCommandTransformInfoQCOMHandle : BaseSafeHandle
{
}


public static class VkCopyCommandTransformInfoQCOMExtensions
{

	public static VkCopyCommandTransformInfoQCOM Dereference(this VkCopyCommandTransformInfoQCOMHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkCopyCommandTransformInfoQCOM>(x.DangerousGetHandle());
}
internal class VkCopyCommandTransformInfoQCOMExterns
{
}

public struct VkCopyCommandTransformInfoQCOM
{
}
