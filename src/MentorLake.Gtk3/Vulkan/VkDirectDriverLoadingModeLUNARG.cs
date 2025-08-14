namespace MentorLake.Vulkan;


public class VkDirectDriverLoadingModeLUNARGHandle : BaseSafeHandle
{
}


public static class VkDirectDriverLoadingModeLUNARGExtensions
{

	public static VkDirectDriverLoadingModeLUNARG Dereference(this VkDirectDriverLoadingModeLUNARGHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDirectDriverLoadingModeLUNARG>(x.DangerousGetHandle());
}
internal class VkDirectDriverLoadingModeLUNARGExterns
{
}


public struct VkDirectDriverLoadingModeLUNARG
{
}
