using UnityEngine;

/// <summary>
/// Factory scene context. Spawn player and other scene preparing.
/// </summary>
[DefaultExecutionOrder(-1)]
public class FactoryContext : BaseContext<ServiceInitializer>
{
    /// <inheritdoc/>
    protected override void Initialize(IServiceContainer serviceResolver)
    {
    }

    /// <inheritdoc/>
    protected override void Deinitialize()
    {

    }
}
