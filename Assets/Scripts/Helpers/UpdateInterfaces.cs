/// <summary>
/// Root interface to add classes to GlobalUpdate system
/// </summary>
interface IUpdater
{
    void AddToUpdator();
    void RemoveFromUpdator();
}

/// <summary>
/// Use this interface to use custom Update instead of MonoBehaviour.Update()
/// </summary>
interface IUpdate : IUpdater
{
    /// <summary>
    /// Use this method instead of MonoBehaviour.Update()
    /// </summary>
    void GUpdate();
}

/// <summary>
/// Use this interface to use custom Update instead of MonoBehaviour.FixedUpdate()
/// </summary>
interface IFixedUpdate : IUpdater
{
    /// <summary>
    /// Use this method instead of MonoBehaviour.FixedUpdate()
    /// </summary>
    void GFixedUpdate();
}

/// <summary>
/// Use this interface to use custom Update instead of MonoBehaviour.LateUpdate()
/// </summary>
interface ILateUpdate : IUpdater
{
    /// <summary>
    /// Use this method instead of MonoBehaviour.LateUpdate()
    /// </summary>
    void GLateUpdate();
}
